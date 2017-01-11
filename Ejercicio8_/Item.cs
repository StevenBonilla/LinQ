using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8_
{
    class Item
    {
        private int ID;

        private string itemName;

        public Item(int _ID, string _itemName) //Constructor
        {
            this.ID = _ID;
            this.itemName = _itemName;
        }

        //GET y SET para ID
        public int getID()
        {
            return ID;
        }

        public void setID(int _ID)
        {
            this.ID = _ID;
        }

        //GET y SET para itemName
        public string getItemName()
        {
            return itemName;
        }

        public void setItemName(string _itemName)
        {
            this.itemName = _itemName;
        }




    }
}
