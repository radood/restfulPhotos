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
    public class RunpathPhotos : ControllerBase
    {
        public static readonly string albumsJson = new WebClient().DownloadString("http://jsonplaceholder.typicode.com/albums");

        List<Albums> resultAlbum = JsonConvert.DeserializeObject<List<Albums>>(albumsJson);

        public static readonly string photosJson = new WebClient().DownloadString("http://jsonplaceholder.typicode.com/photos");

        List <Photos> resultPhotos = JsonConvert.DeserializeObject<List<Photos>>(photosJson);

        private List<Photos> myPhotoList = new List<Photos> { };

        private readonly ILogger<RunpathPhotos> _logger;

        public RunpathPhotos(ILogger<RunpathPhotos> logger)
        {
            _logger = logger;
        }

        [HttpGet("{id}")]
        public IEnumerable<Albums> Get(int id)
        {

            foreach (Photos pho in resultPhotos)
            {
                if(pho.AlbumId == resultAlbum[id - 1].Id)
                {
                    myPhotoList.Add(pho);
                }
            }


            return Enumerable.Range(1, 1).Select(index => new Albums
            {
                Title = resultAlbum[id - 1].Title,
                MyPhotos = myPhotoList
            })
            .ToArray();
        }
    }
}
