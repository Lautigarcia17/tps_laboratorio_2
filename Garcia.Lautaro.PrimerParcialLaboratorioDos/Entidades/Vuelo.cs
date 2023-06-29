using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vuelo
    {
        #region Atributos
        private string estadoVuelo;
        private string codigoVuelo;
        private string ciudadDePartida;
        private string ciudadDeDestino;
        private DateTime fechaVuelo;
        private Aeronave avion;
        private int cantidadAsientosPremium;
        private int cantidadAsientosTurista;
        private float costoTurista;
        private float costoPremium;
        private int pesoCargaValijas;
        private TimeSpan duracionVuelo;
        private List<Pasajero> pasajeros;
        private List<Pasajero> pasajerosTurista;
        private List<Pasajero> pasajerosPremium;
        #endregion

        #region Constructor
        public Vuelo() 
        {
            this.estadoVuelo = string.Empty;
            this.codigoVuelo = string.Empty;
            this.ciudadDeDestino = string.Empty;
            this.ciudadDePartida = string.Empty;
            this.fechaVuelo = new DateTime();
            this.avion = new Aeronave();
            this.cantidadAsientosPremium = 0;
            this.cantidadAsientosTurista = 0;
            this.costoTurista = 0;
            this.costoPremium = 0;
            this.pesoCargaValijas = 0;
            this.duracionVuelo = new TimeSpan();
            this.pasajeros = new List<Pasajero>();
            this.pasajerosTurista = new List<Pasajero>();
            this.pasajerosPremium = new List<Pasajero>();
        }
              
        public Vuelo(string estadoVuelo,string ciudadDePartida, string ciudadDeDestino,DateTime fechaVuelo ,Aeronave avion, int cantidadAsientosPremium, int cantidadAsientosTurista, float costoTurista, float costoPremium,TimeSpan duracionVuelo) : this()
        {
            this.estadoVuelo = estadoVuelo;
            this.codigoVuelo = GenerarCodigoAlfanumerico(); 
            this.ciudadDePartida = ciudadDePartida;
            this.ciudadDeDestino = ciudadDeDestino;
            this.FechaVuelo = fechaVuelo;
            this.avion = avion;
            this.cantidadAsientosPremium = cantidadAsientosPremium;
            this.cantidadAsientosTurista = cantidadAsientosTurista;
            this.costoTurista = costoTurista;
            this.costoPremium = costoPremium;
            this.duracionVuelo = duracionVuelo;
        }

        public Vuelo(string estadoVuelo,string ciudadDePartida, string ciudadDeDestino, DateTime fechaVuelo, Aeronave avion, int cantidadAsientosPremium, int cantidadAsientosTurista, float costoTurista, float costoPremium,TimeSpan duracionVuelo,int pesoCargaValija,List<Pasajero> listaPasajerosGeneral,List<Pasajero> listaPasajerosTurista, List<Pasajero> listaPasajerosPremium) 
            : this(estadoVuelo,ciudadDePartida, ciudadDeDestino, fechaVuelo, avion,cantidadAsientosPremium,cantidadAsientosTurista,costoTurista,costoPremium, duracionVuelo)
        {
            this.pasajeros = listaPasajerosGeneral;
            this.pasajerosTurista = listaPasajerosTurista;
            this.pasajerosPremium = listaPasajerosPremium;
            this.pesoCargaValijas = pesoCargaValija;
        }

        #endregion

        #region Propiedades
        public string EstadoVuelo
        {
            get { return this.estadoVuelo; }
            set { this.estadoVuelo = value; }
        }
        public string CodigoVuelo
        {
            get { return this.codigoVuelo; }
            set { this.codigoVuelo = value;}
        }
        public string CiudadPartida
        {
            get { return this.ciudadDePartida; }
            set { this.ciudadDePartida = value;}
        }
        public DateTime FechaVuelo 
        {
            get { return fechaVuelo; }
            set { fechaVuelo = value; } 
        }
        public string CiudadDeDestino
        {
            get { return this.ciudadDeDestino; }
            set { this.ciudadDeDestino = value; }
        }

        public Aeronave Avion
        {
            get { return this.avion; }
            set { this.avion = value; }
        }
        public int CantidadAsientosPremium
        {
            get { return this.cantidadAsientosPremium; }
            set { this.cantidadAsientosPremium = value; }
        }
        public int CantidadAsientosTurista
        {
            get { return this.cantidadAsientosTurista; }
            set { this.cantidadAsientosTurista = value; }
        }
        public float CostoTurista
        {
            get { return this.costoTurista; }
            set { this.costoTurista = value; }
        }
        public float CostoPremium
        {
            get { return this.costoPremium; }
            set { this.costoPremium = value; }
        }
        public TimeSpan DuracionVuelo
        {
            get { return this.duracionVuelo; }
            set { this.duracionVuelo = value; }
        }

        public int PesoCargaValijas
        {
            get { return this.pesoCargaValijas; }
            set { this.pesoCargaValijas = value; }
        }

        public List<Pasajero> Pasajeros
        {
            get { return this.pasajeros; }
            set { this.pasajeros = value; }
        }
        public List<Pasajero> PasajerosTurista
        {
            get { return this.pasajerosTurista; }
            set { this.pasajerosTurista = value; }
        }
        public List<Pasajero> PasajerosPremium
        {
            get { return this.pasajerosPremium; }
            set { this.pasajerosPremium = value; }
        }


        #endregion

        #region Sobrecargas
        /// <summary>
        /// Compara si una Clase vuelo tiene en su campo Pasajeros el pasajero que 
        /// se ingresa.
        /// </summary>
        /// <param name="vuelo"></param>
        /// <param name="pasajeroUno"></param>
        /// <returns>True si esta el pasajero , false  si no se encuentra</returns>
        public static bool operator ==(Vuelo vuelo, Pasajero pasajeroUno)
        {
            bool estaElPasajero = false;
            foreach (Pasajero item in vuelo.pasajeros)
            {
                if (item == pasajeroUno)
                {
                    estaElPasajero = true;
                    break;
                }
            }
            return estaElPasajero;
        }
        /// <summary>
        /// Compara si una Clase vuelo no tiene en su campo Pasajeros el pasajero que 
        /// se ingresa.
        /// </summary>
        /// <param name="vuelo"></param>
        /// <param name="pasajeroUno"></param>
        /// <returns>True si  no esta el pasajero , false  si  se encuentra</returns>
        public static bool operator !=(Vuelo vuelo, Pasajero pasajeroUno)
        {
            return !(vuelo == pasajeroUno);
        }

        /// <summary>
        /// Compara si una Clase vuelo esta en su campo codigoVuelo el mismo string que se ingresa
        /// </summary>
        /// <param name="vuelo"></param>
        /// <param name="codigoVuelo"></param>
        /// <returns>True si  esta el codigoDeVUelo , false  si  no se encuentra</returns>
        public static bool operator ==(Vuelo vuelo, string codigoVuelo)
        {
            bool estaElPasajero = false;
            
            if (vuelo.codigoVuelo == codigoVuelo)
            {
                estaElPasajero = true;
            }
           
            return estaElPasajero;
        }

        /// <summary>
        /// Compara el campo codigoVuelo de un Vuelo con el string ingresado , buscando la desigualdad
        /// </summary>
        /// <param name="vuelo"></param>
        /// <param name="codigoVuelo"></param>
        /// <returns>True si  no esta el codigoDeVUelo , false  si  se encuentra</returns>
        public static bool operator !=(Vuelo vuelo, string codigoVuelo)
        {
            return !(vuelo == codigoVuelo);
        }


        /// <summary>
        /// Agrega en la lista de pasajeros de un vuelo , el pasajero ingresado, primero validando que no se 
        /// encuentre ya ingresado
        /// </summary>
        /// <param name="vuelo"></param>
        /// <param name="pasajeroUno"></param>
        /// <returns>Objeto Vuelo con su campo actualizado</returns>
        public static Vuelo operator +(Vuelo vuelo, Pasajero pasajeroUno)
        {
            if (vuelo != pasajeroUno)
            {
                vuelo.pasajeros.Add(pasajeroUno);
            }

            return vuelo;
        }

        /// <summary>
        /// Borra de  la lista de pasajeros de un vuelo , el pasajero ingresado, primero validando que  se 
        /// encuentre ya ingresado
        /// </summary>
        /// <param name="vuelo"></param>
        /// <param name="pasajeroUno"></param>
        /// <returns>Objeto Vuelo con su campo actualizado</returns>
        public static Vuelo operator -(Vuelo vuelo, Pasajero pasajeroUno)
        {
            if (vuelo == pasajeroUno)
            {
                vuelo.pasajeros.Remove(pasajeroUno);
            }

            return vuelo;
        }
        /// <summary>
        /// Sobreescritura del metodo Equals , donde compara dos clases del tipo Vuelo.
        /// LLama a la sobrecarga del metodo == entre un vuelo y un string.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>true si son iguales , false si son distintos</returns>
        public override bool Equals(object? obj)
        {
            Boolean retorno = false;

            if (!(obj is null) && obj is Vuelo)
            {
                retorno = this == ((Vuelo)obj).codigoVuelo;
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
        /// <summary>
        /// Sobrecarga del metodo ToString() donde se llama al metodo Mostrar y muestra
        /// todos los datos de la clase Vuielo
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Mostrar();
        }

        /// <summary>
        /// Sobrecarga del operador de conversion implicit donde recibe un objeto de la clase
        /// vuelo y lo muestra , llamando al ToString()
        /// </summary>
        /// <returns>String con los datos de la clase Vuelo</returns>
        public static implicit operator string(Vuelo vuelo)
        {
            return vuelo.ToString();
        }

        #endregion

        #region Sobrecargas Lista de Vuelos

        /// <summary>
        /// Compara una lista de vuelos con un tipo vuelo, para determinar si se encuentra
        /// dentro de la misma
        /// </summary>
        /// <param name="listaVuelos"></param>
        /// <param name="vuelo"></param>
        /// <returns>True si esta , false si no esta</returns>
        public static bool operator ==(List<Vuelo> listaVuelos, Vuelo vuelo)
        {
            bool esta = false;
            foreach (Vuelo item in listaVuelos)
            {
                if (item == vuelo.CodigoVuelo)
                {
                    esta = true;
                    break;
                }
            }
            return esta;
        }
        /// <summary>
        /// Compara una lista de vuelos con un tipo vuelo, para determinar si no se encuentra
        /// dentro de la misma
        /// </summary>
        /// <param name="listaVuelos"></param>
        /// <param name="vuelo"></param>
        /// <returns>True si no esta , false si esta</returns>
        public static bool operator !=(List<Vuelo> listaVuelos, Vuelo vuelo)
        {
            return !(listaVuelos == vuelo);
        }

        /// <summary>
        /// Agrega un objeto del tipo Vuelo que recibe  a la lista de tipo Vuelo
        /// dentro de la misma se pregunta si no se encuentra ya ese objeto, y se agrega el mismo
        /// </summary>
        /// <param name="listaVuelos"></param>
        /// <param name="vueloUno"></param>
        /// <returns>lista de vuelos actualizada, con el agregado del vuelo ingresado</returns>
        public static List<Vuelo> operator +(List<Vuelo> listaVuelos, Vuelo vueloUno)
        {

            if (listaVuelos != vueloUno)
            {
                listaVuelos.Add(vueloUno);
            }

            return listaVuelos;
        }

        /// <summary>
        /// Elimina un objeto del tipo Vuelo que recibe  a la lista de tipo Vuelo
        /// dentro de la misma se pregunta si se encuentra ya ese objeto, y se elemina el mismo
        /// </summary>
        /// <param name="listaVuelos"></param>
        /// <param name="vueloUno"></param>
        /// <returns>lista de vuelo actualizada, con el borrado del vuelo ingresados>
        public static List<Vuelo> operator -(List<Vuelo> listaVuelos, Vuelo vueloUno)
        {
            if (listaVuelos == vueloUno)
            {
                listaVuelos.Remove(vueloUno);
            }

            return listaVuelos;
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Muestra todos los campos de la clase Vuelo, mostrando tambien todos los pasajeros y su aeronave correspondiente
        /// </summary>
        /// <returns></returns>
        private string Mostrar()
        {
            StringBuilder datos = new StringBuilder();

            datos.Append($"{this.codigoVuelo} {this.ciudadDePartida} {this.ciudadDeDestino} {this.FechaVuelo.ToString("d / MMMM/ yyyy / HH:mm")} {this.avion.ToString()} ");
            datos.AppendLine($"{this.cantidadAsientosPremium} {this.cantidadAsientosTurista} {this.costoTurista} {this.costoPremium} {this.duracionVuelo.ToString("hh\\:mm")}");
            datos.Append($"{this.MostrarPasajeros()}");

            return datos.ToString();
        }

        /// <summary>
        /// Carga un stringBuilder con todos los pasajeros de un vuelo
        /// </summary>
        /// <returns>String representando una lista de pasajeros de vuelo</returns>
        public string MostrarPasajeros()
        {
            StringBuilder datos = new StringBuilder();
            foreach (Pasajero item in this.pasajeros)
            {
                datos.AppendLine(item.ToString());
            }

            return datos.ToString();
        }

        /// <summary>
        /// Genera un codigo alfanumerico de todas las letras y numeros
        /// </summary>
        /// <returns>Codigo alfanumerico</returns>
        public static string GenerarCodigoAlfanumerico()
        {
            Random random = new Random();

            StringBuilder sb = new StringBuilder();
            string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            for (int j = 0; j < 8; j++)
            {
                int indice = random.Next(caracteres.Length);
                char caracter = caracteres[indice];
                sb.Append(caracter);
            }

            return sb.ToString();
        }

        /// <summary>
        /// Recibe un minimo y un maximo , y genera una hora en formato timeSpan
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns>Hora en formato timeSpan</returns>
        public static TimeSpan GenerarHora(int min,int max)
        {
            Random random = new Random();

            int hour = random.Next(min, max); // Genera un número aleatorio entre 0 y 23 para la hora
            int minute = random.Next(0, 60); // Genera un número aleatorio entre 0 y 59 para los minutos

            TimeSpan randomTimeSpan = new TimeSpan(hour, minute, 00); // Crea un objeto TimeSpan con los valores aleatorios

            return randomTimeSpan;
        }
        /// <summary>
        /// Suma de todos los pasajeros de la clase premium y turista el gasto que tuvieron
        /// aplicando el iva del 21 %
        /// </summary>
        /// <param name="vuelo"></param>
        /// <returns>La facturacion total de todos los pasajeros por vuelo ingresado</returns>
        public float SumarFacturacionPasajeros(Vuelo vuelo)
        {
            float facturacion = 0;
            float iva = 1.21f;

            foreach (Pasajero item in vuelo.PasajerosPremium)
            {
                facturacion += vuelo.CostoPremium * iva;
            }
            foreach (Pasajero item in vuelo.PasajerosTurista)
            {
                facturacion += vuelo.CostoTurista * iva;
            }

            return facturacion;
        }

        /// <summary>
        /// Suma  todas las ganancias de un vuelo
        /// </summary>
        /// <param name="listaVuelos"></param>
        /// <returns>Ganancias de un vuelo</returns>
        public float SumarGanancias(List<Vuelo> listaVuelos)
        {
            float gananciasTotales = 0;
            foreach (Vuelo item in listaVuelos)
            {
                gananciasTotales += item.SumarFacturacionPasajeros(item);
            }

            return gananciasTotales;
        }

        /// <summary>
        /// Suma las ganancias de un vuelo , segun sean de cabotaje o internacional
        /// Si el  booleano viene cargado con true se cargaran las de cabotaje, en cambio
        /// si viene en false se cargaran las internacionales
        /// </summary>
        /// <param name="listaVuelos"></param>
        /// <param name="esCabotaje"></param>
        /// <returns>Facturacion de internacional o cabotaje</returns>
        public float SumarGanancias(List<Vuelo> listaVuelos,bool esCabotaje)
        {
            float gananciasTotales = 0;
            foreach (Vuelo item in listaVuelos)
            {
                bool esInternacional = Validar.EsVueloInternacional(item.CiudadPartida);
                if ((esInternacional && !esCabotaje) || (!esInternacional && esCabotaje))
                {
                    gananciasTotales += item.SumarFacturacionPasajeros(item);
                }
            }

            return gananciasTotales;
        }

        /// <summary>
        /// Cuenta todos los pasajeros por destinos elegidos , utilizando un diccionario
        /// </summary>
        /// <param name="listaVuelos"></param>
        /// <returns>Retorna un diccionario con la ciudad destino y su cantidad de pasajeros</returns>
        public Dictionary<string, int> ContarDestinosElegidos(List<Vuelo> listaVuelos)
        {

            Dictionary<string, int> destinoMasPedido = new Dictionary<string, int>();

            foreach (Vuelo item in listaVuelos)
            {
                if (destinoMasPedido.ContainsKey(item.CiudadDeDestino))
                {
                    destinoMasPedido[item.CiudadDeDestino] += item.Pasajeros.Count; // incremento el value
                }
                else
                {
                    destinoMasPedido.Add(item.CiudadDeDestino, item.Pasajeros.Count);
                }
            }
            return destinoMasPedido;
        }

        /// <summary>
        /// LLama al contarDestinosElegidos para obtener la lista de destinos elegidos y de este obtiene
        /// el que tiene la mayor cantidad de pasajeros,  y retorna su nombre
        /// </summary>
        /// <param name="listaVuelos"></param>
        /// <returns>String que es el nombre del destino mas elegido</returns>
        public string BuscarDestinoMasElegido(List<Vuelo> listaVuelos)
        {
            Dictionary<string, int> contadorDestinos = this.ContarDestinosElegidos(listaVuelos);

            string destinoMasPedido = "";
            int maxPasajeros = 0;

            foreach (KeyValuePair<string, int> item in contadorDestinos)
            {
                if (item.Value > maxPasajeros)
                {
                    destinoMasPedido = item.Key;
                    maxPasajeros = item.Value;
                }
                else
                {
                    if (item.Value == maxPasajeros)
                    {
                        destinoMasPedido += $"\n{item.Key}";
                    }
                }
            }

            return destinoMasPedido;
        }


        /// <summary>
        /// Genera un diccionario con todos los destinos y la recaudacion que tuvo por cada destino
        /// retornando un diccionario con sus destinso y recaudaciones
        /// </summary>
        /// <param name="listaVuelos"></param>
        /// <returns>Diccionario con destinos y sus recaudaciones</returns>
        public Dictionary<string, float> GenerarFacturacionPorDestino(List<Vuelo> listaVuelos)
        {
            Dictionary<string, float> destinosPorFacturacion = new Dictionary<string, float>();
            float facturacion;

            foreach (Vuelo item in listaVuelos)
            {
                facturacion = 0;

                if (item.Pasajeros.Count > 0)
                {
                    facturacion += item.SumarFacturacionPasajeros(item);
                }

                if (destinosPorFacturacion.ContainsKey(item.CiudadDeDestino))
                {

                    destinosPorFacturacion[item.CiudadDeDestino] += facturacion; // incremento el value
                }
                else
                {
                    destinosPorFacturacion.Add(item.CiudadDeDestino, facturacion);
                }
            }
            destinosPorFacturacion = destinosPorFacturacion.OrderByDescending(item => item.Value).ToDictionary(item => item.Key, item => item.Value); ;

            return destinosPorFacturacion;
        }
        #endregion
    }
}
