using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s2ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Se da o secventa de n numere. Sa se determine cate din ele sunt pare. 

            Console.Write("Introduceti un numar n: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write($"Scrieti cele {n} numere: ");

            int nrp = 0;

            for(int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x % 2 == 0)
                    nrp++;
            }

            Console.WriteLine($"In total sunt {nrp} numere pare");

        }
    }
}
