using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implicitly_Typed_Local_Vairabale_var_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 15;
            int number;
            number = 4;

            var numberVariable = 10;
            var stringVariable = "Tommorow";
            stringVariable = "The next day";

            var booleanVariable = false;
            var decimalVariable = 23.4;
            var charVariable = 'd';

            var listVariable = new List<int>();
            listVariable.Add(1);
            listVariable.Add(3);

            var userDefinedVariable = new Trainee();
            userDefinedVariable.SEID = "23333";
            userDefinedVariable.Name = "Shahidul Islam";
        }
    }
}
