using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helpers;
using Sage.Common.Syndication;
using Sage.crmErp.x2008.Feeds;
using Sage.Integration.Client;

namespace CreatePurchaseOrder
{
	class Program
	{
		static void Main(string[] args)
		{
			string userName = Authentication.GetUserName();
			string password = Authentication.GetPassword();

			// Create a new instance of a purchaseOrder
			purchaseOrderFeedEntry purchaseOrder = new purchaseOrderFeedEntry
            {
                // Find a customer to associate with the new sales Order
                tradingAccount = GetSupplier(userName, password),
                deliveryDate = DateTime.UtcNow.AddDays(-7),
                date = DateTime.UtcNow.AddDays(-7),
                dueDate = DateTime.UtcNow.AddDays(-7)
            };

            if (purchaseOrder.tradingAccount == null)
			{
				// No supplier record means we can go no further
				Console.WriteLine("Unable to find a supplier record");
				Console.ReadKey(true);
				return;
			}

			// Lookup a commodity to use on the new sales Order
			commodityFeedEntry commodity = GetCommodity(userName, password);
			if (commodity == null)
			{
				// No commodity record means we go no further
				Console.WriteLine("Unable to find a commodity record");
				Console.ReadKey(true);
				return;
			}
            commodityFeedEntry commodityReference = new commodityFeedEntry
            {
                UUID = commodity.UUID
            };

            // Lookup a tax code to use on the new sales Order
            taxCodeFeedEntry taxCode = GetTaxCode(userName, password);
			if (taxCode == null)
			{
				// No record means we go no further
				Console.WriteLine("Unable to find a tax code record");
				Console.ReadKey(true);
				return;
			}

            taxCodeFeedEntry taxReference = new taxCodeFeedEntry
            {
                UUID = taxCode.UUID
            };

            purchaseOrder.taxCodes = new taxCodeFeed();
			purchaseOrder.taxCodes.Entries.Add(taxReference);

            // Create a new sale Order line using the commodity we just looked up
            purchaseOrderLineFeedEntry orderLine = new purchaseOrderLineFeedEntry
            {
                type = "Standard",
                text = commodity.description,
                commodity = commodityReference,
                quantity = 2,
                actualPrice = 25,
                netTotal = 50,
                taxTotal = 10,
                grossTotal = 60,
                taxCodes = new taxCodeFeed()
            };
            orderLine.taxCodes.Entries.Add(taxReference);

			// Associate the line with our Order
			purchaseOrder.purchaseOrderLines = new purchaseOrderLineFeed();
			purchaseOrder.purchaseOrderLines.Entries.Add(orderLine);

			// Now we have constructed our new Order we can submit it using the HTTP POST verb  
			SDataUri purchaseOrderUri = new SDataUri();
			purchaseOrderUri.BuildLocalPath("Accounts50", "GCRM", "-", "purchaseOrders");
			purchaseOrderUri.Include = "purchaseOrderLines";
            SDataRequest OrderRequest = new SDataRequest(purchaseOrderUri.Uri, purchaseOrder, Sage.Integration.Messaging.Model.RequestVerb.POST)
            {
                Username = userName,
                Password = password
            };

            // IF successful the POST operation will provide us with a the newly created sales Order
            purchaseOrderFeedEntry savedpurchaseOrder = new purchaseOrderFeedEntry();
			OrderRequest.RequestFeedEntry<purchaseOrderFeedEntry>(savedpurchaseOrder);

			if (OrderRequest.IsStatusValidForVerb)
			{
				Console.WriteLine(string.Format("Successfully created purchase Order {0}", savedpurchaseOrder.reference));
			}
			else
			{
				// There was a problem
				Console.WriteLine("Create failed. Response was {0}", OrderRequest.HttpStatusCode.ToString());
				if (OrderRequest.Diagnoses != null)
				{
					foreach (Diagnosis diagnosis in OrderRequest.Diagnoses)
						Console.WriteLine(diagnosis.Message);
				}
			}

			Console.ReadKey(true);
		}

		static tradingAccountFeedEntry GetSupplier(string userName, string password)
		{
			// Look up the first customer record 
			SDataUri accountUri = new SDataUri();
			accountUri.BuildLocalPath("Accounts50", "GCRM", "-", "tradingAccounts");
			accountUri.Where = "customerSupplierFlag eq 'Supplier'";
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
				return accounts.Entries[0];
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

		static taxCodeFeedEntry GetTaxCode(string userName, string password)
		{
			// Look up the tax code record 
			SDataUri taxCodeUri = new SDataUri();
			taxCodeUri.BuildLocalPath("Accounts50", "GCRM", "-", "taxCodes");
			taxCodeUri.Where = "reference eq 'T1'";

            SDataRequest taxcodeRequest = new SDataRequest(taxCodeUri.Uri)
            {
                Username = userName,
                Password = password
            };

            taxCodeFeed taxcodes = new taxCodeFeed();
			taxcodeRequest.RequestFeed<taxCodeFeedEntry>(taxcodes);

			// If we found a customer record return it
			if (taxcodeRequest.IsStatusValidForVerb && taxcodes.Entries != null && taxcodes.Entries.Count > 0)
				return taxcodes.Entries[0];
			else
			{
				// There was a problem
				Console.WriteLine("Tax code lookup failed. Response was {0}", taxcodeRequest.HttpStatusCode.ToString());
				if (taxcodeRequest.Diagnoses != null)
				{
					foreach (Diagnosis diagnosis in taxcodeRequest.Diagnoses)
						Console.WriteLine(diagnosis.Message);
				}

				return null;
			}
		}
	}
}
