using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Tik_Tak_Toe.Exceptions;
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
            Console.WriteLine($"Player {type}, enter the position (0-8):");
            int position = int.Parse(Console.ReadLine());

            CheckValidPosition(position);

            bool isMoveValid = board.SetCellMark(position, type);

            if (!isMoveValid)
            {
                throw new InvalidPositionException("This position is already occupied! Try again."); // Throw exception for invalid move
            }
        }

        public void CheckValidPosition(int position)
        {
            if (position < 0 || position >= 9)
            {
                throw new EnterValidNumberException("Please Enter valid Number From (0-8)");
            }
        }

        public MarkType GetMarkType()
        {
            return type;
        }

    }
}
