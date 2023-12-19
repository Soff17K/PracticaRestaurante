using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaRestaurante.Interfaces
{
    public interface IRestaurante
    {
        List<IMenu> CrearMenu();
        void AgregarElementosAMenu(List<IMenu> menuList);
        void VerMenu();
        List<IMenu> ObtenerMenu(int indiceMenu);


    }
}
