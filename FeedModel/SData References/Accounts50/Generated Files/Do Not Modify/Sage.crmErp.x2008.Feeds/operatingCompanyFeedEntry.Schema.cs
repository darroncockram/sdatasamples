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
	/// Defines a operatingCompany feed entry
	/// </summary>
	#endregion
	[System.ComponentModel.Browsable(false)]
	[XmlType("operatingCompany", Namespace="http://schemas.sage.com/crmErp/2008")]
	public class operatingCompanyFeedEntrySchema : Sage.Common.Syndication.FeedEntry
	{
		#region Constants

		public const string PropertyapplicationID = "applicationID";
		public const string Propertyactive = "active";
		public const string Propertystatus = "status";
		public const string Propertyname = "name";
		public const string PropertyshortName = "shortName";
		public const string Propertytype = "type";
		public const string Propertycurrency = "currency";
		public const string Propertywebsite = "website";
		public const string Propertyidentifier = "identifier";
		public const string PropertytaxLocale = "taxLocale";
		public const string PropertytaxReference = "taxReference";
		public const string Propertyindustry = "industry";
		public const string Propertylanguage = "language";

		#endregion

		#region Fields

		private System.String _applicationID;
		private Nullable<System.Boolean> _active;
		private System.String _status;
		private System.String _name;
		private System.String _shortName;
		private System.String _type;
		private System.String _currency;
		private System.String _website;
		private System.String _identifier;
		private System.String _taxLocale;
		private System.String _taxReference;
		private System.String _industry;
		private System.String _language;

		#endregion

		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="operatingCompanyFeedEntrySchema"/> class.
		/// </summary>
		#endregion
		public operatingCompanyFeedEntrySchema()
		{
		}

		#region Properties


		[SMEStringProperty(Label="Company Application ID", Name="applicationID", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true, IsUniqueKey=true)]			
		public virtual System.String applicationID { get { return _applicationID; } set { SetProperty(PropertyapplicationID, ref _applicationID, value); } }

		[SMEBoolProperty(Label="Company Active Flag", Nillable=true, Name="active", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.Boolean> active { get { return _active; } set { SetProperty(Propertyactive, ref _active, value); } }

		[SMEStringProperty(Label="Company Status", Name="status", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String status { get { return _status; } set { SetProperty(Propertystatus, ref _status, value); } }

		[SMEStringProperty(Label="Company Name", Name="name", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String name { get { return _name; } set { SetProperty(Propertyname, ref _name, value); } }

		[SMEStringProperty(Label="Company Short Name", Name="shortName", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String shortName { get { return _shortName; } set { SetProperty(PropertyshortName, ref _shortName, value); } }

		[SMEStringProperty(Label="Company Type", Name="type", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String type { get { return _type; } set { SetProperty(Propertytype, ref _type, value); } }

		[SMEStringProperty(Label="Company Currency", Name="currency", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String currency { get { return _currency; } set { SetProperty(Propertycurrency, ref _currency, value); } }

		[SMEStringProperty(Label="Company Web site", Name="website", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String website { get { return _website; } set { SetProperty(Propertywebsite, ref _website, value); } }

		[SMEStringProperty(Label="Company Identifier", Name="identifier", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true, IsUniqueKey=true)]			
		public virtual System.String identifier { get { return _identifier; } set { SetProperty(Propertyidentifier, ref _identifier, value); } }

		[SMEStringProperty(Label="Company Tax Locale", Name="taxLocale", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String taxLocale { get { return _taxLocale; } set { SetProperty(PropertytaxLocale, ref _taxLocale, value); } }

		[SMEStringProperty(Label="Company Tax reference", Name="taxReference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true, IsUniqueKey=true)]			
		public virtual System.String taxReference { get { return _taxReference; } set { SetProperty(PropertytaxReference, ref _taxReference, value); } }

		[SMEStringProperty(Label="Company Industry", Name="industry", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String industry { get { return _industry; } set { SetProperty(Propertyindustry, ref _industry, value); } }

		[SMEStringProperty(Label="Company Language", Name="language", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String language { get { return _language; } set { SetProperty(Propertylanguage, ref _language, value); } }

		#endregion


	}
}