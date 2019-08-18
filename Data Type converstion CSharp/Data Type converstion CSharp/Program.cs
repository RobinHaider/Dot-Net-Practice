using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Type_converstion_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            long l = 10000;

            l = i; //Implicit type conversiton = which one do automatically

            i = Convert.ToInt32(l); //Explicit Type conversion = which i have to do forcefully;

            Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}
