using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree.Classes
{
    public class BT
    {
        public Node Root { get; set; }

        /// <summary>
        /// Traverse in order
        /// </summary>
        /// <returns>List of ints</returns>
        public int[] InOrder()
        {
            List<int> list = new List<int>();
            if (Root != null)
            {
                return InOrder(Root, list);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Traverse pre order
        /// </summary>
        /// <returns>List of ints</returns>
        public int[] PreOrder()
        {
            List<int> list = new List<int>();
            if (Root != null)
            {
                return PreOrder(Root, list);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Traverse post order
        /// </summary>
        /// <returns>List of ints</returns>
        public int[] PostOrder()
        {
            List<int> list = new List<int>();
            if (Root != null)
            {
                return PostOrder(Root, list);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// helper for in order
        /// </summary>
        /// <param name="node">node of "current"</param>
        /// <param name="list">list to return</param>
        /// <returns>int array</returns>
        private static int[] InOrder(Node node, List<int> list)
        {
            if (node == null)
            {
                return null;
            }

            if (node.Left != null)
            {
                InOrder(node.Left, list);
            }

            list.Add(node.Value);

            if (node.Right != null)
            {
                InOrder(node.Right, list);
            }


            return list.ToArray();
        }

        /// <summary>
        /// helper for pre order
        /// </summary>
        /// <param name="node">node of "current"</param>
        /// <param name="list">list to return</param>
        /// <returns>int array</returns>
        private static int[] PreOrder(Node node, List<int> list)
        {
            if (node == null)
            {
                return null;
            }

            list.Add(node.Value);

            if (node.Left != null)
            {
                PreOrder(node.Left, list);
            }

            if (node.Right != null)
            {
                PreOrder(node.Right, list);
            }

            return list.ToArray();
        }

        /// <summary>
        /// helper for post order
        /// </summary>
        /// <param name="node">node of "current"</param>
        /// <param name="list">list to return</param>
        /// <returns>int array</returns>
        private static int[] PostOrder(Node node, List<int> list)
        {
            if (node == null)
            {
                return null;
            }

            if (node.Left != null)
            {
                PostOrder(node.Left, list);
            }

            if (node.Right != null)
            {
                PostOrder(node.Right, list);
            }

            list.Add(node.Value);
            
            return list.ToArray();
        }
    }
}
