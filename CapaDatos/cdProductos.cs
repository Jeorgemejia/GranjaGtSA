using CapaDatos;
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

        //Listar Granjas para ComboBox
        public List<dynamic> MtdListaCodigoGranja()
        {
            List<dynamic> ListaCodigoGranja = new List<dynamic>();
            string QueryListaCodigoGranja = "Select CodigoGranja, Nombre from tbl_Granjas";
            SqlCommand cmd = new SqlCommand(QueryListaCodigoGranja, cdConexiones.mtdAbrirConexion());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ListaCodigoGranja.Add(new
                {
                    Value = reader["CodigoGranja"],
                    Text = $"{reader["CodigoGranja"]}-{reader["Nombre"]}"
                });
            }

            cdConexiones.mtdCerrarConexion();
            return ListaCodigoGranja;
        }

        //Mostrar Informacion de la Granja en el DataGridView
        public string MtdListaGranjaDgv(int CodigoGranja)
        {
            string resultado = string.Empty;
            string QueryListaProductos = "Select CodigoGranja, Nombre from tbl_Producto where CodigoGranja=@CodigoGranja";
            SqlCommand cmd = new SqlCommand(QueryListaProductos, cdConexiones.mtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoGranja", CodigoGranja);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                string codigo = reader["CodigoGranja"].ToString();
                string nombre = reader["Nombre"].ToString();
                resultado = $"{codigo} - {nombre}";
            }
            else
            {
                resultado = string.Empty;
            }

            cdConexiones.mtdCerrarConexion();
            return resultado;
        }

        //Consultar todos los productos
        public DataTable mtdConsultarTablaProductos()
        {

            string queryConsultarProductos = "select * from tbl_Producto";
            SqlDataAdapter sqlAdap = new SqlDataAdapter(queryConsultarProductos, cdConexiones.mtdAbrirConexion());
            DataTable dtProd = new DataTable();
            sqlAdap.Fill(dtProd);

            cdConexiones.mtdCerrarConexion();
            return dtProd;
            
        }

        //Agregar nuevo producto
        public void MtdAgregarProducto(int CodigoGranja, string Nombre, string Tipo, decimal Precio, int Stock, DateTime FechaIngreso, DateTime FechaVencimiento, string Estado, string UsuarioAuditoria, DateTime FechaAuditoria)
        {

            string QueryAgregarProducto = "insert into tbl_Producto (Nombre, Tipo, Precio, Stock, FechaIngreso, FechaVencimiento, Estado, UsuarioAuditoria, FechaAuditoria) values (@Nombre, @Tipo, @Precio, @Stock, @FechaIngreso, @FechaVencimiento, @Estado, @UsuarioAuditoria, @FechaAuditoria)";
            SqlCommand ConnAgregarProducto = new SqlCommand(QueryAgregarProducto, cdConexiones.mtdAbrirConexion());
            ConnAgregarProducto.Parameters.AddWithValue("@CodigoGranja", CodigoGranja);
            ConnAgregarProducto.Parameters.AddWithValue("@Nombre", Nombre);
            ConnAgregarProducto.Parameters.AddWithValue("@Tipo", Tipo);
            ConnAgregarProducto.Parameters.AddWithValue("@Precio", Precio);
            ConnAgregarProducto.Parameters.AddWithValue("@Stock", Stock);
            ConnAgregarProducto.Parameters.AddWithValue("@FechaIngreso", FechaIngreso);
            ConnAgregarProducto.Parameters.AddWithValue("@FechaVencimiento", FechaVencimiento);
            ConnAgregarProducto.Parameters.AddWithValue("@Estado", Estado);
            ConnAgregarProducto.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            ConnAgregarProducto.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            ConnAgregarProducto.ExecuteNonQuery();
            cdConexiones.mtdCerrarConexion();
        }

        //Actualizar producto existente
        public void MtdActualizarProducto(int CodigoProducto, int CodigoGranja, string Nombre, string Tipo, decimal Precio, int Stock, DateTime FechaIngreso, DateTime FechaVencimiento, string Estado, string UsuarioAuditoria, DateTime FechaAuditoria)
        {
            string QueryActualizarProducto = "update tbl_Producto set CodigoGranja = @CodigoGranja, Nombre = @Nombre, Tipo = @Tipo, Precio = @Precio, Stock = @Stock, FechaIngreso = @FechaIngreso, FechaVencimiento = @FechaVencimiento, Estado = @Estado, UsuarioAuditoria = @UsuarioAuditoria, FechaAuditoria = @FechaAuditoria where CodigoProducto = @CodigoProducto";
            SqlCommand ConnActualizarProducto = new SqlCommand(QueryActualizarProducto, cdConexiones.mtdAbrirConexion());
            ConnActualizarProducto.Parameters.AddWithValue("@CodigoProducto", CodigoProducto);
            ConnActualizarProducto.Parameters.AddWithValue("@CodigoGranja", CodigoGranja);
            ConnActualizarProducto.Parameters.AddWithValue("@Nombre", Nombre);
            ConnActualizarProducto.Parameters.AddWithValue("@Tipo", Tipo);
            ConnActualizarProducto.Parameters.AddWithValue("@Precio", Precio);
            ConnActualizarProducto.Parameters.AddWithValue("@Stock", Stock);
            ConnActualizarProducto.Parameters.AddWithValue("@FechaIngreso", FechaIngreso);
            ConnActualizarProducto.Parameters.AddWithValue("@FechaVencimiento", FechaVencimiento);
            ConnActualizarProducto.Parameters.AddWithValue("@Estado", Estado);
            ConnActualizarProducto.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            ConnActualizarProducto.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            ConnActualizarProducto.ExecuteNonQuery();
            cdConexiones.mtdCerrarConexion();
        }

        //Eliminar producto
        public void MtdEliminarProducto(int CodigoProducto)
        {
            string QueryEliminarProducto = "delete from tbl_Producto where CodigoProducto = @CodigoProducto";
            SqlCommand ConnEliminarProducto = new SqlCommand(QueryEliminarProducto, cdConexiones.mtdAbrirConexion());
            ConnEliminarProducto.Parameters.AddWithValue("@CodigoProducto", CodigoProducto);
            ConnEliminarProducto.ExecuteNonQuery();
            cdConexiones.mtdCerrarConexion();
        }
    }
}
