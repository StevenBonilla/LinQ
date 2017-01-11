using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8_
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Item> items = new List<Item>();
            List<Quantity> quantities = new List<Quantity>();
            List<Resultado> result;

            items.Add(new Item(1, "Biscuit")); // Vamos añadiendo nuevos objetos a la lista items, pasando los parametros al constructor
            items.Add(new Item(2, "Chocolate"));  //sin los geters y seters en la clase Item, la creación del objeto sería -> { ID = 2, itemName = "Chocolate" });
            items.Add(new Item(3, "Butter"));
            items.Add(new Item(4, "Brade")); 

            quantities.Add(new Quantity(1, 1, 458)); //Añadimos un nuevo objeto a la lista quantities, pasando los parámetro que llegarán al constructor
            quantities.Add(new Quantity(2, 2, 650)); //sin los geters y seters en la clase Quantity, la creación del objeto sería -> quantities.Add(new Quantity() { IDS = 2, itemID = 2, cantidad = 650 });
            quantities.Add(new Quantity(3, 3, 800)); //{ IDS = 3, itemID = 3, cantidad = 800 });
            quantities.Add(new Quantity(4, 3, 900)); 
            quantities.Add(new Quantity(5, 3, 900)); 
            quantities.Add(new Quantity(6, 4, 700)); 
            quantities.Add(new Quantity(7, 4, 650));

           
            
            Console.WriteLine("Item ID   |    Item Name    |    Purchase Quantity");
            Console.WriteLine("---------------------------------------------------\n");

            //var joinQuery =
              result =  (from m in quantities
                join n in items on m.getItemID() equals n.getID()
                select new Resultado(m.getItemID(), n.getItemName(), m.getCantidad())).ToList(); //Creamos el nuevo objerto Resultado con los 3 valores solicitados

            foreach (Resultado m in result)
            {
                Console.WriteLine(m); //Imprimimos por pantalla, pero en la clse Resultado tenemos que pasar el valor "objeto" a "String" para poder imprimirlo
            }
           

            //foreach (var element in joinQuery)
            //{
            //    Console.WriteLine(element.item_ID + "\t\t" + element.item_Name + "\t\t\t" + element.Purchase_Quantity);
            //}






            Console.ReadLine();
        }
    }
}
