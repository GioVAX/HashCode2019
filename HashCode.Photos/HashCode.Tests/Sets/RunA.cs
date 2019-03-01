using System;
using System.Collections.Generic;
using System.Text;
using HashCode.Photos;
using HashCode.Photos.Runners;
using Xunit;

namespace HashCode.Tests.Sets
{
    public class ATests
    {
        [Fact]
        public void RunA()
        {
            var runner = new DefaultRunner("input/a_example.txt", "../../../output/a_example.out");

            runner.Run();
        }
    }
}
