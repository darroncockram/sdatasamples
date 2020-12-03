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
	/// Defines a salesOrderDeliveryLine feed entry
	/// </summary>
	#endregion
	[System.ComponentModel.Browsable(false)]
	[XmlType("salesOrderDeliveryLine", Namespace="http://schemas.sage.com/crmErp/2008")]
	public class salesOrderDeliveryLineFeedEntrySchema : Sage.Common.Syndication.FeedEntry
	{
		#region Constants

		public const string PropertysalesOrderDelivery = "salesOrderDelivery";
		public const string Propertyactive = "active";
		public const string Propertyreference = "reference";
		public const string Propertyreference2 = "reference2";
		public const string Propertynumber = "number";
		public const string Propertystatus = "status";
		public const string Propertytype = "type";
		public const string Propertycommodity = "commodity";
		public const string Propertytext = "text";
		public const string PropertyfulfillmentLocation = "fulfillmentLocation";
		public const string PropertyfulfillmentSubLocation = "fulfillmentSubLocation";
		public const string PropertyrequestedDeliveryDate = "requestedDeliveryDate";
		public const string PropertyactualDeliveryDate = "actualDeliveryDate";
		public const string PropertyactualDeliveryTime = "actualDeliveryTime";
		public const string PropertydateExceptionReason = "dateExceptionReason";
		public const string PropertyunitOfMeasure = "unitOfMeasure";
		public const string PropertyrequestedQuantity = "requestedQuantity";
		public const string PropertydeliveredQuantity = "deliveredQuantity";
		public const string PropertyinitialPrice = "initialPrice";
		public const string Propertypricelist = "pricelist";
		public const string PropertydeliveryLineDiscountType = "deliveryLineDiscountType";
		public const string PropertydeliveryLineDiscountAmount = "deliveryLineDiscountAmount";
		public const string PropertydeliveryLineDiscountPercent = "deliveryLineDiscountPercent";
		public const string PropertydeliveryLineSubtotalDiscountType = "deliveryLineSubtotalDiscountType";
		public const string PropertydeliveryLineSubtotalDiscountAmount = "deliveryLineSubtotalDiscountAmount";
		public const string PropertydeliveryLineSubtotalDiscountPercent = "deliveryLineSubtotalDiscountPercent";
		public const string PropertyactualPrice = "actualPrice";
		public const string PropertynetTotal = "netTotal";
		public const string PropertychargesTotal = "chargesTotal";
		public const string PropertydiscountTotal = "discountTotal";
		public const string PropertytaxCodes = "taxCodes";
		public const string PropertypriceTax = "priceTax";
		public const string PropertytaxTotal = "taxTotal";
		public const string PropertygrossTotal = "grossTotal";
		public const string PropertycostTotal = "costTotal";
		public const string PropertyprofitTotal = "profitTotal";
		public const string PropertysalesInvoiceLines = "salesInvoiceLines";
		public const string Propertyreceipts = "receipts";
		public const string PropertyfinancialAccounts = "financialAccounts";
		public const string Propertynotes = "notes";

		#endregion

		#region Fields

		private salesOrderDeliveryFeedEntry _salesOrderDelivery;
		private Nullable<System.Boolean> _active;
		private System.String _reference;
		private System.String _reference2;
		private Nullable<System.Decimal> _number;
		private System.String _status;
		private System.String _type;
		private commodityFeedEntry _commodity;
		private System.String _text;
		private locationFeedEntry _fulfillmentLocation;
		private locationFeedEntry _fulfillmentSubLocation;
		private Nullable<System.DateTime> _requestedDeliveryDate;
		private Nullable<System.DateTime> _actualDeliveryDate;
		private Nullable<System.DateTime> _actualDeliveryTime;
		private System.String _dateExceptionReason;
		private unitOfMeasureFeedEntry _unitOfMeasure;
		private Nullable<System.Decimal> _requestedQuantity;
		private Nullable<System.Decimal> _deliveredQuantity;
		private Nullable<System.Decimal> _initialPrice;
		private priceListFeedEntry _pricelist;
		private System.String _deliveryLineDiscountType;
		private Nullable<System.Decimal> _deliveryLineDiscountAmount;
		private Nullable<System.Decimal> _deliveryLineDiscountPercent;
		private System.String _deliveryLineSubtotalDiscountType;
		private Nullable<System.Decimal> _deliveryLineSubtotalDiscountAmount;
		private Nullable<System.Decimal> _deliveryLineSubtotalDiscountPercent;
		private Nullable<System.Decimal> _actualPrice;
		private Nullable<System.Decimal> _netTotal;
		private Nullable<System.Decimal> _chargesTotal;
		private Nullable<System.Decimal> _discountTotal;
		private taxCodeFeed _taxCodes;
		private Nullable<System.Decimal> _priceTax;
		private Nullable<System.Decimal> _taxTotal;
		private Nullable<System.Decimal> _grossTotal;
		private Nullable<System.Decimal> _costTotal;
		private Nullable<System.Decimal> _profitTotal;
		private salesInvoiceLineFeed _salesInvoiceLines;
		private receiptFeed _receipts;
		private financialAccountFeed _financialAccounts;
		private noteFeed _notes;

		#endregion

		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="salesOrderDeliveryLineFeedEntrySchema"/> class.
		/// </summary>
		#endregion
		public salesOrderDeliveryLineFeedEntrySchema()
		{
		}

		#region Properties


		[SMEResource(CanGet=true, PluralName="salesOrderDeliveries", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Parent, Name="salesOrderDelivery", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("salesOrderDelivery")]			
		public virtual salesOrderDeliveryFeedEntry salesOrderDelivery { get { return _salesOrderDelivery; } set { SetProperty(PropertysalesOrderDelivery, ref _salesOrderDelivery, value); } }

		[SMEBoolProperty(Label="SalesOrderDeliveryLine Active Flag", Nillable=true, Name="active", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.Boolean> active { get { return _active; } set { SetProperty(Propertyactive, ref _active, value); } }

		[SMEStringProperty(Label="SalesOrderDeliveryLine reference", Name="reference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true, IsUniqueKey=true)]			
		public virtual System.String reference { get { return _reference; } set { SetProperty(Propertyreference, ref _reference, value); } }

		[SMEStringProperty(Label="SalesOrderDeliveryLine Reference2", Name="reference2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String reference2 { get { return _reference2; } set { SetProperty(Propertyreference2, ref _reference2, value); } }

		[SMEDecimalProperty(DecimalPlaces=0, Label="SalesOrderDeliveryLine Number", Nillable=true, AverageLength=12, Name="number", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> number { get { return _number; } set { SetProperty(Propertynumber, ref _number, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="SalesOrderDeliveryLine Status", Name="status", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String status { get { return _status; } set { SetProperty(Propertystatus, ref _status, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="SalesOrderDeliveryLine Type", Name="type", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsMandatory=true, Unsupported=true)]			
		public virtual System.String type { get { return _type; } set { SetProperty(Propertytype, ref _type, value); } }

		[SMEResource(CanGet=true, PluralName="commodities", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="commodity", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("commodity")]			
		public virtual commodityFeedEntry commodity { get { return _commodity; } set { SetProperty(Propertycommodity, ref _commodity, value); } }

		[SMEStringProperty(Label="SalesOrderDeliveryLine Text", Name="text", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String text { get { return _text; } set { SetProperty(Propertytext, ref _text, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="locations", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="fulfillmentLocation", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("fulfillmentLocation")]			
		public virtual locationFeedEntry fulfillmentLocation { get { return _fulfillmentLocation; } set { SetProperty(PropertyfulfillmentLocation, ref _fulfillmentLocation, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="locations", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="fulfillmentSubLocation", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("fulfillmentSubLocation")]			
		public virtual locationFeedEntry fulfillmentSubLocation { get { return _fulfillmentSubLocation; } set { SetProperty(PropertyfulfillmentSubLocation, ref _fulfillmentSubLocation, value); } }

		[SMEDateProperty(Label="Sales OrderDeliveryLine Requested Delivery Date", Nillable=true, Name="requestedDeliveryDate", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.DateTime> requestedDeliveryDate { get { return _requestedDeliveryDate; } set { SetProperty(PropertyrequestedDeliveryDate, ref _requestedDeliveryDate, value); } }

		[SMEDateProperty(Label="SalesOrderDeliveryLine Actual Delivery Date", Nillable=true, Name="actualDeliveryDate", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.DateTime> actualDeliveryDate { get { return _actualDeliveryDate; } set { SetProperty(PropertyactualDeliveryDate, ref _actualDeliveryDate, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMETimeProperty(Label="SalesOrderDeliveryLine Actual Delivery Time", Nillable=true, Name="actualDeliveryTime", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.DateTime> actualDeliveryTime { get { return _actualDeliveryTime; } set { SetProperty(PropertyactualDeliveryTime, ref _actualDeliveryTime, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="SalesOrderDeliveryLine Date Exception Reason", Name="dateExceptionReason", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String dateExceptionReason { get { return _dateExceptionReason; } set { SetProperty(PropertydateExceptionReason, ref _dateExceptionReason, value); } }

		[SMEResource(CanGet=true, PluralName="unitsOfMeasure", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="unitOfMeasure", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("unitOfMeasure")]			
		public virtual unitOfMeasureFeedEntry unitOfMeasure { get { return _unitOfMeasure; } set { SetProperty(PropertyunitOfMeasure, ref _unitOfMeasure, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesOrderDeliveryLine Requested Quantity", Nillable=true, AverageLength=14, Name="requestedQuantity", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> requestedQuantity { get { return _requestedQuantity; } set { SetProperty(PropertyrequestedQuantity, ref _requestedQuantity, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesOrderDeliveryLine Delivered Quantity", Nillable=true, AverageLength=14, Name="deliveredQuantity", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> deliveredQuantity { get { return _deliveredQuantity; } set { SetProperty(PropertydeliveredQuantity, ref _deliveredQuantity, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesOrderDeliveryLine Initial Price", Nillable=true, AverageLength=14, Name="initialPrice", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> initialPrice { get { return _initialPrice; } set { SetProperty(PropertyinitialPrice, ref _initialPrice, value); } }

		[SMEResource(CanGet=true, PluralName="priceLists", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="pricelist", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("pricelist")]			
		public virtual priceListFeedEntry pricelist { get { return _pricelist; } set { SetProperty(Propertypricelist, ref _pricelist, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="SalesOrderDeliveryLine Delivery Line Discount Type", Name="deliveryLineDiscountType", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String deliveryLineDiscountType { get { return _deliveryLineDiscountType; } set { SetProperty(PropertydeliveryLineDiscountType, ref _deliveryLineDiscountType, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesOrderDeliveryLine Delivery Line Discount Amount", Nillable=true, AverageLength=14, Name="deliveryLineDiscountAmount", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> deliveryLineDiscountAmount { get { return _deliveryLineDiscountAmount; } set { SetProperty(PropertydeliveryLineDiscountAmount, ref _deliveryLineDiscountAmount, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesOrderDeliveryLine Delivery Line Discount Percent", Nillable=true, AverageLength=14, Name="deliveryLineDiscountPercent", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> deliveryLineDiscountPercent { get { return _deliveryLineDiscountPercent; } set { SetProperty(PropertydeliveryLineDiscountPercent, ref _deliveryLineDiscountPercent, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="SalesOrderDeliveryLine Delivery Line Subtotal Discount Type", Name="deliveryLineSubtotalDiscountType", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String deliveryLineSubtotalDiscountType { get { return _deliveryLineSubtotalDiscountType; } set { SetProperty(PropertydeliveryLineSubtotalDiscountType, ref _deliveryLineSubtotalDiscountType, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesOrderDeliveryLine Delivery Line Subtotal Discount Amount", Nillable=true, AverageLength=14, Name="deliveryLineSubtotalDiscountAmount", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> deliveryLineSubtotalDiscountAmount { get { return _deliveryLineSubtotalDiscountAmount; } set { SetProperty(PropertydeliveryLineSubtotalDiscountAmount, ref _deliveryLineSubtotalDiscountAmount, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesOrderDeliveryLine Delivery Line Subtotal Discount Percent", Nillable=true, AverageLength=14, Name="deliveryLineSubtotalDiscountPercent", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> deliveryLineSubtotalDiscountPercent { get { return _deliveryLineSubtotalDiscountPercent; } set { SetProperty(PropertydeliveryLineSubtotalDiscountPercent, ref _deliveryLineSubtotalDiscountPercent, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesOrderDeliveryLine Actual Price", Nillable=true, AverageLength=14, Name="actualPrice", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> actualPrice { get { return _actualPrice; } set { SetProperty(PropertyactualPrice, ref _actualPrice, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesOrderDeliveryLine Net Total", Nillable=true, AverageLength=14, Name="netTotal", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> netTotal { get { return _netTotal; } set { SetProperty(PropertynetTotal, ref _netTotal, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesOrderDeliveryLine Charges Total", Nillable=true, AverageLength=14, Name="chargesTotal", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> chargesTotal { get { return _chargesTotal; } set { SetProperty(PropertychargesTotal, ref _chargesTotal, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesOrderDeliveryLine Discount Total", Nillable=true, AverageLength=14, Name="discountTotal", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> discountTotal { get { return _discountTotal; } set { SetProperty(PropertydiscountTotal, ref _discountTotal, value); } }

		[SMEResource(CanGet=true, PluralName="taxCodes", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="taxCodes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual taxCodeFeed taxCodes { get { return _taxCodes; } set { SetProperty(PropertytaxCodes, ref _taxCodes, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesOrderDeliveryLine Price Tax", Nillable=true, AverageLength=14, Name="priceTax", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> priceTax { get { return _priceTax; } set { SetProperty(PropertypriceTax, ref _priceTax, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesOrderDeliveryLine Tax Total", Nillable=true, AverageLength=14, Name="taxTotal", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> taxTotal { get { return _taxTotal; } set { SetProperty(PropertytaxTotal, ref _taxTotal, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesOrderDeliveryLine Gross Total", Nillable=true, AverageLength=14, Name="grossTotal", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> grossTotal { get { return _grossTotal; } set { SetProperty(PropertygrossTotal, ref _grossTotal, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesOrderDeliveryLine Cost Total", Nillable=true, AverageLength=14, Name="costTotal", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> costTotal { get { return _costTotal; } set { SetProperty(PropertycostTotal, ref _costTotal, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesOrderDeliveryLine Profit Total", Nillable=true, AverageLength=14, Name="profitTotal", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> profitTotal { get { return _profitTotal; } set { SetProperty(PropertyprofitTotal, ref _profitTotal, value); } }

		[SMEResource(CanGet=true, CanDelete=true, PluralName="salesInvoiceLines", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="salesInvoiceLines", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesInvoiceLineFeed salesInvoiceLines { get { return _salesInvoiceLines; } set { SetProperty(PropertysalesInvoiceLines, ref _salesInvoiceLines, value); } }

		[SMEResource(CanGet=true, PluralName="receipts", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="receipts", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual receiptFeed receipts { get { return _receipts; } set { SetProperty(Propertyreceipts, ref _receipts, value); } }

		[SMEResource(CanGet=true, PluralName="financialAccounts", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="financialAccounts", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual financialAccountFeed financialAccounts { get { return _financialAccounts; } set { SetProperty(PropertyfinancialAccounts, ref _financialAccounts, value); } }

		[SMEResource(CanGet=true, CanPut=true, PluralName="notes", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="notes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual noteFeed notes { get { return _notes; } set { SetProperty(Propertynotes, ref _notes, value); } }

		#endregion


	}
}