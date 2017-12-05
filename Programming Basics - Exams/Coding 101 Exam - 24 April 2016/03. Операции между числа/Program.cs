using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Операции_между_числа
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var operator1 = Console.ReadLine();

            if (operator1 == "+")
            {
                var sum = num1 + num2;
                var oddOrEven = "";
                if (sum % 2 == 0)
                {
                    oddOrEven = "even";
                }
                else
                {
                    oddOrEven = "odd";
                }
                Console.WriteLine($"{num1} + {num2} = {sum} - {oddOrEven}");
            }
            else if (operator1 == "-")
            {
                var sum = num1 - num2;
                var oddOrEven = "";
                if (Math.Abs(sum) % 2 == 0)
                {
                    oddOrEven = "even";
                }
                else
                {
                    oddOrEven = "odd";
                }
                Console.WriteLine($"{num1} - {num2} = {sum} - {oddOrEven}");
            }
            else if (operator1 == "*")
            {
                var sum = num1 * num2;
                var oddOrEven = "";
                if (sum % 2 == 0)
                {
                    oddOrEven = "even";
                }
                else
                {
                    oddOrEven = "odd";
                }
                Console.WriteLine($"{num1} * {num2} = {sum} - {oddOrEven}");
            }
            else if (operator1 == "/")
            {
                if (num2 == 0)
                {
                    Console.WriteLine($"Cannot divide {num1} by zero");
                    return;
                }
                var sum = ((double)num1 / num2);               
                Console.WriteLine($"{num1} / {num2} = {sum:f2}");
            }
            else if (operator1 == "%")
            {
                if (num2 == 0)
                {
                    Console.WriteLine($"Cannot divide {num1} by zero");
                    return;
                }
                var sum = ((double)num1 % num2);
                Console.WriteLine($"{num1} % {num2} = {sum}");
            }
        }
    }
}
