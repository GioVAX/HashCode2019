using System;
using System.Collections.Generic;
using System.Text;
using HashCode.Photos;
using HashCode.Photos.Runners;
using Xunit;

namespace HashCode.Tests.Sets
{
    public class DTests
    {
        [Fact]
        public void RunD()
        {
            var runner = new DefaultRunner("input/d_pet_pictures.txt", "../../../output/d_pet_pictures.out");

            runner.Run();
        }
    }
}
