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
	/// Defines a financialPeriod feed entry
	/// </summary>
	#endregion
	[System.ComponentModel.Browsable(false)]
	[XmlType("financialPeriod", Namespace="http://schemas.sage.com/crmErp/2008")]
	public class financialPeriodFeedEntrySchema : Sage.Common.Syndication.FeedEntry
	{
		#region Constants

		public const string Propertyactive = "active";
		public const string Propertyreference = "reference";
		public const string Propertyyear = "year";
		public const string PropertyquarterNumber = "quarterNumber";
		public const string PropertyquarterText = "quarterText";
		public const string PropertymonthNumber = "monthNumber";
		public const string PropertymonthText = "monthText";
		public const string PropertyweekNumber = "weekNumber";
		public const string PropertyweekText = "weekText";
		public const string PropertystartDate = "startDate";
		public const string PropertyendDate = "endDate";
		public const string Propertynotes = "notes";

		#endregion

		#region Fields

		private Nullable<System.Boolean> _active;
		private System.String _reference;
		private System.String _year;
		private Nullable<System.Decimal> _quarterNumber;
		private System.String _quarterText;
		private Nullable<System.Decimal> _monthNumber;
		private System.String _monthText;
		private Nullable<System.Decimal> _weekNumber;
		private System.String _weekText;
		private System.String _startDate;
		private System.String _endDate;
		private noteFeed _notes;

		#endregion

		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="financialPeriodFeedEntrySchema"/> class.
		/// </summary>
		#endregion
		public financialPeriodFeedEntrySchema()
		{
		}

		#region Properties


		[SMEBoolProperty(Label="Financial Period Active Flag", Nillable=true, Name="active", Namespace="http://schemas.sage.com/crmErp/2008", CanFilter=true)]			
		public virtual Nullable<System.Boolean> active { get { return _active; } set { SetProperty(Propertyactive, ref _active, value); } }

		[SMEStringProperty(Label="Financial Period Reference", Name="reference", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String reference { get { return _reference; } set { SetProperty(Propertyreference, ref _reference, value); } }

		[SMEStringProperty(Label="Financial Period Year", Name="year", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String year { get { return _year; } set { SetProperty(Propertyyear, ref _year, value); } }

		[SMEDecimalProperty(DecimalPlaces=0, Label="Financial Period Quarter Number", Nillable=true, AverageLength=12, Name="quarterNumber", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> quarterNumber { get { return _quarterNumber; } set { SetProperty(PropertyquarterNumber, ref _quarterNumber, value); } }

		[SMEStringProperty(Label="Financial Period Quarter Text", Name="quarterText", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String quarterText { get { return _quarterText; } set { SetProperty(PropertyquarterText, ref _quarterText, value); } }

		[SMEDecimalProperty(DecimalPlaces=0, Label="Financial Period Month Number", Nillable=true, AverageLength=12, Name="monthNumber", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> monthNumber { get { return _monthNumber; } set { SetProperty(PropertymonthNumber, ref _monthNumber, value); } }

		[SMEStringProperty(Label="Financial Period Month Text", Name="monthText", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String monthText { get { return _monthText; } set { SetProperty(PropertymonthText, ref _monthText, value); } }

		[SMEDecimalProperty(DecimalPlaces=0, Label="Financial Period Week Number", Nillable=true, AverageLength=12, Name="weekNumber", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual Nullable<System.Decimal> weekNumber { get { return _weekNumber; } set { SetProperty(PropertyweekNumber, ref _weekNumber, value); } }

		[SMEStringProperty(Label="Financial Period Week Text", Name="weekText", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String weekText { get { return _weekText; } set { SetProperty(PropertyweekText, ref _weekText, value); } }

		[SMEStringProperty(Label="Financial Period Start Date", Name="startDate", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String startDate { get { return _startDate; } set { SetProperty(PropertystartDate, ref _startDate, value); } }

		[SMEStringProperty(Label="Financial Period End Date", Name="endDate", Namespace="http://schemas.sage.com/crmErp/2008", DataType="string", CanFilter=true)]			
		public virtual System.String endDate { get { return _endDate; } set { SetProperty(PropertyendDate, ref _endDate, value); } }

		[SMEResource(CanGet=true, CanPut=true, PluralName="notes", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Association, IsCollection=true, Name="notes", Namespace="http://schemas.sage.com/crmErp/2008")]			
		public virtual noteFeed notes { get { return _notes; } set { SetProperty(Propertynotes, ref _notes, value); } }

		#endregion


	}
}