using System;
using System.Collections.Generic;

namespace CSharp_TicTacToe
{
    public class GameMechanics
    {
        public string PlayerMove(string player)
        {
            Console.WriteLine($"Your move {player}");
            Console.Write("Please enter Row: top, (mid)dle, (low)er: ");
            var rowInput = Console.ReadLine() ?? "";
            rowInput = rowInput.ToLower();

            if (rowInput != "" && (rowInput == "top" || rowInput == "mid" || rowInput == "low"))
            {
                Console.Write("\nPlease enter Column: (L)eft, (M)iddle, (R)ight: ");
                var colInput = Console.ReadLine()?? "";
                colInput = colInput.ToUpper();

                if (colInput != "" && colInput.Length == 1 && (colInput == "L" || colInput == "M" || colInput == "R"))
                    return rowInput + "_" + colInput;
            }
            return "";
        }

        public bool SetMarker(Dictionary<string, string> board, string playerMove, string marker)
        {
            if (board[playerMove] != " ")
                return false;
            board[playerMove] = marker;
            return true;
        }

        public bool WinCheck(Dictionary<string, string> board, string marker)
        {
            if (board["top_L"] == marker && board["top_M"] == marker && board["top_R"] == marker ||
                board["mid_L"] == marker && board["mid_M"] == marker && board["mid_R"] == marker ||
                board["low_L"] == marker && board["low_M"] == marker && board["low_R"] == marker ||
                board["top_L"] == marker && board["mid_L"] == marker && board["low_L"] == marker ||
                board["top_M"] == marker && board["mid_M"] == marker && board["low_M"] == marker ||
                board["top_R"] == marker && board["mid_R"] == marker && board["low_R"] == marker ||
                board["top_L"] == marker && board["mid_M"] == marker && board["low_R"] == marker ||
                board["low_L"] == marker && board["mid_M"] == marker && board["top_R"] == marker)
            {
                return true;
            }
            return false;
        }
    }
}