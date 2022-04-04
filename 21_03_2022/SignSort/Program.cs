using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int n = 30;
            int[] v = new int[n];
            Console.WriteLine(n);
            for (int i = 0; i < n; i++)
                v[i] = rand.Next(-5, 6);
            Afisare(v);
            int q = 1;
            // in cazul in care prima valoare e 0 se va inlocui cu urmatoarea valoare diferita de 0 
            if (Math.Sign(v[0]) == 0)
            {
                while (v[q] == 0)
                    q++;
                swap(ref v[0], ref v[q]);
            }
            Afisare(v);
            int s = 0, d = n - 1;
            // configurez sirul de numere sa fie de forma - - - 0 0 + - + + - -
            while (v[s] != 0)
            {
                while (Math.Sign(v[d]) != -1)
                    d--;
                swap(ref v[s], ref v[d]);
                s++;
            }
            Afisare(v);
            // gasesc ultima pozitie din secventa de mijloc a sirului in care avem 0
            d = s;
            while (Math.Sign(v[d]) == 0)
                d++;
            q = n - 1;
            // sortarea finala
            while (q > d)
            {
                if (Math.Sign(v[q]) == -1)
                {
                    swap(ref v[s], ref v[q]);
                    s++;
                }
                else
                if (Math.Sign(v[q]) == 1)
                {
                    q--;
                }
                else
                if (Math.Sign(v[q]) == 0)
                {
                    swap(ref v[q], ref v[d]);
                    d++;
                }
            }
            Afisare(v);
            Console.ReadKey();
        }
        public static void Afisare(int[] v)
        {
            Console.WriteLine();
            foreach (int item in v)
            {
                Console.Write(item + " ");
            }
        }
        public static void swap(ref int a, ref int b)
        {
            int aux;
            aux = a;
            a = b;
            b = aux;
        }
    }
}
