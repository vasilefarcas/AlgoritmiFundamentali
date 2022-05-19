using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_05_2022
{
    internal class Stack
    {
        int[] v;
        public Stack()
        {
            v = new int[0];
        }
        public int Pop()
        {
            int toR = v[0];
            int[] T = new int[v.Length - 1];
            for (int i = 0; i < v.Length - 1; i++)
                T[i] = v[i + 1];
            v = T;
            return toR;
        }
        public void Push(int val)
        {
            int[] t = new int[v.Length + 1];
            for (int i = 0; i < v.Length ; i++)
            {
                t[i + 1] = v[i];
            }
            t[0] = val;
            v = t;
        }
        public void view()
        {
            foreach (int item in v)
                Console.WriteLine(item + " ");
        }
    }
}
