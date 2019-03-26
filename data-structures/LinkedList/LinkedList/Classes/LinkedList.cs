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
    }
}
