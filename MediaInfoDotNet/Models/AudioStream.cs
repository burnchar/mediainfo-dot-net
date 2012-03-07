/******************************************************************************
 * MediaInfo.NET - A fast, easy-to-use .NET wrapper for MediaInfo.
 * Use at your own risk, under the same license as MediaInfo itself.
 * Copyright (C) 2012 Charles N. Burns
 * 
 ******************************************************************************
 *
 * AudioStream.cs
 * 
 * Presents information and functionality specific to an audio stream.
 * 
 ******************************************************************************
 */

using MediaInfoLib;

namespace MediaInfoDotNet.Models
{
	/// <summary>Represents a single audio stream.</summary>
	public sealed class AudioStream : StreamBaseClass
	{
		/// <summary>AudioStream constructor.</summary>
		/// <param name="mediaInfo">A MediaInfo object.</param>
		/// <param name="id">The MediaInfo ID for this audio stream.</param>
		public AudioStream(MediaInfo mediaInfo, int id) {
			this.mediaInfo = mediaInfo;
			this.id = id;
			streamKind = StreamKind.Audio;

			_channels = int.MinValue;
		}
	
		
		int _channels;
		/// <summary>Number of audio channels, e.g. 6 for 5.1 audio.</summary>
		public int channels {
			get {
				if(_channels == int.MinValue)
					_channels = miGetInt("Channel(s)");
				return _channels;
			}
		}

	}
}
