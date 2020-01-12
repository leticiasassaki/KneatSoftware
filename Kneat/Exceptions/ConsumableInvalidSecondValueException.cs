using System;
using System.Collections.Generic;
using System.Text;

namespace Kneat.Exceptions
{
    public class ConsumableInvalidSecondValueException : Exception
    {
        public ConsumableInvalidSecondValueException(string message)
           : base(message)
        {

        }
    }
}
