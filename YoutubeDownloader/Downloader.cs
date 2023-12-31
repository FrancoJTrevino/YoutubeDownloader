using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeDownloader
{
    public static class Downloader
    {
        public static string[] VideoFormats { get; set; } = { "MP4", "WEBM", "AVI", "MOV", "FLV" };
        public static string[] AudioFormats { get; set; } = { "MP3", "WAV", "FLAC", "OGG" };
    }
}
