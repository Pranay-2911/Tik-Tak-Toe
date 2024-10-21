using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tik_Tak_Toe.Exceptions
{
    internal class EnterValidNumberException : Exception
    {
        public EnterValidNumberException(string message) :base(message)
        {
            
        }
    }
}
