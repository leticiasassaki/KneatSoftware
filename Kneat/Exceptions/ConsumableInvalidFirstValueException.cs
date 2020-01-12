using System;
using System.Collections.Generic;
using System.Text;

namespace Kneat.Exceptions
{
    public class ConsumableInvalidFirstValueException : Exception
    {
        public ConsumableInvalidFirstValueException(string message)
           : base(message)
        {

        }
    }
}
