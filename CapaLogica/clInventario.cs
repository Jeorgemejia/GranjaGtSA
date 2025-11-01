using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class clInventario
    {
        public decimal mtdTotalCosto( decimal CantidadDisponible, decimal CostoUnitario)
        {
            decimal CostoTotal;
            CostoTotal = CantidadDisponible * CostoUnitario;
            return CostoTotal;


        }

    }
}
