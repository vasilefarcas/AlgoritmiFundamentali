using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_05_2022
{
    internal class TriData
    {
        int a;
        int b;
        int c;
        public TriData(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void view()
        {
            Console.WriteLine(a + " " + b + " " + c);
        }
        public override string ToString()
        {
            return a + " " + b + " " + c;
        }
    }
}
