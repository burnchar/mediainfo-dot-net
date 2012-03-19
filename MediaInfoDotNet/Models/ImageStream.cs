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

using System;
using MediaInfoLib;
using MediaInfoDotNet;

namespace MediaInfoDotNet.Models
{
	///<summary>Represents a single image stream.</summary>
	public sealed class ImageStream : Media
	{
		readonly MultiStreamCommon streamCommon;

		///<summary>ImageStream constructor.</summary>
		///<param name="mediaInfo">A MediaInfo object.</param>
		///<param name="id">The MediaInfo ID for this image stream.</param>
		public ImageStream(MediaInfo mediaInfo, int id) : base(mediaInfo, id) {
			kind = StreamKind.Image;
			streamCommon = new MultiStreamCommon(mediaInfo, kind, id);
		}

		public string format { get { return streamCommon.format; } }
		public string title { get { return streamCommon.title; } }
		public string uniqueId { get { return streamCommon.uniqueId; } }
		public string codecId { get { return streamCommon.codecId; } }
		public string codecCommonName { get { return streamCommon.codecCommonName; } }
		public DateTime encodedDate { get { return streamCommon.encodedDate; } }
		public string encodedLibrary { get { return streamCommon.encodedLibrary; } }
		public string internetMediaType { get { return streamCommon.internetMediaType; } }
		public long streamSize { get { return streamCommon.streamSize; } }
		public string language { get { return streamCommon.language; } }
		public int bitDepth { get { return streamCommon.bitDepth; } }
		public string compressionMode { get { return streamCommon.compressionMode; } }
		public string compressionRatio { get { return streamCommon.compressionRatio; } }
		public int height { get { return streamCommon.height; } }
		public int width { get { return streamCommon.width; } }
		public float pixelAspectRatio { get { return streamCommon.pixelAspectRatio; } }
	}
}
