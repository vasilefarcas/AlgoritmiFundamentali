using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_05_2022
{
    internal class Program
    {
        static Random r = new Random();
        static int n, m;
        static int[,] a;
        static bool[,] b;
        static bool ok = false;
        static void Main(string[] args)
        {
            // Se da o matrice de val 0 si 1 de dim (n,m).
            // Sa se afiseze daca exista drum de 0 de la locatia (0,0) la (n-1,n-1)
            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            a = new int[n, m];
            b = new bool[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = r.Next(2);
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
            PA(0, 0);
            if (ok == true)
                Console.WriteLine("Da");
            else
                Console.WriteLine("Nu");
            Console.ReadKey();
        }
        public static void PA(int i, int j)
        {
            if (i >= 0 && j >= 0 && i < n && j < m && !b[i, j] && a[i, j] == 0)
            {
                if (i == n - 1 && j == m - 1)
                    ok = true;
                b[i, j] = true;
                PA(i - 1, j);
                PA(i, j + 1);
                PA(i + 1, j);
                PA(i, j - 1);
            }
        }
    }
}
