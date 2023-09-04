using System;
using System.Collections.Generic;
using System.Text;

namespace CodeTest
{
    public class TestThree
    {
        public TestThree()
        {
            ConsoleLog.LogHeader("Test 3 Begin");

            this.ParseString();

            ConsoleLog.LogHeader("Test 3 End");
        }

        /// <summary>
        /// This should print the required outcomes in order.
        /// </summary>
        public void ParseString()
        {
            string value = "B2et_74fr5e9d3681!";

            ConsoleLog.LogSub("Test 3: Parse String");

            //TODO: Remove the non-alphanumeric characters
            //TODO: Print the numbers in order
            //TODO: Print the remianing non numeric characters in the current order, in uppercase.

            ConsoleLog.LogSub("Test 3 End: Parse String");
        }
    }
}
