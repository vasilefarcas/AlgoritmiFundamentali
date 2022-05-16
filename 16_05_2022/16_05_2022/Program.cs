using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_05_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            int m=int.Parse(Console.ReadLine());
            int[,] a = new int[n, m];
            int max = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    {
                    a[i, j] = i ^ j;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(a[i,j]+" ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
