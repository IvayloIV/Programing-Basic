using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Christmas_Toy
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.Write(new string('-', n * 2));
            Console.Write(new string('*', n ));
            Console.WriteLine(new string('-', n * 2));

            var terence = n * 2 - 2;
            var nqkviSiTam = n + 2;
            for (int i = 1; i <= n /2 ; i++)
            {
                    Console.Write(new string('-', terence));
                    Console.Write(new string('*', ((5 * n) - (terence * 2) - nqkviSiTam) / 2));
                    Console.Write(new string('&', nqkviSiTam));
                    Console.Write(new string('*', ((5 * n) - (terence * 2) - nqkviSiTam) / 2));
                    Console.WriteLine(new string('-', terence));
                    terence -= 2;                             
                    nqkviSiTam += 2;
            }

            var terenca2 = n - 1;
            var nqkviSiTam2 = n * 3 - 2;
            for (int i = 1; i <= n / 2; i++)
            {
                Console.Write(new string('-', terenca2));
                Console.Write(new string('*', (n * 5 - terenca2 * 2 - nqkviSiTam2) / 2));
                Console.Write(new string('~', nqkviSiTam2));
                Console.Write(new string('*', (n * 5 - terenca2 * 2 - nqkviSiTam2) / 2));
                Console.WriteLine(new string('-', terenca2));
                terenca2--;
                nqkviSiTam2 += 2;
            }

            var terence3 = n / 2;
            var nqkviSiTam3 = n * 4 - 2;
            Console.Write(new string('-', terence3));
            Console.Write(new string('*', (n * 5 - terence3 * 2 - nqkviSiTam3) / 2));
            Console.Write(new string('|', nqkviSiTam3));
            Console.Write(new string('*', (n * 5 - terence3 * 2 - nqkviSiTam3) / 2));
            Console.WriteLine(new string('-', terence3));

            for (int i = 1; i <= n / 2; i++)
            {
                nqkviSiTam3 -= 2;
                Console.Write(new string('-', terence3));
                Console.Write(new string('*', (n * 5 - terence3 * 2 - nqkviSiTam3) / 2));
                Console.Write(new string('~', nqkviSiTam3));
                Console.Write(new string('*', (n * 5 - terence3 * 2 - nqkviSiTam3) / 2));
                Console.WriteLine(new string('-', terence3));
                terence3++;
            }

            var nqkviSiTam4 = n * 2;

            for (int i = 1; i <= n / 2; i++)
            {
                Console.Write(new string('-', terence3));
                Console.Write(new string('*', (n * 5 - terence3 * 2 - nqkviSiTam4) / 2));
                Console.Write(new string('&', nqkviSiTam4));
                Console.Write(new string('*', (n * 5 - terence3 * 2 - nqkviSiTam4) / 2));
                Console.WriteLine(new string('-', terence3));
                terence3 += 2;
                nqkviSiTam4 -= 2;
            }
            Console.Write(new string('-', n * 2));
            Console.Write(new string('*', n));
            Console.WriteLine(new string('-', n * 2));
        }
    }
}
