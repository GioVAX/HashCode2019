using System;
using System.Collections.Generic;
using System.Text;
using HashCode.Photos;
using Xunit;

namespace HashCode.Tests.Sets
{
    public class DTests
    {
        [Fact]
        public void RunD()
        {
            var runner = new Runner();

            runner.Run("input/d_pet_pictures.txt", "../../../output/d_pet_pictures.out");
        }
    }
}
