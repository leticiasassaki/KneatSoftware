using System;
using System.Collections.Generic;
using System.Text;

namespace Kneat.Exceptions
{
    public class ValueIsNotANumberException : Exception
    {
        public ValueIsNotANumberException(string message)
           : base(message)
        {

        }
    }
}
