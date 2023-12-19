using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaRestaurante.Clases
{
    public class Platillo
    {
        private string _nombre;
        public string Nombre
        {
            get { return _nombre; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("El nombre de un platillo no puede estar en blanco.");
                }
                _nombre = value;
            }
        }

        private int _precio;
        public int Precio
        {
            get { return _precio; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("El precio de un platillo debe ser mayor a 0.");
                }
                _precio = value;
            }
        }

        private static int lastIdAdded = 0;

        private int _id;
        public int Id
        {
            get { return _id; }
            private set { _id = value; }
        }

        public Platillo(string nombre, int precio)
        {
            Nombre = nombre;
            Precio = precio;
            Id = lastIdAdded + 1;
            lastIdAdded++;
        }
    }
}
