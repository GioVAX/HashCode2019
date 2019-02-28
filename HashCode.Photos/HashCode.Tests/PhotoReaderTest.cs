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

            Assert.Equal(1, photos[1].Id);
            Assert.Equal(Orientation.Vertical, photos[1].Orientation);
            Assert.Equal(2, photos[1].Tags.Count);
            Assert.Equal("selfie", photos[1].Tags[0]);
            Assert.Equal("smile", photos[1].Tags[1]);

            Assert.Equal(2, photos[2].Id);
            Assert.Equal(Orientation.Vertical, photos[2].Orientation);
            Assert.Equal(2, photos[2].Tags.Count);
            Assert.Equal("garden", photos[2].Tags[0]);
            Assert.Equal("selfie", photos[2].Tags[1]);

            Assert.Equal(3, photos[3].Id);
            Assert.Equal(Orientation.Horizontal, photos[3].Orientation);
            Assert.Equal(2, photos[3].Tags.Count);
            Assert.Equal("garden", photos[3].Tags[0]);
            Assert.Equal("cat", photos[3].Tags[1]);
        }
    }
}
