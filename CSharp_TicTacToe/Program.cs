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

            var turn = 1;
            var rnd = new Random();
            var player = rnd.Next(1, 3);

            while (turn < 10)
            {
                var marker = player == 1 ? "X" : "O";

                Console.WriteLine();
                gameMechanics.PlayerMove(players[player], marker);

                turn += 1;

                player = player == 1 ? 2 : 1;
            }

            Console.Write("\n\nPress any key to continue");
            Console.ReadKey();
        }
    }
}
