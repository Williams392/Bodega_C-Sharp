using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace caso
{
    // Modelo de bodega.
    internal class bodega
    {
        public int codigo;
        public int correlativo;
        public string producto;
        public int cant;
        public double precio;
        public bodega sgte;

    }
}
