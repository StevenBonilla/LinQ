using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    class item
    {

        public int x, y;

        // Default constructor:
        public item()
        {
            x = 0;
            y = 0;
        }

        // A constructor with two arguments:
        public item(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        // Override the ToString method:
        public override string ToString()
        {
            return (String.Format("({0},{1})", x, y));
        }

    }
}
