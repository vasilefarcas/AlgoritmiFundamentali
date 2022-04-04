using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _510
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()), i, j;
            string[] sir = Console.ReadLine().Split(' ');
            int[] v = new int[n];
            for (i = 0; i < n; i++)
                v[i] = int.Parse(Convert.ToString(sir[i]));
            int max = v.Max();
            int[] c = new int[max + 1];
            int[] rez = new int[n];
            c[1] = 1;
            for (i = 2; i <= max; i++)
            {
                if (c[i] == 0)
                    for (j = 2 * i; j <= max; j = j + i)
                        c[j] = 1;
            }
            int nr = 0;
            for (i = 0; i < n; i++)
                if (c[v[i]] == 0)
                {
                    rez[nr] = v[i];
                    nr++;
                }
            Array.Sort(rez);
            for (j = nr - 1; j < n; j++)
            {
                if (rez[j] != 0)
                    Console.Write(rez[j] + " ");
            }
            Console.ReadKey();
        }
    }
}