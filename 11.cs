using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s2ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 11. Se da o secventa de n numere. Se cere sa se caculeze suma inverselor acestor numere. 

            Console.WriteLine("Introduceti un numar n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Introduceti cele {n} numere: ");
            int s = 0;
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                int inv = 0;
                while(x > 0)
                {
                    inv = inv * 10 + (x % 10);
                    x = x / 10;

                }
                s += inv;

            }
            Console.WriteLine($"Suma inverselor este egala cu {s} ");

        }
    }
}
