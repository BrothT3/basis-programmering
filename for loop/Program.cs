using System;

namespace for_loop
{
    class Program
    {
        static void Main(string[] args)
        {

            /* for (int i = 1; i <= 10; i++) 
             {
                 Console.WriteLine(i);

             }
            */

            
            int timeLeft = 10;
            /*
            while (true)
            {
                timeLeft -= 1;

                Console.WriteLine("Time left " +timeLeft);
                

                if (timeLeft <= 0)
                {
                    break;
                }
            }
            */
            /*
            bool value = (timeLeft == 10);
            do
            {
               
                Console.WriteLine("Time left" + timeLeft);
                timeLeft -= 1;

            } while (timeLeft >= 0);
            */

            int playerHealth = 100;


            Console.WriteLine("How much damage do you do");
            int dmG = Convert.ToInt32(Console.ReadLine());

            switch (dmG)
            {

                default:
                    Console.WriteLine($"You do {dmG} damage ");
                    Console.WriteLine(playerHealth-dmG);

                    break;
            }



        }
    }
}
