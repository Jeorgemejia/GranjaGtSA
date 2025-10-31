using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
    public class cdEmpleados
    {
        cdConexiones conexion = new cdConexiones();

        // Consultar todos los empleados
        public DataTable mtdConsultarTablaEmpleados()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_Empleado", conexion.mtdAbrirConexion());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.mtdCerrarConexion();
            return dt;
        }

        // Agregar empleado
        public void mtdAgregarEmpleado(int CodigoGranja, int CodigoUsuario, string Nombre, int Telefono, string Correo, string Cargo, decimal Salariobase, DateTime FechaIngreso, string Estado, string UsuarioAuditoria, DateTime FechaAuditoria)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO tbl_Empleado (CodigoGranja, CodigoUsuario, Nombre, Telefono, Correo, Cargo, Salariobase, FechaIngreso, Estado, UsuarioAuditoria, FechaAuditoria) VALUES (@CodigoGranja, @CodigoUsuario, @Nombre, @Telefono, @Correo, @Cargo, @Salariobase, @FechaIngreso, @Estado, @UsuarioAuditoria, @FechaAuditoria)", conexion.mtdAbrirConexion());

            cmd.Parameters.AddWithValue("@CodigoGranja", CodigoGranja);
            cmd.Parameters.AddWithValue("@CodigoUsuario", CodigoUsuario);
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@Telefono", Telefono);
            cmd.Parameters.AddWithValue("@Correo", Correo);
            cmd.Parameters.AddWithValue("@Cargo", Cargo);
            cmd.Parameters.AddWithValue("@Salariobase", Salariobase);
            cmd.Parameters.AddWithValue("@FechaIngreso", FechaIngreso);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);

            cmd.ExecuteNonQuery();
            conexion.mtdCerrarConexion();
        }

        // Actualizar empleado
        public void mtdActualizarEmpleado(int CodigoEmpleado, int CodigoGranja, int CodigoUsuario, string Nombre, int Telefono, string Correo, string Cargo, decimal Salariobase, DateTime FechaIngreso, string Estado, string UsuarioAuditoria, DateTime FechaAuditoria)
        {
            SqlCommand cmd = new SqlCommand("UPDATE tbl_Empleado SET CodigoGranja=@CodigoGranja, CodigoUsuario=@CodigoUsuario, Nombre=@Nombre, Telefono=@Telefono, Correo=@Correo, Cargo=@Cargo, Salariobase=@Salariobase, FechaIngreso=@FechaIngreso, Estado=@Estado, UsuarioAuditoria=@UsuarioAuditoria, FechaAuditoria=@FechaAuditoria WHERE CodigoEmpleado=@CodigoEmpleado", conexion.mtdAbrirConexion());

            cmd.Parameters.AddWithValue("@CodigoEmpleado", CodigoEmpleado);
            cmd.Parameters.AddWithValue("@CodigoGranja", CodigoGranja);
            cmd.Parameters.AddWithValue("@CodigoUsuario", CodigoUsuario);
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@Telefono", Telefono);
            cmd.Parameters.AddWithValue("@Correo", Correo);
            cmd.Parameters.AddWithValue("@Cargo", Cargo);
            cmd.Parameters.AddWithValue("@Salariobase", Salariobase);
            cmd.Parameters.AddWithValue("@FechaIngreso", FechaIngreso);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);

            cmd.ExecuteNonQuery();
            conexion.mtdCerrarConexion();
        }

        // Eliminar empleado
        public void mtdEliminarEmpleado(int CodigoEmpleado)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM tbl_Empleado WHERE CodigoEmpleado=@CodigoEmpleado", conexion.mtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoEmpleado", CodigoEmpleado);
            cmd.ExecuteNonQuery();
            conexion.mtdCerrarConexion();
        }

        // Consultar granjas para combo
        public DataTable mtdConsultarGranjas()
        {
            SqlCommand cmd = new SqlCommand("SELECT CodigoGranja, Nombre FROM tbl_Granjas", conexion.mtdAbrirConexion());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.mtdCerrarConexion();
            return dt;
        }

        // Consultar usuarios activos para combo
        public DataTable mtdConsultarUsuarios()
        {
            SqlCommand cmd = new SqlCommand("SELECT CodigoUsuario, Nombre FROM tbl_Usuarios WHERE Estado='Activo'", conexion.mtdAbrirConexion());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.mtdCerrarConexion();
            return dt;
        }
    }
}
