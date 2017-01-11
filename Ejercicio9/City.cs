using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class City
    {

        private int ID;
        private string name;

        public City (int _ID, string _name)
        {
            this.ID = _ID;
            this.name = _name;
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

        //GET y SET para Name de la ciduad
        public string getName()
        {
            return name;
        }

        public void setName(string _name)
        {
            this.name = _name;
        }

        public override string ToString()
        {
            return name;
        }

    }
}
