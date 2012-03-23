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

using System;
using MediaInfoLib;

namespace MediaInfoDotNet.Models
{
	///<summary>Represents a single audio stream.</summary>
	public sealed class AudioStream : Media
	{
		readonly MultiStreamCommon streamCommon;	

		///<summary>AudioStream constructor.</summary>
		///<param name="mediaInfo">A MediaInfo object.</param>
		///<param name="id">The MediaInfo ID for this audio stream.</param>
		public AudioStream(MediaInfo mediaInfo, int id) : base(mediaInfo, id) {
			kind = StreamKind.Audio;
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
		public string language { get { return streamCommon.language; } }
		/// <inheritdoc />
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
		

		int _channels = int.MinValue;
		///<summary>Number of audio channels, e.g. 6 for 5.1 audio.</summary>
		public int channels {
			get {
				if(_channels == int.MinValue)
					_channels = miGetInt("Channel(s)");
				return _channels;
			}
		}


		int _sampleRate = int.MinValue;
		///<summary>Audio sample rate, e.g. 44100 for CD audio.</summary>
		public int sampleRate {
			get {
				if(_sampleRate == int.MinValue)
					_sampleRate = miGetInt("SamplingRate");
				return _sampleRate;
			}
		}

	}
}
