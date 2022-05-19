using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_05_2022
{
    internal class Stack
    {
        int[] val;
        public Stack()
        {
            val = new int[0];
        }
        public int Pop()
        {
            int toR = val[0];
            int[] T = new int[0];
            for (int i = 0; i < val.Length; i++)
            {

            }
            return 0;
        }
        public void Push(int val)
        {
            int[] toR;
        }
        public void view()
        {
            foreach (int item in val)
                Console.WriteLine(item+" ");
        }
    }
}
