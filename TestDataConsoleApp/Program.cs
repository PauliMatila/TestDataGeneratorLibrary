using System;
using System.Collections.Generic;
using TestDataGeneratorLibrary;

namespace TestDataConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestDataGenerator tdg = new TestDataGenerator();
            for (int i = 0; i < 5; i++)
            {
                Person dude = TestDataGenerator.GenerateRandomPerson();
                Console.WriteLine($"Name: {dude.firstName} {dude.lastName}\nAge: {dude.age}\nSex: {dude.sex}\n");
            }
            Person dude2 = TestDataGenerator.GenerateRandomPerson("Teppo", null);
            Console.WriteLine($"Name: {dude2.firstName} {dude2.lastName}\nAge: {dude2.age}\nSex: {dude2.sex}\n");
            Person dude3 = TestDataGenerator.GenerateRandomPerson(null, "Testaaja");
            Console.WriteLine($"Name: {dude3.firstName} {dude3.lastName}\nAge: {dude3.age}\nSex: {dude3.sex}\n");
        }
    }
}