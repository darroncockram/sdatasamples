using Helpers;
using Sage.Common.Syndication;
using Sage.crmErp.x2008.Feeds;
using Sage.Integration.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateCommodity
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Authentication.GetUserName();
            string password = Authentication.GetPassword();

            // Create a new instance of a trading account 
            commodityFeedEntry commodity = new commodityFeedEntry();

            // Prompt for a customer name to use
            Console.WriteLine("Please a name for the new commodity:");

            // Set the name
            commodity.name = Console.ReadLine();
            commodity.reference = "A-123"; // Hard coded but could also prompt

            // Build the request URI. This example assumes that the Accounts 50 GCRM contract implementation is available
            SDataUri uri = new SDataUri();
            uri.BuildLocalPath("Accounts50", "GCRM", "-", "commodities");

            // Build an create request.
            // NOTE an create is an HTTP POST
            SDataRequest createRequest = new SDataRequest(uri.Uri, commodity, Sage.Integration.Messaging.Model.RequestVerb.POST)
            {
                AllowPromptForCredentials = false,
                Username = userName,
                Password = password
            };

            // Submit the create request
            commodityFeedEntry newCommodity = new commodityFeedEntry();
            createRequest.RequestFeedEntry<commodityFeedEntry>(newCommodity);

            if (createRequest.IsStatusValidForVerb)
            {
                Console.WriteLine("Commodity created with a reference of {0}", newCommodity.reference);
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
