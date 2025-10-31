using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Net.Configuration;


namespace CapaDatos
{
    public class cdInventario
    {

        cdConexiones conexion = new cdConexiones();

        public List<dynamic> MtdListaCodigoGranja()
        {
            List<dynamic> ListaCodigoGranja = new List<dynamic>();
            string QueryListaCodigoGranja = "Select CodigoGranja, Nombre from tbl_Granjas";
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

        public List<dynamic> MtdListaCodigoInsumo()
        {
            List<dynamic> ListaCodigoGranja = new List<dynamic>();
            string QueryListaCodigoGranja = "Select CodigoGranja, Nombre from tbl_Granjas";
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





        public string MtdListaCodigoGranjaDgv(int CodigoGranja)
        {
            string resultado = string.Empty;
            string QueryListaCodigoGranja = "Select CodigoGranja, Nombre from tbl_Granjas where CodigoGranja=@CodigoGranja";
            SqlCommand cmd = new SqlCommand(QueryListaCodigoGranja, conexion.mtdAbrirConexion());
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

            conexion.mtdCerrarConexion();
            return resultado;
        }

        public DataTable mtdConsultarTablaInventario()
        {

            string queryConsultarInventario = "select * from tbl_Inventario";
            SqlDataAdapter sqlAdap = new SqlDataAdapter(queryConsultarInventario, conexion.mtdAbrirConexion());
            DataTable dtIventario = new DataTable();
            sqlAdap.Fill(dtIventario);

            return dtIventario;
            conexion.mtdCerrarConexion();
        }

        public void mtdAgregarInventario(int CodigoGranja, int CodigoInsumo, int CantidadDisponible, decimal CostoUnitario, decimal CostoTotal, DateTime FechaRegistro, string Estado, string UsuarioAuditoria, DateTime FechaAuditoria)
        {
            string queryAgregarInventario = "insert into tbl_Inventario (CodigoGranja, CodigoInsumo, CantidadDisponible, CostoUnitario, CostoTotal, FechaRegistro, Estado, UsuarioAuditoria, FechaAuditoria) values (@CodigoGranja, @CodigoInsumo, @CantidadDisponible, @CostoUnitario, @CostoTotal, @FechaRegistro, @Estado, @UsuarioAuditoria, @FechaAuditoria)";
            SqlCommand connAgregarInventario = new SqlCommand(queryAgregarInventario, conexion.mtdAbrirConexion());
            connAgregarInventario.Parameters.AddWithValue("@CodigoGranja", CodigoGranja);
            connAgregarInventario.Parameters.AddWithValue("@CodigoInsumo", CodigoInsumo);
            connAgregarInventario.Parameters.AddWithValue("@CantidadDisponible", CantidadDisponible);
            connAgregarInventario.Parameters.AddWithValue("@CostoUnitario", CostoUnitario);
            connAgregarInventario.Parameters.AddWithValue("@CostoTotal", CostoTotal);
            connAgregarInventario.Parameters.AddWithValue("@FechaRegistro", FechaRegistro);
            connAgregarInventario.Parameters.AddWithValue("@Estado", Estado);
            connAgregarInventario.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            connAgregarInventario.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);


            connAgregarInventario.ExecuteNonQuery();
            conexion.mtdCerrarConexion();
        }


        public void mtdActualizarInventario(int CodigoInventario, int CodigoGranja, int CodigoInsumo, int CantidadDisponible, decimal CostoUnitario, decimal CostoTotal, DateTime FechaRegistro, string Estado, string UsuarioAuditoria, DateTime FechaAuditoria)
        {
            string queryAgregarInventario = "update tbl_Inventario set CodigoGranja = @CodigoGranja, CodigoInsumo = @CodigoInsumo, CantidadDisponible = @CantidadDisponible, CostoUnitario = @CostoUnitario, CostoTotal = @CostoTotal, FechaRegistro = @FechaRegistro, Estado = @Estado, UsuarioAuditoria = @UsuarioAuditoria, FechaAuditoria = @FechaAuditoria where CodigoInventario = @CodigoInventario";
            SqlCommand connActualizarInventario = new SqlCommand(queryAgregarInventario, conexion.mtdAbrirConexion());
            connActualizarInventario.Parameters.AddWithValue("@CodigoInventario", CodigoInventario);
            connActualizarInventario.Parameters.AddWithValue("@CodigoGranja", CodigoGranja);
            connActualizarInventario.Parameters.AddWithValue("@CodigoInsumo", CodigoInsumo);
            connActualizarInventario.Parameters.AddWithValue("@CantidadDisponible", CantidadDisponible);
            connActualizarInventario.Parameters.AddWithValue("@CostoUnitario", CostoUnitario);
            connActualizarInventario.Parameters.AddWithValue("@CostoTotal", CostoTotal);
            connActualizarInventario.Parameters.AddWithValue("@FechaRegistro", FechaRegistro);
            connActualizarInventario.Parameters.AddWithValue("@Estado", Estado);
            connActualizarInventario.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            connActualizarInventario.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);


            connActualizarInventario.ExecuteNonQuery();
            conexion.mtdCerrarConexion();
        }




        public void mtdEliminarnInsumos(int CodigoInventario)
        {
            string queryEliminarInventario = "DELETE FROM tbl_Inventario WHERE CodigoInventario = @CodigoInventario";
            SqlCommand connEliminarInventario = new SqlCommand(queryEliminarInventario, conexion.mtdAbrirConexion());
            connEliminarInventario.Parameters.AddWithValue("@CodigoInventario", CodigoInventario);

            connEliminarInventario.ExecuteNonQuery();
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




    

