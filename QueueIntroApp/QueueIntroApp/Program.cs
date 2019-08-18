using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueIntroApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> myQueue = new Queue<int>();
            myQueue.Enqueue(10);
            myQueue.Enqueue(20);
            myQueue.Enqueue(30);
            myQueue.Enqueue(40);
            myQueue.Enqueue(50);

            //delete and return that data from top
            Console.WriteLine("Dequeue: " + myQueue.Dequeue());

            //only return the data from top
            Console.WriteLine("Peek: " + myQueue.Peek());

            //can copy to an array
            int[] myArray = myQueue.ToArray();

            foreach(var v in myQueue)
            {
                Console.WriteLine(v);
            }

            Console.ReadKey();
            
        }
    }
}
