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
    public class cdCultivos
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
            string QueryListaProductos = "Select CodigoGranja, Nombre from tbl_Cultivo where CodigoGranja=@CodigoGranja";
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

            string queryConsultarProductos = "select * from tbl_Cultivo";
            SqlDataAdapter sqlAdap = new SqlDataAdapter(queryConsultarProductos, cdConexiones.mtdAbrirConexion());
            DataTable dtProd = new DataTable();
            sqlAdap.Fill(dtProd);

            cdConexiones.mtdCerrarConexion();
            return dtProd;

        }

        public void MtdAgregarCultivo(int CodigoGranja, string TipoCultivo, DateTime FechaSiembra, DateTime FechaCosecha, decimal CantidadCosecha, decimal Precio, string Ubicacion, string Observacion, string Estado, string UsuarioAuditoria, DateTime FechaAuditoria)
        {
            string QueryAgregarCultivo = "insert into tbl_Cultivo (TipoCultivo, FechaSiembra, FechaCosecha, CantidadCosecha, Precio, Ubicacion, Observacion, Estado, UsuarioAuditoria, FechaAuditoria) values (@TipoCultivo, @FechaSiembra, @FechaCosecha, @CantidadCosecha, @Precio, @Ubicacion, @Observacion, @Estado, @UsuarioAuditoria, @FechaAuditoria)";
            SqlCommand ConnAgregarCultivos = new SqlCommand(QueryAgregarCultivo, cdConexiones.mtdAbrirConexion());
            ConnAgregarCultivos.Parameters.AddWithValue("@CodigoGranja", CodigoGranja);
            ConnAgregarCultivos.Parameters.AddWithValue("@TipoCultivo", TipoCultivo);
            ConnAgregarCultivos.Parameters.AddWithValue("@FechaSiembra", FechaSiembra);
            ConnAgregarCultivos.Parameters.AddWithValue("@FechaCosecha", FechaCosecha);
            ConnAgregarCultivos.Parameters.AddWithValue("@CantidadCosecha", CantidadCosecha);
            ConnAgregarCultivos.Parameters.AddWithValue("@Precio", Precio);
            ConnAgregarCultivos.Parameters.AddWithValue("@Ubicacion", Ubicacion);
            ConnAgregarCultivos.Parameters.AddWithValue("@Observacion", Observacion);
            ConnAgregarCultivos.Parameters.AddWithValue("@Estado", Estado);
            ConnAgregarCultivos.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            ConnAgregarCultivos.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            ConnAgregarCultivos.ExecuteNonQuery();
            cdConexiones.mtdCerrarConexion();
        }

        public void MtdActualizarCultivo(int CodigoCultivo, int CodigoGranja, string TipoCultivo, DateTime FechaSiembra, DateTime FechaCosecha, decimal CantidadCosecha, decimal Precio, string Ubicacion, string Observacion, string Estado, string UsuarioAuditoria, DateTime FechaAuditoria)
        {
            string QueryActualizarCultivo = "update tbl_Cultivo set CodigoGranja = @CodigoGranja, TipoCultivo = @TipoCultivo, FechaSiembra = @FechaSiembra, FechaCosecha = @FechaCosecha, CantidadCosecha = @CantidadCosecha, Precio = @Precio, Ubicacion = @Ubicacion, Observacion = @Observacion, Estado = @Estado, UsuarioAuditoria = @UsuarioAuditoria, FechaAuditoria = @FechaAuditoria where CodigoCultivo = @CodigoCultivo";
            SqlCommand ConnActualizarCultivo = new SqlCommand(QueryActualizarCultivo, cdConexiones.mtdAbrirConexion());
            ConnActualizarCultivo.Parameters.AddWithValue("@CodigoCultivo", CodigoCultivo);
            ConnActualizarCultivo.Parameters.AddWithValue("@CodigoGranja", CodigoGranja);
            ConnActualizarCultivo.Parameters.AddWithValue("@TipoCultivo", TipoCultivo);
            ConnActualizarCultivo.Parameters.AddWithValue("@FechaSiembra", FechaSiembra);
            ConnActualizarCultivo.Parameters.AddWithValue("@FechaCosecha", FechaCosecha);
            ConnActualizarCultivo.Parameters.AddWithValue("@CantidadCosecha", CantidadCosecha);
            ConnActualizarCultivo.Parameters.AddWithValue("@Precio", Precio);
            ConnActualizarCultivo.Parameters.AddWithValue("@Ubicacion", Ubicacion);
            ConnActualizarCultivo.Parameters.AddWithValue("@Observacion", Observacion);
            ConnActualizarCultivo.Parameters.AddWithValue("@Estado", Estado);
            ConnActualizarCultivo.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            ConnActualizarCultivo.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            ConnActualizarCultivo.ExecuteNonQuery();
            cdConexiones.mtdCerrarConexion();
        }

        //Eliminar producto
        public void MtdEliminarCultivo(int CodigoCultivo)
        {
            string QueryEliminarCultivo = "delete from tbl_Cultivo where CodigoCultivo = @CodigoCultivo";
            SqlCommand ConnEliminarCultivo = new SqlCommand(QueryEliminarCultivo, cdConexiones.mtdAbrirConexion());
            ConnEliminarCultivo.Parameters.AddWithValue("@CodigoCultivo", CodigoCultivo);
            ConnEliminarCultivo.ExecuteNonQuery();
            cdConexiones.mtdCerrarConexion();
        }

    }
}
