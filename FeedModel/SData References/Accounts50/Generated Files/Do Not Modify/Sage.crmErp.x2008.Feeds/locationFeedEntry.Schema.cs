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
	/// Defines a location feed entry
	/// </summary>
	#endregion
	[System.ComponentModel.Browsable(false)]
	[XmlType("location", Namespace="http://schemas.sage.com/crmErp/2008")]
	public class locationFeedEntrySchema : Sage.Common.Syndication.FeedEntry
	{
		#region Constants

		public const string Propertyactive = "active";
		public const string Propertytype = "type";
		public const string Propertyreference = "reference";
		public const string Propertyreference2 = "reference2";
		public const string Propertyname = "name";
		public const string Propertydescription = "description";
		public const string PropertycustomerSupplierFlag = "customerSupplierFlag";
		public const string PropertypostalAddress = "postalAddress";
		public const string PropertysaleFlag = "saleFlag";
		public const string PropertypurchaseFlag = "purchaseFlag";
		public const string PropertyopeningDays = "openingDays";
		public const string PropertyopeningTimes = "openingTimes";
		public const string PropertygPSPosition = "gPSPosition";
		public const string Propertyphones = "phones";
		public const string Propertyemails = "emails";
		public const string Propertywebsite = "website";
		public const string Propertycontacts = "contacts";
		public const string PropertytransitFlag = "transitFlag";
		public const string Propertynotes = "notes";
		public const string PropertyparentLocation = "parentLocation";
		public const string PropertychildLocation = "childLocation";

		#endregion

		#region Fields

		private Nullable<System.Boolean> _active;
		private System.String _type;
		private System.String _reference;
		private System.String _reference2;
		private System.String _name;
		private System.String _description;
		private System.String _customerSupplierFlag;
		private postalAddressFeedEntry _postalAddress;
		private Nullable<System.Boolean> _saleFlag;
		private Nullable<System.Boolean> _purchaseFlag;
		private System.String _openingDays;
		private Nullable<System.DateTime> _openingTimes;
		private System.String _gPSPosition;
		private phoneNumberFeed _phones;
		private emailFeed _emails;
		private System.String _website;
		private contactFeed _contacts;
		private Nullable<System.Boolean> _transitFlag;
		private noteFeed _notes;
		private locationFeedEntry _parentLocation;
		private locationFeed _childLocation;

		#endregion

		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="locationFeedEntrySchema"/> class.
		/// </summary>
		#endregion
		public locationFeedEntrySchema()
		{
		}

		#region Properties


		[SMEBoolProperty(Label="Location Active Flag", Nillable=true, Name="active", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.Boolean> active { get { return _active; } set { SetProperty(Propertyactive, ref _active, value); } }

		[SMEStringProperty(Label="Location Type", Name="type", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String type { get { return _type; } set { SetProperty(Propertytype, ref _type, value); } }

		[SMEStringProperty(Label="Location reference", Name="reference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true, IsUniqueKey=true)]			
		public virtual System.String reference { get { return _reference; } set { SetProperty(Propertyreference, ref _reference, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Location Reference2", Name="reference2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String reference2 { get { return _reference2; } set { SetProperty(Propertyreference2, ref _reference2, value); } }

		[SMEStringProperty(Label="Location Name", Name="name", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true, IsMandatory=true)]			
		public virtual System.String name { get { return _name; } set { SetProperty(Propertyname, ref _name, value); } }

		[SMEStringProperty(Label="Location Description", Name="description", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String description { get { return _description; } set { SetProperty(Propertydescription, ref _description, value); } }

		[SMEStringProperty(Label="Location Customer Supplier Flag", Name="customerSupplierFlag", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String customerSupplierFlag { get { return _customerSupplierFlag; } set { SetProperty(PropertycustomerSupplierFlag, ref _customerSupplierFlag, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="postalAddresses", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="postalAddress", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("postalAddress")]			
		public virtual postalAddressFeedEntry postalAddress { get { return _postalAddress; } set { SetProperty(PropertypostalAddress, ref _postalAddress, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEBoolProperty(Label="Location Sale Flag", Nillable=true, Name="saleFlag", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Boolean> saleFlag { get { return _saleFlag; } set { SetProperty(PropertysaleFlag, ref _saleFlag, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEBoolProperty(Label="Location Purchase Flag", Nillable=true, Name="purchaseFlag", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Boolean> purchaseFlag { get { return _purchaseFlag; } set { SetProperty(PropertypurchaseFlag, ref _purchaseFlag, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Location Opening Days", Name="openingDays", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String openingDays { get { return _openingDays; } set { SetProperty(PropertyopeningDays, ref _openingDays, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDateProperty(Label="Location Opening Times", Nillable=true, Name="openingTimes", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.DateTime> openingTimes { get { return _openingTimes; } set { SetProperty(PropertyopeningTimes, ref _openingTimes, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Location GPS Position", Name="gPSPosition", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String gPSPosition { get { return _gPSPosition; } set { SetProperty(PropertygPSPosition, ref _gPSPosition, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="phoneNumbers", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="phones", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual phoneNumberFeed phones { get { return _phones; } set { SetProperty(Propertyphones, ref _phones, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="emails", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="emails", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual emailFeed emails { get { return _emails; } set { SetProperty(Propertyemails, ref _emails, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Location Web site", Name="website", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String website { get { return _website; } set { SetProperty(Propertywebsite, ref _website, value); } }

		[SMEResource(CanGet=true, PluralName="contacts", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="contacts", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual contactFeed contacts { get { return _contacts; } set { SetProperty(Propertycontacts, ref _contacts, value); } }

		[SMEBoolProperty(Label="Location Transit Flag", Nillable=true, Name="transitFlag", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Boolean> transitFlag { get { return _transitFlag; } set { SetProperty(PropertytransitFlag, ref _transitFlag, value); } }

		[SMEResource(CanGet=true, CanPut=true, PluralName="notes", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="notes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual noteFeed notes { get { return _notes; } set { SetProperty(Propertynotes, ref _notes, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="locations", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Parent, Name="parentLocation", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("parentLocation")]			
		public virtual locationFeedEntry parentLocation { get { return _parentLocation; } set { SetProperty(PropertyparentLocation, ref _parentLocation, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="locations", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Child, IsCollection=true, Name="childLocation", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual locationFeed childLocation { get { return _childLocation; } set { SetProperty(PropertychildLocation, ref _childLocation, value); } }

		#endregion


	}
}