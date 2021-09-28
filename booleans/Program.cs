using System;

namespace booleans
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 6;
            bool value = (n == 6);
            //bool values er true/false afhængig af om den møder visse kriterier/variabler
            Console.WriteLine(n == 5);
            // == spørger om den er i lig med. det er den ikke, så falsk
            Console.WriteLine(n >= 5);
            // >= siger venstre værdi er større end eller i ligmed. bool i denne er falsk, da N er højere
            Console.WriteLine(n != 5);
            // != betyder ikke i ligmed. not equals to. den er sand fordi N ikke er i ligmed 5
            Console.WriteLine(n > 5 && n < 10);
            // && betyder and-gate. boolen er true, fordi n både er større end 5 og mindre end 10
            Console.WriteLine(!(n >= 5 && n < 10));
            // udråbstegnet betyder den er true kun hvis det ikke gælder. derfor er bool-værdien her false
            Console.WriteLine(n < 5 || n >= 10);
            // de to streger betyder or-. det vil sige at bool(true) hvis en eller begge af værdierne er sande. derfor er denne bool false.
            Console.WriteLine(n > 5 || n >= 10);
            // denne er sand, da n er større end 5 og i en or-gate, behøver kun en af værdierne være sande før boolen er true
            Console.ReadLine();

        }
    }
}
