using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            string size;
            int sizeInt;
            //List<string> cities = new List<string> { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS", "NEW YORK" };
            int pages;

            List<City> pageQuery; //Lista de resultados que se imprimirán por pantalla
            List<City> cities = new List<City>();

            cities.Add(new City(1, "ROME")); // Creamos valor a valor nuestra lista de objetos
            cities.Add(new City(2, "LONDON")); // cities.Add(new City() { ID = 2, name = "LONDON" });
            cities.Add(new City(3, "NAIROBI"));
            cities.Add(new City(4, "CALIFORNIA"));
            cities.Add(new City(5, "ZURICH"));
            cities.Add(new City(6, "NEW DELHI"));
            cities.Add(new City(7, "AMSTERDAM"));
            cities.Add(new City(8, "ABU DABHI"));
            cities.Add(new City(9, "PARIS"));
            cities.Add(new City(10, "NEW YORK"));

            int sizeList = cities.Count(); // Numero de elementos en la lista

            Console.WriteLine("Input the number of elements in a group:"); //Numero de elementos en un mismo grupo
            size = Console.ReadLine();
            Int32.TryParse(size, out sizeInt);

            pages = sizeList / sizeInt; // Calculamos el número de páginas que surgirán. Número de elementos en la lista / Número de elementos por grupo
            if (sizeList % sizeInt > 0) //Si el resto es >0 querrá decir que se añadirá una pagina más con menos de 3 elementos
            {
                pages = pages + 1;
            }

            Console.WriteLine("elementos: " +sizeList + ", Number of pages: " + pages);


            for (int i = 0; i < pages; i++)
            {
                pageQuery =
                    ((from m in cities
                                     // m == cities[2]
                     select m).Skip(sizeInt*i).Take(sizeInt)).ToList(); //Especificamos que el resultado obtenido sea unua LISTA

                Console.WriteLine("\n  Page " + (i + 1));
                foreach (City city in pageQuery)
                {
                    Console.WriteLine(city);
                }


            }






            //for (int i = 0; i < pages; i++) //Recorremos pagina a pagina
            //{
            //    for (int j = 0; j < sizeInt; j++) //añadimos a una nueva lista los elementos de un grupo
            //    {
            //        groupCities.Add(cities[k]); //Cuando da alguna pagina con menos valores (resto>0), da error porque k es mayor que elm
            //        k = k + 1;
            //    }

            //    var cityQuery =
            //        from m in groupCities
            //        select m;

            //    Console.WriteLine("\n\t PAGE " + (i+1));
            //    foreach(var element in cityQuery)
            //    {
            //        Console.WriteLine(element);
            //    }
            //    Console.WriteLine("------------");

            //    groupCities.Clear();
            //}


            //var cityQuery =
            //    from m in cities.
            //    select m;

            //foreach (var element in cityQuery)
            //{
            //    Console.WriteLine(element);
            //}

            Console.ReadLine();
        }
    }
}
