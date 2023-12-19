using PracticaRestaurante.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaRestaurante.Clases
{
    public class Menu
    {
        private string _titulo;
        public string Titulo
        {
            get { return _titulo; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("El titulo de un menú no debe estar en blanco.");
                }
                _titulo = value;
            }
        }

        private List<Platillo> _platillos;

        public Menu(string titulo)
        {
            Titulo = titulo;
            _platillos = new List<Platillo>();
        }

        public void MostrarMenu()
        {
            Console.WriteLine(Titulo);
            foreach (var platillo in _platillos)
            {
                Console.WriteLine($"{platillo.Id} - {platillo.Nombre}: ${platillo.Precio}");
            }
        }

        public void AgregarPlatillo(string nombre, int precio)
        {
            foreach (var platillo in _platillos)
            {
                if (platillo.Nombre == nombre)
                {
                    Console.WriteLine("Ya existe un platillo con ese nombre en el menú.");
                    Console.WriteLine("Operación cancelada.");
                    return;
                }
            }

            _platillos.Add(new Platillo(nombre, precio));
        }
    }

}
