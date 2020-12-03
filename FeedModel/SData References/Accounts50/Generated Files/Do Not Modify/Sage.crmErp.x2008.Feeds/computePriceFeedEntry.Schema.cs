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
	/// Defines a computePrice feed entry
	/// </summary>
	#endregion
	[System.ComponentModel.Browsable(false)]
	[XmlType("computePrice", Namespace="http://schemas.sage.com/crmErp/2008")]
	public class computePriceFeedEntrySchema : Sage.Common.Syndication.FeedEntry
	{
		#region Constants

		public const string Propertyrequest = "request";
		public const string Propertyresponse = "response";

		#endregion

		#region Fields

		private computePriceRequestFeedEntry _request;
		private computePriceRequestFeedEntry _response;

		#endregion

		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="computePriceFeedEntrySchema"/> class.
		/// </summary>
		#endregion
		public computePriceFeedEntrySchema()
		{
		}

		#region Properties


		[SMEResource(CanGet=true, CanPut=true, PluralName="computePriceSchema", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="request", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("request")]			
		public virtual computePriceRequestFeedEntry request { get { return _request; } set { SetProperty(Propertyrequest, ref _request, value); } }

		[SMEResource(CanGet=true, CanPut=true, PluralName="computePriceSchema", HasUuid=true)]
		[SMERelationshipProperty(Relationship=Sage.Common.Metadata.Model.RelationshipType.Reference, Name="response", Namespace="http://schemas.sage.com/crmErp/2008")]
		[XmlElement("response")]			
		public virtual computePriceRequestFeedEntry response { get { return _response; } set { SetProperty(Propertyresponse, ref _response, value); } }

		#endregion


	}
}