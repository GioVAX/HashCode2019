using System;
using System.Collections.Generic;
using System.Text;
using HashCode.Photos;
using HashCode.Photos.Runners;
using Xunit;

namespace HashCode.Tests.Sets
{
    public class ETests
    {
        [Fact]
        public void Run()
        {
            var runner = new DefaultRunner("input/e_shiny_selfies.txt", "../../../output/e_shiny_selfies.out");

            runner.Run();
        }
    }
}
