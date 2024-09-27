using System;

namespace Tic_Tac_Toe
{
    public class Player
    {
        public static void Choice()
        {

            try
            {
                bool playerTrun = true;
                string player1 = "Player one";
                string player2 = "Player Two";
                while (true)
                {
                    if (playerTrun)
                    {
                        Board.GameBoard(player1);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("Choice: ");
                        string input = Console.ReadLine();
                        Console.ResetColor();
                        Board.GameBoard(input, player1);
                        playerTrun = false;
                    }
                    else
                    {
                        Board.GameBoard(player2);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("Choice: ");
                        string input = Console.ReadLine();
                        Console.ResetColor();
                        Board.GameBoard(input, player2);
                        playerTrun = true;

                    }
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
