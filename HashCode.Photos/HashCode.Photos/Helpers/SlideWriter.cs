using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HashCode.Photos
{
    public class SlideWriter
    {
        public IEnumerable<string> Format(IEnumerable<Slide> slides)
        {
            var lines = new List<string>();

            lines.Add(slides.Count().ToString());

            foreach (var slide in slides)
            {
                lines.Add(string.Join(" ",
                    slide.Photos.Select(photo => photo.Id)));
            }

            return lines;
        }
    }
}
