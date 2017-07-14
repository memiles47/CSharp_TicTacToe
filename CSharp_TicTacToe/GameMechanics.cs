using System;

namespace CSharp_TicTacToe
{
    class GameMechanics
    {
        public void PlayerMove(string player, string marker)
        {
            Console.WriteLine($"Your move {player}, Marker: {marker}");
            Console.WriteLine(WinCheck(player));
        }

        private string WinCheck(string player)
        {
            //Very Large if statement
            return $"{player}: You Win!";
        }

    }
}