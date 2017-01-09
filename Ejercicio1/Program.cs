using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            string valor;
            int valorInt;
            int[] numbers = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine("Introduzca un número: ");
            valor = Console.ReadLine();
            Int32.TryParse(valor, out valorInt);
            

            var numQuery =
                from num in numbers
                where (num == valorInt)  // Toma aquellos valores de la colección (Array) que coincidan con el valor introducido por pantalla
                select num;

            if(numQuery.Count() > 0) // Cantidad de elmentos que hay en la colección numQuery
            {
                foreach (int num in numQuery)  // Toma de la colección numQuery los elementos num
                      
                {
                    Console.WriteLine("\nNumber = " + num + ", " + "SqrNo = " + num * num); // Muestra por pantalla el numero y su cuadrado
                }
            }else
            {
                Console.WriteLine("Element not found");
            }
                
            
            Console.ReadLine();
        }
    }
}
