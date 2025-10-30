using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class cdRoles
    {
        cdConexiones conexion = new cdConexiones();

        public DataTable mtdConsultarTablaRoles()
        {
            string query = "SELECT * FROM tbl_Roles";
            SqlDataAdapter sqlAdap = new SqlDataAdapter(query, conexion.mtdAbrirConexion());
            DataTable dtRoles = new DataTable();
            sqlAdap.Fill(dtRoles);
            conexion.mtdCerrarConexion();
            return dtRoles;
        }

        public void mtdAgregarRol(string Nombre, int FormConsul, int FormAdd, int FormEdi, int FormDel,
            int AccesoDashboard, int AccesoReportes, int AccesoConfiguracion, string Estado, string UsuarioAuditoria, DateTime FechaAuditoria)
        {
            string query = @"INSERT INTO tbl_Roles 
(Nombre, FormConsul, FormAdd, FormEdi, FormDel, AccesoDashboard, AccesoReportes, AccesoConfiguracion, Estado, UsuarioAuditoria, FechaAuditoria)
VALUES (@Nombre, @FormConsul, @FormAdd, @FormEdi, @FormDel, @AccesoDashboard, @AccesoReportes, @AccesoConfiguracion, @Estado, @UsuarioAuditoria, @FechaAuditoria)";
            SqlCommand cmd = new SqlCommand(query, conexion.mtdAbrirConexion());
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@FormConsul", FormConsul);
            cmd.Parameters.AddWithValue("@FormAdd", FormAdd);
            cmd.Parameters.AddWithValue("@FormEdi", FormEdi);
            cmd.Parameters.AddWithValue("@FormDel", FormDel);
            cmd.Parameters.AddWithValue("@AccesoDashboard", AccesoDashboard);
            cmd.Parameters.AddWithValue("@AccesoReportes", AccesoReportes);
            cmd.Parameters.AddWithValue("@AccesoConfiguracion", AccesoConfiguracion);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            cmd.ExecuteNonQuery();
            conexion.mtdCerrarConexion();
        }

        public void mtdActualizarRol(int CodigoRol, string Nombre, int FormConsul, int FormAdd, int FormEdi, int FormDel,
            int AccesoDashboard, int AccesoReportes, int AccesoConfiguracion, string Estado, string UsuarioAuditoria, DateTime FechaAuditoria)
        {
            string query = @"UPDATE tbl_Roles SET 
Nombre=@Nombre, FormConsul=@FormConsul, FormAdd=@FormAdd, FormEdi=@FormEdi, FormDel=@FormDel,
AccesoDashboard=@AccesoDashboard, AccesoReportes=@AccesoReportes, AccesoConfiguracion=@AccesoConfiguracion,
Estado=@Estado, UsuarioAuditoria=@UsuarioAuditoria, FechaAuditoria=@FechaAuditoria
WHERE CodigoRol=@CodigoRol";
            SqlCommand cmd = new SqlCommand(query, conexion.mtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoRol", CodigoRol);
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@FormConsul", FormConsul);
            cmd.Parameters.AddWithValue("@FormAdd", FormAdd);
            cmd.Parameters.AddWithValue("@FormEdi", FormEdi);
            cmd.Parameters.AddWithValue("@FormDel", FormDel);
            cmd.Parameters.AddWithValue("@AccesoDashboard", AccesoDashboard);
            cmd.Parameters.AddWithValue("@AccesoReportes", AccesoReportes);
            cmd.Parameters.AddWithValue("@AccesoConfiguracion", AccesoConfiguracion);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            cmd.ExecuteNonQuery();
            conexion.mtdCerrarConexion();
        }

        public void mtdEliminarRol(int CodigoRol)
        {
            string query = "DELETE FROM tbl_Roles WHERE CodigoRol=@CodigoRol";
            SqlCommand cmd = new SqlCommand(query, conexion.mtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoRol", CodigoRol);
            cmd.ExecuteNonQuery();
            conexion.mtdCerrarConexion();
        }
    }
}
