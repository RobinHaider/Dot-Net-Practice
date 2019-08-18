using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>();

            myList.Add(200);
            myList.Add(100);
            myList.Add(500);
            myList.Add(400);
            myList.Add(300);

            myList.Remove(100);
            myList.Sort();
            myList.RemoveAt(0);
            myList.Reverse();

            foreach(var i in myList)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
