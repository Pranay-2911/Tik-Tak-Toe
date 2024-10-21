using System;
using Tik_Tak_Toe.Exceptions;

namespace Tik_Tak_Toe.Models
{
    internal class Game
    {
        public void PrintBoard(Board board)
        {
            board.DisplayBoard();
        }

        public void StartGame(Player player1, Player player2, Board board, ResultAnalyser resultAnalyser)
        {
            Console.WriteLine("============== Welcome to Tik-Tak-Toe game =============\n\n");

            board.DisplayBoard();
            while (true)
            {
                GameLoop(player1, player2, board, resultAnalyser);
                Console.WriteLine("Press 1 to Play Again\nPress 0 to exit");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 0)
                    Environment.Exit(0);
                board.ResetBoard();
                board.DisplayBoard();
            }
        }

        public void GameLoop(Player player1, Player player2, Board board, ResultAnalyser resultAnalyser)
        {
            Player currentPlayer = player1;

            while (!board.IsBoardFull())
            {
                try
                {
                    currentPlayer.PlayGame(board); 
                    PrintBoard(board);

                    if (resultAnalyser.CheckAll(board))
                    {
                        Console.WriteLine($"Player {currentPlayer.GetMarkType()} wins!");
                        return;
                    }

                    
                    currentPlayer = (currentPlayer == player1) ? player2 : player1;
                }
                catch (EnterValidNumberException e)
                {
                    Console.WriteLine(e.Message); 
                }
                catch (InvalidPositionException e)
                {
                    Console.WriteLine(e.Message); 
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message); 
                }
            }
            Console.WriteLine("It's a draw!");
        }

      
    }
}
