using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {

            string size;
            int sizeInt;
            string[] palabra;
            string valor;
            string item;
            int itemInt;

            Console.WriteLine("Input number of strings to store in the array"); // Pedimos el tamaño del vector
            size = Console.ReadLine();
            Int32.TryParse(size, out sizeInt);

            palabra = new string[sizeInt];
            for(int i = 0; i < sizeInt; i++)
            {
                Console.WriteLine("Palabra en la posición " + i + " del vector"); // Almacenamos para cada posición del vector un nuevo string
                valor = Console.ReadLine();
                palabra[i] = valor;
            }

            Console.WriteLine("Input the minimum length of the item you want to find : "); // Longitud mínima de los String qu queremos filtrar
            item = Console.ReadLine();
            Int32.TryParse(item, out itemInt);

            var itemQuery =
                from m in palabra
                where m.Length >= itemInt // Solo cogerá aquellos string (m) que tengan una longitud mayor o igual a la impuesta (itemInt)
                select m;

            Console.WriteLine("The items of minimum " + itemInt + " characters are :"); // Imprimimos por pantalla los valores filtrados
            foreach (var m in itemQuery)
            {
                Console.WriteLine(m);
            }

            Console.ReadLine();

        }
    }
}
