using System;
using System.Collections.Generic;
using System.Text;
using HashCode.Photos;
using Xunit;

namespace HashCode.Tests.Sets
{
    public class BTests
    {
        [Fact]
        public void RunB()
        {
            var runner = new Runner();

            runner.Run("input/b_lovely_landscapes.txt", "../../../output/b_lovely_landscapes.out");
        }
    }
}
