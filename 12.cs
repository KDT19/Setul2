using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s2ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 12. Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere.
            // Considerati fiecare astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte.
            // De ex. pentru secventa 1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0 raspunsul este 3. 

            Console.WriteLine("Introduceti un numar n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Introduceti cele {n} numere: ");
            int nrgrupe = 0;
            int x = int.Parse(Console.ReadLine());
            for(int i = 1; i < n; i++)
            {
                int y = int.Parse(Console.ReadLine());
                if (y == 0 && x != 0)
                    nrgrupe++;
                x = y;
            }
            Console.WriteLine($"In secventa sunt {nrgrupe} grupuri de numere consecutive diferite de zero");
        }
    }
}
