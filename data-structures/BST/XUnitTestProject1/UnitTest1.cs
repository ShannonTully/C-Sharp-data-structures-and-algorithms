using System;
using Xunit;
using BinaryTree.Classes;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        //Can successfully instantiate a tree with a single root node
        //Can successfully add a left child and right child to a single root node
        //Can successfully return a collection from a preorder traversal
        //Can successfully return a collection from an inorder traversal
        //Can successfully return a collection from a postorder traversal

        [Fact]
        public void TestInstantiateEmptyTree()
        {
            BST bst = new BST();

            Assert.IsType<BST>(bst);
        }

        [Fact]
        public void TestSingleRoot()
        {
            BST bst = new BST();
            bst.Add(1);
            Assert.Equal(1, bst.Root.Value);
        }

        [Fact]
        public void TestInOrder()
        {
            BST bst = new BST();
            bst.Add(2);
            bst.Add(1);
            bst.Add(3);

            int[] list = { 1, 2, 3 };

            Assert.Equal(list, bst.InOrder());
        }

        [Fact]
        public void TestPreOrder()
        {
            BST bst = new BST();
            bst.Add(2);
            bst.Add(1);
            bst.Add(3);

            int[] list = { 2, 1, 3 };

            Assert.Equal(list, bst.PreOrder());
        }

        [Fact]
        public void TestPostOrder()
        {
            BST bst = new BST();
            bst.Add(2);
            bst.Add(1);
            bst.Add(3);

            int[] list = { 1, 3, 2 };

            Assert.Equal(list, bst.PostOrder());
        }
    }
}
