using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myIntArray = new int[6];
            //myIntArray[0] = 5;
            //myIntArray[1] = 10;
            //myIntArray[2] = 15;
            //myIntArray[3] = 20;
            //myIntArray[4] = 25;

            for (int i=0; i<myIntArray.Length; i++)
            {
                myIntArray[i] = (i + 1) * 10;
            }

            Console.WriteLine("Length: " + myIntArray.Length);

            //for(int i=0; i<5; i++)
            //{
            //    Console.WriteLine(myIntArray[i]);
            //}

            foreach(int i in myIntArray)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
