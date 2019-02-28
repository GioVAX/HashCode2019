using System;
using System.Collections.Generic;
using System.Text;
using HashCode.Photos;
using Xunit;

namespace HashCode.Tests.Sets
{
    public class ETests
    {
        [Fact]
        public void Run()
        {
            var runner = new Runner();

            runner.Run("input/e_shiny_selfies.txt", "../../../output/e_shiny_selfies.out");
        }
    }
}
