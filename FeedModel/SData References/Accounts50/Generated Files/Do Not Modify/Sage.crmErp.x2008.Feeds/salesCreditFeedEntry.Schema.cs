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
	/// Defines a salesCredit feed entry
	/// </summary>
	#endregion
	[System.ComponentModel.Browsable(false)]
	[XmlType("salesCredit", Namespace="http://schemas.sage.com/crmErp/2008")]
	public class salesCreditFeedEntrySchema : Sage.Common.Syndication.FeedEntry
	{
		#region Constants

		public const string Propertyactive = "active";
		public const string Propertyreference = "reference";
		public const string Propertyreference2 = "reference2";
		public const string Propertystatus = "status";
		public const string PropertystatusFlag = "statusFlag";
		public const string PropertystatusFlagText = "statusFlagText";
		public const string Propertytype = "type";
		public const string PropertytradingAccount = "tradingAccount";
		public const string PropertycustomerReference = "customerReference";
		public const string Propertyopportunity = "opportunity";
		public const string Propertypricelist = "pricelist";
		public const string PropertycopyFlag = "copyFlag";
		public const string Propertydate = "date";
		public const string Propertytime = "time";
		public const string PropertytaxDate = "taxDate";
		public const string PropertytaxCodes = "taxCodes";
		public const string PropertypostalAddresses = "postalAddresses";
		public const string PropertydeliveryMethod = "deliveryMethod";
		public const string PropertydeliveryTerms = "deliveryTerms";
		public const string PropertydeliveryRule = "deliveryRule";
		public const string PropertydeliveryDate = "deliveryDate";
		public const string PropertycarrierCompany = "carrierCompany";
		public const string PropertycarrierTradingAccount = "carrierTradingAccount";
		public const string PropertycarrierNetPrice = "carrierNetPrice";
		public const string PropertycarrierTaxPrice = "carrierTaxPrice";
		public const string PropertycarrierTotalPrice = "carrierTotalPrice";
		public const string PropertycarrierSalesInvoice = "carrierSalesInvoice";
		public const string PropertycarrierTaxCodes = "carrierTaxCodes";
		public const string PropertycarrierReference = "carrierReference";
		public const string Propertycurrency = "currency";
		public const string PropertyoperatingCompanyCurrency = "operatingCompanyCurrency";
		public const string PropertyoperatingCompanyCurrencyExchangeRate = "operatingCompanyCurrencyExchangeRate";
		public const string PropertyoperatingCompanyCurrencyExchangeRateOperator = "operatingCompanyCurrencyExchangeRateOperator";
		public const string PropertyoperatingCompanyCurrencyExchangeRateDate = "operatingCompanyCurrencyExchangeRateDate";
		public const string PropertycustomerTradingAccountCurrency = "customerTradingAccountCurrency";
		public const string PropertycustomerTradingAccountCurrencyExchangeRate = "customerTradingAccountCurrencyExchangeRate";
		public const string PropertycustomerTradingAccountCurrencyExchangeRateOperator = "customerTradingAccountCurrencyExchangeRateOperator";
		public const string PropertycustomerTradingAccountCurrencyExchangeRateDate = "customerTradingAccountCurrencyExchangeRateDate";
		public const string PropertybuyerContact = "buyerContact";
		public const string Propertysalespersons = "salespersons";
		public const string PropertysalesCreditLines = "salesCreditLines";
		public const string PropertylineCount = "lineCount";
		public const string PropertyoriginatorDocument = "originatorDocument";
		public const string Propertycontract = "contract";
		public const string PropertysettlementDiscountType = "settlementDiscountType";
		public const string PropertysettlementDiscountAmount = "settlementDiscountAmount";
		public const string PropertysettlementDiscountPercent = "settlementDiscountPercent";
		public const string PropertysettlementDiscountTerms = "settlementDiscountTerms";
		public const string PropertysettlementDiscountIncludedInTotal = "settlementDiscountIncludedInTotal";
		public const string PropertyinvoiceDiscountType = "invoiceDiscountType";
		public const string PropertyinvoiceDiscountAmount = "invoiceDiscountAmount";
		public const string PropertyinvoiceDiscountPercent = "invoiceDiscountPercent";
		public const string PropertyinvoiceAdditionalDiscount1Type = "invoiceAdditionalDiscount1Type";
		public const string PropertyinvoiceAdditionalDiscount1Amount = "invoiceAdditionalDiscount1Amount";
		public const string PropertyinvoiceAdditionalDiscount1Percent = "invoiceAdditionalDiscount1Percent";
		public const string PropertyinvoiceAdditionalDiscount2 = "invoiceAdditionalDiscount2";
		public const string PropertyinvoiceAdditionalDiscount2Amount = "invoiceAdditionalDiscount2Amount";
		public const string PropertyinvoiceAdditionalDiscount2Percent = "invoiceAdditionalDiscount2Percent";
		public const string PropertynetTotal = "netTotal";
		public const string PropertydiscountTotal = "discountTotal";
		public const string PropertychargesTotal = "chargesTotal";
		public const string PropertytaxTotal = "taxTotal";
		public const string PropertygrossTotal = "grossTotal";
		public const string PropertycostTotal = "costTotal";
		public const string Propertytext1 = "text1";
		public const string Propertytext2 = "text2";
		public const string Propertyprojects = "projects";
		public const string PropertyfinancialAccounts = "financialAccounts";
		public const string Propertyinteractions = "interactions";
		public const string Propertyuser = "user";
		public const string Propertynotes = "notes";
		public const string PropertyCustomerId = "CustomerId";

		#endregion

		#region Fields

		private Nullable<System.Boolean> _active;
		private System.String _reference;
		private System.String _reference2;
		private System.String _status;
		private Nullable<System.Boolean> _statusFlag;
		private System.String _statusFlagText;
		private System.String _type;
		private tradingAccountFeedEntry _tradingAccount;
		private System.String _customerReference;
		private opportunityFeedEntry _opportunity;
		private priceListFeedEntry _pricelist;
		private Nullable<System.Boolean> _copyFlag;
		private Nullable<System.DateTime> _date;
		private Nullable<System.DateTime> _time;
		private Nullable<System.DateTime> _taxDate;
		private taxCodeFeed _taxCodes;
		private postalAddressFeed _postalAddresses;
		private System.String _deliveryMethod;
		private System.String _deliveryTerms;
		private Nullable<System.Boolean> _deliveryRule;
		private Nullable<System.DateTime> _deliveryDate;
		private System.String _carrierCompany;
		private tradingAccountFeed _carrierTradingAccount;
		private Nullable<System.Decimal> _carrierNetPrice;
		private Nullable<System.Decimal> _carrierTaxPrice;
		private Nullable<System.Decimal> _carrierTotalPrice;
		private salesInvoiceFeed _carrierSalesInvoice;
		private taxCodeFeed _carrierTaxCodes;
		private System.String _carrierReference;
		private System.String _currency;
		private System.String _operatingCompanyCurrency;
		private Nullable<System.Decimal> _operatingCompanyCurrencyExchangeRate;
		private System.String _operatingCompanyCurrencyExchangeRateOperator;
		private Nullable<System.DateTime> _operatingCompanyCurrencyExchangeRateDate;
		private System.String _customerTradingAccountCurrency;
		private Nullable<System.Decimal> _customerTradingAccountCurrencyExchangeRate;
		private System.String _customerTradingAccountCurrencyExchangeRateOperator;
		private Nullable<System.DateTime> _customerTradingAccountCurrencyExchangeRateDate;
		private contactFeedEntry _buyerContact;
		private salesPersonFeed _salespersons;
		private salesCreditLineFeed _salesCreditLines;
		private Nullable<System.Decimal> _lineCount;
		private salesInvoiceFeedEntry _originatorDocument;
		private System.String _contract;
		private System.String _settlementDiscountType;
		private Nullable<System.Decimal> _settlementDiscountAmount;
		private Nullable<System.Decimal> _settlementDiscountPercent;
		private System.String _settlementDiscountTerms;
		private Nullable<System.Boolean> _settlementDiscountIncludedInTotal;
		private System.String _invoiceDiscountType;
		private Nullable<System.Decimal> _invoiceDiscountAmount;
		private Nullable<System.Decimal> _invoiceDiscountPercent;
		private System.String _invoiceAdditionalDiscount1Type;
		private Nullable<System.Decimal> _invoiceAdditionalDiscount1Amount;
		private Nullable<System.Decimal> _invoiceAdditionalDiscount1Percent;
		private System.String _invoiceAdditionalDiscount2;
		private Nullable<System.Decimal> _invoiceAdditionalDiscount2Amount;
		private Nullable<System.Decimal> _invoiceAdditionalDiscount2Percent;
		private Nullable<System.Decimal> _netTotal;
		private Nullable<System.Decimal> _discountTotal;
		private Nullable<System.Decimal> _chargesTotal;
		private Nullable<System.Decimal> _taxTotal;
		private Nullable<System.Decimal> _grossTotal;
		private Nullable<System.Decimal> _costTotal;
		private System.String _text1;
		private System.String _text2;
		private projectFeed _projects;
		private financialAccountFeed _financialAccounts;
		private interactionFeed _interactions;
		private System.String _user;
		private noteFeed _notes;
		private System.DateTime _CustomerId;

		#endregion

		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="salesCreditFeedEntrySchema"/> class.
		/// </summary>
		#endregion
		public salesCreditFeedEntrySchema()
		{
		}

		#region Properties


		[SMEBoolProperty(Label="SalesCredit Active Flag", Nillable=true, Name="active", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.Boolean> active { get { return _active; } set { SetProperty(Propertyactive, ref _active, value); } }

		[SMEStringProperty(Label="SalesCredit reference", Name="reference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true, IsUniqueKey=true)]			
		public virtual System.String reference { get { return _reference; } set { SetProperty(Propertyreference, ref _reference, value); } }

		[SMEStringProperty(Label="SalesCredit Reference2", Name="reference2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String reference2 { get { return _reference2; } set { SetProperty(Propertyreference2, ref _reference2, value); } }

		[SMEStringProperty(Label="SalesCredit Status", Name="status", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String status { get { return _status; } set { SetProperty(Propertystatus, ref _status, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEBoolProperty(Label="SalesCredit Status Flag", Nillable=true, Name="statusFlag", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Boolean> statusFlag { get { return _statusFlag; } set { SetProperty(PropertystatusFlag, ref _statusFlag, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="SalesCredit Status Flag Text", Name="statusFlagText", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String statusFlagText { get { return _statusFlagText; } set { SetProperty(PropertystatusFlagText, ref _statusFlagText, value); } }

		[SMEStringProperty(Label="SalesCredit Type", Name="type", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String type { get { return _type; } set { SetProperty(Propertytype, ref _type, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="tradingAccounts", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="tradingAccount", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("tradingAccount")]			
		public virtual tradingAccountFeedEntry tradingAccount { get { return _tradingAccount; } set { SetProperty(PropertytradingAccount, ref _tradingAccount, value); } }

		[SMEStringProperty(Label="SalesCredit Customer reference", Name="customerReference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String customerReference { get { return _customerReference; } set { SetProperty(PropertycustomerReference, ref _customerReference, value); } }

		[SMEResource(CanGet=true, PluralName="Opportunities", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="opportunity", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("opportunity")]			
		public virtual opportunityFeedEntry opportunity { get { return _opportunity; } set { SetProperty(Propertyopportunity, ref _opportunity, value); } }

		[SMEResource(CanGet=true, PluralName="priceLists", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="pricelist", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("pricelist")]			
		public virtual priceListFeedEntry pricelist { get { return _pricelist; } set { SetProperty(Propertypricelist, ref _pricelist, value); } }

		[SMEBoolProperty(Label="SalesCredit Copy Flag", Nillable=true, Name="copyFlag", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.Boolean> copyFlag { get { return _copyFlag; } set { SetProperty(PropertycopyFlag, ref _copyFlag, value); } }

		[SMEDateProperty(Label="SalesCredit Date", Nillable=true, Name="date", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.DateTime> date { get { return _date; } set { SetProperty(Propertydate, ref _date, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMETimeProperty(Label="SalesCredit Time", Nillable=true, Name="time", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.DateTime> time { get { return _time; } set { SetProperty(Propertytime, ref _time, value); } }

		[SMEDateProperty(Label="SalesCredit Tax Date", Nillable=true, Name="taxDate", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.DateTime> taxDate { get { return _taxDate; } set { SetProperty(PropertytaxDate, ref _taxDate, value); } }

		[SMEResource(CanGet=true, PluralName="taxCodes", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="taxCodes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual taxCodeFeed taxCodes { get { return _taxCodes; } set { SetProperty(PropertytaxCodes, ref _taxCodes, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="postalAddresses", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="postalAddresses", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual postalAddressFeed postalAddresses { get { return _postalAddresses; } set { SetProperty(PropertypostalAddresses, ref _postalAddresses, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="SalesCredit Delivery Method", Name="deliveryMethod", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String deliveryMethod { get { return _deliveryMethod; } set { SetProperty(PropertydeliveryMethod, ref _deliveryMethod, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="SalesCredit Delivery Terms", Name="deliveryTerms", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String deliveryTerms { get { return _deliveryTerms; } set { SetProperty(PropertydeliveryTerms, ref _deliveryTerms, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEBoolProperty(Label="SalesCredit Delivery Rule", Nillable=true, Name="deliveryRule", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Boolean> deliveryRule { get { return _deliveryRule; } set { SetProperty(PropertydeliveryRule, ref _deliveryRule, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDateProperty(Label="SalesCredit Delivery Date", Nillable=true, Name="deliveryDate", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.DateTime> deliveryDate { get { return _deliveryDate; } set { SetProperty(PropertydeliveryDate, ref _deliveryDate, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="SalesCredit Carrier Company", Name="carrierCompany", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String carrierCompany { get { return _carrierCompany; } set { SetProperty(PropertycarrierCompany, ref _carrierCompany, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="tradingAccounts", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="carrierTradingAccount", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual tradingAccountFeed carrierTradingAccount { get { return _carrierTradingAccount; } set { SetProperty(PropertycarrierTradingAccount, ref _carrierTradingAccount, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesCredit Carrier Net Price", Nillable=true, AverageLength=14, Name="carrierNetPrice", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> carrierNetPrice { get { return _carrierNetPrice; } set { SetProperty(PropertycarrierNetPrice, ref _carrierNetPrice, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesCredit Carrier Tax Price", Nillable=true, AverageLength=14, Name="carrierTaxPrice", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> carrierTaxPrice { get { return _carrierTaxPrice; } set { SetProperty(PropertycarrierTaxPrice, ref _carrierTaxPrice, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesCredit Carrier Gross Price", Nillable=true, AverageLength=14, Name="carrierTotalPrice", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> carrierTotalPrice { get { return _carrierTotalPrice; } set { SetProperty(PropertycarrierTotalPrice, ref _carrierTotalPrice, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanDelete=true, PluralName="salesInvoices", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="carrierSalesInvoice", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesInvoiceFeed carrierSalesInvoice { get { return _carrierSalesInvoice; } set { SetProperty(PropertycarrierSalesInvoice, ref _carrierSalesInvoice, value); } }

		[SMEResource(CanGet=true, PluralName="taxCodes", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="carrierTaxCodes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual taxCodeFeed carrierTaxCodes { get { return _carrierTaxCodes; } set { SetProperty(PropertycarrierTaxCodes, ref _carrierTaxCodes, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="SalesCredit Carrier reference", Name="carrierReference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String carrierReference { get { return _carrierReference; } set { SetProperty(PropertycarrierReference, ref _carrierReference, value); } }

		[SMEStringProperty(Label="SalesCredit Currency", Name="currency", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String currency { get { return _currency; } set { SetProperty(Propertycurrency, ref _currency, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="SalesCredit OperatingCompany Currency", Name="operatingCompanyCurrency", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String operatingCompanyCurrency { get { return _operatingCompanyCurrency; } set { SetProperty(PropertyoperatingCompanyCurrency, ref _operatingCompanyCurrency, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesCredit OperatingCompany Currency Exchange Rate", Nillable=true, AverageLength=14, Name="operatingCompanyCurrencyExchangeRate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> operatingCompanyCurrencyExchangeRate { get { return _operatingCompanyCurrencyExchangeRate; } set { SetProperty(PropertyoperatingCompanyCurrencyExchangeRate, ref _operatingCompanyCurrencyExchangeRate, value); } }

		[SMEStringProperty(Label="SalesCredit OperatingCompany Currency Exchange Rate Operator", Name="operatingCompanyCurrencyExchangeRateOperator", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String operatingCompanyCurrencyExchangeRateOperator { get { return _operatingCompanyCurrencyExchangeRateOperator; } set { SetProperty(PropertyoperatingCompanyCurrencyExchangeRateOperator, ref _operatingCompanyCurrencyExchangeRateOperator, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDateProperty(Label="SalesCredit OperatingCompany Currency Exchange Rate Date", Nillable=true, Name="operatingCompanyCurrencyExchangeRateDate", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.DateTime> operatingCompanyCurrencyExchangeRateDate { get { return _operatingCompanyCurrencyExchangeRateDate; } set { SetProperty(PropertyoperatingCompanyCurrencyExchangeRateDate, ref _operatingCompanyCurrencyExchangeRateDate, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="SalesCredit Customer TradingAccount Currency", Name="customerTradingAccountCurrency", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String customerTradingAccountCurrency { get { return _customerTradingAccountCurrency; } set { SetProperty(PropertycustomerTradingAccountCurrency, ref _customerTradingAccountCurrency, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesCredit Customer TradingAccount Currency Exchange Rate", Nillable=true, AverageLength=14, Name="customerTradingAccountCurrencyExchangeRate", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> customerTradingAccountCurrencyExchangeRate { get { return _customerTradingAccountCurrencyExchangeRate; } set { SetProperty(PropertycustomerTradingAccountCurrencyExchangeRate, ref _customerTradingAccountCurrencyExchangeRate, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="SalesCredit Customer TradingAccount Currency Exchange Rate Operator", Name="customerTradingAccountCurrencyExchangeRateOperator", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String customerTradingAccountCurrencyExchangeRateOperator { get { return _customerTradingAccountCurrencyExchangeRateOperator; } set { SetProperty(PropertycustomerTradingAccountCurrencyExchangeRateOperator, ref _customerTradingAccountCurrencyExchangeRateOperator, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDateProperty(Label="SalesCredit Customer TradingAccount Currency Exchange Rate Date", Nillable=true, Name="customerTradingAccountCurrencyExchangeRateDate", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.DateTime> customerTradingAccountCurrencyExchangeRateDate { get { return _customerTradingAccountCurrencyExchangeRateDate; } set { SetProperty(PropertycustomerTradingAccountCurrencyExchangeRateDate, ref _customerTradingAccountCurrencyExchangeRateDate, value); } }

		[SMEResource(CanGet=true, PluralName="contacts", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="buyerContact", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("buyerContact")]			
		public virtual contactFeedEntry buyerContact { get { return _buyerContact; } set { SetProperty(PropertybuyerContact, ref _buyerContact, value); } }

		[SMEResource(CanGet=true, PluralName="salesPersons", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="salespersons", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesPersonFeed salespersons { get { return _salespersons; } set { SetProperty(Propertysalespersons, ref _salespersons, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="salesCreditLines", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Child, IsCollection=true, Name="salesCreditLines", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesCreditLineFeed salesCreditLines { get { return _salesCreditLines; } set { SetProperty(PropertysalesCreditLines, ref _salesCreditLines, value); } }

		[SMEDecimalProperty(DecimalPlaces=0, Label="SalesCredit Line Count", Nillable=true, AverageLength=12, Name="lineCount", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> lineCount { get { return _lineCount; } set { SetProperty(PropertylineCount, ref _lineCount, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanDelete=true, PluralName="salesInvoices", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="originatorDocument", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("originatorDocument")]			
		public virtual salesInvoiceFeedEntry originatorDocument { get { return _originatorDocument; } set { SetProperty(PropertyoriginatorDocument, ref _originatorDocument, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="SalesCredit Contract", Name="contract", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String contract { get { return _contract; } set { SetProperty(Propertycontract, ref _contract, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="SalesCredit Settlement Discount Type", Name="settlementDiscountType", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String settlementDiscountType { get { return _settlementDiscountType; } set { SetProperty(PropertysettlementDiscountType, ref _settlementDiscountType, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesCredit Settlement Discount Amount", Nillable=true, AverageLength=14, Name="settlementDiscountAmount", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> settlementDiscountAmount { get { return _settlementDiscountAmount; } set { SetProperty(PropertysettlementDiscountAmount, ref _settlementDiscountAmount, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesCredit Settlement Discount Percent", Nillable=true, AverageLength=14, Name="settlementDiscountPercent", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> settlementDiscountPercent { get { return _settlementDiscountPercent; } set { SetProperty(PropertysettlementDiscountPercent, ref _settlementDiscountPercent, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="SalesCredit Settlement Discount Terms", Name="settlementDiscountTerms", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String settlementDiscountTerms { get { return _settlementDiscountTerms; } set { SetProperty(PropertysettlementDiscountTerms, ref _settlementDiscountTerms, value); } }

		[SMEBoolProperty(Label="SalesCredit Settlement Discount Included In Total", Nillable=true, Name="settlementDiscountIncludedInTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Boolean> settlementDiscountIncludedInTotal { get { return _settlementDiscountIncludedInTotal; } set { SetProperty(PropertysettlementDiscountIncludedInTotal, ref _settlementDiscountIncludedInTotal, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="SalesCredit Invoice Discount Type", Name="invoiceDiscountType", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String invoiceDiscountType { get { return _invoiceDiscountType; } set { SetProperty(PropertyinvoiceDiscountType, ref _invoiceDiscountType, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesCredit Invoice Discount Amount", Nillable=true, AverageLength=14, Name="invoiceDiscountAmount", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> invoiceDiscountAmount { get { return _invoiceDiscountAmount; } set { SetProperty(PropertyinvoiceDiscountAmount, ref _invoiceDiscountAmount, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesCredit Invoice Discount Percent", Nillable=true, AverageLength=14, Name="invoiceDiscountPercent", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> invoiceDiscountPercent { get { return _invoiceDiscountPercent; } set { SetProperty(PropertyinvoiceDiscountPercent, ref _invoiceDiscountPercent, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="SalesCredit Invoice Additional Discount1 Type", Name="invoiceAdditionalDiscount1Type", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String invoiceAdditionalDiscount1Type { get { return _invoiceAdditionalDiscount1Type; } set { SetProperty(PropertyinvoiceAdditionalDiscount1Type, ref _invoiceAdditionalDiscount1Type, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesCredit Invoice Additional Discount1 Amount", Nillable=true, AverageLength=14, Name="invoiceAdditionalDiscount1Amount", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> invoiceAdditionalDiscount1Amount { get { return _invoiceAdditionalDiscount1Amount; } set { SetProperty(PropertyinvoiceAdditionalDiscount1Amount, ref _invoiceAdditionalDiscount1Amount, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesCredit Invoice Additional Discount1 Percent", Nillable=true, AverageLength=14, Name="invoiceAdditionalDiscount1Percent", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> invoiceAdditionalDiscount1Percent { get { return _invoiceAdditionalDiscount1Percent; } set { SetProperty(PropertyinvoiceAdditionalDiscount1Percent, ref _invoiceAdditionalDiscount1Percent, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="SalesCredit Invoice Additional Discount2 Type", Name="invoiceAdditionalDiscount2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String invoiceAdditionalDiscount2 { get { return _invoiceAdditionalDiscount2; } set { SetProperty(PropertyinvoiceAdditionalDiscount2, ref _invoiceAdditionalDiscount2, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesCredit Invoice Additional Discount2 Amount", Nillable=true, AverageLength=14, Name="invoiceAdditionalDiscount2Amount", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> invoiceAdditionalDiscount2Amount { get { return _invoiceAdditionalDiscount2Amount; } set { SetProperty(PropertyinvoiceAdditionalDiscount2Amount, ref _invoiceAdditionalDiscount2Amount, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesCredit Invoice Additional Discount2 Percent", Nillable=true, AverageLength=14, Name="invoiceAdditionalDiscount2Percent", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> invoiceAdditionalDiscount2Percent { get { return _invoiceAdditionalDiscount2Percent; } set { SetProperty(PropertyinvoiceAdditionalDiscount2Percent, ref _invoiceAdditionalDiscount2Percent, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesCredit Net Total", Nillable=true, AverageLength=14, Name="netTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> netTotal { get { return _netTotal; } set { SetProperty(PropertynetTotal, ref _netTotal, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesCredit Discount Total", Nillable=true, AverageLength=14, Name="discountTotal", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> discountTotal { get { return _discountTotal; } set { SetProperty(PropertydiscountTotal, ref _discountTotal, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesCredit Charges Total", Nillable=true, AverageLength=14, Name="chargesTotal", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> chargesTotal { get { return _chargesTotal; } set { SetProperty(PropertychargesTotal, ref _chargesTotal, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesCredit Tax Total", Nillable=true, AverageLength=14, Name="taxTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> taxTotal { get { return _taxTotal; } set { SetProperty(PropertytaxTotal, ref _taxTotal, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesCredit Gross Total", Nillable=true, AverageLength=14, Name="grossTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> grossTotal { get { return _grossTotal; } set { SetProperty(PropertygrossTotal, ref _grossTotal, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesCredit Cost Total", Nillable=true, AverageLength=14, Name="costTotal", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> costTotal { get { return _costTotal; } set { SetProperty(PropertycostTotal, ref _costTotal, value); } }

		[SMEStringProperty(Label="SalesCredit Text1", Name="text1", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String text1 { get { return _text1; } set { SetProperty(Propertytext1, ref _text1, value); } }

		[SMEStringProperty(Label="SalesCredit Text2", Name="text2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String text2 { get { return _text2; } set { SetProperty(Propertytext2, ref _text2, value); } }

		[SMEResource(CanGet=true, PluralName="projects", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="projects", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual projectFeed projects { get { return _projects; } set { SetProperty(Propertyprojects, ref _projects, value); } }

		[SMEResource(CanGet=true, PluralName="financialAccounts", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="financialAccounts", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual financialAccountFeed financialAccounts { get { return _financialAccounts; } set { SetProperty(PropertyfinancialAccounts, ref _financialAccounts, value); } }

		[SMEResource(CanGet=true, PluralName="interactions", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="interactions", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual interactionFeed interactions { get { return _interactions; } set { SetProperty(Propertyinteractions, ref _interactions, value); } }

		[SMEStringProperty(Label="SalesCredit User", Name="user", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String user { get { return _user; } set { SetProperty(Propertyuser, ref _user, value); } }

		[SMEResource(CanGet=true, CanPut=true, PluralName="notes", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="notes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual noteFeed notes { get { return _notes; } set { SetProperty(Propertynotes, ref _notes, value); } }

		[SMETimeProperty(Label="Customer Identifier", Name="CustomerId", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.DateTime CustomerId { get { return _CustomerId; } set { SetProperty(PropertyCustomerId, ref _CustomerId, value); } }

		#endregion


	}
}