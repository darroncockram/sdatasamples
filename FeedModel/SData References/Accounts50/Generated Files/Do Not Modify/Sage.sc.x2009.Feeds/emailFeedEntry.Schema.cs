using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using Sage.Common.Metadata;
using Sage.Common.Syndication;

namespace Sage.sc.x2009.Feeds
{
	#region Documentation
	/// <summary>
	/// Defines a email feed entry
	/// </summary>
	#endregion
	[System.ComponentModel.Browsable(false)]
	[XmlType("email", Namespace="http://schemas.sage.com/sc/2009")]
	public class emailFeedEntrySchema : Sage.Common.Syndication.FeedEntry
	{
		#region Constants

		public const string Propertyactive = "active";
		public const string Propertyreference = "reference";
		public const string Propertyreference2 = "reference2";
		public const string Propertytype = "type";
		public const string Propertyaddress = "address";
		public const string Propertyurl = "url";
		public const string PropertyprimacyIndicator = "primacyIndicator";
		public const string Propertynotes = "notes";
		public const string Propertylabel = "label";

		#endregion

		#region Fields

		private Nullable<System.Boolean> _active;
		private System.String _reference;
		private System.String _reference2;
		private System.String _type;
		private System.String _address;
		private System.String _url;
		private Nullable<System.Boolean> _primacyIndicator;
		private noteFeedEntry _notes;
		private System.String _label;

		#endregion

		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="emailFeedEntrySchema"/> class.
		/// </summary>
		#endregion
		public emailFeedEntrySchema()
		{
		}

		#region Properties


		[SMEBoolProperty(Label="Email Active Flag", Nillable=true, Name="active", Namespace="http://schemas.sage.com/sc/2009", CanFilter=true)]			
		public virtual Nullable<System.Boolean> active { get { return _active; } set { SetProperty(Propertyactive, ref _active, value); } }

		[SMEStringProperty(Label="Email reference", Name="reference", Namespace="http://schemas.sage.com/sc/2009", DataType="string", CanFilter=true)]			
		public virtual System.String reference { get { return _reference; } set { SetProperty(Propertyreference, ref _reference, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Email Reference2", Name="reference2", Namespace="http://schemas.sage.com/sc/2009", DataType="string", Unsupported=true)]			
		public virtual System.String reference2 { get { return _reference2; } set { SetProperty(Propertyreference2, ref _reference2, value); } }

		[SMEStringProperty(Label="Email Type", Name="type", Namespace="http://schemas.sage.com/sc/2009", DataType="string", CanFilter=true)]			
		public virtual System.String type { get { return _type; } set { SetProperty(Propertytype, ref _type, value); } }

		[SMEStringProperty(Label="Email Address", Name="address", Namespace="http://schemas.sage.com/sc/2009", DataType="string", CanFilter=true, IsMandatory=true)]			
		public virtual System.String address { get { return _address; } set { SetProperty(Propertyaddress, ref _address, value); } }

		[SMEStringProperty(Label="mailto:URL", Name="url", Namespace="http://schemas.sage.com/sc/2009", DataType="string", CanFilter=true, IsUniqueKey=true)]			
		public virtual System.String url { get { return _url; } set { SetProperty(Propertyurl, ref _url, value); } }

		[SMEBoolProperty(Label="Email Primacy Indicator", Nillable=true, Name="primacyIndicator", Namespace="http://schemas.sage.com/sc/2009", CanFilter=true)]			
		public virtual Nullable<System.Boolean> primacyIndicator { get { return _primacyIndicator; } set { SetProperty(PropertyprimacyIndicator, ref _primacyIndicator, value); } }

		[SMEResource(CanGet=true, CanPut=true, PluralName="notes", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Child, Name="notes", Namespace="http://schemas.sage.com/sc/2009")]
		[XmlElement("notes")]			
		public virtual noteFeedEntry notes { get { return _notes; } set { SetProperty(Propertynotes, ref _notes, value); } }

		[SMEStringProperty(Label="Email Label", Name="label", Namespace="http://schemas.sage.com/sc/2009", DataType="string")]			
		public virtual System.String label { get { return _label; } set { SetProperty(Propertylabel, ref _label, value); } }

		#endregion


	}
}