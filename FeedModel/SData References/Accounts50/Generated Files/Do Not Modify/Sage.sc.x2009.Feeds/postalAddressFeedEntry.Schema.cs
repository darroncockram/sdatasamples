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
	/// Defines a postalAddress feed entry
	/// </summary>
	#endregion
	[System.ComponentModel.Browsable(false)]
	[XmlType("postalAddress", Namespace="http://schemas.sage.com/sc/2009")]
	public class postalAddressFeedEntrySchema : Sage.Common.Syndication.FeedEntry
	{
		#region Constants

		public const string Propertyactive = "active";
		public const string Propertyreference = "reference";
		public const string Propertyname = "name";
		public const string Propertydescription = "description";
		public const string Propertyaddress1 = "address1";
		public const string Propertyaddress2 = "address2";
		public const string Propertyaddress3 = "address3";
		public const string Propertyaddress4 = "address4";
		public const string PropertytownCity = "townCity";
		public const string Propertycounty = "county";
		public const string PropertystateRegion = "stateRegion";
		public const string PropertyzipPostCode = "zipPostCode";
		public const string Propertycountry = "country";
		public const string PropertyprimacyIndicator = "primacyIndicator";
		public const string Propertytype = "type";

		#endregion

		#region Fields

		private Nullable<System.Boolean> _active;
		private System.String _reference;
		private System.String _name;
		private System.String _description;
		private System.String _address1;
		private System.String _address2;
		private System.String _address3;
		private System.String _address4;
		private System.String _townCity;
		private System.String _county;
		private System.String _stateRegion;
		private System.String _zipPostCode;
		private System.String _country;
		private Nullable<System.Boolean> _primacyIndicator;
		private System.String _type;

		#endregion

		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="postalAddressFeedEntrySchema"/> class.
		/// </summary>
		#endregion
		public postalAddressFeedEntrySchema()
		{
		}

		#region Properties


		[SMEBoolProperty(Label="PostalAddress Active Flag", Nillable=true, Name="active", Namespace="http://schemas.sage.com/sc/2009", CanFilter=true)]			
		public virtual Nullable<System.Boolean> active { get { return _active; } set { SetProperty(Propertyactive, ref _active, value); } }

		[SMEStringProperty(Label="PostalAddress Reference", Name="reference", Namespace="http://schemas.sage.com/sc/2009", DataType="string", CanFilter=true)]			
		public virtual System.String reference { get { return _reference; } set { SetProperty(Propertyreference, ref _reference, value); } }

		[SMEStringProperty(Label="PostalAddress Name", Name="name", Namespace="http://schemas.sage.com/sc/2009", DataType="string", CanFilter=true)]			
		public virtual System.String name { get { return _name; } set { SetProperty(Propertyname, ref _name, value); } }

		[SMEStringProperty(Label="PostalAddress Description", Name="description", Namespace="http://schemas.sage.com/sc/2009", DataType="string", CanFilter=true)]			
		public virtual System.String description { get { return _description; } set { SetProperty(Propertydescription, ref _description, value); } }

		[SMEStringProperty(Label="PostalAddress Address 1", Name="address1", Namespace="http://schemas.sage.com/sc/2009", DataType="string", CanFilter=true)]			
		public virtual System.String address1 { get { return _address1; } set { SetProperty(Propertyaddress1, ref _address1, value); } }

		[SMEStringProperty(Label="PostalAddress Address 2", Name="address2", Namespace="http://schemas.sage.com/sc/2009", DataType="string", CanFilter=true)]			
		public virtual System.String address2 { get { return _address2; } set { SetProperty(Propertyaddress2, ref _address2, value); } }

		[SMEStringProperty(Label="PostalAddress Address 3", Name="address3", Namespace="http://schemas.sage.com/sc/2009", DataType="string", CanFilter=true)]			
		public virtual System.String address3 { get { return _address3; } set { SetProperty(Propertyaddress3, ref _address3, value); } }

		[SMEStringProperty(Label="PostalAddress Address 4", Name="address4", Namespace="http://schemas.sage.com/sc/2009", DataType="string", CanFilter=true)]			
		public virtual System.String address4 { get { return _address4; } set { SetProperty(Propertyaddress4, ref _address4, value); } }

		[SMEStringProperty(Label="PostalAddress TownCity", Name="townCity", Namespace="http://schemas.sage.com/sc/2009", DataType="string", CanFilter=true)]			
		public virtual System.String townCity { get { return _townCity; } set { SetProperty(PropertytownCity, ref _townCity, value); } }

		[SMEStringProperty(Label="PostalAddress County", Name="county", Namespace="http://schemas.sage.com/sc/2009", DataType="string", CanFilter=true)]			
		public virtual System.String county { get { return _county; } set { SetProperty(Propertycounty, ref _county, value); } }

		[SMEStringProperty(Label="PostalAddress StateRegion", Name="stateRegion", Namespace="http://schemas.sage.com/sc/2009", DataType="string", CanFilter=true)]			
		public virtual System.String stateRegion { get { return _stateRegion; } set { SetProperty(PropertystateRegion, ref _stateRegion, value); } }

		[SMEStringProperty(Label="PostalAddress ZipPost Code", Name="zipPostCode", Namespace="http://schemas.sage.com/sc/2009", DataType="string", CanFilter=true)]			
		public virtual System.String zipPostCode { get { return _zipPostCode; } set { SetProperty(PropertyzipPostCode, ref _zipPostCode, value); } }

		[SMEStringProperty(Label="PostalAddress Country", Name="country", Namespace="http://schemas.sage.com/sc/2009", DataType="string", CanFilter=true)]			
		public virtual System.String country { get { return _country; } set { SetProperty(Propertycountry, ref _country, value); } }

		[SMEBoolProperty(Label="PostalAddress Primacy Indicator", Nillable=true, Name="primacyIndicator", Namespace="http://schemas.sage.com/sc/2009", CanFilter=true)]			
		public virtual Nullable<System.Boolean> primacyIndicator { get { return _primacyIndicator; } set { SetProperty(PropertyprimacyIndicator, ref _primacyIndicator, value); } }

		[SMEStringProperty(Label="PostalAddress Type", Name="type", Namespace="http://schemas.sage.com/sc/2009", DataType="string", CanFilter=true, IsMandatory=true)]			
		public virtual System.String type { get { return _type; } set { SetProperty(Propertytype, ref _type, value); } }

		#endregion


	}
}