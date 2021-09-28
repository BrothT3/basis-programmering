using System;

namespace multidimensional_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Movepiece();

        }
        static int[,] skakbræt()
        {

            int[,] board = new int[8, 8];
            byte[,] userinput = new byte[8, 8];


            for (int x = 0; x < board.GetLength(0); x++)
            {
                for (int y = 0; y < board.GetLength(1); y++)
                {

                    if (x == 1)
                    {
                        board[x, y] = 1;
                    }
                    //bønder
                    if (x == 0 && y == 0 || x == 0 && y == 7)
                    {
                        board[x, y] = 2;
                    }
                    //tårne
                    if (x == 0 && y == 1 || x == 0 && y == 6)
                    {
                        board[x, y] = 3;
                    }
                    //biskoppe
                    if (x == 0 && y == 2 || x == 0 && y == 5)
                    {
                        board[x, y] = 4;
                    }
                    //konge
                    if (x == 0 && y == 3)
                    {
                        board[x, y] = 5;
                    }
                    //dronning
                    if (x == 0 && y == 4)
                    {
                        board[x, y] = 6;
                    }


                    Console.Write(board[x, y] + " ");


                }
                Console.WriteLine("");

            }
            return board;
        }

        static void Movepiece()
        {

            int[,] board = skakbræt();
            bool gaming = true;
            while (gaming)
            {
                Console.WriteLine("what piece do you wish to move?");
                Console.WriteLine("type x-coordinate, 0-7");
                Byte userinputx = Convert.ToByte(Console.ReadLine());
                Console.WriteLine("type y-coordinate, 0-7");
                byte userinputy = Convert.ToByte(Console.ReadLine());
                int piece = board[userinputy, userinputx];
                switch (piece)
                {

                    case 1:
                        Console.WriteLine("you have selected a pawn \n " +
                           "you have the following options \n" +
                           " \n" +
                           "1. move one square ahead");
                        byte movepiece1 = Convert.ToByte(Console.ReadLine());
                        switch (movepiece1)
                        {
                            case 1:
                                Console.WriteLine("moving piece");
                                board[userinputy + 1, userinputx] = 1;
                                board[userinputy, userinputx] = 0;
                                break;
                            default:
                                Console.WriteLine("that is not an option");
                                Console.ReadLine();
                                break;

                        }
                        break;
                    case 2:
                        Console.WriteLine("you have selected a tower \n " +
                         "Tower-dlc available for only 4,99! \n" +
                         " \n" +
                         "1. go to store page");
                        byte towerpurchase = Convert.ToByte(Console.ReadLine());
                        switch (towerpurchase)
                        {

                            case 1:
                                Console.WriteLine("go fuck yourself");
                                Console.ReadLine();
                                break;
                            default:
                                Console.WriteLine("that is not an option");
                                Console.ReadLine();
                                break;
                        }
                        break;
                    case 3:
                        Console.WriteLine("you have selected a knight \n " +
                           "you have the following options \n" +
                           " \n" +
                           "1. two squares ahead, one east\n" +
                           "2. two squares ahead, one west\n" +
                           "3. two squares west, one ahead\n" +
                           "4. two squares west, one backwards\n" +
                           "5. two squares east, one ahead\n" +
                           "6. two squares east, one backwards\n" +
                           "7. two squares backwards, one east\n" +
                           "8. two squares backwards, one west\n ");
                        byte movepiece3 = Convert.ToByte(Console.ReadLine());
                        switch (movepiece3)
                        {
                            case 1:
                                Console.WriteLine("moving piece");
                                if (userinputy + 2 <= 0 && userinputy +1 >= 7)
                                {
                                    board[userinputy + 2, userinputx + 1] = 3;
                                    board[userinputy, userinputx] = 0;
                                }
                                else
                                {
                                    Console.WriteLine("please try and keep the pieces on the board");
                                    Console.ReadLine();
                                }
                                    
                                /*
                                board[userinputy + 2, userinputx + 1] = 3;
                                board[userinputy, userinputx] = 0;
                                */
                                break;
                            case 2:
                                Console.WriteLine("moving piece");
                                board[userinputy + 2, userinputx - 1] = 3;
                                board[userinputy, userinputx] = 0;
                                break;
                            case 3:
                                Console.WriteLine("moving piece");
                                board[userinputy + 1, userinputx - 2] = 3;
                                board[userinputy, userinputx] = 0;
                                break;
                            case 4:
                                Console.WriteLine("moving piece");
                                board[userinputy - 1, userinputx - 2] = 3;
                                board[userinputy, userinputx] = 0;
                                break;
                            case 5:
                                Console.WriteLine("moving piece");
                                board[userinputy + 2, userinputx + 1] = 3;
                                board[userinputy, userinputx] = 0;
                                break;
                            case 6:
                                Console.WriteLine("moving piece");
                                board[userinputy + 2, userinputx + 1] = 3;
                                board[userinputy, userinputx] = 0;
                                break;
                            case 7:
                                Console.WriteLine("moving piece");
                                board[userinputy + 2, userinputx + 1] = 3;
                                board[userinputy, userinputx] = 0;
                                break;
                            case 8:
                                
                                    board[userinputy - 2, userinputx - 1] = 3;
                                    board[userinputy, userinputx] = 0;
                                
                                else
                                Console.WriteLine("please try and keep the pieces on the board");
                                Console.ReadLine();
                                Console.WriteLine("moving piece");
                                
                                break;

                            default:
                                Console.WriteLine("that is not an option");
                                Console.ReadLine();
                                break;
                        
                        }
                        break;
                 default:

                 Console.WriteLine("there is no piece here");
                 Console.ReadLine();

                 break;
                }
                Console.Clear();
                for (int x = 0; x < board.GetLength(0); x++)
                {
                    for (int y = 0; y < board.GetLength(1); y++)
                    {
                        Console.Write(board[x, y]+" ");
                    }
                    Console.WriteLine("");

                }


            }

        }




    }





    }

