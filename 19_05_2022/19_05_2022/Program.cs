using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_05_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Queue
            /* Queue a = new Queue();
             a.Push(12);
             a.Push(11);
             a.Push(10);
             a.Pop();
             a.view();
            */
            #endregion

            #region Stack
            /*
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine();
            stack.view();
            */
            #endregion

            #region CalculareExpresie
            /*
            Stack b = new Stack();
            string S = "2 1 + 3 * 7 1 * - 5 10 - 2 * +";
            string[] d = S.Split(' ');
            int t = 0;
            for (int i = 0; i < d.Length; i++)
            {
                if (d[i][0] >= '0' && d[i][0] <= '9')
                {
                    t = int.Parse(d[i]);
                    b.Push(t);
                }
                else
                {
                    int t1 = b.Pop();
                    int t2 = b.Pop();
                    switch (d[i][0])
                    {
                        case '+': b.Push(t2 + t1); break;
                        case '-': b.Push(t2 - t1); break;
                        case '*': b.Push(t2 * t1); break;
                        case '/': b.Push(t2 / t1); break;
                    }
                }
            }
            b.view();
            */
            #endregion

            #region Tridata_Queue
            /*
            Queue<TriData> queue = new Queue<TriData>();
            queue.Push(new TriData(1, 2, 3));
            queue.Push(new TriData(4, 5, 6));
            queue.Push(new TriData(7, 8, 9));
            queue.view();
            */
            #endregion
            
            Console.ReadKey();
        }
    }
}
