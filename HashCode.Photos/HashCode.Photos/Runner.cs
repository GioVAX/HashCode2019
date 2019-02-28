using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace HashCode.Photos
{
    public class Runner
    {
        public void Run()
        {
            var input = File.ReadAllLines("a_example.txt");

            var headers = input[0];

            var photos = ParsePhotos(input.Skip(1));

        }

        private IEnumerable<Photo> ParsePhotos(IEnumerable<string> rows)
        {
            var id = -1;
            foreach (var photo in rows)
            {
                var columns = photo.Split(" ");
                var tags = columns[2].Split(" ").ToList();
                yield return new Photo
                {
                    Id = id++,
                    Orientation = columns[1],
                    Tags = tags
                };
            }
        }
    }
}
