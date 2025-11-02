using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CapaSeguridad
{
    public class UserDao
    {
        private readonly cdConexiones conexion = new cdConexiones();

        public bool Login(string nombreUsuario, string clave)
        {
            
                using (SqlConnection conn = conexion.mtdAbrirConexion())
                {
                    string query = @"
                        SELECT u.CodigoUsuario, u.Nombre, u.Clave, u.Estado, r.Nombre AS RolNombre
                        FROM tbl_Usuarios u
                        INNER JOIN tbl_Roles r ON u.CodigoRol = r.CodigoRol
                        WHERE u.Nombre=@Nombre AND u.Clave=@Clave AND u.Estado='Activo'";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = nombreUsuario;
                        cmd.Parameters.Add("@Clave", SqlDbType.VarChar).Value = clave;

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                UserCache.CodigoUsuario = reader.GetInt32(reader.GetOrdinal("CodigoUsuario"));
                                UserCache.NombreUsuario = reader.GetString(reader.GetOrdinal("Nombre"));
                                UserCache.Contrasenia = clave;
                                UserCache.Estado = reader.GetString(reader.GetOrdinal("Estado"));
                                UserCache.Rol = reader.GetString(reader.GetOrdinal("RolNombre"));
                                return true;
                            }
                            else
                                return false;
                        }
                    }
                }
            }
           
        }
    }
