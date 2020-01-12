using System;
using Xunit;
using Kneat.Exceptions;
using Kneat.Business;

namespace KneatTest
{
    public class InputTest
    {
        [Fact]
        public void InputStringTest_ThrowsValueIsNotANumberException()
        {
            Assert.Throws<ValueIsNotANumberException>(()
                => MGLTCalculation.ValidateMGLTInput("test"));
        }
        [Fact]
        public void InputNegativeTest_ThrowsNegativeValueException()
        {
            Assert.Throws<NegativeValueException>(()
                => MGLTCalculation.ValidateMGLTInput("-1254"));
        }
    }
}
