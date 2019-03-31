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

        [Fact]
        public void TestAppendEmpty()
        {
            LinkedList.Classes.LinkedList LL = new LinkedList.Classes.LinkedList();

            LL.Append(1);

            Assert.Equal(1, LL.Head.Value);
        }

        [Fact]
        public void TestAppendNotEmpty()
        {
            LinkedList.Classes.LinkedList LL = new LinkedList.Classes.LinkedList();

            LL.Append(1);
            LL.Append(2);
            LL.Append(3);

            Assert.Equal(1, LL.Head.Value);
        }

        [Fact]
        public void TestInsertBeforeEmpty()
        {
            LinkedList.Classes.LinkedList LL = new LinkedList.Classes.LinkedList();

            LL.InsertBefore(1, 2);

            Assert.Equal(1, LL.Head.Value);
        }

        [Fact]
        public void TestInsertBeforeNotEmpty()
        {
            LinkedList.Classes.LinkedList LL = new LinkedList.Classes.LinkedList();

            LL.Append(1);
            LL.Append(2);
            LL.Append(3);

            LL.InsertBefore(4, 2);

            Assert.Equal(4, LL.Head.Next.Value);
        }

        [Fact]
        public void TestInsertBeforeNotFound()
        {
            LinkedList.Classes.LinkedList LL = new LinkedList.Classes.LinkedList();

            LL.Append(1);
            LL.Append(2);
            LL.Append(3);

            LL.InsertBefore(4, 5);

            Assert.Equal(4, LL.Head.Next.Next.Next.Value);
        }

        [Fact]
        public void TestInsertAfterEmpty()
        {
            LinkedList.Classes.LinkedList LL = new LinkedList.Classes.LinkedList();

            LL.InsertAfter(1, 2);

            Assert.Equal(1, LL.Head.Value);
        }

        [Fact]
        public void TestInsertAfterNotEmpty()
        {
            LinkedList.Classes.LinkedList LL = new LinkedList.Classes.LinkedList();

            LL.Append(1);
            LL.Append(2);
            LL.Append(3);

            LL.InsertAfter(4, 2);

            Assert.Equal(4, LL.Head.Next.Next.Value);
        }

        [Fact]
        public void TestInsertAfterNotFound()
        {
            LinkedList.Classes.LinkedList LL = new LinkedList.Classes.LinkedList();

            LL.Append(1);
            LL.Append(2);
            LL.Append(3);

            LL.InsertAfter(4, 5);

            Assert.Equal(4, LL.Head.Next.Next.Next.Value);
        }

        [Fact]
        public void TestKthFromEndTooBig()
        {
            LinkedList.Classes.LinkedList LL = new LinkedList.Classes.LinkedList();

            LL.Append(1);
            LL.Append(2);
            LL.Append(3);

            Assert.Null(LL.KthFromEnd(3));
        }

        [Fact]
        public void TestKthFromEndValid()
        {
            LinkedList.Classes.LinkedList LL = new LinkedList.Classes.LinkedList();

            LL.Append(1);
            LL.Append(2);
            LL.Append(3);

            Assert.Equal(2, LL.KthFromEnd(1).Value);
        }

        [Fact]
        public void TestKthFromEndInvalid()
        {
            LinkedList.Classes.LinkedList LL = new LinkedList.Classes.LinkedList();

            Assert.Null(LL.KthFromEnd(1));
        }
    }
}

