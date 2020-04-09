using System;
using System.Collections.Generic;
using TestDataGeneratorLibrary;

namespace TestDataConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TestDataGenerator.GetRandomStringFromArray(Person.firstNameMales);
        }
    }
}