using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticaRestaurante.Interfaces;

namespace PracticaRestaurante.Interfaces
{
    public interface IElementoCuenta
    {
        public Platillo platillo { get; set; }
        public int Cantidad { get; set; }

        public int CostoTotal { get; }
    }

}