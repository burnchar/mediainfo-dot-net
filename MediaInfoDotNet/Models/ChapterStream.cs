/******************************************************************************
 * MediaInfo.NET - A fast, easy-to-use .NET wrapper for MediaInfo.
 * Use at your own risk, under the same license as MediaInfo itself.
 * Copyright (C) 2012 Charles N. Burns
 * 
 ******************************************************************************
 *
 * ChapterStream.cs
 * 
 * Presents information and functionality specific to a chapter stream.
 * 
 ******************************************************************************
 */

using MediaInfoLib;

namespace MediaInfoDotNet.Models
{
	/// <summary>Represents a single chapter stream.</summary>
	sealed class ChapterStream : StreamBaseClass
	{
		/// <summary>ChapterStream constructor.</summary>
		/// <param name="mediaInfo">A MediaInfo object.</param>
		/// <param name="id">The MediaInfo ID for this chapter stream.</param>
		public ChapterStream(MediaInfo mediaInfo, int id)
			: base(mediaInfo, id) {
			base.streamKind = StreamKind.Chapters;
		}

	}
}
