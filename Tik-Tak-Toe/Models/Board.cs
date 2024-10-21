using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tik_Tak_Toe.Type;

namespace Tik_Tak_Toe.Models
{
    internal class Board
    {
        private Cell[] cell = new Cell[9];
        public Board()
        {
            for (int i = 0; i < cell.Length; i++)
            {
                cell[i] = new Cell();  
            }
        }
        public bool IsBoardFull()
        {
            foreach (var cel in cell)
            {
                if (cel.IsEmpty())
                {
                    return false;
                }
            }
            return true;
        }

        public void DisplayBoard()
        {
            for (int i = 0; i < cell.Length; i++)
            {
                Console.Write(GetCellMark(i) == MarkType.EMPTY ? "_" : GetCellMark(i).ToString());
                if ((i + 1) % 3 == 0) Console.WriteLine();
                else Console.Write(" | ");
            }
            Console.WriteLine();
        }

        public void PutMark(Cell cell, MarkType type)
        {

        }

        public void SetCellMark(int position, MarkType mark)
        {
            if (cell[position].GetMark() == MarkType.EMPTY)
            {
                cell[position].SetMark(mark);
            }
            else
            {
                Console.WriteLine("Cell is ocupied");
            }
        }

        public MarkType GetCellMark(int position)
        {
            return cell[position].GetMark();
        }
    }
}
