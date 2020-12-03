using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using Sage.Common.Metadata;
using Sage.Common.Syndication;

namespace Sage.sc.x2009.Feeds
{
	#region Documentation
	/// <summary>
	/// Defines a financialAccount feed entry
	/// </summary>
	#endregion
	[System.ComponentModel.Browsable(false)]
	[XmlType("financialAccount", Namespace="http://schemas.sage.com/sc/2009")]
	[SMEResource(CanGet = true, CanPost = false, CanPut = false, CanDelete = false, PluralName = "financialAccounts", HasUuid = true)]
	public class financialAccountFeedEntrySchema : Sage.Common.Syndication.FeedEntry
	{
		#region Constants

		public const string Propertyactive = "active";
		public const string Propertyreference = "reference";
		public const string Propertyreference2 = "reference2";
		public const string Propertytype = "type";
		public const string PropertyreportingType = "reportingType";
		public const string PropertyaccountingType = "accountingType";
		public const string Propertyname = "name";
		public const string Propertydescription = "description";
		public const string Propertyaccount = "account";
		public const string Propertyanalysis01 = "analysis01";
		public const string Propertyanalysis02 = "analysis02";
		public const string Propertyanalysis03 = "analysis03";
		public const string Propertyanalysis04 = "analysis04";
		public const string Propertyanalysis05 = "analysis05";
		public const string Propertyanalysis06 = "analysis06";
		public const string Propertyanalysis07 = "analysis07";
		public const string Propertyanalysis08 = "analysis08";
		public const string Propertyanalysis09 = "analysis09";
		public const string Propertyanalysis10 = "analysis10";
		public const string Propertyanalysis11 = "analysis11";
		public const string Propertyanalysis12 = "analysis12";
		public const string Propertyanalysis13 = "analysis13";
		public const string Propertyanalysis14 = "analysis14";
		public const string Propertyanalysis15 = "analysis15";
		public const string Propertycurrency = "currency";
		public const string Propertybalance = "balance";
		public const string PropertybalanceDate = "balanceDate";
		public const string PropertylastTransactionDate = "lastTransactionDate";
		public const string PropertyprimacyIndicator = "primacyIndicator";

		#endregion

		#region Fields

		private Nullable<System.Boolean> _active;
		private System.String _reference;
		private System.String _reference2;
		private System.String _type;
		private System.String _reportingType;
		private System.String _accountingType;
		private System.String _name;
		private System.String _description;
		private System.String _account;
		private System.String _analysis01;
		private System.String _analysis02;
		private System.String _analysis03;
		private System.String _analysis04;
		private System.String _analysis05;
		private System.String _analysis06;
		private System.String _analysis07;
		private System.String _analysis08;
		private System.String _analysis09;
		private System.String _analysis10;
		private System.String _analysis11;
		private System.String _analysis12;
		private System.String _analysis13;
		private System.String _analysis14;
		private System.String _analysis15;
		private System.String _currency;
		private Nullable<System.Decimal> _balance;
		private Nullable<System.DateTime> _balanceDate;
		private Nullable<System.DateTime> _lastTransactionDate;
		private Nullable<System.Boolean> _primacyIndicator;

		#endregion

		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="financialAccountFeedEntrySchema"/> class.
		/// </summary>
		#endregion
		public financialAccountFeedEntrySchema()
		{
		}

		#region Properties


		[SMEBoolProperty(Label="FinancialAccount Active Flag", Nillable=true, Name="active", Namespace="http://schemas.sage.com/sc/2009", CanFilter=true)]			
		public virtual Nullable<System.Boolean> active { get { return _active; } set { SetProperty(Propertyactive, ref _active, value); } }

		[SMEStringProperty(Label="FinancialAccount reference", Name="reference", Namespace="http://schemas.sage.com/sc/2009", DataType="string", CanFilter=true, IsUniqueKey=true)]			
		public virtual System.String reference { get { return _reference; } set { SetProperty(Propertyreference, ref _reference, value); } }

		[SMEStringProperty(Label="FinancialAccount Reference2", Name="reference2", Namespace="http://schemas.sage.com/sc/2009", DataType="string", CanFilter=true)]			
		public virtual System.String reference2 { get { return _reference2; } set { SetProperty(Propertyreference2, ref _reference2, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="FinancialAccount Type", Name="type", Namespace="http://schemas.sage.com/sc/2009", DataType="string", Unsupported=true)]			
		public virtual System.String type { get { return _type; } set { SetProperty(Propertytype, ref _type, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="FinancialAccount Reporting Type", Name="reportingType", Namespace="http://schemas.sage.com/sc/2009", DataType="string", Unsupported=true)]			
		public virtual System.String reportingType { get { return _reportingType; } set { SetProperty(PropertyreportingType, ref _reportingType, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="FinancialAccount Accounting Type", Name="accountingType", Namespace="http://schemas.sage.com/sc/2009", DataType="string", Unsupported=true)]			
		public virtual System.String accountingType { get { return _accountingType; } set { SetProperty(PropertyaccountingType, ref _accountingType, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="FinancialAccount Name", Name="name", Namespace="http://schemas.sage.com/sc/2009", DataType="string", CanFilter=true, Unsupported=true)]			
		public virtual System.String name { get { return _name; } set { SetProperty(Propertyname, ref _name, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="FinancialAccount Description", Name="description", Namespace="http://schemas.sage.com/sc/2009", DataType="string", Unsupported=true)]			
		public virtual System.String description { get { return _description; } set { SetProperty(Propertydescription, ref _description, value); } }

		[SMEStringProperty(Label="FinancialAccount Account", Name="account", Namespace="http://schemas.sage.com/sc/2009", DataType="string", CanFilter=true)]			
		public virtual System.String account { get { return _account; } set { SetProperty(Propertyaccount, ref _account, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Financial Account Analysis 01", Name="analysis01", Namespace="http://schemas.sage.com/sc/2009", DataType="string", Unsupported=true)]			
		public virtual System.String analysis01 { get { return _analysis01; } set { SetProperty(Propertyanalysis01, ref _analysis01, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Financial Account Analysis 02", Name="analysis02", Namespace="http://schemas.sage.com/sc/2009", DataType="string", Unsupported=true)]			
		public virtual System.String analysis02 { get { return _analysis02; } set { SetProperty(Propertyanalysis02, ref _analysis02, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Financial Account Analysis 03", Name="analysis03", Namespace="http://schemas.sage.com/sc/2009", DataType="string", Unsupported=true)]			
		public virtual System.String analysis03 { get { return _analysis03; } set { SetProperty(Propertyanalysis03, ref _analysis03, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Financial Account Analysis 04", Name="analysis04", Namespace="http://schemas.sage.com/sc/2009", DataType="string", Unsupported=true)]			
		public virtual System.String analysis04 { get { return _analysis04; } set { SetProperty(Propertyanalysis04, ref _analysis04, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Financial Account Analysis 05", Name="analysis05", Namespace="http://schemas.sage.com/sc/2009", DataType="string", Unsupported=true)]			
		public virtual System.String analysis05 { get { return _analysis05; } set { SetProperty(Propertyanalysis05, ref _analysis05, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Financial Account Analysis 06", Name="analysis06", Namespace="http://schemas.sage.com/sc/2009", DataType="string", Unsupported=true)]			
		public virtual System.String analysis06 { get { return _analysis06; } set { SetProperty(Propertyanalysis06, ref _analysis06, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Financial Account Analysis 07", Name="analysis07", Namespace="http://schemas.sage.com/sc/2009", DataType="string", Unsupported=true)]			
		public virtual System.String analysis07 { get { return _analysis07; } set { SetProperty(Propertyanalysis07, ref _analysis07, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Financial Account Analysis 08", Name="analysis08", Namespace="http://schemas.sage.com/sc/2009", DataType="string", Unsupported=true)]			
		public virtual System.String analysis08 { get { return _analysis08; } set { SetProperty(Propertyanalysis08, ref _analysis08, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Financial Account Analysis 09", Name="analysis09", Namespace="http://schemas.sage.com/sc/2009", DataType="string", Unsupported=true)]			
		public virtual System.String analysis09 { get { return _analysis09; } set { SetProperty(Propertyanalysis09, ref _analysis09, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Financial Account Analysis 10", Name="analysis10", Namespace="http://schemas.sage.com/sc/2009", DataType="string", Unsupported=true)]			
		public virtual System.String analysis10 { get { return _analysis10; } set { SetProperty(Propertyanalysis10, ref _analysis10, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Financial Account Analysis 11", Name="analysis11", Namespace="http://schemas.sage.com/sc/2009", DataType="string", Unsupported=true)]			
		public virtual System.String analysis11 { get { return _analysis11; } set { SetProperty(Propertyanalysis11, ref _analysis11, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Financial Account Analysis 12", Name="analysis12", Namespace="http://schemas.sage.com/sc/2009", DataType="string", Unsupported=true)]			
		public virtual System.String analysis12 { get { return _analysis12; } set { SetProperty(Propertyanalysis12, ref _analysis12, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Financial Account Analysis 13", Name="analysis13", Namespace="http://schemas.sage.com/sc/2009", DataType="string", Unsupported=true)]			
		public virtual System.String analysis13 { get { return _analysis13; } set { SetProperty(Propertyanalysis13, ref _analysis13, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Financial Account Analysis 14", Name="analysis14", Namespace="http://schemas.sage.com/sc/2009", DataType="string", Unsupported=true)]			
		public virtual System.String analysis14 { get { return _analysis14; } set { SetProperty(Propertyanalysis14, ref _analysis14, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEStringProperty(Label="Financial Account Analysis 15", Name="analysis15", Namespace="http://schemas.sage.com/sc/2009", DataType="string", Unsupported=true)]			
		public virtual System.String analysis15 { get { return _analysis15; } set { SetProperty(Propertyanalysis15, ref _analysis15, value); } }

		[SMEStringProperty(Label="FinancialAccount Currency", Name="currency", Namespace="http://schemas.sage.com/sc/2009", DataType="string", CanFilter=true)]			
		public virtual System.String currency { get { return _currency; } set { SetProperty(Propertycurrency, ref _currency, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="FinancialAccount Balance", Nillable=true, AverageLength=14, Name="balance", Namespace="http://schemas.sage.com/sc/2009")]			
		public virtual Nullable<System.Decimal> balance { get { return _balance; } set { SetProperty(Propertybalance, ref _balance, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDateProperty(Label="FinancialAccount Balance Date", Nillable=true, Name="balanceDate", Namespace="http://schemas.sage.com/sc/2009", Unsupported=true)]			
		public virtual Nullable<System.DateTime> balanceDate { get { return _balanceDate; } set { SetProperty(PropertybalanceDate, ref _balanceDate, value); } }
		
		/// <summary>
		/// This property is not supported by the SData provider.
		/// </summary>
		[SMEDateProperty(Label="FinancialAccount Last Transaction Date", Nillable=true, Name="lastTransactionDate", Namespace="http://schemas.sage.com/sc/2009", Unsupported=true)]			
		public virtual Nullable<System.DateTime> lastTransactionDate { get { return _lastTransactionDate; } set { SetProperty(PropertylastTransactionDate, ref _lastTransactionDate, value); } }

		[SMEBoolProperty(Label="FinancialAccount Primacy Indicator", Nillable=true, Name="primacyIndicator", Namespace="http://schemas.sage.com/sc/2009", CanFilter=true)]			
		public virtual Nullable<System.Boolean> primacyIndicator { get { return _primacyIndicator; } set { SetProperty(PropertyprimacyIndicator, ref _primacyIndicator, value); } }

		#endregion


	}
}