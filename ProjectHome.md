## MediaInfo.NET allows .NET programs to easily get media file information using a very natural ".NET way" code. ##

See for yourself! Download the _sample application_ from Google or Dropbox below:

  * https://docs.google.com/file/d/0B-GRK7Wsszy2cjdPMlpseHhMZFE/edit?usp=sharing
  * https://www.dropbox.com/s/jh3elsahvtfv6mk/MediaInfoDotNet-sample-v2.zip

**Example uses:**
  * Easily find a movie file's bit rate, the date it was made, or all its subtitle languages.
  * Want to know if an MP3 was encoded using VBR (variable bit rate) or CBR? No problem!

```
// Get the format and number of audio channels (stereo, etc.) for each audio track
foreach(var aud in myVideo.Audio.Values) {
	Console.Out.WriteLine("Audio channels:" + aud.channels + ", Format:" + aud.format);
}
```
Uses MediaInfo (included). Latest version at http://mediaarea.net/en/MediaInfo

License is the same as MediaInfo (see: http://mediaarea.net/en/MediaInfo/License).
Short, unofficial version: Include the following copyright with your binary and source distributions and you are welcome to use this library, even for commercial software, free of license charges:
Copyright (C) 2012-2013 Charles Burns