using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            while(!board.IsBoardFull())
            {
                player1.PlayGame(board);
                if(resultAnalyser.CheckAll(board))
                    break;
                PrintBoard(board);
                player2.PlayGame(board);
                if (resultAnalyser.CheckAll(board))
                    break;
                PrintBoard(board);
               
            }

        }
    }
}
