using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using HashCode.Photos;
using Xunit;
using Xunit.Extensions;

namespace HashCode.Tests
{
    public class TagScorerTests
    {
        [Theory]
        [MemberData(nameof(TagLists))]
        public void WhenScoring_ShouldReturnCorrectScore(HashSet<string> tag1, HashSet<string> tag2, int expected)
        {
            TagScorer.Score(tag1, tag2)
                .Should().Be(expected);

        }

        public static IEnumerable<object[]> TagLists =>
        new [] {
            new object[] { new HashSet<string>(), new HashSet<string> {"a","b"}, 0 },
            new object[] { new HashSet<string> {"a","b"}, new HashSet<string> (), 0 },
            new object[] { new HashSet<string> {"a","b"}, new HashSet<string> {"a","b"}, 0 },
            new object[] { new HashSet<string> {"a","c"}, new HashSet<string> {"a","b"}, 1 },
            new object[] { new HashSet<string> {"a","c", "d", "b"}, new HashSet<string> {"a","b"}, 0 },
            new object[] { new HashSet<string> {"a","c", "d", "b"}, new HashSet<string> {"a","b", "e"}, 1 },
            new object[] { new HashSet<string> {"a","c", "d", "b"}, new HashSet<string> {"a","b", "e", "f"}, 2 },
        };
    }
}
