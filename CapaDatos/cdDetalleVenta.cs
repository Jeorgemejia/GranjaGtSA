using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class cdDetalleVenta
    {

        cdConexiones conexion = new cdConexiones();

        public List<dynamic> MtdListaCodigoVentas()
        {
            List<dynamic> ListaCodigoVentas = new List<dynamic>();
            string QueryListaCodigoVentas = "select v.CodigoVentas, c.Nombre from tbl_Ventas v inner join tbl_Clientes c on v.CodigoCliente = c.CodigoCliente";
            SqlCommand cmd = new SqlCommand(QueryListaCodigoVentas, conexion.mtdAbrirConexion());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ListaCodigoVentas.Add(new
                {
                    Value = reader["CodigoVentas"],
                    Text = $"{reader["CodigoVentas"]}-{reader["Nombre"]}"
                });
            }

            conexion.mtdCerrarConexion();
            return ListaCodigoVentas;
        }

        public List<dynamic> MtdListaCodigoAnimal()
        {
            List<dynamic> ListaCodigoAnimal = new List<dynamic>();
            string QueryListaCodigoAnimal = "select CodigoAnimal, TipoAnimal from tbl_Animales";
            SqlCommand cmd = new SqlCommand(QueryListaCodigoAnimal, conexion.mtdAbrirConexion());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ListaCodigoAnimal.Add(new
                {
                    Value = reader["CodigoAnimal"],
                    Text = $"{reader["CodigoAnimal"]}-{reader["TipoAnimal"]}"
                });
            }

            conexion.mtdCerrarConexion();
            return ListaCodigoAnimal;
        }

        public List<dynamic> MtdListaCodigoCultivo()
        {
            List<dynamic> ListaCodigoCultivo = new List<dynamic>();
            string QueryListaCodigocultivo = "select CodigoCultivo, TipoCultivo from tbl_Cultivo";
            SqlCommand cmd = new SqlCommand(QueryListaCodigocultivo, conexion.mtdAbrirConexion());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ListaCodigoCultivo.Add(new
                {
                    Value = reader["CodigoCultivo"],
                    Text = $"{reader["CodigoCultivo"]}-{reader["TipoCultivo"]}"
                });
            }

            conexion.mtdCerrarConexion();
            return ListaCodigoCultivo;
        }

        public List<dynamic> MtdListaCodigoProducto()
        {
            List<dynamic> ListaCodigoProducto = new List<dynamic>();
            string QueryListaCodigoProducto = "select CodigoProducto, Nombre from tbl_Producto";
            SqlCommand cmd = new SqlCommand(QueryListaCodigoProducto, conexion.mtdAbrirConexion());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ListaCodigoProducto.Add(new
                {
                    Value = reader["CodigoProducto"],
                    Text = $"{reader["CodigoProducto"]}-{reader["Nombre"]}"
                });
            }

            conexion.mtdCerrarConexion();
            return ListaCodigoProducto;
        }

        //ffffffffff



        public DataTable mtdConsultarConsultarTablaDetalleVentas()
        {
            string queryConsultarDetalleVenta = "select * from tbl_DetalleVenta";
            SqlDataAdapter adapter = new SqlDataAdapter(queryConsultarDetalleVenta, conexion.mtdAbrirConexion());
            DataTable dtVentas = new DataTable();
            adapter.Fill(dtVentas);
            conexion.mtdCerrarConexion();
            return dtVentas;
            conexion.mtdCerrarConexion();

        }


        public void MtdAgregarDetalleVenta(int CodigoVentas,int? CodigoAnimal,int? CodigoCultivo, int? CodigoProducto,int Cantidad,decimal PrecioUnitario, decimal Total, decimal Descuento,decimal Impuesto,decimal TotalVenta,string Estado,string UsuarioAuditoria,DateTime FechaAuditoria)
        {
            string query = @"INSERT INTO tbl_DetalleVenta (CodigoVentas, CodigoAnimal, CodigoCultivo, CodigoProducto, Cantidad, PrecioUnitario, Total, Descuento, Impuesto, TotalVenta, Estado, UsuarioAuditoria, FechaAuditoria) VALUES (@CodigoVentas, @CodigoAnimal, @CodigoCultivo, @CodigoProducto, @Cantidad, @PrecioUnitario, @Total, @Descuento, @Impuesto, @TotalVenta, @Estado, @UsuarioAuditoria, @FechaAuditoria)";

    
            using (SqlCommand cmd = new SqlCommand(query, conexion.mtdAbrirConexion()))
            {
                cmd.Parameters.AddWithValue("@CodigoVentas", CodigoVentas);

                cmd.Parameters.AddWithValue("@CodigoAnimal", (object)CodigoAnimal ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@CodigoCultivo", (object)CodigoCultivo ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@CodigoProducto", (object)CodigoProducto ?? DBNull.Value);

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

        public void MtdActualizarDetalleVenta(int CodigoDetalle, int CodigoVentas, int CodigoAnimal, int CodigoCultivo, int CodigoProducto, int Cantidad, decimal PrecioUnitario, decimal Total, decimal Descuento, decimal Impuesto, decimal TotalVenta, string Estado, string UsuarioAuditoria, DateTime FechaAuditoria)
        {
            string query = "UPDATE tbl_DetalleVentas SET CodigoVentas = @CodigoVentas, CodigoAnimal = @CodigoAnimal, CodigoCultivo = @CodigoCultivo, CodigoProducto = @CodigoProducto, Cantidad = @Cantidad, PrecioUnitario = @PrecioUnitario, Total = @Total, Descuento = @Descuento, Impuesto = @Impuesto, TotalVenta = @TotalVenta, Estado = @Estado, UsuarioAuditoria = @UsuarioAuditoria, FechaAuditoria = @FechaAuditoria WHERE CodigoDetalle = @CodigoDetalle";

            using (SqlCommand cmd = new SqlCommand(query, conexion.mtdAbrirConexion()))
            {
                cmd.Parameters.AddWithValue("@CodigoDetalle", CodigoDetalle);
                cmd.Parameters.AddWithValue("@CodigoVentas", CodigoVentas);
                cmd.Parameters.AddWithValue("@CodigoAnimal", (object)CodigoAnimal ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@CodigoCultivo", (object)CodigoCultivo ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@CodigoProducto", (object)CodigoProducto ?? DBNull.Value);
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

        public void MtdEliminarDetalleVenta(int CodigoDetalle)
        {
            string query = "delete from tbl_DetalleVentas where CodigoDetalle=@CodigoDetalle";
            SqlCommand cmd = new SqlCommand(query, conexion.mtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoDetalle", CodigoDetalle);
            cmd.ExecuteNonQuery();
            conexion.mtdCerrarConexion();
        }





      


       

     





    }
}
