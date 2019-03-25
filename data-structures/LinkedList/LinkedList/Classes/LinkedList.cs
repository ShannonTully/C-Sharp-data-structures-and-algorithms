using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
{
    public class LinkedList
    {
        public Node Head;

        public void Insert(int value)
        {
            Node newNode = new Node();
            newNode.Value = value;
            newNode.Next = Head;
            Head = newNode;
        }

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
