using System;
using System.Collections.Generic;
using System.Text;

namespace HashCode.Photos.SlideshowBuilders
{
    public interface ISlideshowBuilder
    {
        IEnumerable<Slide> Build(IEnumerable<Photo> photos);
    }
}
