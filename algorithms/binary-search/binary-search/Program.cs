using System;

namespace binary_search
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] searcharray = { 2, 4, 8, 20, 45, 63, 82 };

            BinarySearch(searcharray, 8);
        }

        public static int BinarySearch(int[] searchlist, int key)
        {
            int midpoint = searchlist.Length / 2;
            int left = 0;
            int right = searchlist.Length - 1;

            while (left <= right)
            {
                if (searchlist[midpoint] == key)
                {
                    return midpoint;
                }
                else if (searchlist[midpoint] < key)
                {
                    left = midpoint + 1;
                    midpoint = (left + right) / 2;
                }
                else if (searchlist[midpoint] > key)
                {
                    right = midpoint - 1;
                    midpoint = (left + right) / 2;
                }
            }

            return -1;
        }
    }
}
