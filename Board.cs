using System;
using System.Collections.Generic;

namespace Tic_Tac_Toe
{
    public class Board
    {
        private static List<string> list = new List<string>()
        {
            "7", " | ", "8", " | ", "9", "\n",
            "---+---+---\n",
            "4", " | ", "5", " | ", "6", "\n",
            "---+---+---\n",
            "1", " | ", "2", " | ", "3", "\n",
        };


        public static void GameBoard(string player)
        {
            Console.Clear();
            Console.WriteLine("\t\tTIC TAC TOE");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\t\t  Player {player}");
            Console.ResetColor();
            Console.WriteLine("Select a position (1 through 9) from the game board");
            foreach (string item in list)
            {
                Console.Write(item);
            }
        }

        public static void GameBoard(string input, string player)
        {
            for (int i = 0; i < list.Count; i++)
            {

                if (list[i] == input)
                {
                    list[i] = player == "Player one" ? "O" : "X";
                    break;
                }

            }
            GameBoard(player);
        }
    }
}
