using System;
using System.Collections.Generic;
using System.Text;
using Sage.crmErp.x2008.Feeds;
using Sage.Common.Syndication;
using Sage.Integration.Client;
using Helpers;

namespace GetTradingAccounts
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Authentication.GetUserName();
            string password = Authentication.GetPassword();

            // Build the request URI. This example assumes that the Accounts 50 GCRM contract implementation is available
            SDataUri uri = new SDataUri();
            uri.BuildLocalPath("Accounts50", "GCRM", "-", "tradingAccounts");
            // There could potentially be a very large number of records so we just request up to the first 10 
            uri.Count = 10;

            // Build an Sdata request from the URI
            SDataRequest request = new SDataRequest(uri.Uri)
            {
                AllowPromptForCredentials = false,
                Username = userName,
                Password = password,
                ResponseContentType = Sage.Common.Syndication.MediaType.JSON
            };

            // Create a new instance of an endpoint feed.
            tradingAccountFeed feed = new tradingAccountFeed();
            // Submit the request for trading accounts
            request.RequestFeed<tradingAccountFeedEntry>(feed);

            if (request.IsStatusValidForVerb)
            {
                // Display the feed data
                Console.WriteLine("Retrieved {0} of {1} trading accounts", feed.Entries.Count, feed.TotalResults);
                foreach (tradingAccountFeedEntry entry in feed.Entries)
                {
                    Console.WriteLine(entry.name);
                }
            }
            else
            {
                // There was a problem
                Console.WriteLine("Request failed. Response was {0}", request.HttpStatusCode.ToString());
                foreach (Diagnosis diagnosis in request.Diagnoses)
                {
                    Console.WriteLine(diagnosis.Message);
                }
            }

            Console.ReadKey(true);
        }
    }
}
