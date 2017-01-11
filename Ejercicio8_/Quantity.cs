using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8_
{
    class Quantity
    {
        private int IDS;

        private int itemID;

        private int cantidad;

        public Quantity(int _IDS, int _itemID, int _cantidad) //Constructor
        {
            this.IDS = _IDS;
            this.itemID = _itemID;
            this.cantidad = _cantidad;
        }

        // GET y SET para IDS
        public int getIDS()
        {
            return IDS;
        }

        public void setIDS(int _IDS)
        {
            this.IDS = _IDS;
        }

        // GET y SET para itemID
        public int getItemID()
        {
            return itemID;
        }

        public void setItemID(int _itemID)
        {
            this.itemID = _itemID;
        }

        //GET y SET para Cantidad
        public int getCantidad()
        {
            return cantidad;
        }

        public void setCantidad(int _cantidad)
        {
            this.cantidad = _cantidad;
        }

    }
}
