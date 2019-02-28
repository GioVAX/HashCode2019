using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace HashCode.Photos
{
    public class Runner
    {
        public void Run(string inputFilePath, string outputFilePath)
        {
            var photos = new PhotoReader().Read(inputFilePath);

            var slides = new List<Slide>();
            foreach (var photo in photos)
            {
                slides.Add(new Slide
                {
                    Photos = new List<Photo> { photo }
                });
            }

            var solutionSlides = new SlideShow().Compose(slides);

            var slideWriter = new SlideWriter();
            var outputLines = slideWriter.Format(solutionSlides);

            File.WriteAllLines(outputFilePath, outputLines);
        }        
    }
}
