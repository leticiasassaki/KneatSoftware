using System;
using System.Collections.Generic;
using System.Text;

namespace Kneat.Exceptions
{
    public static class ExceptionMessage
    {
        public static readonly string ConsumableInvalidFormatMessage = "Starship consumable is in a invalid format";
        public static readonly string ConsumableFirstValueNotANumberMsg = "Starship consumable first value needs to be a number";
        public static readonly string ConsumableInvalidSecondValueMessage = "Starship consumable second value should be year, day or month";
        public static readonly string ValueIsNotANumberMessage = "Lights needs to be a number.";
        public static readonly string NegativeValueMessage = "Lights needs to be higher than 0.";
    }
}
