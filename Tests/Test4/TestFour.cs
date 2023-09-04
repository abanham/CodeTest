﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace CodeTest
{
    public class TestFour
    {
        public TestFour()
        {
            ConsoleLog.LogHeader("Test 4 Begin");            
            this.ConvertJson();

            ConsoleLog.LogHeader("Test 4 End");
        }

        /// <summary>
        /// Convert the Json string into a C# object (typeof ExampleObject) then print the name from the converted object.
        /// </summary>
        public void ConvertJson()
        {
            ConsoleLog.LogSub("Test 4: Convert Json");

            string jsonText;

            #region Json loading
            // Load the embedded Json file in as a string.
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Tests\Test4\TestFourJson.txt");
            jsonText = System.IO.File.ReadAllText(path);
            #endregion

            // TODO: Deserialise the JSON into a List<ExampleObject>
            // TODO: Print the count of the List<ExampleObject>
            // TODO: Print the Names of all the ExampleObjects with the SearchReference of 1.


            ConsoleLog.LogSub("Test 4 End: Convert Json");            
        }
    }
}
