using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_06.Letters_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstLetter = char.Parse(Console.ReadLine());
            var secoundLetter = char.Parse(Console.ReadLine());
            var missletter = char.Parse(Console.ReadLine());

            var allkombination = 0;
            var book = new List<string>();
            for (char q = firstLetter; q <= secoundLetter; q++)
            {
                for (char w = firstLetter; w <= secoundLetter; w++)
                {
                    for (char e = firstLetter; e <= secoundLetter; e++)
                    {
                        var currentWord = $"{q}{w}{e}";
                        if (!currentWord.Contains(missletter))
                        {
                            allkombination++;
                            book.Add(currentWord);
                        }
                    }
                }
            }
            book.Add(allkombination.ToString());
            Console.WriteLine(string.Join(" ", book));
        }
    }
}
