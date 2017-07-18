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

                //Turn this into a method
                Console.Write($"Begin your move {players[player]}\n");
                Console.Write("Enter row 'top', 'mid' or 'low': ");
                var readLine = Console.ReadLine();
                if (readLine != null)
                {
                    var inputRow = readLine.ToLower();

                    Console.Write($"Enter column {players[player]}\n");
                    Console.Write("(R)ighe, (M)id or (L)eft: ");
                    var inputColumn = readLine.ToUpper();

                    var move = inputRow + "_" + inputColumn;

                    Console.WriteLine();
                    gameMechanics.PlayerMove(gameBoard,players[player], marker, move);
                }

                turn += 1;


                player = player == 1 ? 2 : 1;
            }

            Console.Write("\n\nPress any key to continue");
            Console.ReadKey();
        }
    }
}
