/******************************************************************************
 * MediaInfo.NET - A fast, easy-to-use .NET wrapper for MediaInfo.
 * Use at your own risk, under the same license as MediaInfo itself.
 * Copyright (C) 2012 Charles N. Burns
 * 
 * Official source code: https://code.google.com/p/mediainfo-dot-net/
 * 
 ******************************************************************************
 * Program.cs
 * 
 * Demonstrates the use of MediaInfoDotNet by gathering data from a video.
 * (The video is of me after having "rescued" a honey bee from my pool)
 * 
 * To use in a Visual Studio project:
 * Put these files inside all the folders within your project's "/Bin" folder
 *		MediaInfo.dll, MediaInfoDotNet.dll, sample.mkv 
 * 
 * e.g. if your project is named "test", those files would be in: 
 *  "c:\projects\test\test\Bin\Debug\" and "c:\projects\test\test\Bin\Release\"
 * or similar, depending on where you store your projects.
 * 
 ******************************************************************************
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaInfoDotNet;

namespace consoleSample
{
	class Program
	{
		static void Main() {

			string fileNameAndPath = "sample.mkv";
			var myVideo = new MediaFile(fileNameAndPath);

			//
			// Get a value that has to do with the whole file (not just one of its audio or other streams) easily:
			Console.Out.WriteLine("File size: " + myVideo.size + " bytes");

			//
			// Get audio info through the .Audio property.
			// You can loop through all audio streams with a simple "foreach"
			Console.Out.WriteLine(myVideo.filePath + " has " + myVideo.Audio.Count + " audio streams:");
			foreach(var aud in myVideo.Audio.Values) {
				Console.Out.WriteLine("    Audio channels:" + aud.channels + ", Format:" + aud.format);
			}

			// If you know your file has only one stream (audio, video, or otherwise)
			// you can use the array-like indexes like "[0]" used below
			if(myVideo.Video.Count > 0) {
				var vid = myVideo.Video[0];
				Console.Out.WriteLine("\nVideo format: " + vid.format);
				Console.Out.WriteLine("Video resolution: " + vid.width + "x" + vid.height);
			}


			// A little more advanced: You can use LINQ on your media files:
			Console.Out.WriteLine(
				"\nSubtitles languages: "
				+ String.Join(", ", myVideo.Text.Select(x => x.Value.language.ToUpperInvariant()))
			);

			return;
		}
	}
}
