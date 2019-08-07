using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

            Person personOne = new Person();
            personOne.firstName = "Haider";
            personOne.middleName = "Ali";
            personOne.lastName = "Robin";


            Person personTwo;
            personTwo = new Person();

            personTwo = personOne;
            personOne = null;

            Change(personTwo);

            string fullName = personTwo.GetFullName();
            string reverseName = personTwo.GetReverseName();

            int a = 10;
            int b = 30;
            int c = 22;

            b = c;
            c = 300;
            ChangeValue(a);

            Console.WriteLine(fullName);
            Console.WriteLine(reverseName);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        public static void Change(Person person)
        {
            person.lastName = "Changed";
        }

        public static void ChangeValue(int a)
        {
            a = 50;
        }
    }
}
