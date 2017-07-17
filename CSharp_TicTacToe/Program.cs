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
                //One of two ternary's to save
                //Below means 'if player == 1 then marker = 'X' else marker = 'O'
                var marker = player == 1 ? "X" : "O";

                //Turn this into a method
                Console.Write($"Enter your move {players[player]}\n");
                Console.Write($"Enter row 'top', 'mid' or 'low': ");
                var inputRow = Console.ReadLine().ToLower();

                Console.Write($"Enter column {players[player]}\n");
                Console.Write($"'R', 'M' or 'L': ");
                var inputColumn = Console.ReadLine().ToUpper();

                var move = inputRow + "_" + inputColumn;

                Console.WriteLine();
                gameMechanics.PlayerMove(gameBoard,players[player], marker, move);

                turn += 1;


                player = player == 1 ? 2 : 1;
            }

            Console.Write("\n\nPress any key to continue");
            Console.ReadKey();
        }
    }
}
