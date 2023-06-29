using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class JugadorDao
    {
        private static string cadena_conexion;
        private static SqlCommand comando;
        private static SqlConnection conexion;

        static JugadorDao()
        {
            SqlConnectionStringBuilder cadena = new SqlConnectionStringBuilder();
            cadena.DataSource = @".";
            cadena.IntegratedSecurity = true;
            cadena.InitialCatalog = "SegundoParcial_LaGenerala";

            JugadorDao.cadena_conexion = cadena.ConnectionString;

            JugadorDao.comando = new SqlCommand();
            JugadorDao.conexion = new SqlConnection(JugadorDao.cadena_conexion);
            JugadorDao.comando.Connection = JugadorDao.conexion;
            JugadorDao.comando.CommandType = System.Data.CommandType.Text;
        }

        /// <summary>
        /// Busca en la base de datos la tabla  jugadores y trae todos los jugadores, cargandolo en una lista de jugadores, si no se encuentra la base de datos, lanza una excepcion
        /// </summary>
        /// <returns>Lista de jugadores con los datos cargados</returns>
        /// <exception cref="Exception"></exception>
        public static List<Jugador> LeerJugador()
        {
            List<Jugador> lista = new List<Jugador>();

            try
            {
                JugadorDao.conexion.Open();
                JugadorDao.comando.CommandText = "SELECT * FROM jugadores";

                SqlDataReader lector = JugadorDao.comando.ExecuteReader();

                while (lector.Read())
                {
                    int id = Convert.ToInt32(lector["id"]);
                    string? nombre = lector.IsDBNull(lector.GetOrdinal("nombre")) ? string.Empty : lector["nombre"].ToString();
                    string? apellido = lector.IsDBNull(lector.GetOrdinal("apellido")) ? string.Empty : lector["apellido"].ToString();

                    if (nombre != null && apellido != null)
                    {
                        lista.Add(new Jugador(id, nombre, apellido));
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Se produjo un error al leer los datos.", ex);
            }
            finally
            {
                if (JugadorDao.conexion.State == System.Data.ConnectionState.Open)
                {
                    JugadorDao.conexion.Close();
                }
            }

            return lista;
        }

        /// <summary>
        /// El metodo sirve para aumentar la cantidad de partidas ganadas del jugador en la tabla.
        /// Guarda en la tabla jugadores de la base de datos, una modificacion del Jugador , vinculandolos por el id, 
        /// los datos a modificar son las partidasGanadas que se incrementa en 1 Y agrega la suma de puntos que tuvo el jugador, si 
        /// se produce un error en la base de datos lanza excepcion
        /// </summary>
        /// <param name="jugador"></param>
        /// <exception cref="Exception"></exception>
        public static void GuardarPartidaGanada(Jugador jugador)
        {
            try
            {
                JugadorDao.comando.Parameters.Clear();
                JugadorDao.conexion.Open();
                JugadorDao.comando.Parameters.AddWithValue("@id", jugador.Id);
                JugadorDao.comando.Parameters.AddWithValue("@puntajeTotal", jugador.TablaJugador.SumaPuntaje);

                JugadorDao.comando.CommandText = "UPDATE jugadores SET partidasGanadas += 1,puntajeTotal += @puntajeTotal WHERE id = @id";
                SqlDataReader lector = JugadorDao.comando.ExecuteReader();

            }
            catch (Exception ex)
            {
                throw new Exception("Se produjo un error al leer los datos.", ex);
            }
            finally
            {
                if (JugadorDao.conexion.State == System.Data.ConnectionState.Open)
                {
                    JugadorDao.conexion.Close();
                }
            }

        }

        /// <summary>
        /// El metodo sirve para aumentar la cantidad de partidas empatadas del jugador en la tabla.
        /// Guarda en la tabla jugadores de la base de datos, una modificacion del Jugador , vinculandolos por el id, 
        /// los datos a modificar son las partidasEmpatadas que se incrementa en 1 Y agrega la suma de puntos que tuvo el jugador, si 
        /// se produce un error en la base de datos lanza excepcion
        /// </summary>
        /// <param name="jugadorUno"></param>
        /// <exception cref="Exception"></exception>
        public static void GuardarPartidaEmpatada(Jugador jugadorUno)
        {
            try
            {
                JugadorDao.comando.Parameters.Clear();
                JugadorDao.conexion.Open();
                JugadorDao.comando.Parameters.AddWithValue("@id", jugadorUno.Id);
                JugadorDao.comando.Parameters.AddWithValue("@puntajeTotal", jugadorUno.TablaJugador.SumaPuntaje);

                JugadorDao.comando.CommandText = "UPDATE jugadores SET partidasEmpatadas += 1,puntajeTotal += @puntajeTotal WHERE id = @id";
                SqlDataReader lector = JugadorDao.comando.ExecuteReader();

            }
            catch (Exception ex)
            {
                throw new Exception("Se produjo un error al leer los datos.", ex);
            }
            finally
            {
                if (JugadorDao.conexion.State == System.Data.ConnectionState.Open)
                {
                    JugadorDao.conexion.Close();
                }
            }

        }

        /// <summary>
        /// El metodo sirve para aumentar la cantidad de partidas perdidas del jugador en la tabla.
        /// Guarda en la tabla jugadores de la base de datos, una modificacion del Jugador , vinculandolos por el id, 
        /// los datos a modificar son las partidasPerdidas que se incrementa en 1 Y agrega la suma de puntos que tuvo el jugador, si 
        /// se produce un error en la base de datos lanza excepcion
        /// </summary>
        /// <param name="jugadorUno"></param>
        /// <exception cref="Exception"></exception>
        public static void GuardarPartidaPerdida(Jugador jugadorUno)
        {
            try
            {
                JugadorDao.comando.Parameters.Clear();
                JugadorDao.conexion.Open();
                JugadorDao.comando.Parameters.AddWithValue("@id", jugadorUno.Id);
                JugadorDao.comando.Parameters.AddWithValue("@puntajeTotal", jugadorUno.TablaJugador.SumaPuntaje);

                JugadorDao.comando.CommandText = "UPDATE jugadores SET partidasPerdidas += 1,puntajeTotal += @puntajeTotal WHERE id = @id";
                SqlDataReader lector = JugadorDao.comando.ExecuteReader();

            }
            catch (Exception ex)
            {
                throw new Exception("Se produjo un error al leer los datos.", ex);
            }
            finally
            {
                if (JugadorDao.conexion.State == System.Data.ConnectionState.Open)
                {
                    JugadorDao.conexion.Close();
                }
            }
        }

        /// <summary>
        /// El metodo sirve leer la cantidad de partidas ganadas del jugador en la tabla. 
        ///Guardando en un diccionario el nombreCompleto del jugador y la cantidad de partidasGanadas
        ///retornando un diccionario  de todos los jugadores cargados con nombreCompleto,partidasGanadas
        /// </summary>
        /// <returns>Diccionario con datos de jugadores</returns>
        /// <exception cref="Exception"></exception>
        public static Dictionary<string,int> LeerCantidadVictoriasJugador()
        {
            Dictionary<string, int> rankingVictorias = new Dictionary<string, int>();

            try
            {
                JugadorDao.conexion.Open();
                JugadorDao.comando.CommandText = "SELECT nombre,apellido,partidasGanadas FROM jugadores WHERE partidasGanadas > 0";

                SqlDataReader lector = JugadorDao.comando.ExecuteReader();

                while (lector.Read())
                {
                    string? nombre = lector.IsDBNull(lector.GetOrdinal("nombre")) ? string.Empty : lector["nombre"].ToString();
                    string? apellido = lector.IsDBNull(lector.GetOrdinal("apellido")) ? string.Empty : lector["apellido"].ToString();
                    int partidasGanadas = Convert.ToInt32(lector["partidasGanadas"]);

                    if (nombre != null && apellido != null)
                    {
                        string nombreCompleto = nombre + " " + apellido;
                        rankingVictorias.Add(nombreCompleto, partidasGanadas);
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Se produjo un error al leer los datos.", ex);
            }
            finally
            {
                if (JugadorDao.conexion.State == System.Data.ConnectionState.Open)
                {
                    JugadorDao.conexion.Close();
                }
            }

            return rankingVictorias;
        }

        /// <summary>
        ///El metodo sirve leer la cantidad de partidas perdidas del jugador en la tabla. 
        ///Guardando en un diccionario el nombreCompleto del jugador y la cantidad de partidasPerdidas
        ///retornando un diccionario  de todos los jugadores cargados con nombreCompleto,partidasPerdidas
        /// </summary>
        /// <returns>Diccionario con datos de jugadores</returns>
        /// <exception cref="Exception"></exception>
        public static Dictionary<string, int> LeerCantidadDerrotasJugador()
        {
            Dictionary<string, int> rankingDerrotas = new Dictionary<string, int>();

            try
            {
                JugadorDao.conexion.Open();
                JugadorDao.comando.CommandText = "SELECT nombre,apellido,partidasPerdidas FROM jugadores WHERE partidasPerdidas > 0";

                SqlDataReader lector = JugadorDao.comando.ExecuteReader();

                while (lector.Read())
                {
                    string? nombre = lector.IsDBNull(lector.GetOrdinal("nombre")) ? string.Empty : lector["nombre"].ToString();
                    string? apellido = lector.IsDBNull(lector.GetOrdinal("apellido")) ? string.Empty : lector["apellido"].ToString();
                    int partidasPerdidas = Convert.ToInt32(lector["partidasPerdidas"]);

                    if (nombre != null && apellido != null)
                    {
                        string nombreCompleto = nombre + " " + apellido;
                        rankingDerrotas.Add(nombreCompleto, partidasPerdidas);
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Se produjo un error al leer los datos.", ex);
            }
            finally
            {
                if (JugadorDao.conexion.State == System.Data.ConnectionState.Open)
                {
                    JugadorDao.conexion.Close();
                }
            }

            return rankingDerrotas;
        }

        /// <summary>
        /// El metodo sirve leer la cantidad de partidas empatadas del jugador en la tabla. 
        ///Guardando en un diccionario el nombreCompleto del jugador y la cantidad de partidasEmpatadas
        ///retornando un diccionario  de todos los jugadores cargados con nombreCompleto,partidasEmpatadas
        /// </summary>
        /// <returns>Diccionario con datos de jugadores</returns>
        /// <exception cref="Exception"></exception>
        public static Dictionary<string, int> LeerCantidadEmpatesJugador()
        {
            Dictionary<string, int> rankingEmpates= new Dictionary<string, int>();

            try
            {
                JugadorDao.conexion.Open();
                JugadorDao.comando.CommandText = "SELECT nombre,apellido,partidasEmpatadas FROM jugadores WHERE partidasEmpatadas > 0";

                SqlDataReader lector = JugadorDao.comando.ExecuteReader();

                while (lector.Read())
                {
                    string? nombre = lector.IsDBNull(lector.GetOrdinal("nombre")) ? string.Empty : lector["nombre"].ToString();
                    string? apellido = lector.IsDBNull(lector.GetOrdinal("apellido")) ? string.Empty : lector["apellido"].ToString();
                    int partidasEmpatadas= Convert.ToInt32(lector["partidasEmpatadas"]);

                    if (nombre != null && apellido != null)
                    {
                        string nombreCompleto = nombre + " " + apellido;
                        rankingEmpates.Add(nombreCompleto, partidasEmpatadas);
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Se produjo un error al leer los datos.", ex);
            }
            finally
            {
                if (JugadorDao.conexion.State == System.Data.ConnectionState.Open)
                {
                    JugadorDao.conexion.Close();
                }
            }

            return rankingEmpates;
        }

        /// <summary>
        /// El metodo sirve leer el puntaje total de los jugadores en la tabla. 
        ///Guardando en un diccionario el nombreCompleto del jugador y el puntajeTotal
        ///retornando un diccionario  de todos los jugadores cargados con nombreCompleto,puntajeTotal
        /// </summary>
        /// <returns>Diccionario con datos de jugadores</returns>
        /// <exception cref="Exception"></exception>
        public static Dictionary<string, int> LeerPuntajeTotalJugador()
        {
            Dictionary<string, int> rankingPuntajesTotales = new Dictionary<string, int>();

            try
            {
                JugadorDao.conexion.Open();
                JugadorDao.comando.CommandText = "SELECT nombre,apellido,puntajeTotal FROM jugadores WHERE puntajeTotal > 0";

                SqlDataReader lector = JugadorDao.comando.ExecuteReader();

                while (lector.Read())
                {
                    string? nombre = lector.IsDBNull(lector.GetOrdinal("nombre")) ? string.Empty : lector["nombre"].ToString();
                    string? apellido = lector.IsDBNull(lector.GetOrdinal("apellido")) ? string.Empty : lector["apellido"].ToString();
                    int puntajeTotal = Convert.ToInt32(lector["puntajeTotal"]);

                    if (nombre != null && apellido != null)
                    {
                        string nombreCompleto = nombre + " " + apellido;
                        rankingPuntajesTotales.Add(nombreCompleto, puntajeTotal);
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Se produjo un error al leer los datos.", ex);
            }
            finally
            {
                if (JugadorDao.conexion.State == System.Data.ConnectionState.Open)
                {
                    JugadorDao.conexion.Close();
                }
            }

            return rankingPuntajesTotales;
        }

    }
}
