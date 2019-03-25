using System;
using LinkedList;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestInsertEmpty()
        {
            LinkedList.Classes.LinkedList LL = new LinkedList.Classes.LinkedList();

            LL.Insert(1);

            Assert.Equal(1, LL.Head.Value);
        }

        [Fact]
        public void TestInsertNotEmpty()
        {
            LinkedList.Classes.LinkedList LL = new LinkedList.Classes.LinkedList();

            LL.Insert(1);
            LL.Insert(2);

            Assert.Equal(2, LL.Head.Value);
        }

        [Fact]
        public void TestIncludesValid()
        {
            LinkedList.Classes.LinkedList LL = new LinkedList.Classes.LinkedList();

            LL.Insert(1);
            LL.Insert(2);
            LL.Insert(3);

            Assert.True(LL.Includes(2));
        }

        [Fact]
        public void TestIncludesInvalid()
        {
            LinkedList.Classes.LinkedList LL = new LinkedList.Classes.LinkedList();

            LL.Insert(1);
            LL.Insert(2);
            LL.Insert(3);

            Assert.False(LL.Includes(4));
        }

        [Fact]
        public void TestIncludesEmpty()
        {
            LinkedList.Classes.LinkedList LL = new LinkedList.Classes.LinkedList();

            Assert.False(LL.Includes(1));
        }

        [Fact]
        public void TestPrintNotEmpty()
        {
            LinkedList.Classes.LinkedList LL = new LinkedList.Classes.LinkedList();

            LL.Insert(1);
            LL.Insert(2);
            LL.Insert(3);

            int[] excpected = { 3, 2, 1 };

            Assert.Equal(excpected, LL.Print());
        }

        [Fact]
        public void TestPrintEmpty()
        {
            LinkedList.Classes.LinkedList LL = new LinkedList.Classes.LinkedList();

            int[] excpected = { };

            Assert.Equal(excpected, LL.Print());
        }
    }
}

