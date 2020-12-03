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
	/// Defines a interaction feed entry
	/// </summary>
	#endregion
	[System.ComponentModel.Browsable(false)]
	[XmlType("interaction", Namespace="http://schemas.sage.com/crmErp/2008")]
	public class interactionFeedEntrySchema : Sage.Common.Syndication.FeedEntry
	{
		#region Constants

		public const string Propertyactive = "active";
		public const string Propertytype = "type";
		public const string Propertystatus = "status";
		public const string Propertyreference = "reference";
		public const string Propertyname = "name";
		public const string Propertysubject = "subject";
		public const string Propertydescription = "description";
		public const string Propertyuser = "user";
		public const string Propertypriority = "priority";
		public const string PropertytradingAccount = "tradingAccount";
		public const string PropertysalesInvoices = "salesInvoices";
		public const string Propertycontacts = "contacts";
		public const string Propertycommodities = "commodities";
		public const string Propertydate = "date";
		public const string Propertytime = "time";
		public const string PropertyendDate = "endDate";
		public const string PropertyendTime = "endTime";
		public const string PropertyexpirationDate = "expirationDate";
		public const string PropertyexpirationTime = "expirationTime";
		public const string Propertyrecurrence = "recurrence";
		public const string PropertyrecurrenceFrequency = "recurrenceFrequency";
		public const string PropertyworkflowIndicator1 = "workflowIndicator1";
		public const string PropertyworkflowIndicator2 = "workflowIndicator2";
		public const string PropertyprivacyFlag = "privacyFlag";
		public const string Propertyproject = "project";
		public const string Propertynotes = "notes";
		public const string PropertypromisedPaymentDate = "promisedPaymentDate";
		public const string PropertyfollowUpDate = "followUpDate";

		#endregion

		#region Fields

		private Nullable<System.Boolean> _active;
		private System.String _type;
		private System.String _status;
		private System.String _reference;
		private System.String _name;
		private System.String _subject;
		private System.String _description;
		private System.String _user;
		private System.String _priority;
		private tradingAccountFeedEntry _tradingAccount;
		private salesInvoiceFeed _salesInvoices;
		private contactFeed _contacts;
		private commodityFeed _commodities;
		private Nullable<System.DateTime> _date;
		private Nullable<System.DateTime> _time;
		private Nullable<System.DateTime> _endDate;
		private Nullable<System.DateTime> _endTime;
		private Nullable<System.DateTime> _expirationDate;
		private Nullable<System.DateTime> _expirationTime;
		private Nullable<System.Boolean> _recurrence;
		private System.String _recurrenceFrequency;
		private System.String _workflowIndicator1;
		private System.String _workflowIndicator2;
		private Nullable<System.Boolean> _privacyFlag;
		private projectFeedEntry _project;
		private noteFeed _notes;
		private System.String _promisedPaymentDate;
		private System.String _followUpDate;

		#endregion

		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="interactionFeedEntrySchema"/> class.
		/// </summary>
		#endregion
		public interactionFeedEntrySchema()
		{
		}

		#region Properties


		[SMEBoolProperty(Label="Interaction Active Flag", Nillable=true, Name="active", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.Boolean> active { get { return _active; } set { SetProperty(Propertyactive, ref _active, value); } }

		[SMEStringProperty(Label="Interaction Type", Name="type", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true, IsMandatory=true)]			
		public virtual System.String type { get { return _type; } set { SetProperty(Propertytype, ref _type, value); } }

		[SMEStringProperty(Label="Interaction Status", Name="status", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String status { get { return _status; } set { SetProperty(Propertystatus, ref _status, value); } }

		[SMEStringProperty(Label="Interaction reference", Name="reference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String reference { get { return _reference; } set { SetProperty(Propertyreference, ref _reference, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Interaction Name", Name="name", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String name { get { return _name; } set { SetProperty(Propertyname, ref _name, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Interaction Subject", Name="subject", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String subject { get { return _subject; } set { SetProperty(Propertysubject, ref _subject, value); } }

		[SMEStringProperty(Label="Interaction Description", Name="description", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true, IsMandatory=true)]			
		public virtual System.String description { get { return _description; } set { SetProperty(Propertydescription, ref _description, value); } }

		[SMEStringProperty(Label="Interaction User", Name="user", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String user { get { return _user; } set { SetProperty(Propertyuser, ref _user, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Interaction Priority", Name="priority", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String priority { get { return _priority; } set { SetProperty(Propertypriority, ref _priority, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="tradingAccounts", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="tradingAccount", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("tradingAccount")]			
		public virtual tradingAccountFeedEntry tradingAccount { get { return _tradingAccount; } set { SetProperty(PropertytradingAccount, ref _tradingAccount, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanDelete=true, PluralName="salesInvoices", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="salesInvoices", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual salesInvoiceFeed salesInvoices { get { return _salesInvoices; } set { SetProperty(PropertysalesInvoices, ref _salesInvoices, value); } }

		[SMEResource(CanGet=true, PluralName="contacts", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="contacts", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual contactFeed contacts { get { return _contacts; } set { SetProperty(Propertycontacts, ref _contacts, value); } }

		[SMEResource(CanGet=true, PluralName="commodities", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="commodities", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual commodityFeed commodities { get { return _commodities; } set { SetProperty(Propertycommodities, ref _commodities, value); } }

		[SMEDateProperty(Label="Interaction Date", Nillable=true, Name="date", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.DateTime> date { get { return _date; } set { SetProperty(Propertydate, ref _date, value); } }

		[SMETimeProperty(Label="Interaction Time", Nillable=true, Name="time", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> time { get { return _time; } set { SetProperty(Propertytime, ref _time, value); } }

		[SMEDateProperty(Label="Interaction End Date", Nillable=true, Name="endDate", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> endDate { get { return _endDate; } set { SetProperty(PropertyendDate, ref _endDate, value); } }

		[SMETimeProperty(Label="Interaction End Time", Nillable=true, Name="endTime", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.DateTime> endTime { get { return _endTime; } set { SetProperty(PropertyendTime, ref _endTime, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDateProperty(Label="Interaction Expiration Date", Nillable=true, Name="expirationDate", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.DateTime> expirationDate { get { return _expirationDate; } set { SetProperty(PropertyexpirationDate, ref _expirationDate, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMETimeProperty(Label="Interaction Expiration Time", Nillable=true, Name="expirationTime", Namespace="http://schemas.sage.com/crmErp/2008", Unsupported=true)]			
		public virtual Nullable<System.DateTime> expirationTime { get { return _expirationTime; } set { SetProperty(PropertyexpirationTime, ref _expirationTime, value); } }

		[SMEBoolProperty(Label="Interaction Recurrence", Nillable=true, Name="recurrence", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Boolean> recurrence { get { return _recurrence; } set { SetProperty(Propertyrecurrence, ref _recurrence, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Interaction Recurrence Frequency", Name="recurrenceFrequency", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String recurrenceFrequency { get { return _recurrenceFrequency; } set { SetProperty(PropertyrecurrenceFrequency, ref _recurrenceFrequency, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Interaction Workflow Indicator1", Name="workflowIndicator1", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String workflowIndicator1 { get { return _workflowIndicator1; } set { SetProperty(PropertyworkflowIndicator1, ref _workflowIndicator1, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Interaction Workflow Indicator2", Name="workflowIndicator2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", Unsupported=true)]			
		public virtual System.String workflowIndicator2 { get { return _workflowIndicator2; } set { SetProperty(PropertyworkflowIndicator2, ref _workflowIndicator2, value); } }

		[SMEBoolProperty(Label="Interaction Privacy Flag", Nillable=true, Name="privacyFlag", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Boolean> privacyFlag { get { return _privacyFlag; } set { SetProperty(PropertyprivacyFlag, ref _privacyFlag, value); } }

		[SMEResource(CanGet=true, PluralName="projects", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="project", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("project")]			
		public virtual projectFeedEntry project { get { return _project; } set { SetProperty(Propertyproject, ref _project, value); } }

		[SMEResource(CanGet=true, CanPut=true, PluralName="notes", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="notes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual noteFeed notes { get { return _notes; } set { SetProperty(Propertynotes, ref _notes, value); } }

		[SMEStringProperty(Label="Interaciton Promised Payment Date", Nillable=true, Name="promisedPaymentDate", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String promisedPaymentDate { get { return _promisedPaymentDate; } set { SetProperty(PropertypromisedPaymentDate, ref _promisedPaymentDate, value); } }

		[SMEStringProperty(Label="Interaction Follow up Date", Nillable=true, Name="followUpDate", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string")]			
		public virtual System.String followUpDate { get { return _followUpDate; } set { SetProperty(PropertyfollowUpDate, ref _followUpDate, value); } }

		#endregion


	}
}