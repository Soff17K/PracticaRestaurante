﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaRestaurante.Interfaces
{
    public interface IRestaurante
    {
        IMenu CrearMenu(string nombreMenu);
        void AgregarElementosAMenu(IMenu menu);
        void VerMenus();
        IMenu ObtenerMenu(int indiceMenu);


    }
}
