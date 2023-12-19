using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaRestaurante.Interfaces
{
    public internal interface IMenu
    {
        int TotalPlatillos { get; }

        void AgregarPlatillo(Platillo platillo);

        void MostrarMenu();
    }
}
