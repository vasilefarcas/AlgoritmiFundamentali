using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_05_2022
{
    internal class Queue<T>
    {
        T[] val;
        int n;
        public Queue()
        {
            val = new T[0];
        }

        public void Push(T v)
        {
            T[] t = new T[val.Length + 1];
            for (int i = 0; i < val.Length; i++)
            {
                t[i + 1] = val[i];
                t[0] = v;
            }
            t[0] = v;
            val = t;
        }
        public T Pop()
        {
            T toR = val[val.Length - 1];
            T[] T = new T[val.Length - 1];
            for (int i = 0; i < val.Length - 1; i++)
                T[i] = val[i];
            val = T;
            return toR;
        }
        public void view()
        {
            foreach (T item in val)
                Console.WriteLine(item + " ");
        }
    }
}
