using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class clDetalleVenta
    {

       public decimal mtdTotal(decimal Precio, decimal Cantidad)
        {
            return Precio*Cantidad;
        }


        public decimal mtdDescuento(decimal Total, decimal Descuento)
        {
            return Total * Descuento;
        }

        public decimal MtdImpuesto(decimal Total)
        {
            return Total * 0.12m;
        }

        public decimal MtdTotalVenta(decimal Total, decimal Descuento, decimal Impuesto)
        {
            decimal TotalVenta = 0;
            TotalVenta = (Total - Descuento) + Impuesto;
            return TotalVenta;
        }

    }
}
