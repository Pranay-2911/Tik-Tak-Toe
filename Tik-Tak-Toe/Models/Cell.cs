using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tik_Tak_Toe.Type;

namespace Tik_Tak_Toe.Models
{
    internal class Cell
    {
        private MarkType markType;

        public Cell()
        {
            markType = MarkType.EMPTY;
        }

        public bool IsEmpty()
        {
            return markType == MarkType.EMPTY;
        }
        public MarkType GetMark()
        {
            return markType;
        }

        public void SetMark(MarkType mark)
        {
            if (IsEmpty())
            {
                markType = mark;
                return;
            }
            Console.WriteLine("THis Cell Is Already Occuipied");
        }
    }
}
