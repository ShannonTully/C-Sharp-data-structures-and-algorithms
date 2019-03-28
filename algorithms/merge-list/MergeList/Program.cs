using System;
using LinkedList.Classes;

namespace MergeList
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static Node MergeList(LinkedList.Classes.LinkedList lla, LinkedList.Classes.LinkedList llb)
        {
            if (lla.Head == null || llb.Head == null)
            {
                if (lla.Head != null)
                {
                    return lla.Head;
                }
                else if (llb.Head != null)
                {
                    return llb.Head;
                }
                else
                {
                    return null;
                }
            }

            Node curra = lla.Head;
            Node currb = llb.Head;

            while (curra.Next != null && currb.Next != null)
            {
                Node nexta = curra.Next;
                Node nextb = currb.Next;
                curra.Next = currb;
                currb.Next = nexta;
                curra = nexta;
                currb = nextb;
            }

            if (curra.Next == null)
            {
                curra.Next = currb;
            }

            if (currb.Next == null)
            {
                currb.Next = curra.Next;
                curra.Next = currb;
            }

            return lla.Head;
        }
    }
}
