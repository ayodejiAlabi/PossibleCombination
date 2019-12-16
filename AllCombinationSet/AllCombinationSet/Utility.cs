using System;
using System.Collections.Generic;
using System.Text;

namespace AllCombinationSet
{
    class Utility
    {
        public int TestRecurssion(int[] a, int b)
        {
            if (b <= 0)
            {
                return 0;
            }
            int c = a[b - 1];
            int d = c + TestRecurssion(a, b - 1);
            return d;

        }
        public int[][] TestRecurssion1(int[] a, int b, int[][] jaggedArray, int[] d, int c, bool aa)
        {

            if (aa)
            {
                if (a.Length == 1)
                {
                    return jaggedArray;
                }
            }
            if (a.Length < 1)
            {
                if (c > d.Length - 2)
                {
                    return jaggedArray;
                }
                a = d;
                c++;
                a = NewMethod(a, c);
                aa = true;
            }
            int[][] jaggedArray1 = new int[a.Length][];
            jaggedArray1 = LoopThru(a, 1, jaggedArray1);
            a = NewMethod(a, c);
            for (int i = 0; i < jaggedArray1.Length; i++)
            {
                if ((aa) && (jaggedArray1[i].Length == 1))
                {

                }
                else
                {
                    jaggedArray[b] = jaggedArray1[i];
                    b++;
                }

            }
            jaggedArray = TestRecurssion1(a, b, jaggedArray, d, c, aa);
            return jaggedArray;
        }

        private static int[] NewMethod(int[] a, int c)
        {
            int numToRemove = a[c];
            int numIdx = Array.IndexOf(a, numToRemove);
            List<int> tmp = new List<int>(a);
            tmp.RemoveAt(numIdx);
            a = tmp.ToArray();
            return a;
        }

        public int[][] LoopThru(int[] a, int b, int[][] jaggedArray1)
        {
            int[] c = new int[b];
            for (int i = 0; i < b; i++)
            {
                c[i] = a[i];
            }
            jaggedArray1[b - 1] = c;
            if (b < a.Length)
            {
                jaggedArray1 = LoopThru(a, b + 1, jaggedArray1);
                return jaggedArray1;
            }
            return jaggedArray1;
        }
    }
}
