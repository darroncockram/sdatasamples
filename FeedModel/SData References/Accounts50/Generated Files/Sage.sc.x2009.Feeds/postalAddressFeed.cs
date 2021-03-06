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
	/// Defines a postalAddress Feed
	/// </summary>
	#endregion
	public class postalAddressFeed : Sage.Common.Syndication.Feed<postalAddressFeedEntry>
	{
		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="postalAddressFeed"/> class.
		/// </summary>
		#endregion
		public postalAddressFeed()
		{
		}
	}
}