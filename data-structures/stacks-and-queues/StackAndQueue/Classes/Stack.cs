using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue.Classes
{
    public class Stack
    {
        public Node Top;

        /// <summary>
        /// Push onto Stack
        /// </summary>
        /// <param name="value">Number to add</param>
        public void Push(int value)
        {
            Node newNode = new Node();
            newNode.Value = value;
            newNode.Next = Top;
            Top = newNode;
        }

        /// <summary>
        /// Pop off of a Stack
        /// </summary>
        /// <returns>Popped Node</returns>
        public Node Pop()
        {
            Node temp = Top;
            Top = Top.Next;
            return temp;
        }

        /// <summary>
        /// Look at next node to pop
        /// </summary>
        /// <returns>Node on top</returns>
        public Node Peek()
        {
            return Top;
        }
    }
}
