using System;

namespace FlowControl
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome");
            Console.WriteLine("Please enter your name");
            string userName = Console.ReadLine();
            Console.WriteLine("How old are you?");
            int userAge = Convert.ToInt32(Console.ReadLine());

            String userLogin = "gachi bass";
            string userPw = "yes daddy";


            if (userAge >= 18) 
            {
                Console.WriteLine($"Welcome {userName}");
                Console.WriteLine("Please login");
                Console.WriteLine("Username");
                string userInput = Console.ReadLine();

                if (userInput == userLogin)
                {
                    Console.WriteLine("Please enter Password");
                    string userInputPw = Console.ReadLine();

                    if (userInputPw == userPw)
                    {
                        Console.WriteLine($"Welcome {userLogin}");
                    }
                    else
                    {
                        Console.WriteLine("Wrong password");
                        
                    }

                }
                else
                {
                    Console.WriteLine("Wrong username");
                }
                

                Console.ReadLine();
                
            }

            else
            {
                Console.WriteLine($"I'm sorry {userName} you are not old enough to use this program.");
            }


        }
    }
}
