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
	/// Defines a contact feed entry
	/// </summary>
	#endregion
	[System.ComponentModel.Browsable(false)]
	[XmlType("contact", Namespace="http://schemas.sage.com/crmErp/2008")]
	public class contactFeedEntrySchema : Sage.Common.Syndication.FeedEntry
	{
		#region Constants

		public const string PropertycontactGroups = "contactGroups";
		public const string Propertyactive = "active";
		public const string Propertyreference = "reference";
		public const string Propertyreference2 = "reference2";
		public const string Propertystatus = "status";
		public const string Propertytype = "type";
		public const string Propertygender = "gender";
		public const string PropertyfullName = "fullName";
		public const string Propertysalutation = "salutation";
		public const string PropertyfirstName = "firstName";
		public const string PropertypreferredName = "preferredName";
		public const string PropertyfamilyName = "familyName";
		public const string Propertytitle = "title";
		public const string PropertymiddleName = "middleName";
		public const string Propertysuffix = "suffix";
		public const string PropertyfinancialAccounts = "financialAccounts";
		public const string Propertyage = "age";
		public const string PropertydateOfBirth = "dateOfBirth";
		public const string Propertynationality = "nationality";
		public const string Propertylanguage = "language";
		public const string PropertymaritalStatus = "maritalStatus";
		public const string PropertycountryOfResidence = "countryOfResidence";
		public const string PropertynationalInsuranceNumber = "nationalInsuranceNumber";
		public const string PropertytaxReference = "taxReference";
		public const string PropertypostalAddresses = "postalAddresses";
		public const string Propertyphones = "phones";
		public const string Propertyemails = "emails";
		public const string Propertywebsite = "website";
		public const string PropertytradingAccount = "tradingAccount";
		public const string PropertybankAccounts = "bankAccounts";
		public const string PropertyjobTitle = "jobTitle";
		public const string PropertycompanyContext = "companyContext";
		public const string Propertyuser = "user";
		public const string PropertyprimacyIndicator = "primacyIndicator";
		public const string Propertyopportunities = "opportunities";
		public const string PropertysalesQuotations = "salesQuotations";
		public const string PropertysalesOrders = "salesOrders";
		public const string PropertysalesOrderDeliveries = "salesOrderDeliveries";
		public const string PropertysalesInvoices = "salesInvoices";
		public const string PropertysalesCredits = "salesCredits";
		public const string PropertypurchaseOrders = "purchaseOrders";
		public const string PropertypurchaseOrderDeliveries = "purchaseOrderDeliveries";
		public const string Propertyinteractions = "interactions";
		public const string Propertyprojects = "projects";
		public const string Propertynotes = "notes";

		#endregion

		#region Fields

		private contactGroupFeed _contactGroups;
		private Nullable<System.Boolean> _active;
		private System.String _reference;
		private System.String _reference2;
		private System.String _status;
		private System.String _type;
		private System.String _gender;
		private System.String _fullName;
		private System.String _salutation;
		private System.String _firstName;
		private System.String _preferredName;
		private System.String _familyName;
		private System.String _title;
		private System.String _middleName;
		private System.String _suffix;
		private financialAccountFeed _financialAccounts;
		private Nullable<System.Decimal> _age;
		private Nullable<System.DateTime> _dateOfBirth;
		private System.String _nationality;
		private System.String _language;
		private System.String _maritalStatus;
		private System.String _countryOfResidence;
		private System.String _nationalInsuranceNumber;
		private System.String _taxReference;
		private postalAddressFeed _postalAddresses;
		private phoneNumberFeed _phones;
		private emailFeed _emails;
		private System.String _website;
		private tradingAccountFeedEntry _tradingAccount;
		private bankAccountFeed _bankAccounts;
		private System.String _jobTitle;
		private System.String _companyContext;
		private System.String _user;
		private Nullable<System.Boolean> _primacyIndicator;
		private opportunityFeed _opportunities;
		private salesQuotationFeed _salesQuotations;
		private salesOrderFeed _salesOrders;
		private salesOrderDeliveryFeed _salesOrderDeliveries;
		private salesInvoiceFeed _salesInvoices;
		private salesCreditFeed _salesCredits;
		private purchaseOrderFeed _purchaseOrders;
		private purchaseOrderDeliveryFeed _purchaseOrderDeliveries;
		private interactionFeed _interactions;
		private projectFeed _projects;
		private noteFeed _notes;

		#endregion

		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="contactFeedEntrySchema"/> class.
		/// </summary>
		#endregion
		public contactFeedEntrySchema()
		{
		}

		#region Properties


		[SMEResource(CanGet=true, PluralName="contactGroups", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="contactGroups", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual contactGroupFeed contactGroups { get { return _contactGroups; } set { SetProperty(PropertycontactGroups, ref _contactGroups, value); } }

		[SMEBoolProperty(Label="Contact Active Flag", Nillable=true, Name="active", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.Boolean> active { get { return _active; } set { SetProperty(Propertyactive, ref _active, value); } }

		[SMEStringProperty(Label="Contact reference", Name="reference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String reference { get { return _reference; } set { SetProperty(Propertyreference, ref _reference, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Contact Reference2", Name="reference2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String reference2 { get { return _reference2; } set { SetProperty(Propertyreference2, ref _reference2, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Contact Status", Name="status", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String status { get { return _status; } set { SetProperty(Propertystatus, ref _status, value); } }

		[SMEStringProperty(Label="Contact Type", Name="type", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String type { get { return _type; } set { SetProperty(Propertytype, ref _type, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Contact Gender", Name="gender", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String gender { get { return _gender; } set { SetProperty(Propertygender, ref _gender, value); } }

		[SMEStringProperty(Label="Contact Full Name", Name="fullName", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true, IsMandatory=true)]			
		public virtual System.String fullName { get { return _fullName; } set { SetProperty(PropertyfullName, ref _fullName, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Contact Salutation", Name="salutation", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String salutation { get { return _salutation; } set { SetProperty(Propertysalutation, ref _salutation, value); } }

		[SMEStringProperty(Label="Contact First Name", Name="firstName", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String firstName { get { return _firstName; } set { SetProperty(PropertyfirstName, ref _firstName, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Contact Preferred Name", Name="preferredName", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String preferredName { get { return _preferredName; } set { SetProperty(PropertypreferredName, ref _preferredName, value); } }

		[SMEStringProperty(Label="Contact Family Name", Name="familyName", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String familyName { get { return _familyName; } set { SetProperty(PropertyfamilyName, ref _familyName, value); } }

		[SMEStringProperty(Label="Contact Title", Name="title", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual new System.String title { get { return _title; } set { SetProperty(Propertytitle, ref _title, value); } }

		[SMEStringProperty(Label="Contact Middle Name", Name="middleName", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String middleName { get { return _middleName; } set { SetProperty(PropertymiddleName, ref _middleName, value); } }

		[SMEStringProperty(Label="Contact Suffix", Name="suffix", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String suffix { get { return _suffix; } set { SetProperty(Propertysuffix, ref _suffix, value); } }

		[SMEResource(CanGet=true, PluralName="financialAccounts", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="financialAccounts", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual financialAccountFeed financialAccounts { get { return _financialAccounts; } set { SetProperty(PropertyfinancialAccounts, ref _financialAccounts, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDecimalProperty(DecimalPlaces=0, Label="Contact Age", Nillable=true, AverageLength=12, Name="age", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.Decimal> age { get { return _age; } set { SetProperty(Propertyage, ref _age, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDateProperty(Label="Contact Date Of Birth", Nillable=true, Name="dateOfBirth", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.DateTime> dateOfBirth { get { return _dateOfBirth; } set { SetProperty(PropertydateOfBirth, ref _dateOfBirth, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Contact Nationality", Name="nationality", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String nationality { get { return _nationality; } set { SetProperty(Propertynationality, ref _nationality, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Contact Language", Name="language", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String language { get { return _language; } set { SetProperty(Propertylanguage, ref _language, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Contact Marital Status", Name="maritalStatus", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String maritalStatus { get { return _maritalStatus; } set { SetProperty(PropertymaritalStatus, ref _maritalStatus, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Contact Country of Residence", Name="countryOfResidence", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String countryOfResidence { get { return _countryOfResidence; } set { SetProperty(PropertycountryOfResidence, ref _countryOfResidence, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Contact National Insurance Number", Name="nationalInsuranceNumber", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String nationalInsuranceNumber { get { return _nationalInsuranceNumber; } set { SetProperty(PropertynationalInsuranceNumber, ref _nationalInsuranceNumber, value); } }

		[SMEStringProperty(Label="Contact Tax reference", Name="taxReference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String taxReference { get { return _taxReference; } set { SetProperty(PropertytaxReference, ref _taxReference, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="postalAddresses", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="postalAddresses", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual postalAddressFeed postalAddresses { get { return _postalAddresses; } set { SetProperty(PropertypostalAddresses, ref _postalAddresses, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="phoneNumbers", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="phones", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual phoneNumberFeed phones { get { return _phones; } set { SetProperty(Propertyphones, ref _phones, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="emails", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="emails", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual emailFeed emails { get { return _emails; } set { SetProperty(Propertyemails, ref _emails, value); } }

		[SMEStringProperty(Label="Contact Web site", Name="website", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String website { get { return _website; } set { SetProperty(Propertywebsite, ref _website, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="tradingAccounts", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="tradingAccount", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("tradingAccount")]			
		public virtual tradingAccountFeedEntry tradingAccount { get { return _tradingAccount; } set { SetProperty(PropertytradingAccount, ref _tradingAccount, value); } }

		[SMEResource(CanGet=true, CanPut=true, PluralName="bankAccounts", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="bankAccounts", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual bankAccountFeed bankAccounts { get { return _bankAccounts; } set { SetProperty(PropertybankAccounts, ref _bankAccounts, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Contact Job Title", Name="jobTitle", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String jobTitle { get { return _jobTitle; } set { SetProperty(PropertyjobTitle, ref _jobTitle, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Contact Company Context", Name="companyContext", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String companyContext { get { return _companyContext; } set { SetProperty(PropertycompanyContext, ref _companyContext, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Contact User", Name="user", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String user { get { return _user; } set { SetProperty(Propertyuser, ref _user, value); } }

		[SMEBoolProperty(Label="Contact Primacy Indicator", Nillable=true, Name="primacyIndicator", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.Boolean> primacyIndicator { get { return _primacyIndicator; } set { SetProperty(PropertyprimacyIndicator, ref _primacyIndicator, value); } }

		[SMEResource(CanGet=true, PluralName="Opportunities", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="opportunities", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual opportunityFeed opportunities { get { return _opportunities; } set { SetProperty(Propertyopportunities, ref _opportunities, value); } }

		[SMEResource(CanGet=true, CanPost=true, PluralName="salesQuotations", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="salesQuotations", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesQuotationFeed salesQuotations { get { return _salesQuotations; } set { SetProperty(PropertysalesQuotations, ref _salesQuotations, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanDelete=true, PluralName="salesOrders", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="salesOrders", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesOrderFeed salesOrders { get { return _salesOrders; } set { SetProperty(PropertysalesOrders, ref _salesOrders, value); } }

		[SMEResource(CanGet=true, PluralName="salesOrderDeliveries", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="salesOrderDeliveries", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesOrderDeliveryFeed salesOrderDeliveries { get { return _salesOrderDeliveries; } set { SetProperty(PropertysalesOrderDeliveries, ref _salesOrderDeliveries, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanDelete=true, PluralName="salesInvoices", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="salesInvoices", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesInvoiceFeed salesInvoices { get { return _salesInvoices; } set { SetProperty(PropertysalesInvoices, ref _salesInvoices, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="salesCredits", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="salesCredits", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesCreditFeed salesCredits { get { return _salesCredits; } set { SetProperty(PropertysalesCredits, ref _salesCredits, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanDelete=true, PluralName="purchaseOrders", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="purchaseOrders", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual purchaseOrderFeed purchaseOrders { get { return _purchaseOrders; } set { SetProperty(PropertypurchaseOrders, ref _purchaseOrders, value); } }

		[SMEResource(CanGet=true, PluralName="purchaseOrderDeliveries", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="purchaseOrderDeliveries", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual purchaseOrderDeliveryFeed purchaseOrderDeliveries { get { return _purchaseOrderDeliveries; } set { SetProperty(PropertypurchaseOrderDeliveries, ref _purchaseOrderDeliveries, value); } }

		[SMEResource(CanGet=true, PluralName="interactions", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="interactions", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual interactionFeed interactions { get { return _interactions; } set { SetProperty(Propertyinteractions, ref _interactions, value); } }

		[SMEResource(CanGet=true, PluralName="projects", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="projects", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual projectFeed projects { get { return _projects; } set { SetProperty(Propertyprojects, ref _projects, value); } }

		[SMEResource(CanGet=true, CanPut=true, PluralName="notes", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="notes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual noteFeed notes { get { return _notes; } set { SetProperty(Propertynotes, ref _notes, value); } }

		#endregion


	}
}