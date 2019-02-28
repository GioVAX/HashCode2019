using System;
using System.Collections.Generic;
using System.IO;
using HashCode.Photos;
using Xunit;

namespace HashCode.Tests
{
    public class PhotoReaderTest
    {
        [Fact]
        public void Test1()
        {
            var reader = new PhotoReader();

            var photos = reader.Read("a_example.txt");

            Assert.Equal(4, photos.Count);

            Assert.Equal(0, photos[0].Id);
            Assert.Equal(Orientation.Horizontal, photos[0].Orientation);
            Assert.Equal(3, photos[0].Tags.Count);
            Assert.Equal("cat", photos[0].Tags[0]);
            Assert.Equal("beach", photos[0].Tags[1]);
            Assert.Equal("sun", photos[0].Tags[2]);
            }
    }
}
