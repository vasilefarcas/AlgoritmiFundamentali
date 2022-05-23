using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_05_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OrderedQueue orderedQueue = new OrderedQueue();
            orderedQueue.Push(5);
            orderedQueue.Push(4);
            orderedQueue.Push(3);
            orderedQueue.Push(2);
            orderedQueue.Push(7);
            orderedQueue.Push(10);
            orderedQueue.Push(6);
            orderedQueue.view();
            Console.WriteLine(orderedQueue.Pop());
            Console.WriteLine(orderedQueue.Pop());
            Console.WriteLine(orderedQueue.Pop());
            Console.ReadKey();
        }
    }
}
