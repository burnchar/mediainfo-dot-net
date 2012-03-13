/******************************************************************************
 * MediaInfo.NET - A fast, easy-to-use .NET wrapper for MediaInfo.
 * Use at your own risk, under the same license as MediaInfo itself.
 * Copyright (C) 2012 Charles N. Burns
 * 
 ******************************************************************************
 *
 * ImageStream.cs
 * 
 * Presents information and functionality specific to an image stream.
 * 
 ******************************************************************************
 */

using MediaInfoLib;

namespace MediaInfoDotNet.Models
{
	/// <summary>Represents a single image stream.</summary>
	sealed class ImageStream : StreamBaseClass
	{
		/// <summary>ImageStream constructor.</summary>
		/// <param name="mediaInfo">A MediaInfo object.</param>
		/// <param name="id">The MediaInfo ID for this image stream.</param>
		public ImageStream(MediaInfo mediaInfo, int id)
			: base(mediaInfo, id) {
			streamKind = StreamKind.Image;
		}
	}
}
