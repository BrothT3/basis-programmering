using System;

namespace BasisProgrammering
{
    class Program
    {
        static void Main(string[] args)
        {
            //Set letter color
            Console.ForegroundColor = ConsoleColor.Green;

            String helloWorld = "Hello world";
            //saved data
            Console.WriteLine(helloWorld);
            //write data from variable
            Console.WriteLine("");
            Console.WriteLine("What is your name?");
            string myName = Console.ReadLine();
            //reads unserinput and saves it to myName variable
            Console.WriteLine("");

            Console.WriteLine($"Hello {myName}");
            //writes hello and variable

            Console.WriteLine("Say Anything");
            Console.WriteLine($"{Console.ReadLine()}");
            //returns user input without storing it as a variable 
            Console.ReadLine();
        }
    }
}
