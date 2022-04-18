using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_04_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            while (n % 2 != 1)
            {
                Console.WriteLine("Introduceti o valoare impara:");
                n = int.Parse(Console.ReadLine());
            }
            int n2 = n / 2;
            int[,] a = new int[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                        a[i, j] = 0;
                    else if (i + j == n - 1)
                        a[i, j] = 0;
                    else if (n2 == j)
                        a[i, j] = 0;
                    else if (n2 == i)
                        a[i, j] = 0;
                    else if (i < j && i + j < n - 1 && i < n2 && j < n2)
                        a[i, j] = 1;
                    else if (i < j && i + j < n - 1 && i < n2 && j > n2)
                        a[i, j] = 2;
                    else if (i < j && i + j > n - 1 && i < n2 && j > n2)
                        a[i, j] = 3;
                    else if (i < j && i + j > n - 1 && i > n2 && j > n2)
                        a[i, j] = 4;
                    else if (i > j && i + j > n - 1 && i > n2 && j > n2)
                        a[i, j] = 5;
                    else if (i > j && i + j > n - 1 && i > n2 && j < n2)
                        a[i, j] = 6;
                    else if (i > j && i + j < n - 1 && i > n2 && j < n2)
                        a[i, j] = 7;
                    else if (i > j && i + j < n - 1 && i < n2 && j < n2)
                        a[i, j] = 8;
                }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
