using System;
using binary_search;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestRegularSearch()
        {
            int[] searcharray = { 2, 4, 8, 20, 45, 63, 82 };

            Assert.Equal(2, Program.BinarySearch(searcharray, 8));
        }

        [Fact]
        public void TestNotThereSearch()
        {
            int[] searcharray = { 2, 4, 8, 20, 45, 63, 82 };

            Assert.Equal(-1, Program.BinarySearch(searcharray, 25));
        }
    }
}
