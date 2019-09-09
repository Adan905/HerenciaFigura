using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    abstract class figura
    {
        public string Color { get; set; }

        public abstract double calcularArea();
        
        public string toString()
        {
            return "soy una figura;" + Color;
        }
    }
}
