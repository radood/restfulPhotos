# restfulPhotos

Once you run the application, you can visit:
https://localhost:44346/RunpathAlbums/1 to see the albums where 1 is the id of the album you want to see and all the corresponding photos.

You can also visit:
https://localhost:44346/RunpathAlbums/1/photo/2 to see the full details of a photo where 1 is the id of the album and 2 is the id of the photo.

If you try to visit a page for an id that does not exsist you will get an error. This has been properly covered in the unit testing where we are checking some successful get requests and some negative scenario get requests.
