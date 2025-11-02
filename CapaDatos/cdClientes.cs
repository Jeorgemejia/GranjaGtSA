using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class cdClientes
    {
        cdConexiones cdConexiones = new cdConexiones();

        public DataTable MtdConsultarClientes()
        {
            string QueryConsultar = "Select * from tbl_Clientes";
            SqlDataAdapter sqlAdap = new SqlDataAdapter(QueryConsultar, cdConexiones.mtdAbrirConexion());
            DataTable dtClientes = new DataTable();
            sqlAdap.Fill(dtClientes);
            cdConexiones.mtdCerrarConexion();
            return dtClientes;
        }

        public void MtdAgregarCliente(string Nombre, string Tipo, int Telefono, string Correo, string Direccion, string Estado, string UsuarioAuditoria, DateTime FechaAuditoria)
        {
            string QueryAgregarCliente = "insert into tbl_Clientes (Nombre, Tipo, Telefono, Correo, Dirección, Estado, UsuarioAuditoria, FechaAuditoria) values (@Nombre, @Tipo, @Telefono, @Correo, @Dirección, @Estado, @UsuarioAuditoria, @FechaAuditoria)";
            SqlCommand ConnAgregarCliente = new SqlCommand(QueryAgregarCliente, cdConexiones.mtdAbrirConexion());
            ConnAgregarCliente.Parameters.AddWithValue("@Nombre", Nombre);
            ConnAgregarCliente.Parameters.AddWithValue("@Tipo", Tipo);
            ConnAgregarCliente.Parameters.AddWithValue("@Telefono", Telefono);
            ConnAgregarCliente.Parameters.AddWithValue("@Correo", Correo);
            ConnAgregarCliente.Parameters.AddWithValue("@Dirección", Direccion);
            ConnAgregarCliente.Parameters.AddWithValue("@Estado", Estado);
            ConnAgregarCliente.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            ConnAgregarCliente.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            ConnAgregarCliente.ExecuteNonQuery();
            cdConexiones.mtdCerrarConexion();
        }

        public void MtdActualizarCliente(int CodigoCliente, string Nombre, string Tipo, int Telefono, string Correo, string Direccion, string Estado, string UsuarioAuditoria, DateTime FechaAuditoria)
        {
            string QueryActualizarCliente = "update tbl_Clientes set Nombre = @Nombre, Tipo = @Tipo, Telefono = @Telefono, Correo = @Correo, Dirección = @Dirección, Estado = @Estado, UsuarioAuditoria = @UsuarioAuditoria, FechaAuditoria = @FechaAuditoria where CodigoCliente = @CodigoCliente";
            SqlCommand ConnActualizarCliente = new SqlCommand(QueryActualizarCliente, cdConexiones.mtdAbrirConexion());
            ConnActualizarCliente.Parameters.AddWithValue("@CodigoCliente", CodigoCliente);
            ConnActualizarCliente.Parameters.AddWithValue("@Nombre", Nombre);
            ConnActualizarCliente.Parameters.AddWithValue("@Tipo", Tipo);
            ConnActualizarCliente.Parameters.AddWithValue("@Telefono", Telefono);
            ConnActualizarCliente.Parameters.AddWithValue("@Correo", Correo);
            ConnActualizarCliente.Parameters.AddWithValue("@Dirección", Direccion);
            ConnActualizarCliente.Parameters.AddWithValue("@Estado", Estado);
            ConnActualizarCliente.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            ConnActualizarCliente.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            ConnActualizarCliente.ExecuteNonQuery();
            cdConexiones.mtdCerrarConexion();

        }

        public void MtdEliminarCliente(int CodigoCliente)
        {
            string QueryEliminarCliente = "delete from tbl_Clientes where CodigoCliente = @CodigoCliente";
            SqlCommand ConnEliminarCliente = new SqlCommand(QueryEliminarCliente, cdConexiones.mtdAbrirConexion());
            ConnEliminarCliente.Parameters.AddWithValue("@CodigoCliente", CodigoCliente);
            ConnEliminarCliente.ExecuteNonQuery();
            cdConexiones.mtdCerrarConexion();
        }
    }
}
