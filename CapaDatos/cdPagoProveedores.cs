using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace CapaDatos
{
    public class cdPagoProveedores
    {

        cdConexiones conexion = new cdConexiones();

        public List<dynamic> MtdListaCodigoProveedores()
        {
            List<dynamic> ListaCodigoProveedores = new List<dynamic>();
            string QueryListaCodigoProveedores = "Select CodigoProveedor, Nombre from tbl_Proveedores";
            SqlCommand cmd = new SqlCommand(QueryListaCodigoProveedores, conexion.mtdAbrirConexion());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ListaCodigoProveedores.Add(new
                {
                    Value = reader["CodigoProveedor"],
                    Text = $"{reader["CodigoProveedor"]}-{reader["Nombre"]}"
                });
            }

            conexion.mtdCerrarConexion();
            return ListaCodigoProveedores;
        }


        public string MtdListaProveedoresDgv(int CodigoProveedor)
        {
            string resultado = string.Empty;
            string QueryListaProveedores = "Select CodigoProveedor, Nombre from tbl_Proveedores where CodigoEmpleado=@CodigoEmpleado";
            SqlCommand cmd = new SqlCommand(QueryListaProveedores, conexion.mtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoProveedor", CodigoProveedor);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                string codigo = reader["CodigoProveedor"].ToString();
                string nombre = reader["Nombre"].ToString();
                resultado = $"{codigo} - {nombre}";
            }
            else
            {
                resultado = string.Empty;
            }

            conexion.mtdCerrarConexion();
            return resultado;
        }

        public DataTable mtdConsultarTablaPagoProveedores()
        {

            string queryConsultarPagoProveedor = "select * from tbl_PagoProveedor";
            SqlDataAdapter sqlAdap = new SqlDataAdapter(queryConsultarPagoProveedor, conexion.mtdAbrirConexion());
            DataTable dtInsumos = new DataTable();
            sqlAdap.Fill(dtInsumos);

            return dtInsumos;
            conexion.mtdCerrarConexion();
        }

        public void mtdAgregarPagoProveedor(int CodigoProveedor, DateTime FechaPago, decimal Monto, string Metodo, string Descripcion, string Estado, string UsuarioAuditoria, DateTime FechaAuditoria)
        {
            string queryAgregarPagoProveedor = "insert into tbl_PagoProveedor (CodigoProveedor, FechaPago, Monto, Metodo, Descripcion, Estado, UsuarioAuditoria, FechaAuditoria) values (@CodigoProveedor, @FechaPago, @Monto, @Metodo, @Descripcion, @Estado, @UsuarioAuditoria, @FechaAuditoria)";
            SqlCommand connAgregarPagoProveedor = new SqlCommand(queryAgregarPagoProveedor, conexion.mtdAbrirConexion());
            connAgregarPagoProveedor.Parameters.AddWithValue("@CodigoProveedor", CodigoProveedor);
            connAgregarPagoProveedor.Parameters.AddWithValue("@FechaPago", FechaPago);
            connAgregarPagoProveedor.Parameters.AddWithValue("@Monto", Monto);
            connAgregarPagoProveedor.Parameters.AddWithValue("@Metodo", Metodo);
            connAgregarPagoProveedor.Parameters.AddWithValue("@Descripcion", Descripcion);
            connAgregarPagoProveedor.Parameters.AddWithValue("@Estado", Estado);
            connAgregarPagoProveedor.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            connAgregarPagoProveedor.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);


            connAgregarPagoProveedor.ExecuteNonQuery();
            conexion.mtdCerrarConexion();
        }



        public void mtdActualizarPagoProveedor(int CodigoPago, int CodigoProveedor, DateTime FechaPago, decimal Monto, string Metodo, string Descripcion, string Estado, string UsuarioAuditoria, DateTime FechaAuditoria)
        {
            string queryActualizarPagoProveedor = "update tbl_PagoProveedor set CodigoProveedor = @CodigoProveedor, FechaPago = @FechaPago, Monto = @Monto, Metodo = @Metodo, Descripcion = @Descripcion, Estado = @Estado, Estado = @Estado, UsuarioAuditoria = @UsuarioAuditoria, FechaAuditoria = @FechaAuditoria where CodigoPago = @CodigoPago";
            SqlCommand connActualizarPagoProveedor = new SqlCommand(queryActualizarPagoProveedor, conexion.mtdAbrirConexion());
            connActualizarPagoProveedor.Parameters.AddWithValue("@CodigoPago", CodigoPago);
            connActualizarPagoProveedor.Parameters.AddWithValue("@CodigoProveedor", CodigoProveedor);
            connActualizarPagoProveedor.Parameters.AddWithValue("@FechaPago", FechaPago);
            connActualizarPagoProveedor.Parameters.AddWithValue("@Monto", Monto);
            connActualizarPagoProveedor.Parameters.AddWithValue("@Metodo", Metodo);
            connActualizarPagoProveedor.Parameters.AddWithValue("@Descripcion", Descripcion);
            connActualizarPagoProveedor.Parameters.AddWithValue("@Estado", Estado);
            connActualizarPagoProveedor.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            connActualizarPagoProveedor.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);


            connActualizarPagoProveedor.ExecuteNonQuery();
            conexion.mtdCerrarConexion();
        }

        public void mtdEliminarPagoProveedor(int CodigoPago)
        {
            string queryEliminarPagoProveedor = "Delete tbl_PagoProveedor where CodigoPago=@CodigoPago";
            SqlCommand connEliminarPagoProveedor = new SqlCommand(queryEliminarPagoProveedor, conexion.mtdAbrirConexion());
            connEliminarPagoProveedor.Parameters.AddWithValue("@CodigoPago", CodigoPago);

            connEliminarPagoProveedor.ExecuteNonQuery();
            conexion.mtdCerrarConexion();
        }

        //Obtener salario del empleado

        public decimal MtdSalarioPlanilla(int codigoEmpleado)
        {
            decimal salario=0;
            try
            {

                string queryobtenercategoria = "select Saladio from tbl_Empleados where CodigoEmpleado = @codigoEmpleado";
                SqlCommand DtCategoria = new SqlCommand(queryobtenercategoria, conexion.mtdAbrirConexion());
                {
                    DtCategoria.Parameters.AddWithValue("@codigoEmpleado", codigoEmpleado);
                    object resultado = DtCategoria.ExecuteScalar();
                    if (resultado != null)
                    {
                        salario = decimal.Parse(resultado.ToString());
                    }


                }



                conexion.mtdCerrarConexion();
            }
            catch (Exception ex)
            {

            }

            return salario;
        }


        //obtener salario empleado para mostrar en cbox
        public decimal ObtenerSalarioEmpleado(int codigoEmpleado)
        {
            decimal salario = 0;
            using (SqlConnection sqlConnection = conexion.mtdAbrirConexion())
            {
                using (SqlCommand sqlCommand = new SqlCommand("SELECT Saladio FROM tbl_Empleados WHERE CodigoEmpleado = @CodigoEmpleado", sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@CodigoEmpleado", codigoEmpleado);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    if (sqlDataReader.Read())
                    {
                        salario = sqlDataReader.GetDecimal(0);
                    }
                    sqlDataReader.Close();
                }
                conexion.mtdCerrarConexion();
            }
            return salario;
        }
    }
}




    

