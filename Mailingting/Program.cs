using System;

namespace Mailingting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Newsletter signup");
            Console.WriteLine("");

            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("On what street do you live?");
            string streetName = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Number?");
            byte streetNumber = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("In Which country do you live?");
            string myCountry = Console.ReadLine();

            Console.Clear();
            //clears console
            Console.WriteLine("Is this correct?");
            Console.WriteLine($"Your name is {userName}");
            Console.WriteLine($"You live on {streetName} {streetNumber} in {myCountry}");

            
        }
    }
}
