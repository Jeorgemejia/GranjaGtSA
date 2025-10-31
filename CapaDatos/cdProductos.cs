using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class cdProductos
    {
        cdConexiones cdConexiones = new cdConexiones();
        string QueryConsultar = "Select * from tbl_Producto";
        public DataTable MtdConsultarProductos()
        {
            string QueryConsultar = "Select * from tbl_Producto";
            SqlDataAdapter sqlAdap = new SqlDataAdapter(QueryConsultar, cdConexiones.mtdAbrirConexion());
            DataTable dtProductos = new DataTable();
            sqlAdap.Fill(dtProductos);
            cdConexiones.mtdCerrarConexion();
            return dtProductos;

            cdConexiones.mtdCerrarConexion();
        }


    }
}
