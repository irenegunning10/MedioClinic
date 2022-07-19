using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Configuration
{
    public class MediaLibraryOptions
    {
		/// <summary>
		/// Image formats allowed in the site.
		/// </summary>
		public string[]? AllowedImageExtensions { get; set; }

		/// <summary>
		/// File size limit.
		/// </summary>
		public long FileSizeLimit { get; set; }
	}
}
