using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s2ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 9. Sa se determine daca o secventa de n numere este monotona. Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare. 

            Console.WriteLine("Introduceti numarul n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Introduceti cele {n} numere: ");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int verif = 0, ok = 1;
            if (x > y) verif = -1;
            if (x < y) verif = 1;
            
            for(int i = 2; i < n; i++)
            {
                int z = int.Parse(Console.ReadLine());
                if (y < z)
                {
                    if (verif == 0)
                        verif = 1;
                    if (verif == -1)
                        ok = 0;
                }
                if (y > z)
                {
                    if (verif == 0)
                        verif = -1;
                    if (verif == 1)
                        ok = 0;
                }
            }

            if (ok == 1)
                Console.WriteLine("Secventa este monotona");
            else
                Console.WriteLine("Secventa nu este monotona");
        }
    }
}
