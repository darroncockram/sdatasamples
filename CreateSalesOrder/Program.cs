using System;
using System.Collections.Generic;
using System.Text;
using Sage.Common.Syndication;
using Sage.crmErp.x2008.Feeds;
using Sage.Integration.Client;
using Sage.sc.x2009.Feeds;

namespace CreateSalesOrder
{
	class Program
	{
		static void Main(string[] args)
		{
            // Create a new instance of a salesOrder
            salesOrderFeedEntry salesOrder = new salesOrderFeedEntry
            {
                // Find a customer to associate with the new sales Order
                tradingAccount = GetCustomer()
            };

            if (salesOrder.tradingAccount == null)
			{
				// No customer record means we can go no further
				Console.WriteLine("Unable to find a customer record");
				Console.ReadKey(true);
				return;
			}

			// Lookup a commodity to use on the new sales Order
			commodityFeedEntry commodity = GetCommodity();
			if (commodity == null)
			{
				// No commidty record means we go no further
				Console.WriteLine("Unable to find a commodity record");
				Console.ReadKey(true);
				return;
			}
            commodityFeedEntry commodityReference = new commodityFeedEntry
            {
                UUID = commodity.UUID
            };

            // Lookup a tax code to use on the new sales Order
            taxCodeFeedEntry taxCode = GetTaxCode();
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

            salesOrder.taxCodes = new taxCodeFeed();
			salesOrder.taxCodes.Entries.Add(taxReference);

            //salesOrder.carrierTotalPrice = 100;
            //salesOrder.carrierTaxPrice = 20;
            //salesOrder.carrierNetPrice = 80;

            // Create a new sale Order line using the commodity we just looked up
            salesOrderLineFeedEntry orderLine = new salesOrderLineFeedEntry
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
            //orderLine.orderLineDiscountAmount = 7.5M;
            //orderLine.orderLineDiscountPercent = 13.75M;

            // Create another Order line this time as free text
            salesOrderLineFeedEntry freetextOrderLine = new salesOrderLineFeedEntry
            {
                type = "Free Text", // Equivalent to S1 stock code
                text = "An example product",
                quantity = 5,
                actualPrice = 20,
			    netTotal = 100,
			    taxTotal = 20,
			    grossTotal = 120,
			    taxCodes = new taxCodeFeed(),
            };
            freetextOrderLine.taxCodes.Entries.Add(taxReference);


            salesOrderLineFeedEntry secondOrderLine = new salesOrderLineFeedEntry
            {
                type = "Standard",
                text = commodity.description,
                commodity = commodityReference,
                quantity = 2,
                actualPrice = 25,
                netTotal = 50,
                taxTotal = 10,
                grossTotal = 60,
                taxCodes = new taxCodeFeed(),
                financialAccounts = new financialAccountFeed()
            };
            secondOrderLine.taxCodes.Entries.Add(taxReference);
			secondOrderLine.financialAccounts.Entries.Add(GetFinancialAccount("1001"));

			// Associate the lines with our Order
			salesOrder.salesOrderLines = new salesOrderLineFeed();
			salesOrder.salesOrderLines.Entries.Add(orderLine);
			salesOrder.salesOrderLines.Entries.Add(freetextOrderLine);
			salesOrder.salesOrderLines.Entries.Add(secondOrderLine);

			// Now we have constructed our new Order we can submit it using the HTTP POST verb  
			SDataUri salesOrderUri = new SDataUri();
			salesOrderUri.BuildLocalPath("Accounts50", "GCRM", "-", "salesOrders");
			salesOrderUri.Include = "salesOrderLines";
            SDataRequest OrderRequest = new SDataRequest(salesOrderUri.Uri, salesOrder, Sage.Integration.Messaging.Model.RequestVerb.POST)
            {
                Username = "MANAGER",
                Password = ""
            };

            // IF successful the POST operation will provide us with a the newly created sales Order
            salesOrderFeedEntry savedSalesOrder = new salesOrderFeedEntry();
			OrderRequest.RequestFeedEntry<salesOrderFeedEntry>(savedSalesOrder);

			if (OrderRequest.IsStatusValidForVerb)
			{
				Console.WriteLine(string.Format("Successfully created sales Order {0}", savedSalesOrder.reference));
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

		static tradingAccountFeedEntry GetCustomer()
		{
			// Look up the first customer record 
			SDataUri accountUri = new SDataUri();
			accountUri.BuildLocalPath("Accounts50", "GCRM", "-", "tradingAccounts");
			accountUri.Where = "customerSupplierFlag eq 'Customer'";
			accountUri.Count = 1;

            SDataRequest accountRequest = new SDataRequest(accountUri.Uri)
            {
                AllowPromptForCredentials = false,
                Username = "MANAGER",
                Password = ""
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

		static commodityFeedEntry GetCommodity()
		{
			// Look up the first commodity (product) record 
			SDataUri commodityUri = new SDataUri();
			commodityUri.BuildLocalPath("Accounts50", "GCRM", "-", "commodities");
			commodityUri.Count = 1;
			commodityUri.Where = "reference eq 'MON002'";

            SDataRequest commodityRequest = new SDataRequest(commodityUri.Uri)
            {
                Username = "MANAGER",
                Password = ""
            };

            commodityFeed commodities = new commodityFeed();
			commodityRequest.RequestFeed<commodityFeedEntry>(commodities);

			// If we found a record return it
			if (commodityRequest.IsStatusValidForVerb && commodities.Entries != null && commodities.Entries.Count > 0)
				return commodities.Entries[0];
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

		static taxCodeFeedEntry GetTaxCode()
		{
			// Look up the tax code record 
			SDataUri taxCodeUri = new SDataUri();
			taxCodeUri.BuildLocalPath("Accounts50", "GCRM", "-", "taxCodes");
			taxCodeUri.Where = "reference eq 'T1'";

            SDataRequest taxcodeRequest = new SDataRequest(taxCodeUri.Uri)
            {
                Username = "MANAGER",
                Password = ""
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

		static financialAccountFeedEntry GetFinancialAccount(string nominalCode)
		{
			// Look up the tax code record 
			SDataUri financialAccountUri = new SDataUri();
			financialAccountUri.BuildLocalPath("Accounts50", "GCRM", "-", "financialAccounts");
			financialAccountUri.Where = $"reference eq '{nominalCode}'";

            SDataRequest request = new SDataRequest(financialAccountUri.Uri)
            {
                Username = "MANAGER",
                Password = ""
            };

            financialAccountFeed entries = new financialAccountFeed();
			request.RequestFeed<financialAccountFeedEntry>(entries);

			// If we found a customer record return it
			if (request.IsStatusValidForVerb && entries.Entries != null && entries.Entries.Count > 0)
				return entries.Entries[0];
			else
			{
				// There was a problem
				Console.WriteLine("Tax code lookup failed. Response was {0}", request.HttpStatusCode.ToString());
				if (request.Diagnoses != null)
				{
					foreach (Diagnosis diagnosis in request.Diagnoses)
						Console.WriteLine(diagnosis.Message);
				}

				return null;
			}
		}
	}
}
