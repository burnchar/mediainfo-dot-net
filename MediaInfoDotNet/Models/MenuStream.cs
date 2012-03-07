/******************************************************************************
 * MediaInfo.NET - A fast, easy-to-use .NET wrapper for MediaInfo.
 * Use at your own risk, under the same license as MediaInfo itself.
 * Copyright (C) 2012 Charles N. Burns
 * 
 ******************************************************************************
 * MenuStream.cs
 * 
 * Presents information and functionality specific to a menu stream.
 * 
 ******************************************************************************
 */

using MediaInfoLib;

namespace MediaInfoDotNet.Models
{
	/// <summary>Represents a single menu stream.</summary>
	sealed class MenuStream : StreamBaseClass
	{		
		/// <summary>MenuStream constructor.</summary>
		/// <param name="mediaInfo">A MediaInfo object which has already opened a media file.</param>
		/// <param name="id">The MediaInfo ID for this menu stream.</param>
		public MenuStream(MediaInfo mediaInfo, int id) {
			this.mediaInfo = mediaInfo;
			this.id = id;
			//streamKind = StreamKind.Menu; /* Not yet included in MediaInfo's C# support file */
		}
	}
}
