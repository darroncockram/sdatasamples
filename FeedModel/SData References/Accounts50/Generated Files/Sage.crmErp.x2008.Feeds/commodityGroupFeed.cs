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
	/// Defines a commodityGroup Feed
	/// </summary>
	#endregion
	public class commodityGroupFeed : Sage.Common.Syndication.Feed<commodityGroupFeedEntry>
	{
		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="commodityGroupFeed"/> class.
		/// </summary>
		#endregion
		public commodityGroupFeed()
		{
		}
	}
}