using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class cdGranja
    {
        cdConexiones cdConexiones = new cdConexiones();
        public DataTable MtdConsultarGranja()
        {
            string QueryConsultar = "Select * from tbl_Granjas";
            SqlDataAdapter sqlAdap = new SqlDataAdapter(QueryConsultar, cdConexiones.mtdAbrirConexion());
            DataTable dtGranja = new DataTable();
            sqlAdap.Fill(dtGranja);
            cdConexiones.mtdCerrarConexion();
            return dtGranja;
        }

        public void MtdAgregarGranja(string Nombre, string Direccion, int Telefono, string Correo, int CodigoPostal, string Estado, string UsuarioAuditoria, DateTime FechaAuditoria)
        {
            string QueryAgregarGranja = "insert into tbl_Granjas (Nombre, Dirección, Teléfono, Correo, CodigoPostal, Estado, UsuarioAuditoria, FechaAuditoria) values (@Nombre, @Dirección, @Teléfono, @Correo, @CodigoPostal, @Estado, @UsuarioAuditoria, @FechaAuditoria)";
            SqlCommand ConnAgregarGranja = new SqlCommand(QueryAgregarGranja, cdConexiones.mtdAbrirConexion());
            ConnAgregarGranja.Parameters.AddWithValue("@Nombre", Nombre);
            ConnAgregarGranja.Parameters.AddWithValue("@Dirección", Direccion);
            ConnAgregarGranja.Parameters.AddWithValue("@Teléfono", Telefono);
            ConnAgregarGranja.Parameters.AddWithValue("@Correo", Correo);
            ConnAgregarGranja.Parameters.AddWithValue("@CodigoPostal", CodigoPostal);
            ConnAgregarGranja.Parameters.AddWithValue("@Estado", Estado);
            ConnAgregarGranja.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            ConnAgregarGranja.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            ConnAgregarGranja.ExecuteNonQuery();
            cdConexiones.mtdCerrarConexion();
        }

        public void MtdActualizarGranja(int CodigoGranja, string Nombre, string Direccion, int Telefono, string Correo, int CodigoPostal, string Estado, string UsuarioAuditoria, DateTime FechaAuditoria)
        {
            string QueryActualizarGranja = "update tbl_Granjas set Nombre = @Nombre, Direccion = @Dirección, Teléfono = @Teléfono, Correo = @Correo, CodigoPostal = @CodigoPostal, Estado = @Estado, UsuarioAuditoria = @UsuarioAuditoria, FechaAuditoria = @FechaAuditoria where CodigoGranja = @CodigoGranja";
            SqlCommand ConnActualizarGranja = new SqlCommand(QueryActualizarGranja, cdConexiones.mtdAbrirConexion());
            ConnActualizarGranja.Parameters.AddWithValue("@CodigoGranja", CodigoGranja);
            ConnActualizarGranja.Parameters.AddWithValue("@Nombre", Nombre);
            ConnActualizarGranja.Parameters.AddWithValue("@Dirección", Direccion);
            ConnActualizarGranja.Parameters.AddWithValue("@Teléfono", Telefono);
            ConnActualizarGranja.Parameters.AddWithValue("@Correo", Correo);
            ConnActualizarGranja.Parameters.AddWithValue("@CodigoPostal", CodigoPostal);
            ConnActualizarGranja.Parameters.AddWithValue("@Estado", Estado);
            ConnActualizarGranja.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            ConnActualizarGranja.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            ConnActualizarGranja.ExecuteNonQuery();
            cdConexiones.mtdCerrarConexion();
        }

        public void MtdEliminarGranja(int CodigoGranja)
        {
            string QueryEliminarGranja = "delete from tbl_Granjas where CodigoGranja = @CodigoGranja";
            SqlCommand ConnEliminarGranja = new SqlCommand(QueryEliminarGranja, cdConexiones.mtdAbrirConexion());
            ConnEliminarGranja.Parameters.AddWithValue("@CodigoGranja", CodigoGranja);
            ConnEliminarGranja.ExecuteNonQuery();
            cdConexiones.mtdCerrarConexion();
        }
    }
}
