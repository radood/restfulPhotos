using System;
using System.Collections.Generic;

namespace RunPathApplication
{
    public class Albums
    {
        public string UserId { get; set; }
        public string Id { get; set; }
        public string Title { get; set; }

        public List<Photos> MyPhotos { get; set; }
    }

    public class Photos
    {
        public string AlbumId { get; set; }
        public string Id { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
        public string ThumbnailUrl { get; set; }
    }
}
