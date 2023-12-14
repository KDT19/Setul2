using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s2ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 7. Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa. 

            Console.WriteLine("Introduceti numarul n: ");
            int n = int.Parse(Console.ReadLine());

            int min = 0, max = 0;

            Console.WriteLine($"Introduceti cele {n} numere: ");
            int x = int.Parse(Console.ReadLine());
            min = x;
            max = x;
            for (int i=1; i<n; i++)
            {
                int y = int.Parse(Console.ReadLine());
                if (y > max)
                    max = y;
                if (y < min)
                    min = y;
            }

            Console.WriteLine($"Cel mai mare numar din secventa este {max}, iar cel mai mic este {min}");

        }
    }
}
