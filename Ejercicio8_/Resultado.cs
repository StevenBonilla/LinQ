using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8_
{
    class Resultado
    {
        private int item_ID;
        private string item_Name;
        private int Purchase_Quantity;

        public Resultado(int _item_ID, string _item_Name, int _Purchase_Quantity) // Constructor
        {
            this.item_ID = _item_ID;
            this.item_Name = _item_Name;
            this.Purchase_Quantity = _Purchase_Quantity;
        }

        public int getItem_ID()
        {
            return item_ID;
        }

        public void setItem_ID(int _item_ID)
        {
            this.item_ID = _item_ID;
        }

        public string getItem_Name()
        {
            return item_Name;
        }

        public void setItem_Name(string _item_Name)
        {
            this.item_Name = _item_Name;
        }

        public int getPurchase_Quantity()
        {
            return Purchase_Quantity;
        }

        public void setPurchase_Quantity(int _Purchase_Quantity)
        {
            this.Purchase_Quantity = _Purchase_Quantity;
        }

        public override string ToString()
        {
            return item_ID + "\t\t" + item_Name + "\t\t\t" + Purchase_Quantity; //Para poder imprimir los 3 valores por pantalla cuando se llame al objeto desde el main
            
        }





    }
}
