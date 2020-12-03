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
	/// Defines a purchaseOrderDelivery feed entry
	/// </summary>
	#endregion
	[System.ComponentModel.Browsable(false)]
	[XmlType("purchaseOrderDelivery", Namespace="http://schemas.sage.com/crmErp/2008")]
	public class purchaseOrderDeliveryFeedEntrySchema : Sage.Common.Syndication.FeedEntry
	{
		#region Constants

		public const string Propertyactive = "active";
		public const string PropertypurchaseOrder = "purchaseOrder";
		public const string Propertyreference = "reference";
		public const string Propertyreference2 = "reference2";
		public const string Propertystatus = "status";
		public const string PropertytradingAccount = "tradingAccount";
		public const string PropertysupplierReference = "supplierReference";
		public const string Propertytype = "type";
		public const string PropertypostalAddress = "postalAddress";
		public const string PropertydeliveryMethod = "deliveryMethod";
		public const string PropertycarrierTradingAccount = "carrierTradingAccount";
		public const string PropertydeliveryContact = "deliveryContact";
		public const string PropertycarrierReference = "carrierReference";
		public const string PropertycarrierNetPrice = "carrierNetPrice";
		public const string PropertycarrierTaxPrice = "carrierTaxPrice";
		public const string PropertycarrierTotalPrice = "carrierTotalPrice";
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
		public const string PropertyrequestedDeliveryDate = "requestedDeliveryDate";
		public const string PropertyactualDeliveryDate = "actualDeliveryDate";
		public const string PropertyactualDeliveryTime = "actualDeliveryTime";
		public const string PropertydateExceptionReason = "dateExceptionReason";
		public const string PropertypurchaseOrderDeliveryLines = "purchaseOrderDeliveryLines";
		public const string PropertylineCount = "lineCount";
		public const string PropertyrequestedQuantity = "requestedQuantity";
		public const string PropertydeliveredQuantity = "deliveredQuantity";
		public const string Propertytext1 = "text1";
		public const string Propertytext2 = "text2";
		public const string PropertydestinationCountry = "destinationCountry";
		public const string Propertyuser = "user";
		public const string Propertyinteractions = "interactions";
		public const string Propertynotes = "notes";
		public const string PropertySupplierId = "SupplierId";

		#endregion

		#region Fields

		private Nullable<System.Boolean> _active;
		private purchaseOrderFeedEntry _purchaseOrder;
		private System.String _reference;
		private System.String _reference2;
		private System.String _status;
		private tradingAccountFeedEntry _tradingAccount;
		private System.String _supplierReference;
		private System.String _type;
		private postalAddressFeedEntry _postalAddress;
		private System.String _deliveryMethod;
		private tradingAccountFeedEntry _carrierTradingAccount;
		private contactFeedEntry _deliveryContact;
		private System.String _carrierReference;
		private Nullable<System.Decimal> _carrierNetPrice;
		private Nullable<System.Decimal> _carrierTaxPrice;
		private Nullable<System.Decimal> _carrierTotalPrice;
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
		private Nullable<System.DateTime> _requestedDeliveryDate;
		private Nullable<System.DateTime> _actualDeliveryDate;
		private Nullable<System.DateTime> _actualDeliveryTime;
		private System.String _dateExceptionReason;
		private purchaseOrderDeliveryLineFeed _purchaseOrderDeliveryLines;
		private Nullable<System.Decimal> _lineCount;
		private Nullable<System.Decimal> _requestedQuantity;
		private Nullable<System.Decimal> _deliveredQuantity;
		private System.String _text1;
		private System.String _text2;
		private System.String _destinationCountry;
		private System.String _user;
		private interactionFeedEntry _interactions;
		private noteFeedEntry _notes;
		private System.DateTime _SupplierId;

		#endregion

		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="purchaseOrderDeliveryFeedEntrySchema"/> class.
		/// </summary>
		#endregion
		public purchaseOrderDeliveryFeedEntrySchema()
		{
		}

		#region Properties


		[SMEBoolProperty(Label="PurchaseOrderDelivery Active Flag", Nillable=true, Name="active", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.Boolean> active { get { return _active; } set { SetProperty(Propertyactive, ref _active, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanDelete=true, PluralName="purchaseOrders", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Parent, Name="purchaseOrder", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("purchaseOrder")]			
		public virtual purchaseOrderFeedEntry purchaseOrder { get { return _purchaseOrder; } set { SetProperty(PropertypurchaseOrder, ref _purchaseOrder, value); } }

		[SMEStringProperty(Label="PurchaseOrderDelivery reference", Name="reference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String reference { get { return _reference; } set { SetProperty(Propertyreference, ref _reference, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="PurchaseOrderDelivery Reference2", Name="reference2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String reference2 { get { return _reference2; } set { SetProperty(Propertyreference2, ref _reference2, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="PurchaseOrderDelivery Status", Name="status", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String status { get { return _status; } set { SetProperty(Propertystatus, ref _status, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="tradingAccounts", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="tradingAccount", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("tradingAccount")]			
		public virtual tradingAccountFeedEntry tradingAccount { get { return _tradingAccount; } set { SetProperty(PropertytradingAccount, ref _tradingAccount, value); } }

		[SMEStringProperty(Label="PurchaseOrderDelivery Supplier reference", Name="supplierReference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String supplierReference { get { return _supplierReference; } set { SetProperty(PropertysupplierReference, ref _supplierReference, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="PurchaseOrderDelivery Type", Name="type", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String type { get { return _type; } set { SetProperty(Propertytype, ref _type, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="postalAddresses", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, Name="postalAddress", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("postalAddress")]			
		public virtual postalAddressFeedEntry postalAddress { get { return _postalAddress; } set { SetProperty(PropertypostalAddress, ref _postalAddress, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="PurchaseOrderDelivery Method", Name="deliveryMethod", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String deliveryMethod { get { return _deliveryMethod; } set { SetProperty(PropertydeliveryMethod, ref _deliveryMethod, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="tradingAccounts", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="carrierTradingAccount", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("carrierTradingAccount")]			
		public virtual tradingAccountFeedEntry carrierTradingAccount { get { return _carrierTradingAccount; } set { SetProperty(PropertycarrierTradingAccount, ref _carrierTradingAccount, value); } }

		[SMEResource(CanGet=true, PluralName="contacts", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="deliveryContact", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("deliveryContact")]			
		public virtual contactFeedEntry deliveryContact { get { return _deliveryContact; } set { SetProperty(PropertydeliveryContact, ref _deliveryContact, value); } }

		[SMEStringProperty(Label="PurchaseOrderDelivery Carrier reference", Name="carrierReference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String carrierReference { get { return _carrierReference; } set { SetProperty(PropertycarrierReference, ref _carrierReference, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=0, Label="PurchaseOrderDelivery Carrier Net Price", Nillable=true, AverageLength=12, Name="carrierNetPrice", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> carrierNetPrice { get { return _carrierNetPrice; } set { SetProperty(PropertycarrierNetPrice, ref _carrierNetPrice, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=0, Label="PurchaseOrderDelivery Carrier Tax Price", Nillable=true, AverageLength=12, Name="carrierTaxPrice", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> carrierTaxPrice { get { return _carrierTaxPrice; } set { SetProperty(PropertycarrierTaxPrice, ref _carrierTaxPrice, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=0, Label="PurchaseOrderDelivery Carrier Gross Price", Nillable=true, AverageLength=12, Name="carrierTotalPrice", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> carrierTotalPrice { get { return _carrierTotalPrice; } set { SetProperty(PropertycarrierTotalPrice, ref _carrierTotalPrice, value); } }

		[SMEStringProperty(Label="PurchaseOrderDelivery Currency", Name="currency", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String currency { get { return _currency; } set { SetProperty(Propertycurrency, ref _currency, value); } }

		[SMEStringProperty(Label="PurchaseOrderDelivery OperatingCompany Currency", Name="operatingCompanyCurrency", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String operatingCompanyCurrency { get { return _operatingCompanyCurrency; } set { SetProperty(PropertyoperatingCompanyCurrency, ref _operatingCompanyCurrency, value); } }

		[SMEDecimalProperty(DecimalPlaces=0, Label="PurchaseOrderDelivery OperatingCompany Currency Exchange Rate", Nillable=true, AverageLength=12, Name="operatingCompanyCurrencyExchangeRate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> operatingCompanyCurrencyExchangeRate { get { return _operatingCompanyCurrencyExchangeRate; } set { SetProperty(PropertyoperatingCompanyCurrencyExchangeRate, ref _operatingCompanyCurrencyExchangeRate, value); } }

		[SMEStringProperty(Label="PurchaseOrderDelivery OperatingCompany Currency Exchange Rate Operator", Name="operatingCompanyCurrencyExchangeRateOperator", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String operatingCompanyCurrencyExchangeRateOperator { get { return _operatingCompanyCurrencyExchangeRateOperator; } set { SetProperty(PropertyoperatingCompanyCurrencyExchangeRateOperator, ref _operatingCompanyCurrencyExchangeRateOperator, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDateProperty(Label="PurchaseOrderDelivery OperatingCompany Currency Exchange Rate Date", Nillable=true, Name="operatingCompanyCurrencyExchangeRateDate", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.DateTime> operatingCompanyCurrencyExchangeRateDate { get { return _operatingCompanyCurrencyExchangeRateDate; } set { SetProperty(PropertyoperatingCompanyCurrencyExchangeRateDate, ref _operatingCompanyCurrencyExchangeRateDate, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="PurchaseOrderDelivery Invoice Currency", Name="invoiceCurrency", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String invoiceCurrency { get { return _invoiceCurrency; } set { SetProperty(PropertyinvoiceCurrency, ref _invoiceCurrency, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=0, Label="PurchaseOrderDelivery Invoice Currency Exchange Rate", Nillable=true, AverageLength=12, Name="invoiceCurrencyExchangeRate", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> invoiceCurrencyExchangeRate { get { return _invoiceCurrencyExchangeRate; } set { SetProperty(PropertyinvoiceCurrencyExchangeRate, ref _invoiceCurrencyExchangeRate, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="PurchaseOrderDelivery Invoice Currency Exchange Rate Operator", Name="invoiceCurrencyExchangeRateOperator", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String invoiceCurrencyExchangeRateOperator { get { return _invoiceCurrencyExchangeRateOperator; } set { SetProperty(PropertyinvoiceCurrencyExchangeRateOperator, ref _invoiceCurrencyExchangeRateOperator, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDateProperty(Label="PurchaseOrderDelivery Invoice Currency Exchange Rate Date", Nillable=true, Name="invoiceCurrencyExchangeRateDate", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.DateTime> invoiceCurrencyExchangeRateDate { get { return _invoiceCurrencyExchangeRateDate; } set { SetProperty(PropertyinvoiceCurrencyExchangeRateDate, ref _invoiceCurrencyExchangeRateDate, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="PurchaseOrderDelivery Supplier TradingAccount Currency", Name="supplierTradingAccountCurrency", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String supplierTradingAccountCurrency { get { return _supplierTradingAccountCurrency; } set { SetProperty(PropertysupplierTradingAccountCurrency, ref _supplierTradingAccountCurrency, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="PurchaseOrderDelivery Supplier TradingAccount Currency Exchange Rate", Nillable=true, AverageLength=14, Name="supplierTradingAccountCurrencyExchangeRate", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> supplierTradingAccountCurrencyExchangeRate { get { return _supplierTradingAccountCurrencyExchangeRate; } set { SetProperty(PropertysupplierTradingAccountCurrencyExchangeRate, ref _supplierTradingAccountCurrencyExchangeRate, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="PurchaseOrderDelivery Supplier TradingAccount Currency Exchange Rate Operator", Name="supplierTradingAccountCurrencyExchangeRateOperator", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String supplierTradingAccountCurrencyExchangeRateOperator { get { return _supplierTradingAccountCurrencyExchangeRateOperator; } set { SetProperty(PropertysupplierTradingAccountCurrencyExchangeRateOperator, ref _supplierTradingAccountCurrencyExchangeRateOperator, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDateProperty(Label="PurchaseOrderDelivery Supplier TradingAccount Currency Exchange Rate Date", Nillable=true, Name="supplierTradingAccountCurrencyExchangeRateDate", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.DateTime> supplierTradingAccountCurrencyExchangeRateDate { get { return _supplierTradingAccountCurrencyExchangeRateDate; } set { SetProperty(PropertysupplierTradingAccountCurrencyExchangeRateDate, ref _supplierTradingAccountCurrencyExchangeRateDate, value); } }

		[SMEDateProperty(Label="PurchaseOrderDelivery Requested Delivery Date", Nillable=true, Name="requestedDeliveryDate", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.DateTime> requestedDeliveryDate { get { return _requestedDeliveryDate; } set { SetProperty(PropertyrequestedDeliveryDate, ref _requestedDeliveryDate, value); } }

		[SMEDateProperty(Label="PurchaseOrderDelivery Actual Delivery Date", Nillable=true, Name="actualDeliveryDate", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.DateTime> actualDeliveryDate { get { return _actualDeliveryDate; } set { SetProperty(PropertyactualDeliveryDate, ref _actualDeliveryDate, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMETimeProperty(Label="PurchaseOrderDelivery Actual Delivery Time", Nillable=true, Name="actualDeliveryTime", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.DateTime> actualDeliveryTime { get { return _actualDeliveryTime; } set { SetProperty(PropertyactualDeliveryTime, ref _actualDeliveryTime, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="PurchaseOrderDelivery Date Exception Reason", Name="dateExceptionReason", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String dateExceptionReason { get { return _dateExceptionReason; } set { SetProperty(PropertydateExceptionReason, ref _dateExceptionReason, value); } }

		[SMEResource(CanGet=true, PluralName="purchaseOrderDeliveryLines", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Child, IsCollection=true, Name="purchaseOrderDeliveryLines", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual purchaseOrderDeliveryLineFeed purchaseOrderDeliveryLines { get { return _purchaseOrderDeliveryLines; } set { SetProperty(PropertypurchaseOrderDeliveryLines, ref _purchaseOrderDeliveryLines, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="PurchaseOrderDelivery Line Count", Nillable=true, AverageLength=14, Name="lineCount", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> lineCount { get { return _lineCount; } set { SetProperty(PropertylineCount, ref _lineCount, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=0, Label="PurchaseOrderDelivery Requested Quantity", Nillable=true, AverageLength=12, Name="requestedQuantity", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> requestedQuantity { get { return _requestedQuantity; } set { SetProperty(PropertyrequestedQuantity, ref _requestedQuantity, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=0, Label="PurchaseOrderDelivery Delivered Quantity", Nillable=true, AverageLength=12, Name="deliveredQuantity", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> deliveredQuantity { get { return _deliveredQuantity; } set { SetProperty(PropertydeliveredQuantity, ref _deliveredQuantity, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="PurchaseOrderDelivery Text1", Name="text1", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String text1 { get { return _text1; } set { SetProperty(Propertytext1, ref _text1, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="PurchaseOrderDelivery Text2", Name="text2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String text2 { get { return _text2; } set { SetProperty(Propertytext2, ref _text2, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="PurchaseOrderDelivery Destination Country", Name="destinationCountry", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String destinationCountry { get { return _destinationCountry; } set { SetProperty(PropertydestinationCountry, ref _destinationCountry, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="PurchaseOrderDelivery User", Name="user", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String user { get { return _user; } set { SetProperty(Propertyuser, ref _user, value); } }

		[SMEResource(CanGet=true, PluralName="interactions", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, Name="interactions", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("interactions")]			
		public virtual interactionFeedEntry interactions { get { return _interactions; } set { SetProperty(Propertyinteractions, ref _interactions, value); } }

		[SMEResource(CanGet=true, CanPut=true, PluralName="notes", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Child, Name="notes", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("notes")]			
		public virtual noteFeedEntry notes { get { return _notes; } set { SetProperty(Propertynotes, ref _notes, value); } }

		[SMETimeProperty(Label="Supplier Identifier", Name="SupplierId", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual System.DateTime SupplierId { get { return _SupplierId; } set { SetProperty(PropertySupplierId, ref _SupplierId, value); } }

		#endregion


	}
}