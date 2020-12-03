using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using Sage.Common.Metadata;
using Sage.Common.Syndication;

namespace Sage.crmErp.x2008.Feeds
{
	#region Documentation
	/// <summary>
	/// Defines a tradingActivity feed entry
	/// </summary>
	#endregion
	[System.ComponentModel.Browsable(false)]
	[XmlType("tradingActivity", Namespace="http://schemas.sage.com/crmErp/2008")]
	public class tradingActivityFeedEntrySchema : Sage.Common.Syndication.FeedEntry
	{
		#region Constants

		public const string PropertyapplicationID = "applicationID";
		public const string Propertyactive = "active";
		public const string Propertydeleted = "deleted";
		public const string Propertylabel = "label";
		public const string Propertyreference = "reference";
		public const string PropertytradingAccount = "tradingAccount";
		public const string PropertytransactionType = "transactionType";
		public const string Propertydate = "date";
		public const string Propertydetails = "details";
		public const string PropertyamountNet = "amountNet";
		public const string PropertyamountTax = "amountTax";
		public const string PropertyamountGross = "amountGross";
		public const string Propertycurrency = "currency";
		public const string PropertyamountPaid = "amountPaid";
		public const string PropertyaccountReference = "accountReference";
		public const string PropertydueDate = "dueDate";
		public const string PropertyheaderNumber = "headerNumber";

		#endregion

		#region Fields

		private System.String _applicationID;
		private Nullable<System.Boolean> _active;
		private Nullable<System.Boolean> _deleted;
		private System.String _label;
		private System.String _reference;
		private tradingAccountFeed _tradingAccount;
		private System.String _transactionType;
		private Nullable<System.DateTime> _date;
		private System.String _details;
		private Nullable<System.Decimal> _amountNet;
		private Nullable<System.Decimal> _amountTax;
		private Nullable<System.Decimal> _amountGross;
		private System.String _currency;
		private Nullable<System.Decimal> _amountPaid;
		private System.String _accountReference;
		private Nullable<System.DateTime> _dueDate;
		private System.String _headerNumber;

		#endregion

		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="tradingActivityFeedEntrySchema"/> class.
		/// </summary>
		#endregion
		public tradingActivityFeedEntrySchema()
		{
		}

		#region Properties


		[SMEStringProperty(Label="tradingActivity Application ID", Name="applicationID", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true, IsUniqueKey=true)]			
		public virtual System.String applicationID { get { return _applicationID; } set { SetProperty(PropertyapplicationID, ref _applicationID, value); } }

		[SMEBoolProperty(Label="tradingActivity Active Flag", Nillable=true, Name="active", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.Boolean> active { get { return _active; } set { SetProperty(Propertyactive, ref _active, value); } }

		[SMEBoolProperty(Label="tradingActivity Deleted", Nillable=true, Name="deleted", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.Boolean> deleted { get { return _deleted; } set { SetProperty(Propertydeleted, ref _deleted, value); } }

		[SMEStringProperty(Label="tradingActivity Label", Name="label", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String label { get { return _label; } set { SetProperty(Propertylabel, ref _label, value); } }

		[SMEStringProperty(Label="tradingActivity reference", Name="reference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String reference { get { return _reference; } set { SetProperty(Propertyreference, ref _reference, value); } }

		[SMEResource(CanGet=true, CanPost=true, CanPut=true, CanDelete=true, PluralName="tradingAccounts", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="tradingAccount", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual tradingAccountFeed tradingAccount { get { return _tradingAccount; } set { SetProperty(PropertytradingAccount, ref _tradingAccount, value); } }

		[SMEStringProperty(Label="tradingActivity transactionType", Name="transactionType", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String transactionType { get { return _transactionType; } set { SetProperty(PropertytransactionType, ref _transactionType, value); } }

		[SMEDateProperty(Label="tradingActivity Date", Nillable=true, Name="date", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.DateTime> date { get { return _date; } set { SetProperty(Propertydate, ref _date, value); } }

		[SMEStringProperty(Label="tradingActivity details", Name="details", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String details { get { return _details; } set { SetProperty(Propertydetails, ref _details, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="tradingActivity netAmount", Nillable=true, AverageLength=14, Name="amountNet", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.Decimal> amountNet { get { return _amountNet; } set { SetProperty(PropertyamountNet, ref _amountNet, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="tradingActivity taxAmount", Nillable=true, AverageLength=14, Name="amountTax", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.Decimal> amountTax { get { return _amountTax; } set { SetProperty(PropertyamountTax, ref _amountTax, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="tradingActivity grossAmount", Nillable=true, AverageLength=14, Name="amountGross", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.Decimal> amountGross { get { return _amountGross; } set { SetProperty(PropertyamountGross, ref _amountGross, value); } }

		[SMEStringProperty(Label="tradingActivity currency", Name="currency", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String currency { get { return _currency; } set { SetProperty(Propertycurrency, ref _currency, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="tradingActivity paidAcmount", Nillable=true, AverageLength=14, Name="amountPaid", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.Decimal> amountPaid { get { return _amountPaid; } set { SetProperty(PropertyamountPaid, ref _amountPaid, value); } }

		[SMEStringProperty(Label="tradingActivity accountReference", Name="accountReference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String accountReference { get { return _accountReference; } set { SetProperty(PropertyaccountReference, ref _accountReference, value); } }

		[SMEDateProperty(Label="tradingActivity Due Date", Nillable=true, Name="dueDate", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.DateTime> dueDate { get { return _dueDate; } set { SetProperty(PropertydueDate, ref _dueDate, value); } }

		[SMEStringProperty(Label="tradingActivity header number", Name="headerNumber", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String headerNumber { get { return _headerNumber; } set { SetProperty(PropertyheaderNumber, ref _headerNumber, value); } }

		#endregion


	}
}