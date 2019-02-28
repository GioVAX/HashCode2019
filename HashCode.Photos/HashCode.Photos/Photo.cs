using System;
using System.Collections.Generic;
using System.Text;

namespace HashCode.Photos
{
    public class Photo
    {
        public int Id;
        public List<string> Tags = new List<string>();
        public Orientation Orientation;

    }

    public enum Orientation
    {
        Vertical,
        Horizontal
    }
}
