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
	/// Defines a commodity feed entry
	/// </summary>
	#endregion
	[System.ComponentModel.Browsable(false)]
	[XmlType("commodity", Namespace="http://schemas.sage.com/crmErp/2008")]
	public class commodityFeedEntrySchema : Sage.Common.Syndication.FeedEntry
	{
		#region Constants

		public const string Propertyactive = "active";
		public const string PropertycommodityGroup = "commodityGroup";
		public const string PropertycommodityIdentifierType = "commodityIdentifierType";
		public const string PropertycommodityIdentifiers = "commodityIdentifiers";
		public const string Propertyreference = "reference";
		public const string Propertyreference2 = "reference2";
		public const string Propertystatus = "status";
		public const string Propertyname = "name";
		public const string PropertyshortName = "shortName";
		public const string Propertydescription = "description";
		public const string PropertyalternativeDescription1 = "alternativeDescription1";
		public const string PropertyalternativeDescription2 = "alternativeDescription2";
		public const string Propertytype = "type";
		public const string PropertyunitOfMeasure = "unitOfMeasure";
		public const string PropertybuyingAllowedFlag = "buyingAllowedFlag";
		public const string PropertybuyingUnitOfMeasure = "buyingUnitOfMeasure";
		public const string PropertybuyingUnitOfMeasureNumber = "buyingUnitOfMeasureNumber";
		public const string PropertysellingAllowedFlag = "sellingAllowedFlag";
		public const string PropertysellingUnitOfMeasure = "sellingUnitOfMeasure";
		public const string PropertysellingUnitOfMeasureNumber = "sellingUnitOfMeasureNumber";
		public const string PropertypackingUnitOfMeasure = "packingUnitOfMeasure";
		public const string PropertypackingUnitOfMeasureNumber = "packingUnitOfMeasureNumber";
		public const string PropertycatalogueNumber = "catalogueNumber";
		public const string PropertysupplierTradingAccount = "supplierTradingAccount";
		public const string PropertysupplierReference = "supplierReference";
		public const string PropertymanufacturerCompany = "manufacturerCompany";
		public const string PropertymanufacturerReference = "manufacturerReference";
		public const string Propertymaterial = "material";
		public const string PropertycountryOfOrigin = "countryOfOrigin";
		public const string Propertyweight = "weight";
		public const string PropertyweightKg = "weightKg";
		public const string Propertyclassification = "classification";
		public const string PropertytaxCodes = "taxCodes";
		public const string PropertyfinancialAccounts = "financialAccounts";
		public const string PropertydutyApplicableFlag = "dutyApplicableFlag";
		public const string PropertydutyRate = "dutyRate";
		public const string PropertytradeIdentificationNumber = "tradeIdentificationNumber";
		public const string Propertyreplacement = "replacement";
		public const string PropertyreplacementDate = "replacementDate";
		public const string PropertyleadTime = "leadTime";
		public const string Propertycost = "cost";
		public const string PropertyassociatedChildCommodities = "associatedChildCommodities";
		public const string PropertyassociatedParentCommodity = "associatedParentCommodity";
		public const string Propertyversion = "version";
		public const string PropertycommissionType = "commissionType";
		public const string PropertycommissionAmount = "commissionAmount";
		public const string PropertycommissionPercent = "commissionPercent";
		public const string Propertyinteractions = "interactions";
		public const string Propertyopportunities = "opportunities";
		public const string PropertysalesQuotationLines = "salesQuotationLines";
		public const string PropertysalesOrderLines = "salesOrderLines";
		public const string PropertysalesOrderDeliveryLines = "salesOrderDeliveryLines";
		public const string PropertysalesInvoiceLines = "salesInvoiceLines";
		public const string PropertysalesCreditLines = "salesCreditLines";
		public const string PropertypurchaseOrderLines = "purchaseOrderLines";
		public const string PropertypurchaseOrderDeliveryLines = "purchaseOrderDeliveryLines";
		public const string Propertypricelists = "pricelists";
		public const string Propertyprices = "prices";
		public const string PropertyinStock = "inStock";
		public const string Propertyallocated = "allocated";
		public const string PropertyfreeStock = "freeStock";
		public const string PropertyonOrder = "onOrder";
		public const string PropertysalesPrice = "salesPrice";

		#endregion

		#region Fields

		private Nullable<System.Boolean> _active;
		private commodityGroupFeedEntry _commodityGroup;
		private System.String _commodityIdentifierType;
		private commodityIdentifierFeedEntry _commodityIdentifiers;
		private System.String _reference;
		private System.String _reference2;
		private System.String _status;
		private System.String _name;
		private System.String _shortName;
		private System.String _description;
		private System.String _alternativeDescription1;
		private System.String _alternativeDescription2;
		private System.String _type;
		private unitOfMeasureFeedEntry _unitOfMeasure;
		private Nullable<System.Boolean> _buyingAllowedFlag;
		private unitOfMeasureFeedEntry _buyingUnitOfMeasure;
		private Nullable<System.Decimal> _buyingUnitOfMeasureNumber;
		private Nullable<System.Boolean> _sellingAllowedFlag;
		private unitOfMeasureFeedEntry _sellingUnitOfMeasure;
		private Nullable<System.Decimal> _sellingUnitOfMeasureNumber;
		private unitOfMeasureFeedEntry _packingUnitOfMeasure;
		private Nullable<System.Decimal> _packingUnitOfMeasureNumber;
		private System.String _catalogueNumber;
		private tradingAccountFeed _supplierTradingAccount;
		private System.String _supplierReference;
		private System.String _manufacturerCompany;
		private System.String _manufacturerReference;
		private System.String _material;
		private System.String _countryOfOrigin;
		private Nullable<System.Decimal> _weight;
		private Nullable<System.Decimal> _weightKg;
		private System.String _classification;
		private taxCodeFeed _taxCodes;
		private financialAccountFeed _financialAccounts;
		private Nullable<System.Boolean> _dutyApplicableFlag;
		private Nullable<System.Decimal> _dutyRate;
		private System.String _tradeIdentificationNumber;
		private commodityFeedEntry _replacement;
		private Nullable<System.DateTime> _replacementDate;
		private Nullable<System.Decimal> _leadTime;
		private Nullable<System.Decimal> _cost;
		private commodityFeed _associatedChildCommodities;
		private commodityFeedEntry _associatedParentCommodity;
		private System.String _version;
		private System.String _commissionType;
		private Nullable<System.Decimal> _commissionAmount;
		private Nullable<System.Decimal> _commissionPercent;
		private interactionFeed _interactions;
		private opportunityFeed _opportunities;
		private salesQuotationLineFeed _salesQuotationLines;
		private salesOrderLineFeed _salesOrderLines;
		private salesOrderDeliveryLineFeed _salesOrderDeliveryLines;
		private salesInvoiceLineFeed _salesInvoiceLines;
		private salesCreditLineFeed _salesCreditLines;
		private purchaseOrderLineFeed _purchaseOrderLines;
		private purchaseOrderDeliveryLineFeed _purchaseOrderDeliveryLines;
		private priceListFeed _pricelists;
		private priceFeed _prices;
		private Nullable<System.Decimal> _inStock;
		private Nullable<System.Decimal> _allocated;
		private Nullable<System.Decimal> _freeStock;
		private Nullable<System.Decimal> _onOrder;
		private Nullable<System.Decimal> _salesPrice;

		#endregion

		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="commodityFeedEntrySchema"/> class.
		/// </summary>
		#endregion
		public commodityFeedEntrySchema()
		{
		}

		#region Properties


		[SMEBoolProperty(Label="Commodity Active Flag", Nillable=true, Name="active", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.Boolean> active { get { return _active; } set { SetProperty(Propertyactive, ref _active, value); } }

		[SMEResource(CanGet=true, PluralName="commodityGroups", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="commodityGroup", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("commodityGroup")]			
		public virtual commodityGroupFeedEntry commodityGroup { get { return _commodityGroup; } set { SetProperty(PropertycommodityGroup, ref _commodityGroup, value); } }

		[SMEStringProperty(Label="Commodity CommodityIdentifier Type", Name="commodityIdentifierType", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String commodityIdentifierType { get { return _commodityIdentifierType; } set { SetProperty(PropertycommodityIdentifierType, ref _commodityIdentifierType, value); } }

		[SMEResource(CanGet=true, PluralName="commodityIdentifiers", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Child, Name="commodityIdentifiers", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("commodityIdentifiers")]			
		public virtual commodityIdentifierFeedEntry commodityIdentifiers { get { return _commodityIdentifiers; } set { SetProperty(PropertycommodityIdentifiers, ref _commodityIdentifiers, value); } }

		[SMEStringProperty(Label="Commodity reference", Name="reference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true, IsUniqueKey=true)]			
		public virtual System.String reference { get { return _reference; } set { SetProperty(Propertyreference, ref _reference, value); } }

		[SMEStringProperty(Label="Commodity Reference2", Name="reference2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String reference2 { get { return _reference2; } set { SetProperty(Propertyreference2, ref _reference2, value); } }

		[SMEStringProperty(Label="Commodity Status", Name="status", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String status { get { return _status; } set { SetProperty(Propertystatus, ref _status, value); } }

		[SMEStringProperty(Label="Commodity Name", Name="name", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true, IsMandatory=true)]			
		public virtual System.String name { get { return _name; } set { SetProperty(Propertyname, ref _name, value); } }

		[SMEStringProperty(Label="Commodity Short Name", Name="shortName", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String shortName { get { return _shortName; } set { SetProperty(PropertyshortName, ref _shortName, value); } }

		[SMEStringProperty(Label="Commodity Description", Name="description", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String description { get { return _description; } set { SetProperty(Propertydescription, ref _description, value); } }

		[SMEStringProperty(Label="Commodity Alternative Description 1", Name="alternativeDescription1", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String alternativeDescription1 { get { return _alternativeDescription1; } set { SetProperty(PropertyalternativeDescription1, ref _alternativeDescription1, value); } }

		[SMEStringProperty(Label="Commodity Alternative Description 2", Name="alternativeDescription2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String alternativeDescription2 { get { return _alternativeDescription2; } set { SetProperty(PropertyalternativeDescription2, ref _alternativeDescription2, value); } }

		[SMEStringProperty(Label="Commodity Type", Name="type", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true, IsMandatory=true)]			
		public virtual System.String type { get { return _type; } set { SetProperty(Propertytype, ref _type, value); } }

		[SMEResource(CanGet=true, PluralName="unitsOfMeasure", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="unitOfMeasure", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("unitOfMeasure")]			
		public virtual unitOfMeasureFeedEntry unitOfMeasure { get { return _unitOfMeasure; } set { SetProperty(PropertyunitOfMeasure, ref _unitOfMeasure, value); } }

		[SMEBoolProperty(Label="Commodity Buying Allowed Flag", Nillable=true, Name="buyingAllowedFlag", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Boolean> buyingAllowedFlag { get { return _buyingAllowedFlag; } set { SetProperty(PropertybuyingAllowedFlag, ref _buyingAllowedFlag, value); } }

		[SMEResource(CanGet=true, PluralName="unitsOfMeasure", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="buyingUnitOfMeasure", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("buyingUnitOfMeasure")]			
		public virtual unitOfMeasureFeedEntry buyingUnitOfMeasure { get { return _buyingUnitOfMeasure; } set { SetProperty(PropertybuyingUnitOfMeasure, ref _buyingUnitOfMeasure, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="Commodity Buying UnitOfMeasure Number", Nillable=true, AverageLength=14, Name="buyingUnitOfMeasureNumber", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> buyingUnitOfMeasureNumber { get { return _buyingUnitOfMeasureNumber; } set { SetProperty(PropertybuyingUnitOfMeasureNumber, ref _buyingUnitOfMeasureNumber, value); } }

		[SMEBoolProperty(Label="Commodity Selling Allowed Flag", Nillable=true, Name="sellingAllowedFlag", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Boolean> sellingAllowedFlag { get { return _sellingAllowedFlag; } set { SetProperty(PropertysellingAllowedFlag, ref _sellingAllowedFlag, value); } }

		[SMEResource(CanGet=true, PluralName="unitsOfMeasure", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="sellingUnitOfMeasure", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("sellingUnitOfMeasure")]			
		public virtual unitOfMeasureFeedEntry sellingUnitOfMeasure { get { return _sellingUnitOfMeasure; } set { SetProperty(PropertysellingUnitOfMeasure, ref _sellingUnitOfMeasure, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="Commodity Selling UnitOfMeasure Number", Nillable=true, AverageLength=14, Name="sellingUnitOfMeasureNumber", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> sellingUnitOfMeasureNumber { get { return _sellingUnitOfMeasureNumber; } set { SetProperty(PropertysellingUnitOfMeasureNumber, ref _sellingUnitOfMeasureNumber, value); } }

		[SMEResource(CanGet=true, PluralName="unitsOfMeasure", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="packingUnitOfMeasure", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("packingUnitOfMeasure")]			
		public virtual unitOfMeasureFeedEntry packingUnitOfMeasure { get { return _packingUnitOfMeasure; } set { SetProperty(PropertypackingUnitOfMeasure, ref _packingUnitOfMeasure, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="Commodity Packing UnitOfMeasure Number", Nillable=true, AverageLength=14, Name="packingUnitOfMeasureNumber", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> packingUnitOfMeasureNumber { get { return _packingUnitOfMeasureNumber; } set { SetProperty(PropertypackingUnitOfMeasureNumber, ref _packingUnitOfMeasureNumber, value); } }

		[SMEStringProperty(Label="Commodity Catalogue Number", Name="catalogueNumber", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String catalogueNumber { get { return _catalogueNumber; } set { SetProperty(PropertycatalogueNumber, ref _catalogueNumber, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="tradingAccounts", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="supplierTradingAccount", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual tradingAccountFeed supplierTradingAccount { get { return _supplierTradingAccount; } set { SetProperty(PropertysupplierTradingAccount, ref _supplierTradingAccount, value); } }

		[SMEStringProperty(Label="Commodity Supplier reference", Name="supplierReference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String supplierReference { get { return _supplierReference; } set { SetProperty(PropertysupplierReference, ref _supplierReference, value); } }

		[SMEStringProperty(Label="Commodity Manufacturer Company", Name="manufacturerCompany", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String manufacturerCompany { get { return _manufacturerCompany; } set { SetProperty(PropertymanufacturerCompany, ref _manufacturerCompany, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Commodity Manufacturer reference", Name="manufacturerReference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String manufacturerReference { get { return _manufacturerReference; } set { SetProperty(PropertymanufacturerReference, ref _manufacturerReference, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Commodity Material", Name="material", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String material { get { return _material; } set { SetProperty(Propertymaterial, ref _material, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Commodity Country Of Origin", Name="countryOfOrigin", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String countryOfOrigin { get { return _countryOfOrigin; } set { SetProperty(PropertycountryOfOrigin, ref _countryOfOrigin, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="Commodity Weight", Nillable=true, AverageLength=14, Name="weight", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> weight { get { return _weight; } set { SetProperty(Propertyweight, ref _weight, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="Commodity Weight KG", Nillable=true, AverageLength=14, Name="weightKg", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> weightKg { get { return _weightKg; } set { SetProperty(PropertyweightKg, ref _weightKg, value); } }

		[SMEStringProperty(Label="Commodity Classification", Name="classification", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String classification { get { return _classification; } set { SetProperty(Propertyclassification, ref _classification, value); } }

		[SMEResource(CanGet=true, PluralName="taxCodes", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="taxCodes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual taxCodeFeed taxCodes { get { return _taxCodes; } set { SetProperty(PropertytaxCodes, ref _taxCodes, value); } }

		[SMEResource(CanGet=true, PluralName="financialAccounts", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="financialAccounts", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual financialAccountFeed financialAccounts { get { return _financialAccounts; } set { SetProperty(PropertyfinancialAccounts, ref _financialAccounts, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEBoolProperty(Label="Commodity Duty Applicable Flag", Nillable=true, Name="dutyApplicableFlag", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Boolean> dutyApplicableFlag { get { return _dutyApplicableFlag; } set { SetProperty(PropertydutyApplicableFlag, ref _dutyApplicableFlag, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="Commodity Duty Rate", Nillable=true, AverageLength=14, Name="dutyRate", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> dutyRate { get { return _dutyRate; } set { SetProperty(PropertydutyRate, ref _dutyRate, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Commodity Trade Identification Number", Name="tradeIdentificationNumber", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true, Unsupported=true)]			
		public virtual System.String tradeIdentificationNumber { get { return _tradeIdentificationNumber; } set { SetProperty(PropertytradeIdentificationNumber, ref _tradeIdentificationNumber, value); } }

		[SMEResource(CanGet=true, PluralName="commodities", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="replacement", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("replacement")]			
		public virtual commodityFeedEntry replacement { get { return _replacement; } set { SetProperty(Propertyreplacement, ref _replacement, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDateProperty(Label="Commodity Replacement Date", Nillable=true, Name="replacementDate", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.DateTime> replacementDate { get { return _replacementDate; } set { SetProperty(PropertyreplacementDate, ref _replacementDate, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="Commodity Lead Time", Nillable=true, AverageLength=14, Name="leadTime", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> leadTime { get { return _leadTime; } set { SetProperty(PropertyleadTime, ref _leadTime, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="Commodity Cost", Nillable=true, AverageLength=14, Name="cost", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> cost { get { return _cost; } set { SetProperty(Propertycost, ref _cost, value); } }

		[SMEResource(CanGet=true, PluralName="commodities", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Child, IsCollection=true, Name="associatedChildCommodities", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual commodityFeed associatedChildCommodities { get { return _associatedChildCommodities; } set { SetProperty(PropertyassociatedChildCommodities, ref _associatedChildCommodities, value); } }

		[SMEResource(CanGet=true, PluralName="commodities", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Parent, Name="associatedParentCommodity", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("associatedParentCommodity")]			
		public virtual commodityFeedEntry associatedParentCommodity { get { return _associatedParentCommodity; } set { SetProperty(PropertyassociatedParentCommodity, ref _associatedParentCommodity, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Commodity Version", Name="version", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String version { get { return _version; } set { SetProperty(Propertyversion, ref _version, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Commodity Commission Type", Name="commissionType", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String commissionType { get { return _commissionType; } set { SetProperty(PropertycommissionType, ref _commissionType, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="Commodity Commission Amount", Nillable=true, AverageLength=14, Name="commissionAmount", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> commissionAmount { get { return _commissionAmount; } set { SetProperty(PropertycommissionAmount, ref _commissionAmount, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="Commodity Commission Percent", Nillable=true, AverageLength=14, Name="commissionPercent", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> commissionPercent { get { return _commissionPercent; } set { SetProperty(PropertycommissionPercent, ref _commissionPercent, value); } }

		[SMEResource(CanGet=true, PluralName="interactions", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="interactions", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual interactionFeed interactions { get { return _interactions; } set { SetProperty(Propertyinteractions, ref _interactions, value); } }

		[SMEResource(CanGet=true, PluralName="Opportunities", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="opportunities", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual opportunityFeed opportunities { get { return _opportunities; } set { SetProperty(Propertyopportunities, ref _opportunities, value); } }

		[SMEResource(CanGet=true, CanDelete=true, PluralName="salesQuotationLines", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="salesQuotationLines", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesQuotationLineFeed salesQuotationLines { get { return _salesQuotationLines; } set { SetProperty(PropertysalesQuotationLines, ref _salesQuotationLines, value); } }

		[SMEResource(CanGet=true, CanPost=true, PluralName="salesOrderLines", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="salesOrderLines", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesOrderLineFeed salesOrderLines { get { return _salesOrderLines; } set { SetProperty(PropertysalesOrderLines, ref _salesOrderLines, value); } }

		[SMEResource(CanGet=true, PluralName="salesOrderDeliveryLines", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="salesOrderDeliveryLines", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesOrderDeliveryLineFeed salesOrderDeliveryLines { get { return _salesOrderDeliveryLines; } set { SetProperty(PropertysalesOrderDeliveryLines, ref _salesOrderDeliveryLines, value); } }

		[SMEResource(CanGet=true, CanDelete=true, PluralName="salesInvoiceLines", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="salesInvoiceLines", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesInvoiceLineFeed salesInvoiceLines { get { return _salesInvoiceLines; } set { SetProperty(PropertysalesInvoiceLines, ref _salesInvoiceLines, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="salesCreditLines", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="salesCreditLines", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesCreditLineFeed salesCreditLines { get { return _salesCreditLines; } set { SetProperty(PropertysalesCreditLines, ref _salesCreditLines, value); } }

		[SMEResource(CanGet=true, PluralName="purchaseOrderLines", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="purchaseOrderLines", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual purchaseOrderLineFeed purchaseOrderLines { get { return _purchaseOrderLines; } set { SetProperty(PropertypurchaseOrderLines, ref _purchaseOrderLines, value); } }

		[SMEResource(CanGet=true, PluralName="purchaseOrderDeliveryLines", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="purchaseOrderDeliveryLines", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual purchaseOrderDeliveryLineFeed purchaseOrderDeliveryLines { get { return _purchaseOrderDeliveryLines; } set { SetProperty(PropertypurchaseOrderDeliveryLines, ref _purchaseOrderDeliveryLines, value); } }

		[SMEResource(CanGet=true, PluralName="priceLists", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="pricelists", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual priceListFeed pricelists { get { return _pricelists; } set { SetProperty(Propertypricelists, ref _pricelists, value); } }

		[SMEResource(CanGet=true, PluralName="prices", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="prices", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual priceFeed prices { get { return _prices; } set { SetProperty(Propertyprices, ref _prices, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="Commodity Amount in Stock", Nillable=true, AverageLength=14, Name="inStock", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> inStock { get { return _inStock; } set { SetProperty(PropertyinStock, ref _inStock, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="Commodity Amount Allocated", Nillable=true, AverageLength=14, Name="allocated", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> allocated { get { return _allocated; } set { SetProperty(Propertyallocated, ref _allocated, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="Commodity Free Stock", Nillable=true, AverageLength=14, Name="freeStock", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> freeStock { get { return _freeStock; } set { SetProperty(PropertyfreeStock, ref _freeStock, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="Commodity Amount on Order", Nillable=true, AverageLength=14, Name="onOrder", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> onOrder { get { return _onOrder; } set { SetProperty(PropertyonOrder, ref _onOrder, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="Commodity Sales Price in base currency", Nillable=true, AverageLength=14, Name="salesPrice", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> salesPrice { get { return _salesPrice; } set { SetProperty(PropertysalesPrice, ref _salesPrice, value); } }

		#endregion


	}
}