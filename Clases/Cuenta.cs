using PracticaRestaurante.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaRestaurante.Clases
{
    public class Cuenta : ICuenta
    {
        private List<ElementoCuenta> _elementosCuenta;
        public int Total {

            get {

                int total = 0;
                foreach (var elemento in _elementosCuenta){
                    total += elemento.CostoTotal;
                }

                return total;
            }
        }

        public Cuenta(){

            _elementosCuenta = new List<ElementoCuenta>();

        }

        public void AgregarElemento(IPlatillo platillo, int Cantidad){
            
            foreach (var elemento in _elementosCuenta){
                if (elemento.platillo.Id == platillo.Id){
                    elemento.Cantidad += Cantidad;
                    return;
                }
            }

            _elementosCuenta.Add(new ElementoCuenta(platillo, Cantidad));

        }

        public void MostrarCuenta(){
            System.Console.WriteLine("La cuenta es la siguiente:");
            foreach (var elemento in _elementosCuenta){
                Console.WriteLine($"{elemento.platillo.Nombre}. Cant: {elemento.Cantidad}. Total: ${elemento.CostoTotal}");
            }
        }

    }


}