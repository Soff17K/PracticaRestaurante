using PracticaRestaurante.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaRestaurante.Clases
{
    public class Restaurante : IRestaurante
    {
        private List<IMenu> _menus;
        public Restaurante()
        {
            _menus = new List<IMenu>();
        }
        public IMenu CrearMenu(string nombreMenu)
        {
            
        }

        public void AgregarElementosAMenu(List<IMenu> menuList)
        {

        }
        void VerMenu();
        List<IMenu> ObtenerMenu(int indiceMenu);
    }
}
