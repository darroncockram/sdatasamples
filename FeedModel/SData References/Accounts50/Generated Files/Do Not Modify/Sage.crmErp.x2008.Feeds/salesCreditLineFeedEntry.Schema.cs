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
	/// Defines a salesCreditLine feed entry
	/// </summary>
	#endregion
	[System.ComponentModel.Browsable(false)]
	[XmlType("salesCreditLine", Namespace="http://schemas.sage.com/crmErp/2008")]
	public class salesCreditLineFeedEntrySchema : Sage.Common.Syndication.FeedEntry
	{
		#region Constants

		public const string PropertyoriginatorDocumentLine = "originatorDocumentLine";
		public const string Propertyactive = "active";
		public const string Propertyreference = "reference";
		public const string Propertyreference2 = "reference2";
		public const string Propertystatus = "status";
		public const string Propertytype = "type";
		public const string Propertynumber = "number";
		public const string Propertycommodity = "commodity";
		public const string Propertytext = "text";
		public const string PropertydeliveryTerms = "deliveryTerms";
		public const string PropertydeliveryDate = "deliveryDate";
		public const string PropertycarrierTradingAccount = "carrierTradingAccount";
		public const string PropertycarrierNetPrice = "carrierNetPrice";
		public const string PropertycarrierTaxPrice = "carrierTaxPrice";
		public const string PropertycarrierTotalPrice = "carrierTotalPrice";
		public const string PropertycarrierSalesInvoiceLine = "carrierSalesInvoiceLine";
		public const string PropertycarrierTaxCodes = "carrierTaxCodes";
		public const string PropertycarrierReference = "carrierReference";
		public const string PropertyunitOfMeasure = "unitOfMeasure";
		public const string Propertyquantity = "quantity";
		public const string PropertyinitialPrice = "initialPrice";
		public const string Propertypricelist = "pricelist";
		public const string PropertysettlementDiscountType = "settlementDiscountType";
		public const string PropertysettlementDiscountAmount = "settlementDiscountAmount";
		public const string PropertysettlementDiscountPercent = "settlementDiscountPercent";
		public const string PropertysettlementDiscountTerms = "settlementDiscountTerms";
		public const string PropertyinvoiceLineDiscountType = "invoiceLineDiscountType";
		public const string PropertyinvoiceLineDiscountAmount = "invoiceLineDiscountAmount";
		public const string PropertyinvoiceLineDiscountPercent = "invoiceLineDiscountPercent";
		public const string PropertyinvoiceLineSubtotalDiscountType = "invoiceLineSubtotalDiscountType";
		public const string PropertyinvoiceLineSubtotalDiscountAmount = "invoiceLineSubtotalDiscountAmount";
		public const string PropertyinvoiceLineSubtotalDiscountPercent = "invoiceLineSubtotalDiscountPercent";
		public const string PropertyactualPrice = "actualPrice";
		public const string PropertynetTotal = "netTotal";
		public const string PropertychargesTotal = "chargesTotal";
		public const string PropertydiscountTotal = "discountTotal";
		public const string PropertytaxCodes = "taxCodes";
		public const string PropertypriceTax = "priceTax";
		public const string PropertytaxTotal = "taxTotal";
		public const string PropertygrossTotal = "grossTotal";
		public const string PropertycostTotal = "costTotal";
		public const string Propertyproject = "project";
		public const string PropertyfinancialAccounts = "financialAccounts";
		public const string Propertynotes = "notes";

		#endregion

		#region Fields

		private salesOrderLineFeedEntry _originatorDocumentLine;
		private Nullable<System.Boolean> _active;
		private System.String _reference;
		private System.String _reference2;
		private System.String _status;
		private System.String _type;
		private Nullable<System.Decimal> _number;
		private commodityFeedEntry _commodity;
		private System.String _text;
		private System.String _deliveryTerms;
		private Nullable<System.DateTime> _deliveryDate;
		private tradingAccountFeedEntry _carrierTradingAccount;
		private Nullable<System.Decimal> _carrierNetPrice;
		private Nullable<System.Decimal> _carrierTaxPrice;
		private Nullable<System.Decimal> _carrierTotalPrice;
		private salesInvoiceLineFeedEntry _carrierSalesInvoiceLine;
		private taxCodeFeed _carrierTaxCodes;
		private System.String _carrierReference;
		private unitOfMeasureFeedEntry _unitOfMeasure;
		private Nullable<System.Decimal> _quantity;
		private Nullable<System.Decimal> _initialPrice;
		private priceListFeedEntry _pricelist;
		private System.String _settlementDiscountType;
		private Nullable<System.Decimal> _settlementDiscountAmount;
		private Nullable<System.Decimal> _settlementDiscountPercent;
		private System.String _settlementDiscountTerms;
		private System.String _invoiceLineDiscountType;
		private Nullable<System.Decimal> _invoiceLineDiscountAmount;
		private Nullable<System.Decimal> _invoiceLineDiscountPercent;
		private System.String _invoiceLineSubtotalDiscountType;
		private Nullable<System.Decimal> _invoiceLineSubtotalDiscountAmount;
		private Nullable<System.Decimal> _invoiceLineSubtotalDiscountPercent;
		private Nullable<System.Decimal> _actualPrice;
		private Nullable<System.Decimal> _netTotal;
		private Nullable<System.Decimal> _chargesTotal;
		private Nullable<System.Decimal> _discountTotal;
		private taxCodeFeed _taxCodes;
		private Nullable<System.Decimal> _priceTax;
		private Nullable<System.Decimal> _taxTotal;
		private Nullable<System.Decimal> _grossTotal;
		private Nullable<System.Decimal> _costTotal;
		private projectFeedEntry _project;
		private financialAccountFeed _financialAccounts;
		private noteFeed _notes;

		#endregion

		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="salesCreditLineFeedEntrySchema"/> class.
		/// </summary>
		#endregion
		public salesCreditLineFeedEntrySchema()
		{
		}

		#region Properties


		[SMEResource(CanGet=true, CanPost=true, PluralName="salesOrderLines", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="originatorDocumentLine", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("originatorDocumentLine")]			
		public virtual salesOrderLineFeedEntry originatorDocumentLine { get { return _originatorDocumentLine; } set { SetProperty(PropertyoriginatorDocumentLine, ref _originatorDocumentLine, value); } }

		[SMEBoolProperty(Label="SalesCreditLine Active Flag", Nillable=true, Name="active", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.Boolean> active { get { return _active; } set { SetProperty(Propertyactive, ref _active, value); } }

		[SMEStringProperty(Label="SalesCreditLine reference", Name="reference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true, IsUniqueKey=true)]			
		public virtual System.String reference { get { return _reference; } set { SetProperty(Propertyreference, ref _reference, value); } }

		[SMEStringProperty(Label="SalesCreditLine Reference2", Name="reference2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String reference2 { get { return _reference2; } set { SetProperty(Propertyreference2, ref _reference2, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="SalesCreditLine Status", Name="status", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String status { get { return _status; } set { SetProperty(Propertystatus, ref _status, value); } }

		[SMEStringProperty(Label="SalesCreditLine Type", Name="type", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true, IsMandatory=true)]			
		public virtual System.String type { get { return _type; } set { SetProperty(Propertytype, ref _type, value); } }

		[SMEDecimalProperty(DecimalPlaces=0, Label="SalesCreditLine Number", Nillable=true, AverageLength=12, Name="number", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> number { get { return _number; } set { SetProperty(Propertynumber, ref _number, value); } }

		[SMEResource(CanGet=true, PluralName="commodities", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="commodity", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("commodity")]			
		public virtual commodityFeedEntry commodity { get { return _commodity; } set { SetProperty(Propertycommodity, ref _commodity, value); } }

		[SMEStringProperty(Label="SalesCreditLine Text", Name="text", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String text { get { return _text; } set { SetProperty(Propertytext, ref _text, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="SalesCreditLine Delivery Terms", Name="deliveryTerms", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String deliveryTerms { get { return _deliveryTerms; } set { SetProperty(PropertydeliveryTerms, ref _deliveryTerms, value); } }

		[SMEDateProperty(Label="SalesCreditLine Delivery Date", Nillable=true, Name="deliveryDate", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.DateTime> deliveryDate { get { return _deliveryDate; } set { SetProperty(PropertydeliveryDate, ref _deliveryDate, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="tradingAccounts", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="carrierTradingAccount", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("carrierTradingAccount")]			
		public virtual tradingAccountFeedEntry carrierTradingAccount { get { return _carrierTradingAccount; } set { SetProperty(PropertycarrierTradingAccount, ref _carrierTradingAccount, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesCreditLine Carrier Net Price", Nillable=true, AverageLength=14, Name="carrierNetPrice", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> carrierNetPrice { get { return _carrierNetPrice; } set { SetProperty(PropertycarrierNetPrice, ref _carrierNetPrice, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesCreditLine Carrier Tax Price", Nillable=true, AverageLength=14, Name="carrierTaxPrice", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> carrierTaxPrice { get { return _carrierTaxPrice; } set { SetProperty(PropertycarrierTaxPrice, ref _carrierTaxPrice, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesCreditLine Carrier Gross Price", Nillable=true, AverageLength=14, Name="carrierTotalPrice", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> carrierTotalPrice { get { return _carrierTotalPrice; } set { SetProperty(PropertycarrierTotalPrice, ref _carrierTotalPrice, value); } }

		[SMEResource(CanGet=true, CanDelete=true, PluralName="salesInvoiceLines", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="carrierSalesInvoiceLine", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("carrierSalesInvoiceLine")]			
		public virtual salesInvoiceLineFeedEntry carrierSalesInvoiceLine { get { return _carrierSalesInvoiceLine; } set { SetProperty(PropertycarrierSalesInvoiceLine, ref _carrierSalesInvoiceLine, value); } }

		[SMEResource(CanGet=true, PluralName="taxCodes", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="carrierTaxCodes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual taxCodeFeed carrierTaxCodes { get { return _carrierTaxCodes; } set { SetProperty(PropertycarrierTaxCodes, ref _carrierTaxCodes, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="SalesCreditLine Carrier reference", Name="carrierReference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String carrierReference { get { return _carrierReference; } set { SetProperty(PropertycarrierReference, ref _carrierReference, value); } }

		[SMEResource(CanGet=true, PluralName="unitsOfMeasure", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="unitOfMeasure", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("unitOfMeasure")]			
		public virtual unitOfMeasureFeedEntry unitOfMeasure { get { return _unitOfMeasure; } set { SetProperty(PropertyunitOfMeasure, ref _unitOfMeasure, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesCreditLine Quantity", Nillable=true, AverageLength=14, Name="quantity", Namespace="http://schemas.sage.com/crmErp/2008", IsMandatory=true)]			
		public virtual Nullable<System.Decimal> quantity { get { return _quantity; } set { SetProperty(Propertyquantity, ref _quantity, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesCreditLine Initial Price", Nillable=true, AverageLength=14, Name="initialPrice", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> initialPrice { get { return _initialPrice; } set { SetProperty(PropertyinitialPrice, ref _initialPrice, value); } }

		[SMEResource(CanGet=true, PluralName="priceLists", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="pricelist", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("pricelist")]			
		public virtual priceListFeedEntry pricelist { get { return _pricelist; } set { SetProperty(Propertypricelist, ref _pricelist, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="SalesCreditLine Settlement Discount Type", Name="settlementDiscountType", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String settlementDiscountType { get { return _settlementDiscountType; } set { SetProperty(PropertysettlementDiscountType, ref _settlementDiscountType, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesCreditLine Settlement Discount Amount", Nillable=true, AverageLength=14, Name="settlementDiscountAmount", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> settlementDiscountAmount { get { return _settlementDiscountAmount; } set { SetProperty(PropertysettlementDiscountAmount, ref _settlementDiscountAmount, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesCreditLine Settlement Discount Percent", Nillable=true, AverageLength=14, Name="settlementDiscountPercent", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> settlementDiscountPercent { get { return _settlementDiscountPercent; } set { SetProperty(PropertysettlementDiscountPercent, ref _settlementDiscountPercent, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="SalesCreditLine Settlement Discount Terms", Name="settlementDiscountTerms", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String settlementDiscountTerms { get { return _settlementDiscountTerms; } set { SetProperty(PropertysettlementDiscountTerms, ref _settlementDiscountTerms, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="SalesCreditLine Invoice Line Discount Type", Name="invoiceLineDiscountType", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String invoiceLineDiscountType { get { return _invoiceLineDiscountType; } set { SetProperty(PropertyinvoiceLineDiscountType, ref _invoiceLineDiscountType, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesCreditLine Invoice Line Discount Amount", Nillable=true, AverageLength=14, Name="invoiceLineDiscountAmount", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> invoiceLineDiscountAmount { get { return _invoiceLineDiscountAmount; } set { SetProperty(PropertyinvoiceLineDiscountAmount, ref _invoiceLineDiscountAmount, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesCreditLine Invoice Line Discount Percent", Nillable=true, AverageLength=14, Name="invoiceLineDiscountPercent", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> invoiceLineDiscountPercent { get { return _invoiceLineDiscountPercent; } set { SetProperty(PropertyinvoiceLineDiscountPercent, ref _invoiceLineDiscountPercent, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="SalesCreditLine Invoice Line Subtotal Discount Type", Name="invoiceLineSubtotalDiscountType", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String invoiceLineSubtotalDiscountType { get { return _invoiceLineSubtotalDiscountType; } set { SetProperty(PropertyinvoiceLineSubtotalDiscountType, ref _invoiceLineSubtotalDiscountType, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesCreditLine Invoice Line Subtotal Discount Amount", Nillable=true, AverageLength=14, Name="invoiceLineSubtotalDiscountAmount", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> invoiceLineSubtotalDiscountAmount { get { return _invoiceLineSubtotalDiscountAmount; } set { SetProperty(PropertyinvoiceLineSubtotalDiscountAmount, ref _invoiceLineSubtotalDiscountAmount, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesCreditLine Invoice Line Subtotal Discount Percent", Nillable=true, AverageLength=14, Name="invoiceLineSubtotalDiscountPercent", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> invoiceLineSubtotalDiscountPercent { get { return _invoiceLineSubtotalDiscountPercent; } set { SetProperty(PropertyinvoiceLineSubtotalDiscountPercent, ref _invoiceLineSubtotalDiscountPercent, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesCreditLine Actual Price", Nillable=true, AverageLength=14, Name="actualPrice", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> actualPrice { get { return _actualPrice; } set { SetProperty(PropertyactualPrice, ref _actualPrice, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesCreditLine Net Total", Nillable=true, AverageLength=14, Name="netTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> netTotal { get { return _netTotal; } set { SetProperty(PropertynetTotal, ref _netTotal, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesCreditLine Charges Total", Nillable=true, AverageLength=14, Name="chargesTotal", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> chargesTotal { get { return _chargesTotal; } set { SetProperty(PropertychargesTotal, ref _chargesTotal, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesCreditLine Discount Total", Nillable=true, AverageLength=14, Name="discountTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> discountTotal { get { return _discountTotal; } set { SetProperty(PropertydiscountTotal, ref _discountTotal, value); } }

		[SMEResource(CanGet=true, PluralName="taxCodes", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="taxCodes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual taxCodeFeed taxCodes { get { return _taxCodes; } set { SetProperty(PropertytaxCodes, ref _taxCodes, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesCreditLine Price Tax", Nillable=true, AverageLength=14, Name="priceTax", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> priceTax { get { return _priceTax; } set { SetProperty(PropertypriceTax, ref _priceTax, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesCreditLine Tax Total", Nillable=true, AverageLength=14, Name="taxTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> taxTotal { get { return _taxTotal; } set { SetProperty(PropertytaxTotal, ref _taxTotal, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesCreditLine Gross Total", Nillable=true, AverageLength=14, Name="grossTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> grossTotal { get { return _grossTotal; } set { SetProperty(PropertygrossTotal, ref _grossTotal, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="SalesCreditLine Cost Total", Nillable=true, AverageLength=14, Name="costTotal", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> costTotal { get { return _costTotal; } set { SetProperty(PropertycostTotal, ref _costTotal, value); } }

		[SMEResource(CanGet=true, PluralName="projects", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="project", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("project")]			
		public virtual projectFeedEntry project { get { return _project; } set { SetProperty(Propertyproject, ref _project, value); } }

		[SMEResource(CanGet=true, PluralName="financialAccounts", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="financialAccounts", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual financialAccountFeed financialAccounts { get { return _financialAccounts; } set { SetProperty(PropertyfinancialAccounts, ref _financialAccounts, value); } }

		[SMEResource(CanGet=true, CanPut=true, PluralName="notes", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="notes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual noteFeed notes { get { return _notes; } set { SetProperty(Propertynotes, ref _notes, value); } }

		#endregion


	}
}