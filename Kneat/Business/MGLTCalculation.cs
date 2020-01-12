using Kneat.Exceptions;
using System;
using static Kneat.Exceptions.ExceptionMessage;

namespace Kneat.Business
{
    public class MGLTCalculation
    {
        public static double ValidateMGLTInput(string input)
        {
            double MGLT;
            if (!Double.TryParse(input, out _))
            {
                throw new ValueIsNotANumberException(ValueIsNotANumberMessage);
            }
            else
            {
                MGLT = Convert.ToDouble(input);
            }

            if (MGLT < 0)
            {
                throw new NegativeValueException(NegativeValueMessage);
            }

            return MGLT;
        }

        public static bool ValidateConsumable(string consumables)
        {
            string validValues = "days|day|weeks|week|months|month|years|year";
            string[] splitedConsumables = consumables.Split(" ");
            if (splitedConsumables.Length >= 3)
            {
                throw new ConsumableInvalidFormatException(ConsumableInvalidFormatMessage);
            }

            if (!int.TryParse(splitedConsumables[0], out _))
            {
                throw new ConsumableInvalidFirstValueException(ConsumableFirstValueNotANumberMsg);
            }

            if (!validValues.Contains(splitedConsumables[1]))
            {
                throw new ConsumableInvalidSecondValueException(ConsumableInvalidSecondValueMessage);
            }

            return true;
        }
        public static double CalculateStops(double distance, int starshipMGLT, int calculatedHours)
        {
            double totalMGLT = starshipMGLT * calculatedHours;
            return Math.Floor(distance / totalMGLT);
        }

        public static int ConsumablesToHours(string consumables)
        {
            int numberOfHours = 0;

            string[] splitedConsumables = consumables.Split(" ");

            switch (splitedConsumables[1].ToLower())
            {
                case "days":
                case "day":
                    numberOfHours = Convert.ToInt16(splitedConsumables[0]) * 24;
                    break;
                case "weeks":
                case "week":
                    numberOfHours = (Convert.ToInt16(splitedConsumables[0]) * 7) * 24;
                    break;
                case "months":
                case "month":
                    numberOfHours = (Convert.ToInt16(splitedConsumables[0]) * 30) * 24;
                    break;
                case "years":
                case "year":
                    numberOfHours = (Convert.ToInt16(splitedConsumables[0]) * 365) * 24;
                    break;
            }

            return numberOfHours;
        }

    }
}
