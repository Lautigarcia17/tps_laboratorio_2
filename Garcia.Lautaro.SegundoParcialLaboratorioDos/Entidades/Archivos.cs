using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Archivos <T>
    {
        /// <summary>
        /// Guarda un dato generico en un path especificado , esto haciendolo en formato json, si por algun motivo ocurre un error,  se lanza una excepcion
        /// </summary>
        /// <param name="lista"></param>
        /// <param name="path"></param>
        /// <exception cref="Exception"></exception>
        public static void GuardarJson(T lista, string path) 
        {

            try
            {
                System.Text.Json.JsonSerializerOptions opciones = new System.Text.Json.JsonSerializerOptions();
                opciones.WriteIndented = true;

                using (System.IO.StreamWriter writer = new System.IO.StreamWriter(path.ToString()))
                {
                    string obj_json = System.Text.Json.JsonSerializer.Serialize(lista,opciones);
                    writer.Write(obj_json);
                }
            }
            catch (Exception)
            {
                throw new Exception("Surgio un error en el guardado de datos");
            }
        }

        /// <summary>
        /// Lee los datos de un archivo .json especificado en el path,  en caso de que no lo encuentre lanza una excepcion de FileNotFoundException
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static T LecturaJson(string path)
        {
            T lista = default;
            try
            {
                if (File.Exists(path.ToString()))
                {
                    using (System.IO.StreamReader sr = new System.IO.StreamReader(path.ToString()))
                    {
                        string json_str = sr.ReadToEnd();

                        lista = System.Text.Json.JsonSerializer.Deserialize<T>(json_str);
                    }
                }
                else
                {
                    throw new FileNotFoundException("No se encontro el archivo en esa ruta");
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return lista;
        }


    }
}
