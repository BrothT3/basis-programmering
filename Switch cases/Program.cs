using System;

namespace Switch_cases
{
    class Program
    {
        static void Main(string[] args)
        {
            const string userName1 = "Manuel";
            string userPw1 = "José";

           const string userName2 = "yo mama";
            string userPw2 = "thanks dad";

            const string userName3 = "Jarl";
            string userPw3 = "Rolf";
            // login "database"

            Console.WriteLine("Welcome to the Bill gates microchipping service");
            Console.WriteLine("Please log in");
            Console.WriteLine("");
            Console.WriteLine("What is your Username?");
            string userInput = Console.ReadLine();

            String askforPw = "Enter your password";
            //preset besked i stedet for at skrive det 2000 gange

            switch (userInput)
            {//switch alt efter hvad brugeren skriver

                case userName1:
                    //for at bruge det gemte brugernavn skulle den defineres som en konstant
                    { 
                    Console.WriteLine(askforPw); 
                    string userInputPw = Console.ReadLine();

                    if (userInputPw == userPw1)
                            //hvis bruger input er lig med det gemte login kode
                    {
                        Console.WriteLine("You can now book your appointment for Bill Gates' cummies");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Wrong password");
                        break;
                    }

            }

                case userName2:
                { 
                    Console.Write(askforPw);
                    string userInputPw = Console.ReadLine();
                        if (userInputPw == userPw2)
                        {

                            Console.WriteLine("You can now book your appointment for Bill Gates' cummies");
                            break;
                        }
                        else
                        {

                            Console.WriteLine("WRONG");
                            break;
                        }

                }
                case userName3:
                    {

                        Console.WriteLine(askforPw);
                        string userInputPw = Console.ReadLine();
                        if (userInputPw == userPw3)
                        {

                            Console.WriteLine("You can now book your appointment for Bill Gates' cummies");
                            
                        }
                        else
                        {

                            Console.WriteLine("Also wrong");
                        }
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Begone commie");
                        break;
                    }


                    

            }



        }
    }
}
