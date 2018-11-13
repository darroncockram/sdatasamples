using Sage.Common.Syndication;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiscoverDatasetsForContract
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new instance of an endpoint feed.
            Sage.Common.Syndication.EndPointFeed feed = new Sage.Common.Syndication.EndPointFeed();

            // Build the request URI
            const string contract = "GCRM";
            SDataUri uri = new SDataUri();
            uri.BuildLocalPath("$system", "registry", "*", "endpoints");
            uri.Where = string.Format("endPointType eq 'dataSet' AND ContractName eq '{0}'", contract);

            // Build an Sdata request from the URI
            Sage.Integration.Client.SDataRequest request = new Sage.Integration.Client.SDataRequest(uri.Uri);

            // Request the end point feed data
            request.RequestFeed<Sage.Common.Syndication.EndPointEntry>(feed);

            if (request.IsStatusValidForVerb)
            {
                // Display the feed data
                foreach (Sage.Common.Syndication.EndPointEntry entry in feed.Entries)
                {
                    Console.WriteLine("{0} - {1}", entry.DataSetName.Trim(), entry.Url);
                }
            }
            else
            {
                Console.WriteLine("Failed to retrieve endpoints.");
            }

            Console.ReadKey(true);
        }
    }
}
