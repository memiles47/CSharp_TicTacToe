using System;

namespace CSharp_TicTacToe
{
    class Program
    {
        static void Main()
        {
            var gameSetup = new GameSetup();
            var gameMechanics = new GameMechanics();
            var gameBoard = gameSetup.NewBoard;
            var players = gameSetup.PlayerNames;

            gameSetup.EnterPlayers(players);
            gameSetup.PrintBoard(gameBoard);

            foreach (var name in players)
                Console.WriteLine(name);

            Console.WriteLine();
            Console.WriteLine(gameMechanics.WinDraw("X"));

            Console.Write("\n\nPress andy key to continue");
            Console.ReadKey();
        }
    }
}
