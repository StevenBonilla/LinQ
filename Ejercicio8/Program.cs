using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    class Program : item
    {
        static void Main(string[] args)
        {

            item p1 = new item();
            CoOrds p2 = new CoOrds(5, 3);

            // Display the results using the overriden ToString method:
            Console.WriteLine("CoOrds #1 at {0}", p1);
            Console.WriteLine("CoOrds #2 at {0}", p2);
            Console.ReadKey();

        }
    }
}
