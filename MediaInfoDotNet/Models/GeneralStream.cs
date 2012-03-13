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

		/// <summary>GeneralStream constructor.</summary>
		/// <param name="filePath">Complete path and name of a file.</param>
		public GeneralStream(string filePath)
			: base(filePath) {
			base.streamKind = StreamKind.General;
		}


		DateTime _encodedDate = DateTime.MinValue;
		/// <summary>The date/time this media file was created.</summary>
		public DateTime encodedDate {
			get {
				if(_encodedDate == DateTime.MaxValue)
					_encodedDate = miGetDateTime("Encoded_Date");
				return _encodedDate;
			}
		}


		int _videoCount = int.MinValue;
		/// <summary>The count of video streams in this file.</summary>
		public int videoCount {
			get {
				if(_videoCount == int.MinValue)
					_videoCount = miGetInt("VideoCount");
				return _videoCount;
			}
		}


		int _audioCount = int.MinValue;
		/// <summary>The count of audio streams in this file.</summary>
		public int audioCount {
			get {
				if(_audioCount == int.MinValue)
					_audioCount = miGetInt("AudioCount");
				return _audioCount;
			}
		}


		long _size = long.MinValue;
		/// <summary>File size, in bytes.</summary>
		public long size {
			get {
				if(_size == long.MinValue)
					_size = miGetLong("FileSize");
				return _size;
			}
		}


		int _duration = int.MinValue;
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
