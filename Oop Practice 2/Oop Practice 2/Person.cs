using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Practice_2
{
    class Person
    {
        public string firstName; //field // variable insatance
        public string middleName;
        public string lastName;

        public Person(string firstName, string middleName, string lastName) 
            : this(firstName,lastName)
        {
            this.middleName = middleName;
        }

        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Person()
        {

        }

        public string GetFullName() //method
        {
            string fullName = firstName + " " + middleName + " " + lastName;
            return fullName;
        }

        public string GetReverseName()
        {
            string fullName = GetFullName();
            char[] charArray = fullName.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
