using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestDataGeneratorLibrary
{
    public class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }        
        public Sex sex { get; set; }
        
        public enum Sex { male, female }

        public static string[] firstNameMales =
        {
            "Sam",
            "Pete",
            "Dwayne",
            "Nathan",
            "Scott",
            "Miles",
            "Paul",
            "Connor"
        };

        public static string[] firstNameFemales =
        {
            "Elizabeth",
            "Ester",
            "Michelle",
            "Jane",
            "Katy",
            "Hana",
            "Emma",
            "Veronica",
            "Isabelle"
        };

        public static string[] lastNames =
        {
            "Strickland",
            "Mejia",
            "Palmer",
            "Alexander",
            "Mann",
            "Wise",
            "Thornton",
            "Khan",
            "Kaye",
            "Obama",
            "Rossi"
        };
    }
}
