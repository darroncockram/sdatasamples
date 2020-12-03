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
	/// Defines a note Feed
	/// </summary>
	#endregion
	public class noteFeed : Sage.Common.Syndication.Feed<noteFeedEntry>
	{
		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="noteFeed"/> class.
		/// </summary>
		#endregion
		public noteFeed()
		{
		}
	}
}