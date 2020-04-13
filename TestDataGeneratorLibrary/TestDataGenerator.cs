using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestDataGeneratorLibrary
{
    public class TestDataGenerator
    {               
        public static string GetRandomStringFromArray(string[] names)
        {
            Random rand = new Random();
            int index = rand.Next(names.Length);
            return names[index];
        }
        
        public static Person GenerateRandomPerson(string firstName = null, string lastName = null)
        {
            Person person = new Person();                                    
            person.age = GenerateRandomData(10, 99);
            person.sex = RandomSex();
            if (person.sex == Person.Sex.male && firstName == null)
            {
                person.firstName = GetRandomStringFromArray(Person.firstNameMales);
            }
            else if (firstName == null)
            {
                person.firstName = GetRandomStringFromArray(Person.firstNameFemales);
            }
            else
            {
                person.firstName = firstName;
            }
            if (lastName == null)
            {
                person.lastName = GetRandomStringFromArray(Person.lastNames);
            }
            else
            {
                person.lastName = lastName;
            }
            return person;
        }

        public static int GenerateRandomData(int min, int max)
        {
            Random randNum = new Random();
            int number = randNum.Next(min, max);
            return number;
        }

        public static Person.Sex RandomSex()
        {
            Array values = Enum.GetValues(typeof(Person.Sex));
            Random randSex = new Random();
            return (Person.Sex)values.GetValue(randSex.Next(values.Length));
        }
    }
}
