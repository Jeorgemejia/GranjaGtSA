using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaDatos;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class clVentas
    {

        cdVentas cd_Ventas = new cdVentas();

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




        public string MtdObtenerNombreGranja(int codigoEmpleado)
        {
            cdVentas cd_Ventas = new cdVentas();
            return cd_Ventas.ObtenerGranja(codigoEmpleado);
        }



        public decimal MtdObtenerTotalVentaPorCodigo(int codigoVenta)
        {
            return cd_Ventas.ObtenerTotalVentaPorCodigo(codigoVenta);
        }





    }
}
