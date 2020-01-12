using System;
using System.Collections.Generic;
using System.Text;

namespace Kneat.Exceptions
{
    public class ConsumableInvalidFormatException : Exception
    {
        public ConsumableInvalidFormatException(string message)
           : base(message)
        {

        }
    }
}
