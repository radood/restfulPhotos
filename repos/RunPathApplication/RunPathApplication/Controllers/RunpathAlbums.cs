using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace RunPathApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RunpathAlbums : ControllerBase
    {
        public static readonly string albumsJson = new WebClient().DownloadString("http://jsonplaceholder.typicode.com/albums");

        List<Albums> resultAlbum = JsonConvert.DeserializeObject<List<Albums>>(albumsJson);

        public static readonly string photosJson = new WebClient().DownloadString("http://jsonplaceholder.typicode.com/photos");

        List <Photos> resultPhotos = JsonConvert.DeserializeObject<List<Photos>>(photosJson);

        [HttpGet("{id}")]
        public string Get(int id)
        {
            string albums = "Sorry, that album does not exsist !!";

            if(resultAlbum.ElementAtOrDefault(id - 1) != null )
            {
                List<string> photos = new List<string> { };
                foreach (Photos pho in resultPhotos)
                {
                    if (pho.AlbumId == resultAlbum[id - 1].Id)
                    {
                        photos.Add(pho.Url);
                    }
                }

                albums = "Title: " + resultAlbum[id - 1].Title + ", PhotoList: {" + string.Join(",", photos) + "}";
            }

            return albums;
        }

        [HttpGet("{id}/photo/{photoId}")]
        public string Get(int id, int photoId)
        {
            string album = "Sorry, that album does now own that picture !!";

            if ((resultPhotos.ElementAtOrDefault(photoId - 1) != null) && (resultAlbum.ElementAtOrDefault(id - 1) != null) && (resultPhotos[photoId - 1].AlbumId == resultAlbum[id - 1].Id))
            {
                album = "Photo Title: " + resultPhotos[photoId - 1].Title + ", Thumbnail Image: {" + resultPhotos[photoId - 1].ThumbnailUrl + ", Full Image: " + resultPhotos[photoId - 1].Url;
            }
            return album;
        }
    }
}
