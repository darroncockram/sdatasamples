using System;
using System.Collections.Generic;
using System.Text;
using Sage.crmErp.x2008.Feeds;
using Sage.Integration.Client;
using Sage.Common.Syndication;

namespace GetRelatedSalesInvoices
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find a customer to associate with the new sales invoice
            tradingAccountFeedEntry account = GetCustomer();

            if (account == null)
            {
                // No customer record means we can go no further
                Console.WriteLine("Unable to find a customer record");
                Console.ReadKey(true);
                return;
            }

            SDataUri accountUri = new SDataUri(account.Uri);
            accountUri.AppendPath("salesInvoices");
            // Ensure the correct media type is set on the request
            accountUri.Format = Sage.Common.Syndication.MediaType.Atom;

            // Build an Sdata request from the URI
            SDataRequest invoiceRequest = new SDataRequest(accountUri.Uri)
            {
                AllowPromptForCredentials = false, // Do not show any UI
                Username = "MANAGER",
                Password = string.Empty
            };

            salesInvoiceFeed invoices = new salesInvoiceFeed();
            invoiceRequest.RequestFeed<salesInvoiceFeedEntry>(invoices);

            if (invoiceRequest.IsStatusValidForVerb)
            {
                if (invoices.Entries != null)
                {
                    Console.WriteLine("Request successful. Found {0} invoices for {1}.", invoices.Entries.Count, account.name);
                    foreach (salesInvoiceFeedEntry invoice in invoices.Entries)
                    {
                        Console.WriteLine("Found invoice {0}", invoice.reference);
                    }
                }
                else
                {
                    Console.WriteLine("Request successful. Found 0 invoices.");
                }
            }
            else
            {
                // There was a problem
                Console.WriteLine("Request failed. Response was {0}", invoiceRequest.HttpStatusCode.ToString());
                foreach (Diagnosis diagnosis in invoiceRequest.Diagnoses)
                {
                    Console.WriteLine(diagnosis.Message);
                }
            }

            Console.ReadKey(true);
        }

        static tradingAccountFeedEntry GetCustomer()
        {
            // Look up the first customer record 
            SDataUri accountUri = new SDataUri();
            accountUri.BuildLocalPath("Accounts50", "GCRM", "-", "tradingAccounts");
            accountUri.Where = "customerSupplierFlag eq 'Customer'";
            accountUri.Count = 1;

            SDataRequest accountRequest = new SDataRequest(accountUri.Uri)
            {
                Username = "MANAGER",
                Password = ""
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
