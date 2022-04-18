using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zone_spirala
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 14;
            int[,] a = new int[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = 1;
                }
            for (int i = 0; i < n; i++)
                a[0, i] = 0;
            for (int i = 0; i < n; i++)
                a[i, n - 1] = 0;
            for (int i = n - 1; i > 0; i--)
                a[n - 1, i] = 0;
            for (int i = n - 1; i > 0; i--)
                a[i, 0] = 0;
            Afisare(a, n);

            int count = 0;
            for (int i = 1; i < n - 1; i++)
                a[0, i] = ++count;
            count--;
            for (int i = 0; i < n - 1; i++)
                a[i, n - 2] = ++count;
            count--;
            for (int i = n - 1; i > 1; i--)
                a[n - 2, i - 1] = ++count;
            count--;
            for (int i = n - 2; i > 0; i--)
                a[i, 1] = ++count;
            Afisare(a, n);
            for (int i = 1; i <= n-3; i++)
            {
                for (int j = 2; j <= n-3; j++)
                {
                    a[i, j] = 0;
                }
            }
            Afisare(a, n);
            Console.ReadKey();
        }
        static void Afisare(int[,] a, int n)
        {
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
