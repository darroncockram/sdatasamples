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
	/// Defines a bankAccount feed entry
	/// </summary>
	#endregion
	[System.ComponentModel.Browsable(false)]
	[XmlType("bankAccount", Namespace="http://schemas.sage.com/crmErp/2008")]
	public class bankAccountFeedEntrySchema : Sage.Common.Syndication.FeedEntry
	{
		#region Constants

		public const string Propertyactive = "active";
		public const string Propertytype = "type";
		public const string Propertyreference = "reference";
		public const string Propertyname = "name";
		public const string Propertydescription = "description";
		public const string PropertybranchIdentifier = "branchIdentifier";
		public const string PropertyaccountNumber = "accountNumber";
		public const string PropertyiBANNumber = "iBANNumber";
		public const string PropertybICSwiftCode = "bICSwiftCode";
		public const string PropertyrollNumber = "rollNumber";
		public const string Propertycurrency = "currency";
		public const string PropertyoperatingCompanyCurrency = "operatingCompanyCurrency";
		public const string PropertytradingAccount = "tradingAccount";
		public const string Propertycontacts = "contacts";
		public const string Propertyphones = "phones";
		public const string Propertyemails = "emails";
		public const string Propertywebsite = "website";
		public const string PropertypostalAddress = "postalAddress";
		public const string PropertycompanyReference = "companyReference";
		public const string PropertypaymentAllowedFlag = "paymentAllowedFlag";
		public const string PropertypaymentReference = "paymentReference";
		public const string PropertyreceiptAllowedFlag = "receiptAllowedFlag";
		public const string PropertyreceiptReference = "receiptReference";
		public const string Propertyreference2 = "reference2";
		public const string Propertybalance = "balance";
		public const string Propertylimit = "limit";
		public const string PropertyfinancialAccounts = "financialAccounts";
		public const string PropertylastStatementDate = "lastStatementDate";
		public const string PropertyprimacyIndicator = "primacyIndicator";
		public const string Propertynotes = "notes";

		#endregion

		#region Fields

		private Nullable<System.Boolean> _active;
		private System.String _type;
		private System.String _reference;
		private System.String _name;
		private System.String _description;
		private System.String _branchIdentifier;
		private System.String _accountNumber;
		private System.String _iBANNumber;
		private System.String _bICSwiftCode;
		private System.String _rollNumber;
		private System.String _currency;
		private System.String _operatingCompanyCurrency;
		private tradingAccountFeedEntry _tradingAccount;
		private contactFeed _contacts;
		private phoneNumberFeed _phones;
		private emailFeed _emails;
		private System.String _website;
		private postalAddressFeedEntry _postalAddress;
		private System.String _companyReference;
		private Nullable<System.Boolean> _paymentAllowedFlag;
		private System.String _paymentReference;
		private Nullable<System.Boolean> _receiptAllowedFlag;
		private System.String _receiptReference;
		private System.String _reference2;
		private Nullable<System.Decimal> _balance;
		private Nullable<System.Decimal> _limit;
		private financialAccountFeed _financialAccounts;
		private Nullable<System.DateTime> _lastStatementDate;
		private Nullable<System.Boolean> _primacyIndicator;
		private noteFeed _notes;

		#endregion

		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="bankAccountFeedEntrySchema"/> class.
		/// </summary>
		#endregion
		public bankAccountFeedEntrySchema()
		{
		}

		#region Properties


		[SMEBoolProperty(Label="BankAccount Active Flag", Nillable=true, Name="active", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.Boolean> active { get { return _active; } set { SetProperty(Propertyactive, ref _active, value); } }

		[SMEStringProperty(Label="BankAccount Type", Name="type", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String type { get { return _type; } set { SetProperty(Propertytype, ref _type, value); } }

		[SMEStringProperty(Label="BankAccount Reference", Name="reference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String reference { get { return _reference; } set { SetProperty(Propertyreference, ref _reference, value); } }

		[SMEStringProperty(Label="BankAccount Name", Name="name", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String name { get { return _name; } set { SetProperty(Propertyname, ref _name, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="BankAccount Description", Name="description", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String description { get { return _description; } set { SetProperty(Propertydescription, ref _description, value); } }

		[SMEStringProperty(Label="BankAccount Branch Identifier", Name="branchIdentifier", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String branchIdentifier { get { return _branchIdentifier; } set { SetProperty(PropertybranchIdentifier, ref _branchIdentifier, value); } }

		[SMEStringProperty(Label="BankAccount Account Number", Name="accountNumber", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String accountNumber { get { return _accountNumber; } set { SetProperty(PropertyaccountNumber, ref _accountNumber, value); } }

		[SMEStringProperty(Label="BankAccount IBAN Number", Name="iBANNumber", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true, IsUniqueKey=true)]			
		public virtual System.String iBANNumber { get { return _iBANNumber; } set { SetProperty(PropertyiBANNumber, ref _iBANNumber, value); } }

		[SMEStringProperty(Label="BankAccount BIC Swift Code", Name="bICSwiftCode", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String bICSwiftCode { get { return _bICSwiftCode; } set { SetProperty(PropertybICSwiftCode, ref _bICSwiftCode, value); } }

		[SMEStringProperty(Label="BankAccount Roll Number", Name="rollNumber", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String rollNumber { get { return _rollNumber; } set { SetProperty(PropertyrollNumber, ref _rollNumber, value); } }

		[SMEStringProperty(Label="BankAccount Currency", Name="currency", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String currency { get { return _currency; } set { SetProperty(Propertycurrency, ref _currency, value); } }

		[SMEStringProperty(Label="BankAccount OperatingCompany Currency", Name="operatingCompanyCurrency", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String operatingCompanyCurrency { get { return _operatingCompanyCurrency; } set { SetProperty(PropertyoperatingCompanyCurrency, ref _operatingCompanyCurrency, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="tradingAccounts", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="tradingAccount", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("tradingAccount")]			
		public virtual tradingAccountFeedEntry tradingAccount { get { return _tradingAccount; } set { SetProperty(PropertytradingAccount, ref _tradingAccount, value); } }

		[SMEResource(CanGet=true, PluralName="contacts", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="contacts", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual contactFeed contacts { get { return _contacts; } set { SetProperty(Propertycontacts, ref _contacts, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="phoneNumbers", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="phones", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual phoneNumberFeed phones { get { return _phones; } set { SetProperty(Propertyphones, ref _phones, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="emails", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="emails", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual emailFeed emails { get { return _emails; } set { SetProperty(Propertyemails, ref _emails, value); } }

		[SMEStringProperty(Label="BankAccount Web site", Name="website", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String website { get { return _website; } set { SetProperty(Propertywebsite, ref _website, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="postalAddresses", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="postalAddress", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("postalAddress")]			
		public virtual postalAddressFeedEntry postalAddress { get { return _postalAddress; } set { SetProperty(PropertypostalAddress, ref _postalAddress, value); } }

		[SMEStringProperty(Label="BankAccount Company reference", Name="companyReference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String companyReference { get { return _companyReference; } set { SetProperty(PropertycompanyReference, ref _companyReference, value); } }

		[SMEBoolProperty(Label="BankAccount Payment Allowed Flag", Nillable=true, Name="paymentAllowedFlag", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Boolean> paymentAllowedFlag { get { return _paymentAllowedFlag; } set { SetProperty(PropertypaymentAllowedFlag, ref _paymentAllowedFlag, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="BankAccount Payment reference", Name="paymentReference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String paymentReference { get { return _paymentReference; } set { SetProperty(PropertypaymentReference, ref _paymentReference, value); } }

		[SMEBoolProperty(Label="BankAccount Receipt Allowed Flag", Nillable=true, Name="receiptAllowedFlag", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Boolean> receiptAllowedFlag { get { return _receiptAllowedFlag; } set { SetProperty(PropertyreceiptAllowedFlag, ref _receiptAllowedFlag, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="BankAccount Receipt reference", Name="receiptReference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String receiptReference { get { return _receiptReference; } set { SetProperty(PropertyreceiptReference, ref _receiptReference, value); } }

		[SMEStringProperty(Label="BankAccount Reference2", Name="reference2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String reference2 { get { return _reference2; } set { SetProperty(Propertyreference2, ref _reference2, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="BankAccount Balance", Nillable=true, AverageLength=14, Name="balance", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> balance { get { return _balance; } set { SetProperty(Propertybalance, ref _balance, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="BankAccount Limit", Nillable=true, AverageLength=14, Name="limit", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> limit { get { return _limit; } set { SetProperty(Propertylimit, ref _limit, value); } }

		[SMEResource(CanGet=true, PluralName="financialAccounts", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="financialAccounts", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual financialAccountFeed financialAccounts { get { return _financialAccounts; } set { SetProperty(PropertyfinancialAccounts, ref _financialAccounts, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDateProperty(Label="BankAccount Last Statement Date", Nillable=true, Name="lastStatementDate", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.DateTime> lastStatementDate { get { return _lastStatementDate; } set { SetProperty(PropertylastStatementDate, ref _lastStatementDate, value); } }

		[SMEBoolProperty(Label="BankAccount Primacy Indicator", Nillable=true, Name="primacyIndicator", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.Boolean> primacyIndicator { get { return _primacyIndicator; } set { SetProperty(PropertyprimacyIndicator, ref _primacyIndicator, value); } }

		[SMEResource(CanGet=true, CanPut=true, PluralName="notes", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="notes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual noteFeed notes { get { return _notes; } set { SetProperty(Propertynotes, ref _notes, value); } }

		#endregion


	}
}