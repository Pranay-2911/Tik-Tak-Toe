using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tik_Tak_Toe.Type;

namespace Tik_Tak_Toe.Models
{
    internal class Player
    {
        MarkType type;

        public Player(MarkType mark)
        {
             type = mark;
        }

        public void PlayGame(Board board)
        {
            Console.WriteLine("Enter the Position");
            int position = int.Parse(Console.ReadLine());
            board.SetCellMark(position, type);
        }
    }
}
