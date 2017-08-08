/*
 * Created by SharpDevelop.
 * User: Michael Miles
 * Date: 7/5/2017
 * Time: 5:44 AM
 */
using System;

namespace CSharp_TicTacToe
{
    static class Program
    {
        public static void Main()
        {
            var gameSetup = new GameSetup();
            var gameBoard = gameSetup.NewBoard;
            var players = gameSetup.PlayerNames;

            GameSetup.EnterPlayers(players);

            var turn = 1;
            var rnd = new Random();
            var player = rnd.Next(1, 3);

            GameSetup.PrintBoard(gameBoard);
            while (turn < 10)
            {
                var marker = player == 1 ? "X" : "O";

                var playerMove = GameMechanics.PlayerMove(players[player]);
                if (playerMove == "")
                {
                    Console.WriteLine("Invalid Entry");
                    Console.Write("Press any key to continue");
                    Console.ReadKey();
                    Console.Clear();
                    GameSetup.PrintBoard(gameBoard);
                    continue;
                }

                if (!GameMechanics.SetMarker(gameBoard, playerMove, marker))
                {
                    Console.WriteLine("Spot already taken");
                    Console.Write("Press any key to continue");
                    Console.ReadKey();
                    Console.Clear();
                    GameSetup.PrintBoard(gameBoard);
                    continue;
                }

                if (GameMechanics.WinCheck(gameBoard, marker))
                {
                    Console.Clear();
                    GameSetup.PrintBoard(gameBoard);
                    Console.WriteLine($"You Win {players[player]}!!");
                    break;
                }

                Console.Clear();
                GameSetup.PrintBoard(gameBoard);
                turn += 1;
                player = player == 1 ? 2 : 1;
            }

            Console.Write("\n\nPress any key to continue");
            Console.ReadKey();
        }
    }
}
