using System;
using System.Collections.Generic;

namespace CSharp_TicTacToe
{
    class GameSetup
    {
        public readonly Dictionary<string, string> NewBoard = new Dictionary<string, string>
        {
            {"top_L", "X"}, {"top_M", "X"}, {"top_R", "X"},
            {"mid_L", " "}, {"mid_M", " "}, {"mid_R", " "},
            {"low_L", " "}, {"low_M", " "}, {"low_R", " "}
        };

        public readonly Dictionary<int, string> PlayerNames = new Dictionary<int, string> { { 1, "" }, { 2, "" } };

        public void EnterPlayers(Dictionary<int, string> names)
        {
            for (var i = 1; i < 3; i++)
            {
                Console.Write("Enter name for player {0}: ", i);
                names[i] = Console.ReadLine();
                if (names[i] == "")
                    names[i] = "Player" + Convert.ToString(i);
            }
            Console.Clear();
        }

        public void PrintBoard(Dictionary<string, string> board)
        {
            Console.WriteLine("-------------");
            Console.WriteLine("| {0} | {1} | {2} |", board["top_L"], board["top_M"], board["top_R"]);
            Console.WriteLine("-------------");
            Console.WriteLine("| {0} | {1} | {2} |", board["mid_L"], board["mid_M"], board["mid_R"]);
            Console.WriteLine("-------------");
            Console.WriteLine("| {0} | {1} | {2} |", board["low_L"], board["low_M"], board["low_R"]);
            Console.WriteLine("-------------");
        }
    }
}