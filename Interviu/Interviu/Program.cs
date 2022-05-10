using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interviu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Fibo(300);
            // Console.WriteLine(Palindrom("abcbbba"));
            Console.WriteLine(Eliminare("mere",'e'));
            Console.ReadKey();
        }
        public static void Fibo(int n)
        {
            int a = 1, b = 0, c = 0;
            while (a <= n)
            {
                Console.WriteLine(c + " ");
                c = a + b;
                a = b;
                b = c;
            }
        }
        public static bool Palindrom(string sir)
        {
            int lungime = sir.Length - 1, i = 0;
            while (sir[i] == sir[lungime] && i != lungime && i<lungime)
            {
                i++;
                lungime--;
            }
            if (i == lungime || i > lungime)
                return true;
            return false;
        }
        public static string Oglindit(string n)
        {
            string ogl = string.Empty;

            return ogl;
        }

        public static string Eliminare(string s,char a)
        {
            string sir = string.Empty;
            for (int i = 0; i < s.Length-1; i++)
            {
                if (s[i] != a)
                    sir += s[i];
            }
            return sir;
        }
    }
}
