using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

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
        public int CombinationSum(int[] a, int b)
        {
            int c = 0;
            try
            {
                if (b.Equals(0))
                {
                    return 1;
                }
                for (int i = 0; i < a.Length; i++)
                {
                    if (b >= 1)
                    {
                        c += CombinationSum(a, b - a[i]);
                    }
                }
            }
            catch (Exception Ex)
            {

                throw;
            }
            return c;
        }
        public int CombinationSumExt(int[] a, int b)
        {
            int[] d = new int[b + 1];
            d[0] = 1;
            for (int i = 1; i <= b; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    if (i >= a[j])
                    {
                        d[i] += d[i - a[j]];
                    }
                }
            }
            return d[b];
        }
        public int GetCntOfRepeatedItems()
        {
            int c = 0;
            try
            {
                // Define a regular expression for repeated words.
                Regex rx = new Regex(@"\b(?<word>\w+)\s+(\k<word>)\b", RegexOptions.Compiled | RegexOptions.IgnoreCase);
                // Define a test string.        
                string text = "The the quick brown fox  fox jumps over the lazy dog dog.";
                // Find matches.
                MatchCollection matches = rx.Matches(text);
                int jjh = matches.Max(z => z.Groups.Count);
                foreach (Match item in matches)
                {
                    GroupCollection groups = item.Groups;
                }
            }
            catch (Exception Ex)
            {

                throw;
            }
            return c;
        }
        public int[] GetAllOddNumbers(int a)
        {
            IList<int> b = new List<int>();
            for (int i = 1; i <= a; i++)
            {
                if (i == 1)
                {
                    b.Add(i);
                }
                else
                {
                    if (i % 2 != 0)
                    {
                        b.Add(i);
                    }
                }
            }
            return b.ToArray();
        }
       
    }
}

