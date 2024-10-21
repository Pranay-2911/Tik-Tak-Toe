using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tik_Tak_Toe.Exceptions
{
    internal class InvalidPositionException : Exception
    {
        public InvalidPositionException(string message) : base(message)
        {
             
        }
    }
}
