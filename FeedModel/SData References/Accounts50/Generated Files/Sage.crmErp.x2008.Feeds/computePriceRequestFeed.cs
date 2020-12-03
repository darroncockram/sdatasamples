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
	/// Defines a computePriceRequest Feed
	/// </summary>
	#endregion
	public class computePriceRequestFeed : Sage.Common.Syndication.Feed<computePriceRequestFeedEntry>
	{
		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="computePriceRequestFeed"/> class.
		/// </summary>
		#endregion
		public computePriceRequestFeed()
		{
		}
	}
}