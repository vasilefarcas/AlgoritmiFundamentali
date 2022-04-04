using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _509
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] num = Console.ReadLine().Split(' ');
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(num[i]);
            }
            bool ok = false;
            int aux;
            int k = 0;
            do
            {
                ok = true;
                for (int i = 0; i < n - 1 - k; i++)
                {
                    if (v[i] > v[i + 1])
                    {
                        aux = v[i];
                        v[i] = v[i + 1];
                        v[i + 1] = aux;
                        ok = false;
                    }
                }
                k++;
            }
            while (!ok);
            foreach (int item in v)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }
    }
}
