using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.The_song_of_the_wheels
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            var book = new List<string>();
            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    for (int c = 1; c <= 9; c++)
                    {
                        for (int d = 1; d <= 9; d++)
                        {
                            if (a * b + c * d == num && a < b && c > d)
                            {
                                book.Add($"{a}{b}{c}{d}");
                            }
                        }
                    }
                }
            }

            if (book.Count != 0)
            {
                Console.WriteLine(string.Join(" ", book));
            }

            if (book.Count < 4)
            {
                Console.WriteLine("No!");
            }
            else
            {
                Console.WriteLine($"Password: {book[3]}");
            }
        }
    }
}
