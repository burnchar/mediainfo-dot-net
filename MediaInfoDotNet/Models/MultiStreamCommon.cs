using System;
using MediaInfoLib;

namespace MediaInfoDotNet.Models
{
	public class MultiStreamCommon : Media
	{
		public MultiStreamCommon(MediaInfo mediaInfo, StreamKind kind, int id)
			: base(mediaInfo, id) {
				this.kind = kind;
		}

		#region AllStreamsCommon
		string _format;
		///<summary>The format or container of this file or stream.</summary>
		///<example>Matroska, Windows Media, JPEG, MPEG-4.</example>
		public string format {
			get {
				if(_format == null)
					_format = miGetString("Format");
				return _format;
			}
		}


		string _title;
		///<summary>The title of the movie, track, song, etc..</summary>
		public string title {
			get {
				if(_title == null)
					_title = miGetString("Title");
				return _title;
			}
		}


		string _uniqueId;
		///<summary>This stream's globally unique ID (GUID).</summary>
		public string uniqueId {
			get {
				if(_uniqueId == null)
					_uniqueId = miGetString("UniqueID");
				return _uniqueId;
			}
		}
		#endregion

		#region VideoAudioTextCommon

		int _bitRate = int.MinValue;
		///<summary></summary>
		///<example></example>
		public int bitRate {
			get {
				if(_bitRate == int.MinValue)
					_bitRate = miGetInt("BitRate");
				return _bitRate;
			}
		}


		int _bitRateMaximum = int.MinValue;
		///<summary></summary>
		///<example></example>
		public int bitRateMaximum {
			get {
				if(_bitRateMaximum == int.MinValue)
					_bitRateMaximum = miGetInt("BitRate_Maximum");
				return _bitRateMaximum;
			}
		}


		int _bitRateMinimum = int.MinValue;
		///<summary></summary>
		///<example></example>
		public int bitRateMinimum {
			get {
				if(_bitRateMinimum == int.MinValue)
					_bitRateMinimum = miGetInt("BitRate_Minimum");
				return _bitRateMinimum;
			}
		}


		int _bitRateNominal = int.MinValue;
		///<summary></summary>
		///<example></example>
		public int bitRateNominal {
			get {
				if(_bitRateNominal == int.MinValue)
					_bitRateNominal = miGetInt("BitRate_Nominal");
				return _bitRateNominal;
			}
		}
			

		int _frameCount = int.MinValue;
		///<summary></summary>
		///<example></example>
		public int frameCount {
			get {
				if(_frameCount == int.MinValue)
					_frameCount = miGetInt("FrameCount");
				return _frameCount;
			}
		}


		string _bitRateMode = null;
		///<summary>Mode by which bits are allocated over time.</summary>
		///<example>Variable bit rate:VBR, Constant bit rate:CBR</example>
		public string bitRateMode {
			get {
				if(_bitRateMode == null)
					_bitRateMode = miGetString("BitRate_Mode");
				return _bitRateMode;
			}
		}


		string _muxingMode = null;
		///<summary>How the stream is muxed into the container.</summary>
		///<example></example>
		public string muxingMode {
			get {
				if(_muxingMode == null)
					_muxingMode = miGetString("MuxingMode");
				return _muxingMode;
			}
		}


		float _frameRate = float.MinValue;
		///<summary>Frame rate of the stream in frames per second.</summary>
		///<example>Standard film is 24FPS.</example>
		public float frameRate {
			get {
				if(_frameRate == float.MinValue)
					_frameRate = miGetFloat("FrameRate");
				return _frameRate;
			}
		}
		#endregion

		#region VideoAudioTextImageCommon
		string _compressionMode = null;
		///<summary></summary>
		///<example></example>
		public string compressionMode {
			get {
				if(_compressionMode == null)
					_compressionMode = miGetString("Compression_Mode");
				return _compressionMode;
			}
		}


		string _compressionRatio = null;
		///<summary></summary>
		///<example></example>
		public string compressionRatio {
			get {
				if(_compressionRatio == null)
					_compressionRatio = miGetString("Compression_Ratio");
				return _compressionRatio;
			}
		}


		int _bitDepth = int.MinValue;
		///<summary></summary>
		///<example></example>
		public int bitDepth {
			get {
				if(_bitDepth == int.MinValue)
					_bitDepth = miGetInt("BitDepth");
				return _bitDepth;
			}
		}

		#endregion

		#region GeneralVideoAudioTextImageMenuCommon
		string _codecId = null;
		///<summary>Codec ID available from some codecs.</summary>
		///<example>AAC audio:A_AAC, h.264 video:V_MPEG4/ISO/AVC</example>
		public string codecId {
			get {
				if(_codecId == null)
					_codecId = miGetString("CodecID");
				return _codecId;
			}
		}


		string _codecCommonName = null;
		///<summary>Common name of the codec.</summary>
		///<example></example>
		public string codecCommonName {
			get {
				if(_codecCommonName == null)
					_codecCommonName = miGetString("CodecID/Hint");
				return _codecCommonName;
			}
		}
		#endregion

		#region VideoAudioTextImageMenuCommon
		string _language = null;
		///<summary></summary>
		///<example></example>
		public string language {
			get {
				if(_language == null)
					_language = miGetString("Language");
				return _language;
			}
		}
		#endregion

		#region GeneralVideoAudioTextImageCommon

		DateTime _encodedDate = DateTime.MinValue;
		///<summary></summary>
		///<example></example>
		public DateTime encodedDate {
			get {
				if(_encodedDate == DateTime.MinValue)
					_encodedDate = miGetDateTime("Encoded_Date");
				return _encodedDate;
			}
		}


		string _encodedLibrary = null;
		///<summary></summary>
		///<example></example>
		public string encodedLibrary {
			get {
				if(_encodedLibrary == null)
					_encodedLibrary = miGetString("Encoded_Library");
				return _encodedLibrary;
			}
		}


		string _internetMediaType = null;
		///<summary>Media type of stream, formerly called MIME type.</summary>
		///<example>audio/x-aac, image/png, audio/mp3</example>
		public string internetMediaType {
			get {
				if(_internetMediaType == null)
					_internetMediaType = miGetString("InternetMediaType");
				return _internetMediaType;
			}
		}


		long _streamSize = long.MinValue;
		///<summary>Stream size in bytes.</summary>
		public long streamSize {
			get {
				if(_streamSize == long.MinValue)
					_streamSize = miGetLong("StreamSize");
				return _streamSize;
			}
		}

		#endregion

		#region VideoTextCommon

		string _frameRateMode = null;
		///<summary>Frame rate mode of stream.</summary>
		///<example>Constant frame rate:CFR, Variable frame rate:VFR</example>
		public string frameRateMode {
			get {
				if(_frameRateMode == null)
					_frameRateMode = miGetString("FrameRate_Mode");
				return _frameRateMode;
			}
		}

		#endregion

		#region GeneralVideoAudioTextMenu

		int _delay = int.MinValue;
		///<summary></summary>
		///<example></example>
		public int delay {
			get {
				if(_delay == int.MinValue)
					_delay = miGetInt("Delay");
				return _delay;
			}
		}


		int _duration = int.MinValue;
		///<summary>Duration of the stream in milliseconds.</summary>
		///<example>A 2 hour and 16 minute stream returns 8160000.</example>
		public int duration {
			get {
				if(_duration == int.MinValue)
					_duration = miGetInt("Duration");
				return _duration;
			}
		}

		#endregion

		#region VideoTextImageCommon

		int _height = int.MinValue;
		///<summary></summary>
		///<example></example>
		public int height {
			get {
				if(_height == int.MinValue)
					_height = miGetInt("Height");
				return _height;
			}
		}


		int _width = int.MinValue;
		///<summary></summary>
		///<example></example>
		public int width {
			get {
				if(_width == int.MinValue)
					_width = miGetInt("Width");
				return _width;
			}
		}

		#endregion

		#region VideoImageCommon
		
		float _pixelAspectRatio = float.MinValue;
		///<summary></summary>
		///<example></example>
		public float pixelAspectRatio {
			get {
				if(_pixelAspectRatio == float.MinValue)
					_pixelAspectRatio = miGetFloat("PixelAspectRatio");
				return _pixelAspectRatio;
			}
		}
		

		#endregion

	}
}
