using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s2ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3. Calculati suma si produsul numerelor de la 1 la n. 

            Console.Write("Introduceti un numar n: ");
            int n = int.Parse(Console.ReadLine());

            int s = 0, p = 1;
            for(int i = 1; i<=n; i++)
            {
                s += i;
                p *= i;
            }

            Console.WriteLine($"Suma numerelor de la 1 la {n} este {s}, iar produsul este {p}");
        }
    }
}
