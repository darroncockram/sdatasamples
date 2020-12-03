using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using Sage.Common.Metadata;
using Sage.Common.Syndication;
using Sage.sc.x2009.Feeds;

namespace Sage.crmErp.x2008.Feeds
{
	#region Documentation
	/// <summary>
	/// Defines a salesOrderDelivery feed entry
	/// </summary>
	#endregion
	[System.ComponentModel.Browsable(false)]
	[XmlType("salesOrderDelivery", Namespace="http://schemas.sage.com/crmErp/2008")]
	public class salesOrderDeliveryFeedEntrySchema : Sage.Common.Syndication.FeedEntry
	{
		#region Constants

		public const string Propertyactive = "active";
		public const string PropertysalesOrder = "salesOrder";
		public const string Propertyreference = "reference";
		public const string Propertyreference2 = "reference2";
		public const string Propertystatus = "status";
		public const string PropertytradingAccount = "tradingAccount";
		public const string PropertycustomerReference = "customerReference";
		public const string Propertypricelist = "pricelist";
		public const string PropertysupplierTradingAccount = "supplierTradingAccount";
		public const string PropertysupplierReference = "supplierReference";
		public const string Propertytype = "type";
		public const string PropertypostalAddress = "postalAddress";
		public const string PropertydeliveryMethod = "deliveryMethod";
		public const string PropertycarrierTradingAccount = "carrierTradingAccount";
		public const string PropertycarrierTaxCodes = "carrierTaxCodes";
		public const string PropertycarrierReference = "carrierReference";
		public const string PropertycarrierNetPrice = "carrierNetPrice";
		public const string PropertycarrierTaxPrice = "carrierTaxPrice";
		public const string PropertycarrierTotalPrice = "carrierTotalPrice";
		public const string PropertycarrierSalesInvoice = "carrierSalesInvoice";
		public const string Propertycurrency = "currency";
		public const string PropertyoperatingCompanyCurrency = "operatingCompanyCurrency";
		public const string PropertyoperatingCompanyCurrencyExchangeRate = "operatingCompanyCurrencyExchangeRate";
		public const string PropertyoperatingCompanyCurrencyExchangeRateOperator = "operatingCompanyCurrencyExchangeRateOperator";
		public const string PropertyoperatingCompanyCurrencyExchangeRateDate = "operatingCompanyCurrencyExchangeRateDate";
		public const string PropertyinvoiceCurrency = "invoiceCurrency";
		public const string PropertyinvoiceCurrencyExchangeRate = "invoiceCurrencyExchangeRate";
		public const string PropertyinvoiceCurrencyExchangeRateOperator = "invoiceCurrencyExchangeRateOperator";
		public const string PropertyinvoiceCurrencyExchangeRateDate = "invoiceCurrencyExchangeRateDate";
		public const string PropertycustomerTradingAccountCurrency = "customerTradingAccountCurrency";
		public const string PropertycustomerTradingAccountCurrencyExchangeRate = "customerTradingAccountCurrencyExchangeRate";
		public const string PropertycustomerTradingAccountCurrencyExchangeRateOperator = "customerTradingAccountCurrencyExchangeRateOperator";
		public const string PropertycustomerTradingAccountCurrencyExchangeRateDate = "customerTradingAccountCurrencyExchangeRateDate";
		public const string PropertyrequestedDeliveryDate = "requestedDeliveryDate";
		public const string PropertyactualDeliveryDate = "actualDeliveryDate";
		public const string PropertyactualDeliveryTime = "actualDeliveryTime";
		public const string PropertydateExceptionReason = "dateExceptionReason";
		public const string Propertytaxcodes = "taxcodes";
		public const string PropertydeliveryContact = "deliveryContact";
		public const string PropertysalesOrderDeliveryLines = "salesOrderDeliveryLines";
		public const string PropertylineCount = "lineCount";
		public const string PropertyrequestedQuantity = "requestedQuantity";
		public const string PropertydeliveredQuantity = "deliveredQuantity";
		public const string PropertydeliveryDiscountType = "deliveryDiscountType";
		public const string PropertydeliveryDiscountAmount = "deliveryDiscountAmount";
		public const string PropertydeliveryDiscountPercent = "deliveryDiscountPercent";
		public const string PropertydeliveryAdditionalDiscount1Type = "deliveryAdditionalDiscount1Type";
		public const string PropertydeliveryAdditionalDiscount1Amount = "deliveryAdditionalDiscount1Amount";
		public const string PropertydeliveryAdditionalDiscount1Percent = "deliveryAdditionalDiscount1Percent";
		public const string PropertydeliveryAdditionalDiscount2 = "deliveryAdditionalDiscount2";
		public const string PropertydeliveryAdditionalDiscount2Amount = "deliveryAdditionalDiscount2Amount";
		public const string PropertydeliveryAdditionalDiscount2Percent = "deliveryAdditionalDiscount2Percent";
		public const string Propertytext1 = "text1";
		public const string Propertytext2 = "text2";
		public const string PropertynetTotal = "netTotal";
		public const string PropertydiscountTotal = "discountTotal";
		public const string PropertychargesTotal = "chargesTotal";
		public const string PropertytaxTotal = "taxTotal";
		public const string PropertygrossTotal = "grossTotal";
		public const string PropertycostTotal = "costTotal";
		public const string PropertyprofitTotal = "profitTotal";
		public const string Propertyreceipts = "receipts";
		public const string PropertyinvoiceTradingAccount = "invoiceTradingAccount";
		public const string PropertyinvoiceCountry = "invoiceCountry";
		public const string PropertydeliveryCountry = "deliveryCountry";
		public const string PropertyoriginCountry = "originCountry";
		public const string PropertytypeOfBusiness = "typeOfBusiness";
		public const string PropertystatisticalProcess = "statisticalProcess";
		public const string Propertyuser = "user";
		public const string PropertyfinancialAccounts = "financialAccounts";
		public const string Propertyinteractions = "interactions";
		public const string Propertynotes = "notes";

		#endregion

		#region Fields

		private Nullable<System.Boolean> _active;
		private salesOrderFeed _salesOrder;
		private System.String _reference;
		private System.String _reference2;
		private System.String _status;
		private tradingAccountFeedEntry _tradingAccount;
		private System.String _customerReference;
		private priceListFeedEntry _pricelist;
		private tradingAccountFeedEntry _supplierTradingAccount;
		private System.String _supplierReference;
		private System.String _type;
		private postalAddressFeedEntry _postalAddress;
		private System.String _deliveryMethod;
		private tradingAccountFeedEntry _carrierTradingAccount;
		private taxCodeFeed _carrierTaxCodes;
		private System.String _carrierReference;
		private Nullable<System.Decimal> _carrierNetPrice;
		private Nullable<System.Decimal> _carrierTaxPrice;
		private Nullable<System.Decimal> _carrierTotalPrice;
		private salesInvoiceFeedEntry _carrierSalesInvoice;
		private System.String _currency;
		private System.String _operatingCompanyCurrency;
		private Nullable<System.Decimal> _operatingCompanyCurrencyExchangeRate;
		private System.String _operatingCompanyCurrencyExchangeRateOperator;
		private Nullable<System.DateTime> _operatingCompanyCurrencyExchangeRateDate;
		private System.String _invoiceCurrency;
		private Nullable<System.Decimal> _invoiceCurrencyExchangeRate;
		private System.String _invoiceCurrencyExchangeRateOperator;
		private Nullable<System.DateTime> _invoiceCurrencyExchangeRateDate;
		private System.String _customerTradingAccountCurrency;
		private Nullable<System.Decimal> _customerTradingAccountCurrencyExchangeRate;
		private System.String _customerTradingAccountCurrencyExchangeRateOperator;
		private Nullable<System.DateTime> _customerTradingAccountCurrencyExchangeRateDate;
		private Nullable<System.DateTime> _requestedDeliveryDate;
		private Nullable<System.DateTime> _actualDeliveryDate;
		private Nullable<System.DateTime> _actualDeliveryTime;
		private System.String _dateExceptionReason;
		private taxCodeFeed _taxcodes;
		private contactFeedEntry _deliveryContact;
		private salesOrderDeliveryLineFeed _salesOrderDeliveryLines;
		private Nullable<System.Decimal> _lineCount;
		private Nullable<System.Decimal> _requestedQuantity;
		private Nullable<System.Decimal> _deliveredQuantity;
		private System.String _deliveryDiscountType;
		private Nullable<System.Decimal> _deliveryDiscountAmount;
		private Nullable<System.Decimal> _deliveryDiscountPercent;
		private System.String _deliveryAdditionalDiscount1Type;
		private Nullable<System.Decimal> _deliveryAdditionalDiscount1Amount;
		private Nullable<System.Decimal> _deliveryAdditionalDiscount1Percent;
		private System.String _deliveryAdditionalDiscount2;
		private Nullable<System.Decimal> _deliveryAdditionalDiscount2Amount;
		private Nullable<System.Decimal> _deliveryAdditionalDiscount2Percent;
		private System.String _text1;
		private System.String _text2;
		private Nullable<System.Decimal> _netTotal;
		private Nullable<System.Decimal> _discountTotal;
		private Nullable<System.Decimal> _chargesTotal;
		private Nullable<System.Decimal> _taxTotal;
		private Nullable<System.Decimal> _grossTotal;
		private Nullable<System.Decimal> _costTotal;
		private Nullable<System.Decimal> _profitTotal;
		private receiptFeed _receipts;
		private tradingAccountFeedEntry _invoiceTradingAccount;
		private System.String _invoiceCountry;
		private System.String _deliveryCountry;
		private System.String _originCountry;
		private System.String _typeOfBusiness;
		private System.String _statisticalProcess;
		private System.String _user;
		private financialAccountFeed _financialAccounts;
		private interactionFeed _interactions;
		private noteFeed _notes;

		#endregion

		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="salesOrderDeliveryFeedEntrySchema"/> class.
		/// </summary>
		#endregion
		public salesOrderDeliveryFeedEntrySchema()
		{
		}

		#region Properties


		[SMEBoolProperty(Label="SalesOrderDelivery Active Flag", Nillable=true, Name="active", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.Boolean> active { get { return _active; } set { SetProperty(Propertyactive, ref _active, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanDelete=true, PluralName="salesOrders", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="salesOrder", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesOrderFeed salesOrder { get { return _salesOrder; } set { SetProperty(PropertysalesOrder, ref _salesOrder, value); } }

		[SMEStringProperty(Label="SalesOrderDelivery reference", Name="reference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true, IsUniqueKey=true)]			
		public virtual System.String reference { get { return _reference; } set { SetProperty(Propertyreference, ref _reference, value); } }

		[SMEStringProperty(Label="SalesOrderDelivery Reference2", Name="reference2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String reference2 { get { return _reference2; } set { SetProperty(Propertyreference2, ref _reference2, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="SalesOrderDelivery Status", Name="status", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String status { get { return _status; } set { SetProperty(Propertystatus, ref _status, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="tradingAccounts", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="tradingAccount", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("tradingAccount")]			
		public virtual tradingAccountFeedEntry tradingAccount { get { return _tradingAccount; } set { SetProperty(PropertytradingAccount, ref _tradingAccount, value); } }

		[SMEStringProperty(Label="SalesOrderDelivery Customer reference", Name="customerReference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String customerReference { get { return _customerReference; } set { SetProperty(PropertycustomerReference, ref _customerReference, value); } }

		[SMEResource(CanGet=true, PluralName="priceLists", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="pricelist", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("pricelist")]			
		public virtual priceListFeedEntry pricelist { get { return _pricelist; } set { SetProperty(Propertypricelist, ref _pricelist, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="tradingAccounts", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="supplierTradingAccount", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("supplierTradingAccount")]			
		public virtual tradingAccountFeedEntry supplierTradingAccount { get { return _supplierTradingAccount; } set { SetProperty(PropertysupplierTradingAccount, ref _supplierTradingAccount, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="SalesOrderDelivery Supplier reference", Name="supplierReference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String supplierReference { get { return _supplierReference; } set { SetProperty(PropertysupplierReference, ref _supplierReference, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="SalesOrderDelivery Type", Name="type", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String type { get { return _type; } set { SetProperty(Propertytype, ref _type, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="postalAddresses", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="postalAddress", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("postalAddress")]			
		public virtual postalAddressFeedEntry postalAddress { get { return _postalAddress; } set { SetProperty(PropertypostalAddress, ref _postalAddress, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="SalesOrderDelivery Method", Name="deliveryMethod", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String deliveryMethod { get { return _deliveryMethod; } set { SetProperty(PropertydeliveryMethod, ref _deliveryMethod, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="tradingAccounts", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="carrierTradingAccount", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("carrierTradingAccount")]			
		public virtual tradingAccountFeedEntry carrierTradingAccount { get { return _carrierTradingAccount; } set { SetProperty(PropertycarrierTradingAccount, ref _carrierTradingAccount, value); } }

		[SMEResource(CanGet=true, PluralName="taxCodes", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="carrierTaxCodes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual taxCodeFeed carrierTaxCodes { get { return _carrierTaxCodes; } set { SetProperty(PropertycarrierTaxCodes, ref _carrierTaxCodes, value); } }

		[SMEStringProperty(Label="SalesOrderDelivery Carrier reference", Name="carrierReference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String carrierReference { get { return _carrierReference; } set { SetProperty(PropertycarrierReference, ref _carrierReference, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesOrderDelivery Carrier Net Price", Nillable=true, AverageLength=14, Name="carrierNetPrice", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> carrierNetPrice { get { return _carrierNetPrice; } set { SetProperty(PropertycarrierNetPrice, ref _carrierNetPrice, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesOrderDelivery Carrier Tax Price", Nillable=true, AverageLength=14, Name="carrierTaxPrice", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> carrierTaxPrice { get { return _carrierTaxPrice; } set { SetProperty(PropertycarrierTaxPrice, ref _carrierTaxPrice, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesOrderDelivery Carrier Gross Price", Nillable=true, AverageLength=14, Name="carrierTotalPrice", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> carrierTotalPrice { get { return _carrierTotalPrice; } set { SetProperty(PropertycarrierTotalPrice, ref _carrierTotalPrice, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanDelete=true, PluralName="salesInvoices", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="carrierSalesInvoice", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("carrierSalesInvoice")]			
		public virtual salesInvoiceFeedEntry carrierSalesInvoice { get { return _carrierSalesInvoice; } set { SetProperty(PropertycarrierSalesInvoice, ref _carrierSalesInvoice, value); } }

		[SMEStringProperty(Label="SalesOrderDelivery Currency", Name="currency", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String currency { get { return _currency; } set { SetProperty(Propertycurrency, ref _currency, value); } }

		[SMEStringProperty(Label="SalesOrderDelivery OperatingCompany Currency", Name="operatingCompanyCurrency", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String operatingCompanyCurrency { get { return _operatingCompanyCurrency; } set { SetProperty(PropertyoperatingCompanyCurrency, ref _operatingCompanyCurrency, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesOrderDelivery OperatingCompany Currency Exchange Rate", Nillable=true, AverageLength=14, Name="operatingCompanyCurrencyExchangeRate", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> operatingCompanyCurrencyExchangeRate { get { return _operatingCompanyCurrencyExchangeRate; } set { SetProperty(PropertyoperatingCompanyCurrencyExchangeRate, ref _operatingCompanyCurrencyExchangeRate, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="SalesOrderDelivery OperatingCompany Currency Exchange Rate Operator", Name="operatingCompanyCurrencyExchangeRateOperator", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String operatingCompanyCurrencyExchangeRateOperator { get { return _operatingCompanyCurrencyExchangeRateOperator; } set { SetProperty(PropertyoperatingCompanyCurrencyExchangeRateOperator, ref _operatingCompanyCurrencyExchangeRateOperator, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDateProperty(Label="SalesOrderDelivery OperatingCompany Currency Exchange Rate Date", Nillable=true, Name="operatingCompanyCurrencyExchangeRateDate", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.DateTime> operatingCompanyCurrencyExchangeRateDate { get { return _operatingCompanyCurrencyExchangeRateDate; } set { SetProperty(PropertyoperatingCompanyCurrencyExchangeRateDate, ref _operatingCompanyCurrencyExchangeRateDate, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="SalesOrderDelivery Invoice Currency", Name="invoiceCurrency", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String invoiceCurrency { get { return _invoiceCurrency; } set { SetProperty(PropertyinvoiceCurrency, ref _invoiceCurrency, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesOrderDelivery Invoice Currency Exchange Rate", Nillable=true, AverageLength=14, Name="invoiceCurrencyExchangeRate", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> invoiceCurrencyExchangeRate { get { return _invoiceCurrencyExchangeRate; } set { SetProperty(PropertyinvoiceCurrencyExchangeRate, ref _invoiceCurrencyExchangeRate, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="SalesOrderDelivery Invoice Currency Exchange Rate Operator", Name="invoiceCurrencyExchangeRateOperator", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String invoiceCurrencyExchangeRateOperator { get { return _invoiceCurrencyExchangeRateOperator; } set { SetProperty(PropertyinvoiceCurrencyExchangeRateOperator, ref _invoiceCurrencyExchangeRateOperator, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDateProperty(Label="SalesOrderDelivery Invoice Currency Exchange Rate Date", Nillable=true, Name="invoiceCurrencyExchangeRateDate", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.DateTime> invoiceCurrencyExchangeRateDate { get { return _invoiceCurrencyExchangeRateDate; } set { SetProperty(PropertyinvoiceCurrencyExchangeRateDate, ref _invoiceCurrencyExchangeRateDate, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="SalesOrderDelivery Customer TradingAccount Currency", Name="customerTradingAccountCurrency", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String customerTradingAccountCurrency { get { return _customerTradingAccountCurrency; } set { SetProperty(PropertycustomerTradingAccountCurrency, ref _customerTradingAccountCurrency, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesOrderDelivery Customer TradingAccount Currency Exchange Rate", Nillable=true, AverageLength=14, Name="customerTradingAccountCurrencyExchangeRate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> customerTradingAccountCurrencyExchangeRate { get { return _customerTradingAccountCurrencyExchangeRate; } set { SetProperty(PropertycustomerTradingAccountCurrencyExchangeRate, ref _customerTradingAccountCurrencyExchangeRate, value); } }

		[SMEStringProperty(Label="SalesOrderDelivery Customer TradingAccount Currency Exchange Rate Operator", Name="customerTradingAccountCurrencyExchangeRateOperator", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String customerTradingAccountCurrencyExchangeRateOperator { get { return _customerTradingAccountCurrencyExchangeRateOperator; } set { SetProperty(PropertycustomerTradingAccountCurrencyExchangeRateOperator, ref _customerTradingAccountCurrencyExchangeRateOperator, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDateProperty(Label="SalesOrderDelivery Customer TradingAccount Currency Exchange Rate Date", Nillable=true, Name="customerTradingAccountCurrencyExchangeRateDate", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.DateTime> customerTradingAccountCurrencyExchangeRateDate { get { return _customerTradingAccountCurrencyExchangeRateDate; } set { SetProperty(PropertycustomerTradingAccountCurrencyExchangeRateDate, ref _customerTradingAccountCurrencyExchangeRateDate, value); } }

		[SMEDateProperty(Label="SalesOrderDelivery Requested Delivery Date", Nillable=true, Name="requestedDeliveryDate", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.DateTime> requestedDeliveryDate { get { return _requestedDeliveryDate; } set { SetProperty(PropertyrequestedDeliveryDate, ref _requestedDeliveryDate, value); } }

		[SMEDateProperty(Label="SalesOrderDelivery Actual Delivery Date", Nillable=true, Name="actualDeliveryDate", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.DateTime> actualDeliveryDate { get { return _actualDeliveryDate; } set { SetProperty(PropertyactualDeliveryDate, ref _actualDeliveryDate, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMETimeProperty(Label="SalesOrderDelivery Actual Delivery Time", Nillable=true, Name="actualDeliveryTime", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.DateTime> actualDeliveryTime { get { return _actualDeliveryTime; } set { SetProperty(PropertyactualDeliveryTime, ref _actualDeliveryTime, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="SalesOrderDelivery Date Exception Reason", Name="dateExceptionReason", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String dateExceptionReason { get { return _dateExceptionReason; } set { SetProperty(PropertydateExceptionReason, ref _dateExceptionReason, value); } }

		[SMEResource(CanGet=true, PluralName="taxCodes", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="taxcodes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual taxCodeFeed taxcodes { get { return _taxcodes; } set { SetProperty(Propertytaxcodes, ref _taxcodes, value); } }

		[SMEResource(CanGet=true, PluralName="contacts", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="deliveryContact", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("deliveryContact")]			
		public virtual contactFeedEntry deliveryContact { get { return _deliveryContact; } set { SetProperty(PropertydeliveryContact, ref _deliveryContact, value); } }

		[SMEResource(CanGet=true, PluralName="salesOrderDeliveryLines", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Child, IsCollection=true, Name="salesOrderDeliveryLines", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesOrderDeliveryLineFeed salesOrderDeliveryLines { get { return _salesOrderDeliveryLines; } set { SetProperty(PropertysalesOrderDeliveryLines, ref _salesOrderDeliveryLines, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesOrderDelivery Line Count", Nillable=true, AverageLength=14, Name="lineCount", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> lineCount { get { return _lineCount; } set { SetProperty(PropertylineCount, ref _lineCount, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesOrderDelivery Requested Quantity", Nillable=true, AverageLength=14, Name="requestedQuantity", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> requestedQuantity { get { return _requestedQuantity; } set { SetProperty(PropertyrequestedQuantity, ref _requestedQuantity, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesOrderDelivery Delivered Quantity", Nillable=true, AverageLength=14, Name="deliveredQuantity", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> deliveredQuantity { get { return _deliveredQuantity; } set { SetProperty(PropertydeliveredQuantity, ref _deliveredQuantity, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="SalesOrderDelivery Delivery Discount Type", Name="deliveryDiscountType", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String deliveryDiscountType { get { return _deliveryDiscountType; } set { SetProperty(PropertydeliveryDiscountType, ref _deliveryDiscountType, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesOrderDelivery Delivery Discount Amount", Nillable=true, AverageLength=14, Name="deliveryDiscountAmount", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> deliveryDiscountAmount { get { return _deliveryDiscountAmount; } set { SetProperty(PropertydeliveryDiscountAmount, ref _deliveryDiscountAmount, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesOrderDelivery Delivery Discount Percent", Nillable=true, AverageLength=14, Name="deliveryDiscountPercent", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> deliveryDiscountPercent { get { return _deliveryDiscountPercent; } set { SetProperty(PropertydeliveryDiscountPercent, ref _deliveryDiscountPercent, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="SalesOrderDelivery Delivery Additional Discount1 Type", Name="deliveryAdditionalDiscount1Type", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String deliveryAdditionalDiscount1Type { get { return _deliveryAdditionalDiscount1Type; } set { SetProperty(PropertydeliveryAdditionalDiscount1Type, ref _deliveryAdditionalDiscount1Type, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesOrderDelivery Delivery Additional Discount1 Amount", Nillable=true, AverageLength=14, Name="deliveryAdditionalDiscount1Amount", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> deliveryAdditionalDiscount1Amount { get { return _deliveryAdditionalDiscount1Amount; } set { SetProperty(PropertydeliveryAdditionalDiscount1Amount, ref _deliveryAdditionalDiscount1Amount, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesOrderDelivery Delivery Additional Discount1 Percent", Nillable=true, AverageLength=14, Name="deliveryAdditionalDiscount1Percent", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> deliveryAdditionalDiscount1Percent { get { return _deliveryAdditionalDiscount1Percent; } set { SetProperty(PropertydeliveryAdditionalDiscount1Percent, ref _deliveryAdditionalDiscount1Percent, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="SalesOrderDelivery Delivery Additional Discount2 Type", Name="deliveryAdditionalDiscount2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String deliveryAdditionalDiscount2 { get { return _deliveryAdditionalDiscount2; } set { SetProperty(PropertydeliveryAdditionalDiscount2, ref _deliveryAdditionalDiscount2, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesOrderDelivery Delivery Additional Discount2 Amount", Nillable=true, AverageLength=14, Name="deliveryAdditionalDiscount2Amount", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> deliveryAdditionalDiscount2Amount { get { return _deliveryAdditionalDiscount2Amount; } set { SetProperty(PropertydeliveryAdditionalDiscount2Amount, ref _deliveryAdditionalDiscount2Amount, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesOrderDelivery Delivery Additional Discount2 Percent", Nillable=true, AverageLength=14, Name="deliveryAdditionalDiscount2Percent", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> deliveryAdditionalDiscount2Percent { get { return _deliveryAdditionalDiscount2Percent; } set { SetProperty(PropertydeliveryAdditionalDiscount2Percent, ref _deliveryAdditionalDiscount2Percent, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="SalesOrderDelivery Text1", Name="text1", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String text1 { get { return _text1; } set { SetProperty(Propertytext1, ref _text1, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="SalesOrderDelivery Text2", Name="text2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String text2 { get { return _text2; } set { SetProperty(Propertytext2, ref _text2, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesOrderDelivery Net Total", Nillable=true, AverageLength=14, Name="netTotal", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> netTotal { get { return _netTotal; } set { SetProperty(PropertynetTotal, ref _netTotal, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesOrderDelivery Discount Total", Nillable=true, AverageLength=14, Name="discountTotal", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> discountTotal { get { return _discountTotal; } set { SetProperty(PropertydiscountTotal, ref _discountTotal, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesOrderDelivery Charges Total", Nillable=true, AverageLength=14, Name="chargesTotal", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> chargesTotal { get { return _chargesTotal; } set { SetProperty(PropertychargesTotal, ref _chargesTotal, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesOrderDelivery Tax Total", Nillable=true, AverageLength=14, Name="taxTotal", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> taxTotal { get { return _taxTotal; } set { SetProperty(PropertytaxTotal, ref _taxTotal, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesOrderDelivery Gross Total", Nillable=true, AverageLength=14, Name="grossTotal", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> grossTotal { get { return _grossTotal; } set { SetProperty(PropertygrossTotal, ref _grossTotal, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesOrderDelivery Cost Total", Nillable=true, AverageLength=14, Name="costTotal", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> costTotal { get { return _costTotal; } set { SetProperty(PropertycostTotal, ref _costTotal, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesOrderDelivery Profit Total", Nillable=true, AverageLength=14, Name="profitTotal", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> profitTotal { get { return _profitTotal; } set { SetProperty(PropertyprofitTotal, ref _profitTotal, value); } }

		[SMEResource(CanGet=true, PluralName="receipts", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="receipts", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual receiptFeed receipts { get { return _receipts; } set { SetProperty(Propertyreceipts, ref _receipts, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="tradingAccounts", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="invoiceTradingAccount", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("invoiceTradingAccount")]			
		public virtual tradingAccountFeedEntry invoiceTradingAccount { get { return _invoiceTradingAccount; } set { SetProperty(PropertyinvoiceTradingAccount, ref _invoiceTradingAccount, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="SalesOrderDelivery Invoice Country", Name="invoiceCountry", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String invoiceCountry { get { return _invoiceCountry; } set { SetProperty(PropertyinvoiceCountry, ref _invoiceCountry, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="SalesOrderDelivery Delivery Country", Name="deliveryCountry", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String deliveryCountry { get { return _deliveryCountry; } set { SetProperty(PropertydeliveryCountry, ref _deliveryCountry, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="SalesOrderDelivery Origin Country", Name="originCountry", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String originCountry { get { return _originCountry; } set { SetProperty(PropertyoriginCountry, ref _originCountry, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="SalesOrderDelivery Type Of Business", Name="typeOfBusiness", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String typeOfBusiness { get { return _typeOfBusiness; } set { SetProperty(PropertytypeOfBusiness, ref _typeOfBusiness, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="SalesOrderDelivery Statistical Process", Name="statisticalProcess", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String statisticalProcess { get { return _statisticalProcess; } set { SetProperty(PropertystatisticalProcess, ref _statisticalProcess, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="SalesOrderDelivery User", Name="user", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String user { get { return _user; } set { SetProperty(Propertyuser, ref _user, value); } }

		[SMEResource(CanGet=true, PluralName="financialAccounts", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="financialAccounts", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual financialAccountFeed financialAccounts { get { return _financialAccounts; } set { SetProperty(PropertyfinancialAccounts, ref _financialAccounts, value); } }

		[SMEResource(CanGet=true, PluralName="interactions", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="interactions", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual interactionFeed interactions { get { return _interactions; } set { SetProperty(Propertyinteractions, ref _interactions, value); } }

		[SMEResource(CanGet=true, CanPut=true, PluralName="notes", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="notes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual noteFeed notes { get { return _notes; } set { SetProperty(Propertynotes, ref _notes, value); } }

		#endregion


	}
}