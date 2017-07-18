/*
 * Created by SharpDevelop.
 * User: Michael Miles
 * Date: 7/5/2017
 * Time: 5:44 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
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
            var gameMechanics = new GameMechanics();

            gameSetup.EnterPlayers(players);

            var turn = 1;
            var rnd = new Random();
            var player = rnd.Next(1, 3);

            gameSetup.PrintBoard(gameBoard);
            while (turn < 10)
            {
                var marker = player == 1 ? "X" : "O";

                var playerMove = gameMechanics.PlayerMove(players[player]);
                if (playerMove == "")
                {
                    Console.WriteLine("Invalid Entry");
                    Console.Write("Press any key to continue");
                    Console.ReadKey();
                    Console.Clear();
                    gameSetup.PrintBoard(gameBoard);
                    continue;
                }

                if (!gameMechanics.SetMarker(gameBoard, playerMove, marker))
                {
                    Console.WriteLine("Spot already taken");
                    Console.Write("Press any key to continue");
                    Console.ReadKey();
                    Console.Clear();
                    gameSetup.PrintBoard(gameBoard);
                    continue;
                }

                if (gameMechanics.WinCheck(gameBoard, marker))
                {
                    Console.Clear();
                    gameSetup.PrintBoard(gameBoard);
                    Console.WriteLine($"You Win {players[player]}!!");
                    break;
                }

                Console.Clear();
                gameSetup.PrintBoard(gameBoard);
                turn += 1;
                player = player == 1 ? 2 : 1;
            }

            Console.Write("\n\nPress any key to continue");
            Console.ReadKey();
        }
    }
}
