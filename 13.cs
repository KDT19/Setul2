using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace s2ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 13. O <secventa crescatoare rotita> este o secventa de numere care este in ordine crescatoare
            // sau poate fi transformata intr-o secventa in ordine crescatoare prin rotiri succesive
            // (rotire cu o pozitie spre stanga = toate elementele se muta cu o pozitie spre stanga si primul element devine ultimul).
            // Determinati daca o secventa de n numere este o secventa crescatoare rotita. 

            Console.WriteLine("Introduceti un numar n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Introduceti cele {n} numere: ");
            int first = 0, schimb = 0;
            int x = int.Parse(Console.ReadLine());
            first = x;
            for(int i = 1; i < n; i++)
            {
                int y = int.Parse(Console.ReadLine());
                if (y < x)
                {
                    schimb++;
                }
                x = y;
            }
            if (schimb <= 1 && first >= x || schimb == 0)
                Console.WriteLine("Secventa de numere este o secventa crescatoare rotita");
            else
                Console.WriteLine("Secventa de numere nu este o secventa crescatoare rotita");
        }
    } 
}
