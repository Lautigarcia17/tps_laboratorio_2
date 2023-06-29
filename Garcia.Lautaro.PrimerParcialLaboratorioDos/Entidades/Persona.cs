using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        #region Atributos
        protected string nombre;
        protected string apellido;
        #endregion

        #region Constructor
        public Persona() //necesario para la desearilizacion de json
        {
            this.nombre = string.Empty;
            this.apellido = string.Empty;   
        } 
        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        #endregion

        #region Propiedades
        public string Nombre 
        {
            get { return nombre; }
            set { nombre = value; } 
        }
        public string Apellido 
        { 
            get { return apellido; }
            set { apellido = value; }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Se declara el metodo Mostrar,  donde devuelve un nombre y apellido , y teniendo la posibilidad
        /// de sobreescribir en las clases derivadas
        /// </summary>
        /// <returns></returns>
        protected virtual string Mostrar()
        {
            return this.nombre + " " + this.apellido;
        }
        #endregion 
    }
}
