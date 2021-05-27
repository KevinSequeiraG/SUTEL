using SUTEL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUTEL.Clases
{
    class Telefono
    {
        public string numero { get; set; }
        public int minutos { get; set; }

        public IProveedor proveedor;

        public void agregarProveedor(IProveedor prov)
        {
            proveedor = prov;
        }

    }
}
