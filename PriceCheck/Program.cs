using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Helpers;
using Sage.Common.Syndication;
using Sage.crmErp.x2008.Feeds;
using Sage.Integration.Client;
using Sage.Integration.Messaging.Model;

namespace PriceCheck
{
	class Program
	{
		static void Main(string[] args)
		{
			SendComputePriceRequest();
			Console.ReadKey(true);
		}

		private static void SendComputePriceRequest()
		{
			string userName = Authentication.GetUserName();
			string password = Authentication.GetPassword();

			computePriceFeedEntry priceCheck = new computePriceFeedEntry
            {
                request = new computePriceRequestFeedEntry()
            };

            // Find the customer to check  prices for
            tradingAccountFeedEntry account = GetCustomer(userName, password);
			if (account == null)
			{
				Console.WriteLine("Unable to find a customer record");
				return;
			}

			// Lookup a commodity to check the price for
			commodityFeedEntry commodity = GetCommodity(userName, password);
			if (commodity == null)
			{
				Console.WriteLine("Unable to find a commodity record");
				return;
			}

			// Set up the check price request
			priceCheck.request.tradingAccount = account;

			priceCheck.request.pricingDocumentLines = new pricingDocumentLineFeed();

            pricingDocumentLineFeedEntry line = new pricingDocumentLineFeedEntry
            {
                quantity = 100,
                commodity = commodity
            };
            priceCheck.request.pricingDocumentLines.Entries.Add(line);

			//Further lines may be added as necessary

			SDataUri computePriceUri = new SDataUri();
			computePriceUri.BuildLocalPath("Accounts50", "GCRM", "-", "computePrice");
			computePriceUri.ServiceMethod = "ComputePrice";
            SDataRequest request = new SDataRequest(computePriceUri.Uri, (Sage.Common.Syndication.FeedEntry)priceCheck, RequestVerb.POST)
            {
                Username = userName,
                Password = password
            };

            computePriceFeedEntry computePriceResult = new computePriceFeedEntry();
			request.RequestFeedEntry<computePriceFeedEntry>(computePriceResult);

			// Issue the request
			if (request.IsStatusValidForVerb)
			{
				foreach (pricingDocumentLineFeedEntry item in computePriceResult.response.pricingDocumentLines.Entries)
				{
					Console.WriteLine("Computed price for item {0} is {1}", item.commodity.reference, item.initialPrice);
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
		}

		static tradingAccountFeedEntry GetCustomer(string userName, string password)
		{
			// Look up the first customer record 
			SDataUri accountUri = new SDataUri();
			accountUri.BuildLocalPath("Accounts50", "GCRM", "-", "tradingAccounts");
			accountUri.Where = "customerSupplierFlag eq 'Customer'";
			accountUri.Count = 1;

            SDataRequest accountRequest = new SDataRequest(accountUri.Uri)
            {
                AllowPromptForCredentials = false,
                Username = userName,
                Password = password
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
                if (accountRequest.Diagnoses != null)
                {
                    foreach (Diagnosis diagnosis in accountRequest.Diagnoses)
                        Console.WriteLine(diagnosis.Message);
                }

                return null;
            }
		}

		static commodityFeedEntry GetCommodity(string userName, string password)
		{
			// Look up the first commodity (product) record 
			SDataUri commodityUri = new SDataUri();
			commodityUri.BuildLocalPath("Accounts50", "GCRM", "-", "commodities");
			commodityUri.Count = 1;

            SDataRequest commodityRequest = new SDataRequest(commodityUri.Uri)
            {
                Username = userName,
                Password = password
            };

            commodityFeed commodities = new commodityFeed();
			commodityRequest.RequestFeed<commodityFeedEntry>(commodities);

            // If we found a record return it
            if (commodityRequest.IsStatusValidForVerb && commodities.Entries != null && commodities.Entries.Count > 0)
            {
                return commodities.Entries[0];
            }
            else
            {
                // There was a problem
                Console.WriteLine("Commodity lookup failed. Response was {0}", commodityRequest.HttpStatusCode.ToString());
                if (commodityRequest.Diagnoses != null)
                {
                    foreach (Diagnosis diagnosis in commodityRequest.Diagnoses)
                        Console.WriteLine(diagnosis.Message);
                }

                return null;
            }
		}
	}
}
