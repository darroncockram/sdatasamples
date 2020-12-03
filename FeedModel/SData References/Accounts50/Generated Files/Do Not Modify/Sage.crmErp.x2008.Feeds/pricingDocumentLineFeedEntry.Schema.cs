using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using Sage.Common.Metadata;
using Sage.Common.Syndication;

namespace Sage.crmErp.x2008.Feeds
{
	#region Documentation
	/// <summary>
	/// Defines a pricingDocumentLine feed entry
	/// </summary>
	#endregion
	[System.ComponentModel.Browsable(false)]
	[XmlType("pricingDocumentLine", Namespace="http://schemas.sage.com/crmErp/2008")]
	public class pricingDocumentLineFeedEntrySchema : Sage.Common.Syndication.FeedEntry
	{
		#region Constants

		public const string Propertyuuid = "uuid";
		public const string Propertycommodity = "commodity";
		public const string PropertycommodityVariant = "commodityVariant";
		public const string PropertycommodityDimension = "commodityDimension";
		public const string Propertyquantity = "quantity";
		public const string PropertyunitOfMeasure = "unitOfMeasure";
		public const string PropertypricingDocumentLineType = "pricingDocumentLineType";
		public const string PropertyfulfillmentLocation = "fulfillmentLocation";
		public const string Propertydescription = "description";
		public const string PropertyenteredPrice = "enteredPrice";
		public const string PropertyinitialPrice = "initialPrice";
		public const string PropertyactualPrice = "actualPrice";
		public const string PropertydiscountType = "discountType";
		public const string PropertydiscountAmount = "discountAmount";
		public const string PropertydiscountPercent = "discountPercent";
		public const string PropertysubtotalDiscountType = "subtotalDiscountType";
		public const string PropertysubtotalDiscountAmount = "subtotalDiscountAmount";
		public const string PropertysubtotalDiscountPercent = "subtotalDiscountPercent";
		public const string PropertynetTotal = "netTotal";
		public const string PropertychargesTotal = "chargesTotal";
		public const string PropertydiscountTotal = "discountTotal";
		public const string PropertytaxCode = "taxCode";
		public const string PropertypriceTax = "priceTax";
		public const string PropertytaxTotal = "taxTotal";
		public const string PropertygrossTotal = "grossTotal";
		public const string PropertycostTotal = "costTotal";
		public const string PropertyprofitTotal = "profitTotal";
		public const string Propertyreference = "reference";
		public const string PropertypriceChangeStatus = "priceChangeStatus";
		public const string PropertyshortText = "shortText";
		public const string PropertylongText = "longText";

		#endregion

		#region Fields

		private string _uuid;
		private commodityFeedEntry _commodity;
		private System.String _commodityVariant;
		private System.String _commodityDimension;
		private Nullable<System.Decimal> _quantity;
		private unitOfMeasureFeedEntry _unitOfMeasure;
		private System.String _pricingDocumentLineType;
		private System.String _fulfillmentLocation;
		private System.String _description;
		private Nullable<System.Decimal> _enteredPrice;
		private Nullable<System.Decimal> _initialPrice;
		private Nullable<System.Decimal> _actualPrice;
		private System.String _discountType;
		private Nullable<System.Decimal> _discountAmount;
		private Nullable<System.Decimal> _discountPercent;
		private System.String _subtotalDiscountType;
		private Nullable<System.Decimal> _subtotalDiscountAmount;
		private Nullable<System.Decimal> _subtotalDiscountPercent;
		private Nullable<System.Decimal> _netTotal;
		private Nullable<System.Decimal> _chargesTotal;
		private Nullable<System.Decimal> _discountTotal;
		private taxCodeFeedEntry _taxCode;
		private Nullable<System.Decimal> _priceTax;
		private Nullable<System.Decimal> _taxTotal;
		private Nullable<System.Decimal> _grossTotal;
		private Nullable<System.Decimal> _costTotal;
		private Nullable<System.Decimal> _profitTotal;
		private System.String _reference;
		private System.String _priceChangeStatus;
		private System.String _shortText;
		private System.String _longText;

		#endregion

		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="pricingDocumentLineFeedEntrySchema"/> class.
		/// </summary>
		#endregion
		public pricingDocumentLineFeedEntrySchema()
		{
		}

		#region Properties


		[SMEEnumProperty(EnumTypeName="computePrice-uuid--type", Label="Pricing Document Line Global ID", Pattern="[0-9a-fA-F-]+", Name="uuid", Namespace="http://schemas.sage.com/crmErp/2008", IsUniqueKey=true)]			
		public virtual new string uuid { get { return _uuid; } set { SetProperty(Propertyuuid, ref _uuid, value); } }

		[SMEResource(CanGet=true, PluralName="commodities", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="commodity", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("commodity")]			
		public virtual commodityFeedEntry commodity { get { return _commodity; } set { SetProperty(Propertycommodity, ref _commodity, value); } }

		[SMEStringProperty(Label="Commodity Variant", Name="commodityVariant", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String commodityVariant { get { return _commodityVariant; } set { SetProperty(PropertycommodityVariant, ref _commodityVariant, value); } }

		[SMEStringProperty(Label="Commodity Dimension", Name="commodityDimension", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String commodityDimension { get { return _commodityDimension; } set { SetProperty(PropertycommodityDimension, ref _commodityDimension, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="Quantity", Nillable=true, AverageLength=14, Name="quantity", Namespace="http://schemas.sage.com/crmErp/2008", IsMandatory=true)]			
		public virtual Nullable<System.Decimal> quantity { get { return _quantity; } set { SetProperty(Propertyquantity, ref _quantity, value); } }

		[SMEResource(CanGet=true, PluralName="unitsOfMeasure", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="unitOfMeasure", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("unitOfMeasure")]			
		public virtual unitOfMeasureFeedEntry unitOfMeasure { get { return _unitOfMeasure; } set { SetProperty(PropertyunitOfMeasure, ref _unitOfMeasure, value); } }

		[SMEStringProperty(Label="Pricing document line type", Name="pricingDocumentLineType", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String pricingDocumentLineType { get { return _pricingDocumentLineType; } set { SetProperty(PropertypricingDocumentLineType, ref _pricingDocumentLineType, value); } }

		[SMEStringProperty(Label="Fulfillment Location", Name="fulfillmentLocation", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String fulfillmentLocation { get { return _fulfillmentLocation; } set { SetProperty(PropertyfulfillmentLocation, ref _fulfillmentLocation, value); } }

		[SMEStringProperty(Label="Description", Name="description", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String description { get { return _description; } set { SetProperty(Propertydescription, ref _description, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="Entered price", Nillable=true, AverageLength=14, Name="enteredPrice", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> enteredPrice { get { return _enteredPrice; } set { SetProperty(PropertyenteredPrice, ref _enteredPrice, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="Initial price", Nillable=true, AverageLength=14, Name="initialPrice", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> initialPrice { get { return _initialPrice; } set { SetProperty(PropertyinitialPrice, ref _initialPrice, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="Actual price", Nillable=true, AverageLength=14, Name="actualPrice", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> actualPrice { get { return _actualPrice; } set { SetProperty(PropertyactualPrice, ref _actualPrice, value); } }

		[SMEStringProperty(Label="Discount Type", Name="discountType", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String discountType { get { return _discountType; } set { SetProperty(PropertydiscountType, ref _discountType, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="Discount Amount", Nillable=true, AverageLength=14, Name="discountAmount", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> discountAmount { get { return _discountAmount; } set { SetProperty(PropertydiscountAmount, ref _discountAmount, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="Discount Percent", Nillable=true, AverageLength=14, Name="discountPercent", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> discountPercent { get { return _discountPercent; } set { SetProperty(PropertydiscountPercent, ref _discountPercent, value); } }

		[SMEStringProperty(Label="Subtotal Discount Type", Name="subtotalDiscountType", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String subtotalDiscountType { get { return _subtotalDiscountType; } set { SetProperty(PropertysubtotalDiscountType, ref _subtotalDiscountType, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="Subtotal Discount Amount", Nillable=true, AverageLength=14, Name="subtotalDiscountAmount", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> subtotalDiscountAmount { get { return _subtotalDiscountAmount; } set { SetProperty(PropertysubtotalDiscountAmount, ref _subtotalDiscountAmount, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="Subtotal Discount Percent", Nillable=true, AverageLength=14, Name="subtotalDiscountPercent", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> subtotalDiscountPercent { get { return _subtotalDiscountPercent; } set { SetProperty(PropertysubtotalDiscountPercent, ref _subtotalDiscountPercent, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="Net Total", Nillable=true, AverageLength=14, Name="netTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> netTotal { get { return _netTotal; } set { SetProperty(PropertynetTotal, ref _netTotal, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="Charges Total", Nillable=true, AverageLength=14, Name="chargesTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> chargesTotal { get { return _chargesTotal; } set { SetProperty(PropertychargesTotal, ref _chargesTotal, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="Discount Total", Nillable=true, AverageLength=14, Name="discountTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> discountTotal { get { return _discountTotal; } set { SetProperty(PropertydiscountTotal, ref _discountTotal, value); } }

		[SMEResource(CanGet=true, PluralName="taxCodes", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="taxCode", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("taxCode")]			
		public virtual taxCodeFeedEntry taxCode { get { return _taxCode; } set { SetProperty(PropertytaxCode, ref _taxCode, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="Price Tax", Nillable=true, AverageLength=14, Name="priceTax", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> priceTax { get { return _priceTax; } set { SetProperty(PropertypriceTax, ref _priceTax, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="Tax Total", Nillable=true, AverageLength=14, Name="taxTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> taxTotal { get { return _taxTotal; } set { SetProperty(PropertytaxTotal, ref _taxTotal, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="Gross Total", Nillable=true, AverageLength=14, Name="grossTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> grossTotal { get { return _grossTotal; } set { SetProperty(PropertygrossTotal, ref _grossTotal, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="Cost Total", Nillable=true, AverageLength=14, Name="costTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> costTotal { get { return _costTotal; } set { SetProperty(PropertycostTotal, ref _costTotal, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="Profit Total", Nillable=true, AverageLength=14, Name="profitTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> profitTotal { get { return _profitTotal; } set { SetProperty(PropertyprofitTotal, ref _profitTotal, value); } }

		[SMEStringProperty(Label="Reference", Name="reference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String reference { get { return _reference; } set { SetProperty(Propertyreference, ref _reference, value); } }

		[SMEStringProperty(Label="Price Change Status", Name="priceChangeStatus", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String priceChangeStatus { get { return _priceChangeStatus; } set { SetProperty(PropertypriceChangeStatus, ref _priceChangeStatus, value); } }

		[SMEStringProperty(Label="Short Text", Name="shortText", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String shortText { get { return _shortText; } set { SetProperty(PropertyshortText, ref _shortText, value); } }

		[SMEStringProperty(Label="Long Text", Name="longText", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String longText { get { return _longText; } set { SetProperty(PropertylongText, ref _longText, value); } }

		#endregion


	}
}