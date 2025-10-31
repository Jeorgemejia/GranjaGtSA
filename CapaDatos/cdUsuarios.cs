using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class cdUsuarios
    {
        cdConexiones conexion = new cdConexiones();

        // Consultar todos los usuarios
        public DataTable mtdConsultarUsuarios()
        {
            SqlCommand cmd = new SqlCommand("SELECT CodigoUsuario, CodigoRol, Nombre, Clave, FechaRegistro, Estado FROM tbl_Usuarios", conexion.mtdAbrirConexion());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.mtdCerrarConexion();
            return dt;
        }

        // Consultar roles para combo
        public DataTable mtdConsultarRoles()
        {
            SqlCommand cmd = new SqlCommand("SELECT CodigoRol, Nombre FROM tbl_Roles", conexion.mtdAbrirConexion());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.mtdCerrarConexion();
            return dt;
        }

        // Agregar usuario
        public void mtdAgregarUsuario(int CodigoRol, string Nombre, string Clave, DateTime FechaRegistro, string Estado)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO tbl_Usuarios (CodigoRol, Nombre, Clave, FechaRegistro, Estado, UsuarioAuditoria, FechaAuditoria) VALUES (@CodigoRol, @Nombre, @Clave, @FechaRegistro, @Estado, @UsuarioAuditoria, @FechaAuditoria)", conexion.mtdAbrirConexion());

            cmd.Parameters.AddWithValue("@CodigoRol", CodigoRol);
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@Clave", Clave);
            cmd.Parameters.AddWithValue("@FechaRegistro", FechaRegistro);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", "Sistema");
            cmd.Parameters.AddWithValue("@FechaAuditoria", DateTime.Now);

            cmd.ExecuteNonQuery();
            conexion.mtdCerrarConexion();
        }

        // Actualizar usuario
        public void mtdActualizarUsuario(int CodigoUsuario, int CodigoRol, string Nombre, string Clave, DateTime FechaRegistro, string Estado)
        {
            SqlCommand cmd = new SqlCommand("UPDATE tbl_Usuarios SET CodigoRol=@CodigoRol, Nombre=@Nombre, Clave=@Clave, FechaRegistro=@FechaRegistro, Estado=@Estado, UsuarioAuditoria=@UsuarioAuditoria, FechaAuditoria=@FechaAuditoria WHERE CodigoUsuario=@CodigoUsuario", conexion.mtdAbrirConexion());

            cmd.Parameters.AddWithValue("@CodigoUsuario", CodigoUsuario);
            cmd.Parameters.AddWithValue("@CodigoRol", CodigoRol);
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@Clave", Clave);
            cmd.Parameters.AddWithValue("@FechaRegistro", FechaRegistro);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", "Sistema");
            cmd.Parameters.AddWithValue("@FechaAuditoria", DateTime.Now);

            cmd.ExecuteNonQuery();
            conexion.mtdCerrarConexion();
        }

        // Eliminar usuario
        public void mtdEliminarUsuario(int CodigoUsuario)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM tbl_Usuarios WHERE CodigoUsuario=@CodigoUsuario", conexion.mtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoUsuario", CodigoUsuario);
            cmd.ExecuteNonQuery();
            conexion.mtdCerrarConexion();
        }
    }
}
