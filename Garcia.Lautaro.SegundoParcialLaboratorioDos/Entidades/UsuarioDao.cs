using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class UsuarioDao
    {
        private static string cadena_conexion;
        private static SqlCommand comando;
        private static SqlConnection conexion;

        static UsuarioDao()
        { 
            SqlConnectionStringBuilder cadena = new SqlConnectionStringBuilder();
            cadena.DataSource = @".";
            cadena.IntegratedSecurity = true;
            cadena.InitialCatalog = "SegundoParcial_LaGenerala";

            UsuarioDao.cadena_conexion = cadena.ConnectionString;
            UsuarioDao.comando = new SqlCommand();
            UsuarioDao.conexion = new SqlConnection(UsuarioDao.cadena_conexion);
            UsuarioDao.comando.Connection = UsuarioDao.conexion;
            UsuarioDao.comando.CommandType = System.Data.CommandType.Text;
        }

        /// <summary>
        /// Busca en la base de datos la tabla  usuarios y trae todos los usuarios, cargandolo en una lista de usuarios, si no se encuentra la base de datos, lanza una excepcion
        /// </summary>
        /// <returns>Lista de usuarios con los datos cargados</returns>
        /// <exception cref="Exception"></exception>
        public static List<Usuario> LeerUsuario()
        { 
            List<Usuario> lista = new List<Usuario>();

            try
            {
                UsuarioDao.conexion.Open();
                UsuarioDao.comando.CommandText = "SELECT * FROM usuarios";

                SqlDataReader lector = UsuarioDao.comando.ExecuteReader();

                while (lector.Read()) 
                {
                    int id = Convert.ToInt32(lector["id"]);
                    string? nombreUsuario = lector.IsDBNull(lector.GetOrdinal("nombreUsuario")) ? string.Empty : lector["nombreUsuario"].ToString();
                    string? contrasenia = lector.IsDBNull(lector.GetOrdinal("contrasenia")) ? string.Empty : lector["contrasenia"].ToString();

                    if (nombreUsuario !=null && contrasenia != null)
                    {
                        lista.Add(new Usuario(id,nombreUsuario,contrasenia));
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Se produjo un error al leer los datos.", ex);
            }
            finally
            {
                if (UsuarioDao.conexion.State == System.Data.ConnectionState.Open)
                {
                    UsuarioDao.conexion.Close();
                }
            }

            return lista;
        }


    }
}
