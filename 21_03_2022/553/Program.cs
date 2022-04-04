using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _553
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[] s = { ' ' };
            string[] sir = Console.ReadLine().Split(s, StringSplitOptions.RemoveEmptyEntries);
            int[] v = new int[sir.Length];
            for (int i = 0; i < sir.Length; i++)
            {
                v[i] = int.Parse(sir[i]);
            }
            int min = v[0], max = v[0], imin = 0, imax = 0;
            for (int i = 0; i < n; i++)
            {
                if (v[i] < min)
                {
                    min = v[i];
                    imin = i;
                }
                if (v[i] > max)
                {
                    max = v[i];
                    imax = i;
                }
            }
            imax++;
            imin++;
            Console.WriteLine(imin+" "+imax);
            Console.ReadKey();
        }
    }
}
