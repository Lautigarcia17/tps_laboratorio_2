using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario : Persona
    {
        #region Atributos
        private int legajo;
        private string correo;
        private string clave;
        private string perfil;
        #endregion

        #region Constructor
        public Usuario() 
        {
            this.legajo = 0;
            this.correo = string.Empty;
            this.clave = string.Empty;
            this.perfil = string.Empty;
        }
        public Usuario(string nombre, string apellido, int legajo, string correo, string clave, string perfil) : base(nombre,apellido)
        {
            this.legajo = legajo;
            this.correo = correo;
            this.clave = clave;
            this.perfil = perfil;
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// Utilizacion de la propiedad de Json para que el archivo reconozca a la propiedad por el nombre indicado entre parentesis
        /// </summary>
        [JsonPropertyName("legajo")]
        public int Legajo
        {
            get { return this.legajo; }
            set { this.legajo = value; }
        }
        [JsonPropertyName("correo")]
        public string Correo
        {
            get { return this.correo; }
            set { this.correo = value; }
        }
        [JsonPropertyName("clave")]
        public string Clave
        {
            get { return this.clave; }
            set { this.clave = value; }
        }
        [JsonPropertyName("perfil")]
        public string Perfil
        {
            get { return this.perfil; }
            set { this.perfil = value; }
        }
        #endregion

        #region Sobrecargas
        /// <summary>
        /// Sobreescritura del metodo equals donde se compara el correo y clave de un objeto
        /// con un string.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>True si son iguales , false si son distintos</returns>
        public override bool Equals(object? obj)
        {
            Boolean retorno = false;

            if (!(obj is null) && obj is string)
            {
                string compare = this.correo + " " + this.clave;
                retorno = compare == obj.ToString();
            }

            return retorno;
        }
        /// <summary>
        /// Sobreescritura del metodo GetHashCode , donde se vuelve a llamar a este mismo.
        /// LLama a la sobrecarga del metodo ==.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>Un codigo entero unico</returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion

        #region Metodos

        /// <summary>
        /// Muestra todos los campos de la clase  Vuelo, llamando ademas a la clase base para obtener nombre apellido
        /// </summary>
        /// <returns></returns>
        protected override string Mostrar()
        { 
            StringBuilder datos = new StringBuilder();

            datos.Append($"{base.Mostrar()} {this.legajo} {this.correo} {this.clave} {this.perfil}");
        
            return datos.ToString();
        }

        /// <summary>
        /// Sobrecarga del metodo ToString() donde se llama al metodo Mostrar y muestra
        /// todos los datos de la clase Usuario
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Mostrar();
        }


        /// <summary>
        /// Encuentra un usuario a traves de su corre y clave , recibe un correo , una clave
        /// y una lista de donde se va a comparar
        /// </summary>
        /// <param name="correo"></param>
        /// <param name="clave"></param>
        /// <param name="lista"></param>
        /// <returns>Objeto Usuario</returns>
        public Usuario EncontrarUsuario(string correo,string clave,List<Usuario> lista)
        {
            Usuario usuario = new Usuario();

            foreach (Usuario item in lista)
            {
                string datosUsuario = correo + " " + clave;
                if (item.Equals(datosUsuario))
                {
                    usuario = item;
                    break;
                }
            }

            return usuario;
        }

        /// <summary>
        /// Recibe un nombre y apellido y atraves de esos , recorre la lista y busca que usuario tienen ese nombre y apellido
        /// devolviendo su correo y clave en un string
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="lista"></param>
        /// <returns></returns>
        public string EncontrarCorreoClave(string nombre, string apellido, List<Usuario> lista)
        {
            string correoClave = "";
            foreach (Usuario item in lista)
            {
                if (item.nombre == nombre && item.apellido == apellido)
                {
                    correoClave += item.correo + " " + item.clave;
                    break;
                }
            }

            return correoClave;
        }
        #endregion
    }
}
