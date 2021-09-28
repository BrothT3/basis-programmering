using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = skrevet();
            Console.WriteLine(text);
            Console.ReadLine();
            //den definere text som skrevet, sådan vi kan hente den i nedenstående funktion og derefte skrive den
        }
        static string skrevet()
        {

            Console.WriteLine("type something");
            string skrevet = Console.ReadLine();
            return skrevet;
            //denne funktion har til formål at man skrive noget som den kan læse og sætte som string skrevet. derefter retunere den stringen så den kan bruges ovenover
        }
    }
}
