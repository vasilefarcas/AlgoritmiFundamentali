using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_03_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 488
            int n = int.Parse(Console.ReadLine());
            string[] s = Console.ReadLine().Split(' ');
            for (int i = 1; i < s.Length; i = i + 2)
                Console.Write(s[i] + " ");
            Console.WriteLine();
            if (n % 2 == 0)
                for (int i = n - 2; i >= 0; i = i - 2)
                    Console.Write(s[i] + " ");
            else
                for (int i = n-1; i >= 0; i = i - 2)
                    Console.Write(s[i] + " ");

            Console.ReadKey();
        }
    }
}
