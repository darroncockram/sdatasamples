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
	/// Defines a unitOfMeasureGroup feed entry
	/// </summary>
	#endregion
	[System.ComponentModel.Browsable(false)]
	[XmlType("unitOfMeasureGroup", Namespace="http://schemas.sage.com/crmErp/2008")]
	public class unitOfMeasureGroupFeedEntrySchema : Sage.Common.Syndication.FeedEntry
	{
		#region Constants

		public const string Propertyactive = "active";
		public const string Propertyreference = "reference";
		public const string Propertyname = "name";
		public const string Propertydescription = "description";
		public const string PropertyunitOfMeasures = "unitOfMeasures";
		public const string Propertynotes = "notes";

		#endregion

		#region Fields

		private Nullable<System.Boolean> _active;
		private System.String _reference;
		private System.String _name;
		private System.String _description;
		private unitOfMeasureFeed _unitOfMeasures;
		private noteFeed _notes;

		#endregion

		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="unitOfMeasureGroupFeedEntrySchema"/> class.
		/// </summary>
		#endregion
		public unitOfMeasureGroupFeedEntrySchema()
		{
		}

		#region Properties


		[SMEBoolProperty(Label="UnitOfMeasureGroup Active Flag", Nillable=true, Name="active", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.Boolean> active { get { return _active; } set { SetProperty(Propertyactive, ref _active, value); } }

		[SMEStringProperty(Label="UnitOfMeasureGroup Reference", Name="reference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String reference { get { return _reference; } set { SetProperty(Propertyreference, ref _reference, value); } }

		[SMEStringProperty(Label="UnitOfMeasureGroup Name", Name="name", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true, IsMandatory=true)]			
		public virtual System.String name { get { return _name; } set { SetProperty(Propertyname, ref _name, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="UnitOfMeasureGroup Description", Name="description", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String description { get { return _description; } set { SetProperty(Propertydescription, ref _description, value); } }

		[SMEResource(CanGet=true, PluralName="unitsOfMeasure", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Child, IsCollection=true, Name="unitOfMeasures", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual unitOfMeasureFeed unitOfMeasures { get { return _unitOfMeasures; } set { SetProperty(PropertyunitOfMeasures, ref _unitOfMeasures, value); } }

		[SMEResource(CanGet=true, CanPut=true, PluralName="notes", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Child, IsCollection=true, Name="notes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual noteFeed notes { get { return _notes; } set { SetProperty(Propertynotes, ref _notes, value); } }

		#endregion


	}
}