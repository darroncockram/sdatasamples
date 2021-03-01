using System;
using System.Collections.Generic;
using System.Text;
using Sage.crmErp.x2008.Feeds;
using Sage.Common.Syndication;
using Sage.Integration.Client;
using Helpers;

namespace QueryForTradingAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Authentication.GetUserName();
            string password = Authentication.GetPassword();

            Console.Write("Please enter a reference to search for: ");
            string search = Console.ReadLine();

            // Create a new instance of an endpoint feed.
            tradingAccountFeed feed = new tradingAccountFeed();

            // Build the request URI. This example assumes that the Accounts 50 GCRM contract implementation is available
            SDataUri uri = new SDataUri();
            uri.BuildLocalPath("Accounts50", "GCRM", "-", "tradingAccounts");
            // Set the query based on the user input
            uri.Where = string.Format("reference eq '{0}'", search);

            // Build an Sdata request from the URI
            SDataRequest request = new SDataRequest(uri.Uri)
            {
                AllowPromptForCredentials = false,
                Username = userName,
                Password = password
            };

            // Submit the request for trading accounts
            request.RequestFeed<tradingAccountFeedEntry>(feed);

            if (request.IsStatusValidForVerb)
            {
                // Display the feed data
                Console.WriteLine("{0} matching records found", feed.TotalResults);
                foreach (tradingAccountFeedEntry entry in feed.Entries)
                {
                    Console.WriteLine(entry.name);
                }
            }
            else
            {
                // There was a problem
                Console.WriteLine("Request failed. Response was {0}", request.HttpStatusCode.ToString());
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
    }
}
