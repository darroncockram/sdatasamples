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
	/// Defines a salesQuotationLine feed entry
	/// </summary>
	#endregion
	[System.ComponentModel.Browsable(false)]
	[XmlType("salesQuotationLine", Namespace="http://schemas.sage.com/crmErp/2008")]
	public class salesQuotationLineFeedEntrySchema : Sage.Common.Syndication.FeedEntry
	{
		#region Constants

		public const string PropertysalesQuotation = "salesQuotation";
		public const string Propertyactive = "active";
		public const string Propertyreference = "reference";
		public const string Propertyreference2 = "reference2";
		public const string Propertynumber = "number";
		public const string Propertystatus = "status";
		public const string Propertytype = "type";
		public const string PropertydeliveryTerms = "deliveryTerms";
		public const string Propertycommodity = "commodity";
		public const string Propertytext = "text";
		public const string PropertyassociatedCommodity = "associatedCommodity";
		public const string PropertyfulfillmentLocation = "fulfillmentLocation";
		public const string PropertydeliveryDate = "deliveryDate";
		public const string PropertydueDate = "dueDate";
		public const string PropertyunitOfMeasure = "unitOfMeasure";
		public const string Propertyquantity = "quantity";
		public const string PropertyinitialPrice = "initialPrice";
		public const string Propertypricelist = "pricelist";
		public const string PropertypostalAddresses = "postalAddresses";
		public const string PropertyorderLineDiscountType = "orderLineDiscountType";
		public const string PropertyorderLineDiscountAmount = "orderLineDiscountAmount";
		public const string PropertyorderLineDiscountPercent = "orderLineDiscountPercent";
		public const string PropertyorderLineSubtotalDiscountType = "orderLineSubtotalDiscountType";
		public const string PropertyorderLineSubtotalDiscountAmount = "orderLineSubtotalDiscountAmount";
		public const string PropertyorderLineSubtotalDiscountPercent = "orderLineSubtotalDiscountPercent";
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
		public const string PropertybuyerContact = "buyerContact";
		public const string Propertyproject = "project";
		public const string PropertyBOMLine = "BOMLine";
		public const string PropertyfinancialAccounts = "financialAccounts";
		public const string Propertynotes = "notes";
		public const string Propertylabel = "label";

		#endregion

		#region Fields

		private salesQuotationFeedEntry _salesQuotation;
		private Nullable<System.Boolean> _active;
		private System.String _reference;
		private System.String _reference2;
		private Nullable<System.Decimal> _number;
		private System.String _status;
		private System.String _type;
		private System.String _deliveryTerms;
		private commodityFeedEntry _commodity;
		private System.String _text;
		private commodityFeedEntry _associatedCommodity;
		private locationFeedEntry _fulfillmentLocation;
		private Nullable<System.DateTime> _deliveryDate;
		private Nullable<System.DateTime> _dueDate;
		private unitOfMeasureFeedEntry _unitOfMeasure;
		private Nullable<System.Decimal> _quantity;
		private Nullable<System.Decimal> _initialPrice;
		private priceListFeedEntry _pricelist;
		private postalAddressFeed _postalAddresses;
		private System.String _orderLineDiscountType;
		private Nullable<System.Decimal> _orderLineDiscountAmount;
		private Nullable<System.Decimal> _orderLineDiscountPercent;
		private System.String _orderLineSubtotalDiscountType;
		private Nullable<System.Decimal> _orderLineSubtotalDiscountAmount;
		private Nullable<System.Decimal> _orderLineSubtotalDiscountPercent;
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
		private contactFeedEntry _buyerContact;
		private projectFeedEntry _project;
		private System.String _BOMLine;
		private financialAccountFeed _financialAccounts;
		private noteFeed _notes;
		private System.String _label;

		#endregion

		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="salesQuotationLineFeedEntrySchema"/> class.
		/// </summary>
		#endregion
		public salesQuotationLineFeedEntrySchema()
		{
		}

		#region Properties


		[SMEResource(CanGet=true, CanPost=true, PluralName="salesQuotations", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Parent, Name="salesQuotation", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("salesQuotation")]			
		public virtual salesQuotationFeedEntry salesQuotation { get { return _salesQuotation; } set { SetProperty(PropertysalesQuotation, ref _salesQuotation, value); } }

		[SMEBoolProperty(Label="SalesQuotationLine Active Flag", Nillable=true, Name="active", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.Boolean> active { get { return _active; } set { SetProperty(Propertyactive, ref _active, value); } }

		[SMEStringProperty(Label="SalesQuotationLine reference", Name="reference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true, IsUniqueKey=true)]			
		public virtual System.String reference { get { return _reference; } set { SetProperty(Propertyreference, ref _reference, value); } }

		[SMEStringProperty(Label="SalesQuotationLine Reference2", Name="reference2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String reference2 { get { return _reference2; } set { SetProperty(Propertyreference2, ref _reference2, value); } }

		[SMEDecimalProperty(DecimalPlaces=0, Label="SalesQuotationLine Number", Nillable=true, AverageLength=12, Name="number", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> number { get { return _number; } set { SetProperty(Propertynumber, ref _number, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="SalesQuotationLine Status", Name="status", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String status { get { return _status; } set { SetProperty(Propertystatus, ref _status, value); } }

		[SMEStringProperty(Label="SalesQuotationLine Type", Name="type", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true, IsMandatory=true)]			
		public virtual System.String type { get { return _type; } set { SetProperty(Propertytype, ref _type, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="SalesQuotationLine Delivery Terms", Name="deliveryTerms", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String deliveryTerms { get { return _deliveryTerms; } set { SetProperty(PropertydeliveryTerms, ref _deliveryTerms, value); } }

		[SMEResource(CanGet=true, PluralName="commodities", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="commodity", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("commodity")]			
		public virtual commodityFeedEntry commodity { get { return _commodity; } set { SetProperty(Propertycommodity, ref _commodity, value); } }

		[SMEStringProperty(Label="SalesQuotationLine Text", Name="text", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String text { get { return _text; } set { SetProperty(Propertytext, ref _text, value); } }

		[SMEResource(CanGet=true, PluralName="commodities", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="associatedCommodity", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("associatedCommodity")]			
		public virtual commodityFeedEntry associatedCommodity { get { return _associatedCommodity; } set { SetProperty(PropertyassociatedCommodity, ref _associatedCommodity, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="locations", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="fulfillmentLocation", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("fulfillmentLocation")]			
		public virtual locationFeedEntry fulfillmentLocation { get { return _fulfillmentLocation; } set { SetProperty(PropertyfulfillmentLocation, ref _fulfillmentLocation, value); } }

		[SMEDateProperty(Label="SalesQuotationLine Delivery Date", Nillable=true, Name="deliveryDate", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.DateTime> deliveryDate { get { return _deliveryDate; } set { SetProperty(PropertydeliveryDate, ref _deliveryDate, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDateProperty(Label="SalesQuotationLine Due Date", Nillable=true, Name="dueDate", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.DateTime> dueDate { get { return _dueDate; } set { SetProperty(PropertydueDate, ref _dueDate, value); } }

		[SMEResource(CanGet=true, PluralName="unitsOfMeasure", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="unitOfMeasure", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("unitOfMeasure")]			
		public virtual unitOfMeasureFeedEntry unitOfMeasure { get { return _unitOfMeasure; } set { SetProperty(PropertyunitOfMeasure, ref _unitOfMeasure, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesQuotationLine Quantity", Nillable=true, AverageLength=14, Name="quantity", Namespace="http://schemas.sage.com/crmErp/2008", IsMandatory=true)]			
		public virtual Nullable<System.Decimal> quantity { get { return _quantity; } set { SetProperty(Propertyquantity, ref _quantity, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesQuotationLine Initial Price", Nillable=true, AverageLength=14, Name="initialPrice", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> initialPrice { get { return _initialPrice; } set { SetProperty(PropertyinitialPrice, ref _initialPrice, value); } }

		[SMEResource(CanGet=true, PluralName="priceLists", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="pricelist", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("pricelist")]			
		public virtual priceListFeedEntry pricelist { get { return _pricelist; } set { SetProperty(Propertypricelist, ref _pricelist, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="postalAddresses", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="postalAddresses", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual postalAddressFeed postalAddresses { get { return _postalAddresses; } set { SetProperty(PropertypostalAddresses, ref _postalAddresses, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="SalesQuotationLine Order Line Discount Type", Name="orderLineDiscountType", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String orderLineDiscountType { get { return _orderLineDiscountType; } set { SetProperty(PropertyorderLineDiscountType, ref _orderLineDiscountType, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesQuotationLine Order Line Discount Amount", Nillable=true, AverageLength=14, Name="orderLineDiscountAmount", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> orderLineDiscountAmount { get { return _orderLineDiscountAmount; } set { SetProperty(PropertyorderLineDiscountAmount, ref _orderLineDiscountAmount, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesQuotationLine Order Line Discount Percent", Nillable=true, AverageLength=14, Name="orderLineDiscountPercent", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> orderLineDiscountPercent { get { return _orderLineDiscountPercent; } set { SetProperty(PropertyorderLineDiscountPercent, ref _orderLineDiscountPercent, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="SalesQuotationLine Order Line Subtotal Discount Type", Name="orderLineSubtotalDiscountType", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String orderLineSubtotalDiscountType { get { return _orderLineSubtotalDiscountType; } set { SetProperty(PropertyorderLineSubtotalDiscountType, ref _orderLineSubtotalDiscountType, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesQuotationLine Order Line Subtotal Discount Amount", Nillable=true, AverageLength=14, Name="orderLineSubtotalDiscountAmount", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> orderLineSubtotalDiscountAmount { get { return _orderLineSubtotalDiscountAmount; } set { SetProperty(PropertyorderLineSubtotalDiscountAmount, ref _orderLineSubtotalDiscountAmount, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesQuotationLine Order Line Subtotal Discount Percent", Nillable=true, AverageLength=14, Name="orderLineSubtotalDiscountPercent", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> orderLineSubtotalDiscountPercent { get { return _orderLineSubtotalDiscountPercent; } set { SetProperty(PropertyorderLineSubtotalDiscountPercent, ref _orderLineSubtotalDiscountPercent, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesQuotationLine Actual Price", Nillable=true, AverageLength=14, Name="actualPrice", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> actualPrice { get { return _actualPrice; } set { SetProperty(PropertyactualPrice, ref _actualPrice, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesQuotationLine Net Total", Nillable=true, AverageLength=14, Name="netTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> netTotal { get { return _netTotal; } set { SetProperty(PropertynetTotal, ref _netTotal, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesQuotationLine Charges Total", Nillable=true, AverageLength=14, Name="chargesTotal", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> chargesTotal { get { return _chargesTotal; } set { SetProperty(PropertychargesTotal, ref _chargesTotal, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesQuotationLine Discount Total", Nillable=true, AverageLength=14, Name="discountTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> discountTotal { get { return _discountTotal; } set { SetProperty(PropertydiscountTotal, ref _discountTotal, value); } }

		[SMEResource(CanGet=true, PluralName="taxCodes", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="taxCodes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual taxCodeFeed taxCodes { get { return _taxCodes; } set { SetProperty(PropertytaxCodes, ref _taxCodes, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesQuotationLine Price Tax", Nillable=true, AverageLength=14, Name="priceTax", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> priceTax { get { return _priceTax; } set { SetProperty(PropertypriceTax, ref _priceTax, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesQuotationLine Tax Total", Nillable=true, AverageLength=14, Name="taxTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> taxTotal { get { return _taxTotal; } set { SetProperty(PropertytaxTotal, ref _taxTotal, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesQuotationLine Gross Total", Nillable=true, AverageLength=14, Name="grossTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> grossTotal { get { return _grossTotal; } set { SetProperty(PropertygrossTotal, ref _grossTotal, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesQuotationLine Cost Total", Nillable=true, AverageLength=14, Name="costTotal", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> costTotal { get { return _costTotal; } set { SetProperty(PropertycostTotal, ref _costTotal, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesQuotationLine Profit Total", Nillable=true, AverageLength=14, Name="profitTotal", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> profitTotal { get { return _profitTotal; } set { SetProperty(PropertyprofitTotal, ref _profitTotal, value); } }

		[SMEResource(CanGet=true, PluralName="contacts", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="buyerContact", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("buyerContact")]			
		public virtual contactFeedEntry buyerContact { get { return _buyerContact; } set { SetProperty(PropertybuyerContact, ref _buyerContact, value); } }

		[SMEResource(CanGet=true, PluralName="projects", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="project", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("project")]			
		public virtual projectFeedEntry project { get { return _project; } set { SetProperty(Propertyproject, ref _project, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="SalesQuotationLine BOM Line", Name="BOMLine", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String BOMLine { get { return _BOMLine; } set { SetProperty(PropertyBOMLine, ref _BOMLine, value); } }

		[SMEResource(CanGet=true, PluralName="financialAccounts", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="financialAccounts", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual financialAccountFeed financialAccounts { get { return _financialAccounts; } set { SetProperty(PropertyfinancialAccounts, ref _financialAccounts, value); } }

		[SMEResource(CanGet=true, CanPut=true, PluralName="notes", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="notes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual noteFeed notes { get { return _notes; } set { SetProperty(Propertynotes, ref _notes, value); } }

		[SMEStringProperty(Label="SalesQuotationLine Label", Name="label", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String label { get { return _label; } set { SetProperty(Propertylabel, ref _label, value); } }

		#endregion


	}
}