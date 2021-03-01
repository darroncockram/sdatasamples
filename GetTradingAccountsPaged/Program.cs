using System;
using System.Collections.Generic;
using System.Text;
using Sage.Common.Syndication;
using Sage.Integration.Client;
using Sage.crmErp.x2008.Feeds;
using Helpers;

namespace GetTradingAccountsPaged
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

            long processed = 0;

            do
            {
                uri.StartIndex = processed + 1;

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
                    // Ensure we actually got some results
                    if (feed.Entries == null || feed.Entries.Count == 0)
                    {
                        Console.WriteLine("No more records");
                        break;
                    }

                    // Display the feed data
                    Console.WriteLine("Retrieved records {0} to {1} of {2} trading accounts", processed + 1, feed.Entries.Count + processed, feed.TotalResults);
                    foreach (tradingAccountFeedEntry entry in feed.Entries)
                    {
                        Console.WriteLine(entry.name);
                        ++processed;
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

                    break;
                }

                Console.WriteLine(string.Empty);
                Console.WriteLine("Continue? (Y/N):");
                bool stopProcessing = (Console.ReadKey(true).Key != ConsoleKey.Y);

                // Check if we have processed all the records or the user has aborted
                if (stopProcessing || !feed.TotalResults.HasValue || processed >= feed.TotalResults.Value)
                {
                    break;
                }
            }
            while (true);

            Console.WriteLine(string.Empty);
            Console.WriteLine("Processing complete");
            Console.ReadKey(true);
        }
    }
}
