using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1313
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] l = Console.ReadLine().Split(' ');
            int m = int.Parse(l[0]), n = int.Parse(l[1]);
            int[,] a = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                string[] linie = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                    a[i, j] = int.Parse(linie[j]);
            }
            int p = int.Parse(Console.ReadLine());
            int[,] b = new int[n, p];
            for (int i = 0; i < n; i++)
            {
                string[] linie = Console.ReadLine().Split(' ');
                for (int j = 0; j < p; j++)
                    b[i, j] = int.Parse(linie[j]);
            }
            int[,] c = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        c[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(c[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
