/******************************************************************************
 * MediaInfo.NET - A fast, easy-to-use .NET wrapper for MediaInfo.
 * Use at your own risk, under the same license as MediaInfo itself.
 * Copyright (C) 2012 Charles N. Burns
 * 
 ******************************************************************************
 *
 * GeneralStream.cs
 * 
 * Presents information and functionality at the file-level.
 * 
 ******************************************************************************
 */

using System;
using MediaInfoLib;

namespace MediaInfoDotNet.Models
{
	/// <summary>For inheritance by classes representing media files.</summary>
	public abstract class GeneralStream : StreamBaseClass
	{
		/// <summary>Information about this media container or file.</summary>
		/// <param name="mediaInfo">A MediaInfo object.</param>
		/// <param name="id">The MediaInfo ID for this stream.</param>
		public GeneralStream(MediaInfo mediaInfo, int id) {
			this.mediaInfo = mediaInfo;
			this.id = id;
			this.streamKind = StreamKind.General;

			_encodedDate = DateTime.MinValue;
			_videoCount = int.MinValue;
			_audioCount = int.MinValue;
			_size = long.MinValue;
		}


		DateTime _encodedDate;
		/// <summary>The date/time this media file was created.</summary>
		public DateTime encodedDate {
			get {
				if(_encodedDate == DateTime.MaxValue)
					_encodedDate = miGetDateTime("Encoded_Date");
				return _encodedDate;
			}
		}


		int _videoCount;
		/// <summary>The count of video streams in this file.</summary>
		public int videoCount {
			get {
				if(_videoCount == int.MinValue)
					_videoCount = miGetInt("VideoCount");
				return _videoCount;
			}
		}


		int _audioCount;
		/// <summary>The count of audio streams in this file.</summary>
		public int audioCount {
			get {
				if(_audioCount == int.MinValue)
					_audioCount = miGetInt("AudioCount");
				return _audioCount;
			}
		}


		long _size;
		/// <summary>File size, in bytes.</summary>
		public long size {
			get {
				if(_size == long.MinValue)
					_size = miGetLong("FileSize");
				return _size;
			}
		}


		int _duration;
		/// <summary>Duration of the file in milliseconds.</summary>
		public int duration {
			get {
				if(_duration == int.MinValue)
					_duration = miGetInt("Duration");
				return _duration;
			}
		}
		


	}
}
