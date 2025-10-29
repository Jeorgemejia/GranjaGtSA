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
    public class cdInsumos
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

        public DataTable mtdConsultarTablaInsumos()
        {

            string queryConsultarInsumos = "select * from tbl_Insumos";
            SqlDataAdapter sqlAdap = new SqlDataAdapter(queryConsultarInsumos, conexion.mtdAbrirConexion());
            DataTable dtInsumos = new DataTable();
            sqlAdap.Fill(dtInsumos);

            return dtInsumos;
            conexion.mtdCerrarConexion();
        }

        public void mtdAgregarInsumos(int CodigoProveedor, string Nombre, string Tipo, decimal CostoUnitario, string UnidadMedida, decimal Peso, string Observacion, string Estado, string UsuarioAuditoria, DateTime FechaAuditoria)
        {
            string queryAgregarInsumos = "insert into tbl_Insumos (CodigoProveedor, Nombre, Tipo, CostoUnitario, UnidadMedida, Peso, Observacion, Estado, UsuarioAuditoria, FechaAuditoria) values (@CodigoProveedor, @Nombre, @Tipo, @CostoUnitario, @UnidadMedida, @Peso, @Observacion, @Estado, @UsuarioAuditoria, @FechaAuditoria)";
            SqlCommand connAgregarInsumos = new SqlCommand(queryAgregarInsumos, conexion.mtdAbrirConexion());
            connAgregarInsumos.Parameters.AddWithValue("@CodigoProveedor", CodigoProveedor);
            connAgregarInsumos.Parameters.AddWithValue("@Nombre", Nombre);
            connAgregarInsumos.Parameters.AddWithValue("@Tipo", Tipo);
            connAgregarInsumos.Parameters.AddWithValue("@CostoUnitario", CostoUnitario);
            connAgregarInsumos.Parameters.AddWithValue("@UnidadMedida", UnidadMedida);
            connAgregarInsumos.Parameters.AddWithValue("@Peso", Peso);
            connAgregarInsumos.Parameters.AddWithValue("@Observacion", Observacion);
            connAgregarInsumos.Parameters.AddWithValue("@Estado", Estado);
            connAgregarInsumos.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            connAgregarInsumos.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);


            connAgregarInsumos.ExecuteNonQuery();
            conexion.mtdCerrarConexion();
        }



        public void mtdActualizarInsumos(int CodigoInsumo, int CodigoProveedor, string Nombre, string Tipo, decimal CostoUnitario, string UnidadMedida, decimal Peso, string Observacion, string Estado, string UsuarioAuditoria, DateTime FechaAuditoria)
        {
            string queryActualizarnsumos = "update tbl_Insumos set Nombre = @Nombre, Tipo = @Tipo, CostoUnitario = @CostoUnitario, UnidadMedida = @UnidadMedida, Peso = @Peso, Observacion = @Observacion, Estado = @Estado, UsuarioAuditoria = @UsuarioAuditoria, FechaAuditoria = @FechaAuditoria where CodigoInsumo = @CodigoInsumo";
            SqlCommand connActualizarInsumos = new SqlCommand(queryActualizarnsumos, conexion.mtdAbrirConexion());
            connActualizarInsumos.Parameters.AddWithValue("@CodigoInsumo", CodigoInsumo);
            connActualizarInsumos.Parameters.AddWithValue("@CodigoProveedor", CodigoProveedor);
            connActualizarInsumos.Parameters.AddWithValue("@Nombre", Nombre);
            connActualizarInsumos.Parameters.AddWithValue("@Tipo", Tipo);
            connActualizarInsumos.Parameters.AddWithValue("@CostoUnitario", CostoUnitario);
            connActualizarInsumos.Parameters.AddWithValue("@UnidadMedida", UnidadMedida);
            connActualizarInsumos.Parameters.AddWithValue("@Peso", Peso);
            connActualizarInsumos.Parameters.AddWithValue("@Observacion", Observacion);
            connActualizarInsumos.Parameters.AddWithValue("@Estado", Estado);
            connActualizarInsumos.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            connActualizarInsumos.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);


            connActualizarInsumos.ExecuteNonQuery();
            conexion.mtdCerrarConexion();
        }

        public void mtdEliminarnInsumos(int CodigoInsumo)
        {
            string queryEliminarInsumos = "Delete tbl_Insumos where CodigoInsumo=@CodigoInsumo";
            SqlCommand connEliminarInsumos = new SqlCommand(queryEliminarInsumos, conexion.mtdAbrirConexion());
            connEliminarInsumos.Parameters.AddWithValue("@CodigoInsumo", CodigoInsumo);

            connEliminarInsumos.ExecuteNonQuery();
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




    

