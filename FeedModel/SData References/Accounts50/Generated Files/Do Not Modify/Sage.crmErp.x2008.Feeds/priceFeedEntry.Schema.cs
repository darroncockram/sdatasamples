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
	/// Defines a price feed entry
	/// </summary>
	#endregion
	[System.ComponentModel.Browsable(false)]
	[XmlType("price", Namespace="http://schemas.sage.com/crmErp/2008")]
	public class priceFeedEntrySchema : Sage.Common.Syndication.FeedEntry
	{
		#region Constants

		public const string Propertyactive = "active";
		public const string Propertyreference = "reference";
		public const string Propertystatus = "status";
		public const string PropertycustomerSupplierFlag = "customerSupplierFlag";
		public const string PropertytradingAccounts = "tradingAccounts";
		public const string Propertycommodity = "commodity";
		public const string Propertypricelist = "pricelist";
		public const string PropertyunitOfMeasure = "unitOfMeasure";
		public const string Propertylocation = "location";
		public const string PropertypostalAddress = "postalAddress";
		public const string Propertycurrency = "currency";
		public const string PropertyoperatingCompanyCurrency = "operatingCompanyCurrency";
		public const string PropertyoperatingCompanyCurrencyExchangeRate = "operatingCompanyCurrencyExchangeRate";
		public const string PropertyoperatingCompanyCurrencyExchangeRateOperator = "operatingCompanyCurrencyExchangeRateOperator";
		public const string PropertyoperatingCompanyCurrencyExchangeRateDate = "operatingCompanyCurrencyExchangeRateDate";
		public const string PropertydecimalPlaces = "decimalPlaces";
		public const string Propertyprice = "price";
		public const string PropertyincludesTax = "includesTax";
		public const string PropertystartDate = "startDate";
		public const string PropertyendDate = "endDate";
		public const string Propertynotes = "notes";

		#endregion

		#region Fields

		private Nullable<System.Boolean> _active;
		private System.String _reference;
		private System.String _status;
		private System.String _customerSupplierFlag;
		private tradingAccountFeed _tradingAccounts;
		private commodityFeedEntry _commodity;
		private priceListFeedEntry _pricelist;
		private unitOfMeasureFeedEntry _unitOfMeasure;
		private locationFeed _location;
		private postalAddressFeed _postalAddress;
		private System.String _currency;
		private System.String _operatingCompanyCurrency;
		private Nullable<System.Decimal> _operatingCompanyCurrencyExchangeRate;
		private System.String _operatingCompanyCurrencyExchangeRateOperator;
		private Nullable<System.DateTime> _operatingCompanyCurrencyExchangeRateDate;
		private Nullable<System.Decimal> _decimalPlaces;
		private Nullable<System.Decimal> _price;
		private Nullable<System.Boolean> _includesTax;
		private Nullable<System.DateTime> _startDate;
		private Nullable<System.DateTime> _endDate;
		private noteFeed _notes;

		#endregion

		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="priceFeedEntrySchema"/> class.
		/// </summary>
		#endregion
		public priceFeedEntrySchema()
		{
		}

		#region Properties


		[SMEBoolProperty(Label="Price Active Flag", Nillable=true, Name="active", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.Boolean> active { get { return _active; } set { SetProperty(Propertyactive, ref _active, value); } }

		[SMEStringProperty(Label="Price Reference", Name="reference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String reference { get { return _reference; } set { SetProperty(Propertyreference, ref _reference, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Price Status", Name="status", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String status { get { return _status; } set { SetProperty(Propertystatus, ref _status, value); } }

		[SMEStringProperty(Label="Price Customer Supplier Flag", Name="customerSupplierFlag", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String customerSupplierFlag { get { return _customerSupplierFlag; } set { SetProperty(PropertycustomerSupplierFlag, ref _customerSupplierFlag, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="tradingAccounts", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="tradingAccounts", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual tradingAccountFeed tradingAccounts { get { return _tradingAccounts; } set { SetProperty(PropertytradingAccounts, ref _tradingAccounts, value); } }

		[SMEResource(CanGet=true, PluralName="commodities", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="commodity", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("commodity")]			
		public virtual commodityFeedEntry commodity { get { return _commodity; } set { SetProperty(Propertycommodity, ref _commodity, value); } }

		[SMEResource(CanGet=true, PluralName="priceLists", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="pricelist", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("pricelist")]			
		public virtual priceListFeedEntry pricelist { get { return _pricelist; } set { SetProperty(Propertypricelist, ref _pricelist, value); } }

		[SMEResource(CanGet=true, PluralName="unitsOfMeasure", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="unitOfMeasure", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("unitOfMeasure")]			
		public virtual unitOfMeasureFeedEntry unitOfMeasure { get { return _unitOfMeasure; } set { SetProperty(PropertyunitOfMeasure, ref _unitOfMeasure, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="locations", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="location", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual locationFeed location { get { return _location; } set { SetProperty(Propertylocation, ref _location, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="postalAddresses", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="postalAddress", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual postalAddressFeed postalAddress { get { return _postalAddress; } set { SetProperty(PropertypostalAddress, ref _postalAddress, value); } }

		[SMEStringProperty(Label="Price Currency", Name="currency", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String currency { get { return _currency; } set { SetProperty(Propertycurrency, ref _currency, value); } }

		[SMEStringProperty(Label="Price OperatingCompany Currency", Name="operatingCompanyCurrency", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String operatingCompanyCurrency { get { return _operatingCompanyCurrency; } set { SetProperty(PropertyoperatingCompanyCurrency, ref _operatingCompanyCurrency, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="Price OperatingCompany Currency Exchange Rate", Nillable=true, AverageLength=14, Name="operatingCompanyCurrencyExchangeRate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> operatingCompanyCurrencyExchangeRate { get { return _operatingCompanyCurrencyExchangeRate; } set { SetProperty(PropertyoperatingCompanyCurrencyExchangeRate, ref _operatingCompanyCurrencyExchangeRate, value); } }

		[SMEStringProperty(Label="Price OperatingCompany Currency Exchange Rate Operator", Name="operatingCompanyCurrencyExchangeRateOperator", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String operatingCompanyCurrencyExchangeRateOperator { get { return _operatingCompanyCurrencyExchangeRateOperator; } set { SetProperty(PropertyoperatingCompanyCurrencyExchangeRateOperator, ref _operatingCompanyCurrencyExchangeRateOperator, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDateProperty(Label="Price OperatingCompany Currency Exchange Rate Date", Nillable=true, Name="operatingCompanyCurrencyExchangeRateDate", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.DateTime> operatingCompanyCurrencyExchangeRateDate { get { return _operatingCompanyCurrencyExchangeRateDate; } set { SetProperty(PropertyoperatingCompanyCurrencyExchangeRateDate, ref _operatingCompanyCurrencyExchangeRateDate, value); } }

		[SMEDecimalProperty(DecimalPlaces=0, Label="Price Decimal Places", Nillable=true, AverageLength=12, Name="decimalPlaces", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> decimalPlaces { get { return _decimalPlaces; } set { SetProperty(PropertydecimalPlaces, ref _decimalPlaces, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="Price", Nillable=true, AverageLength=14, Name="price", Namespace="http://schemas.sage.com/crmErp/2008", IsMandatory=true)]			
		public virtual Nullable<System.Decimal> price { get { return _price; } set { SetProperty(Propertyprice, ref _price, value); } }

		[SMEBoolProperty(Label="Price Includes Tax", Nillable=true, Name="includesTax", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Boolean> includesTax { get { return _includesTax; } set { SetProperty(PropertyincludesTax, ref _includesTax, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDateProperty(Label="Price Start Date", Nillable=true, Name="startDate", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.DateTime> startDate { get { return _startDate; } set { SetProperty(PropertystartDate, ref _startDate, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDateProperty(Label="Price End Date", Nillable=true, Name="endDate", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.DateTime> endDate { get { return _endDate; } set { SetProperty(PropertyendDate, ref _endDate, value); } }

		[SMEResource(CanGet=true, CanPut=true, PluralName="notes", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="notes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual noteFeed notes { get { return _notes; } set { SetProperty(Propertynotes, ref _notes, value); } }

		#endregion


	}
}