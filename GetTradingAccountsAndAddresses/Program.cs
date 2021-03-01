using System;
using System.Collections.Generic;
using System.Text;
using Sage.crmErp.x2008.Feeds;
using Sage.Common.Syndication;
using Sage.Integration.Client;
using Helpers;

namespace GetTradingAccountsAndAddresses
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Authentication.GetUserName();
            string password = Authentication.GetPassword();

            // Create a new instance of an endpoint feed.
            tradingAccountFeed feed = new tradingAccountFeed();

            // Build the request URI. This example assumes that the Accounts 50 GCRM contract implementation is available
            SDataUri uri = new SDataUri();
            uri.BuildLocalPath("Accounts50", "GCRM", "-", "tradingAccounts");
            // There could potentially be a very large number of records so we just request up to the first 10 
            uri.Count = 10;

            // Request that the registered address to be included in the response
            // NOTE: Use the include parameter with caution. Requesting a large number of related 
            // resources or doing so for large number of parent records can cause a performance bottleneck.
            uri.Include = "registeredAddress";

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
                Console.WriteLine("Retrieved {0} of {1} trading accounts", feed.Entries.Count, feed.TotalResults);
                foreach (tradingAccountFeedEntry account in feed.Entries)
                {
                    Console.WriteLine("{0} - {1}", account.name, account.registeredAddress.address1);
                }
            }
            else
            {
                // There was a problem
                Console.WriteLine("Request failed. Response was {0}", request.HttpStatusCode.ToString());
				if (request.Diagnoses != null)
				{
					foreach (Diagnosis diagnosis in request.Diagnoses)
						Console.WriteLine(diagnosis.Message);
				}
            }

            Console.ReadKey(true);
        }
    }
}
