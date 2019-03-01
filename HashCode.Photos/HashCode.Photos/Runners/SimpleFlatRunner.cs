using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HashCode.Photos.Runners
{
    public class SimpleFlatRunner : RunnerBase
    {
        public SimpleFlatRunner(string inputFilePath, string outputFilePath)
            : base(inputFilePath, outputFilePath)
        {
        }

        public void Run()
        {
            var slides = new List<Slide>();
            foreach (var photo in this.Photos)
            {
                slides.Add(new Slide
                {
                    Photos = new List<Photo> { photo }
                });
            }

            var solutionSlides = new SlideShow().Compose(slides);

            this.Save(solutionSlides);
        }
    }
}
