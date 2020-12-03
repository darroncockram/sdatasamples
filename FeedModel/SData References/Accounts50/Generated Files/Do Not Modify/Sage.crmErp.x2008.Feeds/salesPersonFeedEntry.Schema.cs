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
	/// Defines a salesPerson feed entry
	/// </summary>
	#endregion
	[System.ComponentModel.Browsable(false)]
	[XmlType("salesPerson", Namespace="http://schemas.sage.com/crmErp/2008")]
	public class salesPersonFeedEntrySchema : Sage.Common.Syndication.FeedEntry
	{
		#region Constants

		public const string Propertyactive = "active";
		public const string Propertyreference = "reference";
		public const string Propertyreference2 = "reference2";
		public const string Propertyname = "name";
		public const string Propertycontact = "contact";
		public const string PropertypostalAddress = "postalAddress";
		public const string PropertycommissionType = "commissionType";
		public const string PropertycommissionAmount = "commissionAmount";
		public const string PropertycommissionPercent = "commissionPercent";
		public const string PropertyprimacyIndicator = "primacyIndicator";
		public const string Propertynotes = "notes";

		#endregion

		#region Fields

		private Nullable<System.Boolean> _active;
		private System.String _reference;
		private System.String _reference2;
		private System.String _name;
		private contactFeedEntry _contact;
		private postalAddressFeedEntry _postalAddress;
		private System.String _commissionType;
		private Nullable<System.Decimal> _commissionAmount;
		private Nullable<System.Decimal> _commissionPercent;
		private Nullable<System.Boolean> _primacyIndicator;
		private noteFeed _notes;

		#endregion

		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="salesPersonFeedEntrySchema"/> class.
		/// </summary>
		#endregion
		public salesPersonFeedEntrySchema()
		{
		}

		#region Properties

		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEBoolProperty(Label="SalesPerson Active Flag", Nillable=true, Name="active", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Boolean> active { get { return _active; } set { SetProperty(Propertyactive, ref _active, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="SalesPerson reference", Name="reference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true, Unsupported=true)]			
		public virtual System.String reference { get { return _reference; } set { SetProperty(Propertyreference, ref _reference, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="SalesPersonReference2", Name="reference2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String reference2 { get { return _reference2; } set { SetProperty(Propertyreference2, ref _reference2, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="SalesPerson Name", Name="name", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsMandatory=true, Unsupported=true)]			
		public virtual System.String name { get { return _name; } set { SetProperty(Propertyname, ref _name, value); } }

		[SMEResource(CanGet=true, PluralName="contacts", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="contact", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("contact")]			
		public virtual contactFeedEntry contact { get { return _contact; } set { SetProperty(Propertycontact, ref _contact, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="postalAddresses", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="postalAddress", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("postalAddress")]			
		public virtual postalAddressFeedEntry postalAddress { get { return _postalAddress; } set { SetProperty(PropertypostalAddress, ref _postalAddress, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="SalesPerson Commission Type", Name="commissionType", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String commissionType { get { return _commissionType; } set { SetProperty(PropertycommissionType, ref _commissionType, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesPerson Commission Amount", Nillable=true, AverageLength=14, Name="commissionAmount", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> commissionAmount { get { return _commissionAmount; } set { SetProperty(PropertycommissionAmount, ref _commissionAmount, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesPerson Commission Percent", Nillable=true, AverageLength=14, Name="commissionPercent", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> commissionPercent { get { return _commissionPercent; } set { SetProperty(PropertycommissionPercent, ref _commissionPercent, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEBoolProperty(Label="SalesPerson Primacy Indicator", Nillable=true, Name="primacyIndicator", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Boolean> primacyIndicator { get { return _primacyIndicator; } set { SetProperty(PropertyprimacyIndicator, ref _primacyIndicator, value); } }

		[SMEResource(CanGet=true, CanPut=true, PluralName="notes", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="notes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual noteFeed notes { get { return _notes; } set { SetProperty(Propertynotes, ref _notes, value); } }

		#endregion


	}
}