using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {

            string size;
            int sizeInt;
            int[] numbers;
            string valor;
            int valorInt;

            Console.WriteLine("\nIntroduzca el tamaño del vector: ");
            size = Console.ReadLine();
            Int32.TryParse(size, out sizeInt);

            numbers = new int[sizeInt];

            for (int i = 0; i < sizeInt; i++) // Pido por pantalla los valores del vector
            {
                Console.WriteLine("introduzca el valor de la posición " + i);
                valor = Console.ReadLine();
                Int32.TryParse(valor, out valorInt);
                numbers[i] = valorInt;
            }

            var numQuery =
                from num in numbers.Distinct() // Para el ejemplo numbers = {1, 1, 2, 2, 5} -> Num pertenece a la colección de valores no repetidos {1, 2, 5}
                select new { Numbers = num, appears = (from m in numbers where (num == m) select m).Count() }; // Creación objeto. Comparamos los valores Num(de repetidos) con m(del original), y los contamos

            foreach (var Numbers in numQuery){
                Console.WriteLine("" + Numbers); // Imprimimos por pantalla el objeto, que contiene los distintos parámetros
            }


            Console.ReadLine(); 

        }
    }
}
