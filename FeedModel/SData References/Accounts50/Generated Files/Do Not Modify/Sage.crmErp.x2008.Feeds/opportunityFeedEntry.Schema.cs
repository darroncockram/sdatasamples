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
	/// Defines a opportunity feed entry
	/// </summary>
	#endregion
	[System.ComponentModel.Browsable(false)]
	[XmlType("opportunity", Namespace="http://schemas.sage.com/crmErp/2008")]
	public class opportunityFeedEntrySchema : Sage.Common.Syndication.FeedEntry
	{
		#region Constants

		public const string Propertyactive = "active";
		public const string Propertystatus = "status";
		public const string PropertystatusFlag = "statusFlag";
		public const string PropertystatusFlagText = "statusFlagText";
		public const string Propertyreference = "reference";
		public const string Propertyname = "name";
		public const string Propertydescription = "description";
		public const string PropertycompanyReference = "companyReference";
		public const string PropertycustomerReference = "customerReference";
		public const string PropertycustomerTradingAccount = "customerTradingAccount";
		public const string PropertytradingAccountReference = "tradingAccountReference";
		public const string Propertycommodities = "commodities";
		public const string Propertytext = "text";
		public const string Propertycurrency = "currency";
		public const string PropertyoperatingCompanyCurrency = "operatingCompanyCurrency";
		public const string PropertyoperatingCompanyCurrencyExchangeRate = "operatingCompanyCurrencyExchangeRate";
		public const string PropertyoperatingCompanyCurrencyExchangeRateOperator = "operatingCompanyCurrencyExchangeRateOperator";
		public const string PropertyoperatingCompanyCurrencyExchangeRateDate = "operatingCompanyCurrencyExchangeRateDate";
		public const string Propertycontacts = "contacts";
		public const string Propertysource = "source";
		public const string Propertysalesperson = "salesperson";
		public const string Propertydate = "date";
		public const string PropertycloseDate = "closeDate";
		public const string PropertyopenDays = "openDays";
		public const string Propertypriority = "priority";
		public const string PropertyprobabilityIndicatorType = "probabilityIndicatorType";
		public const string PropertyprobabilityIndicatorstring = "probabilityIndicatorstring";
		public const string PropertyprobabilityIndicatorPercent = "probabilityIndicatorPercent";
		public const string PropertyworkflowIndicator1 = "workflowIndicator1";
		public const string PropertyworkflowIndicator2 = "workflowIndicator2";
		public const string PropertynetTotal = "netTotal";
		public const string PropertydiscountTotal = "discountTotal";
		public const string PropertychargesTotal = "chargesTotal";
		public const string PropertytaxTotal = "taxTotal";
		public const string PropertygrossTotal = "grossTotal";
		public const string PropertycostTotal = "costTotal";
		public const string PropertyprofitTotal = "profitTotal";
		public const string PropertyquotationNetTotal = "quotationNetTotal";
		public const string PropertyquotationDiscountTotal = "quotationDiscountTotal";
		public const string PropertyquotationChargesTotal = "quotationChargesTotal";
		public const string PropertyquotationTaxTotal = "quotationTaxTotal";
		public const string PropertyquotationGrossTotal = "quotationGrossTotal";
		public const string PropertyquotationCostTotal = "quotationCostTotal";
		public const string PropertyquotationProfitTotal = "quotationProfitTotal";
		public const string PropertysalesQuotations = "salesQuotations";
		public const string PropertyorderNetTotal = "orderNetTotal";
		public const string PropertyorderDiscountTotal = "orderDiscountTotal";
		public const string PropertyorderChargesTotal = "orderChargesTotal";
		public const string PropertyorderTaxTotal = "orderTaxTotal";
		public const string PropertyorderGrossTotal = "orderGrossTotal";
		public const string PropertyorderCostTotal = "orderCostTotal";
		public const string PropertyorderProfitTotal = "orderProfitTotal";
		public const string PropertysalesOrders = "salesOrders";
		public const string Propertyinteractions = "interactions";
		public const string PropertyprivacyFlag = "privacyFlag";
		public const string Propertynotes = "notes";

		#endregion

		#region Fields

		private Nullable<System.Boolean> _active;
		private System.String _status;
		private Nullable<System.Boolean> _statusFlag;
		private System.String _statusFlagText;
		private System.String _reference;
		private System.String _name;
		private System.String _description;
		private System.String _companyReference;
		private System.String _customerReference;
		private tradingAccountFeedEntry _customerTradingAccount;
		private System.String _tradingAccountReference;
		private commodityFeed _commodities;
		private System.String _text;
		private System.String _currency;
		private System.String _operatingCompanyCurrency;
		private Nullable<System.Decimal> _operatingCompanyCurrencyExchangeRate;
		private System.String _operatingCompanyCurrencyExchangeRateOperator;
		private Nullable<System.DateTime> _operatingCompanyCurrencyExchangeRateDate;
		private contactFeed _contacts;
		private System.String _source;
		private salesPersonFeed _salesperson;
		private Nullable<System.DateTime> _date;
		private Nullable<System.DateTime> _closeDate;
		private System.String _openDays;
		private System.String _priority;
		private System.String _probabilityIndicatorType;
		private System.String _probabilityIndicatorstring;
		private Nullable<System.Decimal> _probabilityIndicatorPercent;
		private System.String _workflowIndicator1;
		private System.String _workflowIndicator2;
		private Nullable<System.Decimal> _netTotal;
		private Nullable<System.Decimal> _discountTotal;
		private Nullable<System.Decimal> _chargesTotal;
		private Nullable<System.Decimal> _taxTotal;
		private Nullable<System.Decimal> _grossTotal;
		private Nullable<System.Decimal> _costTotal;
		private Nullable<System.Decimal> _profitTotal;
		private Nullable<System.Decimal> _quotationNetTotal;
		private Nullable<System.Decimal> _quotationDiscountTotal;
		private Nullable<System.Decimal> _quotationChargesTotal;
		private Nullable<System.Decimal> _quotationTaxTotal;
		private Nullable<System.Decimal> _quotationGrossTotal;
		private Nullable<System.Decimal> _quotationCostTotal;
		private Nullable<System.Decimal> _quotationProfitTotal;
		private salesQuotationFeed _salesQuotations;
		private Nullable<System.Decimal> _orderNetTotal;
		private Nullable<System.Decimal> _orderDiscountTotal;
		private Nullable<System.Decimal> _orderChargesTotal;
		private Nullable<System.Decimal> _orderTaxTotal;
		private Nullable<System.Decimal> _orderGrossTotal;
		private Nullable<System.Decimal> _orderCostTotal;
		private Nullable<System.Decimal> _orderProfitTotal;
		private salesOrderFeed _salesOrders;
		private interactionFeed _interactions;
		private Nullable<System.Boolean> _privacyFlag;
		private noteFeedEntry _notes;

		#endregion

		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="opportunityFeedEntrySchema"/> class.
		/// </summary>
		#endregion
		public opportunityFeedEntrySchema()
		{
		}

		#region Properties

		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEBoolProperty(Label="Opportunity Active Flag", Nillable=true, Name="active", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Boolean> active { get { return _active; } set { SetProperty(Propertyactive, ref _active, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Opportunity Status", Name="status", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String status { get { return _status; } set { SetProperty(Propertystatus, ref _status, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEBoolProperty(Label="Opportunity Status Flag", Nillable=true, Name="statusFlag", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Boolean> statusFlag { get { return _statusFlag; } set { SetProperty(PropertystatusFlag, ref _statusFlag, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Opportunity Status Flag Text", Name="statusFlagText", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String statusFlagText { get { return _statusFlagText; } set { SetProperty(PropertystatusFlagText, ref _statusFlagText, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Opportunity reference", Name="reference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", IsUniqueKey=true, Unsupported=true)]			
		public virtual System.String reference { get { return _reference; } set { SetProperty(Propertyreference, ref _reference, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Opportunity Name", Name="name", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String name { get { return _name; } set { SetProperty(Propertyname, ref _name, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Opportunity Description", Name="description", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String description { get { return _description; } set { SetProperty(Propertydescription, ref _description, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Opportunity Company reference", Name="companyReference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String companyReference { get { return _companyReference; } set { SetProperty(PropertycompanyReference, ref _companyReference, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Opportunity Customer reference", Name="customerReference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String customerReference { get { return _customerReference; } set { SetProperty(PropertycustomerReference, ref _customerReference, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="tradingAccounts", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="customerTradingAccount", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("customerTradingAccount")]			
		public virtual tradingAccountFeedEntry customerTradingAccount { get { return _customerTradingAccount; } set { SetProperty(PropertycustomerTradingAccount, ref _customerTradingAccount, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Opportunity Customer TradingAccount reference", Name="tradingAccountReference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String tradingAccountReference { get { return _tradingAccountReference; } set { SetProperty(PropertytradingAccountReference, ref _tradingAccountReference, value); } }

		[SMEResource(CanGet=true, PluralName="commodities", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="commodities", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual commodityFeed commodities { get { return _commodities; } set { SetProperty(Propertycommodities, ref _commodities, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Opportunity Commodity Text", Name="text", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String text { get { return _text; } set { SetProperty(Propertytext, ref _text, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Opportunity Currency", Name="currency", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String currency { get { return _currency; } set { SetProperty(Propertycurrency, ref _currency, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Opportunity OperatingCompany Currency", Name="operatingCompanyCurrency", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String operatingCompanyCurrency { get { return _operatingCompanyCurrency; } set { SetProperty(PropertyoperatingCompanyCurrency, ref _operatingCompanyCurrency, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=0, Label="Opportunity OperatingCompany Currency Exchange Rate", Nillable=true, AverageLength=12, Name="operatingCompanyCurrencyExchangeRate", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> operatingCompanyCurrencyExchangeRate { get { return _operatingCompanyCurrencyExchangeRate; } set { SetProperty(PropertyoperatingCompanyCurrencyExchangeRate, ref _operatingCompanyCurrencyExchangeRate, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Opportunity OperatingCompany Currency Exchange Rate Operator", Name="operatingCompanyCurrencyExchangeRateOperator", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String operatingCompanyCurrencyExchangeRateOperator { get { return _operatingCompanyCurrencyExchangeRateOperator; } set { SetProperty(PropertyoperatingCompanyCurrencyExchangeRateOperator, ref _operatingCompanyCurrencyExchangeRateOperator, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDateProperty(Label="Opportunity OperatingCompany Currency Exchange Rate Date", Nillable=true, Name="operatingCompanyCurrencyExchangeRateDate", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.DateTime> operatingCompanyCurrencyExchangeRateDate { get { return _operatingCompanyCurrencyExchangeRateDate; } set { SetProperty(PropertyoperatingCompanyCurrencyExchangeRateDate, ref _operatingCompanyCurrencyExchangeRateDate, value); } }

		[SMEResource(CanGet=true, PluralName="contacts", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="contacts", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual contactFeed contacts { get { return _contacts; } set { SetProperty(Propertycontacts, ref _contacts, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Opportunity Source", Name="source", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual new System.String source { get { return _source; } set { SetProperty(Propertysource, ref _source, value); } }

		[SMEResource(CanGet=true, PluralName="salesPersons", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="salesperson", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesPersonFeed salesperson { get { return _salesperson; } set { SetProperty(Propertysalesperson, ref _salesperson, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDateProperty(Label="Opportunity Date", Nillable=true, Name="date", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.DateTime> date { get { return _date; } set { SetProperty(Propertydate, ref _date, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDateProperty(Label="Opportunity Close Date", Nillable=true, Name="closeDate", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.DateTime> closeDate { get { return _closeDate; } set { SetProperty(PropertycloseDate, ref _closeDate, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Opportunity Open Days", Name="openDays", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String openDays { get { return _openDays; } set { SetProperty(PropertyopenDays, ref _openDays, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Opportunity Priority", Name="priority", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String priority { get { return _priority; } set { SetProperty(Propertypriority, ref _priority, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Opportunity Probability Indicator Type", Name="probabilityIndicatorType", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String probabilityIndicatorType { get { return _probabilityIndicatorType; } set { SetProperty(PropertyprobabilityIndicatorType, ref _probabilityIndicatorType, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Opportunity Probability Indicator String", Name="probabilityIndicatorstring", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String probabilityIndicatorstring { get { return _probabilityIndicatorstring; } set { SetProperty(PropertyprobabilityIndicatorstring, ref _probabilityIndicatorstring, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=0, Label="Opportunity Probability Indicator Percent", Nillable=true, AverageLength=12, Name="probabilityIndicatorPercent", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> probabilityIndicatorPercent { get { return _probabilityIndicatorPercent; } set { SetProperty(PropertyprobabilityIndicatorPercent, ref _probabilityIndicatorPercent, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Opportunity Workflow Indicator1", Name="workflowIndicator1", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String workflowIndicator1 { get { return _workflowIndicator1; } set { SetProperty(PropertyworkflowIndicator1, ref _workflowIndicator1, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Opportunity Workflow Indicator2", Name="workflowIndicator2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String workflowIndicator2 { get { return _workflowIndicator2; } set { SetProperty(PropertyworkflowIndicator2, ref _workflowIndicator2, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=0, Label="Opportunity Net Total", Nillable=true, AverageLength=12, Name="netTotal", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> netTotal { get { return _netTotal; } set { SetProperty(PropertynetTotal, ref _netTotal, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=0, Label="Opportunity Discount Total", Nillable=true, AverageLength=12, Name="discountTotal", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> discountTotal { get { return _discountTotal; } set { SetProperty(PropertydiscountTotal, ref _discountTotal, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=0, Label="Opportunity Charges Total", Nillable=true, AverageLength=12, Name="chargesTotal", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> chargesTotal { get { return _chargesTotal; } set { SetProperty(PropertychargesTotal, ref _chargesTotal, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=0, Label="Opportunity Tax Total", Nillable=true, AverageLength=12, Name="taxTotal", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> taxTotal { get { return _taxTotal; } set { SetProperty(PropertytaxTotal, ref _taxTotal, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=0, Label="Opportunity Gross Total", Nillable=true, AverageLength=12, Name="grossTotal", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> grossTotal { get { return _grossTotal; } set { SetProperty(PropertygrossTotal, ref _grossTotal, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=0, Label="Opportunity Cost Total", Nillable=true, AverageLength=12, Name="costTotal", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> costTotal { get { return _costTotal; } set { SetProperty(PropertycostTotal, ref _costTotal, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=0, Label="Opportunity Profit Total", Nillable=true, AverageLength=12, Name="profitTotal", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> profitTotal { get { return _profitTotal; } set { SetProperty(PropertyprofitTotal, ref _profitTotal, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=0, Label="Opportunity Quotation Net Total", Nillable=true, AverageLength=12, Name="quotationNetTotal", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> quotationNetTotal { get { return _quotationNetTotal; } set { SetProperty(PropertyquotationNetTotal, ref _quotationNetTotal, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=0, Label="Opportunity Quotation Discount Total", Nillable=true, AverageLength=12, Name="quotationDiscountTotal", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> quotationDiscountTotal { get { return _quotationDiscountTotal; } set { SetProperty(PropertyquotationDiscountTotal, ref _quotationDiscountTotal, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=0, Label="Opportunity Quotation Charges Total", Nillable=true, AverageLength=12, Name="quotationChargesTotal", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> quotationChargesTotal { get { return _quotationChargesTotal; } set { SetProperty(PropertyquotationChargesTotal, ref _quotationChargesTotal, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=0, Label="Opportunity Quotation Tax Total", Nillable=true, AverageLength=12, Name="quotationTaxTotal", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> quotationTaxTotal { get { return _quotationTaxTotal; } set { SetProperty(PropertyquotationTaxTotal, ref _quotationTaxTotal, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=0, Label="Opportunity Quotation Gross Total", Nillable=true, AverageLength=12, Name="quotationGrossTotal", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> quotationGrossTotal { get { return _quotationGrossTotal; } set { SetProperty(PropertyquotationGrossTotal, ref _quotationGrossTotal, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=0, Label="Opportunity Quotation Cost Total", Nillable=true, AverageLength=12, Name="quotationCostTotal", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> quotationCostTotal { get { return _quotationCostTotal; } set { SetProperty(PropertyquotationCostTotal, ref _quotationCostTotal, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=0, Label="Opportunity Quotation Profit Total", Nillable=true, AverageLength=12, Name="quotationProfitTotal", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> quotationProfitTotal { get { return _quotationProfitTotal; } set { SetProperty(PropertyquotationProfitTotal, ref _quotationProfitTotal, value); } }

		[SMEResource(CanGet=true, CanPost=true, PluralName="salesQuotations", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="salesQuotations", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesQuotationFeed salesQuotations { get { return _salesQuotations; } set { SetProperty(PropertysalesQuotations, ref _salesQuotations, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=0, Label="Opportunity Order Net Total", Nillable=true, AverageLength=12, Name="orderNetTotal", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> orderNetTotal { get { return _orderNetTotal; } set { SetProperty(PropertyorderNetTotal, ref _orderNetTotal, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=0, Label="Opportunity Order Discount Total", Nillable=true, AverageLength=12, Name="orderDiscountTotal", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> orderDiscountTotal { get { return _orderDiscountTotal; } set { SetProperty(PropertyorderDiscountTotal, ref _orderDiscountTotal, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=0, Label="Opportunity Order Charges Total", Nillable=true, AverageLength=12, Name="orderChargesTotal", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> orderChargesTotal { get { return _orderChargesTotal; } set { SetProperty(PropertyorderChargesTotal, ref _orderChargesTotal, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=0, Label="Opportunity Order Tax Total", Nillable=true, AverageLength=12, Name="orderTaxTotal", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> orderTaxTotal { get { return _orderTaxTotal; } set { SetProperty(PropertyorderTaxTotal, ref _orderTaxTotal, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=0, Label="Opportunity Order Gross Total", Nillable=true, AverageLength=12, Name="orderGrossTotal", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> orderGrossTotal { get { return _orderGrossTotal; } set { SetProperty(PropertyorderGrossTotal, ref _orderGrossTotal, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=0, Label="Opportunity Order Cost Total", Nillable=true, AverageLength=12, Name="orderCostTotal", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> orderCostTotal { get { return _orderCostTotal; } set { SetProperty(PropertyorderCostTotal, ref _orderCostTotal, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=0, Label="Opportunity Order Profit Total", Nillable=true, AverageLength=12, Name="orderProfitTotal", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> orderProfitTotal { get { return _orderProfitTotal; } set { SetProperty(PropertyorderProfitTotal, ref _orderProfitTotal, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanDelete=true, PluralName="salesOrders", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="salesOrders", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesOrderFeed salesOrders { get { return _salesOrders; } set { SetProperty(PropertysalesOrders, ref _salesOrders, value); } }

		[SMEResource(CanGet=true, PluralName="interactions", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="interactions", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual interactionFeed interactions { get { return _interactions; } set { SetProperty(Propertyinteractions, ref _interactions, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEBoolProperty(Label="Opportunity Privacy Flag", Nillable=true, Name="privacyFlag", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Boolean> privacyFlag { get { return _privacyFlag; } set { SetProperty(PropertyprivacyFlag, ref _privacyFlag, value); } }

		[SMEResource(CanGet=true, CanPut=true, PluralName="notes", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Child, Name="notes", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("notes")]			
		public virtual noteFeedEntry notes { get { return _notes; } set { SetProperty(Propertynotes, ref _notes, value); } }

		#endregion


	}
}