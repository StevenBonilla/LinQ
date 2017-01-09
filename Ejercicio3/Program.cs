using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
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
             
            for (int i = 0; i < sizeInt; i++) //pido por pantalla los valores del vector
            {
                Console.WriteLine("introduzca el valor de la posición " + i);
                valor = Console.ReadLine();
                Int32.TryParse(valor, out valorInt);
                numbers[i] = valorInt;
            }

            var numQuery =
                from num in numbers.Distinct() // num recorrerá solo el vector con todos los elementos, pero eliminando los repetidos
                select new { Numbers = num, Frecuency = (from m in numbers where (num == m) select m).Count() };

            foreach(var element in numQuery) // Puedo llamar a un elemento en concreto de mi colección (en este caso del objeto creado "Numbers")
            {
                
                Console.WriteLine("Number: " + element.Numbers + ", Frecuency: " + element.Frecuency + ", Number*Frecuency: " + element.Numbers * element.Frecuency);
            }

            Console.ReadLine();
        }
    }
}
