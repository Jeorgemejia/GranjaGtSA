using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class cdEnvio
    {
        cdConexiones conexion = new cdConexiones();

        // Método para obtener la lista de códigos de ventas junto con el nombre del cliente
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

        // Método para obtener la lista de códigos de empleados junto con el nombre del empleado
        public List<dynamic> MtdListaCodigoEmpleado()
        {
            List<dynamic> ListaCodigoEmpleado = new List<dynamic>();
            string QueryListaCodigoEmpleado = "select CodigoEmpleado, Nombre from tbl_Empleado";
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

        // Método para obtener la lista de códigos de granjas junto con el nombre de la granja
        public List<dynamic> MtdListaCodigoGranja()
        {
            List<dynamic> ListaCodigoGranja = new List<dynamic>();
            string QueryListaCodigoGranja = "select CodigoGranja, Nombre from tbl_Granjas";
            SqlCommand cmd = new SqlCommand(QueryListaCodigoGranja, conexion.mtdAbrirConexion());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ListaCodigoGranja.Add(new
                {
                    Value = reader["CodigoGranja"],
                    Text = $"{reader["CodigoGranja"]}-{reader["Nombre"]}"
                });
            }

            conexion.mtdCerrarConexion();
            return ListaCodigoGranja;
        }

        //--------------------------------------------------------------------------------------------------

        public DataTable mtdConsultarTablaEnvios()
        {
            DataTable dtEnvios = new DataTable();
            string QueryConsultarEnvios = "select e.CodigoEnvio, v.CodigoVentas, c.Nombre as Cliente, em.Nombre as Empleado, g.Nombre as Granja, e.Fecha, e.Direccion, e.Estado from tbl_Envio e inner join tbl_Ventas v on e.CodigoVentas = v.CodigoVentas inner join tbl_Clientes c on v.CodigoCliente = c.CodigoCliente inner join tbl_Empleado em on e.CodigoEmpleado = em.CodigoEmpleado inner join tbl_Granjas g on e.CodigoGranja = g.CodigoGranja;\r\n";
            SqlDataAdapter da = new SqlDataAdapter(QueryConsultarEnvios, conexion.mtdAbrirConexion());
            da.Fill(dtEnvios);
            conexion.mtdCerrarConexion();
            return dtEnvios;
        }

        public void MtdAgregarEnvio(int CodigoVentas, int CodigoEmpleado, int CodigoGranja, DateTime Fecha, string Direccion, string TipoTransporte, string PlacaTransporte, string Estado, string UsuarioAuditoria, DateTime FechaAuditoria)
        {
            string QueryAgregarEnvio = "insert into tbl_Envio (CodigoVentas, CodigoEmpleado, CodigoGranja, Fecha, Direccion, TipoTransporte, PlacaTransporte, Estado, UsuarioAuditoria, FechaAuditoria) values (@CodigoVentas, @CodigoEmpleado, @CodigoGranja, @Fecha, @Direccion, @TipoTransporte, @PlacaTransporte, @Estado, @UsuarioAuditoria, @FechaAuditoria)";
            SqlCommand ConnAgregarEnvio = new SqlCommand(QueryAgregarEnvio, conexion.mtdAbrirConexion());
            ConnAgregarEnvio.Parameters.AddWithValue("@CodigoVentas", CodigoVentas);
            ConnAgregarEnvio.Parameters.AddWithValue("@CodigoEmpleado", CodigoEmpleado);
            ConnAgregarEnvio.Parameters.AddWithValue("@CodigoGranja", CodigoGranja);
            ConnAgregarEnvio.Parameters.AddWithValue("@Fecha", Fecha);
            ConnAgregarEnvio.Parameters.AddWithValue("@Direccion", Direccion);
            ConnAgregarEnvio.Parameters.AddWithValue("@TipoTransporte", TipoTransporte);
            ConnAgregarEnvio.Parameters.AddWithValue("@PlacaTransporte", PlacaTransporte);
            ConnAgregarEnvio.Parameters.AddWithValue("@Estado", Estado);
            ConnAgregarEnvio.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            ConnAgregarEnvio.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            ConnAgregarEnvio.ExecuteNonQuery();
            conexion.mtdCerrarConexion();
        }

        public void MtdEditarEnvio(int CodigoEnvio, int CodigoVentas, int CodigoEmpleado, int CodigoGranja, DateTime Fecha, string Direccion, string TipoTransporte, string PlacaTransporte, string Estado, string UsuarioAuditoria, DateTime FechaAuditoria)
        {
            string QueryEditarEnvio = "update tbl_Envio set CodigoVentas=@CodigoVentas, CodigoEmpleado=@CodigoEmpleado, CodigoGranja=@CodigoGranja, Fecha=@Fecha, Direccion=@Direccion, TipoTransporte=@TipoTransporte, PlacaTransporte=@PlacaTransporte, Estado=@Estado, UsuarioAuditoria=@UsuarioAuditoria, FechaAuditoria=@FechaAuditoria where CodigoEnvio=@CodigoEnvio";
            SqlCommand ConnEditarEnvio = new SqlCommand(QueryEditarEnvio, conexion.mtdAbrirConexion());
            ConnEditarEnvio.Parameters.AddWithValue("@CodigoEnvio", CodigoEnvio);
            ConnEditarEnvio.Parameters.AddWithValue("@CodigoVentas", CodigoVentas);
            ConnEditarEnvio.Parameters.AddWithValue("@CodigoEmpleado", CodigoEmpleado);
            ConnEditarEnvio.Parameters.AddWithValue("@CodigoGranja", CodigoGranja);
            ConnEditarEnvio.Parameters.AddWithValue("@Fecha", Fecha);
            ConnEditarEnvio.Parameters.AddWithValue("@Direccion", Direccion);
            ConnEditarEnvio.Parameters.AddWithValue("@TipoTransporte", TipoTransporte);
            ConnEditarEnvio.Parameters.AddWithValue("@PlacaTransporte", PlacaTransporte);
            ConnEditarEnvio.Parameters.AddWithValue("@Estado", Estado);
            ConnEditarEnvio.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            ConnEditarEnvio.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            ConnEditarEnvio.ExecuteNonQuery();
            conexion.mtdCerrarConexion();
        }

        public void MtdEliminarEnvio(int CodigoEnvio)
        {
            string QueryEliminarEnvio = "delete from tbl_Envio where CodigoEnvio=@CodigoEnvio";
            SqlCommand ConnEliminarEnvio = new SqlCommand(QueryEliminarEnvio, conexion.mtdAbrirConexion());
            ConnEliminarEnvio.Parameters.AddWithValue("@CodigoEnvio", CodigoEnvio);
            ConnEliminarEnvio.ExecuteNonQuery();
            conexion.mtdCerrarConexion();
        }
    }
}
