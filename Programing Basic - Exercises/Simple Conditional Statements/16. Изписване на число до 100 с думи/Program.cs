using System;

namespace NumberAsWords
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if (number < 0 || number > 100)
            {
                Console.WriteLine("invalid number");
                return;
            }
            string[] toNineteen = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven",
                "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] tensNumbers = { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            string word = "";

            if (number == 100)
            {
                Console.WriteLine("one hundred");
                return;
            }
            else if (number >= 0 && number <= 100) 
            {

                if (number / 100 > 0)
                {
                    word = toNineteen[number / 100] + " " + "hundred";
                    number = number % 100;
                }

                if (word != "")
                {
                    word = word + " " + "and ";
                }
                if (number < 20)
                {
                    word = word + toNineteen[number];
                }
                else if (number / 10 > 1)
                {
                    word = word + tensNumbers[number / 10];
                    if (number % 10 > 0)
                    {
                        word = word + " " + toNineteen[number % 10];
                    }
                }
            }
            else
            {
                Console.WriteLine("invalid number");

            }
            Console.WriteLine(word);
        }
    }
}