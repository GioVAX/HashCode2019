using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HashCode.Photos.Runners
{
    public class DefaultRunner : RunnerBase
    { 
        public DefaultRunner(string inputFilePath, string outputFilePath) : base (inputFilePath, outputFilePath) { }

        public override void Run()
        {
            var builder = new SimpleFlatBuilder();

            var slides = builder.Build(this.Photos.ToList());

            this.Save(slides);
        }
    }
}
