using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s2ex17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 17. Se da o secventa de 0 si 1, unde 0 inseamna paranteza deschisa si 1 inseamna paranteza inchisa.
            // Determinati daca secventa reprezinta o secventa de paranteze corecta si, daca este,
            // determinati nivelul maxim de incuibare a parantezelor. De exemplu 0 1 0 0 1 0 1 1 este corecta si
            // are nivelul maxim de incuibare 2 pe cand 0 0 1 1 1 0 este incorecta.

            int parantezeDeschise = 0;
            int nivelMaxim = 0;
            bool ok = true;
            Console.WriteLine("Introduceti numarul n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Introduceti cele {n} paranteze (0 - deschisa si 1 - inchisa)");
            for(int i = 0; i < n; i ++)
           
            {
                int x = int.Parse(Console.ReadLine());
                if (x == 0)
                {
                    parantezeDeschise++;
                    nivelMaxim = Math.Max(nivelMaxim, parantezeDeschise);
                }
                else if (x == 1)
                {
                    if (parantezeDeschise > 0)
                    {
                        parantezeDeschise--;
                    }
                    else
                    {
                        ok = false;
                    }
                }
            }

            if (ok && parantezeDeschise == 0)
            {
                Console.WriteLine($"Secventa este corecta, iar nivelul maxim de incuibare este {nivelMaxim}");
            }
            else
            {
                Console.WriteLine("Secventa nu este corecta.");
            }


        }
    }
}
