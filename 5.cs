using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s2ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 5. Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa.
            // Se considera ca primul element din secventa este pe pozitia 0. 

            Console.Write("Introduceti numarul n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Scrieti cele {n} numere: ");
            int nr = 0;
            for(int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x == i)
                    nr++;

            }

            Console.WriteLine($"In secventa sunt {nr} numere egale cu pozitia pe care apar in secventa");

        }
    }
}
