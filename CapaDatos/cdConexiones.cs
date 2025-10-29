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
        public SqlConnection db_conexion = new SqlConnection("Server=tcp:proyectofinaldb1.database.windows.net,1433;Initial Catalog=db_GranjaGtSA;Persist Security Info=False;User ID=usuario;Password=Proyectofinal1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30");

        public SqlConnection mtdAbrirConexion()
            { 
                if (db_conexion.State==ConnectionState.Closed)
                db_conexion.Open();
            return db_conexion; 
        
        }

        public SqlConnection mtdCerrarConexion()
        {
            if (db_conexion.State == ConnectionState.Open)
                db_conexion.Close();
            return db_conexion;

        }

    }
}
