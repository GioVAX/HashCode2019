using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HashCode.Photos
{
    public class Slide
    {
        public List<Photo> Photos = new List<Photo>();

        public IEnumerable<string> Tags
        {
            get { return Photos.SelectMany(photo => photo.Tags); }
        }

        public int TotalTags
        {
            get { return Tags.Count(); }
        }
    }
}
