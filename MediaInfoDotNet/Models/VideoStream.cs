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

using MediaInfoLib;

namespace MediaInfoDotNet.Models
{
	/// <summary>Represents a single video stream.</summary>
	public sealed class VideoStream : StreamBaseClass
	{
		/// <summary>VideoStream constructor</summary>
		/// <param name="mediaInfo">A MediaInfo object.</param>
		/// <param name="id">The MediaInfo ID for this audio stream.</param>
		public VideoStream(MediaInfo mediaInfo, int id) {
			this.mediaInfo = mediaInfo;
			this.id = id;
			this.streamKind = StreamKind.Video;

			_height = int.MinValue;
			_width = int.MinValue;
		}

	
		int _height;
		/// <summary>Height in pixels.</summary>
		public int height {
			get {
				if(_height == int.MinValue) _height = miGetInt("Height");
				return _height;
			}
		}


		int _width;
		/// <summary>Width pixels.</summary>
		public int width {
			get {
				if(_width == int.MinValue) _width = miGetInt("Width");
				return _width;
			}
		}

	}
}
