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
	/// Defines a purchaseOrderLine feed entry
	/// </summary>
	#endregion
	[System.ComponentModel.Browsable(false)]
	[XmlType("purchaseOrderLine", Namespace="http://schemas.sage.com/crmErp/2008")]
	public class purchaseOrderLineFeedEntrySchema : Sage.Common.Syndication.FeedEntry
	{
		#region Constants

		public const string Propertyactive = "active";
		public const string Propertyreference = "reference";
		public const string Propertyreference2 = "reference2";
		public const string Propertynumber = "number";
		public const string Propertystatus = "status";
		public const string Propertytype = "type";
		public const string PropertydeliveryTerms = "deliveryTerms";
		public const string PropertydeliveryDate = "deliveryDate";
		public const string PropertydueDate = "dueDate";
		public const string PropertycarrierTradingAccount = "carrierTradingAccount";
		public const string PropertycarrierNetPrice = "carrierNetPrice";
		public const string PropertycarrierTaxPrice = "carrierTaxPrice";
		public const string PropertycarrierTotalPrice = "carrierTotalPrice";
		public const string PropertycarrierTaxCodes = "carrierTaxCodes";
		public const string PropertycarrierReference = "carrierReference";
		public const string Propertycommodity = "commodity";
		public const string Propertytext = "text";
		public const string PropertyfulfillmentLocation = "fulfillmentLocation";
		public const string PropertyunitOfMeasure = "unitOfMeasure";
		public const string Propertyquantity = "quantity";
		public const string PropertyinitialPrice = "initialPrice";
		public const string Propertypricelist = "pricelist";
		public const string PropertycustomerTradingAccount = "customerTradingAccount";
		public const string PropertycustomerReference = "customerReference";
		public const string PropertycustomerSalesOrder = "customerSalesOrder";
		public const string PropertycustomerSalesOrderLine = "customerSalesOrderLine";
		public const string PropertyorderLineDiscountType = "orderLineDiscountType";
		public const string PropertyorderLineDiscountAmount = "orderLineDiscountAmount";
		public const string PropertyorderLineDiscountPercent = "orderLineDiscountPercent";
		public const string PropertyorderLineSubtotalDiscountType = "orderLineSubtotalDiscountType";
		public const string PropertyorderLineSubtotalDiscountAmount = "orderLineSubtotalDiscountAmount";
		public const string PropertyorderLineSubtotalDiscountPercent = "orderLineSubtotalDiscountPercent";
		public const string PropertyactualPrice = "actualPrice";
		public const string PropertynetTotal = "netTotal";
		public const string PropertydiscountTotal = "discountTotal";
		public const string PropertychargesTotal = "chargesTotal";
		public const string PropertyfOBPoint = "fOBPoint";
		public const string PropertytaxCodes = "taxCodes";
		public const string PropertypriceTax = "priceTax";
		public const string PropertytaxTotal = "taxTotal";
		public const string PropertygrossTotal = "grossTotal";
		public const string Propertyproject = "project";
		public const string PropertypurchaseOrderDeliveryLine = "purchaseOrderDeliveryLine";
		public const string PropertyfinancialAccounts = "financialAccounts";
		public const string Propertynotes = "notes";

		#endregion

		#region Fields

		private Nullable<System.Boolean> _active;
		private System.String _reference;
		private System.String _reference2;
		private Nullable<System.Decimal> _number;
		private System.String _status;
		private System.String _type;
		private System.String _deliveryTerms;
		private Nullable<System.DateTime> _deliveryDate;
		private Nullable<System.DateTime> _dueDate;
		private tradingAccountFeedEntry _carrierTradingAccount;
		private Nullable<System.Decimal> _carrierNetPrice;
		private Nullable<System.Decimal> _carrierTaxPrice;
		private Nullable<System.Decimal> _carrierTotalPrice;
		private taxCodeFeed _carrierTaxCodes;
		private System.String _carrierReference;
		private commodityFeedEntry _commodity;
		private System.String _text;
		private locationFeedEntry _fulfillmentLocation;
		private unitOfMeasureFeedEntry _unitOfMeasure;
		private Nullable<System.Decimal> _quantity;
		private Nullable<System.Decimal> _initialPrice;
		private priceListFeedEntry _pricelist;
		private tradingAccountFeedEntry _customerTradingAccount;
		private System.String _customerReference;
		private salesOrderFeed _customerSalesOrder;
		private salesOrderLineFeed _customerSalesOrderLine;
		private System.String _orderLineDiscountType;
		private Nullable<System.Decimal> _orderLineDiscountAmount;
		private Nullable<System.Decimal> _orderLineDiscountPercent;
		private System.String _orderLineSubtotalDiscountType;
		private Nullable<System.Decimal> _orderLineSubtotalDiscountAmount;
		private Nullable<System.Decimal> _orderLineSubtotalDiscountPercent;
		private Nullable<System.Decimal> _actualPrice;
		private Nullable<System.Decimal> _netTotal;
		private Nullable<System.Decimal> _discountTotal;
		private Nullable<System.Decimal> _chargesTotal;
		private System.String _fOBPoint;
		private taxCodeFeed _taxCodes;
		private Nullable<System.Decimal> _priceTax;
		private Nullable<System.Decimal> _taxTotal;
		private Nullable<System.Decimal> _grossTotal;
		private projectFeedEntry _project;
		private purchaseOrderDeliveryLineFeed _purchaseOrderDeliveryLine;
		private financialAccountFeed _financialAccounts;
		private noteFeed _notes;

		#endregion

		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="purchaseOrderLineFeedEntrySchema"/> class.
		/// </summary>
		#endregion
		public purchaseOrderLineFeedEntrySchema()
		{
		}

		#region Properties


		[SMEBoolProperty(Label="PurchaseOrderLine Active Flag", Nillable=true, Name="active", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.Boolean> active { get { return _active; } set { SetProperty(Propertyactive, ref _active, value); } }

		[SMEStringProperty(Label="PurchaseOrderLine reference", Name="reference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true, IsUniqueKey=true)]			
		public virtual System.String reference { get { return _reference; } set { SetProperty(Propertyreference, ref _reference, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="PurchaseOrderLine Reference2", Name="reference2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true, Unsupported=true)]			
		public virtual System.String reference2 { get { return _reference2; } set { SetProperty(Propertyreference2, ref _reference2, value); } }

		[SMEDecimalProperty(DecimalPlaces=0, Label="PurchaseOrderLine Number", Nillable=true, AverageLength=12, Name="number", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> number { get { return _number; } set { SetProperty(Propertynumber, ref _number, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="PurchaseOrderLine Status", Name="status", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String status { get { return _status; } set { SetProperty(Propertystatus, ref _status, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="PurchaseOrderLine Type", Name="type", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsMandatory=true, Unsupported=true)]			
		public virtual System.String type { get { return _type; } set { SetProperty(Propertytype, ref _type, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="PurchaseOrderLine Delivery Terms", Name="deliveryTerms", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String deliveryTerms { get { return _deliveryTerms; } set { SetProperty(PropertydeliveryTerms, ref _deliveryTerms, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDateProperty(Label="PurchaseOrderLine Delivery Date", Nillable=true, Name="deliveryDate", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.DateTime> deliveryDate { get { return _deliveryDate; } set { SetProperty(PropertydeliveryDate, ref _deliveryDate, value); } }

		[SMEDateProperty(Label="PurchaseOrderLine Due Date", Nillable=true, Name="dueDate", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.DateTime> dueDate { get { return _dueDate; } set { SetProperty(PropertydueDate, ref _dueDate, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="tradingAccounts", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="carrierTradingAccount", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("carrierTradingAccount")]			
		public virtual tradingAccountFeedEntry carrierTradingAccount { get { return _carrierTradingAccount; } set { SetProperty(PropertycarrierTradingAccount, ref _carrierTradingAccount, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="PurchaseOrderLine Carrier Net Price", Nillable=true, AverageLength=14, Name="carrierNetPrice", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> carrierNetPrice { get { return _carrierNetPrice; } set { SetProperty(PropertycarrierNetPrice, ref _carrierNetPrice, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="PurchaseOrderLine Carrier Tax Price", Nillable=true, AverageLength=14, Name="carrierTaxPrice", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> carrierTaxPrice { get { return _carrierTaxPrice; } set { SetProperty(PropertycarrierTaxPrice, ref _carrierTaxPrice, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="PurchaseOrderLine Carrier Gross Price", Nillable=true, AverageLength=14, Name="carrierTotalPrice", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> carrierTotalPrice { get { return _carrierTotalPrice; } set { SetProperty(PropertycarrierTotalPrice, ref _carrierTotalPrice, value); } }

		[SMEResource(CanGet=true, PluralName="taxCodes", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="carrierTaxCodes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual taxCodeFeed carrierTaxCodes { get { return _carrierTaxCodes; } set { SetProperty(PropertycarrierTaxCodes, ref _carrierTaxCodes, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="PurchaseOrderLine Carrier reference", Name="carrierReference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String carrierReference { get { return _carrierReference; } set { SetProperty(PropertycarrierReference, ref _carrierReference, value); } }

		[SMEResource(CanGet=true, PluralName="commodities", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="commodity", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("commodity")]			
		public virtual commodityFeedEntry commodity { get { return _commodity; } set { SetProperty(Propertycommodity, ref _commodity, value); } }

		[SMEStringProperty(Label="PurchaseOrderLine Text", Name="text", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String text { get { return _text; } set { SetProperty(Propertytext, ref _text, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="locations", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="fulfillmentLocation", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("fulfillmentLocation")]			
		public virtual locationFeedEntry fulfillmentLocation { get { return _fulfillmentLocation; } set { SetProperty(PropertyfulfillmentLocation, ref _fulfillmentLocation, value); } }

		[SMEResource(CanGet=true, PluralName="unitsOfMeasure", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="unitOfMeasure", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("unitOfMeasure")]			
		public virtual unitOfMeasureFeedEntry unitOfMeasure { get { return _unitOfMeasure; } set { SetProperty(PropertyunitOfMeasure, ref _unitOfMeasure, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="PurchaseOrderLine Quantity", Nillable=true, AverageLength=14, Name="quantity", Namespace="http://schemas.sage.com/crmErp/2008", IsMandatory=true)]			
		public virtual Nullable<System.Decimal> quantity { get { return _quantity; } set { SetProperty(Propertyquantity, ref _quantity, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="PurchaseOrderLine Initial Price", Nillable=true, AverageLength=14, Name="initialPrice", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> initialPrice { get { return _initialPrice; } set { SetProperty(PropertyinitialPrice, ref _initialPrice, value); } }

		[SMEResource(CanGet=true, PluralName="priceLists", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="pricelist", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("pricelist")]			
		public virtual priceListFeedEntry pricelist { get { return _pricelist; } set { SetProperty(Propertypricelist, ref _pricelist, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="tradingAccounts", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="customerTradingAccount", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("customerTradingAccount")]			
		public virtual tradingAccountFeedEntry customerTradingAccount { get { return _customerTradingAccount; } set { SetProperty(PropertycustomerTradingAccount, ref _customerTradingAccount, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="PurchaseOrderLine Customer reference", Name="customerReference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String customerReference { get { return _customerReference; } set { SetProperty(PropertycustomerReference, ref _customerReference, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanDelete=true, PluralName="salesOrders", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="customerSalesOrder", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesOrderFeed customerSalesOrder { get { return _customerSalesOrder; } set { SetProperty(PropertycustomerSalesOrder, ref _customerSalesOrder, value); } }

		[SMEResource(CanGet=true, CanPost=true, PluralName="salesOrderLines", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="customerSalesOrderLine", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesOrderLineFeed customerSalesOrderLine { get { return _customerSalesOrderLine; } set { SetProperty(PropertycustomerSalesOrderLine, ref _customerSalesOrderLine, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="PurchaseOrderLine Order Line Discount Type", Name="orderLineDiscountType", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String orderLineDiscountType { get { return _orderLineDiscountType; } set { SetProperty(PropertyorderLineDiscountType, ref _orderLineDiscountType, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="PurchaseOrderLine Order Line Discount Amount", Nillable=true, AverageLength=14, Name="orderLineDiscountAmount", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> orderLineDiscountAmount { get { return _orderLineDiscountAmount; } set { SetProperty(PropertyorderLineDiscountAmount, ref _orderLineDiscountAmount, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="PurchaseOrderLine Order Line Discount Percent", Nillable=true, AverageLength=14, Name="orderLineDiscountPercent", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> orderLineDiscountPercent { get { return _orderLineDiscountPercent; } set { SetProperty(PropertyorderLineDiscountPercent, ref _orderLineDiscountPercent, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="PurchaseOrderLine Order Line Subtotal Discount Type", Name="orderLineSubtotalDiscountType", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String orderLineSubtotalDiscountType { get { return _orderLineSubtotalDiscountType; } set { SetProperty(PropertyorderLineSubtotalDiscountType, ref _orderLineSubtotalDiscountType, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="PurchaseOrderLine Order Line Subtotal Discount Amount", Nillable=true, AverageLength=14, Name="orderLineSubtotalDiscountAmount", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> orderLineSubtotalDiscountAmount { get { return _orderLineSubtotalDiscountAmount; } set { SetProperty(PropertyorderLineSubtotalDiscountAmount, ref _orderLineSubtotalDiscountAmount, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="PurchaseOrderLine Order Line Subtotal Discount Percent", Nillable=true, AverageLength=14, Name="orderLineSubtotalDiscountPercent", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> orderLineSubtotalDiscountPercent { get { return _orderLineSubtotalDiscountPercent; } set { SetProperty(PropertyorderLineSubtotalDiscountPercent, ref _orderLineSubtotalDiscountPercent, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="PurchaseOrderLine Actual Price", Nillable=true, AverageLength=14, Name="actualPrice", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> actualPrice { get { return _actualPrice; } set { SetProperty(PropertyactualPrice, ref _actualPrice, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="PurchaseOrderLine Net Total", Nillable=true, AverageLength=14, Name="netTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> netTotal { get { return _netTotal; } set { SetProperty(PropertynetTotal, ref _netTotal, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="PurchaseOrderLine Discount Total", Nillable=true, AverageLength=14, Name="discountTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> discountTotal { get { return _discountTotal; } set { SetProperty(PropertydiscountTotal, ref _discountTotal, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="PurchaseOrderLine Charges Total", Nillable=true, AverageLength=14, Name="chargesTotal", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> chargesTotal { get { return _chargesTotal; } set { SetProperty(PropertychargesTotal, ref _chargesTotal, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="PurchaseOrderLine FOB Point", Name="fOBPoint", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String fOBPoint { get { return _fOBPoint; } set { SetProperty(PropertyfOBPoint, ref _fOBPoint, value); } }

		[SMEResource(CanGet=true, PluralName="taxCodes", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="taxCodes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual taxCodeFeed taxCodes { get { return _taxCodes; } set { SetProperty(PropertytaxCodes, ref _taxCodes, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="PurchaseOrderLine Price Tax", Nillable=true, AverageLength=14, Name="priceTax", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> priceTax { get { return _priceTax; } set { SetProperty(PropertypriceTax, ref _priceTax, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="PurchaseOrderLine Tax Total", Nillable=true, AverageLength=14, Name="taxTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> taxTotal { get { return _taxTotal; } set { SetProperty(PropertytaxTotal, ref _taxTotal, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="PurchaseOrderLine Gross Total", Nillable=true, AverageLength=14, Name="grossTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> grossTotal { get { return _grossTotal; } set { SetProperty(PropertygrossTotal, ref _grossTotal, value); } }

		[SMEResource(CanGet=true, PluralName="projects", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="project", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("project")]			
		public virtual projectFeedEntry project { get { return _project; } set { SetProperty(Propertyproject, ref _project, value); } }

		[SMEResource(CanGet=true, PluralName="purchaseOrderDeliveryLines", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="purchaseOrderDeliveryLine", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual purchaseOrderDeliveryLineFeed purchaseOrderDeliveryLine { get { return _purchaseOrderDeliveryLine; } set { SetProperty(PropertypurchaseOrderDeliveryLine, ref _purchaseOrderDeliveryLine, value); } }

		[SMEResource(CanGet=true, PluralName="financialAccounts", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="financialAccounts", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual financialAccountFeed financialAccounts { get { return _financialAccounts; } set { SetProperty(PropertyfinancialAccounts, ref _financialAccounts, value); } }

		[SMEResource(CanGet=true, CanPut=true, PluralName="notes", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="notes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual noteFeed notes { get { return _notes; } set { SetProperty(Propertynotes, ref _notes, value); } }

		#endregion


	}
}