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
	/// Defines a tradingAccount feed entry
	/// </summary>
	#endregion
	[System.ComponentModel.Browsable(false)]
	[XmlType("tradingAccount", Namespace="http://schemas.sage.com/crmErp/2008")]
	public class tradingAccountFeedEntrySchema : Sage.Common.Syndication.FeedEntry
	{
		#region Constants

		public const string Propertyactive = "active";
		public const string PropertycustomerSupplierFlag = "customerSupplierFlag";
		public const string PropertycompanyPersonFlag = "companyPersonFlag";
		public const string PropertyinvoiceTradingAccount = "invoiceTradingAccount";
		public const string PropertyopenedDate = "openedDate";
		public const string Propertyreference = "reference";
		public const string Propertyreference2 = "reference2";
		public const string Propertystatus = "status";
		public const string Propertyname = "name";
		public const string PropertyshortName = "shortName";
		public const string Propertytype = "type";
		public const string PropertyregisteredAddress = "registeredAddress";
		public const string PropertypostalAddresses = "postalAddresses";
		public const string PropertyshippingAddresses = "shippingAddresses";
		public const string PropertybillingAddresses = "billingAddresses";
		public const string Propertyphones = "phones";
		public const string Propertyemails = "emails";
		public const string Propertywebsite = "website";
		public const string Propertycontacts = "contacts";
		public const string PropertydeliveryContact = "deliveryContact";
		public const string PropertysalesPersons = "salesPersons";
		public const string PropertydeliveryMethod = "deliveryMethod";
		public const string PropertydeliveryRule = "deliveryRule";
		public const string Propertycurrency = "currency";
		public const string PropertytaxCode = "taxCode";
		public const string PropertytaxReference = "taxReference";
		public const string PropertytaxationCountry = "taxationCountry";
		public const string PropertyuseTaxInclusivePrices = "useTaxInclusivePrices";
		public const string PropertyfinanceBalance = "financeBalance";
		public const string PropertyfinanceLimit = "financeLimit";
		public const string PropertyfinanceBalanceDate = "financeBalanceDate";
		public const string PropertyfinanceStatusFlag = "financeStatusFlag";
		public const string PropertyfinanceStatusText = "financeStatusText";
		public const string PropertysettlementDiscountType = "settlementDiscountType";
		public const string PropertysettlementDiscountAmount = "settlementDiscountAmount";
		public const string PropertysettlementDiscountPercent = "settlementDiscountPercent";
		public const string PropertysettlementDiscountTerms = "settlementDiscountTerms";
		public const string PropertysettlementDiscountTermsCommencement = "settlementDiscountTermsCommencement";
		public const string PropertysettlementDiscountIncludedInTotal = "settlementDiscountIncludedInTotal";
		public const string PropertypaymentTerms = "paymentTerms";
		public const string PropertypaymentTermsCommencement = "paymentTermsCommencement";
		public const string PropertyorderDiscountType = "orderDiscountType";
		public const string PropertyorderDiscountAmount = "orderDiscountAmount";
		public const string PropertyorderDiscountPercent = "orderDiscountPercent";
		public const string PropertyorderText1 = "orderText1";
		public const string PropertyorderText2 = "orderText2";
		public const string PropertyorderLineDiscountType = "orderLineDiscountType";
		public const string PropertyorderLineDiscountAmount = "orderLineDiscountAmount";
		public const string PropertyorderLineDiscountPercent = "orderLineDiscountPercent";
		public const string PropertyorderLineText1 = "orderLineText1";
		public const string PropertyorderLineText2 = "orderLineText2";
		public const string PropertyinvoiceDiscountType = "invoiceDiscountType";
		public const string PropertyinvoiceDiscountAmount = "invoiceDiscountAmount";
		public const string PropertyinvoiceDiscountPercent = "invoiceDiscountPercent";
		public const string PropertyinvoiceText1 = "invoiceText1";
		public const string PropertyinvoiceText2 = "invoiceText2";
		public const string PropertybankAccounts = "bankAccounts";
		public const string PropertytenderType = "tenderType";
		public const string PropertydefaultFulfillmentLocation = "defaultFulfillmentLocation";
		public const string Propertypricelists = "pricelists";
		public const string PropertypricingOverride = "pricingOverride";
		public const string PropertyaccountingType = "accountingType";
		public const string PropertyfinancialAccounts = "financialAccounts";
		public const string PropertyprimacyIndicator = "primacyIndicator";
		public const string Propertyopportunities = "opportunities";
		public const string PropertysalesQuotations = "salesQuotations";
		public const string PropertysalesOrders = "salesOrders";
		public const string PropertysalesOrderDeliveries = "salesOrderDeliveries";
		public const string PropertysalesInvoices = "salesInvoices";
		public const string PropertysalesCredits = "salesCredits";
		public const string PropertypurchaseOrders = "purchaseOrders";
		public const string PropertypurchaseOrderDeliveries = "purchaseOrderDeliveries";
		public const string Propertyreceipts = "receipts";
		public const string Propertyinteractions = "interactions";
		public const string Propertyprojects = "projects";

		#endregion

		#region Fields

		private Nullable<System.Boolean> _active;
		private System.String _customerSupplierFlag;
		private System.String _companyPersonFlag;
		private tradingAccountFeedEntry _invoiceTradingAccount;
		private Nullable<System.DateTime> _openedDate;
		private System.String _reference;
		private System.String _reference2;
		private System.String _status;
		private System.String _name;
		private System.String _shortName;
		private System.String _type;
		private postalAddressFeedEntry _registeredAddress;
		private postalAddressFeed _postalAddresses;
		private postalAddressFeed _shippingAddresses;
		private postalAddressFeed _billingAddresses;
		private phoneNumberFeed _phones;
		private emailFeed _emails;
		private System.String _website;
		private contactFeed _contacts;
		private contactFeedEntry _deliveryContact;
		private salesPersonFeed _salesPersons;
		private System.String _deliveryMethod;
		private Nullable<System.Boolean> _deliveryRule;
		private System.String _currency;
		private taxCodeFeed _taxCode;
		private System.String _taxReference;
		private System.String _taxationCountry;
		private Nullable<System.Boolean> _useTaxInclusivePrices;
		private Nullable<System.Decimal> _financeBalance;
		private Nullable<System.Decimal> _financeLimit;
		private Nullable<System.DateTime> _financeBalanceDate;
		private Nullable<System.Boolean> _financeStatusFlag;
		private System.String _financeStatusText;
		private System.String _settlementDiscountType;
		private Nullable<System.Decimal> _settlementDiscountAmount;
		private Nullable<System.Decimal> _settlementDiscountPercent;
		private System.String _settlementDiscountTerms;
		private System.String _settlementDiscountTermsCommencement;
		private Nullable<System.Boolean> _settlementDiscountIncludedInTotal;
		private System.String _paymentTerms;
		private System.String _paymentTermsCommencement;
		private System.String _orderDiscountType;
		private Nullable<System.Decimal> _orderDiscountAmount;
		private Nullable<System.Decimal> _orderDiscountPercent;
		private System.String _orderText1;
		private System.String _orderText2;
		private System.String _orderLineDiscountType;
		private Nullable<System.Decimal> _orderLineDiscountAmount;
		private Nullable<System.Decimal> _orderLineDiscountPercent;
		private System.String _orderLineText1;
		private System.String _orderLineText2;
		private System.String _invoiceDiscountType;
		private Nullable<System.Decimal> _invoiceDiscountAmount;
		private Nullable<System.Decimal> _invoiceDiscountPercent;
		private System.String _invoiceText1;
		private System.String _invoiceText2;
		private bankAccountFeed _bankAccounts;
		private System.String _tenderType;
		private locationFeedEntry _defaultFulfillmentLocation;
		private priceListFeed _pricelists;
		private priceListFeed _pricingOverride;
		private System.String _accountingType;
		private financialAccountFeed _financialAccounts;
		private Nullable<System.Boolean> _primacyIndicator;
		private opportunityFeed _opportunities;
		private salesQuotationFeed _salesQuotations;
		private salesOrderFeed _salesOrders;
		private salesOrderDeliveryFeed _salesOrderDeliveries;
		private salesInvoiceFeed _salesInvoices;
		private salesCreditFeed _salesCredits;
		private purchaseOrderFeed _purchaseOrders;
		private purchaseOrderDeliveryFeed _purchaseOrderDeliveries;
		private receiptFeed _receipts;
		private interactionFeed _interactions;
		private projectFeed _projects;

		#endregion

		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="tradingAccountFeedEntrySchema"/> class.
		/// </summary>
		#endregion
		public tradingAccountFeedEntrySchema()
		{
		}

		#region Properties


		[SMEBoolProperty(Label="TradingAccount Active Flag", Nillable=true, Name="active", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.Boolean> active { get { return _active; } set { SetProperty(Propertyactive, ref _active, value); } }

		[SMEStringProperty(Label="TradingAccount Customer Supplier Flag", Name="customerSupplierFlag", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String customerSupplierFlag { get { return _customerSupplierFlag; } set { SetProperty(PropertycustomerSupplierFlag, ref _customerSupplierFlag, value); } }

		[SMEStringProperty(Label="TradingAccount Company Person Flag", Name="companyPersonFlag", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String companyPersonFlag { get { return _companyPersonFlag; } set { SetProperty(PropertycompanyPersonFlag, ref _companyPersonFlag, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="tradingAccounts", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="invoiceTradingAccount", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("invoiceTradingAccount")]			
		public virtual tradingAccountFeedEntry invoiceTradingAccount { get { return _invoiceTradingAccount; } set { SetProperty(PropertyinvoiceTradingAccount, ref _invoiceTradingAccount, value); } }

		[SMEDateProperty(Label="TradingAccount Opened Date", Nillable=true, Name="openedDate", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.DateTime> openedDate { get { return _openedDate; } set { SetProperty(PropertyopenedDate, ref _openedDate, value); } }

		[SMEStringProperty(Label="TradingAccount Reference", Name="reference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String reference { get { return _reference; } set { SetProperty(Propertyreference, ref _reference, value); } }

		[SMEStringProperty(Label="TradingAccount Reference2", Name="reference2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String reference2 { get { return _reference2; } set { SetProperty(Propertyreference2, ref _reference2, value); } }

		[SMEStringProperty(Label="TradingAccount Status", Name="status", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String status { get { return _status; } set { SetProperty(Propertystatus, ref _status, value); } }

		[SMEStringProperty(Label="TradingAccount Name", Name="name", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true, IsMandatory=true)]			
		public virtual System.String name { get { return _name; } set { SetProperty(Propertyname, ref _name, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="TradingAccount Short Name", Name="shortName", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true, Unsupported=true)]			
		public virtual System.String shortName { get { return _shortName; } set { SetProperty(PropertyshortName, ref _shortName, value); } }

		[SMEStringProperty(Label="TradingAccount Type", Name="type", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String type { get { return _type; } set { SetProperty(Propertytype, ref _type, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="postalAddresses", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, Name="registeredAddress", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("registeredAddress")]			
		public virtual postalAddressFeedEntry registeredAddress { get { return _registeredAddress; } set { SetProperty(PropertyregisteredAddress, ref _registeredAddress, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="postalAddresses", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="postalAddresses", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual postalAddressFeed postalAddresses { get { return _postalAddresses; } set { SetProperty(PropertypostalAddresses, ref _postalAddresses, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="postalAddresses", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="shippingAddresses", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual postalAddressFeed shippingAddresses { get { return _shippingAddresses; } set { SetProperty(PropertyshippingAddresses, ref _shippingAddresses, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="postalAddresses", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="billingAddresses", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual postalAddressFeed billingAddresses { get { return _billingAddresses; } set { SetProperty(PropertybillingAddresses, ref _billingAddresses, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="phoneNumbers", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="phones", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual phoneNumberFeed phones { get { return _phones; } set { SetProperty(Propertyphones, ref _phones, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="emails", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="emails", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual emailFeed emails { get { return _emails; } set { SetProperty(Propertyemails, ref _emails, value); } }

		[SMEStringProperty(Label="TradingAccount Web site", Name="website", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String website { get { return _website; } set { SetProperty(Propertywebsite, ref _website, value); } }

		[SMEResource(CanGet=true, PluralName="contacts", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="contacts", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual contactFeed contacts { get { return _contacts; } set { SetProperty(Propertycontacts, ref _contacts, value); } }

		[SMEResource(CanGet=true, PluralName="contacts", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="deliveryContact", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("deliveryContact")]			
		public virtual contactFeedEntry deliveryContact { get { return _deliveryContact; } set { SetProperty(PropertydeliveryContact, ref _deliveryContact, value); } }

		[SMEResource(CanGet=true, PluralName="salesPersons", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="salesPersons", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesPersonFeed salesPersons { get { return _salesPersons; } set { SetProperty(PropertysalesPersons, ref _salesPersons, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="TradingAccount Delivery Method", Name="deliveryMethod", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String deliveryMethod { get { return _deliveryMethod; } set { SetProperty(PropertydeliveryMethod, ref _deliveryMethod, value); } }

		[SMEBoolProperty(Label="TradingAccount Delivery Rule", Nillable=true, Name="deliveryRule", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.Boolean> deliveryRule { get { return _deliveryRule; } set { SetProperty(PropertydeliveryRule, ref _deliveryRule, value); } }

		[SMEStringProperty(Label="TradingAccount Currency", Name="currency", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String currency { get { return _currency; } set { SetProperty(Propertycurrency, ref _currency, value); } }

		[SMEResource(CanGet=true, PluralName="taxCodes", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="taxCode", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual taxCodeFeed taxCode { get { return _taxCode; } set { SetProperty(PropertytaxCode, ref _taxCode, value); } }

		[SMEStringProperty(Label="TradingAccount Tax reference", Name="taxReference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true, IsUniqueKey=true)]			
		public virtual System.String taxReference { get { return _taxReference; } set { SetProperty(PropertytaxReference, ref _taxReference, value); } }

		[SMEStringProperty(Label="TradingAccount Taxation Country", Name="taxationCountry", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String taxationCountry { get { return _taxationCountry; } set { SetProperty(PropertytaxationCountry, ref _taxationCountry, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEBoolProperty(Label="TradingAccount Use Tax Inclusive Prices", Nillable=true, Name="useTaxInclusivePrices", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Boolean> useTaxInclusivePrices { get { return _useTaxInclusivePrices; } set { SetProperty(PropertyuseTaxInclusivePrices, ref _useTaxInclusivePrices, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="TradingAccount Finance Balance", Nillable=true, AverageLength=14, Name="financeBalance", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> financeBalance { get { return _financeBalance; } set { SetProperty(PropertyfinanceBalance, ref _financeBalance, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="TradingAccount Finance Limit", Nillable=true, AverageLength=14, Name="financeLimit", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> financeLimit { get { return _financeLimit; } set { SetProperty(PropertyfinanceLimit, ref _financeLimit, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDateProperty(Label="TradingAccount Finance Balance Date", Nillable=true, Name="financeBalanceDate", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.DateTime> financeBalanceDate { get { return _financeBalanceDate; } set { SetProperty(PropertyfinanceBalanceDate, ref _financeBalanceDate, value); } }

		[SMEBoolProperty(Label="TradingAccount Finance Status Flag", Nillable=true, Name="financeStatusFlag", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.Boolean> financeStatusFlag { get { return _financeStatusFlag; } set { SetProperty(PropertyfinanceStatusFlag, ref _financeStatusFlag, value); } }

		[SMEStringProperty(Label="TradingAccount Finance Status Text", Name="financeStatusText", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String financeStatusText { get { return _financeStatusText; } set { SetProperty(PropertyfinanceStatusText, ref _financeStatusText, value); } }

		[SMEStringProperty(Label="TradingAccount Settlement Discount Type", Name="settlementDiscountType", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String settlementDiscountType { get { return _settlementDiscountType; } set { SetProperty(PropertysettlementDiscountType, ref _settlementDiscountType, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="TradingAccount Settlement Discount Amount", Nillable=true, AverageLength=14, Name="settlementDiscountAmount", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> settlementDiscountAmount { get { return _settlementDiscountAmount; } set { SetProperty(PropertysettlementDiscountAmount, ref _settlementDiscountAmount, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="TradingAccount Settlement Discount Percent", Nillable=true, AverageLength=14, Name="settlementDiscountPercent", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> settlementDiscountPercent { get { return _settlementDiscountPercent; } set { SetProperty(PropertysettlementDiscountPercent, ref _settlementDiscountPercent, value); } }

		[SMEStringProperty(Label="TradingAccount Settlement Discount Terms", Name="settlementDiscountTerms", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String settlementDiscountTerms { get { return _settlementDiscountTerms; } set { SetProperty(PropertysettlementDiscountTerms, ref _settlementDiscountTerms, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="TradingAccount Settlement Discount Terms Commencement", Name="settlementDiscountTermsCommencement", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String settlementDiscountTermsCommencement { get { return _settlementDiscountTermsCommencement; } set { SetProperty(PropertysettlementDiscountTermsCommencement, ref _settlementDiscountTermsCommencement, value); } }

		[SMEBoolProperty(Label="TradingAccount Settlement Discount Included In Total", Nillable=true, Name="settlementDiscountIncludedInTotal", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.Boolean> settlementDiscountIncludedInTotal { get { return _settlementDiscountIncludedInTotal; } set { SetProperty(PropertysettlementDiscountIncludedInTotal, ref _settlementDiscountIncludedInTotal, value); } }

		[SMEStringProperty(Label="TradingAccount Payment Terms", Name="paymentTerms", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String paymentTerms { get { return _paymentTerms; } set { SetProperty(PropertypaymentTerms, ref _paymentTerms, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="TradingAccount Payment Terms Commencement", Name="paymentTermsCommencement", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String paymentTermsCommencement { get { return _paymentTermsCommencement; } set { SetProperty(PropertypaymentTermsCommencement, ref _paymentTermsCommencement, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="TradingAccount Order Discount Type", Name="orderDiscountType", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String orderDiscountType { get { return _orderDiscountType; } set { SetProperty(PropertyorderDiscountType, ref _orderDiscountType, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="TradingAccount Order Discount Amount", Nillable=true, AverageLength=14, Name="orderDiscountAmount", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> orderDiscountAmount { get { return _orderDiscountAmount; } set { SetProperty(PropertyorderDiscountAmount, ref _orderDiscountAmount, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="TradingAccount Order Discount Percent", Nillable=true, AverageLength=14, Name="orderDiscountPercent", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> orderDiscountPercent { get { return _orderDiscountPercent; } set { SetProperty(PropertyorderDiscountPercent, ref _orderDiscountPercent, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="TradingAccount Order Text1", Name="orderText1", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String orderText1 { get { return _orderText1; } set { SetProperty(PropertyorderText1, ref _orderText1, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="TradingAccount Order Text2", Name="orderText2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String orderText2 { get { return _orderText2; } set { SetProperty(PropertyorderText2, ref _orderText2, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="TradingAccount Order Line Discount Type", Name="orderLineDiscountType", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String orderLineDiscountType { get { return _orderLineDiscountType; } set { SetProperty(PropertyorderLineDiscountType, ref _orderLineDiscountType, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="TradingAccount Order Line Discount Amount", Nillable=true, AverageLength=14, Name="orderLineDiscountAmount", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> orderLineDiscountAmount { get { return _orderLineDiscountAmount; } set { SetProperty(PropertyorderLineDiscountAmount, ref _orderLineDiscountAmount, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="TradingAccount Order Line Discount Percent", Nillable=true, AverageLength=14, Name="orderLineDiscountPercent", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> orderLineDiscountPercent { get { return _orderLineDiscountPercent; } set { SetProperty(PropertyorderLineDiscountPercent, ref _orderLineDiscountPercent, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="TradingAccount OrderLine Text1", Name="orderLineText1", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String orderLineText1 { get { return _orderLineText1; } set { SetProperty(PropertyorderLineText1, ref _orderLineText1, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="TradingAccount OrderLine Text2", Name="orderLineText2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String orderLineText2 { get { return _orderLineText2; } set { SetProperty(PropertyorderLineText2, ref _orderLineText2, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="TradingAccount Invoice Discount Type", Name="invoiceDiscountType", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String invoiceDiscountType { get { return _invoiceDiscountType; } set { SetProperty(PropertyinvoiceDiscountType, ref _invoiceDiscountType, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="TradingAccount Invoice Discount Amount", Nillable=true, AverageLength=14, Name="invoiceDiscountAmount", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> invoiceDiscountAmount { get { return _invoiceDiscountAmount; } set { SetProperty(PropertyinvoiceDiscountAmount, ref _invoiceDiscountAmount, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="TradingAccount Invoice Discount Percent", Nillable=true, AverageLength=14, Name="invoiceDiscountPercent", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> invoiceDiscountPercent { get { return _invoiceDiscountPercent; } set { SetProperty(PropertyinvoiceDiscountPercent, ref _invoiceDiscountPercent, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="TradingAccount Invoice Text1", Name="invoiceText1", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String invoiceText1 { get { return _invoiceText1; } set { SetProperty(PropertyinvoiceText1, ref _invoiceText1, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="TradingAccount Invoice Text2", Name="invoiceText2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String invoiceText2 { get { return _invoiceText2; } set { SetProperty(PropertyinvoiceText2, ref _invoiceText2, value); } }

		[SMEResource(CanGet=true, CanPut=true, PluralName="bankAccounts", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="bankAccounts", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual bankAccountFeed bankAccounts { get { return _bankAccounts; } set { SetProperty(PropertybankAccounts, ref _bankAccounts, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="TradingAccount Default Tender Type", Name="tenderType", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String tenderType { get { return _tenderType; } set { SetProperty(PropertytenderType, ref _tenderType, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="locations", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="defaultFulfillmentLocation", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("defaultFulfillmentLocation")]			
		public virtual locationFeedEntry defaultFulfillmentLocation { get { return _defaultFulfillmentLocation; } set { SetProperty(PropertydefaultFulfillmentLocation, ref _defaultFulfillmentLocation, value); } }

		[SMEResource(CanGet=true, PluralName="priceLists", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="pricelists", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual priceListFeed pricelists { get { return _pricelists; } set { SetProperty(Propertypricelists, ref _pricelists, value); } }

		[SMEResource(CanGet=true, PluralName="priceLists", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="pricingOverride", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual priceListFeed pricingOverride { get { return _pricingOverride; } set { SetProperty(PropertypricingOverride, ref _pricingOverride, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="TradingAccount Accounting Type", Name="accountingType", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String accountingType { get { return _accountingType; } set { SetProperty(PropertyaccountingType, ref _accountingType, value); } }

		[SMEResource(CanGet=true, PluralName="financialAccounts", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="financialAccounts", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual financialAccountFeed financialAccounts { get { return _financialAccounts; } set { SetProperty(PropertyfinancialAccounts, ref _financialAccounts, value); } }

		[SMEBoolProperty(Label="TradingAccount Primacy Indicator", Nillable=true, Name="primacyIndicator", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.Boolean> primacyIndicator { get { return _primacyIndicator; } set { SetProperty(PropertyprimacyIndicator, ref _primacyIndicator, value); } }

		[SMEResource(CanGet=true, PluralName="Opportunities", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="opportunities", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual opportunityFeed opportunities { get { return _opportunities; } set { SetProperty(Propertyopportunities, ref _opportunities, value); } }

		[SMEResource(CanGet=true, CanPost=true, PluralName="salesQuotations", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="salesQuotations", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesQuotationFeed salesQuotations { get { return _salesQuotations; } set { SetProperty(PropertysalesQuotations, ref _salesQuotations, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanDelete=true, PluralName="salesOrders", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="salesOrders", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesOrderFeed salesOrders { get { return _salesOrders; } set { SetProperty(PropertysalesOrders, ref _salesOrders, value); } }

		[SMEResource(CanGet=true, PluralName="salesOrderDeliveries", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="salesOrderDeliveries", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesOrderDeliveryFeed salesOrderDeliveries { get { return _salesOrderDeliveries; } set { SetProperty(PropertysalesOrderDeliveries, ref _salesOrderDeliveries, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanDelete=true, PluralName="salesInvoices", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="salesInvoices", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesInvoiceFeed salesInvoices { get { return _salesInvoices; } set { SetProperty(PropertysalesInvoices, ref _salesInvoices, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="salesCredits", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="salesCredits", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesCreditFeed salesCredits { get { return _salesCredits; } set { SetProperty(PropertysalesCredits, ref _salesCredits, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanDelete=true, PluralName="purchaseOrders", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="purchaseOrders", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual purchaseOrderFeed purchaseOrders { get { return _purchaseOrders; } set { SetProperty(PropertypurchaseOrders, ref _purchaseOrders, value); } }

		[SMEResource(CanGet=true, PluralName="purchaseOrderDeliveries", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="purchaseOrderDeliveries", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual purchaseOrderDeliveryFeed purchaseOrderDeliveries { get { return _purchaseOrderDeliveries; } set { SetProperty(PropertypurchaseOrderDeliveries, ref _purchaseOrderDeliveries, value); } }

		[SMEResource(CanGet=true, PluralName="receipts", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="receipts", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual receiptFeed receipts { get { return _receipts; } set { SetProperty(Propertyreceipts, ref _receipts, value); } }

		[SMEResource(CanGet=true, PluralName="interactions", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="interactions", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual interactionFeed interactions { get { return _interactions; } set { SetProperty(Propertyinteractions, ref _interactions, value); } }

		[SMEResource(CanGet=true, PluralName="projects", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="projects", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual projectFeed projects { get { return _projects; } set { SetProperty(Propertyprojects, ref _projects, value); } }

		#endregion


	}
}