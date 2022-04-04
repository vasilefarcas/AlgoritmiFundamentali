using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcurgere_Spirala
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[,] a = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                string[] linie = Console.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = int.Parse(linie[j]);
                }
            }
            /*
             int r;
             for (r = 0; r < n / 2; r++)
             {
                 for (int j = r; j < n - r - 1; ++j)
                 {
                     Console.Write(a[r, j] + " ");
                 }
                 for (int j = r; j < n - r - 1; ++j)
                 {
                     Console.Write(a[j, n - r - 1] + " ");
                 }
                 for (int j = n - r - 1; j >= r + 1; --j)
                 {
                     Console.Write(a[n - r - 1, j] + " ");
                 }
                 for (int j = n - r - 1; j >= r + 1; --j)
                 {
                     Console.Write(a[j, r] + " ");
                 }
             }
            */
            if (n == m)
                for (int i = 0; i < n / 2; i++)
                {
                    AfisareCadranPatratic(a, n, m, i);
                }

            else
            {
                int c = 0;
                if (n != m)
                    for (int i = 0; i < n / 2 + 1; i++)
                    {
                        AfisareCadran(a, n, m, i, ref c);
                    }
            }
            Console.ReadKey();
        }
        static void AfisareCadranPatratic(int[,] a, int n, int m, int r)
        {
            for (int j = r; j < n - r - 1; ++j)
            {
                Console.Write(a[r, j] + " ");
            }
            for (int j = r; j < n - r - 1; ++j)
            {
                Console.Write(a[j, n - r - 1] + " ");
            }
            for (int j = n - r - 1; j >= r + 1; --j)
            {
                Console.Write(a[n - r - 1, j] + " ");
            }
            for (int j = n - r - 1; j >= r + 1; --j)
            {
                Console.Write(a[j, r] + " ");
            }
        }
        static void AfisareCadran(int[,] a, int n, int m, int r, ref int c)
        {
            if (c >= n * m)
                return;
            for (int j = r; j < m - r - 1; ++j)
            {
                Console.Write(a[r, j] + " ");
                c++;
            }
            if (c >= n * m)
                return;
            for (int j = r; j < n - r - 1; ++j)
            {
                Console.Write(a[j, m - r - 1] + " ");
                c++;
            }
            if (c >= n * m)
                return;
            for (int j = m - r - 1; j >= r + 1; --j)
            {
                Console.Write(a[n - r - 1, j] + " ");
                c++;
            }
            if (c >= n * m)
                return;
            for (int j = n - r - 1; j >= r + 1; --j)
            {
                Console.Write(a[j, r] + " ");
                c++;
            }
        }
    }
}
/*
11 12 13 14 15
16 17 18 19 20
21 22 23 24 25
26 27 28 29 30
31 32 33 34 35

00 01 02 03 04 05
10 11 12 13 14 15
20 21 22 23 24 25
30 31 32 33 34 35
40 41 42 43 44 45
50 51 52 53 54 55
*/

