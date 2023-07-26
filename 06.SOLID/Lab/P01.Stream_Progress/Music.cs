﻿namespace P01.Stream_Progress
{
    public class Music : File
    {
        private string artist;
        private string album;

        public Music(string artist, string album, int length, int bytesSent)
            : base(artist, length, bytesSent)
        {
            this.artist = artist;
            this.album = album;
            this.Length = length;
            this.BytesSent = bytesSent;
        }

        public int Length { get; set; }
        public int ByteSent { get; set; }
    }
}
