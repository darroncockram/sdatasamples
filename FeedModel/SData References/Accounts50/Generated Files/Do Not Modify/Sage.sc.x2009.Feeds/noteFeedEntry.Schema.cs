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
	/// Defines a note feed entry
	/// </summary>
	#endregion
	[System.ComponentModel.Browsable(false)]
	[XmlType("note", Namespace="http://schemas.sage.com/sc/2009")]
	public class noteFeedEntrySchema : Sage.Common.Syndication.FeedEntry
	{
		#region Constants

		public const string Propertyactive = "active";
		public const string Propertyreference = "reference";
		public const string Propertyreference2 = "reference2";
		public const string Propertytext = "text";
		public const string PropertyprivacyFlag = "privacyFlag";
		public const string PropertydateStamp = "dateStamp";
		public const string PropertyprimacyIndicator = "primacyIndicator";
		public const string Propertyuser = "user";
		public const string PropertyapplicationID = "applicationID";

		#endregion

		#region Fields

		private Nullable<System.Boolean> _active;
		private System.String _reference;
		private System.String _reference2;
		private System.String _text;
		private Nullable<System.Boolean> _privacyFlag;
		private Nullable<System.DateTime> _dateStamp;
		private Nullable<System.Boolean> _primacyIndicator;
		private System.String _user;
		private System.String _applicationID;

		#endregion

		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="noteFeedEntrySchema"/> class.
		/// </summary>
		#endregion
		public noteFeedEntrySchema()
		{
		}

		#region Properties


		[SMEBoolProperty(Label="Note Active Flag", Nillable=true, Name="active", Namespace="http://schemas.sage.com/sc/2009", CanFilter=true)]			
		public virtual Nullable<System.Boolean> active { get { return _active; } set { SetProperty(Propertyactive, ref _active, value); } }

		[SMEStringProperty(Label="Note reference", Name="reference", Namespace="http://schemas.sage.com/sc/2009", DataType="string", CanFilter=true, IsUniqueKey=true)]			
		public virtual System.String reference { get { return _reference; } set { SetProperty(Propertyreference, ref _reference, value); } }

		[SMEStringProperty(Label="NoteReference2", Name="reference2", Namespace="http://schemas.sage.com/sc/2009", DataType="string", CanFilter=true)]			
		public virtual System.String reference2 { get { return _reference2; } set { SetProperty(Propertyreference2, ref _reference2, value); } }

		[SMEStringProperty(Label="Note Text", Name="text", Namespace="http://schemas.sage.com/sc/2009", DataType="string", IsMandatory=true)]			
		public virtual System.String text { get { return _text; } set { SetProperty(Propertytext, ref _text, value); } }

		[SMEBoolProperty(Label="Note Privacy Flag", Nillable=true, Name="privacyFlag", Namespace="http://schemas.sage.com/sc/2009")]			
		public virtual Nullable<System.Boolean> privacyFlag { get { return _privacyFlag; } set { SetProperty(PropertyprivacyFlag, ref _privacyFlag, value); } }

		[SMEDateProperty(Label="Note Date Stamp", Nillable=true, Name="dateStamp", Namespace="http://schemas.sage.com/sc/2009")]			
		public virtual Nullable<System.DateTime> dateStamp { get { return _dateStamp; } set { SetProperty(PropertydateStamp, ref _dateStamp, value); } }

		[SMEBoolProperty(Label="Note Primacy Indicator", Nillable=true, Name="primacyIndicator", Namespace="http://schemas.sage.com/sc/2009")]			
		public virtual Nullable<System.Boolean> primacyIndicator { get { return _primacyIndicator; } set { SetProperty(PropertyprimacyIndicator, ref _primacyIndicator, value); } }

		[SMEStringProperty(Label="Note User", Name="user", Namespace="http://schemas.sage.com/sc/2009", DataType="string")]			
		public virtual System.String user { get { return _user; } set { SetProperty(Propertyuser, ref _user, value); } }

		[SMEStringProperty(Label="Note Application ID", Name="applicationID", Namespace="http://schemas.sage.com/sc/2009", DataType="string", IsUniqueKey=true)]			
		public virtual System.String applicationID { get { return _applicationID; } set { SetProperty(PropertyapplicationID, ref _applicationID, value); } }

		#endregion


	}
}