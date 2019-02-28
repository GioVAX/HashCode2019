using System;
using System.Collections.Generic;
using System.Text;
using HashCode.Photos;
using Xunit;

namespace HashCode.Tests.Sets
{
    public class AExampleTests
    {
        [Fact]
        public void Run_AExample()
        {
            var runner = new Runner();

            runner.Run("a_example.txt", "../../../a_example.out");
        }
    }
}
