using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sandbox
{
    public class Person
    {
        public Person() // constructor
        {

        }
        public string _givenName = "";
        public string _familyName = "";
        public void ShowEasternName()
        {
            Console.WriteLine($"Western Name: {_givenName} {_familyName}");
        }
        public void ShowWesternName()
        {
            Console.WriteLine($"Eastern Name: {_familyName} {_givenName}");
        }
    }
}