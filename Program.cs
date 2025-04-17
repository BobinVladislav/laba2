using System;

namespace laba2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 5, 4, 2, 8, 1, 9, 3, 6 };
            int[] result = Sort.MergeSort(a, 0, a.Length - 1);
            Console.WriteLine(String.Join(", ",result));
        }
    }
}
