using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tik_Tak_Toe.Type;

namespace Tik_Tak_Toe.Models
{
    internal class ResultAnalyser
    {
        public ResultAnalyser() { }

        public bool CheckAll(Board board)
        {
            return CheckFirstRow(board) || CheckSecondRow(board) || CheckThirdRow(board) ||
                   CheckFirstColumn(board) || CheckSecondColumn(board) || CheckThirdColumn(board) ||
                   CheckLeftDiagonal(board) || CheckRightDiagonal(board);
        }

        private bool CheckFirstRow(Board board)
        {
            return board.GetCellMark(0) == board.GetCellMark(1) &&
                   board.GetCellMark(1) == board.GetCellMark(2) &&
                   board.GetCellMark(0) != MarkType.EMPTY;
        }

        private bool CheckSecondRow(Board board)
        {
            return board.GetCellMark(3) == board.GetCellMark(4) &&
                   board.GetCellMark(4) == board.GetCellMark(5) &&
                   board.GetCellMark(3) != MarkType.EMPTY;
        }

        private bool CheckThirdRow(Board board)
        {
            return board.GetCellMark(6) == board.GetCellMark(7) &&
                   board.GetCellMark(7) == board.GetCellMark(8) &&
                   board.GetCellMark(6) != MarkType.EMPTY;
        }

        private bool CheckFirstColumn(Board board)
        {
            return board.GetCellMark(0) == board.GetCellMark(3) &&
                   board.GetCellMark(3) == board.GetCellMark(6) &&
                   board.GetCellMark(0) != MarkType.EMPTY;
        }

        private bool CheckSecondColumn(Board board)
        {
            return board.GetCellMark(1) == board.GetCellMark(4) &&
                   board.GetCellMark(4) == board.GetCellMark(7) &&
                   board.GetCellMark(1) != MarkType.EMPTY;
        }

        private bool CheckThirdColumn(Board board)
        {
            return board.GetCellMark(2) == board.GetCellMark(5) &&
                   board.GetCellMark(5) == board.GetCellMark(8) &&
                   board.GetCellMark(2) != MarkType.EMPTY;
        }

        private bool CheckLeftDiagonal(Board board)
        {
            return board.GetCellMark(0) == board.GetCellMark(4) &&
                   board.GetCellMark(4) == board.GetCellMark(8) &&
                   board.GetCellMark(0) != MarkType.EMPTY;
        }

        private bool CheckRightDiagonal(Board board)
        {
            return board.GetCellMark(2) == board.GetCellMark(4) &&
                   board.GetCellMark(4) == board.GetCellMark(6) &&
                   board.GetCellMark(2) != MarkType.EMPTY;
        }
    }
}
