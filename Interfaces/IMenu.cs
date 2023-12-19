using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaRestaurante.Interfaces
{
    public interface IMenu
    {
        int TotalPlatillos { get; }

        void AgregarPlatillo(string nombre, int precio);

        void MostrarMenu();
    }
}
