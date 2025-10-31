using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class cdPago
    {
        cdConexiones conexion = new cdConexiones();

        // Consultar todos los pagos
        public DataTable mtdConsultarPagos()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_Pago", conexion.mtdAbrirConexion());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.mtdCerrarConexion();
            return dt;
        }

        // Agregar pago
        public void mtdAgregarPago(int CodigoEmpleado, int CodigoGranja, decimal SalarioBase, int HorasExtras, decimal Bonos, decimal Descuentos, decimal SalarioFinal, DateTime FechaPago, string Estado, string UsuarioAuditoria, DateTime FechaAuditoria)
        {
            SqlCommand cmd = new SqlCommand(@"INSERT INTO tbl_Pago 
            (CodigoEmpleado, CodigoGranja, SalarioBase, HorasExtras, Bonos, Descuentos, SalarioFinal, FechaPago, Estado, UsuarioAuditoria, FechaAuditoria)
            VALUES (@CodigoEmpleado, @CodigoGranja, @SalarioBase, @HorasExtras, @Bonos, @Descuentos, @SalarioFinal, @FechaPago, @Estado, @UsuarioAuditoria, @FechaAuditoria)", conexion.mtdAbrirConexion());

            cmd.Parameters.AddWithValue("@CodigoEmpleado", CodigoEmpleado);
            cmd.Parameters.AddWithValue("@CodigoGranja", CodigoGranja);
            cmd.Parameters.AddWithValue("@SalarioBase", SalarioBase);
            cmd.Parameters.AddWithValue("@HorasExtras", HorasExtras);
            cmd.Parameters.AddWithValue("@Bonos", Bonos);
            cmd.Parameters.AddWithValue("@Descuentos", Descuentos);
            cmd.Parameters.AddWithValue("@SalarioFinal", SalarioFinal);
            cmd.Parameters.AddWithValue("@FechaPago", FechaPago);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);

            cmd.ExecuteNonQuery();
            conexion.mtdCerrarConexion();
        }

        // Actualizar pago
        public void mtdActualizarPago(int CodigoPago, int CodigoEmpleado, int CodigoGranja, decimal SalarioBase, int HorasExtras, decimal Bonos, decimal Descuentos, decimal SalarioFinal, DateTime FechaPago, string Estado, string UsuarioAuditoria, DateTime FechaAuditoria)
        {
            SqlCommand cmd = new SqlCommand(@"UPDATE tbl_Pago SET 
            CodigoEmpleado=@CodigoEmpleado, CodigoGranja=@CodigoGranja, SalarioBase=@SalarioBase, HorasExtras=@HorasExtras, Bonos=@Bonos, Descuentos=@Descuentos, SalarioFinal=@SalarioFinal, FechaPago=@FechaPago, Estado=@Estado, UsuarioAuditoria=@UsuarioAuditoria, FechaAuditoria=@FechaAuditoria
            WHERE CodigoPago=@CodigoPago", conexion.mtdAbrirConexion());

            cmd.Parameters.AddWithValue("@CodigoPago", CodigoPago);
            cmd.Parameters.AddWithValue("@CodigoEmpleado", CodigoEmpleado);
            cmd.Parameters.AddWithValue("@CodigoGranja", CodigoGranja);
            cmd.Parameters.AddWithValue("@SalarioBase", SalarioBase);
            cmd.Parameters.AddWithValue("@HorasExtras", HorasExtras);
            cmd.Parameters.AddWithValue("@Bonos", Bonos);
            cmd.Parameters.AddWithValue("@Descuentos", Descuentos);
            cmd.Parameters.AddWithValue("@SalarioFinal", SalarioFinal);
            cmd.Parameters.AddWithValue("@FechaPago", FechaPago);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            cmd.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);

            cmd.ExecuteNonQuery();
            conexion.mtdCerrarConexion();
        }

        // Eliminar pago
        public void mtdEliminarPago(int CodigoPago)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM tbl_Pago WHERE CodigoPago=@CodigoPago", conexion.mtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoPago", CodigoPago);
            cmd.ExecuteNonQuery();
            conexion.mtdCerrarConexion();
        }
    }
}
