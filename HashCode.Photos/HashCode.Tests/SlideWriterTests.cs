using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HashCode.Photos;
using Xunit;

namespace HashCode.Tests
{
    public class SlideWriterTests
    {
        [Fact]
        public void Write()
        {
            var writer = new SlideWriter();

            var slides = new List<Slide>
            {
                new Slide
                {
                     Photos = new List<Photo>{new Photo { Id = 0 } }
                },
                new Slide
                {
                    Photos = new List<Photo>{new Photo { Id = 3 } }
                },
                new Slide
                {
                    Photos = new List<Photo>{ new Photo { Id = 1 }, new Photo { Id = 2} }
                }
            };

            var lines = writer.Format(slides).ToList();

            Assert.Equal(4, lines.Count());

            Assert.Equal("3", lines[0]);
            Assert.Equal("0", lines[1]);
            Assert.Equal("3", lines[2]);
            Assert.Equal("1 2", lines[3]);
        }
    }
}
