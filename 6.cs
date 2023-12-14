using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s2ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 6. Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare. 

            Console.Write("Introduceti numarul n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Scrieti cele {n} numere: ");
            int ok = 1;
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                int y = int.Parse(Console.ReadLine());
                if (x > y)
                    ok = 0;
                x = y;
            }

            if (ok == 1)
                Console.WriteLine("Numerele din secventa sunt in ordine crescatoare");
            else
                Console.WriteLine("Numerele din secventa nu sunt in ordine crescatoare");

        }
    }
}
