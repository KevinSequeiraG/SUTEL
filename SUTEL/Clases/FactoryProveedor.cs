using SUTEL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUTEL.Clases
{
    class FactoryProveedor
    {
        public static IProveedor CrearProveedor(bool kolbi, bool movistar, bool claro, int minutos)
        {
            if (kolbi)
                return new Kolbi(minutos);
            else if (movistar)
                return new Movistar(minutos);
            else
                return new Claro(minutos);
        }
    }
}
