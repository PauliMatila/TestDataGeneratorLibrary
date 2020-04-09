using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestDataGeneratorLibrary
{
    public class TestDataGenerator
    {
        public static void GetRandomStringFromArray(string[] firstNameMales)
        {
            Random rand = new Random();
            int index = rand.Next(firstNameMales.Length);
            Console.WriteLine(firstNameMales[index]);            
        }

        public static Person GenerateRandomPerson()
        {
            Person person = new Person();            
        }
    }
}
