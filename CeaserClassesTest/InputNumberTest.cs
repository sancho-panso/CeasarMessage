using CeasarMessage;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Specialized;
using System.IO;

namespace CeaserClassesTest
{
    [TestClass]
    public class InputNumberTest
    {
        [TestMethod]
        public void InputNumberIntegerTypeTestPass()
        {
            var input = new StringReader("15216");
            Console.SetIn(input);

            var userInput = InputNumber.InputValidNumber();

            Assert.IsInstanceOfType(userInput, typeof(Int32));
        }

        [TestMethod]
        public void InputNumberIntegerTypeTestFail()
        {
            var output = new StringWriter();
            Console.SetOut(output);

            var input = new StringReader("badInput");
            Console.SetIn(input);

            var expectedOutput = "Enter decryption key as integer number:\r\nWe can not convert input: 'badInput' \nto an integer number, please try again\r\n";

            InputNumber.InputValidNumber();

            Assert.AreEqual(expectedOutput, output.ToString());
        }

    }
}
