using System;
using System.Collections.Generic;
using System.Text;
using Helpers;
using Sage.Common.Syndication;
using Sage.crmErp.x2008.Feeds;

namespace GetTradingAccountTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Authentication.GetUserName();
            string password = Authentication.GetPassword();

            // Create a new instance of a trading account this will be populated with default values
            tradingAccountFeedEntry templateAccount = new tradingAccountFeedEntry();

            // Build the request URI. This example assumes that the Accounts 50 GCRM contract implementation is available
            SDataUri uri = new SDataUri();
            uri.BuildLocalPath("Accounts50", "GCRM", "-", "tradingAccounts", "$template");

            // Build an Sdata request from the URI
            Sage.Integration.Client.SDataRequest request = new Sage.Integration.Client.SDataRequest(uri.Uri)
            {
                AllowPromptForCredentials = false,
                Username = userName,
                Password = password
            };

            // Submit the request for trading accounts
            request.RequestFeedEntry<tradingAccountFeedEntry>(templateAccount);

            if (request.IsStatusValidForVerb)
            {
                // Display some properties that have been set to default values
                Console.WriteLine("Title: {0}. Currency: {1}.", templateAccount.Title, templateAccount.currency);
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
