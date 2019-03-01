using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using HashCode.Photos.SlideshowBuilders;

namespace HashCode.Photos.Runners
{
    public class SimpleFlatBuilder : ISlideshowBuilder
    {
        public IEnumerable<Slide> Build(IEnumerable<Photo> photos)
        {
            var slides = new List<Slide>();
            
            //Add all Horizontal
            slides.AddRange(
                photos
                    .Where(photo => photo.Orientation == Orientation.Horizontal)
                    .Select(photo => new Slide{Photos = new List<Photo>{photo}}));

            //Add pairs of vertical photos to a slide randomly
            var verticalPhotos = photos.Where(photo => photo.Orientation == Orientation.Vertical).ToList();
            for (var i = 0; i < verticalPhotos.Count(); i++)
            {
                var slide = new Slide {Photos = new List<Photo>{ verticalPhotos.ElementAt(i)}};
                if (verticalPhotos.ElementAtOrDefault(i + 1) != null)
                    slide.Photos.Add(verticalPhotos.ElementAt(i + 1));
                slides.Add(slide);
                i++;
            }
            
            /*
            var verticalPhotos = photos.Where(photo => photo.Orientation == Orientation.Vertical);
            slides.AddRange(verticalPhotos.Skip(2).Zip(verticalPhotos, (second, first) => new[] {first, second})
                .Select(pair =>
                    new Slide {Photos = new List<Photo> {pair[0], pair[1]}}));
            */

            return slides;
        }
    }
}
