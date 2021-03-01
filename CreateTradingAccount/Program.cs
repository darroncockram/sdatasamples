using System;
using System.Collections.Generic;
using System.Text;
using Sage.crmErp.x2008.Feeds;
using Sage.Integration.Client;
using Sage.Common.Syndication;
using Helpers;

namespace CreateTradingAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Authentication.GetUserName();
            string password = Authentication.GetPassword();

            // Create a new instance of a trading account 
            tradingAccountFeedEntry account = new tradingAccountFeedEntry();
            
            // Prompt for a customer name to use
            Console.WriteLine("Please a name for the new customer:");

            // Update the name
            account.name = Console.ReadLine();

            // required field
            account.customerSupplierFlag = "Customer";

            // Build the request URI. This example assumes that the Accounts 50 GCRM contract implementation is available
            SDataUri uri = new SDataUri();
            uri.BuildLocalPath("Accounts50", "GCRM", "-", "tradingAccounts");

            // Build an create request.
            // NOTE an create is an HTTP POST
            SDataRequest createRequest = new SDataRequest(uri.Uri, account, Sage.Integration.Messaging.Model.RequestVerb.POST)
            {
                AllowPromptForCredentials = false,
                Username = userName,
                Password = password
            };

            // Submit the create request
            //createRequest.Send();
            tradingAccountFeedEntry newAccount = new tradingAccountFeedEntry();
            createRequest.RequestFeedEntry<tradingAccountFeedEntry>(newAccount);

            if (createRequest.IsStatusValidForVerb)
            {
				Console.WriteLine("Account created with a reference of {0}", newAccount.reference);
            }
            else
            {
                // There was a problem
                Console.WriteLine("Request failed. Response was {0}", createRequest.HttpStatusCode.ToString());
                foreach (Diagnosis diagnosis in createRequest.Diagnoses)
                {
                    Console.WriteLine(diagnosis.Message);
                }
            }

            Console.ReadKey(true);
        }
    }
}