using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public delegate void PartidaCancelada(string mensaje);
    public class Partida : IEncontrarDato<List<Partida>,Partida>
    {
        private int idPartida;
        private Jugador jugadorUno;
        private Jugador jugadorDos;
        private string ganador;

        public Partida()
        {
            this.jugadorUno = new Jugador();
            this.jugadorDos = new Jugador();
            this.ganador = string.Empty;
            this.idPartida = 0;
        }
        public Partida(Jugador jugadorUno, Jugador jugadorDos, string ganador):this()
        {
            this.jugadorUno = jugadorUno;
            this.jugadorDos = jugadorDos;
            this.ganador = ganador;
            this.idPartida = GenerarIdAutoincremental();
        }
        public Partida(Jugador jugadorUno, Jugador jugadorDos) : this(jugadorUno,jugadorDos,"")
        {
        }

        public Jugador JugadorUno 
        { 
            get => this.jugadorUno; 
            set => this.jugadorUno = value; 
        }
        public Jugador JugadorDos 
        { 
            get => this.jugadorDos; 
            set => this.jugadorDos = value; 
        }
        public string Ganador 
        { 
            get => this.ganador; 
            set => this.ganador = value; 
        }
        public int IdPartida
        {
            get => this.idPartida;
            set => this.idPartida = value;
        }

        /// <summary>
        /// Muestra todos los atributos de la clase Partida, y lo retorna en un string
        /// </summary>
        /// <returns>string con todos los datos</returns>
        private string MostrarPartida()
        { 
            StringBuilder datos = new StringBuilder();

            datos.AppendLine($"Id : {this.idPartida}");
            datos.AppendLine($"Jugador uno : \n{this.jugadorUno}");
            datos.AppendLine($"Jugador dos : \n{this.jugadorDos}");
            datos.AppendLine($"ganador : {this.ganador}");
           
            return datos.ToString();
        }
        /// <summary>
        /// LLama al metodo MostrarPartida(), que contiene todos los atributos de la clase y lo retorna en formato string
        /// </summary>
        /// <returns>String de datos</returns>
        public override string ToString()
        {
            return this.MostrarPartida(); 
        }

        /// <summary>
        /// Lee el archivo .json de partidas, y lo guarda en una lista de tipo Partida, luego de eso busca cual es el idPartida mayor, siendo un atributo de partida
        /// cuando lo encuentra lo retorna en formato entero, en caso de que el archivo no exista, lanza una excepcion controlada, y inicializa el entero en 0, cuando se retorna
        /// se incrementa en uno el entero. Ya siendo el primer id 1 o apartir del ultimo id , uno mas.
        /// </summary>
        /// <returns>Ultimo/primer id incrementado en 1</returns>
        public static int GenerarIdAutoincremental()
        {
            int ultimoId;
            try
            {
                List<Partida> lista = Archivos<List<Partida>>.LecturaJson(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "partidas.json"));
                ultimoId = lista.Max(p => p.idPartida); // busca el ultimo / mayor  y lo trae

            }
            catch (Exception)
            {
                ultimoId = 0;
            }

            return ++ultimoId; // primero incremento , despues retorno
        }

        /// <summary>
        /// Compara una Partida y un id , la partida se compara por su atributo id,buscando la igualdad
        /// </summary>
        /// <param name="partida"></param>
        /// <param name="id"></param>
        /// <returns>True si son iguales , false si son distintos</returns>
        public static bool operator ==(Partida partida, int id)
        {
            return partida.idPartida == id;        
        }
        /// <summary>
        /// Compara una Partida y un id , la partida se compara por su atributo id,buscando la desigualdad
        /// </summary>
        /// <param name="partida"></param>
        /// <param name="id"></param>
        /// <returns>True si son distintos , false si son iguales</returns>
        public static bool operator !=(Partida partida, int id)
        {
            return !(partida == id);
        }
        /// <summary>
        /// Compara un tipo Partida con otro objeto Partida, llamando a la sobrecarga de operadores ==.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>True si son iguales, false si son distintos </returns>
        public override bool Equals(object? obj)
        {
            bool rtn = false;

            if (!(obj is null) && obj is int)
            {
                rtn = this == (int)obj;
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
        /// Busca en una lista de partidas, una Partida con el id mandado por parametros, cuando compara el atributo idPartida de la Partida con el id por parametro , retorna la Partida, 
        /// si no se encuentra retorna una Partida por default
        /// </summary>
        /// <param name="lista"></param>
        /// <param name="id"></param>
        /// <returns>Partida del id enviado o un default</returns>
        public Partida Encontrar(List<Partida> lista, int id)
        {
            Partida partida = new Partida();

            foreach (Partida item in lista)
            {
                if (item == id)
                {
                    partida = item;
                    break;
                }
            }
            return partida;
        }
    }
}
