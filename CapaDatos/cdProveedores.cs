using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class cdProveedores
    {
        cdConexiones cdConexiones = new cdConexiones();
        string QueryConsultar = "Select * from tbl_Proveedores";

             public DataTable MtdConsultarProveedores()
             {
                string QueryConsultar = "Select * from tbl_Proveedores";
                SqlDataAdapter sqlAdap = new SqlDataAdapter(QueryConsultar, cdConexiones.mtdAbrirConexion());
                DataTable dtProveedores = new DataTable();
                sqlAdap.Fill(dtProveedores);
                cdConexiones.mtdCerrarConexion();
                return dtProveedores;

            cdConexiones.mtdCerrarConexion();
             }

        public void MtdAgregarProveedores(string Nombre, int Telefono, string Correo, string Direccion, string Estado, string UsuarioAuditoria, DateTime FechaAuditoria)
        {

            string QueryAgregarProveedores = "insert into tbl_Proveedores (Nombre, Telefono, Correo, Direccion, Estado, UsuarioAuditoria, FechaAuditoria) values (@Nombre, @Telefono, @Correo, @Direccion, @Estado, @UsuarioAuditoria, @FechaAuditoria)";
            SqlCommand ConnAgregarProveedores = new SqlCommand(QueryAgregarProveedores, cdConexiones.mtdAbrirConexion());
            ConnAgregarProveedores.Parameters.AddWithValue("@Nombre", Nombre);
            ConnAgregarProveedores.Parameters.AddWithValue("@Telefono", Telefono);
            ConnAgregarProveedores.Parameters.AddWithValue("@Correo", Correo);
            ConnAgregarProveedores.Parameters.AddWithValue("@Direccion", Direccion);
            ConnAgregarProveedores.Parameters.AddWithValue("@Estado", Estado);
            ConnAgregarProveedores.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            ConnAgregarProveedores.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            ConnAgregarProveedores.ExecuteNonQuery();
            cdConexiones.mtdCerrarConexion();
        }


        public void MtdActualizarProveedores(int CodigoProveedor, string Nombre, int Telefono, string Correo, string Direccion, string Estado, string UsuarioAuditoria, DateTime FechaAuditoria)
        {

            string QueryAgregarProveedores = "update tbl_Proveveedores set Nombre = @Nombre, Telefono = @Telefono, Correo = @Correo, Direccion = @Direccion, Estado = @Estado, UsuarioAuditoria = @UsuarioAuditoria, FechaAuditoria = @FechaAuditoria where CodigoProveedor = @CodigoProveedor";
            SqlCommand ConnActualizarProveedores = new SqlCommand(QueryAgregarProveedores, cdConexiones.mtdAbrirConexion());
            ConnActualizarProveedores.Parameters.AddWithValue("@CodigoProveedor", CodigoProveedor);
            ConnActualizarProveedores.Parameters.AddWithValue("@Nombre", Nombre);
            ConnActualizarProveedores.Parameters.AddWithValue("@Telefono", Telefono);
            ConnActualizarProveedores.Parameters.AddWithValue("@Correo", Correo);
            ConnActualizarProveedores.Parameters.AddWithValue("@Direccion", Direccion);
            ConnActualizarProveedores.Parameters.AddWithValue("@Estado", Estado);
            ConnActualizarProveedores.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            ConnActualizarProveedores.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            ConnActualizarProveedores.ExecuteNonQuery();
            cdConexiones.mtdCerrarConexion();
        }


        public void MtdEliminarProveedores(int CodigoProveedor)
        {

            string QueryEliminarProveedores = "Delete from tbl_Proveedores where CodigoProveedor = @CodigoProveedor";
            SqlCommand ConnEliminarProveedores = new SqlCommand(QueryEliminarProveedores, cdConexiones.mtdAbrirConexion());
            ConnEliminarProveedores.Parameters.AddWithValue("@CodigoProveedor", CodigoProveedor);

            ConnEliminarProveedores.ExecuteNonQuery();
            cdConexiones.mtdCerrarConexion();
        }

    }
}
