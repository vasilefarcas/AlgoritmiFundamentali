using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_04_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[,] a = new int[n, m];
            string[] linie = Console.ReadLine().Split(' ');
            int[] ciur = CiurEratorstene(3000);
            int q = 0, k = 0;
            for (int i = 0; i < linie.Length && q < n; i++)
            {
                if (ciur[int.Parse(linie[i])] == 0)
                {
                    a[q, k] = int.Parse(linie[i]);
                    k++;
                    if (k == m)
                    {
                        q++;
                        k = 0;
                    }

                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        private static int[] CiurEratorstene(int n)
        {
            int[] ciur = new int[n];
            for (int i = 2; i < n; i++)
            {
                if (ciur[i] == 0)
                {
                    for (int j = 2 * i; j < n; j += i)
                    {
                        ciur[j] = 1;
                    }
                }
            }
            return ciur;
        }

    }
}
