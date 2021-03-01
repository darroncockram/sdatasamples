using System;
using System.Collections.Generic;
using System.Text;
using Sage.Integration.Client;
using Sage.crmErp.x2008.Feeds;
using Sage.sc.x2009.Feeds;
using Sage.Common.Syndication;
using Helpers;

namespace DeleteTradingAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Authentication.GetUserName();
            string password = Authentication.GetPassword();

            // Get a customer to attempt to delete
            tradingAccountFeedEntry account = GetCustomer(userName, password);

            // Build an Sdata request from the trading account URI
            SDataRequest deleteRequest = new SDataRequest(new Uri(account.Uri), Sage.Integration.Messaging.Model.RequestVerb.DELETE)
            {
                AllowPromptForCredentials = false,
                Username = userName,
                Password = password
            };

            deleteRequest.Send();

            if (deleteRequest.IsStatusValidForVerb)
            {
                Console.WriteLine("Successfully deleted trading account");
            }
            else
            {
                Console.WriteLine("failed to delete trading account. Response was {0}", deleteRequest.HttpStatusCode.ToString());
                foreach (Diagnosis diagnosis in deleteRequest.Diagnoses)
                {
                    Console.WriteLine(diagnosis.Message);
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
                foreach (Diagnosis diagnosis in accountRequest.Diagnoses)
                {
                    Console.WriteLine(diagnosis.Message);
                }

                return null;
            }
        }
    }
}
