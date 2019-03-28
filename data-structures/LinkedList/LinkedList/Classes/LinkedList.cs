using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
{
    public class LinkedList
    {
        public Node Head;

        /// <summary>
        /// Insert value into the beginning of the linked list
        /// </summary>
        /// <param name="value">Value to be added</param>
        public void Insert(int value)
        {
            Node newNode = new Node();
            newNode.Value = value;
            newNode.Next = Head;
            Head = newNode;
        }

        /// <summary>
        /// Does the linked list include given value
        /// </summary>
        /// <param name="value">Value to search for</param>
        /// <returns>Is in or not</returns>
        public bool Includes(int value)
        {
            Node current = Head;

            while (current != null)
            {
                if (value == current.Value)
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        /// <summary>
        /// Return a array of all values
        /// </summary>
        /// <returns>Array of values</returns>
        public int[] Print()
        {
            Node current = Head;
            List<int> output = new List<int>();

            while (current != null)
            {
                output.Add(current.Value);
                current = current.Next;
            }

            return output.ToArray();
        }

        /// <summary>
        /// Append a value to the end of a linked list
        /// </summary>
        /// <param name="value">Value to add</param>
        public void Append(int value)
        {
            Node newNode = new Node();
            newNode.Value = value;
            if (Head == null)
            {
                Head = newNode;
                return;
            }
            Node current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }

        /// <summary>
        /// Insert a value before the target value
        /// </summary>
        /// <param name="value">Value to add</param>
        /// <param name="target">Target value to add before</param>
        public void InsertBefore(int value, int target)
        {
            Node newNode = new Node();
            newNode.Value = value;
            if (Head == null)
            {
                Head = newNode;
                return;
            }
            Node current = Head;
            while (current.Next != null && current.Next.Value != target)
            {
                current = current.Next;
            }
            if (current.Next != null)
            {
                newNode.Next = current.Next;
            }
            current.Next = newNode;
        }

        /// <summary>
        /// Insert a value after the target value
        /// </summary>
        /// <param name="value">Value to add</param>
        /// <param name="target">Target valuse to add after</param>
        public void InsertAfter(int value, int target)
        {
            Node newNode = new Node();
            newNode.Value = value;
            if (Head == null)
            {
                Head = newNode;
                return;
            }
            Node current = Head;
            while (current.Value != target && current.Next != null)
            {
                current = current.Next;
            }
            if (current.Next != null)
            {
                newNode.Next = current.Next;
            }
            current.Next = newNode;
        }

        /// <summary>
        /// Find the node that is k from the end
        /// </summary>
        /// <param name="target">How many from back</param>
        /// <returns>Node of kth from end</returns>
        public Node KthFromEnd(int target)
        {
            Node front = Head;
            Node back = Head;

            if (Head == null)
            {
                return null;
            }

            for (int i = 0; i < target; i++)
			{
                if (front.Next != null)
	            {
                    front = front.Next;
	            }
                else
	            {
                    return null;
	            }
			}

            while (front.Next != null)
	        {
                front = front.Next;
                back = back.Next;
	        }
            return back;
        }
    }
}
