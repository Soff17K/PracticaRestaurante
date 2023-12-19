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
            //IMenu nuevoMenu = new IMenu(nombreMenu);
            //return nuevoMenu;
        }

        public void AgregarElementosAMenu(IMenu menu)
        {
            while(true)
            {
                Console.WriteLine("¿Deseas agregar un nuevo platillo?");
                Console.WriteLine("1) Si    2)No");
                string seleccion = Console.ReadLine();
                if (seleccion == "1")
                {
                    Console.WriteLine("¿Cómo se llama el platillo?");
                    string nombrePlatillo = Console.ReadLine();
                    Console.WriteLine("¿Cuál es el precio del platillo?");
                    int precioPlatillo = int.Parse(Console.ReadLine());
                    menu.AgregarPlatillo(nombrePlatillo, precioPlatillo);
                }
                else
                {
                    break;
                }

            }
            
            
        }
        void VerMenu();
        List<IMenu> ObtenerMenu(int indiceMenu);
    }
}
