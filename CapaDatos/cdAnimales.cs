using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class cdAnimales
    {
        cdConexiones cdConexiones = new cdConexiones();

        //Listar Granjas para ComboBox
        public List<dynamic> MtdListaCodigoGranja()
        {
            List<dynamic> ListaCodigoGranja = new List<dynamic>();
            string QueryListaCodigoGranja = "Select CodigoGranja, Nombre from tbl_Granjas";
            SqlCommand cmd = new SqlCommand(QueryListaCodigoGranja, cdConexiones.mtdAbrirConexion());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ListaCodigoGranja.Add(new
                {
                    Value = reader["CodigoGranja"],
                    Text = $"{reader["CodigoGranja"]}-{reader["Nombre"]}"
                });
            }

            cdConexiones.mtdCerrarConexion();
            return ListaCodigoGranja;
        }

        //Mostrar Informacion de la Granja en el DataGridView
        public string MtdListaGranjaDgv(int CodigoGranja)
        {
            string resultado = string.Empty;
            string QueryListaProductos = "Select CodigoGranja, Nombre from tbl_Animales where CodigoGranja=@CodigoGranja";
            SqlCommand cmd = new SqlCommand(QueryListaProductos, cdConexiones.mtdAbrirConexion());
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

            cdConexiones.mtdCerrarConexion();
            return resultado;
        }

        public DataTable mtdConsultarTablaAnimales()
        {

            string queryConsultarAnimales = "select * from tbl_Animales";
            SqlDataAdapter sqlAdap = new SqlDataAdapter(queryConsultarAnimales, cdConexiones.mtdAbrirConexion());
            DataTable dtProd = new DataTable();
            sqlAdap.Fill(dtProd);

            cdConexiones.mtdCerrarConexion();
            return dtProd;
        }

        public void MtdAgregarAnimal(int CodigoGranja, string TipoAnimal, string Raza, DateTime FechaNacimiento, decimal Precio, string Descripcion, string Estado, string UsuarioAuditoria, DateTime FechaAuditoria)
        {
            string QueryAgregarAnimal = "Insert into tbl_Animales (CodigoGranja, TipoAnimal, Raza, FechaNacimiento, Precio, Descripcion, Estado, UsuarioAuditoria, FechaAuditoria) values (@CodigoGranja, @TipoAnimal, @Raza, @FechaNacimiento, @Precio, @Descripcion, @Estado, @UsuarioAuditoria, @FechaAuditoria)";
            SqlCommand ConnAgregarAnimales = new SqlCommand(QueryAgregarAnimal, cdConexiones.mtdAbrirConexion());
            ConnAgregarAnimales.Parameters.AddWithValue("@CodigoGranja", CodigoGranja);
            ConnAgregarAnimales.Parameters.AddWithValue("@TipoAnimal", TipoAnimal);
            ConnAgregarAnimales.Parameters.AddWithValue("@Raza", Raza);
            ConnAgregarAnimales.Parameters.AddWithValue("@FechaNacimiento", FechaNacimiento);
            ConnAgregarAnimales.Parameters.AddWithValue("@Precio", Precio);
            ConnAgregarAnimales.Parameters.AddWithValue("@Descripcion", Descripcion);
            ConnAgregarAnimales.Parameters.AddWithValue("@Estado", Estado);
            ConnAgregarAnimales.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            ConnAgregarAnimales.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            ConnAgregarAnimales.ExecuteNonQuery();
            cdConexiones.mtdCerrarConexion();
        }

        //Actualizar producto existente
        public void MtdActualizarAnimal(int CodigoAnimal, int CodigoGranja, string TipoAnimal, string Raza, DateTime FechaNacimiento, decimal Precio, string Descripcion, string Estado, string UsuarioAuditoria, DateTime FechaAuditoria)
        {
            string QueryActualizarAnimal = "Update tbl_Animales set CodigoGranja=@CodigoGranja, TipoAnimal=@TipoAnimal, Raza=@Raza, FechaNacimiento=@FechaNacimiento, Precio=@Precio, Descripcion=@Descripcion, Estado=@Estado, UsuarioAuditoria=@UsuarioAuditoria, FechaAuditoria=@FechaAuditoria where CodigoAnimal=@CodigoAnimal";
            SqlCommand ConnActualizarAnimales = new SqlCommand(QueryActualizarAnimal, cdConexiones.mtdAbrirConexion());
            ConnActualizarAnimales.Parameters.AddWithValue("@CodigoAnimal", CodigoAnimal);
            ConnActualizarAnimales.Parameters.AddWithValue("@CodigoGranja", CodigoGranja);
            ConnActualizarAnimales.Parameters.AddWithValue("@TipoAnimal", TipoAnimal);
            ConnActualizarAnimales.Parameters.AddWithValue("@Raza", Raza);
            ConnActualizarAnimales.Parameters.AddWithValue("@FechaNacimiento", FechaNacimiento);
            ConnActualizarAnimales.Parameters.AddWithValue("@Precio", Precio);
            ConnActualizarAnimales.Parameters.AddWithValue("@Descripcion", Descripcion);
            ConnActualizarAnimales.Parameters.AddWithValue("@Estado", Estado);
            ConnActualizarAnimales.Parameters.AddWithValue("@UsuarioAuditoria", UsuarioAuditoria);
            ConnActualizarAnimales.Parameters.AddWithValue("@FechaAuditoria", FechaAuditoria);
            ConnActualizarAnimales.ExecuteNonQuery();
            cdConexiones.mtdCerrarConexion();
        }

        //Eliminar producto
        public void MtdEliminarAnimal(int CodigoAnimal)
        {
            string QueryEliminarAnimal = "Delete from tbl_Animales where CodigoAnimal=@CodigoAnimal";
            SqlCommand ConnEliminarAnimales = new SqlCommand(QueryEliminarAnimal, cdConexiones.mtdAbrirConexion());
            ConnEliminarAnimales.Parameters.AddWithValue("@CodigoAnimal", CodigoAnimal);
            ConnEliminarAnimales.ExecuteNonQuery();
            cdConexiones.mtdCerrarConexion();
        }
    }
}
