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
            List<dynamic> ListaCodigoEmpleado = new List<dynamic>();
            string QueryListaCodigoEmpleado = "Select CodigoEmpleado, Nombre from tbl_Empleado";
            SqlCommand cmd = new SqlCommand(QueryListaCodigoEmpleado, conexion.mtdAbrirConexion());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ListaCodigoEmpleado.Add(new
                {
                    Value = reader["CodigoEmpleado"],
                    Text = $"{reader["CodigoEmpleado"]}-{reader["Nombre"]}"
                });
            }

            conexion.mtdCerrarConexion();
            return ListaCodigoEmpleado;
        }



        public string MtdListarCodigoClienteDgv(int CodigoCliente)
        {
            string resultado = string.Empty;
            string QueryListaCodigoCliente = "Select CodigoOrdenEnc, MontoTotalOrd from tbl_EncabezadoOrdenes where CodigoOrdenEnc=@CodigoOrdenEnc";
            SqlCommand cmd = new SqlCommand(QueryListaCodigoCliente, conexion.mtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoCliente", CodigoCliente);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                string Codigo = reader["CodigoCliente"].ToString();
                string Nombre = reader["Nombre"].ToString();
                resultado = $"{Codigo} - {Nombre}";
            }
            else
            {
                resultado = string.Empty;
            }
            conexion.mtdCerrarConexion();
            return resultado;
        }


        public string MtdListarCodigoEmpleadoDgv(int CodigoEmpleado)
        {
            string resultado = string.Empty;
            string QueryListaCodigoEmpleado = "Select CodigoEmpleado, Nombre from tbl_Empleados where CodigoEmpleado=@CodigoEmpleado";
            SqlCommand cmd = new SqlCommand(QueryListaCodigoEmpleado, conexion.mtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoEmpleado", CodigoEmpleado);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                string Codigo = reader["CodigoEmpleado"].ToString();
                string Nombre = reader["Nombre"].ToString();
                resultado = $"{Codigo} - {Nombre}";
            }
            else
            {
                resultado = string.Empty;
            }
            conexion.mtdCerrarConexion();
            return resultado;
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



        public void MtdActualizarVenta(int CodigoVentas, int CodigoCliente, int CodigoEmpleado, DateTime FechaVenta, string TipoVenta, decimal TotalVenta, string Estado, string UsuarioAuditoria, DateTime FechaAuditoria)
        {
            string query = "UPDATE tbl_Ventas SET CodigoCliente = @CodigoCliente, CodigoEmpleado = @CodigoEmpleado, FechaVenta = @FechaVenta, TipoVenta = @TipoVenta, TotalVenta = @TotalVenta, Estado = @Estado, UsuarioAuditoria = @UsuarioAuditoria, FechaAuditoria = @FechaAuditoria WHERE CodigoVentas = @CodigoVentas";
            SqlCommand cmd = new SqlCommand(query, conexion.mtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoVentas", CodigoVentas);
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

        public void MtdEliminarrVenta(int CodigoVentas)
        {
            string query = "DELETE FROM tbl_Ventas WHERE CodigoVentas = @CodigoVentas;";
            SqlCommand cmd = new SqlCommand(query, conexion.mtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoVentas", CodigoVentas);
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


        //Obtener granja

        public string ObtenerGranja(int CodigoEmpleado)
        {
            string nombreGranja = string.Empty;

            using (SqlConnection sqlConnection = conexion.mtdAbrirConexion())
            {
                string query = @"SELECT g.Nombre AS NombreGranja
                         FROM tbl_Empleado e
                         INNER JOIN tbl_Granjas g ON e.CodigoGranja = g.CodigoGranja
                         WHERE e.CodigoEmpleado = @CodigoEmpleado";

                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@CodigoEmpleado", CodigoEmpleado);

                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    if (reader.Read())
                    {
                        // Asegúrate que la columna existe y no es nula
                        nombreGranja = reader["NombreGranja"] != DBNull.Value
                                       ? reader["NombreGranja"].ToString()
                                       : string.Empty;
                    }
                    reader.Close();
                }
            }
            conexion.mtdCerrarConexion();

            return nombreGranja;
        }


        //Obtener totaldevetnas

        public decimal ObtenerTotalVentaPorCodigo(int CodigoVentas)
        {
            decimal total = 0;
            using (SqlConnection conn = conexion.mtdAbrirConexion())
            {
                string query = "SELECT ISNULL(SUM(TotalVenta), 0) FROM tbl_DetalleVenta WHERE CodigoVentas = @CodigoVentas";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CodigoVentas", CodigoVentas);
                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                    total = Convert.ToDecimal(result);
            }
            conexion.mtdCerrarConexion();
            return total;
        }





    }
}
