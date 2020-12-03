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
	/// Defines a commodityIdentifier feed entry
	/// </summary>
	#endregion
	[System.ComponentModel.Browsable(false)]
	[XmlType("commodityIdentifier", Namespace="http://schemas.sage.com/crmErp/2008")]
	public class commodityIdentifierFeedEntrySchema : Sage.Common.Syndication.FeedEntry
	{
		#region Constants

		public const string Propertyactive = "active";
		public const string Propertyreference = "reference";
		public const string Propertyreference2 = "reference2";
		public const string PropertyisUniqueFlag = "isUniqueFlag";
		public const string Propertystatus = "status";
		public const string Propertytype = "type";
		public const string PropertyinStockFlag = "inStockFlag";
		public const string Propertyname = "name";
		public const string Propertydescription = "description";
		public const string Propertycommodity = "commodity";
		public const string Propertyidentifier = "identifier";
		public const string Propertybarcode = "barcode";
		public const string PropertycreationDate = "creationDate";
		public const string PropertyuseByDate = "useByDate";
		public const string PropertyexpirationDate = "expirationDate";
		public const string PropertyparentCommodityIdentifier = "parentCommodityIdentifier";
		public const string PropertychildCommodityIdentifiers = "childCommodityIdentifiers";
		public const string PropertybuyingAllowed = "buyingAllowed";
		public const string PropertysupplierTradingAccount = "supplierTradingAccount";
		public const string PropertyoriginatorPurchaseDocumentLine = "originatorPurchaseDocumentLine";
		public const string PropertypurchaseDeliveryLine = "purchaseDeliveryLine";
		public const string PropertypurchaseQuantity = "purchaseQuantity";
		public const string PropertylastPurchaseDate = "lastPurchaseDate";
		public const string PropertysellingAllowed = "sellingAllowed";
		public const string PropertycustomerTradingAccount = "customerTradingAccount";
		public const string PropertyoriginatorSalesDocumentLine = "originatorSalesDocumentLine";
		public const string PropertysalesDeliveryLine = "salesDeliveryLine";
		public const string PropertysaleQuantity = "saleQuantity";
		public const string PropertylastSaleDate = "lastSaleDate";
		public const string PropertymovementAllowed = "movementAllowed";
		public const string PropertymovementQuantity = "movementQuantity";
		public const string PropertylastMovementDate = "lastMovementDate";
		public const string PropertyavailableQuantity = "availableQuantity";
		public const string PropertyreservedQuantity = "reservedQuantity";
		public const string PropertytotalQuantity = "totalQuantity";
		public const string Propertylocation = "location";
		public const string PropertysubLocation = "subLocation";
		public const string Propertynotes = "notes";

		#endregion

		#region Fields

		private Nullable<System.Boolean> _active;
		private System.String _reference;
		private System.String _reference2;
		private Nullable<System.Boolean> _isUniqueFlag;
		private System.String _status;
		private System.String _type;
		private Nullable<System.Boolean> _inStockFlag;
		private System.String _name;
		private System.String _description;
		private commodityFeedEntry _commodity;
		private System.String _identifier;
		private System.String _barcode;
		private Nullable<System.DateTime> _creationDate;
		private Nullable<System.DateTime> _useByDate;
		private Nullable<System.DateTime> _expirationDate;
		private commodityIdentifierFeedEntry _parentCommodityIdentifier;
		private commodityIdentifierFeed _childCommodityIdentifiers;
		private Nullable<System.Boolean> _buyingAllowed;
		private tradingAccountFeedEntry _supplierTradingAccount;
		private purchaseOrderLineFeedEntry _originatorPurchaseDocumentLine;
		private purchaseOrderDeliveryLineFeedEntry _purchaseDeliveryLine;
		private Nullable<System.Decimal> _purchaseQuantity;
		private Nullable<System.DateTime> _lastPurchaseDate;
		private Nullable<System.Boolean> _sellingAllowed;
		private tradingAccountFeedEntry _customerTradingAccount;
		private salesOrderLineFeed _originatorSalesDocumentLine;
		private salesOrderDeliveryLineFeed _salesDeliveryLine;
		private Nullable<System.Decimal> _saleQuantity;
		private Nullable<System.DateTime> _lastSaleDate;
		private Nullable<System.Boolean> _movementAllowed;
		private Nullable<System.Decimal> _movementQuantity;
		private Nullable<System.DateTime> _lastMovementDate;
		private Nullable<System.Decimal> _availableQuantity;
		private Nullable<System.Decimal> _reservedQuantity;
		private Nullable<System.Decimal> _totalQuantity;
		private locationFeedEntry _location;
		private locationFeedEntry _subLocation;
		private noteFeedEntry _notes;

		#endregion

		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="commodityIdentifierFeedEntrySchema"/> class.
		/// </summary>
		#endregion
		public commodityIdentifierFeedEntrySchema()
		{
		}

		#region Properties


		[SMEBoolProperty(Label="CommodityIdentifier Active Flag", Nillable=true, Name="active", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.Boolean> active { get { return _active; } set { SetProperty(Propertyactive, ref _active, value); } }

		[SMEStringProperty(Label="CommodityIdentifier reference", Name="reference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true, IsUniqueKey=true)]			
		public virtual System.String reference { get { return _reference; } set { SetProperty(Propertyreference, ref _reference, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="CommodityIdentifier Reference2", Name="reference2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String reference2 { get { return _reference2; } set { SetProperty(Propertyreference2, ref _reference2, value); } }

		[SMEBoolProperty(Label="CommodityIdentifier Unique Flag", Nillable=true, Name="isUniqueFlag", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Boolean> isUniqueFlag { get { return _isUniqueFlag; } set { SetProperty(PropertyisUniqueFlag, ref _isUniqueFlag, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="CommodityIdentifier Status", Name="status", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String status { get { return _status; } set { SetProperty(Propertystatus, ref _status, value); } }

		[SMEStringProperty(Label="CommodityIdentifier Type", Name="type", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String type { get { return _type; } set { SetProperty(Propertytype, ref _type, value); } }

		[SMEBoolProperty(Label="CommodityIdentifier In Stock Flag", Nillable=true, Name="inStockFlag", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Boolean> inStockFlag { get { return _inStockFlag; } set { SetProperty(PropertyinStockFlag, ref _inStockFlag, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="CommodityIdentifier Name", Name="name", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String name { get { return _name; } set { SetProperty(Propertyname, ref _name, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="CommodityIdentifier Description", Name="description", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true, Unsupported=true)]			
		public virtual System.String description { get { return _description; } set { SetProperty(Propertydescription, ref _description, value); } }

		[SMEResource(CanGet=true, PluralName="commodities", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Parent, Name="commodity", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("commodity")]			
		public virtual commodityFeedEntry commodity { get { return _commodity; } set { SetProperty(Propertycommodity, ref _commodity, value); } }

		[SMEStringProperty(Label="CommodityIdentifier Identifier", Name="identifier", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String identifier { get { return _identifier; } set { SetProperty(Propertyidentifier, ref _identifier, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="ComodityIdentifier Barcode", Name="barcode", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String barcode { get { return _barcode; } set { SetProperty(Propertybarcode, ref _barcode, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDateProperty(Label="CommodityIdentifier Creation Date", Nillable=true, Name="creationDate", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.DateTime> creationDate { get { return _creationDate; } set { SetProperty(PropertycreationDate, ref _creationDate, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDateProperty(Label="CommodityIdentifier Use By Date", Nillable=true, Name="useByDate", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.DateTime> useByDate { get { return _useByDate; } set { SetProperty(PropertyuseByDate, ref _useByDate, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDateProperty(Label="CommodityIdentifier Expiration Date", Nillable=true, Name="expirationDate", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.DateTime> expirationDate { get { return _expirationDate; } set { SetProperty(PropertyexpirationDate, ref _expirationDate, value); } }

		[SMEResource(CanGet=true, PluralName="commodityIdentifiers", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Parent, Name="parentCommodityIdentifier", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("parentCommodityIdentifier")]			
		public virtual commodityIdentifierFeedEntry parentCommodityIdentifier { get { return _parentCommodityIdentifier; } set { SetProperty(PropertyparentCommodityIdentifier, ref _parentCommodityIdentifier, value); } }

		[SMEResource(CanGet=true, PluralName="commodityIdentifiers", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Child, IsCollection=true, Name="childCommodityIdentifiers", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual commodityIdentifierFeed childCommodityIdentifiers { get { return _childCommodityIdentifiers; } set { SetProperty(PropertychildCommodityIdentifiers, ref _childCommodityIdentifiers, value); } }

		[SMEBoolProperty(Label="CommodityIdentifier Buying Allowed Flag", Nillable=true, Name="buyingAllowed", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Boolean> buyingAllowed { get { return _buyingAllowed; } set { SetProperty(PropertybuyingAllowed, ref _buyingAllowed, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="tradingAccounts", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="supplierTradingAccount", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("supplierTradingAccount")]			
		public virtual tradingAccountFeedEntry supplierTradingAccount { get { return _supplierTradingAccount; } set { SetProperty(PropertysupplierTradingAccount, ref _supplierTradingAccount, value); } }

		[SMEResource(CanGet=true, PluralName="purchaseOrderLines", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="originatorPurchaseDocumentLine", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("originatorPurchaseDocumentLine")]			
		public virtual purchaseOrderLineFeedEntry originatorPurchaseDocumentLine { get { return _originatorPurchaseDocumentLine; } set { SetProperty(PropertyoriginatorPurchaseDocumentLine, ref _originatorPurchaseDocumentLine, value); } }

		[SMEResource(CanGet=true, PluralName="purchaseOrderDeliveryLines", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="purchaseDeliveryLine", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("purchaseDeliveryLine")]			
		public virtual purchaseOrderDeliveryLineFeedEntry purchaseDeliveryLine { get { return _purchaseDeliveryLine; } set { SetProperty(PropertypurchaseDeliveryLine, ref _purchaseDeliveryLine, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="CommodityIdentifier Purchase Quantity", Nillable=true, AverageLength=14, Name="purchaseQuantity", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> purchaseQuantity { get { return _purchaseQuantity; } set { SetProperty(PropertypurchaseQuantity, ref _purchaseQuantity, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDateProperty(Label="CommodityIdentifier Last Purchase Date", Nillable=true, Name="lastPurchaseDate", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.DateTime> lastPurchaseDate { get { return _lastPurchaseDate; } set { SetProperty(PropertylastPurchaseDate, ref _lastPurchaseDate, value); } }

		[SMEBoolProperty(Label="CommodityIdentifier Selling Allowed Flag", Nillable=true, Name="sellingAllowed", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Boolean> sellingAllowed { get { return _sellingAllowed; } set { SetProperty(PropertysellingAllowed, ref _sellingAllowed, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="tradingAccounts", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="customerTradingAccount", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("customerTradingAccount")]			
		public virtual tradingAccountFeedEntry customerTradingAccount { get { return _customerTradingAccount; } set { SetProperty(PropertycustomerTradingAccount, ref _customerTradingAccount, value); } }

		[SMEResource(CanGet=true, CanPost=true, PluralName="salesOrderLines", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="originatorSalesDocumentLine", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesOrderLineFeed originatorSalesDocumentLine { get { return _originatorSalesDocumentLine; } set { SetProperty(PropertyoriginatorSalesDocumentLine, ref _originatorSalesDocumentLine, value); } }

		[SMEResource(CanGet=true, PluralName="salesOrderDeliveryLines", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="salesDeliveryLine", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesOrderDeliveryLineFeed salesDeliveryLine { get { return _salesDeliveryLine; } set { SetProperty(PropertysalesDeliveryLine, ref _salesDeliveryLine, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="CommodityIdentifier Sale Quantity", Nillable=true, AverageLength=14, Name="saleQuantity", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> saleQuantity { get { return _saleQuantity; } set { SetProperty(PropertysaleQuantity, ref _saleQuantity, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDateProperty(Label="CommodityIdentifier Last Sale Date", Nillable=true, Name="lastSaleDate", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.DateTime> lastSaleDate { get { return _lastSaleDate; } set { SetProperty(PropertylastSaleDate, ref _lastSaleDate, value); } }

		[SMEBoolProperty(Label="CommodityIdentifier Movements Allowed Flag", Nillable=true, Name="movementAllowed", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Boolean> movementAllowed { get { return _movementAllowed; } set { SetProperty(PropertymovementAllowed, ref _movementAllowed, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="CommodityIdentifier Movement Quantity", Nillable=true, AverageLength=14, Name="movementQuantity", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> movementQuantity { get { return _movementQuantity; } set { SetProperty(PropertymovementQuantity, ref _movementQuantity, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDateProperty(Label="CommodityIdentifier Last Movement Date", Nillable=true, Name="lastMovementDate", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.DateTime> lastMovementDate { get { return _lastMovementDate; } set { SetProperty(PropertylastMovementDate, ref _lastMovementDate, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="CommodityIdentifier Available Quantity", Nillable=true, AverageLength=14, Name="availableQuantity", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> availableQuantity { get { return _availableQuantity; } set { SetProperty(PropertyavailableQuantity, ref _availableQuantity, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="CommodityIdentifier Reserved Quantity", Nillable=true, AverageLength=14, Name="reservedQuantity", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> reservedQuantity { get { return _reservedQuantity; } set { SetProperty(PropertyreservedQuantity, ref _reservedQuantity, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="CommodityIdentifier Total Quantity", Nillable=true, AverageLength=14, Name="totalQuantity", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> totalQuantity { get { return _totalQuantity; } set { SetProperty(PropertytotalQuantity, ref _totalQuantity, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="locations", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="location", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("location")]			
		public virtual locationFeedEntry location { get { return _location; } set { SetProperty(Propertylocation, ref _location, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="locations", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="subLocation", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("subLocation")]			
		public virtual locationFeedEntry subLocation { get { return _subLocation; } set { SetProperty(PropertysubLocation, ref _subLocation, value); } }

		[SMEResource(CanGet=true, CanPut=true, PluralName="notes", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Child, Name="notes", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("notes")]			
		public virtual noteFeedEntry notes { get { return _notes; } set { SetProperty(Propertynotes, ref _notes, value); } }

		#endregion


	}
}