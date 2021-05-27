using SUTEL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SUTEL.Clases
{
    class Claro : IProveedor
    {
        int minutos { get; set; }
        public string nombre = "Claro";
        public Claro(int minutos)
        {
            this.minutos = minutos;
        }
        public double calculaTotal()
        {
            try
            {
                double costo = 0;
                if (minutos >= 1 && minutos <= 10)
                {
                    costo = minutos * 15;                    
                }
                else if (minutos >= 11)
                {
                    costo = 10 * 15;
                    costo += (minutos - 10) * 25;
                }
                else
                {
                    throw new Exception("Los minutos ingresados no pueden ser 0 o menor");
                }

                return costo;
            }
            catch (Exception)
            {
                throw new ApplicationException("Error al tratar de obtener el costo del Proveedor Claro.");
            }
        }
    }
}
