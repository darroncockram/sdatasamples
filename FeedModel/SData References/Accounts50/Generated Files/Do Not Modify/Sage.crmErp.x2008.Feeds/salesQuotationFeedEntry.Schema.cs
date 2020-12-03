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
	/// Defines a salesQuotation feed entry
	/// </summary>
	#endregion
	[System.ComponentModel.Browsable(false)]
	[XmlType("salesQuotation", Namespace="http://schemas.sage.com/crmErp/2008")]
	public class salesQuotationFeedEntrySchema : Sage.Common.Syndication.FeedEntry
	{
		#region Constants

		public const string Propertyactive = "active";
		public const string Propertyreference = "reference";
		public const string Propertyreference2 = "reference2";
		public const string Propertystatus = "status";
		public const string PropertystatusFlag = "statusFlag";
		public const string PropertystatusFlagText = "statusFlagText";
		public const string PropertytradingAccount = "tradingAccount";
		public const string PropertycustomerReference = "customerReference";
		public const string Propertyopportunity = "opportunity";
		public const string Propertypricelist = "pricelist";
		public const string Propertytype = "type";
		public const string PropertycopyFlag = "copyFlag";
		public const string PropertyoriginatorDocument = "originatorDocument";
		public const string PropertypostalAddresses = "postalAddresses";
		public const string PropertydeliveryMethod = "deliveryMethod";
		public const string PropertydeliveryRule = "deliveryRule";
		public const string PropertydeliveryTerms = "deliveryTerms";
		public const string PropertydeliveryDate = "deliveryDate";
		public const string PropertydueDate = "dueDate";
		public const string Propertycurrency = "currency";
		public const string PropertyoperatingCompanyCurrency = "operatingCompanyCurrency";
		public const string PropertyoperatingCompanyCurrencyExchangeRate = "operatingCompanyCurrencyExchangeRate";
		public const string PropertyoperatingCompanyCurrencyExchangeRateOperator = "operatingCompanyCurrencyExchangeRateOperator";
		public const string PropertyoperatingCompanyCurrencyExchangeRateDate = "operatingCompanyCurrencyExchangeRateDate";
		public const string PropertycustomerTradingAccountCurrency = "customerTradingAccountCurrency";
		public const string PropertycustomerTradingAccountCurrencyExchangeRate = "customerTradingAccountCurrencyExchangeRate";
		public const string PropertycustomerTradingAccountCurrencyExchangeRateOperator = "customerTradingAccountCurrencyExchangeRateOperator";
		public const string PropertycustomerTradingAccountCurrencyExchangeRateDate = "customerTradingAccountCurrencyExchangeRateDate";
		public const string Propertydate = "date";
		public const string Propertytime = "time";
		public const string Propertyvalidity = "validity";
		public const string PropertyexpirationDate = "expirationDate";
		public const string PropertytaxCodes = "taxCodes";
		public const string PropertybuyerContact = "buyerContact";
		public const string Propertysalespersons = "salespersons";
		public const string Propertyuser = "user";
		public const string PropertysalesQuotationLines = "salesQuotationLines";
		public const string PropertylineCount = "lineCount";
		public const string PropertyorderDiscountType = "orderDiscountType";
		public const string PropertyorderDiscountAmount = "orderDiscountAmount";
		public const string PropertyorderDiscountPercent = "orderDiscountPercent";
		public const string PropertyorderAdditionalDiscount1Type = "orderAdditionalDiscount1Type";
		public const string PropertyorderAdditionalDiscount1Amount = "orderAdditionalDiscount1Amount";
		public const string PropertyorderAdditionalDiscount1Percent = "orderAdditionalDiscount1Percent";
		public const string PropertyorderAdditionalDiscount2 = "orderAdditionalDiscount2";
		public const string PropertyorderAdditionalDiscount2Amount = "orderAdditionalDiscount2Amount";
		public const string PropertyorderAdditionalDiscount2Percent = "orderAdditionalDiscount2Percent";
		public const string Propertytext1 = "text1";
		public const string Propertytext2 = "text2";
		public const string PropertynetTotal = "netTotal";
		public const string PropertydiscountTotal = "discountTotal";
		public const string PropertychargesTotal = "chargesTotal";
		public const string PropertytaxTotal = "taxTotal";
		public const string PropertygrossTotal = "grossTotal";
		public const string PropertycostTotal = "costTotal";
		public const string PropertyprofitTotal = "profitTotal";
		public const string Propertycontract = "contract";
		public const string Propertyprojects = "projects";
		public const string PropertyfulfillmentLocations = "fulfillmentLocations";
		public const string PropertyfinancialAccounts = "financialAccounts";
		public const string Propertyinteractions = "interactions";
		public const string Propertynotes = "notes";
		public const string Propertylabel = "label";
		public const string PropertyCustomerId = "CustomerId";

		#endregion

		#region Fields

		private Nullable<System.Boolean> _active;
		private System.String _reference;
		private System.String _reference2;
		private System.String _status;
		private Nullable<System.Boolean> _statusFlag;
		private System.String _statusFlagText;
		private tradingAccountFeedEntry _tradingAccount;
		private System.String _customerReference;
		private opportunityFeedEntry _opportunity;
		private priceListFeedEntry _pricelist;
		private System.String _type;
		private Nullable<System.Boolean> _copyFlag;
		private salesQuotationFeedEntry _originatorDocument;
		private postalAddressFeed _postalAddresses;
		private System.String _deliveryMethod;
		private Nullable<System.Boolean> _deliveryRule;
		private System.String _deliveryTerms;
		private Nullable<System.DateTime> _deliveryDate;
		private Nullable<System.DateTime> _dueDate;
		private System.String _currency;
		private System.String _operatingCompanyCurrency;
		private Nullable<System.Decimal> _operatingCompanyCurrencyExchangeRate;
		private System.String _operatingCompanyCurrencyExchangeRateOperator;
		private Nullable<System.DateTime> _operatingCompanyCurrencyExchangeRateDate;
		private System.String _customerTradingAccountCurrency;
		private Nullable<System.Decimal> _customerTradingAccountCurrencyExchangeRate;
		private System.String _customerTradingAccountCurrencyExchangeRateOperator;
		private Nullable<System.DateTime> _customerTradingAccountCurrencyExchangeRateDate;
		private Nullable<System.DateTime> _date;
		private Nullable<System.DateTime> _time;
		private Nullable<System.Decimal> _validity;
		private Nullable<System.DateTime> _expirationDate;
		private taxCodeFeed _taxCodes;
		private contactFeedEntry _buyerContact;
		private salesPersonFeed _salespersons;
		private System.String _user;
		private salesQuotationLineFeed _salesQuotationLines;
		private Nullable<System.Decimal> _lineCount;
		private System.String _orderDiscountType;
		private Nullable<System.Decimal> _orderDiscountAmount;
		private Nullable<System.Decimal> _orderDiscountPercent;
		private System.String _orderAdditionalDiscount1Type;
		private Nullable<System.Decimal> _orderAdditionalDiscount1Amount;
		private Nullable<System.Decimal> _orderAdditionalDiscount1Percent;
		private System.String _orderAdditionalDiscount2;
		private Nullable<System.Decimal> _orderAdditionalDiscount2Amount;
		private Nullable<System.Decimal> _orderAdditionalDiscount2Percent;
		private System.String _text1;
		private System.String _text2;
		private Nullable<System.Decimal> _netTotal;
		private Nullable<System.Decimal> _discountTotal;
		private Nullable<System.Decimal> _chargesTotal;
		private Nullable<System.Decimal> _taxTotal;
		private Nullable<System.Decimal> _grossTotal;
		private Nullable<System.Decimal> _costTotal;
		private Nullable<System.Decimal> _profitTotal;
		private System.String _contract;
		private projectFeed _projects;
		private locationFeed _fulfillmentLocations;
		private financialAccountFeed _financialAccounts;
		private interactionFeed _interactions;
		private noteFeed _notes;
		private System.String _label;
		private System.String _CustomerId;

		#endregion

		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="salesQuotationFeedEntrySchema"/> class.
		/// </summary>
		#endregion
		public salesQuotationFeedEntrySchema()
		{
		}

		#region Properties


		[SMEBoolProperty(Label="SalesQuotation Active Flag", Nillable=true, Name="active", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.Boolean> active { get { return _active; } set { SetProperty(Propertyactive, ref _active, value); } }

		[SMEStringProperty(Label="SalesQuotation reference", Name="reference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true, IsUniqueKey=true)]			
		public virtual System.String reference { get { return _reference; } set { SetProperty(Propertyreference, ref _reference, value); } }

		[SMEStringProperty(Label="SalesQuotation Reference2", Name="reference2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String reference2 { get { return _reference2; } set { SetProperty(Propertyreference2, ref _reference2, value); } }

		[SMEStringProperty(Label="SalesQuotation Status", Name="status", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String status { get { return _status; } set { SetProperty(Propertystatus, ref _status, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEBoolProperty(Label="SalesQuotation Status Flag", Nillable=true, Name="statusFlag", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Boolean> statusFlag { get { return _statusFlag; } set { SetProperty(PropertystatusFlag, ref _statusFlag, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="SalesQuotation Status Flag Text", Name="statusFlagText", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String statusFlagText { get { return _statusFlagText; } set { SetProperty(PropertystatusFlagText, ref _statusFlagText, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="tradingAccounts", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="tradingAccount", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("tradingAccount")]			
		public virtual tradingAccountFeedEntry tradingAccount { get { return _tradingAccount; } set { SetProperty(PropertytradingAccount, ref _tradingAccount, value); } }

		[SMEStringProperty(Label="SalesQuotation Customer reference", Name="customerReference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String customerReference { get { return _customerReference; } set { SetProperty(PropertycustomerReference, ref _customerReference, value); } }

		[SMEResource(CanGet=true, PluralName="Opportunities", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="opportunity", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("opportunity")]			
		public virtual opportunityFeedEntry opportunity { get { return _opportunity; } set { SetProperty(Propertyopportunity, ref _opportunity, value); } }

		[SMEResource(CanGet=true, PluralName="priceLists", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="pricelist", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("pricelist")]			
		public virtual priceListFeedEntry pricelist { get { return _pricelist; } set { SetProperty(Propertypricelist, ref _pricelist, value); } }

		[SMEStringProperty(Label="SalesQuotation Type", Name="type", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String type { get { return _type; } set { SetProperty(Propertytype, ref _type, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEBoolProperty(Label="SalesQuotation Copy Flag", Nillable=true, Name="copyFlag", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Boolean> copyFlag { get { return _copyFlag; } set { SetProperty(PropertycopyFlag, ref _copyFlag, value); } }

		[SMEResource(CanGet=true, CanPost=true, PluralName="salesQuotations", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="originatorDocument", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("originatorDocument")]			
		public virtual salesQuotationFeedEntry originatorDocument { get { return _originatorDocument; } set { SetProperty(PropertyoriginatorDocument, ref _originatorDocument, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="postalAddresses", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="postalAddresses", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual postalAddressFeed postalAddresses { get { return _postalAddresses; } set { SetProperty(PropertypostalAddresses, ref _postalAddresses, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="SalesQuotation Delivery Method", Name="deliveryMethod", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String deliveryMethod { get { return _deliveryMethod; } set { SetProperty(PropertydeliveryMethod, ref _deliveryMethod, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEBoolProperty(Label="SalesQuotation Delivery Rule", Nillable=true, Name="deliveryRule", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Boolean> deliveryRule { get { return _deliveryRule; } set { SetProperty(PropertydeliveryRule, ref _deliveryRule, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="SalesQuotation Delivery Terms", Name="deliveryTerms", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String deliveryTerms { get { return _deliveryTerms; } set { SetProperty(PropertydeliveryTerms, ref _deliveryTerms, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDateProperty(Label="SalesQuotation Delivery Date", Nillable=true, Name="deliveryDate", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.DateTime> deliveryDate { get { return _deliveryDate; } set { SetProperty(PropertydeliveryDate, ref _deliveryDate, value); } }

		[SMEDateProperty(Label="SalesQuotation Due Date", Nillable=true, Name="dueDate", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.DateTime> dueDate { get { return _dueDate; } set { SetProperty(PropertydueDate, ref _dueDate, value); } }

		[SMEStringProperty(Label="SalesQuotation Currency", Name="currency", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String currency { get { return _currency; } set { SetProperty(Propertycurrency, ref _currency, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="SalesQuotation OperatingCompany Currency", Name="operatingCompanyCurrency", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String operatingCompanyCurrency { get { return _operatingCompanyCurrency; } set { SetProperty(PropertyoperatingCompanyCurrency, ref _operatingCompanyCurrency, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesQuotation OperatingCompany Currency Exchange Rate", Nillable=true, AverageLength=14, Name="operatingCompanyCurrencyExchangeRate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> operatingCompanyCurrencyExchangeRate { get { return _operatingCompanyCurrencyExchangeRate; } set { SetProperty(PropertyoperatingCompanyCurrencyExchangeRate, ref _operatingCompanyCurrencyExchangeRate, value); } }

		[SMEStringProperty(Label="SalesQuotation OperatingCompany Currency Exchange Rate Operator", Name="operatingCompanyCurrencyExchangeRateOperator", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String operatingCompanyCurrencyExchangeRateOperator { get { return _operatingCompanyCurrencyExchangeRateOperator; } set { SetProperty(PropertyoperatingCompanyCurrencyExchangeRateOperator, ref _operatingCompanyCurrencyExchangeRateOperator, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDateProperty(Label="SalesQuotation OperatingCompany Currency Exchange Rate Date", Nillable=true, Name="operatingCompanyCurrencyExchangeRateDate", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.DateTime> operatingCompanyCurrencyExchangeRateDate { get { return _operatingCompanyCurrencyExchangeRateDate; } set { SetProperty(PropertyoperatingCompanyCurrencyExchangeRateDate, ref _operatingCompanyCurrencyExchangeRateDate, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="SalesQuotation Customer TradingAccount Currency", Name="customerTradingAccountCurrency", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String customerTradingAccountCurrency { get { return _customerTradingAccountCurrency; } set { SetProperty(PropertycustomerTradingAccountCurrency, ref _customerTradingAccountCurrency, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesQuotation Customer TradingAccount Currency Exchange Rate", Nillable=true, AverageLength=14, Name="customerTradingAccountCurrencyExchangeRate", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> customerTradingAccountCurrencyExchangeRate { get { return _customerTradingAccountCurrencyExchangeRate; } set { SetProperty(PropertycustomerTradingAccountCurrencyExchangeRate, ref _customerTradingAccountCurrencyExchangeRate, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="SalesQuotation Customer TradingAccount Currency Exchange Rate Operator", Name="customerTradingAccountCurrencyExchangeRateOperator", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String customerTradingAccountCurrencyExchangeRateOperator { get { return _customerTradingAccountCurrencyExchangeRateOperator; } set { SetProperty(PropertycustomerTradingAccountCurrencyExchangeRateOperator, ref _customerTradingAccountCurrencyExchangeRateOperator, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDateProperty(Label="SalesQuotation Customer TradingAccount Currency Exchange Rate Date", Nillable=true, Name="customerTradingAccountCurrencyExchangeRateDate", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.DateTime> customerTradingAccountCurrencyExchangeRateDate { get { return _customerTradingAccountCurrencyExchangeRateDate; } set { SetProperty(PropertycustomerTradingAccountCurrencyExchangeRateDate, ref _customerTradingAccountCurrencyExchangeRateDate, value); } }

		[SMEDateProperty(Label="SalesQuotation Date", Nillable=true, Name="date", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.DateTime> date { get { return _date; } set { SetProperty(Propertydate, ref _date, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMETimeProperty(Label="SalesQuotation Time", Nillable=true, Name="time", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.DateTime> time { get { return _time; } set { SetProperty(Propertytime, ref _time, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesQuotation Validity", Nillable=true, AverageLength=14, Name="validity", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> validity { get { return _validity; } set { SetProperty(Propertyvalidity, ref _validity, value); } }

		[SMEDateProperty(Label="SalesQuotation Expiration Date", Nillable=true, Name="expirationDate", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.DateTime> expirationDate { get { return _expirationDate; } set { SetProperty(PropertyexpirationDate, ref _expirationDate, value); } }

		[SMEResource(CanGet=true, PluralName="taxCodes", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="taxCodes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual taxCodeFeed taxCodes { get { return _taxCodes; } set { SetProperty(PropertytaxCodes, ref _taxCodes, value); } }

		[SMEResource(CanGet=true, PluralName="contacts", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="buyerContact", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("buyerContact")]			
		public virtual contactFeedEntry buyerContact { get { return _buyerContact; } set { SetProperty(PropertybuyerContact, ref _buyerContact, value); } }

		[SMEResource(CanGet=true, PluralName="salesPersons", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="salespersons", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesPersonFeed salespersons { get { return _salespersons; } set { SetProperty(Propertysalespersons, ref _salespersons, value); } }

		[SMEStringProperty(Label="SalesQuotation User", Name="user", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String user { get { return _user; } set { SetProperty(Propertyuser, ref _user, value); } }

		[SMEResource(CanGet=true, CanDelete=true, PluralName="salesQuotationLines", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Child, IsCollection=true, Name="salesQuotationLines", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesQuotationLineFeed salesQuotationLines { get { return _salesQuotationLines; } set { SetProperty(PropertysalesQuotationLines, ref _salesQuotationLines, value); } }

		[SMEDecimalProperty(DecimalPlaces=0, Label="SalesQuotation Line Count", Nillable=true, AverageLength=12, Name="lineCount", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> lineCount { get { return _lineCount; } set { SetProperty(PropertylineCount, ref _lineCount, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="SalesQuotation Order Discount Type", Name="orderDiscountType", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String orderDiscountType { get { return _orderDiscountType; } set { SetProperty(PropertyorderDiscountType, ref _orderDiscountType, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesQuotation Order Discount Amount", Nillable=true, AverageLength=14, Name="orderDiscountAmount", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> orderDiscountAmount { get { return _orderDiscountAmount; } set { SetProperty(PropertyorderDiscountAmount, ref _orderDiscountAmount, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesQuotation Order Discount Percent", Nillable=true, AverageLength=14, Name="orderDiscountPercent", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> orderDiscountPercent { get { return _orderDiscountPercent; } set { SetProperty(PropertyorderDiscountPercent, ref _orderDiscountPercent, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="SalesQuotation Order Additional Discount1 Type", Name="orderAdditionalDiscount1Type", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String orderAdditionalDiscount1Type { get { return _orderAdditionalDiscount1Type; } set { SetProperty(PropertyorderAdditionalDiscount1Type, ref _orderAdditionalDiscount1Type, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesQuotation Order Additional Discount1 Amount", Nillable=true, AverageLength=14, Name="orderAdditionalDiscount1Amount", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> orderAdditionalDiscount1Amount { get { return _orderAdditionalDiscount1Amount; } set { SetProperty(PropertyorderAdditionalDiscount1Amount, ref _orderAdditionalDiscount1Amount, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesQuotation Order Additional Discount1 Percent", Nillable=true, AverageLength=14, Name="orderAdditionalDiscount1Percent", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> orderAdditionalDiscount1Percent { get { return _orderAdditionalDiscount1Percent; } set { SetProperty(PropertyorderAdditionalDiscount1Percent, ref _orderAdditionalDiscount1Percent, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="SalesQuotation Order Additional Discount2 Type", Name="orderAdditionalDiscount2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String orderAdditionalDiscount2 { get { return _orderAdditionalDiscount2; } set { SetProperty(PropertyorderAdditionalDiscount2, ref _orderAdditionalDiscount2, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesQuotation Order Additional Discount2 Amount", Nillable=true, AverageLength=14, Name="orderAdditionalDiscount2Amount", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> orderAdditionalDiscount2Amount { get { return _orderAdditionalDiscount2Amount; } set { SetProperty(PropertyorderAdditionalDiscount2Amount, ref _orderAdditionalDiscount2Amount, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesQuotation Order Additional Discount2 Percent", Nillable=true, AverageLength=14, Name="orderAdditionalDiscount2Percent", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> orderAdditionalDiscount2Percent { get { return _orderAdditionalDiscount2Percent; } set { SetProperty(PropertyorderAdditionalDiscount2Percent, ref _orderAdditionalDiscount2Percent, value); } }

		[SMEStringProperty(Label="SalesQuotation Text1", Name="text1", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String text1 { get { return _text1; } set { SetProperty(Propertytext1, ref _text1, value); } }

		[SMEStringProperty(Label="SalesQuotation Text2", Name="text2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String text2 { get { return _text2; } set { SetProperty(Propertytext2, ref _text2, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesQuotation Net Total", Nillable=true, AverageLength=14, Name="netTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> netTotal { get { return _netTotal; } set { SetProperty(PropertynetTotal, ref _netTotal, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesQuotation Discount Total", Nillable=true, AverageLength=14, Name="discountTotal", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> discountTotal { get { return _discountTotal; } set { SetProperty(PropertydiscountTotal, ref _discountTotal, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesQuotation Charges Total", Nillable=true, AverageLength=14, Name="chargesTotal", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> chargesTotal { get { return _chargesTotal; } set { SetProperty(PropertychargesTotal, ref _chargesTotal, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesQuotation Tax Total", Nillable=true, AverageLength=14, Name="taxTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> taxTotal { get { return _taxTotal; } set { SetProperty(PropertytaxTotal, ref _taxTotal, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesQuotation Gross Total", Nillable=true, AverageLength=14, Name="grossTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> grossTotal { get { return _grossTotal; } set { SetProperty(PropertygrossTotal, ref _grossTotal, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesQuotation Cost Total", Nillable=true, AverageLength=14, Name="costTotal", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> costTotal { get { return _costTotal; } set { SetProperty(PropertycostTotal, ref _costTotal, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesQuotation Profit Total", Nillable=true, AverageLength=14, Name="profitTotal", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> profitTotal { get { return _profitTotal; } set { SetProperty(PropertyprofitTotal, ref _profitTotal, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="SalesQuotation Contract", Name="contract", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String contract { get { return _contract; } set { SetProperty(Propertycontract, ref _contract, value); } }

		[SMEResource(CanGet=true, PluralName="projects", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="projects", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual projectFeed projects { get { return _projects; } set { SetProperty(Propertyprojects, ref _projects, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="locations", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="fulfillmentLocations", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual locationFeed fulfillmentLocations { get { return _fulfillmentLocations; } set { SetProperty(PropertyfulfillmentLocations, ref _fulfillmentLocations, value); } }

		[SMEResource(CanGet=true, PluralName="financialAccounts", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="financialAccounts", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual financialAccountFeed financialAccounts { get { return _financialAccounts; } set { SetProperty(PropertyfinancialAccounts, ref _financialAccounts, value); } }

		[SMEResource(CanGet=true, PluralName="interactions", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="interactions", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual interactionFeed interactions { get { return _interactions; } set { SetProperty(Propertyinteractions, ref _interactions, value); } }

		[SMEResource(CanGet=true, CanPut=true, PluralName="notes", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="notes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual noteFeed notes { get { return _notes; } set { SetProperty(Propertynotes, ref _notes, value); } }

		[SMEStringProperty(Label="SalesQuotation Label", Name="label", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String label { get { return _label; } set { SetProperty(Propertylabel, ref _label, value); } }

		[SMEStringProperty(Label="CustomerId", Name="CustomerId", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String CustomerId { get { return _CustomerId; } set { SetProperty(PropertyCustomerId, ref _CustomerId, value); } }

		#endregion


	}
}