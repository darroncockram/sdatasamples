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
	/// Defines a purchaseOrderDeliveryLine feed entry
	/// </summary>
	#endregion
	[System.ComponentModel.Browsable(false)]
	[XmlType("purchaseOrderDeliveryLine", Namespace="http://schemas.sage.com/crmErp/2008")]
	public class purchaseOrderDeliveryLineFeedEntrySchema : Sage.Common.Syndication.FeedEntry
	{
		#region Constants

		public const string PropertypurchaseOrderDelivery = "purchaseOrderDelivery";
		public const string Propertyactive = "active";
		public const string Propertyreference = "reference";
		public const string Propertyreference2 = "reference2";
		public const string Propertynumber = "number";
		public const string Propertystatus = "status";
		public const string Propertycommodity = "commodity";
		public const string Propertytext = "text";
		public const string PropertyfulfillmentLocation = "fulfillmentLocation";
		public const string PropertyfulfillmentSubLocation = "fulfillmentSubLocation";
		public const string PropertyunitOfMeasure = "unitOfMeasure";
		public const string PropertyrequestedQuantity = "requestedQuantity";
		public const string PropertydeliveredQuantity = "deliveredQuantity";
		public const string Propertynotes = "notes";

		#endregion

		#region Fields

		private purchaseOrderDeliveryFeedEntry _purchaseOrderDelivery;
		private Nullable<System.Boolean> _active;
		private System.String _reference;
		private System.String _reference2;
		private Nullable<System.Decimal> _number;
		private System.String _status;
		private commodityFeedEntry _commodity;
		private System.String _text;
		private locationFeedEntry _fulfillmentLocation;
		private locationFeedEntry _fulfillmentSubLocation;
		private unitOfMeasureFeedEntry _unitOfMeasure;
		private Nullable<System.Decimal> _requestedQuantity;
		private Nullable<System.Decimal> _deliveredQuantity;
		private noteFeed _notes;

		#endregion

		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="purchaseOrderDeliveryLineFeedEntrySchema"/> class.
		/// </summary>
		#endregion
		public purchaseOrderDeliveryLineFeedEntrySchema()
		{
		}

		#region Properties


		[SMEResource(CanGet=true, PluralName="purchaseOrderDeliveries", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Parent, Name="purchaseOrderDelivery", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("purchaseOrderDelivery")]			
		public virtual purchaseOrderDeliveryFeedEntry purchaseOrderDelivery { get { return _purchaseOrderDelivery; } set { SetProperty(PropertypurchaseOrderDelivery, ref _purchaseOrderDelivery, value); } }

		[SMEBoolProperty(Label="PurchaseOrderDeliveryLine Active Flag", Nillable=true, Name="active", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.Boolean> active { get { return _active; } set { SetProperty(Propertyactive, ref _active, value); } }

		[SMEStringProperty(Label="PurchaseOrderDeliveryLine reference", Name="reference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true, IsUniqueKey=true)]			
		public virtual System.String reference { get { return _reference; } set { SetProperty(Propertyreference, ref _reference, value); } }

		[SMEStringProperty(Label="PurchaseOrderDeliveryLine Reference2", Name="reference2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String reference2 { get { return _reference2; } set { SetProperty(Propertyreference2, ref _reference2, value); } }

		[SMEDecimalProperty(DecimalPlaces=0, Label="PurchaseOrderDeliveryLine Number", Nillable=true, AverageLength=12, Name="number", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> number { get { return _number; } set { SetProperty(Propertynumber, ref _number, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="PurchaseOrderDeliveryLine Status", Name="status", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String status { get { return _status; } set { SetProperty(Propertystatus, ref _status, value); } }

		[SMEResource(CanGet=true, PluralName="commodities", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="commodity", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("commodity")]			
		public virtual commodityFeedEntry commodity { get { return _commodity; } set { SetProperty(Propertycommodity, ref _commodity, value); } }

		[SMEStringProperty(Label="PurchaseOrderDeliveryLine Text", Name="text", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String text { get { return _text; } set { SetProperty(Propertytext, ref _text, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="locations", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="fulfillmentLocation", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("fulfillmentLocation")]			
		public virtual locationFeedEntry fulfillmentLocation { get { return _fulfillmentLocation; } set { SetProperty(PropertyfulfillmentLocation, ref _fulfillmentLocation, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="locations", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="fulfillmentSubLocation", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("fulfillmentSubLocation")]			
		public virtual locationFeedEntry fulfillmentSubLocation { get { return _fulfillmentSubLocation; } set { SetProperty(PropertyfulfillmentSubLocation, ref _fulfillmentSubLocation, value); } }

		[SMEResource(CanGet=true, PluralName="unitsOfMeasure", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="unitOfMeasure", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("unitOfMeasure")]			
		public virtual unitOfMeasureFeedEntry unitOfMeasure { get { return _unitOfMeasure; } set { SetProperty(PropertyunitOfMeasure, ref _unitOfMeasure, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="PurchaseOrderDeliveryLine Requested Quantity", Nillable=true, AverageLength=14, Name="requestedQuantity", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> requestedQuantity { get { return _requestedQuantity; } set { SetProperty(PropertyrequestedQuantity, ref _requestedQuantity, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="PurchaseOrderDeliveryLine Delivered Quantity", Nillable=true, AverageLength=14, Name="deliveredQuantity", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> deliveredQuantity { get { return _deliveredQuantity; } set { SetProperty(PropertydeliveredQuantity, ref _deliveredQuantity, value); } }

		[SMEResource(CanGet=true, CanPut=true, PluralName="notes", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="notes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual noteFeed notes { get { return _notes; } set { SetProperty(Propertynotes, ref _notes, value); } }

		#endregion


	}
}