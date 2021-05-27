using SUTEL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUTEL.Clases
{
    class Kolbi : IProveedor
    {
        int minutos { get; set; }
        string nombre = "Kolbi";
        public Kolbi(int minutos)
        {
            this.minutos = minutos;
        }
        public double calculaTotal()
        {
            try
            {
                double costo = 0;
                if (minutos >= 1 && minutos <= 5)
                {
                    costo = 30 * minutos;
                }
                else if (minutos >= 6 && minutos <= 15)
                {
                    costo = 5 * 30;
                    costo += (minutos - 5) * 25;
                }
                else if (minutos >= 16)
                {
                    costo = 5 * 30;
                    costo += 10 * 25;
                    costo += (minutos - 15) * 20;
                }
                else
                {
                    throw new Exception("Los minutos ingresados no pueden ser 0 o menor");
                }
                return costo;
            }
            catch (Exception)
            {
                throw new ApplicationException("Error al tratar de obtener el costo del Proveedor Kolbi.");
            }            
        }
    }
}
