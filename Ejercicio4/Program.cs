using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {

            string start;
            char startChar;
            string end;
            char endChar;
            string[] city = new string[] { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            Console.WriteLine("Input starting character for the city (Capital letter): ");
            start = Console.ReadLine();
            char.TryParse(start, out startChar);
            


            Console.WriteLine("Input ending character for the city (Capital letter): ");
            end = Console.ReadLine();
            char.TryParse(end, out endChar);

            var cityQuery =
                from name in city
                where name.StartsWith(startChar.ToString().ToUpper()) && name.EndsWith(endChar.ToString().ToUpper()) //Elijo aquellos elementos que empiezan y terminan con los caracteres introducidos por pantalla (startsWith() solo admite string)
                select name;

            if (cityQuery.Count() > 0) // Numero de elementos en la colección
            {
                foreach (string name in cityQuery)
                {
                    Console.WriteLine("\nThe city starting with " + startChar + " and ending with " + endChar + " is " + name);
                }
            }
            else // Si la colección está vacía
            {
                Console.WriteLine("\nThere is not cities");
            }


            Console.ReadLine();

        }
    }
}
