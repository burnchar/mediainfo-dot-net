/******************************************************************************
 * MediaInfo.NET - A fast, easy-to-use .NET wrapper for MediaInfo.dll
 * 
 * New versions available from http://code.google.com/p/mediainfo-dot-net/
 * 
 * Use at your own risk, under the same license as MediaInfo itself.
 * 
 * If you want to make a donation to this project, instead make it to the 
 * MediaInfo project at: http://mediainfo.sourceforge.net
 * 
 * Copyright (C) Charles N. Burns
 * 
 ******************************************************************************
 * 
 * MediaInfo.cs
 * 
 * Library entrypoint.
 * 
 * To make this work in your .NET project:
 * 1) Add this DLL, MediaInfoDotNet.dll, to your project's "references"
 * 2) Copy MediaInfo.DLL into each subfolder of your project's "bin\" folder
 *    You can download it from http://mediainfo.sourceforge.net
 *    Do not try to add MediaInfo.dll to your "references". Wrong type of DLL.
 */

using System;
using System.Collections.Generic;
using MediaInfoLib;
using MediaInfoDotNet.Models;

namespace MediaInfoDotNet
{
	/// <summary>Represents a media file.</summary>
	public sealed class MediaFile : GeneralStream, IDisposable
	{
		/// <summary>MediaFile constructor.</summary>
		/// <param name="filePath">Complete path and name of a file.</param>
		/// <example>"c:\pics\me.jpg", "/home/charles/me.jpg"</example>
		public MediaFile(string filePath)
			: base(new MediaInfo(), 0) {
			if(!isMediaInfoDllCompatible())
				throw new InvalidOperationException("Incompatible MediaInfo DLL version.");
			if(filePath == null)
				throw new ArgumentNullException("File name cannot be null.");

			mediaInfo.Open(filePath);
		}


		/// <summary>Destructor. Disposes of resources.</summary>
		~MediaFile() {
			Dispose();
		}


		Dictionary<int, AudioStream> _Audio;
		/// <summary>Audio streams in this file.</summary>
		public Dictionary<int, AudioStream> Audio {
			get {
				if(_Audio == null) {
					_Audio = new Dictionary<int, AudioStream>(audioCount);
					for(int id = 0; id < audioCount; ++id) {
						_Audio.Add(id, new AudioStream(mediaInfo, id));
					}
				}
				return _Audio;
			}
		}


		Dictionary<int, VideoStream> _Video;
		/// <summary>Video streams in this file.</summary>
		public Dictionary<int, VideoStream> Video {
			get {
				if(_Video == null) {
					_Video = new Dictionary<int, VideoStream>(videoCount);
					for(int id = 0; id < videoCount; ++id) {
						_Video.Add(id, new VideoStream(mediaInfo, id));
					}
				}
				return _Video;
			}
		}

		
		/// <summary>Returns true if MediaInfo.dll is compatible.</summary>
		bool isMediaInfoDllCompatible() {
			String ToDisplay =
				mediaInfo.Option("Info_Version", "0.7.0.0;MediaInfo.Net;0.1");
			return (ToDisplay.Length > 0 ? true : false);
		}

		bool disposed = false;
		/// <summary>Ensures resource disposal.</summary>
		public void Dispose() {
			if(disposed == false) {
				disposed = true;
				mediaInfo.Close();
				GC.SuppressFinalize(this);
			}
		}


	}
}
