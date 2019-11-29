using Microsoft.VisualStudio.TestTools.UnitTesting;
using RunPathApplication.Controllers;
using System;
using System.Collections.Generic;
using System.Text;

namespace RunPathApplication.Controllers.Tests
{
    [TestClass()]
    public class RunpathAlbumsTests
    {
        RunpathAlbums myController = new RunpathAlbums();

        [TestMethod()]
        public void RunpathAlbumsTestGetFirstAlbum()
        {
            Assert.AreEqual( myController.Get(1) , "Title: quidem molestiae enim, PhotoList: {https://via.placeholder.com/600/92c952,https://via.placeholder.com/600/771796,https://via.placeholder.com/600/24f355,https://via.placeholder.com/600/d32776,https://via.placeholder.com/600/f66b97,https://via.placeholder.com/600/56a8c2,https://via.placeholder.com/600/b0f7cc,https://via.placeholder.com/600/54176f,https://via.placeholder.com/600/51aa97,https://via.placeholder.com/600/810b14,https://via.placeholder.com/600/1ee8a4,https://via.placeholder.com/600/66b7d2,https://via.placeholder.com/600/197d29,https://via.placeholder.com/600/61a65,https://via.placeholder.com/600/f9cee5,https://via.placeholder.com/600/fdf73e,https://via.placeholder.com/600/9c184f,https://via.placeholder.com/600/1fe46f,https://via.placeholder.com/600/56acb2,https://via.placeholder.com/600/8985dc,https://via.placeholder.com/600/5e12c6,https://via.placeholder.com/600/45601a,https://via.placeholder.com/600/e924e6,https://via.placeholder.com/600/8f209a,https://via.placeholder.com/600/5e3a73,https://via.placeholder.com/600/474645,https://via.placeholder.com/600/c984bf,https://via.placeholder.com/600/392537,https://via.placeholder.com/600/602b9e,https://via.placeholder.com/600/372c93,https://via.placeholder.com/600/a7c272,https://via.placeholder.com/600/c70a4d,https://via.placeholder.com/600/501fe1,https://via.placeholder.com/600/35185e,https://via.placeholder.com/600/c96cad,https://via.placeholder.com/600/4d564d,https://via.placeholder.com/600/ea51da,https://via.placeholder.com/600/4f5b8d,https://via.placeholder.com/600/1e71a2,https://via.placeholder.com/600/3a0b95,https://via.placeholder.com/600/659403,https://via.placeholder.com/600/ca50ac,https://via.placeholder.com/600/6ad437,https://via.placeholder.com/600/29fe9f,https://via.placeholder.com/600/c4084a,https://via.placeholder.com/600/e9b68,https://via.placeholder.com/600/b4412f,https://via.placeholder.com/600/68e0a8,https://via.placeholder.com/600/2cd88b,https://via.placeholder.com/600/9e59da}");
        }

        [TestMethod()]
        public void RunpathAlbumsTestGetAlbumThatDoesNotExsist()
        {
            Assert.AreEqual(myController.Get(22222), "Sorry, that album does not exsist !!");
        }

        [TestMethod()]
        public void RunpathAlbumsTestGetFirstPhotoInFirstAlbum()
        {
            Assert.AreEqual(myController.Get(1,1), "Photo Title: accusamus beatae ad facilis cum similique qui sunt, Thumbnail Image: {https://via.placeholder.com/150/92c952, Full Image: https://via.placeholder.com/600/92c952");
        }

        [TestMethod()]
        public void RunpathAlbumsTestGetPhotoThatDoesNotExsist()
        {
            Assert.AreEqual(myController.Get(2, 1), "Sorry, that album does now own that picture !!");
        }

        [TestMethod()]
        public void RunpathAlbumsTestGetPhotoThatDoesNotExsistWithBadAlbumId()
        {
            Assert.AreEqual(myController.Get(22222, 1), "Sorry, that album does now own that picture !!");
        }

        [TestMethod()]
        public void RunpathAlbumsTestGetPhotoThatDoesNotExsistWithBadPhotoId()
        {
            Assert.AreEqual(myController.Get(1, 22222), "Sorry, that album does now own that picture !!");
        }

        [TestMethod()]
        public void RunpathAlbumsTestGetPhotoThatDoesNotExsistWithBadPhotoAndAlbumId()
        {
            Assert.AreEqual(myController.Get(222222, 22222), "Sorry, that album does now own that picture !!");
        }

    }
}