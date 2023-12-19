using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaRestaurante.Interfaces
{
    public interface IPlatillo
    {
        string Nombre { get; set; }
        int Precio { get; set; }
        int Id { get; }
    }
}
