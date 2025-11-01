using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class clVentas
    {

        public decimal CalcularTotalDetalle(decimal cantidad, decimal precioUnitario)
        {
            return cantidad * precioUnitario;
        }

        public decimal CalcularTotalVenta(decimal total, decimal descuento, decimal impuesto)
        {
            return (total - descuento) + impuesto;
        }


        public decimal CalcularImpuesto(decimal total)
        {
            return total * 0.12m;
        }


        public decimal CalcularDescuento(decimal total, int porcentaje)
        {
            return total * porcentaje / 100;
        }

    }
}
