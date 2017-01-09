using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {

            List<char> letraList = new List<char>(0);
            char letra = '0';

            Console.WriteLine("\nIntroduca caracter a caracter. Para terminar pulse * : "); // Pedimos por pantalla los caracteres

            letra = (char)Console.Read(); // Leemos el primero de los caracteres que se introduce
            while (letra != '*') // Determinamos el caracter '*' como fin/límite para la introducción de caracteres
            {
                if(Char.IsLetter(letra)) //Para obviar /r,/n... comprobamos que el caracter que está leyendo es una letra
                    letraList.Add(letra); // Si realmente es una letra, la almacena en la List
                letra = (char)Console.Read(); // Continúa leyendo caracter a caracter
                
            }
            Console.ReadLine(); // El último caracter introducido fue '*', el cual viene seguido de /r,/n..., para limpiarlos, hacemos el ReadLine, que leerá la línea entera, no solo el caracter

            //Console.WriteLine("Here is the list of items :");
            //letraList.ForEach(delegate (String name) // Mostrar por pantalla los valores de una list (Sin usar LinQ)
            //{
            //    Console.WriteLine(name);
            //});


            Console.WriteLine("\nLetter to remove: "); // Pedimios la letra con la cual queremos realizar el filtro
            char remove = (char)Console.Read(); // Almacenamos esa letra en remove


            var palabraQuery =
                from m in letraList
                where (m != remove) // Leemos la List, comparando caracter a caracter si coincide con remove
                select m; // Solo cogemos las letras que no coinciden con remove

            Console.WriteLine("\nHere is the list after removing the item " + remove + " from the list: ");
            foreach (var m in palabraQuery) // Imprimimos por pantalla las m seleccionadas (aquellas que no coinciden con remove)
            {
                Console.WriteLine(m); 
            }

            Console.ReadKey();

        }
    }
}
