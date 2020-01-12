using Kneat.Business;
using Kneat.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace KneatTests
{
    public class CalculationTest
    {
        [Fact]
        public void ConsumableInvalidFormatExceptionTest_ThrowsConsumableInvalidFormatException()
        {
            Assert.Throws<ConsumableInvalidFormatException>(()
                => MGLTCalculation.ValidateConsumable("1234 test week"));
        }

        [Fact]
        public void ConsumableInvalidFirstValueTest_ThrowsConsumableInvalidFirstValueException()
        {
            Assert.Throws<ConsumableInvalidFirstValueException>(()
                => MGLTCalculation.ValidateConsumable("week 2365"));
        }

        [Fact]
        public void ConsumableInvalidSecondValueTest_ThrowsConsumableInvalidSecondValueException()
        {
            Assert.Throws<ConsumableInvalidSecondValueException>(()
                => MGLTCalculation.ValidateConsumable("2641 megalights"));
        }

        [Theory]
        [InlineData(1000000, "50", 1440, 13)]
        [InlineData(1000000, "75", 1440, 9)]
        [InlineData(1000000, "80", 168, 74)]
        public void CalculateAmountofStopsTest(double distance, string MGLT, int hours, int expectedResult)
        {
            double amountOfStops = MGLTCalculation.CalculateStops(distance, Convert.ToInt32(MGLT), hours);

            Assert.Equal(expectedResult, amountOfStops);
        }

        [Theory]
        [InlineData("1 year", 8760)]
        [InlineData("2 days", 48)]
        [InlineData("6 months", 4320)]
        public void ConvertConsumablesToHoursTest(string consumables, int? expectedResult)
        {
            int? hours = MGLTCalculation.ConsumablesToHours(consumables);

            Assert.Equal(expectedResult, hours);
        }

    }
}
