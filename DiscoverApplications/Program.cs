using Sage.Common.Syndication;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiscoverApplications
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new instance of an endpoint feed.
            Sage.Common.Syndication.EndPointFeed feed = new Sage.Common.Syndication.EndPointFeed();

            // Build the request URI
            SDataUri uri = new SDataUri();
            uri.BuildLocalPath("$system", "registry", "*", "endpoints");
            uri.Where = "endPointType eq 'application'";

            // Build an Sdata request from the URI
            Sage.Integration.Client.SDataRequest request = new Sage.Integration.Client.SDataRequest(uri.Uri);

            // Request the end point feed data
            request.RequestFeed<Sage.Common.Syndication.EndPointEntry>(feed);

            // Display the feed data
            foreach (Sage.Common.Syndication.EndPointEntry entry in feed.Entries)
            {
                Console.WriteLine(entry.ApplicationName);
            }

            Console.ReadKey(true);
        }
    }
}
