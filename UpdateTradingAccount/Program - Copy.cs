using System;
using System.Collections.Generic;
using System.Text;
using Sage.Common.Syndication;
using Sage.crmErp.x2008.Feeds;
using Sage.Integration.Client;

namespace UpdateTradingAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get a customer to attempt to use in the update
            tradingAccountFeedEntry account = GetCustomer();

            Console.WriteLine("Current trading account name is '{0}'", account.name);
            Console.WriteLine("Please enter a new name:");

            account.name = Console.ReadLine();

            // An update is an HTTP PUT
            SDataRequest updateRequest = new SDataRequest(new Uri(account.Uri), account, Sage.Integration.Messaging.Model.RequestVerb.PUT);
            updateRequest.AllowPromptForCredentials = false;
            updateRequest.Username = "MANAGER";
            updateRequest.Password = string.Empty;
            updateRequest.Send();

            if (updateRequest.IsStatusValidForVerb)
            {
                Console.WriteLine("Successfully updated");
            }
            else
            {
                Console.WriteLine("Failed to update trading account. Response was {0}", updateRequest.HttpStatusCode.ToString());
				if (updateRequest.Diagnoses != null)
				{
					foreach (Diagnosis diagnosis in updateRequest.Diagnoses)
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
            Sage.Common.Syndication.SDataUri accountUri = new Sage.Common.Syndication.SDataUri();
            accountUri.BuildLocalPath("Accounts50", "GCRM", "-", "tradingAccounts");
            accountUri.Where = "customerSupplierFlag eq 'Customer'";
            accountUri.Count = 1;

            SDataRequest accountRequest = new SDataRequest(accountUri.Uri);
            accountRequest.Username = "MANAGER";
            accountRequest.Password = "";

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
