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
	/// Defines a financialAccount Feed
	/// </summary>
	#endregion
	public class financialAccountFeed : Sage.Common.Syndication.Feed<financialAccountFeedEntry>
	{
		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="financialAccountFeed"/> class.
		/// </summary>
		#endregion
		public financialAccountFeed()
		{
		}
	}
}