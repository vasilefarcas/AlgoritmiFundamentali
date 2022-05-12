using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ProblemaPlatouri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a = readM(@"D:\Drive\OneDrive\Facultate\Semestrul II\AlgoritmiFundamentali\12_05_2022\ProblemaPlatouri\bin\TextFile1.txt");
            viewM(a);
            Console.ReadKey();
        }
        static int[,] readM(string filename)
        {
            int[,] toR;
            string buffer;
            List<string> T = new List<string>();
            TextReader load = new StreamReader(filename);
            while ((buffer = load.ReadLine()) != null)
                T.Add(buffer);
            load.Close();
            int n = T.Count;
            int m = T[0].Split(' ').Length;
            toR = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                string[] ld = T[i].Split(' ');
                for (int j = 0; j < ld.Length; j++)
                    toR[i, j] = int.Parse(ld[j]);

            }
            return toR;
        }
        static void viewM(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}


