using System;
using System.Collections.Generic;

namespace CSharp_TicTacToe
{
    class GameMechanics
    {
        public void PlayerMove(Dictionary<string, string> board, string player, string marker)
        {
            Console.WriteLine($"Your move {player}, Marker: {marker}");
            Console.WriteLine(Winner(board, player, marker));
        }

        //massive if statement with and's and or's
        private string Winner(Dictionary<string, string> chkBoard, string player, string marker)
        {
            if (chkBoard["top_L"] == marker && chkBoard["top_M"] == marker && chkBoard["top_R"] == marker ||
                chkBoard["mid_L"] == marker && chkBoard["mid_M"] == marker && chkBoard["mid_R"] == marker ||
                chkBoard["low_L"] == marker && chkBoard["low_M"] == marker && chkBoard["low_R"] == marker ||
                chkBoard["top_L"] == marker && chkBoard["mid_L"] == marker && chkBoard["low_L"] == marker ||
                chkBoard["top_M"] == marker && chkBoard["mid_M"] == marker && chkBoard["low_M"] == marker ||
                chkBoard["top_R"] == marker && chkBoard["mid_R"] == marker && chkBoard["low_R"] == marker ||
                chkBoard["top_L"] == marker && chkBoard["mid_M"] == marker && chkBoard["low_R"] == marker ||
                chkBoard["low_L"] == marker && chkBoard["mid_M"] == marker && chkBoard["top_R"] == marker)
            {
                return $"{player}: You Win!";
            }
            
            return "";
        }
    }
}