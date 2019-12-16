using System;

namespace AllCombinationSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Utility pkl = new Utility();
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            int hjj = pkl.TestRecurssion(a, a.Length);
            int[][] jaggedArray1 = new int[500][];
            int[][] kkl = pkl.TestRecurssion1(a, 0, jaggedArray1, a, 0, false);
        }
    }
}
