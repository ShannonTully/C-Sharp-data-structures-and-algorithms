using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue.Classes
{
    public class Queue
    {
        public Node Back;

        // For queue with stack
        public Stack Current = new Stack();
        public Stack Other = new Stack();

        /// <summary>
        /// Enwueue onto a Queue
        /// </summary>
        /// <param name="value">Number to Enqueue</param>
        public void Enqueue(int value)
        {
            Node newNode = new Node();
            newNode.Value = value;
            newNode.Next = Back;
            Back = newNode;
        }

        /// <summary>
        /// Dequeue from front of Queue
        /// </summary>
        /// <returns>Dequeued Node</returns>
        public Node Dequeue()
        {
            if (Back == null)
            {
                return null;
            }

            Node current = Back;

            if (current.Next == null)
            {
                Back = null;
                return current;
            }

            while (current.Next.Next != null)
            {
                current = current.Next;
            }

            Node temp = current.Next;
            current.Next = null;
            return current;
        }

        /// <summary>
        /// Look at node to be dequeued
        /// </summary>
        /// <returns>Node in front</returns>
        public Node Peek()
        {
            if (Back == null)
            {
                return null;
            }

            Node current = Back;
            while (current.Next != null)
            {
                current = current.Next;
            }
            return current;
        }

        /// <summary>
        /// Enwueue onto a Queue using 2 stacks
        /// </summary>
        /// <param name="value">number to enqueue</param>
        public void StackEnqueue(int value)
        {
            List<Node> list = new List<Node>();

            if (Current.Peek() == null)
            {
                Current.Push(value);
            }
            else
            {
            Other.Push(value);
            }

            while (Current.Peek() != null)
            {
                list.Add(Current.Pop());
            }

            list.Reverse();
            Node[] temp = list.ToArray();

            foreach (Node node in temp)
	        {
                Other.Push(node.Value);
	        }
            
            Current = Other;
            Other = new Stack();
        }

        /// <summary>
        /// Dequeue from front of Queue using 2 stacks
        /// </summary>
        /// <returns>Dequeued Node</returns>
        public Node StackDequeue()
        {
            return Current.Pop();
        }

        /// <summary>
        /// Look at node to be dequeued using 2 stacks
        /// </summary>
        /// <returns>Node in front</returns>
        public Node StackPeek()
        {
            try
            {
                return Current.Top;
            }
            catch (NullReferenceException)
            {
                return null;
            }
            
        }
    }
}
