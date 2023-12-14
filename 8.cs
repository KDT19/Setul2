using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s2ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 8. Determianti al n-lea numar din sirul lui Fibonacci. Sirul lui Fibonacci se construieste astfel:
            // f1 = 0, f2 = 1, f_n = f_(n-1) + f(n-2). Exemplu: 0, 1, 1, 2, 3, 5, 8 ...

            Console.WriteLine("Introduceti al catelea numar din sirul lui Fibonacci doriti sa aflati: ");
            int n = int.Parse(Console.ReadLine());

            int f1 = 0, f2 = 1, f3 = 1; 

            for(int i = 4; i <=n; i++)
            {
                int aux = f3, aux2 = f2;
                f3 += f2;
                f2 = aux;
                f1 = aux2;
            }

            if(n == 1)
                Console.WriteLine("Primul numar din sirul lui Fibonacci este 0");
            else if(n == 2 || n == 3)
                Console.WriteLine($"Al {n}-lea numar din sirul lui Fibonacci este 1");
            else
                Console.WriteLine($"Al {n}-lea numar din sirul lui Fibonacci este {f3}");
        }
    }
}
