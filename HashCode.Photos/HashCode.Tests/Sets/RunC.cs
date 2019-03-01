using System;
using System.Collections.Generic;
using System.Text;
using HashCode.Photos;
using HashCode.Photos.Runners;
using Xunit;

namespace HashCode.Tests.Sets
{
    public class CTests
    {
        [Fact]
        public void RunC()
        {
            var runner = new DefaultRunner("input/c_memorable_moments.txt", "../../../output/c_memorable_moments.out");

            runner.Run();
        }
    }
}
