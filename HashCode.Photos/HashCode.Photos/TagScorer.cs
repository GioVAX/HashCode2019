using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HashCode.Photos
{
    public class TagScorer
    {
        public static int Score(HashSet<string> tags1, HashSet<string> tags2)
        {
            var t1 = tags1.Count();
            var t2 = tags2.Count();
            if (t1 == 0 || t2 == 0)
                return 0;

            var commons = tags1.Intersect(tags2).Count();
            if (commons == 0)
                return 0;

            return Math.Min(commons, Math.Min(t1 - commons, t2 - commons));
        }
    }
}
