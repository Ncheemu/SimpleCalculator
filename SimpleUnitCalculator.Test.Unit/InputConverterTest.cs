using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator;
using System;

namespace SimpleUnitCalculator.Test.Unit
{
    [TestClass]
    public class InputConverterTest
    {
        private readonly InputConverter _inputConverter = new InputConverter();

       [TestMethod]
        public void ConvertsValidStingInputIntoDouble()
        {
            string inputNumber = "5";
            double convertedNumber = _inputConverter.ConvertInputToNumeric(inputNumber);
            Assert.AreEqual(5, convertedNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FailsToConvertInvaliudStringInputIntoDouble()
        {
            string inputNumber = "sdfds";
            double convertedNumber = _inputConverter.ConvertInputToNumeric(inputNumber);
            
        }
    }
}
