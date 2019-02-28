using System.Collections.Generic;
using FluentAssertions;
using HashCode.Photos;
using Xunit;

namespace HashCode.Tests
{
    public class SlideShow_Tests
    {
        [Fact]
        public void ComposingTheExampleSlideshow_ShouldReturnTheExpectedResult()
        {
            var photo0 = new Photo { Id = 0, Orientation = Orientation.Horizontal, Tags = { "cat", "beach", "sun" } };
            var photo1 = new Photo { Id = 1, Orientation = Orientation.Vertical, Tags = { "selfie", "smile" } };
            var photo2 = new Photo { Id = 2, Orientation = Orientation.Vertical, Tags = { "garden", "selfie" } };
            var photo3 = new Photo { Id = 3, Orientation = Orientation.Horizontal, Tags = { "cat", "garden" } };

            var slide0 = new Slide {Photos = new List<Photo> {photo0}};
            var slide1 = new Slide {Photos = new List<Photo> {photo1, photo2}};
            var slide2 = new Slide {Photos = new List<Photo> {photo3}};

            var slides = new List<Slide>
            {
                slide0,
                slide1,
                slide2,
            };

            var slideShow = new SlideShow();

            slideShow.Compose(slides)
                .Should().ContainInOrder(new {slide0, slide2, slide1});
        }
    }
}
