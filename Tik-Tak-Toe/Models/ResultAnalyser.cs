using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tik_Tak_Toe.Models
{
    internal class ResultAnalyser
    {
        public ResultAnalyser() { }

        public bool CheackFirstRow(Board board)
        {
            if(board.GetCellMark(0) == Type.MarkType.X && board.GetCellMark(0) == board.GetCellMark(1) && board.GetCellMark(1) == board.GetCellMark(2))
            {
                Console.WriteLine("Player 1 wins");
                board.DisplayBoard();
                return true;
            }
            else if (board.GetCellMark(0) == Type.MarkType.O && board.GetCellMark(0) == board.GetCellMark(1) && board.GetCellMark(1) == board.GetCellMark(2))
            {
                Console.WriteLine("Player 2 wins");
                board.DisplayBoard();
                return true;
            }
            return false;
        }

        public bool CheckSecondRow(Board board)
        {
            if (board.GetCellMark(3) == Type.MarkType.X && board.GetCellMark(3) == board.GetCellMark(4) && board.GetCellMark(4) == board.GetCellMark(5))
            {
                Console.WriteLine("Player 1 wins");
                board.DisplayBoard();
                return true;
            }
            else if (board.GetCellMark(3) == Type.MarkType.O && board.GetCellMark(3) == board.GetCellMark(4) && board.GetCellMark(4) == board.GetCellMark(5))
            {
                Console.WriteLine("Player 2 wins");
                board.DisplayBoard();
                return true;
            }
            return false;
        }

        public bool CheckThridRow(Board board)
        {
            if (board.GetCellMark(6) == Type.MarkType.X && board.GetCellMark(6) == board.GetCellMark(7) && board.GetCellMark(7) == board.GetCellMark(8))
            {
                Console.WriteLine("Player 1 wins");
                board.DisplayBoard();
                return true;
            }
            else if (board.GetCellMark(6) == Type.MarkType.O && board.GetCellMark(6) == board.GetCellMark(7) && board.GetCellMark(7) == board.GetCellMark(8))
            {
                Console.WriteLine("Player 2 wins");
                board.DisplayBoard();
                return true;
            }
            return false;
        }
        public bool CheckFirstColumn(Board board)
        {
            if (board.GetCellMark(0) == Type.MarkType.X && board.GetCellMark(0) == board.GetCellMark(3) && board.GetCellMark(3) == board.GetCellMark(6))
            {
                Console.WriteLine("Player 1 wins");
                board.DisplayBoard();
                return true;
            }
            else if (board.GetCellMark(0) == Type.MarkType.O && board.GetCellMark(0) == board.GetCellMark(3) && board.GetCellMark(3) == board.GetCellMark(6))
            {
                Console.WriteLine("Player 2 wins");
                board.DisplayBoard();
                return true;
            }
            return false ;
        }
        public bool CheckSecondColumn(Board board)
        {
            if (board.GetCellMark(1) == Type.MarkType.X && board.GetCellMark(1) == board.GetCellMark(4) && board.GetCellMark(4) == board.GetCellMark(7))
            {
                Console.WriteLine("Player 1 wins");
                board.DisplayBoard();
                return true;
            }
            else if (board.GetCellMark(1) == Type.MarkType.O && board.GetCellMark(1) == board.GetCellMark(4) && board.GetCellMark(4) == board.GetCellMark(7))
            {
                Console.WriteLine("Player 2 wins");
                board.DisplayBoard();
                return true;
            }
            return false;
        }

        public bool CheckThridColumn(Board board)
        {
            if (board.GetCellMark(2) == Type.MarkType.X && board.GetCellMark(2) == board.GetCellMark(5) && board.GetCellMark(5) == board.GetCellMark(8))
            {
                Console.WriteLine("Player 1 wins");
                board.DisplayBoard();
                return true;
            }
            else if (board.GetCellMark(2) == Type.MarkType.O && board.GetCellMark(2) == board.GetCellMark(5) && board.GetCellMark(5) == board.GetCellMark(8))
            {
                Console.WriteLine("Player 2 wins");
                board.DisplayBoard();
                return true;
            }
            return false;
        }
        public bool CheckLeftDiagonal(Board board)
        {
            if (board.GetCellMark(0) == Type.MarkType.X && board.GetCellMark(0) == board.GetCellMark(4) && board.GetCellMark(4) == board.GetCellMark(8))
            {
                Console.WriteLine("Player 1 wins");
                board.DisplayBoard();
                return true;
            }
            else if (board.GetCellMark(0) == Type.MarkType.O && board.GetCellMark(0) == board.GetCellMark(4) && board.GetCellMark(4) == board.GetCellMark(8))
            {
                Console.WriteLine("Player 2 wins");
                board.DisplayBoard();
                return true;
            }
            return false;
        }

        public bool CheckRightDiagonal(Board board)
        {
            if (board.GetCellMark(2) == Type.MarkType.X && board.GetCellMark(2) == board.GetCellMark(4) && board.GetCellMark(4) == board.GetCellMark(6))
            {
                Console.WriteLine("Player 1 wins");
                board.DisplayBoard();
                return true;
            }
            else if (board.GetCellMark(2) == Type.MarkType.O && board.GetCellMark(2) == board.GetCellMark(4) && board.GetCellMark(4) == board.GetCellMark(6))
            {
                Console.WriteLine("Player 2 wins");
                board.DisplayBoard();
                return true;
            }
            return false;
        }

        public bool CheckAll(Board board)
        {
            if (CheackFirstRow(board) ||
                CheckSecondRow(board) ||
                CheckThridRow(board) ||
                CheckFirstColumn(board) ||
                CheckSecondColumn(board) ||
                CheckThridColumn(board) ||
                CheckLeftDiagonal(board) ||
                CheckRightDiagonal(board))
            {
                return true;
            }
            return false;
        }
    }
}
