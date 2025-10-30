using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaDatos
{
    public class cdUsuarios
    {
        cdConexiones conexion = new cdConexiones();

        public DataTable mtdConsultarTablaUsuarios()
        {
            DataTable dt = new DataTable();
            try
            {
                string query = @"SELECT u.CodigoUsuario, r.Nombre AS Rol, u.Nombre, u.Clave, u.FechaRegistro, u.Estado
                                 FROM tbl_Usuarios u
                                 INNER JOIN tbl_Roles r ON u.CodigoRol = r.CodigoRol";
                SqlDataAdapter da = new SqlDataAdapter(query, conexion.mtdAbrirConexion());
                da.Fill(dt);
                conexion.mtdCerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar usuarios: " + ex.Message);
            }
            return dt;
        }

        public void mtdAgregarUsuario(int CodigoRol, string Nombre, string Clave, DateTime FechaRegistro, string Estado, string UsuarioAuditoria, DateTime FechaAuditoria)
        {
            try
            {
                string query = @"INSERT INTO tbl_Usuarios
                                 (CodigoRol, Nombre, Clave, FechaRegistro, Estado, UsuarioAuditoria, FechaAuditoria)
                                 VALUES (@CodigoRol, @Nombre, @Clave, @FechaRegistro, @Estado, @UsuarioAuditoria, @FechaAuditoria)";
                SqlCommand cmd = new SqlCommand(query, conexion.mtdAbrirConexion());
                cmd.Parameters.AddWithValue("@CodigoRol", CodigoRol);
                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                cmd.Parameters.AddWithValue("@Clave", Clave);
                cmd.Parameters.AddWithValue("@FechaRegistro", FechaRegistro);
                cmd.Parameters.AddWithValue("@Estado", Estado);
                cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
                cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
                cmd.ExecuteNonQuery();
                conexion.mtdCerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar usuario: " + ex.Message);
            }
        }

        public void mtdActualizarUsuario(int CodigoUsuario, int CodigoRol, string Nombre, string Clave, DateTime FechaRegistro, string Estado, string UsuarioAuditoria, DateTime FechaAuditoria)
        {
            try
            {
                string query = @"UPDATE tbl_Usuarios
                                 SET CodigoRol=@CodigoRol, Nombre=@Nombre, Clave=@Clave, FechaRegistro=@FechaRegistro,
                                     Estado=@Estado, UsuarioAuditoria=@UsuarioAuditoria, FechaAuditoria=@FechaAuditoria
                                 WHERE CodigoUsuario=@CodigoUsuario";
                SqlCommand cmd = new SqlCommand(query, conexion.mtdAbrirConexion());
                cmd.Parameters.AddWithValue("@CodigoUsuario", CodigoUsuario);
                cmd.Parameters.AddWithValue("@CodigoRol", CodigoRol);
                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                cmd.Parameters.AddWithValue("@Clave", Clave);
                cmd.Parameters.AddWithValue("@FechaRegistro", FechaRegistro);
                cmd.Parameters.AddWithValue("@Estado", Estado);
                cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
                cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
                cmd.ExecuteNonQuery();
                conexion.mtdCerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar usuario: " + ex.Message);
            }
        }

        public void mtdEliminarUsuario(int CodigoUsuario)
        {
            try
            {
                string query = "DELETE FROM tbl_Usuarios WHERE CodigoUsuario=@CodigoUsuario";
                SqlCommand cmd = new SqlCommand(query, conexion.mtdAbrirConexion());
                cmd.Parameters.AddWithValue("@CodigoUsuario", CodigoUsuario);
                cmd.ExecuteNonQuery();
                conexion.mtdCerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar usuario: " + ex.Message);
            }
        }

        public DataTable mtdConsultarRoles()
        {
            DataTable dt = new DataTable();
            try
            {
                string query = "SELECT CodigoRol, Nombre FROM tbl_Roles WHERE Estado='Activo'";
                SqlDataAdapter da = new SqlDataAdapter(query, conexion.mtdAbrirConexion());
                da.Fill(dt);
                conexion.mtdCerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar roles: " + ex.Message);
            }
            return dt;
        }
    }
}
