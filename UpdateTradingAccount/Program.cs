using System;
using System.Collections.Generic;
using System.Text;
using Helpers;
using Sage.Common.Syndication;
using Sage.crmErp.x2008.Feeds;
using Sage.Integration.Client;
using Sage.sc.x2009.Feeds;

namespace UpdateTradingAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Authentication.GetUserName();
            string password = Authentication.GetPassword();

            // Get a customer to attempt to use in the update
            tradingAccountFeedEntry account = GetCustomer(userName, password);

            Console.WriteLine("Current trading account name is '{0}'", account.name);
            Console.WriteLine("Please enter a new name:");

			account.name = Console.ReadLine();

            // An update is an HTTP PUT
            SDataRequest updateRequest = new SDataRequest(new Uri(account.Uri), account, Sage.Integration.Messaging.Model.RequestVerb.PUT)
            {
                AllowPromptForCredentials = false,
                Username = userName,
                Password = password
            };
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
        
        static tradingAccountFeedEntry GetCustomer(string userName, string password)
        {
            // Look up the first customer record 
            SDataUri accountUri = new SDataUri();
            accountUri.BuildLocalPath("Accounts50", "GCRM", "-", "tradingAccounts");
            accountUri.Where = "customerSupplierFlag eq 'Customer'";
            accountUri.Count = 1;

            SDataRequest accountRequest = new SDataRequest(accountUri.Uri)
            {
                Username = userName,
                Password = password
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
