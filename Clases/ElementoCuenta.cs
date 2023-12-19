using PracticaRestaurante.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaRestaurante.Clases
{
    public class ElementoCuenta : IElementoCuenta
    {
        public IPlatillo platillo { get; set; }
        public int Cantidad { get; set; }

        public int CostoTotal {
            get
            {
                return platillo.Precio * Cantidad;
            }
        }

        public ElementoCuenta(IPlatillo platillo, int cantidad)
        {
            this.platillo = platillo;
            Cantidad = cantidad;
        }

    }

}