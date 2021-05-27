using SUTEL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUTEL.Clases
{
    class FacadeProveedor
    {
        public double ObtenerCosto(IProveedor prov)
        {
            if (prov.GetType() == typeof(Kolbi))
            {
                return prov.calculaTotal();
            }
            else if (prov.GetType() == typeof(Movistar))
            {
                return prov.calculaTotal();
            }
            else if (prov.GetType() == typeof(Claro))
            {
                return prov.calculaTotal();
            }
            else
            {
                throw new ApplicationException("Error al obtener el costo");
            }
        }

        public string nombreProveedor(IProveedor prov)
        {
            if (prov.GetType() == typeof(Kolbi))
            {
                return "Kolbi";
            }
            else if (prov.GetType() == typeof(Movistar))
            {
                return "Movistar";
            }
            else if (prov.GetType() == typeof(Claro))
            {
                return "Claro";
            }
            else
            {
                throw new ApplicationException("Error al obtener el nombre de proveedor");
            }
        }
    }
}
