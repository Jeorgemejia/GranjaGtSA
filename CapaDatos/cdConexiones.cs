using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;



namespace CapaDatos
{
    public class cdConexiones
    {

        private string db_cadenaConexion = "Server=tcp:proyectofinaldb1.database.windows.net,1433;Initial Catalog=db_GranjaGtSA;Persist Security Info=False;User ID=usuario;Password=Proyectofinal1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";

        public SqlConnection db_conexion;

        public cdConexiones()
        {
            db_conexion = new SqlConnection(db_cadenaConexion);
        }

        public SqlConnection mtdAbrirConexion()
        {
        
            if (string.IsNullOrEmpty(db_conexion.ConnectionString))
            {
                // Si fue rechz, crea una NUEVA conexión
                db_conexion = new SqlConnection(db_cadenaConexion);
            }

            try
            {
               
                if (db_conexion.State == ConnectionState.Closed)
                {
                    db_conexion.Open();
                }
            }
            catch (Exception ex)
            {
                throw; 
            }

            return db_conexion;
        }

        
        public SqlConnection mtdCerrarConexion()
        {
            try
            {
                if (db_conexion.State == ConnectionState.Open)
                {
                    db_conexion.Close();
                }
            }
            catch (Exception ex)
            {
            }
            return db_conexion;
        }




    }
}

