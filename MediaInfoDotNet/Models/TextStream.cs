/******************************************************************************
 * MediaInfo.NET - A fast, easy-to-use .NET wrapper for MediaInfo.
 * Use at your own risk, under the same license as MediaInfo itself.
 * Copyright (C) 2012 Charles N. Burns
 * 
 ******************************************************************************
 * TextStream.cs
 * 
 * Presents information and functionality specific to a text (subtitle) stream.
 * 
 ******************************************************************************
 */

using MediaInfoLib;

namespace MediaInfoDotNet.Models
{
	/// <summary>Represents a single text stream.</summary>
	sealed class TextStream : StreamBaseClass
	{
		/// <summary>TextStream constructor.</summary>
		/// <param name="mediaInfo">A MediaInfo object.</param>
		/// <param name="id">The MediaInfo ID for this text stream.</param>
		public TextStream(MediaInfo mediaInfo, int id) {
			this.mediaInfo = mediaInfo;
			this.id = id;
			streamKind = StreamKind.Text;
		}
	
	}
}
