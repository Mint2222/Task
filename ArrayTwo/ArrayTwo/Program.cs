using System;
using System.Globalization;

namespace ArrayTwo
{
    class Program
    {

        static void findMissing(int[] a, int[] b, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                int j;

                for (j = 0; j < m; j++)
                    if (a[i] == b[j])
                        break;

                if (j == m)
                    Console.Write(a[i] + " ");


            }
        }
        public static void Main()
        {
            int[] a = { 101, 201, 301, 401, 501 };
            int[] b = { 201, 301, 101, 501, 601 };

            int n = a.Length;
            int m = b.Length;

            findMissing(a, b, n, m);
        }


    }
}