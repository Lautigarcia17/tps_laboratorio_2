using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador : IEncontrarDato<List<Jugador>,Jugador>
    {
        private int id;
        private string nombre;
        private string apellido;
        private Tabla tablaJugador;

        public Jugador()
        {
            this.id = 0;
            this.nombre = string.Empty;
            this.apellido = string.Empty;
            this.tablaJugador = new Tabla();
        }

        public Jugador(int id,string nombre, string apellido) : this()
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public int Id
        {
            get => this.id;
            set => this.id = value;

        }

        public string Nombre 
        { 
            get => this.nombre; 
            set => this.nombre = value; 
        }
        public string Apellido 
        { 
            get => this.apellido; 
            set => this.apellido = value; 
        }
        public string NombreCompleto
        {
            get => this.nombre+" "+ this.apellido;
        }

        public Tabla TablaJugador 
        { 
            get => this.tablaJugador;
            set => this.tablaJugador = value; 
        }

        /// <summary>
        /// Compara un Jugador y un id , el jugador se compara por su atributo id,buscando la igualdad
        /// </summary>
        /// <param name="jugadorUno"></param>
        /// <param name="id"></param>
        /// <returns>True si son iguales , false si son distintos</returns>
        public static bool operator ==(Jugador jugadorUno, int id)
        {
            return jugadorUno.id == id;
        }
        /// <summary>
        /// Compara un Jugador y un id , el jugador se compara por su atributo id,buscando la desigualdad
        /// </summary>
        /// <param name="jugadorUno"></param>
        /// <param name="id"></param>
        /// <returns>True si son distintos , false si son iguales</returns>
        public static bool operator !=(Jugador jugadorUno, int id)
        {
            return !(jugadorUno == id);
        }

        /// <summary>
        /// Compara dos tipo Jugador, los  tipo Jugador  se compara por su atributo id,buscando la igualdad
        /// </summary>
        /// <param name="jugadorUno"></param>
        /// <param name="jugadorDos"></param>
        /// <returns>True si son iguales , false si son distintos</returns>
        public static bool operator ==(Jugador jugadorUno, Jugador jugadorDos)
        {
            return jugadorUno.id == jugadorDos.id;
        }
        /// <summary>
        /// Compara dos tipo Jugador, los  tipo Jugador  se compara por su atributo id,buscando la desigualdad
        /// </summary>
        /// <param name="jugadorUno"></param>
        /// <param name="jugadorDos"></param>
        /// <returns>True si son distintos , false si son iguales</returns>
        public static bool operator !=(Jugador jugadorUno, Jugador jugadorDos)
        {
            return !(jugadorUno == jugadorDos);
        }

        /// <summary>
        /// Compara un tipo Jugador con otro objeto Jugador, llamando a la sobrecarga de operadores ==.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>True si son iguales, false si son distintos </returns>
        public override bool Equals(object? obj)
        {
            bool rtn = false;
            if (obj is Jugador)
            {
                rtn = this == (Jugador)obj;
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
        /// Muestra todos los atributos de la clase Jugador, y lo retorna en un string
        /// </summary>
        /// <returns>string con todos los datos</returns>
        private string MostrarJugador()
        { 
            StringBuilder datos = new StringBuilder();

            datos.AppendLine($"Nombre Completo : {this.nombre} {this.apellido}");
            datos.AppendLine($"Puntaje : {this.tablaJugador.SumaPuntaje}");
            datos.AppendLine($"\nTabla : \n{this.tablaJugador.ToString()}");
        
            return datos.ToString();
        }

        /// <summary>
        /// LLama al metodo MostrarJugador(), que contiene todos los atributos de la clase y lo retorna en formato string
        /// </summary>
        /// <returns>String de datos</returns>
        public override string ToString()
        {
            return this.MostrarJugador(); 
        }

        /// <summary>
        /// Busca en una lista de jugadores, un Jugador con el id mandado por parametros, cuando compara el atributo id del Jugador con el id por parametro , retorna el Jugador, 
        /// si no se encuentra retorna un Jugador por default
        /// </summary>
        /// <param name="lista"></param>
        /// <param name="id"></param>
        /// <returns>Jugador del id enviado o un default</returns>
        public  Jugador Encontrar(List<Jugador> lista, int id)
        {
            Jugador jugador = new Jugador();

            foreach (Jugador item in lista)
            {
                if (item == id)
                {
                    jugador = item;
                    break;
                }
            }

            return jugador;
        }
    }
}
