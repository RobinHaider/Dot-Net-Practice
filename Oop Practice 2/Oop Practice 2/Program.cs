using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Practice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

            Person person1 = new Person("Haider", "Ali", "Robin");

            string fullName = person1.GetFullName();
            Console.WriteLine(fullName);

            Person person2 = new Person("Tom", "Hanks");
            fullName = person2.GetFullName();
            Console.WriteLine(fullName);

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
