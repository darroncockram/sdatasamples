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
	/// Defines a taxCode Feed Entry
	/// </summary>
	#endregion
	[SMEResource(HasUuid = true)]
	public class taxCodeFeedEntry : taxCodeFeedEntrySchema
	{
		#region Documentation
		/// <summary>
		/// Initialises a new instance of the <see cref="taxCodeFeedEntry"/> class.
		/// </summary>
		#endregion
		public taxCodeFeedEntry()
		{
		}
	}
}