using SUTEL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUTEL.Clases
{
    class Movistar : IProveedor
    {
        int minutos { get; set; }
        string nombre = "Movistar";
        public Movistar(int minutos)
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
                    costo = minutos * 28;
                }
                else if (minutos >= 11 && minutos <= 20)
                {
                    costo = 10 * 28;
                    costo += (minutos - 10) * 22;
                }                    
                else if (minutos >= 21)
                {
                    costo = 10 * 28;
                    costo += 10 * 22;
                    costo += (minutos - 20) * 18;
                }                    
                else
                    throw new Exception("Los minutos ingresados no pueden ser 0 o menor");

                return costo;
            }
            catch (Exception e)
            {
                throw new ApplicationException("Error al tratar de obtener el costo del Proveedor Movistar.");
            }
        }
    }
}
