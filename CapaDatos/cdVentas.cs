using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class cdVentas
    {

        cdConexiones conexion = new cdConexiones();

        public List<dynamic> MtdListaCodigoCliente()
        {
            List<dynamic> ListaCodigoCliente = new List<dynamic>();
            string QueryListaCodigoCliente = "Select CodigoCliente, Nombre from tbl_Clientes";
            SqlCommand cmd = new SqlCommand(QueryListaCodigoCliente, conexion.mtdAbrirConexion());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ListaCodigoCliente.Add(new
                {
                    Value = reader["CodigoCliente"],
                    Text = $"{reader["CodigoCliente"]}-{reader["Nombre"]}"
                });
            }

            conexion.mtdCerrarConexion();
            return ListaCodigoCliente;
        }


        public List<dynamic> MtdListaCodigoEmpleado()
        {
            List<dynamic> ListaCodigoCliente = new List<dynamic>();
            string QueryListaCodigoCliente = "Select CodigoCliente, Nombre from tbl_Clientes";
            SqlCommand cmd = new SqlCommand(QueryListaCodigoCliente, conexion.mtdAbrirConexion());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ListaCodigoCliente.Add(new
                {
                    Value = reader["CodigoCliente"],
                    Text = $"{reader["CodigoCliente"]}-{reader["Nombre"]}"
                });
            }

            conexion.mtdCerrarConexion();
            return ListaCodigoCliente;
        }


        public DataTable mtdConsultarConsultarTablaVentas()
        {
            string queryConsultarVentas = "select * from tbl_Ventas";
            SqlDataAdapter adapter = new SqlDataAdapter(queryConsultarVentas, conexion.mtdAbrirConexion());
            DataTable dtVentas = new DataTable();
            adapter.Fill(dtVentas);
            conexion.mtdCerrarConexion();
            return dtVentas;
            conexion.mtdCerrarConexion();

        }


        public void MtdAgregarVenta(int CodigoCliente, int CodigoEmpleado, DateTime FechaVenta, string TipoVenta, decimal TotalVenta, string Estado, string UsuarioAuditoria, DateTime FechaAuditoria)
        {
            string query = "insert into tbl_Ventas (CodigoCliente, CodigoEmpleado, FechaVenta, TipoVenta,TotalVenta, Estado, UsuarioAuditoria, FechaAuditoria) values (@CodigoCliente, @CodigoEmpleado, @FechaVenta, @TipoVenta,@TotalVenta, @Estado, @UsuarioAuditoria, @FechaAuditoria)";
            SqlCommand cmd = new SqlCommand(query, conexion.mtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoCliente", CodigoCliente);
            cmd.Parameters.AddWithValue("@CodigoEmpleado", CodigoEmpleado);
            cmd.Parameters.AddWithValue("@FechaVenta", FechaVenta);
            cmd.Parameters.AddWithValue("@TipoVenta", TipoVenta);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@TotalVenta", TotalVenta);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            cmd.ExecuteNonQuery();
            conexion.mtdCerrarConexion();
        }


        //detalle Ventas
        public void AgregarDetalleVenta(int CodigoVentas, int CodigoAnimal, int CodigoCultivo, int CodigoProducto, decimal Cantidad, decimal PrecioUnitario, decimal Total, decimal Descuento, decimal Impuesto, decimal TotalVenta, string Estado, string UsuarioAuditoria, DateTime FechaAuditoria)
        {
            string query = "insert into tbl_DetalleVenta (CodigoVentas, CodigoAnimal, CodigoCultivo, CodigoProducto, Cantidad, PrecioUnitario, Total, Descuento, Impuesto, TotalVenta) values (@CodigoVentas, @CodigoAnimal, @CodigoCultivo, @CodigoProducto, @Cantidad, @PrecioUnitario, @Total, @Descuento, @Impuesto, @TotalVenta)";
            SqlCommand cmd = new SqlCommand(query, conexion.mtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoVentas", CodigoVentas);
            cmd.Parameters.AddWithValue("@CodigoAnimal", CodigoAnimal);
            cmd.Parameters.AddWithValue("@CodigoCultivo", CodigoCultivo);
            cmd.Parameters.AddWithValue("@CodigoProducto", CodigoProducto);
            cmd.Parameters.AddWithValue("@Cantidad", Cantidad);
            cmd.Parameters.AddWithValue("@PrecioUnitario", PrecioUnitario);
            cmd.Parameters.AddWithValue("@Total", Total);
            cmd.Parameters.AddWithValue("@Descuento", Descuento);
            cmd.Parameters.AddWithValue("@Impuesto", Impuesto);
            cmd.Parameters.AddWithValue("@TotalVenta", TotalVenta);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);

            cmd.ExecuteNonQuery();
            conexion.mtdCerrarConexion();


        }
    }
}
