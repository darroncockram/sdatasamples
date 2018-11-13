using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sage.Common.Syndication;
using Sage.crmErp.x2008.Feeds;
using Sage.Integration.Client;

namespace CreateServiceCredit
{
	class Program
	{
		private const string HOST_NAME = "Win7VM";

		static void Main(string[] args)
		{
            // Create a new instance of a salesCredit
            salesCreditFeedEntry salesCredit = new salesCreditFeedEntry
            {
                // This property determines that it is a service Credit as opposed to a product Credit
                type = "Service Credit",

                // Find a customer to associate with the new sales Credit
                tradingAccount = GetCustomer()
            };

            if (salesCredit.tradingAccount == null)
			{
				// No customer record means we can go no further
				Console.WriteLine("Unable to find a customer record");
				Console.ReadKey(true);
				return;
			}

			salesCredit.carrierTotalPrice = 100;
			salesCredit.carrierTaxPrice = 20;
			salesCredit.carrierNetPrice = 80;

            // Create another Credit line this time as free text
            salesCreditLineFeedEntry serviceOrderLine = new salesCreditLineFeedEntry
            {
                type = "Free Text", // Equivalent to S1 stock code
                text = "An example\r\n service",
                quantity = 5,
                netTotal = 100,
                taxTotal = 20,
                grossTotal = 120,
                taxCodes = new taxCodeFeed()
            };

            // Associate the lines with our Credit
            salesCredit.salesCreditLines = new salesCreditLineFeed();
			salesCredit.salesCreditLines.Entries.Add(serviceOrderLine);

            // Create a delivery contact 
            salesCredit.buyerContact = new contactFeedEntry
            {
                fullName = "Joe Bloggs"
            };

            // Now we have constructed our new Credit we can submit it using the HTTP POST verb  
            SDataUri salesCreditUri = new SDataUri();
			salesCreditUri.BuildLocalPath("Accounts50", "GCRM", "-", "salesCredits");
			salesCreditUri.Host = HOST_NAME;
            SDataRequest CreditRequest = new SDataRequest(salesCreditUri.Uri, salesCredit, Sage.Integration.Messaging.Model.RequestVerb.POST)
            {
                Username = "MANAGER",
                Password = "1"
            };

            // IF successful the POST operation will provide us with a the newly created sales Credit
            salesCreditFeedEntry savedSalesCredit = new salesCreditFeedEntry();
			CreditRequest.RequestFeedEntry<salesCreditFeedEntry>(savedSalesCredit);

			if (CreditRequest.IsStatusValidForVerb)
			{
				Console.WriteLine(string.Format("Successfully created sales Credit {0}", savedSalesCredit.reference));
			}
			else
			{
				// There was a problem
				Console.WriteLine("Create failed. Response was {0}", CreditRequest.HttpStatusCode.ToString());
				if (CreditRequest.Diagnoses != null)
				{
					foreach (Diagnosis diagnosis in CreditRequest.Diagnoses)
						Console.WriteLine(diagnosis.Message);
				}
			}

			Console.ReadKey(true);
		}

		static tradingAccountFeedEntry GetCustomer()
		{
			// Look up the first customer record 
			SDataUri accountUri = new SDataUri();
			accountUri.BuildLocalPath("Accounts50", "GCRM", "-", "tradingAccounts");
			accountUri.Host = HOST_NAME;
			accountUri.Where = "customerSupplierFlag eq 'Customer'";
			accountUri.Count = 1;

            SDataRequest accountRequest = new SDataRequest(accountUri.Uri)
            {
                AllowPromptForCredentials = false,
                Username = "MANAGER",
                Password = "1"
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
