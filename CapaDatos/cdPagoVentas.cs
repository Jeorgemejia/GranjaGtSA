using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class cdPagoVentas
    {
        cdConexiones conexion = new cdConexiones();

        // Consultar todos los pagos de ventas
        public DataTable mtdConsultarPagoVentas()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_PagoVentas", conexion.mtdAbrirConexion());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.mtdCerrarConexion();
            return dt;
        }

        // Agregar pago de venta
        public void mtdAgregarPagoVenta(int codigoVentas, decimal monto, string tipoPago, int numReferencia, DateTime fechaPago, string estado, string usuarioAuditoria, DateTime fechaAuditoria)
        {
            SqlCommand cmd = new SqlCommand(@"INSERT INTO tbl_PagoVentas 
            (CodigoVentas, Monto, TipoPago, NumReferencia, FechaPago, Estado, UsuarioAuditoria, FechaAuditoria) 
            VALUES (@CodigoVentas, @Monto, @TipoPago, @NumReferencia, @FechaPago, @Estado, @UsuarioAuditoria, @FechaAuditoria)",
            conexion.mtdAbrirConexion());

            cmd.Parameters.AddWithValue("@CodigoVentas", codigoVentas);
            cmd.Parameters.AddWithValue("@Monto", monto);
            cmd.Parameters.AddWithValue("@TipoPago", tipoPago);
            cmd.Parameters.AddWithValue("@NumReferencia", numReferencia);
            cmd.Parameters.AddWithValue("@FechaPago", fechaPago);
            cmd.Parameters.AddWithValue("@Estado", estado);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", usuarioAuditoria);
            cmd.Parameters.AddWithValue("@FechaAuditoria", fechaAuditoria);

            cmd.ExecuteNonQuery();
            conexion.mtdCerrarConexion();
        }

        // Actualizar pago de venta
        public void mtdActualizarPagoVenta(int codigoPago, int codigoVentas, decimal monto, string tipoPago, int numReferencia, DateTime fechaPago, string estado, string usuarioAuditoria, DateTime fechaAuditoria)
        {
            SqlCommand cmd = new SqlCommand(@"UPDATE tbl_PagoVentas SET 
                CodigoVentas=@CodigoVentas, Monto=@Monto, TipoPago=@TipoPago, NumReferencia=@NumReferencia, 
                FechaPago=@FechaPago, Estado=@Estado, UsuarioAuditoria=@UsuarioAuditoria, FechaAuditoria=@FechaAuditoria
                WHERE CodigoPago=@CodigoPago",
                conexion.mtdAbrirConexion());

            cmd.Parameters.AddWithValue("@CodigoPago", codigoPago);
            cmd.Parameters.AddWithValue("@CodigoVentas", codigoVentas);
            cmd.Parameters.AddWithValue("@Monto", monto);
            cmd.Parameters.AddWithValue("@TipoPago", tipoPago);
            cmd.Parameters.AddWithValue("@NumReferencia", numReferencia);
            cmd.Parameters.AddWithValue("@FechaPago", fechaPago);
            cmd.Parameters.AddWithValue("@Estado", estado);
            cmd.Parameters.AddWithValue("@UsuarioAuditoria", usuarioAuditoria);
            cmd.Parameters.AddWithValue("@FechaAuditoria", fechaAuditoria);

            cmd.ExecuteNonQuery();
            conexion.mtdCerrarConexion();
        }

        // Eliminar pago de venta
        public void mtdEliminarPagoVenta(int codigoPago)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM tbl_PagoVentas WHERE CodigoPago=@CodigoPago", conexion.mtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoPago", codigoPago);
            cmd.ExecuteNonQuery();
            conexion.mtdCerrarConexion();
        }

        // Consultar ventas para combo
        public DataTable mtdConsultarVentas()
        {
            SqlCommand cmd = new SqlCommand("SELECT CodigoVentas, TotalVenta FROM tbl_Ventas", conexion.mtdAbrirConexion());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.mtdCerrarConexion();
            return dt;
        }
    }
}
