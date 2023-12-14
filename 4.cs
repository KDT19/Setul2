using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s2ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4. Se da o secventa de n numere.
            // Determinati pe ce pozitie se afla in secventa un numara a.
            // Se considera ca primul element din secventa este pe pozitia zero.
            // Daca numarul nu se afla in secventa raspunsul va fi -1. 

            Console.WriteLine("Introduceti numarul n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti numarul a: ");
            int a = int.Parse(Console.ReadLine());

            int poz = -1;

            Console.WriteLine($"Introduceti cele {n} numere: ");
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x == a)
                    poz = i;
            }
            if(poz == -1)
                Console.WriteLine("-1");
            else
                Console.WriteLine($"Numarul {a} se afla pe pozitia {poz}");

        }
    }
}
