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
	/// Defines a purchaseOrder feed entry
	/// </summary>
	#endregion
	[System.ComponentModel.Browsable(false)]
	[XmlType("purchaseOrder", Namespace="http://schemas.sage.com/crmErp/2008")]
	public class purchaseOrderFeedEntrySchema : Sage.Common.Syndication.FeedEntry
	{
		#region Constants

		public const string Propertyactive = "active";
		public const string Propertyreference = "reference";
		public const string Propertyreference2 = "reference2";
		public const string Propertystatus = "status";
		public const string PropertystatusFlag = "statusFlag";
		public const string PropertystatusFlagText = "statusFlagText";
		public const string PropertytradingAccount = "tradingAccount";
		public const string PropertycustomerTradingAccount = "customerTradingAccount";
		public const string PropertycustomerReference = "customerReference";
		public const string PropertycustomerSalesOrders = "customerSalesOrders";
		public const string PropertysupplierReference = "supplierReference";
		public const string Propertypricelist = "pricelist";
		public const string PropertysellerContact = "sellerContact";
		public const string Propertytype = "type";
		public const string PropertycopyFlag = "copyFlag";
		public const string PropertyoriginatorDocument = "originatorDocument";
		public const string PropertypostalAddresses = "postalAddresses";
		public const string PropertydeliveryMethod = "deliveryMethod";
		public const string PropertydeliveryRule = "deliveryRule";
		public const string PropertydeliveryTerms = "deliveryTerms";
		public const string PropertydeliveryDate = "deliveryDate";
		public const string PropertycarrierCompany = "carrierCompany";
		public const string PropertycarrierTradingAccount = "carrierTradingAccount";
		public const string PropertycarrierNetPrice = "carrierNetPrice";
		public const string PropertycarrierTaxPrice = "carrierTaxPrice";
		public const string PropertycarrierTotalPrice = "carrierTotalPrice";
		public const string PropertycarrierTaxCodes = "carrierTaxCodes";
		public const string PropertycarrierReference = "carrierReference";
		public const string Propertycurrency = "currency";
		public const string PropertyoperatingCompanyCurrency = "operatingCompanyCurrency";
		public const string PropertyoperatingCompanyCurrencyExchangeRate = "operatingCompanyCurrencyExchangeRate";
		public const string PropertyoperatingCompanyCurrencyExchangeRateOperator = "operatingCompanyCurrencyExchangeRateOperator";
		public const string PropertyoperatingCompanyCurrencyExchangeRateDate = "operatingCompanyCurrencyExchangeRateDate";
		public const string PropertyinvoiceCurrency = "invoiceCurrency";
		public const string PropertyinvoiceCurrencyExchangeRate = "invoiceCurrencyExchangeRate";
		public const string PropertyinvoiceCurrencyExchangeRateOperator = "invoiceCurrencyExchangeRateOperator";
		public const string PropertyinvoiceCurrencyExchangeRateDate = "invoiceCurrencyExchangeRateDate";
		public const string PropertysupplierTradingAccountCurrency = "supplierTradingAccountCurrency";
		public const string PropertysupplierTradingAccountCurrencyExchangeRate = "supplierTradingAccountCurrencyExchangeRate";
		public const string PropertysupplierTradingAccountCurrencyExchangeRateOperator = "supplierTradingAccountCurrencyExchangeRateOperator";
		public const string PropertysupplierTradingAccountCurrencyExchangeRateDate = "supplierTradingAccountCurrencyExchangeRateDate";
		public const string Propertydate = "date";
		public const string Propertytime = "time";
		public const string Propertyvalidity = "validity";
		public const string PropertyexpirationDate = "expirationDate";
		public const string PropertydueDate = "dueDate";
		public const string PropertytaxCodes = "taxCodes";
		public const string Propertyuser = "user";
		public const string PropertybuyerUser = "buyerUser";
		public const string PropertypurchaseOrderLines = "purchaseOrderLines";
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
		public const string PropertydepositFlag = "depositFlag";
		public const string Propertycontract = "contract";
		public const string PropertyinvoiceTradingAccount = "invoiceTradingAccount";
		public const string Propertyprojects = "projects";
		public const string PropertypurchaseOrderDeliveries = "purchaseOrderDeliveries";
		public const string PropertyfinancialAccounts = "financialAccounts";
		public const string Propertyinteractions = "interactions";
		public const string Propertynotes = "notes";
		public const string PropertySupplierId = "SupplierId";
		public const string PropertyonOrder = "onOrder";

		#endregion

		#region Fields

		private Nullable<System.Boolean> _active;
		private System.String _reference;
		private System.String _reference2;
		private System.String _status;
		private Nullable<System.Boolean> _statusFlag;
		private System.String _statusFlagText;
		private tradingAccountFeedEntry _tradingAccount;
		private tradingAccountFeedEntry _customerTradingAccount;
		private System.String _customerReference;
		private salesOrderFeed _customerSalesOrders;
		private System.String _supplierReference;
		private priceListFeedEntry _pricelist;
		private contactFeedEntry _sellerContact;
		private System.String _type;
		private Nullable<System.Boolean> _copyFlag;
		private purchaseOrderFeed _originatorDocument;
		private postalAddressFeed _postalAddresses;
		private System.String _deliveryMethod;
		private Nullable<System.Boolean> _deliveryRule;
		private System.String _deliveryTerms;
		private Nullable<System.DateTime> _deliveryDate;
		private System.String _carrierCompany;
		private tradingAccountFeed _carrierTradingAccount;
		private Nullable<System.Decimal> _carrierNetPrice;
		private Nullable<System.Decimal> _carrierTaxPrice;
		private Nullable<System.Decimal> _carrierTotalPrice;
		private taxCodeFeed _carrierTaxCodes;
		private System.String _carrierReference;
		private System.String _currency;
		private System.String _operatingCompanyCurrency;
		private Nullable<System.Decimal> _operatingCompanyCurrencyExchangeRate;
		private System.String _operatingCompanyCurrencyExchangeRateOperator;
		private Nullable<System.DateTime> _operatingCompanyCurrencyExchangeRateDate;
		private System.String _invoiceCurrency;
		private Nullable<System.Decimal> _invoiceCurrencyExchangeRate;
		private System.String _invoiceCurrencyExchangeRateOperator;
		private Nullable<System.DateTime> _invoiceCurrencyExchangeRateDate;
		private System.String _supplierTradingAccountCurrency;
		private Nullable<System.Decimal> _supplierTradingAccountCurrencyExchangeRate;
		private System.String _supplierTradingAccountCurrencyExchangeRateOperator;
		private Nullable<System.DateTime> _supplierTradingAccountCurrencyExchangeRateDate;
		private Nullable<System.DateTime> _date;
		private Nullable<System.DateTime> _time;
		private Nullable<System.Decimal> _validity;
		private Nullable<System.DateTime> _expirationDate;
		private Nullable<System.DateTime> _dueDate;
		private taxCodeFeed _taxCodes;
		private System.String _user;
		private System.String _buyerUser;
		private purchaseOrderLineFeed _purchaseOrderLines;
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
		private Nullable<System.Boolean> _depositFlag;
		private System.String _contract;
		private tradingAccountFeedEntry _invoiceTradingAccount;
		private projectFeed _projects;
		private purchaseOrderDeliveryFeed _purchaseOrderDeliveries;
		private financialAccountFeed _financialAccounts;
		private interactionFeed _interactions;
		private noteFeed _notes;
		private System.DateTime _SupplierId;
		private System.String _onOrder;

		#endregion

		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="purchaseOrderFeedEntrySchema"/> class.
		/// </summary>
		#endregion
		public purchaseOrderFeedEntrySchema()
		{
		}

		#region Properties


		[SMEBoolProperty(Label="PurchaseOrder Active Flag", Nillable=true, Name="active", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.Boolean> active { get { return _active; } set { SetProperty(Propertyactive, ref _active, value); } }

		[SMEStringProperty(Label="PurchaseOrder reference", Name="reference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true, IsUniqueKey=true)]			
		public virtual System.String reference { get { return _reference; } set { SetProperty(Propertyreference, ref _reference, value); } }

		[SMEStringProperty(Label="PurchaseOrder Reference2", Name="reference2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String reference2 { get { return _reference2; } set { SetProperty(Propertyreference2, ref _reference2, value); } }

		[SMEStringProperty(Label="PurchaseOrder Status", Name="status", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String status { get { return _status; } set { SetProperty(Propertystatus, ref _status, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEBoolProperty(Label="PurchaseOrder Status Flag", Nillable=true, Name="statusFlag", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Boolean> statusFlag { get { return _statusFlag; } set { SetProperty(PropertystatusFlag, ref _statusFlag, value); } }

		[SMEStringProperty(Label="PurchaseOrder Status Flag Text", Name="statusFlagText", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String statusFlagText { get { return _statusFlagText; } set { SetProperty(PropertystatusFlagText, ref _statusFlagText, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="tradingAccounts", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="tradingAccount", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("tradingAccount")]			
		public virtual tradingAccountFeedEntry tradingAccount { get { return _tradingAccount; } set { SetProperty(PropertytradingAccount, ref _tradingAccount, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="tradingAccounts", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="customerTradingAccount", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("customerTradingAccount")]			
		public virtual tradingAccountFeedEntry customerTradingAccount { get { return _customerTradingAccount; } set { SetProperty(PropertycustomerTradingAccount, ref _customerTradingAccount, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="PurchaseOrder Customer Reference", Name="customerReference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String customerReference { get { return _customerReference; } set { SetProperty(PropertycustomerReference, ref _customerReference, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanDelete=true, PluralName="salesOrders", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="customerSalesOrders", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesOrderFeed customerSalesOrders { get { return _customerSalesOrders; } set { SetProperty(PropertycustomerSalesOrders, ref _customerSalesOrders, value); } }

		[SMEStringProperty(Label="PurchaseOrder Supplier reference", Name="supplierReference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String supplierReference { get { return _supplierReference; } set { SetProperty(PropertysupplierReference, ref _supplierReference, value); } }

		[SMEResource(CanGet=true, PluralName="priceLists", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="pricelist", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("pricelist")]			
		public virtual priceListFeedEntry pricelist { get { return _pricelist; } set { SetProperty(Propertypricelist, ref _pricelist, value); } }

		[SMEResource(CanGet=true, PluralName="contacts", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="sellerContact", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("sellerContact")]			
		public virtual contactFeedEntry sellerContact { get { return _sellerContact; } set { SetProperty(PropertysellerContact, ref _sellerContact, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="PurchaseOrder Type", Name="type", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String type { get { return _type; } set { SetProperty(Propertytype, ref _type, value); } }

		[SMEBoolProperty(Label="PurchaseOrder Copy Flag", Nillable=true, Name="copyFlag", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Boolean> copyFlag { get { return _copyFlag; } set { SetProperty(PropertycopyFlag, ref _copyFlag, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanDelete=true, PluralName="purchaseOrders", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="originatorDocument", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual purchaseOrderFeed originatorDocument { get { return _originatorDocument; } set { SetProperty(PropertyoriginatorDocument, ref _originatorDocument, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="postalAddresses", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="postalAddresses", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual postalAddressFeed postalAddresses { get { return _postalAddresses; } set { SetProperty(PropertypostalAddresses, ref _postalAddresses, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="PurchaseOrder Delivery Method", Name="deliveryMethod", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String deliveryMethod { get { return _deliveryMethod; } set { SetProperty(PropertydeliveryMethod, ref _deliveryMethod, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEBoolProperty(Label="PurchaseOrder Delivery Rule", Nillable=true, Name="deliveryRule", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Boolean> deliveryRule { get { return _deliveryRule; } set { SetProperty(PropertydeliveryRule, ref _deliveryRule, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="PurchaseOrder Delivery Terms", Name="deliveryTerms", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String deliveryTerms { get { return _deliveryTerms; } set { SetProperty(PropertydeliveryTerms, ref _deliveryTerms, value); } }

		[SMEDateProperty(Label="PurchaseOrder Delivery Date", Nillable=true, Name="deliveryDate", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.DateTime> deliveryDate { get { return _deliveryDate; } set { SetProperty(PropertydeliveryDate, ref _deliveryDate, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="PurchaseOrder Carrier Company", Name="carrierCompany", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String carrierCompany { get { return _carrierCompany; } set { SetProperty(PropertycarrierCompany, ref _carrierCompany, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="tradingAccounts", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="carrierTradingAccount", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual tradingAccountFeed carrierTradingAccount { get { return _carrierTradingAccount; } set { SetProperty(PropertycarrierTradingAccount, ref _carrierTradingAccount, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="PurchaseOrder Carrier Net Price", Nillable=true, AverageLength=14, Name="carrierNetPrice", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> carrierNetPrice { get { return _carrierNetPrice; } set { SetProperty(PropertycarrierNetPrice, ref _carrierNetPrice, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="PurchaseOrder Carrier Tax Price", Nillable=true, AverageLength=14, Name="carrierTaxPrice", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> carrierTaxPrice { get { return _carrierTaxPrice; } set { SetProperty(PropertycarrierTaxPrice, ref _carrierTaxPrice, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="PurchaseOrder Carrier Gross Price", Nillable=true, AverageLength=14, Name="carrierTotalPrice", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> carrierTotalPrice { get { return _carrierTotalPrice; } set { SetProperty(PropertycarrierTotalPrice, ref _carrierTotalPrice, value); } }

		[SMEResource(CanGet=true, PluralName="taxCodes", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="carrierTaxCodes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual taxCodeFeed carrierTaxCodes { get { return _carrierTaxCodes; } set { SetProperty(PropertycarrierTaxCodes, ref _carrierTaxCodes, value); } }

		[SMEStringProperty(Label="PurchaseOrder Carrier reference", Name="carrierReference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String carrierReference { get { return _carrierReference; } set { SetProperty(PropertycarrierReference, ref _carrierReference, value); } }

		[SMEStringProperty(Label="PurchaseOrder Currency", Name="currency", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String currency { get { return _currency; } set { SetProperty(Propertycurrency, ref _currency, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="PurchaseOrder OperatingCompany Currency", Name="operatingCompanyCurrency", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String operatingCompanyCurrency { get { return _operatingCompanyCurrency; } set { SetProperty(PropertyoperatingCompanyCurrency, ref _operatingCompanyCurrency, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="PurchaseOrder OperatingCompany Currency Exchange Rate", Nillable=true, AverageLength=14, Name="operatingCompanyCurrencyExchangeRate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> operatingCompanyCurrencyExchangeRate { get { return _operatingCompanyCurrencyExchangeRate; } set { SetProperty(PropertyoperatingCompanyCurrencyExchangeRate, ref _operatingCompanyCurrencyExchangeRate, value); } }

		[SMEStringProperty(Label="PurchaseOrder OperatingCompany Currency Exchange Rate Operator", Name="operatingCompanyCurrencyExchangeRateOperator", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String operatingCompanyCurrencyExchangeRateOperator { get { return _operatingCompanyCurrencyExchangeRateOperator; } set { SetProperty(PropertyoperatingCompanyCurrencyExchangeRateOperator, ref _operatingCompanyCurrencyExchangeRateOperator, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDateProperty(Label="PurchaseOrder OperatingCompany Currency Exchange Rate Date", Nillable=true, Name="operatingCompanyCurrencyExchangeRateDate", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.DateTime> operatingCompanyCurrencyExchangeRateDate { get { return _operatingCompanyCurrencyExchangeRateDate; } set { SetProperty(PropertyoperatingCompanyCurrencyExchangeRateDate, ref _operatingCompanyCurrencyExchangeRateDate, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="PurchaseOrder Invoice Currency", Name="invoiceCurrency", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String invoiceCurrency { get { return _invoiceCurrency; } set { SetProperty(PropertyinvoiceCurrency, ref _invoiceCurrency, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="PurchaseOrder Invoice Currency Exchange Rate", Nillable=true, AverageLength=14, Name="invoiceCurrencyExchangeRate", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> invoiceCurrencyExchangeRate { get { return _invoiceCurrencyExchangeRate; } set { SetProperty(PropertyinvoiceCurrencyExchangeRate, ref _invoiceCurrencyExchangeRate, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="PurchaseOrder Invoice Currency Exchange Rate Operator", Name="invoiceCurrencyExchangeRateOperator", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String invoiceCurrencyExchangeRateOperator { get { return _invoiceCurrencyExchangeRateOperator; } set { SetProperty(PropertyinvoiceCurrencyExchangeRateOperator, ref _invoiceCurrencyExchangeRateOperator, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDateProperty(Label="PurchaseOrder Invoice Currency Exchange Rate Date", Nillable=true, Name="invoiceCurrencyExchangeRateDate", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.DateTime> invoiceCurrencyExchangeRateDate { get { return _invoiceCurrencyExchangeRateDate; } set { SetProperty(PropertyinvoiceCurrencyExchangeRateDate, ref _invoiceCurrencyExchangeRateDate, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="PurchaseOrder Supplier TradingAccount Currency", Name="supplierTradingAccountCurrency", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String supplierTradingAccountCurrency { get { return _supplierTradingAccountCurrency; } set { SetProperty(PropertysupplierTradingAccountCurrency, ref _supplierTradingAccountCurrency, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="PurchaseOrder Supplier TradingAccount Currency Exchange Rate", Nillable=true, AverageLength=14, Name="supplierTradingAccountCurrencyExchangeRate", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> supplierTradingAccountCurrencyExchangeRate { get { return _supplierTradingAccountCurrencyExchangeRate; } set { SetProperty(PropertysupplierTradingAccountCurrencyExchangeRate, ref _supplierTradingAccountCurrencyExchangeRate, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="PurchaseOrder Supplier TradingAccount Currency Exchange Rate Operator", Name="supplierTradingAccountCurrencyExchangeRateOperator", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String supplierTradingAccountCurrencyExchangeRateOperator { get { return _supplierTradingAccountCurrencyExchangeRateOperator; } set { SetProperty(PropertysupplierTradingAccountCurrencyExchangeRateOperator, ref _supplierTradingAccountCurrencyExchangeRateOperator, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDateProperty(Label="PurchaseOrder Supplier TradingAccount Currency Exchange Rate Date", Nillable=true, Name="supplierTradingAccountCurrencyExchangeRateDate", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.DateTime> supplierTradingAccountCurrencyExchangeRateDate { get { return _supplierTradingAccountCurrencyExchangeRateDate; } set { SetProperty(PropertysupplierTradingAccountCurrencyExchangeRateDate, ref _supplierTradingAccountCurrencyExchangeRateDate, value); } }

		[SMEDateProperty(Label="PurchaseOrder Date", Nillable=true, Name="date", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.DateTime> date { get { return _date; } set { SetProperty(Propertydate, ref _date, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMETimeProperty(Label="PurchaseOrder Time", Nillable=true, Name="time", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.DateTime> time { get { return _time; } set { SetProperty(Propertytime, ref _time, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="PurchaseOrder Validity", Nillable=true, AverageLength=14, Name="validity", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> validity { get { return _validity; } set { SetProperty(Propertyvalidity, ref _validity, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDateProperty(Label="PurchaseOrder Expiration Date", Nillable=true, Name="expirationDate", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.DateTime> expirationDate { get { return _expirationDate; } set { SetProperty(PropertyexpirationDate, ref _expirationDate, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDateProperty(Label="PurchaseOrder Due Date", Nillable=true, Name="dueDate", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.DateTime> dueDate { get { return _dueDate; } set { SetProperty(PropertydueDate, ref _dueDate, value); } }

		[SMEResource(CanGet=true, PluralName="taxCodes", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="taxCodes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual taxCodeFeed taxCodes { get { return _taxCodes; } set { SetProperty(PropertytaxCodes, ref _taxCodes, value); } }

		[SMEStringProperty(Label="PurchaseOrder user", Name="user", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String user { get { return _user; } set { SetProperty(Propertyuser, ref _user, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="PurchaseOder Buyer", Name="buyerUser", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String buyerUser { get { return _buyerUser; } set { SetProperty(PropertybuyerUser, ref _buyerUser, value); } }

		[SMEResource(CanGet=true, PluralName="purchaseOrderLines", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Child, IsCollection=true, Name="purchaseOrderLines", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual purchaseOrderLineFeed purchaseOrderLines { get { return _purchaseOrderLines; } set { SetProperty(PropertypurchaseOrderLines, ref _purchaseOrderLines, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="PurchaseOrder Line Count", Nillable=true, AverageLength=14, Name="lineCount", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> lineCount { get { return _lineCount; } set { SetProperty(PropertylineCount, ref _lineCount, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="PurchaseOrder Order Discount Type", Name="orderDiscountType", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String orderDiscountType { get { return _orderDiscountType; } set { SetProperty(PropertyorderDiscountType, ref _orderDiscountType, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="PurchaseOrder Order Discount Amount", Nillable=true, AverageLength=14, Name="orderDiscountAmount", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> orderDiscountAmount { get { return _orderDiscountAmount; } set { SetProperty(PropertyorderDiscountAmount, ref _orderDiscountAmount, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="PurchaseOrder Order Discount Percent", Nillable=true, AverageLength=14, Name="orderDiscountPercent", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> orderDiscountPercent { get { return _orderDiscountPercent; } set { SetProperty(PropertyorderDiscountPercent, ref _orderDiscountPercent, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="PurchaseOrder Order Additional Discount1 Type", Name="orderAdditionalDiscount1Type", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String orderAdditionalDiscount1Type { get { return _orderAdditionalDiscount1Type; } set { SetProperty(PropertyorderAdditionalDiscount1Type, ref _orderAdditionalDiscount1Type, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="PurchaseOrder Order Additional Discount1 Amount", Nillable=true, AverageLength=14, Name="orderAdditionalDiscount1Amount", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> orderAdditionalDiscount1Amount { get { return _orderAdditionalDiscount1Amount; } set { SetProperty(PropertyorderAdditionalDiscount1Amount, ref _orderAdditionalDiscount1Amount, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="PurchaseOrder Order Additional Discount1 Percent", Nillable=true, AverageLength=14, Name="orderAdditionalDiscount1Percent", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> orderAdditionalDiscount1Percent { get { return _orderAdditionalDiscount1Percent; } set { SetProperty(PropertyorderAdditionalDiscount1Percent, ref _orderAdditionalDiscount1Percent, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="PurchaseOrder Order Additional Discount2 Type", Name="orderAdditionalDiscount2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String orderAdditionalDiscount2 { get { return _orderAdditionalDiscount2; } set { SetProperty(PropertyorderAdditionalDiscount2, ref _orderAdditionalDiscount2, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="PurchaseOrder Order Additional Discount2 Amount", Nillable=true, AverageLength=14, Name="orderAdditionalDiscount2Amount", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> orderAdditionalDiscount2Amount { get { return _orderAdditionalDiscount2Amount; } set { SetProperty(PropertyorderAdditionalDiscount2Amount, ref _orderAdditionalDiscount2Amount, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="PurchaseOrder Order Additional Discount2 Percent", Nillable=true, AverageLength=14, Name="orderAdditionalDiscount2Percent", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> orderAdditionalDiscount2Percent { get { return _orderAdditionalDiscount2Percent; } set { SetProperty(PropertyorderAdditionalDiscount2Percent, ref _orderAdditionalDiscount2Percent, value); } }

		[SMEStringProperty(Label="PurchaseOrder Text1", Name="text1", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String text1 { get { return _text1; } set { SetProperty(Propertytext1, ref _text1, value); } }

		[SMEStringProperty(Label="PurchaseOrder Text2", Name="text2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String text2 { get { return _text2; } set { SetProperty(Propertytext2, ref _text2, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="PurchaseOrder Net Total", Nillable=true, AverageLength=14, Name="netTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> netTotal { get { return _netTotal; } set { SetProperty(PropertynetTotal, ref _netTotal, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="PurchaseOrder Discount Total", Nillable=true, AverageLength=14, Name="discountTotal", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> discountTotal { get { return _discountTotal; } set { SetProperty(PropertydiscountTotal, ref _discountTotal, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="PurchaseOrder Charges Total", Nillable=true, AverageLength=14, Name="chargesTotal", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> chargesTotal { get { return _chargesTotal; } set { SetProperty(PropertychargesTotal, ref _chargesTotal, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="PurchaseOrder Tax Total", Nillable=true, AverageLength=14, Name="taxTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> taxTotal { get { return _taxTotal; } set { SetProperty(PropertytaxTotal, ref _taxTotal, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="PurchaseOrder Gross Total", Nillable=true, AverageLength=14, Name="grossTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> grossTotal { get { return _grossTotal; } set { SetProperty(PropertygrossTotal, ref _grossTotal, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEBoolProperty(Label="PurchaseOrder Deposit Flag", Nillable=true, Name="depositFlag", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Boolean> depositFlag { get { return _depositFlag; } set { SetProperty(PropertydepositFlag, ref _depositFlag, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="PurchaseOrder Contract", Name="contract", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String contract { get { return _contract; } set { SetProperty(Propertycontract, ref _contract, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="tradingAccounts", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="invoiceTradingAccount", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("invoiceTradingAccount")]			
		public virtual tradingAccountFeedEntry invoiceTradingAccount { get { return _invoiceTradingAccount; } set { SetProperty(PropertyinvoiceTradingAccount, ref _invoiceTradingAccount, value); } }

		[SMEResource(CanGet=true, PluralName="projects", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="projects", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual projectFeed projects { get { return _projects; } set { SetProperty(Propertyprojects, ref _projects, value); } }

		[SMEResource(CanGet=true, PluralName="purchaseOrderDeliveries", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="purchaseOrderDeliveries", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual purchaseOrderDeliveryFeed purchaseOrderDeliveries { get { return _purchaseOrderDeliveries; } set { SetProperty(PropertypurchaseOrderDeliveries, ref _purchaseOrderDeliveries, value); } }

		[SMEResource(CanGet=true, PluralName="financialAccounts", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="financialAccounts", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual financialAccountFeed financialAccounts { get { return _financialAccounts; } set { SetProperty(PropertyfinancialAccounts, ref _financialAccounts, value); } }

		[SMEResource(CanGet=true, PluralName="interactions", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="interactions", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual interactionFeed interactions { get { return _interactions; } set { SetProperty(Propertyinteractions, ref _interactions, value); } }

		[SMEResource(CanGet=true, CanPut=true, PluralName="notes", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="notes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual noteFeed notes { get { return _notes; } set { SetProperty(Propertynotes, ref _notes, value); } }

		[SMETimeProperty(Label="Supplier Identifier", Name="SupplierId", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.DateTime SupplierId { get { return _SupplierId; } set { SetProperty(PropertySupplierId, ref _SupplierId, value); } }

		[SMEStringProperty(Label="Purchase Order On Order Status", Name="onOrder", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String onOrder { get { return _onOrder; } set { SetProperty(PropertyonOrder, ref _onOrder, value); } }

		#endregion


	}
}