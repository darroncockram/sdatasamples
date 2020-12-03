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
	/// Defines a unitOfMeasure feed entry
	/// </summary>
	#endregion
	[System.ComponentModel.Browsable(false)]
	[XmlType("unitOfMeasure", Namespace="http://schemas.sage.com/crmErp/2008")]
	public class unitOfMeasureFeedEntrySchema : Sage.Common.Syndication.FeedEntry
	{
		#region Constants

		public const string PropertyunitOfMeasureGroup = "unitOfMeasureGroup";
		public const string Propertyactive = "active";
		public const string Propertytype = "type";
		public const string Propertyreference = "reference";
		public const string Propertyreference2 = "reference2";
		public const string Propertyname = "name";
		public const string PropertyshortName = "shortName";
		public const string Propertysymbol = "symbol";
		public const string Propertydescription = "description";
		public const string PropertybaseNumber = "baseNumber";
		public const string PropertybaseFactorNumber = "baseFactorNumber";
		public const string PropertydecimalPlaces = "decimalPlaces";
		public const string PropertytradeIdentificationNumber = "tradeIdentificationNumber";
		public const string Propertyweight = "weight";
		public const string PropertyweightKg = "weightKg";
		public const string PropertyprimacyIndicator = "primacyIndicator";
		public const string Propertycommodities = "commodities";
		public const string Propertynotes = "notes";

		#endregion

		#region Fields

		private unitOfMeasureGroupFeedEntry _unitOfMeasureGroup;
		private Nullable<System.Boolean> _active;
		private System.String _type;
		private System.String _reference;
		private System.String _reference2;
		private System.String _name;
		private System.String _shortName;
		private System.String _symbol;
		private System.String _description;
		private Nullable<System.Decimal> _baseNumber;
		private Nullable<System.Decimal> _baseFactorNumber;
		private Nullable<System.Decimal> _decimalPlaces;
		private System.String _tradeIdentificationNumber;
		private Nullable<System.Decimal> _weight;
		private Nullable<System.Decimal> _weightKg;
		private Nullable<System.Boolean> _primacyIndicator;
		private commodityFeed _commodities;
		private noteFeed _notes;

		#endregion

		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="unitOfMeasureFeedEntrySchema"/> class.
		/// </summary>
		#endregion
		public unitOfMeasureFeedEntrySchema()
		{
		}

		#region Properties


		[SMEResource(CanGet=true, PluralName="unitsOfMeasureGroup", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Parent, Name="unitOfMeasureGroup", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("unitOfMeasureGroup")]			
		public virtual unitOfMeasureGroupFeedEntry unitOfMeasureGroup { get { return _unitOfMeasureGroup; } set { SetProperty(PropertyunitOfMeasureGroup, ref _unitOfMeasureGroup, value); } }

		[SMEBoolProperty(Label="UnitOfMeasure Active Flag", Nillable=true, Name="active", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.Boolean> active { get { return _active; } set { SetProperty(Propertyactive, ref _active, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="UnitOfMeasure Type", Name="type", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String type { get { return _type; } set { SetProperty(Propertytype, ref _type, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="UnitOfMeasure reference", Name="reference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String reference { get { return _reference; } set { SetProperty(Propertyreference, ref _reference, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="UnitOfMeasure Reference2", Name="reference2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String reference2 { get { return _reference2; } set { SetProperty(Propertyreference2, ref _reference2, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="UnitOfMeasure Name", Name="name", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String name { get { return _name; } set { SetProperty(Propertyname, ref _name, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="UnitOfMeasure Short Name", Name="shortName", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String shortName { get { return _shortName; } set { SetProperty(PropertyshortName, ref _shortName, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="UnitOfMeasure Symbol", Name="symbol", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String symbol { get { return _symbol; } set { SetProperty(Propertysymbol, ref _symbol, value); } }

		[SMEStringProperty(Label="UnitOfMeasure Description", Name="description", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String description { get { return _description; } set { SetProperty(Propertydescription, ref _description, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="UnitOfMeasure Base Number", Nillable=true, AverageLength=14, Name="baseNumber", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> baseNumber { get { return _baseNumber; } set { SetProperty(PropertybaseNumber, ref _baseNumber, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="UnitOfMeasure Base Factor Number", Nillable=true, AverageLength=14, Name="baseFactorNumber", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> baseFactorNumber { get { return _baseFactorNumber; } set { SetProperty(PropertybaseFactorNumber, ref _baseFactorNumber, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="UnitOfMeasure Decimal Places", Nillable=true, AverageLength=14, Name="decimalPlaces", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> decimalPlaces { get { return _decimalPlaces; } set { SetProperty(PropertydecimalPlaces, ref _decimalPlaces, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="UnitOfMeasure Trade Identification Number", Name="tradeIdentificationNumber", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true, Unsupported=true)]			
		public virtual System.String tradeIdentificationNumber { get { return _tradeIdentificationNumber; } set { SetProperty(PropertytradeIdentificationNumber, ref _tradeIdentificationNumber, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="UnitOfMeasure Weight", Nillable=true, AverageLength=14, Name="weight", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> weight { get { return _weight; } set { SetProperty(Propertyweight, ref _weight, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="UnitOfMeasure Weight KG", Nillable=true, AverageLength=14, Name="weightKg", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> weightKg { get { return _weightKg; } set { SetProperty(PropertyweightKg, ref _weightKg, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEBoolProperty(Label="UnitOfMeasure Primacy Indicator", Nillable=true, Name="primacyIndicator", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Boolean> primacyIndicator { get { return _primacyIndicator; } set { SetProperty(PropertyprimacyIndicator, ref _primacyIndicator, value); } }

		[SMEResource(CanGet=true, PluralName="commodities", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="commodities", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual commodityFeed commodities { get { return _commodities; } set { SetProperty(Propertycommodities, ref _commodities, value); } }

		[SMEResource(CanGet=true, CanPut=true, PluralName="notes", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="notes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual noteFeed notes { get { return _notes; } set { SetProperty(Propertynotes, ref _notes, value); } }

		#endregion


	}
}