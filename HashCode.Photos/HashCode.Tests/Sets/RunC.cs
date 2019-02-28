using System;
using System.Collections.Generic;
using System.Text;
using HashCode.Photos;
using Xunit;

namespace HashCode.Tests.Sets
{
    public class CTests
    {
        [Fact]
        public void RunC()
        {
            var runner = new Runner();

            runner.Run("input/c_memorable_moments.txt", "../../../output/c_memorable_moments.out");
        }
    }
}
