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
	/// Defines a tradingAccountSummary feed entry
	/// </summary>
	#endregion
	[System.ComponentModel.Browsable(false)]
	[XmlType("tradingAccountSummary", Namespace="http://schemas.sage.com/crmErp/2008")]
	public class tradingAccountSummaryFeedEntrySchema : Sage.Common.Syndication.FeedEntry
	{
		#region Constants

		public const string PropertyapplicationID = "applicationID";
		public const string PropertyaccountName = "accountName";
		public const string Propertystatus = "status";
		public const string PropertyaccountOnHold = "accountOnHold";
		public const string Propertybalance = "balance";
		public const string PropertycreditLimit = "creditLimit";
		public const string PropertyMTDTurnover = "MTDTurnover";
		public const string PropertyYTDTurnover = "YTDTurnover";
		public const string PropertypriorYTDTurnover = "priorYTDTurnover";
		public const string PropertyfirstInvoiceDate = "firstInvoiceDate";
		public const string PropertylastInvoiceDate = "lastInvoiceDate";
		public const string PropertylastPaymentDate = "lastPaymentDate";
		public const string PropertyaccountOpenedDate = "accountOpenedDate";
		public const string PropertylastCreditReviewDate = "lastCreditReviewDate";
		public const string PropertytradingTerms = "tradingTerms";
		public const string PropertypriceList = "priceList";
		public const string PropertystandardDiscount = "standardDiscount";
		public const string Propertyanalysis1 = "analysis1";
		public const string Propertyanalysis2 = "analysis2";
		public const string Propertyanalysis3 = "analysis3";
		public const string PropertycanChargeCredit = "canChargeCredit";
		public const string PropertynextCreditReviewDate = "nextCreditReviewDate";
		public const string PropertyadditionalDiscount = "additionalDiscount";
		public const string PropertycreditAppliedDate = "creditAppliedDate";
		public const string PropertysettlementDiscountPercent = "settlementDiscountPercent";
		public const string PropertysettlementDiscountTerms = "settlementDiscountTerms";
		public const string PropertytermsAgreed = "termsAgreed";
		public const string PropertycustomerSupplier = "customerSupplier";

		#endregion

		#region Fields

		private System.String _applicationID;
		private System.String _accountName;
		private System.String _status;
		private Nullable<System.Boolean> _accountOnHold;
		private Nullable<System.Decimal> _balance;
		private Nullable<System.Decimal> _creditLimit;
		private Nullable<System.Decimal> _MTDTurnover;
		private Nullable<System.Decimal> _YTDTurnover;
		private Nullable<System.Decimal> _priorYTDTurnover;
		private Nullable<System.DateTime> _firstInvoiceDate;
		private Nullable<System.DateTime> _lastInvoiceDate;
		private Nullable<System.DateTime> _lastPaymentDate;
		private Nullable<System.DateTime> _accountOpenedDate;
		private Nullable<System.DateTime> _lastCreditReviewDate;
		private System.String _tradingTerms;
		private System.String _priceList;
		private Nullable<System.Decimal> _standardDiscount;
		private System.String _analysis1;
		private System.String _analysis2;
		private System.String _analysis3;
		private Nullable<System.Boolean> _canChargeCredit;
		private Nullable<System.DateTime> _nextCreditReviewDate;
		private System.String _additionalDiscount;
		private Nullable<System.DateTime> _creditAppliedDate;
		private Nullable<System.Decimal> _settlementDiscountPercent;
		private System.String _settlementDiscountTerms;
		private Nullable<System.Boolean> _termsAgreed;
		private System.String _customerSupplier;

		#endregion

		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="tradingAccountSummaryFeedEntrySchema"/> class.
		/// </summary>
		#endregion
		public tradingAccountSummaryFeedEntrySchema()
		{
		}

		#region Properties


		[SMEStringProperty(Label="tradingAccountSummary Application ID", Name="applicationID", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true, IsUniqueKey=true)]			
		public virtual System.String applicationID { get { return _applicationID; } set { SetProperty(PropertyapplicationID, ref _applicationID, value); } }

		[SMEStringProperty(Label="tradingAccountSummary accountName", Name="accountName", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String accountName { get { return _accountName; } set { SetProperty(PropertyaccountName, ref _accountName, value); } }

		[SMEStringProperty(Label="tradingAccountSummary status", Name="status", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String status { get { return _status; } set { SetProperty(Propertystatus, ref _status, value); } }

		[SMEBoolProperty(Label="tradingAccountSummary on hold flag", Nillable=true, Name="accountOnHold", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.Boolean> accountOnHold { get { return _accountOnHold; } set { SetProperty(PropertyaccountOnHold, ref _accountOnHold, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="Trading Account Balance", Nillable=true, AverageLength=14, Name="balance", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.Decimal> balance { get { return _balance; } set { SetProperty(Propertybalance, ref _balance, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="Trading Account Credit Limit", Nillable=true, AverageLength=14, Name="creditLimit", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.Decimal> creditLimit { get { return _creditLimit; } set { SetProperty(PropertycreditLimit, ref _creditLimit, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="Trading Account Month To Date Turnover", Nillable=true, AverageLength=14, Name="MTDTurnover", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.Decimal> MTDTurnover { get { return _MTDTurnover; } set { SetProperty(PropertyMTDTurnover, ref _MTDTurnover, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="Trading Account Year To Date Turnover", Nillable=true, AverageLength=14, Name="YTDTurnover", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.Decimal> YTDTurnover { get { return _YTDTurnover; } set { SetProperty(PropertyYTDTurnover, ref _YTDTurnover, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="Trading Account Prior Year To Date Turnover", Nillable=true, AverageLength=14, Name="priorYTDTurnover", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.Decimal> priorYTDTurnover { get { return _priorYTDTurnover; } set { SetProperty(PropertypriorYTDTurnover, ref _priorYTDTurnover, value); } }

		[SMEDateProperty(Label="Trading Account First Invoice Date", Nillable=true, Name="firstInvoiceDate", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.DateTime> firstInvoiceDate { get { return _firstInvoiceDate; } set { SetProperty(PropertyfirstInvoiceDate, ref _firstInvoiceDate, value); } }

		[SMEDateProperty(Label="Trading Account Last Invoice Date", Nillable=true, Name="lastInvoiceDate", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.DateTime> lastInvoiceDate { get { return _lastInvoiceDate; } set { SetProperty(PropertylastInvoiceDate, ref _lastInvoiceDate, value); } }

		[SMEDateProperty(Label="Trading Account Last Payment Date", Nillable=true, Name="lastPaymentDate", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.DateTime> lastPaymentDate { get { return _lastPaymentDate; } set { SetProperty(PropertylastPaymentDate, ref _lastPaymentDate, value); } }

		[SMEDateProperty(Label="Trading Account Account Opened Date", Nillable=true, Name="accountOpenedDate", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.DateTime> accountOpenedDate { get { return _accountOpenedDate; } set { SetProperty(PropertyaccountOpenedDate, ref _accountOpenedDate, value); } }

		[SMEDateProperty(Label="Trading Account Last Credit Review Date", Nillable=true, Name="lastCreditReviewDate", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.DateTime> lastCreditReviewDate { get { return _lastCreditReviewDate; } set { SetProperty(PropertylastCreditReviewDate, ref _lastCreditReviewDate, value); } }

		[SMEStringProperty(Label="Trading Account Trading Terms", Name="tradingTerms", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String tradingTerms { get { return _tradingTerms; } set { SetProperty(PropertytradingTerms, ref _tradingTerms, value); } }

		[SMEStringProperty(Label="Trading Account Price List", Name="priceList", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String priceList { get { return _priceList; } set { SetProperty(PropertypriceList, ref _priceList, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="Trading Account Standard Discount", Nillable=true, AverageLength=14, Name="standardDiscount", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.Decimal> standardDiscount { get { return _standardDiscount; } set { SetProperty(PropertystandardDiscount, ref _standardDiscount, value); } }

		[SMEStringProperty(Label="Trading Account Analysis Field 1", Name="analysis1", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String analysis1 { get { return _analysis1; } set { SetProperty(Propertyanalysis1, ref _analysis1, value); } }

		[SMEStringProperty(Label="Trading Account Analysis Field 2", Name="analysis2", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String analysis2 { get { return _analysis2; } set { SetProperty(Propertyanalysis2, ref _analysis2, value); } }

		[SMEStringProperty(Label="Trading Account Analysis Field 3", Name="analysis3", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String analysis3 { get { return _analysis3; } set { SetProperty(Propertyanalysis3, ref _analysis3, value); } }

		[SMEBoolProperty(Label="Trading Account Can Charge Credit", Nillable=true, Name="canChargeCredit", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.Boolean> canChargeCredit { get { return _canChargeCredit; } set { SetProperty(PropertycanChargeCredit, ref _canChargeCredit, value); } }

		[SMEDateProperty(Label="Trading Account Next Credit Review Date", Nillable=true, Name="nextCreditReviewDate", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.DateTime> nextCreditReviewDate { get { return _nextCreditReviewDate; } set { SetProperty(PropertynextCreditReviewDate, ref _nextCreditReviewDate, value); } }

		[SMEStringProperty(Label="Trading Account Additional Discount Type", Name="additionalDiscount", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String additionalDiscount { get { return _additionalDiscount; } set { SetProperty(PropertyadditionalDiscount, ref _additionalDiscount, value); } }

		[SMEDateProperty(Label="Trading Account Credit Applied date", Nillable=true, Name="creditAppliedDate", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.DateTime> creditAppliedDate { get { return _creditAppliedDate; } set { SetProperty(PropertycreditAppliedDate, ref _creditAppliedDate, value); } }

		[SMEDecimalProperty(DecimalPlaces=2, Label="TradingAccount Settlement Discount Percent", Nillable=true, AverageLength=14, Name="settlementDiscountPercent", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.Decimal> settlementDiscountPercent { get { return _settlementDiscountPercent; } set { SetProperty(PropertysettlementDiscountPercent, ref _settlementDiscountPercent, value); } }

		[SMEStringProperty(Label="TradingAccount Settlement Discount Terms", Name="settlementDiscountTerms", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String settlementDiscountTerms { get { return _settlementDiscountTerms; } set { SetProperty(PropertysettlementDiscountTerms, ref _settlementDiscountTerms, value); } }

		[SMEBoolProperty(Label="Trading Account Terms Agreed", Nillable=true, Name="termsAgreed", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.Boolean> termsAgreed { get { return _termsAgreed; } set { SetProperty(PropertytermsAgreed, ref _termsAgreed, value); } }

		[SMEStringProperty(Label="TradingAccount Customer Supplier Flag", Name="customerSupplier", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String customerSupplier { get { return _customerSupplier; } set { SetProperty(PropertycustomerSupplier, ref _customerSupplier, value); } }

		#endregion


	}
}