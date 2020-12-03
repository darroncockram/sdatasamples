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
	/// Defines a computePriceRequest feed entry
	/// </summary>
	#endregion
	[System.ComponentModel.Browsable(false)]
	[XmlType("computePriceRequest", Namespace="http://schemas.sage.com/crmErp/2008")]
	public class computePriceRequestFeedEntrySchema : Sage.Common.Syndication.FeedEntry
	{
		#region Constants

		public const string PropertytradingAccount = "tradingAccount";
		public const string PropertypricingDocumentID = "pricingDocumentID";
		public const string PropertypricingDocumentType = "pricingDocumentType";
		public const string PropertypricingDocumentDate = "pricingDocumentDate";
		public const string PropertypricingDocumentStatus = "pricingDocumentStatus";
		public const string PropertypricingDocumentCurrency = "pricingDocumentCurrency";
		public const string PropertypricingList = "pricingList";
		public const string PropertypricingShippingAddress = "pricingShippingAddress";
		public const string PropertycarrierTradingAccount = "carrierTradingAccount";
		public const string PropertycarrierNetPrice = "carrierNetPrice";
		public const string PropertycarrierTaxPrice = "carrierTaxPrice";
		public const string PropertycarrierGrossPrice = "carrierGrossPrice";
		public const string PropertycarrierReference = "carrierReference";
		public const string PropertysalesPerson = "salesPerson";
		public const string Propertybuyer = "buyer";
		public const string PropertytaxCode = "taxCode";
		public const string PropertydoNotChangePrice = "doNotChangePrice";
		public const string PropertydiscountType = "discountType";
		public const string PropertydiscountAmount = "discountAmount";
		public const string PropertydiscountPercent = "discountPercent";
		public const string PropertysettlementDiscountType = "settlementDiscountType";
		public const string PropertysettlementDiscountPercent = "settlementDiscountPercent";
		public const string PropertyadditionalDiscount1Type = "additionalDiscount1Type";
		public const string PropertyadditionalDiscount1Amount = "additionalDiscount1Amount";
		public const string PropertyadditionalDiscount1Percent = "additionalDiscount1Percent";
		public const string PropertyadditionalDiscount2Type = "additionalDiscount2Type";
		public const string PropertyadditionalDiscount2Amount = "additionalDiscount2Amount";
		public const string PropertyadditionalDiscount2Percent = "additionalDiscount2Percent";
		public const string PropertynetTotal = "netTotal";
		public const string PropertydiscountTotal = "discountTotal";
		public const string PropertytaxTotal = "taxTotal";
		public const string PropertygrossTotal = "grossTotal";
		public const string PropertycostTotal = "costTotal";
		public const string PropertyprofitTotal = "profitTotal";
		public const string PropertyadditionalText = "additionalText";
		public const string PropertypricingDocumentLines = "pricingDocumentLines";

		#endregion

		#region Fields

		private tradingAccountFeedEntry _tradingAccount;
		private string _pricingDocumentID;
		private System.String _pricingDocumentType;
		private System.String _pricingDocumentDate;
		private System.String _pricingDocumentStatus;
		private System.String _pricingDocumentCurrency;
		private priceListFeed _pricingList;
		private postalAddressFeed _pricingShippingAddress;
		private tradingAccountFeedEntry _carrierTradingAccount;
		private priceFeedEntry _carrierNetPrice;
		private priceFeedEntry _carrierTaxPrice;
		private priceFeedEntry _carrierGrossPrice;
		private System.String _carrierReference;
		private salesPersonFeedEntry _salesPerson;
		private System.String _buyer;
		private taxCodeFeedEntry _taxCode;
		private System.String _doNotChangePrice;
		private System.String _discountType;
		private Nullable<System.Decimal> _discountAmount;
		private Nullable<System.Decimal> _discountPercent;
		private System.String _settlementDiscountType;
		private Nullable<System.Decimal> _settlementDiscountPercent;
		private System.String _additionalDiscount1Type;
		private Nullable<System.Decimal> _additionalDiscount1Amount;
		private Nullable<System.Decimal> _additionalDiscount1Percent;
		private System.String _additionalDiscount2Type;
		private Nullable<System.Decimal> _additionalDiscount2Amount;
		private Nullable<System.Decimal> _additionalDiscount2Percent;
		private Nullable<System.Decimal> _netTotal;
		private Nullable<System.Decimal> _discountTotal;
		private Nullable<System.Decimal> _taxTotal;
		private Nullable<System.Decimal> _grossTotal;
		private Nullable<System.Decimal> _costTotal;
		private Nullable<System.Decimal> _profitTotal;
		private System.String _additionalText;
		private pricingDocumentLineFeed _pricingDocumentLines;

		#endregion

		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="computePriceRequestFeedEntrySchema"/> class.
		/// </summary>
		#endregion
		public computePriceRequestFeedEntrySchema()
		{
		}

		#region Properties


		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="tradingAccounts", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="tradingAccount", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("tradingAccount")]			
		public virtual tradingAccountFeedEntry tradingAccount { get { return _tradingAccount; } set { SetProperty(PropertytradingAccount, ref _tradingAccount, value); } }

		[SMEEnumProperty(EnumTypeName="computePrice-pricingDocumentID--type", Label="Pricing Document ID", Pattern="[0-9a-fA-F-]+", Name="pricingDocumentID", Namespace="http://schemas.sage.com/crmErp/2008", IsUniqueKey=true)]			
		public virtual string pricingDocumentID { get { return _pricingDocumentID; } set { SetProperty(PropertypricingDocumentID, ref _pricingDocumentID, value); } }

		[SMEStringProperty(Label="Pricing Document Type", Name="pricingDocumentType", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String pricingDocumentType { get { return _pricingDocumentType; } set { SetProperty(PropertypricingDocumentType, ref _pricingDocumentType, value); } }

		[SMEStringProperty(Label="Pricing Document Date", Nillable=true, Name="pricingDocumentDate", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String pricingDocumentDate { get { return _pricingDocumentDate; } set { SetProperty(PropertypricingDocumentDate, ref _pricingDocumentDate, value); } }

		[SMEStringProperty(Label="Pricing Document Status", Name="pricingDocumentStatus", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String pricingDocumentStatus { get { return _pricingDocumentStatus; } set { SetProperty(PropertypricingDocumentStatus, ref _pricingDocumentStatus, value); } }

		[SMEStringProperty(Label="Pricing Document Currency", Name="pricingDocumentCurrency", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String pricingDocumentCurrency { get { return _pricingDocumentCurrency; } set { SetProperty(PropertypricingDocumentCurrency, ref _pricingDocumentCurrency, value); } }

		[SMEResource(CanGet=true, PluralName="priceLists", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="pricingList", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual priceListFeed pricingList { get { return _pricingList; } set { SetProperty(PropertypricingList, ref _pricingList, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="postalAddresses", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="pricingShippingAddress", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual postalAddressFeed pricingShippingAddress { get { return _pricingShippingAddress; } set { SetProperty(PropertypricingShippingAddress, ref _pricingShippingAddress, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="tradingAccounts", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="carrierTradingAccount", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("carrierTradingAccount")]			
		public virtual tradingAccountFeedEntry carrierTradingAccount { get { return _carrierTradingAccount; } set { SetProperty(PropertycarrierTradingAccount, ref _carrierTradingAccount, value); } }

		[SMEResource(CanGet=true, PluralName="prices", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, Name="carrierNetPrice", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("carrierNetPrice")]			
		public virtual priceFeedEntry carrierNetPrice { get { return _carrierNetPrice; } set { SetProperty(PropertycarrierNetPrice, ref _carrierNetPrice, value); } }

		[SMEResource(CanGet=true, PluralName="prices", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, Name="carrierTaxPrice", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("carrierTaxPrice")]			
		public virtual priceFeedEntry carrierTaxPrice { get { return _carrierTaxPrice; } set { SetProperty(PropertycarrierTaxPrice, ref _carrierTaxPrice, value); } }

		[SMEResource(CanGet=true, PluralName="prices", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, Name="carrierGrossPrice", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("carrierGrossPrice")]			
		public virtual priceFeedEntry carrierGrossPrice { get { return _carrierGrossPrice; } set { SetProperty(PropertycarrierGrossPrice, ref _carrierGrossPrice, value); } }

		[SMEStringProperty(Label="Carrier Reference", Name="carrierReference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String carrierReference { get { return _carrierReference; } set { SetProperty(PropertycarrierReference, ref _carrierReference, value); } }

		[SMEResource(CanGet=true, PluralName="salesPersons", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="salesPerson", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("salesPerson")]			
		public virtual salesPersonFeedEntry salesPerson { get { return _salesPerson; } set { SetProperty(PropertysalesPerson, ref _salesPerson, value); } }

		[SMEStringProperty(Label="Buyer Contact", Name="buyer", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String buyer { get { return _buyer; } set { SetProperty(Propertybuyer, ref _buyer, value); } }

		[SMEResource(CanGet=true, PluralName="taxCodes", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="taxCode", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("taxCode")]			
		public virtual taxCodeFeedEntry taxCode { get { return _taxCode; } set { SetProperty(PropertytaxCode, ref _taxCode, value); } }

		[SMEStringProperty(Label="Do Not Change Price", Name="doNotChangePrice", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String doNotChangePrice { get { return _doNotChangePrice; } set { SetProperty(PropertydoNotChangePrice, ref _doNotChangePrice, value); } }

		[SMEStringProperty(Label="Discount Type", Name="discountType", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String discountType { get { return _discountType; } set { SetProperty(PropertydiscountType, ref _discountType, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="Discount Amount", Nillable=true, AverageLength=14, Name="discountAmount", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> discountAmount { get { return _discountAmount; } set { SetProperty(PropertydiscountAmount, ref _discountAmount, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="Discount Percent", Nillable=true, AverageLength=14, Name="discountPercent", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> discountPercent { get { return _discountPercent; } set { SetProperty(PropertydiscountPercent, ref _discountPercent, value); } }

		[SMEStringProperty(Label="Settlement Discount Type", Name="settlementDiscountType", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String settlementDiscountType { get { return _settlementDiscountType; } set { SetProperty(PropertysettlementDiscountType, ref _settlementDiscountType, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="Settlement Discount Percent", Nillable=true, AverageLength=14, Name="settlementDiscountPercent", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> settlementDiscountPercent { get { return _settlementDiscountPercent; } set { SetProperty(PropertysettlementDiscountPercent, ref _settlementDiscountPercent, value); } }

		[SMEStringProperty(Label="Order Additional Discount1 Type", Name="additionalDiscount1Type", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String additionalDiscount1Type { get { return _additionalDiscount1Type; } set { SetProperty(PropertyadditionalDiscount1Type, ref _additionalDiscount1Type, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="Order Additional Discount1 Amount", Nillable=true, AverageLength=14, Name="additionalDiscount1Amount", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> additionalDiscount1Amount { get { return _additionalDiscount1Amount; } set { SetProperty(PropertyadditionalDiscount1Amount, ref _additionalDiscount1Amount, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="Order Additional Discount1 Percent", Nillable=true, AverageLength=14, Name="additionalDiscount1Percent", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> additionalDiscount1Percent { get { return _additionalDiscount1Percent; } set { SetProperty(PropertyadditionalDiscount1Percent, ref _additionalDiscount1Percent, value); } }

		[SMEStringProperty(Label="Order Additional Discount2 Type", Name="additionalDiscount2Type", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String additionalDiscount2Type { get { return _additionalDiscount2Type; } set { SetProperty(PropertyadditionalDiscount2Type, ref _additionalDiscount2Type, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="Order Additional Discount2 Amount", Nillable=true, AverageLength=14, Name="additionalDiscount2Amount", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> additionalDiscount2Amount { get { return _additionalDiscount2Amount; } set { SetProperty(PropertyadditionalDiscount2Amount, ref _additionalDiscount2Amount, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="Order Additional Discount2 Percent", Nillable=true, AverageLength=14, Name="additionalDiscount2Percent", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> additionalDiscount2Percent { get { return _additionalDiscount2Percent; } set { SetProperty(PropertyadditionalDiscount2Percent, ref _additionalDiscount2Percent, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="Net Total", Nillable=true, AverageLength=14, Name="netTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> netTotal { get { return _netTotal; } set { SetProperty(PropertynetTotal, ref _netTotal, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="Discount Total", Nillable=true, AverageLength=14, Name="discountTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> discountTotal { get { return _discountTotal; } set { SetProperty(PropertydiscountTotal, ref _discountTotal, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="Tax Total", Nillable=true, AverageLength=14, Name="taxTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> taxTotal { get { return _taxTotal; } set { SetProperty(PropertytaxTotal, ref _taxTotal, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="Gross Total", Nillable=true, AverageLength=14, Name="grossTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> grossTotal { get { return _grossTotal; } set { SetProperty(PropertygrossTotal, ref _grossTotal, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="Cost Total", Nillable=true, AverageLength=14, Name="costTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> costTotal { get { return _costTotal; } set { SetProperty(PropertycostTotal, ref _costTotal, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="Profit Total", Nillable=true, AverageLength=14, Name="profitTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> profitTotal { get { return _profitTotal; } set { SetProperty(PropertyprofitTotal, ref _profitTotal, value); } }

		[SMEStringProperty(Label="Additional Text", Name="additionalText", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String additionalText { get { return _additionalText; } set { SetProperty(PropertyadditionalText, ref _additionalText, value); } }

		[SMEResource(CanGet=true, CanPut=true, PluralName="pricingDocumentLine", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Child, IsCollection=true, Name="pricingDocumentLines", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual pricingDocumentLineFeed pricingDocumentLines { get { return _pricingDocumentLines; } set { SetProperty(PropertypricingDocumentLines, ref _pricingDocumentLines, value); } }

		#endregion


	}
}