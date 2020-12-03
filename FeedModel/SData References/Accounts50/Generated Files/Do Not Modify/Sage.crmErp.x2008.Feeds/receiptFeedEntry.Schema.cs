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
	/// Defines a receipt feed entry
	/// </summary>
	#endregion
	[System.ComponentModel.Browsable(false)]
	[XmlType("receipt", Namespace="http://schemas.sage.com/crmErp/2008")]
	public class receiptFeedEntrySchema : Sage.Common.Syndication.FeedEntry
	{
		#region Constants

		public const string Propertyactive = "active";
		public const string Propertytype = "type";
		public const string PropertybankAccount = "bankAccount";
		public const string Propertysource = "source";
		public const string Propertystatus = "status";
		public const string PropertytenderType = "tenderType";
		public const string PropertytenderReference = "tenderReference";
		public const string PropertyexternalReference = "externalReference";
		public const string Propertyreference = "reference";
		public const string Propertyreference2 = "reference2";
		public const string Propertydate = "date";
		public const string PropertyprocessDate = "processDate";
		public const string PropertytradingAccount = "tradingAccount";
		public const string PropertytradingAccountReference = "tradingAccountReference";
		public const string PropertypriceList = "priceList";
		public const string PropertyoriginatorDocument = "originatorDocument";
		public const string PropertytaxCode = "taxCode";
		public const string PropertysalesPerson = "salesPerson";
		public const string Propertycurrency = "currency";
		public const string PropertyoperatingCompanyCurrency = "operatingCompanyCurrency";
		public const string PropertyoperatingCompanyCurrencyExchangeRate = "operatingCompanyCurrencyExchangeRate";
		public const string PropertyoperatingCompanyCurrencyExchangeRateOperator = "operatingCompanyCurrencyExchangeRateOperator";
		public const string PropertyoperatingCompanyCurrencyExchangeRateDate = "operatingCompanyCurrencyExchangeRateDate";
		public const string PropertybankAccountCurrency = "bankAccountCurrency";
		public const string PropertybankAccountCurrencyExchangeRate = "bankAccountCurrencyExchangeRate";
		public const string PropertybankAccountCurrencyExchangeRateOperator = "bankAccountCurrencyExchangeRateOperator";
		public const string PropertybankAccountCurrencyExchangeRateDate = "bankAccountCurrencyExchangeRateDate";
		public const string PropertynetTotal = "netTotal";
		public const string PropertybalanceBefore = "balanceBefore";
		public const string PropertybalanceAfter = "balanceAfter";
		public const string PropertydiscountTotal = "discountTotal";
		public const string PropertychargesTotal = "chargesTotal";
		public const string PropertytaxTotal = "taxTotal";
		public const string PropertygrossTotal = "grossTotal";
		public const string Propertyname = "name";
		public const string Propertydescription = "description";
		public const string Propertytext1 = "text1";
		public const string Propertytext2 = "text2";
		public const string PropertylineCount = "lineCount";
		public const string Propertyuser = "user";
		public const string PropertyfinancialAccounts = "financialAccounts";
		public const string Propertyprojects = "projects";
		public const string Propertyinteractions = "interactions";
		public const string Propertynotes = "notes";

		#endregion

		#region Fields

		private Nullable<System.Boolean> _active;
		private System.String _type;
		private bankAccountFeedEntry _bankAccount;
		private System.String _source;
		private System.String _status;
		private System.String _tenderType;
		private System.String _tenderReference;
		private System.String _externalReference;
		private System.String _reference;
		private System.String _reference2;
		private Nullable<System.DateTime> _date;
		private Nullable<System.DateTime> _processDate;
		private tradingAccountFeedEntry _tradingAccount;
		private System.String _tradingAccountReference;
		private priceListFeedEntry _priceList;
		private salesInvoiceFeed _originatorDocument;
		private taxCodeFeed _taxCode;
		private salesPersonFeed _salesPerson;
		private System.String _currency;
		private System.String _operatingCompanyCurrency;
		private Nullable<System.Decimal> _operatingCompanyCurrencyExchangeRate;
		private System.String _operatingCompanyCurrencyExchangeRateOperator;
		private Nullable<System.DateTime> _operatingCompanyCurrencyExchangeRateDate;
		private System.String _bankAccountCurrency;
		private Nullable<System.Decimal> _bankAccountCurrencyExchangeRate;
		private System.String _bankAccountCurrencyExchangeRateOperator;
		private Nullable<System.DateTime> _bankAccountCurrencyExchangeRateDate;
		private Nullable<System.Decimal> _netTotal;
		private Nullable<System.Decimal> _balanceBefore;
		private Nullable<System.Decimal> _balanceAfter;
		private Nullable<System.Decimal> _discountTotal;
		private Nullable<System.Decimal> _chargesTotal;
		private Nullable<System.Decimal> _taxTotal;
		private Nullable<System.Decimal> _grossTotal;
		private System.String _name;
		private System.String _description;
		private System.String _text1;
		private System.String _text2;
		private Nullable<System.Decimal> _lineCount;
		private System.String _user;
		private financialAccountFeed _financialAccounts;
		private projectFeed _projects;
		private interactionFeed _interactions;
		private noteFeed _notes;

		#endregion

		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="receiptFeedEntrySchema"/> class.
		/// </summary>
		#endregion
		public receiptFeedEntrySchema()
		{
		}

		#region Properties


		[SMEBoolProperty(Label="Receipt Active Flag", Nillable=true, Name="active", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.Boolean> active { get { return _active; } set { SetProperty(Propertyactive, ref _active, value); } }

		[SMEStringProperty(Label="Receipt Type", Name="type", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String type { get { return _type; } set { SetProperty(Propertytype, ref _type, value); } }

		[SMEResource(CanGet=true, CanPut=true, PluralName="bankAccounts", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="bankAccount", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("bankAccount")]			
		public virtual bankAccountFeedEntry bankAccount { get { return _bankAccount; } set { SetProperty(PropertybankAccount, ref _bankAccount, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Receipt Source", Name="source", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual new System.String source { get { return _source; } set { SetProperty(Propertysource, ref _source, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Receipt Status", Name="status", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String status { get { return _status; } set { SetProperty(Propertystatus, ref _status, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Receipt Tender Type", Name="tenderType", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String tenderType { get { return _tenderType; } set { SetProperty(PropertytenderType, ref _tenderType, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Receipt Tender reference", Name="tenderReference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String tenderReference { get { return _tenderReference; } set { SetProperty(PropertytenderReference, ref _tenderReference, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Receipt Tender External reference", Name="externalReference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String externalReference { get { return _externalReference; } set { SetProperty(PropertyexternalReference, ref _externalReference, value); } }

		[SMEStringProperty(Label="Receipt reference", Name="reference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true, IsUniqueKey=true)]			
		public virtual System.String reference { get { return _reference; } set { SetProperty(Propertyreference, ref _reference, value); } }

		[SMEStringProperty(Label="Receipt Reference2", Name="reference2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String reference2 { get { return _reference2; } set { SetProperty(Propertyreference2, ref _reference2, value); } }

		[SMEDateProperty(Label="Receipt Date", Nillable=true, Name="date", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.DateTime> date { get { return _date; } set { SetProperty(Propertydate, ref _date, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDateProperty(Label="Receipt Process Date", Nillable=true, Name="processDate", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.DateTime> processDate { get { return _processDate; } set { SetProperty(PropertyprocessDate, ref _processDate, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="tradingAccounts", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="tradingAccount", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("tradingAccount")]			
		public virtual tradingAccountFeedEntry tradingAccount { get { return _tradingAccount; } set { SetProperty(PropertytradingAccount, ref _tradingAccount, value); } }

		[SMEStringProperty(Label="Receipt TradingAccount reference", Name="tradingAccountReference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String tradingAccountReference { get { return _tradingAccountReference; } set { SetProperty(PropertytradingAccountReference, ref _tradingAccountReference, value); } }

		[SMEResource(CanGet=true, PluralName="priceLists", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="priceList", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("priceList")]			
		public virtual priceListFeedEntry priceList { get { return _priceList; } set { SetProperty(PropertypriceList, ref _priceList, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanDelete=true, PluralName="salesInvoices", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="originatorDocument", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesInvoiceFeed originatorDocument { get { return _originatorDocument; } set { SetProperty(PropertyoriginatorDocument, ref _originatorDocument, value); } }

		[SMEResource(CanGet=true, PluralName="taxCodes", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="taxCode", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual taxCodeFeed taxCode { get { return _taxCode; } set { SetProperty(PropertytaxCode, ref _taxCode, value); } }

		[SMEResource(CanGet=true, PluralName="salesPersons", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="salesPerson", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesPersonFeed salesPerson { get { return _salesPerson; } set { SetProperty(PropertysalesPerson, ref _salesPerson, value); } }

		[SMEStringProperty(Label="Receipt Currency", Name="currency", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String currency { get { return _currency; } set { SetProperty(Propertycurrency, ref _currency, value); } }

		[SMEStringProperty(Label="Receipt OperatingCompany Currency", Name="operatingCompanyCurrency", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String operatingCompanyCurrency { get { return _operatingCompanyCurrency; } set { SetProperty(PropertyoperatingCompanyCurrency, ref _operatingCompanyCurrency, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="Receipt OperatingCompany Currency Exchange Rate", Nillable=true, AverageLength=14, Name="operatingCompanyCurrencyExchangeRate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> operatingCompanyCurrencyExchangeRate { get { return _operatingCompanyCurrencyExchangeRate; } set { SetProperty(PropertyoperatingCompanyCurrencyExchangeRate, ref _operatingCompanyCurrencyExchangeRate, value); } }

		[SMEStringProperty(Label="Receipt OperatingCompany Currency Exchange Rate Operator", Name="operatingCompanyCurrencyExchangeRateOperator", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String operatingCompanyCurrencyExchangeRateOperator { get { return _operatingCompanyCurrencyExchangeRateOperator; } set { SetProperty(PropertyoperatingCompanyCurrencyExchangeRateOperator, ref _operatingCompanyCurrencyExchangeRateOperator, value); } }

		[SMEDateProperty(Label="Receipt OperatingCompany Currency Exchange Rate Date", Nillable=true, Name="operatingCompanyCurrencyExchangeRateDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> operatingCompanyCurrencyExchangeRateDate { get { return _operatingCompanyCurrencyExchangeRateDate; } set { SetProperty(PropertyoperatingCompanyCurrencyExchangeRateDate, ref _operatingCompanyCurrencyExchangeRateDate, value); } }

		[SMEStringProperty(Label="Receipt Bank Account Currency", Name="bankAccountCurrency", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String bankAccountCurrency { get { return _bankAccountCurrency; } set { SetProperty(PropertybankAccountCurrency, ref _bankAccountCurrency, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="Receipt Bank Account Currency Exchange Rate", Nillable=true, AverageLength=14, Name="bankAccountCurrencyExchangeRate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> bankAccountCurrencyExchangeRate { get { return _bankAccountCurrencyExchangeRate; } set { SetProperty(PropertybankAccountCurrencyExchangeRate, ref _bankAccountCurrencyExchangeRate, value); } }

		[SMEStringProperty(Label="Receipt Bank Account Currency Exchange Rate Operator", Name="bankAccountCurrencyExchangeRateOperator", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String bankAccountCurrencyExchangeRateOperator { get { return _bankAccountCurrencyExchangeRateOperator; } set { SetProperty(PropertybankAccountCurrencyExchangeRateOperator, ref _bankAccountCurrencyExchangeRateOperator, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDateProperty(Label="Receipt Bank Account Currency Exchange Rate Date", Nillable=true, Name="bankAccountCurrencyExchangeRateDate", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.DateTime> bankAccountCurrencyExchangeRateDate { get { return _bankAccountCurrencyExchangeRateDate; } set { SetProperty(PropertybankAccountCurrencyExchangeRateDate, ref _bankAccountCurrencyExchangeRateDate, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="Receipt Net Total", Nillable=true, AverageLength=14, Name="netTotal", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> netTotal { get { return _netTotal; } set { SetProperty(PropertynetTotal, ref _netTotal, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="Receipt BankAccount Balance Before", Nillable=true, AverageLength=14, Name="balanceBefore", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> balanceBefore { get { return _balanceBefore; } set { SetProperty(PropertybalanceBefore, ref _balanceBefore, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="Receipt BankAccount Balance After", Nillable=true, AverageLength=14, Name="balanceAfter", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> balanceAfter { get { return _balanceAfter; } set { SetProperty(PropertybalanceAfter, ref _balanceAfter, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="Receipt Discount Total", Nillable=true, AverageLength=14, Name="discountTotal", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> discountTotal { get { return _discountTotal; } set { SetProperty(PropertydiscountTotal, ref _discountTotal, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=2, Label="Receipt Charges Total", Nillable=true, AverageLength=14, Name="chargesTotal", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> chargesTotal { get { return _chargesTotal; } set { SetProperty(PropertychargesTotal, ref _chargesTotal, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="Receipt Tax Total", Nillable=true, AverageLength=14, Name="taxTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> taxTotal { get { return _taxTotal; } set { SetProperty(PropertytaxTotal, ref _taxTotal, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="Receipt Gross Total", Nillable=true, AverageLength=14, Name="grossTotal", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> grossTotal { get { return _grossTotal; } set { SetProperty(PropertygrossTotal, ref _grossTotal, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Receipt Name", Name="name", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String name { get { return _name; } set { SetProperty(Propertyname, ref _name, value); } }

		[SMEStringProperty(Label="Receipt Description", Name="description", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String description { get { return _description; } set { SetProperty(Propertydescription, ref _description, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Receipt Text1", Name="text1", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String text1 { get { return _text1; } set { SetProperty(Propertytext1, ref _text1, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Receipt Text2", Name="text2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String text2 { get { return _text2; } set { SetProperty(Propertytext2, ref _text2, value); } }

		[SMEDecimalProperty(DecimalPlaces=0, Label="Receipt Line Count", Nillable=true, AverageLength=12, Name="lineCount", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> lineCount { get { return _lineCount; } set { SetProperty(PropertylineCount, ref _lineCount, value); } }

		[SMEStringProperty(Label="Receipt User", Name="user", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String user { get { return _user; } set { SetProperty(Propertyuser, ref _user, value); } }

		[SMEResource(CanGet=true, PluralName="financialAccounts", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="financialAccounts", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual financialAccountFeed financialAccounts { get { return _financialAccounts; } set { SetProperty(PropertyfinancialAccounts, ref _financialAccounts, value); } }

		[SMEResource(CanGet=true, PluralName="projects", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="projects", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual projectFeed projects { get { return _projects; } set { SetProperty(Propertyprojects, ref _projects, value); } }

		[SMEResource(CanGet=true, PluralName="interactions", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="interactions", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual interactionFeed interactions { get { return _interactions; } set { SetProperty(Propertyinteractions, ref _interactions, value); } }

		[SMEResource(CanGet=true, CanPut=true, PluralName="notes", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="notes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual noteFeed notes { get { return _notes; } set { SetProperty(Propertynotes, ref _notes, value); } }

		#endregion


	}
}