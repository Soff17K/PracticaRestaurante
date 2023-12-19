using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaRestaurante.Interfaces
{
    public interface ICuenta
    {
        public int Total { get; }

        public void AgregarElemento(IPlatillo platillo, int Cantidad){
            
        }

        public void MostrarCuenta(){

        }

    }

}