/******************************************************************************
 * MediaInfo.NET - A fast, easy-to-use .NET wrapper for MediaInfo.
 * Use at your own risk, under the same license as MediaInfo itself.
 * Copyright (C) 2012 Charles N. Burns
 * 
 ******************************************************************************
 * MenuStream.cs
 * 
 * Presents information and functionality specific to a menu stream.
 * 
 ******************************************************************************
 */

using System;
using MediaInfoLib;
using MediaInfoDotNet.Models;

namespace MediaInfoDotNet.Models
{
	///<summary>Represents a single menu stream.</summary>
	public sealed class MenuStream : Media
	{
		readonly MultiStreamCommon streamCommon;

		///<summary>MenuStream constructor.</summary>
		///<param name="mediaInfo">A MediaInfo object which has already opened a media file.</param>
		///<param name="id">The MediaInfo ID for this menu stream.</param>
		public MenuStream(MediaInfo mediaInfo, int id) : base(mediaInfo, id) {
			kind = StreamKind.Menu;
			streamCommon = new MultiStreamCommon(mediaInfo, kind, id);
		}

		public string format { get { return streamCommon.format; } }
		public string title { get { return streamCommon.title; } }
		public string uniqueId { get { return streamCommon.uniqueId; } }
		public string codecId { get { return streamCommon.codecId; } }
		public string codecCommonName { get { return streamCommon.codecCommonName; } }
		public int delay { get { return streamCommon.delay; } }
		public int duration { get { return streamCommon.duration; } }
		public string language { get { return streamCommon.language; } }
	}
}
