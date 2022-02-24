
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    class Program
    {

        static char[,] playField = { { '1','2','3'},//Row 0
                              { '4','5','6'},//Row 1
                              { '7','8','9' } };//Row 2
        static void Main(string[] args)
        {
            int player = 2;
            int input = 0;
            int ok = 0;
            bool inputCorrect = true;



            do
            {
                if (player == 2)
                {
                    player = 1;
                    EnterXorO(player, input);
                }
                else if (player == 1)
                {
                    player = 2;
                    EnterXorO(player, input);
                }
                DrawBoard();
                #region
                //To check winning condition
                char[] playerChar = { 'X', 'O' };
                foreach (var item in playerChar)
                {
                    if ((playField[0, 0] == item) && (playField[0, 1] == item) && (playField[0, 2] == item) ||
                        (playField[1, 0] == item) && (playField[1, 1] == item) && (playField[1, 2] == item) ||
                        (playField[2, 0] == item) && (playField[2, 1] == item) && (playField[2, 2] == item) ||
                        (playField[0, 0] == item) && (playField[1, 0] == item) && (playField[2, 0] == item) ||
                        (playField[0, 1] == item) && (playField[1, 1] == item) && (playField[2, 1] == item) ||
                        (playField[0, 2] == item) && (playField[1, 2] == item) && (playField[2, 2] == item) ||
                        (playField[0, 0] == item) && (playField[1, 1] == item) && (playField[2, 2] == item) ||
                        (playField[0, 2] == item) && (playField[1, 1] == item) && (playField[2, 0] == item))
                    {
                        if (item == 'X')
                        {
                            Console.WriteLine("**player 2 has WON**");
                            ok = 1;
                        }

                        else
                        {
                            Console.WriteLine("**player 1 has WON**");
                            ok = 1;
                        }

                    }
                }

                #endregion
                if (ok == 1)
                {
                    Console.WriteLine("Game has End");
                    break;
                }
                #region
                else
                    do
                    {
                        Console.WriteLine("\n Player {0}: Choose the Field", player);
                        try
                        {
                            input = Convert.ToInt32(Console.ReadLine());

                        }
                        catch
                        {
                            Console.WriteLine("please enter a number between 1 to 9");
                        }
                        if (input == 1 && playField[0, 0] == '1')//checking whether the field is occupied failed to occupy the same field
                        {
                            inputCorrect = true;
                        }
                        else if (input == 2 && playField[0, 1] == '2')
                        {
                            inputCorrect = true;
                        }
                        else if (input == 3 && playField[0, 2] == '3')
                        {
                            inputCorrect = true;
                        }
                        else if (input == 4 && playField[1, 0] == '4')
                        {
                            inputCorrect = true;
                        }
                        else if (input == 5 && playField[1, 1] == '5')
                        {
                            inputCorrect = true;
                        }
                        else if (input == 6 && playField[1, 2] == '6')
                        {
                            inputCorrect = true;
                        }
                        else if (input == 7 && playField[2, 0] == '7')
                        {
                            inputCorrect = true;
                        }
                        else if (input == 8 && playField[2, 1] == '8')
                        {
                            inputCorrect = true;
                        }
                        else if (input == 9 && playField[2, 2] == '9')
                        {
                            inputCorrect = true;
                        }
                        else
                        {
                            Console.WriteLine("Please Use another field");
                            inputCorrect = false;
                        }
                    } while (!inputCorrect);
            } while (true) ;

            #endregion




            Console.ReadLine();
        }

        private static void EnterXorO(int player, int input)
        {
            char playerSign = ' ';
            if (player == 1)
                playerSign = 'X';
            else if (player == 2)
                playerSign = 'O';


            switch (input)
            {
                case 1: playField[0, 0] = playerSign; break;

                case 2: playField[0, 1] = playerSign; break;

                case 3: playField[0, 2] = playerSign; break;

                case 4: playField[1, 0] = playerSign; break;

                case 5: playField[1, 1] = playerSign; break;

                case 6: playField[1, 2] = playerSign; break;

                case 7: playField[2, 0] = playerSign; break;

                case 8: playField[2, 1] = playerSign; break;

                case 9: playField[2, 2] = playerSign; break;

            }






        }

        private static void DrawBoard()
        {
            //This is a method to draw 3*3 Board
            Console.Clear();
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2} ", playField[0, 0], playField[0, 1], playField[0, 2]);
            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2} ", playField[1, 0], playField[1, 1], playField[1, 2]);
            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2} ", playField[2, 0], playField[2, 1], playField[2, 2]);
            Console.WriteLine("   |   |   ");
        }
    }
}