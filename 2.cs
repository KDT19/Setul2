using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s2ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2. Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive. 

            Console.Write("Introduceti un numar n: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write($"Scrieti cele {n} numere: ");

            int nrp = 0, nrn = 0, nr0 = 0;

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x < 0)
                    nrn++;
                else
                    if (x > 0)
                    nrp++;
                else
                    nr0++;
                    
            }

            Console.WriteLine($"In total sunt {nrp} numere pozitive, {nrn} numere negative si {nr0} numere egale cu 0");

        }
    }
}
