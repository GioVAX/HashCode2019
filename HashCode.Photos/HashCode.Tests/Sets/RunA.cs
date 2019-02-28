using System;
using System.Collections.Generic;
using System.Text;
using HashCode.Photos;
using Xunit;

namespace HashCode.Tests.Sets
{
    public class ATests
    {
        [Fact]
        public void RunA()
        {
            var runner = new Runner();

            runner.Run("input/a_example.txt", "../../../output/a_example.out");
        }
    }
}
