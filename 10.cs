using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s2ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 10. Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa. 

            Console.WriteLine("Introduceti numarul n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Introduceti cele {n} numere: ");
            int x = int.Parse(Console.ReadLine());
           
            int lc = 1, lmax = 0;
           
            for(int i = 0; i < n; i++)
            {
                int y = int.Parse(Console.ReadLine());
                if (x == y)
                    lc++;
                else
                {
                    if (lc > lmax)
                        lmax = lc;
                    lc = 1;
                }
                x = y;

                if (i == n && lc > lmax)
                    lmax = lc;
            }

            Console.WriteLine($"Numarul maxim de numere consecutive egale din secventa este {lmax}");
        }
    }
}
