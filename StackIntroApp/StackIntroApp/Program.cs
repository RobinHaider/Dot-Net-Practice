using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackIntroApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> myStack = new Stack<string>();
            myStack.Push("Tony Stark");
            myStack.Push("Steve Rogers");
            myStack.Push("Thor");
            myStack.Push("Clint");
            myStack.Push("Dr. Banner");
            myStack.Push("Natasha Romenoff");

            //You can delete only from top which is the last one you input..
            string deleteData = myStack.Pop();
            Console.WriteLine("Dead Avenger: "+deleteData);

            //copying to array
            string[] stringArray = myStack.ToArray();

            foreach(var v in myStack)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine("Total Avengers: "+myStack.Count);
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
