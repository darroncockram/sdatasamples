using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sage.Common.Syndication;
using Sage.crmErp.x2008.Feeds;
using Sage.Integration.Client;

namespace CreateServiceInvoice
{
	class Program
	{
		static void Main(string[] args)
		{
			// Create a new instance of a salesInvoice
			salesInvoiceFeedEntry salesInvoice = new salesInvoiceFeedEntry
			{
				// This property determines that it is a service invoice as opposed to a product invoice
				type = "Service Invoice",

				// Find a customer to associate with the new sales invoice
				tradingAccount = GetCustomer()
			};

			if (salesInvoice.tradingAccount == null)
			{
				// No customer record means we can go no further
				Console.WriteLine("Unable to find a customer record");
				Console.ReadKey(true);
				return;
			}

			salesInvoice.carrierTotalPrice = 100;
			salesInvoice.carrierTaxPrice = 20;
			salesInvoice.carrierNetPrice = 80;

			// Create another invoice line this time as free text
			salesInvoiceLineFeedEntry serviceOrderLine = new salesInvoiceLineFeedEntry
			{
				type = "Free Text", // Equivalent to S1 stock code
				text = "An example\r\n service",
				quantity = 5,
				netTotal = 100,
				taxTotal = 20,
				grossTotal = 120,
				taxCodes = new taxCodeFeed()
			};

			// Associate the lines with our invoice
			salesInvoice.salesInvoiceLines = new salesInvoiceLineFeed();
			salesInvoice.salesInvoiceLines.Entries.Add(serviceOrderLine);

			// Create a delivery contact 
			salesInvoice.buyerContact = new contactFeedEntry
			{
				fullName = "Joe Bloggs"
			};

			// Now we have constructed our new invoice we can submit it using the HTTP POST verb  
			SDataUri salesInvoiceUri = new SDataUri();
			salesInvoiceUri.BuildLocalPath("Accounts50", "GCRM", "-", "salesInvoices");
			SDataRequest invoiceRequest = new SDataRequest(salesInvoiceUri.Uri, salesInvoice, Sage.Integration.Messaging.Model.RequestVerb.POST)
			{
				Username = "MANAGER",
				Password = ""
			};

			// IF successful the POST operation will provide us with a the newly created sales invoice
			salesInvoiceFeedEntry savedSalesInvoice = new salesInvoiceFeedEntry();
			invoiceRequest.RequestFeedEntry<salesInvoiceFeedEntry>(savedSalesInvoice);

			if (invoiceRequest.IsStatusValidForVerb)
			{
				Console.WriteLine(string.Format("Successfully created sales invoice {0}", savedSalesInvoice.reference));
			}
			else
			{
				// There was a problem
				Console.WriteLine("Create failed. Response was {0}", invoiceRequest.HttpStatusCode.ToString());
				if (invoiceRequest.Diagnoses != null)
				{
					foreach (Diagnosis diagnosis in invoiceRequest.Diagnoses)
					{
						Console.WriteLine(diagnosis.Message);
					}
				}
			}

			Console.ReadKey(true);
		}

		static tradingAccountFeedEntry GetCustomer()
		{
			// Look up the first customer record 
			SDataUri accountUri = new SDataUri();
			accountUri.BuildLocalPath("Accounts50", "GCRM", "-", "tradingAccounts");
			accountUri.Where = "customerSupplierFlag eq 'Customer'";
			accountUri.Count = 1;

			SDataRequest accountRequest = new SDataRequest(accountUri.Uri)
			{
				AllowPromptForCredentials = false,
				Username = "MANAGER",
				Password = ""
			};

			tradingAccountFeed accounts = new tradingAccountFeed();
			accountRequest.RequestFeed<tradingAccountFeedEntry>(accounts);

			// If we found a customer record return it
			if (accountRequest.IsStatusValidForVerb && accounts.Entries != null && accounts.Entries.Count > 0)
			{
				return accounts.Entries[0];
			}
			else
			{
				// There was a problem
				Console.WriteLine("Account lookup failed. Response was {0}", accountRequest.HttpStatusCode.ToString());
				if (accountRequest.Diagnoses != null)
				{
					foreach (Diagnosis diagnosis in accountRequest.Diagnoses)
					{
						Console.WriteLine(diagnosis.Message);
					}
				}

				return null;
			}
		}

	}
}
