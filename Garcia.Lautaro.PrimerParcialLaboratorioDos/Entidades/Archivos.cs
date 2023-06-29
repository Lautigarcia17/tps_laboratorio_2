using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public class Archivos
    {
        #region Paths
        private static string pathPasajeros = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "LISTA_PASAJEROS.xml"); 
        private static string pathVuelos = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "LISTA_VUELOS.xml"); 
        private static string pathAeronaves = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "LISTA_AERONAVES.json"); 
        private static string pathUsuarios = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "MOCK_DATA.json");  
        private static string pathUsuario = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "usuario.log.json");
        #endregion

        #region Usuarios
        /// <summary>
        /// Deserealizacion  en formato json de un archivo que contiene objetos del tipo Usuario
        /// </summary>
        /// <returns>Una lista cargada de objetos Usuario</returns>
        public static List<Usuario> LeerJsonUsuarios()
        {
            List <Usuario> lista = new List<Usuario>();

            if (File.Exists(Archivos.pathUsuarios))
            {
                using (System.IO.StreamReader sr = new System.IO.StreamReader(Archivos.pathUsuarios))
                {
                    string json_str = sr.ReadToEnd();

                    lista = (List<Usuario>)System.Text.Json.JsonSerializer.Deserialize(json_str, typeof(List<Usuario>));
                }
            }
            return lista;
        }

        /// <summary>
        /// Serializa en formato json un objeto de la Clase Usuario y una fecha de cuando se inicio sesion
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="fecha"></param>
        public static void GuardarJsonUsuario(Usuario usuario,DateTime fecha)
        {

            System.Text.Json.JsonSerializerOptions opciones = new System.Text.Json.JsonSerializerOptions();
            opciones.WriteIndented = true;

            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(Archivos.pathUsuario))
            {
                string obj_json = System.Text.Json.JsonSerializer.Serialize(usuario, opciones);
                writer.Write($"{obj_json}\n{fecha.ToString("yyyy-MM-dd HH:mm:ss")}");
            }
        }

        #endregion

        #region Pasajeros
        /// <summary>
        /// Deserealizacion en formato xml de un archivo que contiene objetos del tipo Pasajero
        /// </summary>
        /// <returns>Una lista cargada de objetos Usuario</returns>
        public static List<Pasajero> LeerXmlPasajeros()
        {
            List<Pasajero> lista = new List<Pasajero>();

            if (File.Exists(Archivos.pathPasajeros))
            {
                using (XmlTextReader read = new XmlTextReader(Archivos.pathPasajeros))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(List<Pasajero>));
                    lista = (List<Pasajero>)ser.Deserialize(read);
                }
            }

            return lista;
        }
        /// <summary>
        /// Serializa en formato xml una lista de objetos de la clase Pasajero
        /// </summary>
        /// <param name="listaPasajeros"></param>
        public static void GuardarXmlPasajeros(List<Pasajero> listaPasajeros)
        {
            using (XmlTextWriter write = new XmlTextWriter(Archivos.pathPasajeros, Encoding.UTF8))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<Pasajero>));
                ser.Serialize(write, listaPasajeros);
            }
        }
        #endregion

        #region Vuelos
        /// <summary>
        /// Deserealizacion en formato xml de un archivo que contiene una lista de objetos de la clase Vuelo
        /// </summary>
        /// <returns>Una lista cargada de objetos Vuelo</returns>
        public static List<Vuelo> LeerDeXmlVuelos()
        {
            List<Vuelo> listaDeVuelos = new List<Vuelo>();
            if (File.Exists(Archivos.pathVuelos))
            {
                using (XmlTextReader read = new XmlTextReader(Archivos.pathVuelos))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(List<Vuelo>));
                    listaDeVuelos = (List<Vuelo>)ser.Deserialize(read);
                }
            }

            return listaDeVuelos;
        }

        /// <summary>
        /// Serializa en formato xml una lista de objetos de la clase Vuelo
        /// </summary>
        /// <param name="listaVuelos"></param>
        public static void GuardarXmlVuelos(List<Vuelo> listaVuelos)
        {
            using (XmlTextWriter write = new XmlTextWriter(Archivos.pathVuelos, Encoding.UTF8))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<Vuelo>));
                ser.Serialize(write, listaVuelos);
            }
        }
        #endregion

        #region Aeronaves
        /// <summary>
        /// Deserealizacion  en formato json de un archivo que contiene objetos del tipo Aeronave
        /// </summary>
        /// <returns>Una lista cargada de objetos Aeronave</returns>
        public static List<Aeronave> LeerJsonAeronave()
        {
            List<Aeronave> lista = new List<Aeronave>();


            if (File.Exists(Archivos.pathAeronaves))
            {
                using (System.IO.StreamReader sr = new System.IO.StreamReader(Archivos.pathAeronaves))
                {
                    string json_str = sr.ReadToEnd();

                    lista = (List<Aeronave>)System.Text.Json.JsonSerializer.Deserialize(json_str, typeof(List<Aeronave>));
                }
            }
            return lista;
        }
        /// <summary>
        /// Serializa en formato json una lista de objetos de la clase Aeronave
        /// </summary>
        /// <param name="listaAeronave"></param>
        public static void GuardarJsonAeronave(List<Aeronave> listaAeronave)
        {

            System.Text.Json.JsonSerializerOptions opciones = new System.Text.Json.JsonSerializerOptions();
            opciones.WriteIndented = true;

            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(Archivos.pathAeronaves))
            {
                string obj_json = System.Text.Json.JsonSerializer.Serialize(listaAeronave, opciones);
                writer.Write(obj_json);
            }
        }
        #endregion

    }
}