using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymas_type
{
    class Program
    {
        static void Main(string[] args)
        {
            var aCustomer = new { Name = "Tom Hanks", Id = "001", Address = "Hollywood" };
            var aStudent = new { Name = "Leonardo Decapreo", RegNo = "t15593", Email = "titanic69@gmail.com" };

            Console.WriteLine("Name: " + aCustomer.Name + " Id: " + aCustomer.Id + " Address: " + aCustomer.Address);

            var names = new[] { "Amy Adams", "Jenifer Lourange", "Anjelina Joli" };
            foreach(var name in names)
            {
                Console.WriteLine(name);
            }

            var aList = new[]
            {
                new{Code=1, MovieType="Drama", MovieName="Forrest Gumm"},
                new{Code=2, MovieType="Drama/Crime", MovieName="Catch Me If You Can" },
                new{Code=3, MovieType="Dramma/Fantasy", MovieName="Big"}
            };

            Show(aList);

            Console.ReadKey();
        }

        private static void Show(IEnumerable<dynamic> aList)
        {
            foreach (var aValue in aList)
            {
                Console.WriteLine(aValue.Code + "-" + aValue.MovieType + "-" + aValue.MovieName);
            }
        }
    }
}
