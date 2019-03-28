using System;
using MergeList;
using LinkedList.Classes;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestMergeEven()
        {
            LinkedList.Classes.LinkedList lla = new LinkedList.Classes.LinkedList();
            LinkedList.Classes.LinkedList llb = new LinkedList.Classes.LinkedList();

            lla.Append(1);
            llb.Append(2);
            lla.Append(3);
            llb.Append(4);

            Node head = Program.MergeList(lla, llb);

            Assert.Equal(4, head.Next.Next.Next.Value);
        }

        [Fact]
        public void TestMergeFirstLong()
        {
            LinkedList.Classes.LinkedList lla = new LinkedList.Classes.LinkedList();
            LinkedList.Classes.LinkedList llb = new LinkedList.Classes.LinkedList();

            lla.Append(1);
            llb.Append(2);
            lla.Append(3);
            llb.Append(4);

            lla.Append(5);
            lla.Append(6);

            Node head = Program.MergeList(lla, llb);

            Assert.Equal(6, head.Next.Next.Next.Next.Next.Value);
        }

        [Fact]
        public void TestMergeSecondLong()
        {
            LinkedList.Classes.LinkedList lla = new LinkedList.Classes.LinkedList();
            LinkedList.Classes.LinkedList llb = new LinkedList.Classes.LinkedList();

            lla.Append(1);
            llb.Append(2);
            lla.Append(3);
            llb.Append(4);

            llb.Append(5);
            llb.Append(6);

            Node head = Program.MergeList(lla, llb);

            Assert.Equal(6, head.Next.Next.Next.Next.Next.Value);
        }

        [Fact]
        public void TestMergeFirstEmpty()
        {
            LinkedList.Classes.LinkedList lla = new LinkedList.Classes.LinkedList();
            LinkedList.Classes.LinkedList llb = new LinkedList.Classes.LinkedList();

            llb.Append(2);
            llb.Append(4);

            Node head = Program.MergeList(lla, llb);

            Assert.Equal(4, head.Next.Value);
        }

        [Fact]
        public void TestMergeSecondEmpty()
        {
            LinkedList.Classes.LinkedList lla = new LinkedList.Classes.LinkedList();
            LinkedList.Classes.LinkedList llb = new LinkedList.Classes.LinkedList();

            lla.Append(1);
            lla.Append(3);

            Node head = Program.MergeList(lla, llb);

            Assert.Equal(3, head.Next.Value);
        }

        [Fact]
        public void TestMergeBothEmpty()
        {
            LinkedList.Classes.LinkedList lla = new LinkedList.Classes.LinkedList();
            LinkedList.Classes.LinkedList llb = new LinkedList.Classes.LinkedList();

            Node head = Program.MergeList(lla, llb);

            Assert.Null(head);
        }
    }
}
