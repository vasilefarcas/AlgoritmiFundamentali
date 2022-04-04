using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _633
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = 0, i = 0, nr;
            string s = Console.ReadLine();
            string[] v = s.Split(' ');
            for (int j = 0; j < n; j++)
            {
                nr = int.Parse(v[j]);
                if (nr % 2 == 0)
                    p++;
                else
                    i++;
            }

            Console.WriteLine(Math.Abs(i - p));

        }
    }
}
