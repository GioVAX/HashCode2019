using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HashCode.Photos.Runners
{

    public abstract class RunnerBase
    {
        private readonly string _inputFilePath;
        private readonly string _outputFilePath;

        public IEnumerable<Photo> Photos;

        public RunnerBase(string inputFilePath, string outputFilePath)
        {
            _inputFilePath = inputFilePath;
            _outputFilePath = outputFilePath;

            this.Photos = new PhotoReader().Read(_inputFilePath);
        }

        public abstract void Run();

        public void Save(IEnumerable<Slide> slides)
        {
            var slideWriter = new SlideWriter();
            var outputLines = slideWriter.Format(slides);

            File.WriteAllLines(this._outputFilePath, outputLines);
        }
    }
}
