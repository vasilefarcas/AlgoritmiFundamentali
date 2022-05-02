using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_05_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine()), m=int.Parse(Console.ReadLine());
            char[,] a = new char[n, m];
            char litera = 'a';
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (j % 2 == 1)
                        a[i, j] = litera;
                    else a[i,j]=char.ToUpper(litera);
                }
                litera++;
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(a[i,j]);
                }
                Console.WriteLine();
            }
            // Console.ReadKey();


            int n1=int.Parse(Console.ReadLine());
            int n2=int.Parse(Console.ReadLine());
            int[,] v=new int[n1,n2];
            for (int i = 0; i < n1; i++)
                for (int j = 0; j < n2; j++)
                {
                    
                }
            for (int i = 0; i < n1; i++)
            {
                for (int j = 0; j < n2; j++)
                {
                    Console.Write(v[i,j]+" ");
                }
                Console.WriteLine();
            }
             Console.ReadKey();
        }
    }
}
