using System;

namespace Lommeregner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the worlds shittiest calculator!");
            Console.WriteLine("");
            Console.WriteLine("Please insert first numbers and hit enter");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert operator, +, -, / or * and hit enter");
            String op = Console.ReadLine();
            Console.WriteLine("Insert second number and hit enter");
            int y = Convert.ToInt32(Console.ReadLine());
            
            String calcTime = ($"{x} {op} {y} =");

            
                switch (op)
                {
                    case "/":
                        Console.WriteLine(calcTime);
                        Console.WriteLine(x / y);
                        break;

                    case "*":
                        Console.WriteLine(calcTime);
                        Console.WriteLine(x * y);
                        break;

                    case "-":
                        Console.WriteLine(calcTime);
                        Console.WriteLine(x - y);
                        break;

                    case "+":
                        Console.WriteLine(calcTime);
                        Console.WriteLine(x + y);
                        break;

                    default:
                        Console.WriteLine("Please select an operator");
                        break;

                }
            
            Console.ReadLine();

        }
    }
}
