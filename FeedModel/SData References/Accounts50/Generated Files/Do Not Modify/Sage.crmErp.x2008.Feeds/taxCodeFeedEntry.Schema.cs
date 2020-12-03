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
	/// Defines a taxCode feed entry
	/// </summary>
	#endregion
	[System.ComponentModel.Browsable(false)]
	[XmlType("taxCode", Namespace="http://schemas.sage.com/crmErp/2008")]
	public class taxCodeFeedEntrySchema : Sage.Common.Syndication.FeedEntry
	{
		#region Constants

		public const string Propertyactive = "active";
		public const string Propertyreference = "reference";
		public const string Propertyreference2 = "reference2";
		public const string Propertytype = "type";
		public const string PropertytaxationCountry = "taxationCountry";
		public const string PropertytaxationLocale = "taxationLocale";
		public const string Propertyvalue = "value";
		public const string PropertyvalueText = "valueText";
		public const string PropertyprimacyIndicator = "primacyIndicator";
		public const string PropertyorderOfPrecedence = "orderOfPrecedence";
		public const string Propertynotes = "notes";

		#endregion

		#region Fields

		private Nullable<System.Boolean> _active;
		private System.String _reference;
		private System.String _reference2;
		private System.String _type;
		private System.String _taxationCountry;
		private System.String _taxationLocale;
		private Nullable<System.Decimal> _value;
		private System.String _valueText;
		private Nullable<System.Boolean> _primacyIndicator;
		private Nullable<System.Decimal> _orderOfPrecedence;
		private noteFeedEntry _notes;

		#endregion

		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="taxCodeFeedEntrySchema"/> class.
		/// </summary>
		#endregion
		public taxCodeFeedEntrySchema()
		{
		}

		#region Properties


		[SMEBoolProperty(Label="TaxCode Active Flag", Nillable=true, Name="active", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.Boolean> active { get { return _active; } set { SetProperty(Propertyactive, ref _active, value); } }

		[SMEStringProperty(Label="TaxCode reference", Name="reference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true, IsUniqueKey=true)]			
		public virtual System.String reference { get { return _reference; } set { SetProperty(Propertyreference, ref _reference, value); } }

		[SMEStringProperty(Label="TaxCode Reference2", Name="reference2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String reference2 { get { return _reference2; } set { SetProperty(Propertyreference2, ref _reference2, value); } }

		[SMEStringProperty(Label="TaxCode Type", Name="type", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String type { get { return _type; } set { SetProperty(Propertytype, ref _type, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="TaxCode Taxation Country", Name="taxationCountry", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String taxationCountry { get { return _taxationCountry; } set { SetProperty(PropertytaxationCountry, ref _taxationCountry, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="TaxCode Taxation Locale", Name="taxationLocale", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String taxationLocale { get { return _taxationLocale; } set { SetProperty(PropertytaxationLocale, ref _taxationLocale, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="TaxCode Value", Nillable=true, AverageLength=14, Name="value", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> value { get { return _value; } set { SetProperty(Propertyvalue, ref _value, value); } }

		[SMEStringProperty(Label="TaxCode Value Text", Name="valueText", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String valueText { get { return _valueText; } set { SetProperty(PropertyvalueText, ref _valueText, value); } }

		[SMEBoolProperty(Label="TaxCode Primacy Indicator", Nillable=true, Name="primacyIndicator", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.Boolean> primacyIndicator { get { return _primacyIndicator; } set { SetProperty(PropertyprimacyIndicator, ref _primacyIndicator, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=0, Label="TaxCode Order Of Precedence", Nillable=true, AverageLength=12, Name="orderOfPrecedence", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> orderOfPrecedence { get { return _orderOfPrecedence; } set { SetProperty(PropertyorderOfPrecedence, ref _orderOfPrecedence, value); } }

		[SMEResource(CanGet=true, CanPut=true, PluralName="notes", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Child, Name="notes", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("notes")]			
		public virtual noteFeedEntry notes { get { return _notes; } set { SetProperty(Propertynotes, ref _notes, value); } }

		#endregion


	}
}