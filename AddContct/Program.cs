using System;
using System.Collections.Generic;
using System.Text;
using Sage.Common.Syndication;
using Sage.crmErp.x2008.Feeds;
using Sage.Integration.Client;

namespace CreateSalesInvoice
{
	class Program
	{
		static void Main(string[] args)
		{
			// Create a new instance of a contactFeedEntry
			contactFeedEntry contact = new contactFeedEntry();

			// Find a customer to associate with the new sales invoice
			tradingAccountFeedEntry tradingAccount = GetCustomer();

			if (tradingAccount == null)
			{
				// No customer record means we can go no further
				Console.WriteLine("Unable to find a customer record");
				Console.ReadKey(true);
				return;
			}

			contact.firstName = "Test";
			contact.familyName = "Person";
			contact.tradingAccount = new tradingAccountFeedEntry() { UUID = tradingAccount.UUID };
			contact.type = "Customer Delivery Contact";
			
			
			// Now we have constructed our new invoice we can submit it using the HTTP POST verb  
			SDataUri salesInvoiceUri = new SDataUri();
			salesInvoiceUri.BuildLocalPath("Accounts50", "GCRM", "-", "contacts");

            SDataRequest request = new SDataRequest(salesInvoiceUri.Uri, contact, Sage.Integration.Messaging.Model.RequestVerb.POST)
            {
                Username = "MANAGER",
                Password = ""
            };

            // If successful the POST operation will provide us with a the newly created sales invoice
            contactFeedEntry savedContact = new contactFeedEntry();
			request.RequestFeedEntry<contactFeedEntry>(savedContact);

			if (request.IsStatusValidForVerb)
			{
				Console.WriteLine(string.Format("Successfully created contact {0}", savedContact.UUID));
			}
			else
			{
				// There was a problem
				Console.WriteLine("Create failed. Response was {0}", request.HttpStatusCode.ToString());
				if (request.Diagnoses != null)
				{
                    foreach (Diagnosis diagnosis in request.Diagnoses)
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
                        Console.WriteLine(diagnosis.Message);
                }

                return null;
            }
		}
	}
}
