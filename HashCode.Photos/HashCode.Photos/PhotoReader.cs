using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace HashCode.Photos
{
    public class PhotoReader
    {
        public List<Photo> Read(string filePath)
        {
            var input = File.ReadAllLines(filePath);

            var totalRows = Int16.Parse(input[0]);

            var photos = ParsePhotos(input.Skip(1));

            if (totalRows != photos.Count())
                throw new Exception("Failed to read rows correctly");

            return photos.ToList();
        }

        private IEnumerable<Photo> ParsePhotos(IEnumerable<string> rows)
        {
            var id = 0;
            foreach (var photo in rows)
            {
                var columns = photo.Split(" ");
                var expectedTagCount = Int16.Parse(columns[1]);
                var tags = columns.Skip(2).ToList();

                if(expectedTagCount != tags.Count())
                    throw new Exception("Tags not read correctly");

                yield return new Photo
                {
                    Id = id++,
                    Orientation = columns[0] == "H" ? Orientation.Horizontal : Orientation.Vertical,
                    Tags = tags
                };
            }
        }
    }
}
