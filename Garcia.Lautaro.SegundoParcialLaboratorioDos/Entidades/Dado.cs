using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Dado
    {
        private int numeroDado;

        public Dado()
        {
            this.numeroDado = Dado.GenerarDadoRandom();
        }

        public int NumeroDado
        {
            get => this.numeroDado;
        }



        /// <summary>
        /// Compara dos dados por su atributo numeroDado,buscando la igualdad
        /// </summary>
        /// <param name="dado"></param>
        /// <param name="dadoDos"></param>
        /// <returns>True si son iguales , false distintos</returns>
        public static bool operator ==(Dado dado, Dado dadoDos)
        {
            return dado.numeroDado == dadoDos.numeroDado;
        }
        /// <summary>
        /// Compara dos dados por su atributo numeroDado,buscando la desigualdad
        /// </summary>
        /// <param name="dado"></param>
        /// <param name="dadoDos"></param>
        /// <returns>True si son distintos , false iguales</returns>
        public static bool operator !=(Dado dado, Dado dadoDos)
        {
            return !(dado == dadoDos);
        }
        /// <summary>
        /// Compara un tipo dado con otro objeto Dado, llamando a la sobrecarga de operadores ==.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>True si son iguales, false si son distintos </returns>
        public override bool Equals(object? obj)
        {
            bool rtn = false;
            if (obj is Dado)
            {
                rtn = this == (Dado)obj;
            }
            return rtn;
        }
        /// <summary>
        /// Sobreescritura del metodo GetHashCode , donde se vuelve a llamar a este mismo.
        /// </summary>
        /// <returns>Un codigo entero unico</returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    
        /// <summary>
        /// Genera un numero random entre 1 y 6
        /// </summary>
        /// <returns>numero random entero</returns>
        private static int GenerarDadoRandom()
        {
            Random numero = new Random();

            return numero.Next(1, 7);
        }
        public override string ToString()
        {
            return $"Dado : {this.numeroDado}";
        }
    }
}
