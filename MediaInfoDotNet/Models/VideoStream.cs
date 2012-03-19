/******************************************************************************
 * MediaInfo.NET - A fast, easy-to-use .NET wrapper for MediaInfo.
 * Use at your own risk, under the same license as MediaInfo itself.
 * Copyright (C) 2012 Charles N. Burns
 * 
 ******************************************************************************
 * VideoStream.cs
 * 
 * Presents information and functionality specific to a video stream.
 * 
 ******************************************************************************
 */

using System;
using MediaInfoLib;

namespace MediaInfoDotNet.Models
{
	///<summary>Represents a single video stream.</summary>
	public sealed class VideoStream : Media
	{
		readonly MultiStreamCommon streamCommon;
 
		///<summary>VideoStream constructor</summary>
		///<param name="mediaInfo">A MediaInfo object.</param>
		///<param name="id">The MediaInfo ID for this audio stream.</param>
		public VideoStream(MediaInfo mediaInfo, int id) : base(mediaInfo, id) {
			kind = StreamKind.Video;
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
		public int delay { get { return streamCommon.delay; } }
		public int duration { get { return streamCommon.duration; } }
		public string language { get { return streamCommon.language; } }
		public int bitDepth { get { return streamCommon.bitDepth; } }
		public string compressionMode { get { return streamCommon.compressionMode; } }
		public string compressionRatio { get { return streamCommon.compressionRatio; } }
		public int bitRate { get { return streamCommon.bitRate; } }
		public string bitRateMode { get { return streamCommon.bitRateMode; } }
		public int bitRateMaximum { get { return streamCommon.bitRateMaximum; } }
		public int bitRateMinimum { get { return streamCommon.bitRateMinimum; } }
		public int bitRateNominal { get { return streamCommon.bitRateNominal; } }
		public int frameCount { get { return streamCommon.frameCount; } }
		public string muxingMode { get { return streamCommon.muxingMode; } }
		public int height { get { return streamCommon.height; } }
		public int width { get { return streamCommon.width; } }
		public float frameRate { get { return streamCommon.frameRate; } }
		public string frameRateMode { get { return streamCommon.frameRateMode; } }
		public float pixelAspectRatio { get { return streamCommon.pixelAspectRatio; } }
		//{ get { return streamCommon; } }

	}
}
