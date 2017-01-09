using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5_
{
    class Program
    {
        static void Main(string[] args)
        {
            char c = '0';
            string palabra = "";
            List<string> palabraList = new List<string>(0);


            //bool flag = false;
            //while (!flag)
            //{
            //    char c = (char)Console.Read(); // Lee caracter a caracter
            //    frase = frase + c; // Va almacenando en el string la concatenación de los caracteres C
            //    if (c == 32)  // Si encuentra un espacio (32), almacena los anteriores caracteres como una única palabra
            //    {
            //        palabra.Add(frase); // Añade una nueva palabra a la lista
            //        frase = "";
            //    }else if (c == 13) // Si el caracter introducido es enter (13), cambia la variable flag a true para salir del bucle while
            //    {
            //        palabra.Add(frase);
            //        flag = true;
            //    }
            //}

            do
            {
                c = (char)Console.Read(); // Lee caracter a caracter
                palabra = palabra + c; // Va almacenando en el string la concatenación de los caracteres C
                if (c == 32)  // Si encuentra un espacio (32), almacena los anteriores caracteres como una única palabra
                {
                    palabraList.Add(palabra); // Añade una nueva palabra a la lista
                    palabra = ""; // Ponemos a "0" el string
                }
            } while (c != 13);

            palabraList.Add(palabra); // Añadimos a la lista la última palabra introducida (No ha sido detectada por el espacio)


            //palabraList.ForEach(delegate (String name) // Mostrar por pantalla los valores de una list (Sin usar LinQ)
            //{
            //    Console.Write("" + name);
            //});

            var palabraQuery =
                from m in palabraList
                where (m == m.ToUpper()) // Compara cada palabra consigo mismo en mayúscula, para saber si la original lo es
                select m;

            Console.WriteLine("\nThe UPPER CASE words are: \n");

            foreach (var m in palabraQuery)
            {
                Console.WriteLine(m);
            }



            Console.ReadKey();


        }
    }
}
