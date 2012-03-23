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
using MediaInfoDotNet.Models;

namespace MediaInfoDotNet.Models
{
	///<summary>For inheritance by classes representing media files.</summary>
	public abstract class GeneralStream : Media
	{
		readonly MultiStreamCommon streamCommon;

		///<summary>GeneralStream constructor.</summary>
		///<param name="filePath">Complete path and name of a file.</param>
		public GeneralStream(string filePath) : base(filePath) {
			kind = StreamKind.General;
			streamCommon = new MultiStreamCommon(mediaInfo, kind, id);
		}

		public string format { get { return streamCommon.format; } }
		public string title { get { return streamCommon.title; } }
		public string uniqueId { get { return streamCommon.uniqueId; } }
		public string codecId { get { return streamCommon.codecId; } }
		public string codecCommonName { get { return streamCommon.codecCommonName; } }
		public DateTime encodedDate { get { return streamCommon.encodedDate; } }
		public string encodedLibrary { get { return streamCommon.encoderLibrary; } }
		public string encoderSettings { get { return streamCommon.encoderSettings; } }
		public string internetMediaType { get { return streamCommon.internetMediaType; } }
		public long streamSize { get { return streamCommon.streamSize; } }
		public int delay { get { return streamCommon.delay; } }
		public int duration { get { return streamCommon.duration; } }


		int _videoCount = int.MinValue;
		///<summary>Number of video streams in this file.</summary>
		protected int videoCount {
			get {
				if(_videoCount == int.MinValue)
					_videoCount = miGetInt("VideoCount");
				return _videoCount;
			}
		}


		int _audioCount = int.MinValue;
		///<summary>Number of audio streams in this file.</summary>
		protected int audioCount {
			get {
				if(_audioCount == int.MinValue)
					_audioCount = miGetInt("AudioCount");
				return _audioCount;
			}
		}


		int _textCount = int.MinValue;
		///<summary>Number of subtitles or other texts in this file.</summary>
		protected int textCount {
			get {
				if(_textCount == int.MinValue)
					_textCount = miGetInt("TextCount");
				return _textCount;
			}
		}


		int _imageCount = int.MinValue;
		///<summary>Number of images in this file.</summary>
		protected int imageCount {
			get {
				if(_imageCount == int.MinValue)
					_imageCount = miGetInt("ImageCount");
				return _imageCount;
			}
		}


		int _chapterCount = int.MinValue;
		///<summary>Number of chapters in this file.</summary>
		protected int chapterCount {
			get {
				if(_chapterCount == int.MinValue)
					_chapterCount = miGetInt("ChaptersCount");
				return _chapterCount;
			}
		}


		int _menuCount = int.MinValue;
		///<summary>Number of menu streams in this file.</summary>
		protected int menuCount {
			get {
				if(_menuCount == int.MinValue)
					_menuCount = miGetInt("MenuCount");
				return _menuCount;
			}
		}

	
		long _size = long.MinValue;
		///<summary>File size, in bytes.</summary>
		public long size {
			get {
				if(_size == long.MinValue)
					_size = miGetLong("FileSize");
				return _size;
			}
		}


		string _encodedBy;
		///<summary>Name of the person/group who encoded this file.</summary>
		public string encodedBy {
			get {
				if(_encodedBy == null)
					_encodedBy = miGetString("EncodedBy");
				return _encodedBy;
			}
		}


		string _album;
		///<summary>Album name, if the file represents an album.</summary>
		public string album {
			get {
				if(_album == null)
					_album = miGetString("Album");
				return _album;
			}
		}



		string _iTunesGrouping = null;
		///<summary></summary>
		///<example></example>
		public string iTunesGrouping {
			get {
				if(_iTunesGrouping == null)
					_iTunesGrouping = miGetString("Grouping");
				return _iTunesGrouping;
			}
		}


		string _iTunesCompilation = null;
		///<summary></summary>
		///<example></example>
		public string iTunesCompilation {
			get {
				if(_iTunesCompilation == null)
					_iTunesCompilation = miGetString("Compilation");
				return _iTunesCompilation;
			}
		}


		int _bitRate = int.MinValue;
		///<summary>Overall bitrate of all streams in this file.</summary>
		///<example></example>
		public int bitRate {
			get {
				if(_bitRate == int.MinValue)
					_bitRate = miGetInt("OverallBitRate");
				return _bitRate;
			}
		}



		int _bitRateMaximum = int.MinValue;
		///<summary></summary>
		///<example></example>
		public int bitRateMaximum {
			get {
				if(_bitRateMaximum == int.MinValue)
					_bitRateMaximum = miGetInt("OverallBitRate_Maximum");
				return _bitRateMaximum;
			}
		}


		int _bitRateMinimum = int.MinValue;
		///<summary></summary>
		///<example></example>
		public int bitRateMinimum {
			get {
				if(_bitRateMinimum == int.MinValue)
					_bitRateMinimum = miGetInt("OverallBitRate_Minimum");
				return _bitRateMinimum;
			}
		}


		int _bitRateNominal = int.MinValue;
		///<summary></summary>
		///<example></example>
		public int bitRateNominal {
			get {
				if(_bitRateNominal == int.MinValue)
					_bitRateNominal = miGetInt("OverallBitRate_Nominal");
				return _bitRateNominal;
			}
		}
			
				

	}
}
