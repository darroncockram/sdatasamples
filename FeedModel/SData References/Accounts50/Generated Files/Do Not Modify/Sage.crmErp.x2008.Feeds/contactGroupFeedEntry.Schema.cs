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
	/// Defines a contactGroup feed entry
	/// </summary>
	#endregion
	[System.ComponentModel.Browsable(false)]
	[XmlType("contactGroup", Namespace="http://schemas.sage.com/crmErp/2008")]
	public class contactGroupFeedEntrySchema : Sage.Common.Syndication.FeedEntry
	{
		#region Constants

		public const string Propertyactive = "active";
		public const string Propertyname = "name";
		public const string Propertyreference = "reference";
		public const string Propertydescription = "description";
		public const string PropertyassociatedContactGroup = "associatedContactGroup";
		public const string Propertycontacts = "contacts";
		public const string Propertynotes = "notes";

		#endregion

		#region Fields

		private Nullable<System.Boolean> _active;
		private System.String _name;
		private System.String _reference;
		private System.String _description;
		private contactGroupFeed _associatedContactGroup;
		private contactFeed _contacts;
		private noteFeed _notes;

		#endregion

		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="contactGroupFeedEntrySchema"/> class.
		/// </summary>
		#endregion
		public contactGroupFeedEntrySchema()
		{
		}

		#region Properties


		[SMEBoolProperty(Label="ContactGroup Active Flag", Nillable=true, Name="active", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.Boolean> active { get { return _active; } set { SetProperty(Propertyactive, ref _active, value); } }

		[SMEStringProperty(Label="ContactGroup Name", Name="name", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true, IsMandatory=true)]			
		public virtual System.String name { get { return _name; } set { SetProperty(Propertyname, ref _name, value); } }

		[SMEStringProperty(Label="ContactGroup Reference", Name="reference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String reference { get { return _reference; } set { SetProperty(Propertyreference, ref _reference, value); } }

		[SMEStringProperty(Label="ContactGroup Description", Name="description", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String description { get { return _description; } set { SetProperty(Propertydescription, ref _description, value); } }

		[SMEResource(CanGet=true, PluralName="contactGroups", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="associatedContactGroup", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual contactGroupFeed associatedContactGroup { get { return _associatedContactGroup; } set { SetProperty(PropertyassociatedContactGroup, ref _associatedContactGroup, value); } }

		[SMEResource(CanGet=true, PluralName="contacts", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="contacts", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual contactFeed contacts { get { return _contacts; } set { SetProperty(Propertycontacts, ref _contacts, value); } }

		[SMEResource(CanGet=true, CanPut=true, PluralName="notes", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="notes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual noteFeed notes { get { return _notes; } set { SetProperty(Propertynotes, ref _notes, value); } }

		#endregion


	}
}