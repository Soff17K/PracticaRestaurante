using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticaRestaurante.Interfaces;

namespace PracticaRestaurante.Interfaces
{
    public interface ICuenta
    {
    
        private List<ElementoCuenta> _elementosCuenta;

        public int Total { get; }

        public void AgregarElemento(Platillo platillo, int Cantidad){

        }

        public void MostrarCuenta(){

        }

    }

}