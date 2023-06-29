using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Entidades
{
    public class Aeronave
    {
        #region Atributos
        private int cantidadVuelos;
        private string matricula;
        private int cantidadAsientos;
        private int cantidadBanios;
        private bool ofreceInternet;
        private bool ofreceComida;
        private int capacidadBodega;
        #endregion

        #region Constructor
        public Aeronave()
        {
            this.cantidadVuelos = 0;
            this.matricula = string.Empty;
            this.cantidadAsientos = 0;
            this.cantidadBanios = 0;
            this.ofreceInternet = false;
            this.ofreceComida = false;
            this.capacidadBodega = 0;   
        }

        public Aeronave(int cantidadAsientos, int cantidadBanios, bool ofreceInternet, bool ofreceComida, int capacidadBodega):this()
        {
            this.cantidadVuelos = 0;
            this.cantidadAsientos = cantidadAsientos;
            this.cantidadBanios = cantidadBanios;
            this.ofreceInternet = ofreceInternet;
            this.ofreceComida = ofreceComida;
            this.capacidadBodega = capacidadBodega;
            this.matricula = Vuelo.GenerarCodigoAlfanumerico();
        }
        public Aeronave(int cantidadVuelos,int cantidadAsientos, int cantidadBanios, bool ofreceInternet, bool ofreceComida, int capacidadBodega) : this(cantidadAsientos,cantidadBanios,ofreceInternet,ofreceComida,capacidadBodega)
        {
            this.cantidadVuelos=cantidadVuelos;
        }
        #endregion

        #region Propiedades
        public int CantidadVuelos
        {
            get { return this.cantidadVuelos; }
            set { this.cantidadVuelos = value; }
        }
        public string Matricula
        {
            get { return this.matricula; }
            set { this.matricula = value; }
        }
        public int CantidadAsientos
        {
            get { return this.cantidadAsientos; }
            set { this.cantidadAsientos = value; }
        }

        public int CantidadBanios
        {
            get { return this.cantidadBanios; }
            set { this.cantidadBanios = value; }
        }
        public bool OfreceInternet
        {
            get { return this.ofreceInternet; }
            set { this.ofreceInternet = value; }
        }

        public bool OfreceComida
        {
            get { return this.ofreceComida; }
            set { this.ofreceComida = value; }
        }
        public int CapacidadBodega
        {
            get { return this.capacidadBodega; }
            set { this.capacidadBodega = value; }
        }
        #endregion

        #region Sobrecargas
        
        /// <summary>
        /// Compara dos clases del tipo avion , buscando la igualdad ,  por el campo matricula.
        /// </summary>
        /// <param name="avionUno"></param>
        /// <param name="avionDos"></param>
        /// <returns>True si son iguales , false distintos</returns>
        public static bool operator ==(Aeronave avionUno, Aeronave avionDos)
        { 
            return avionUno.matricula == avionDos.matricula;
        }
        /// <summary>
        /// Compara dos clases del tipo avion , buscando la desigualdad ,  por el campo matricula.
        /// </summary>
        /// <param name="avionUno"></param>
        /// <param name="avionDos"></param>
        /// <returns>True si son distintos , false iguales</returns>
        public static bool operator !=(Aeronave avionUno, Aeronave avionDos)
        {
            return !(avionUno == avionDos);
        }

        /// <summary>
        /// Compara una  clases del tipo avion  y una string , representando la matricula, buscando la igualdad.
        /// </summary>
        /// <param name="avionUno"></param>
        /// <param name="matricula"></param>
        /// <returns>True si son iguales , false distintos</returns>
        public static bool operator ==(Aeronave avionUno, string matricula)
        {
            return avionUno.matricula == matricula;
        }
        /// <summary>
        /// Compara una  clases del tipo avion  y una string , representando la matricula, buscando la desigualdad.
        /// </summary>
        /// <param name="avionUno"></param>
        /// <param name="matricula"></param>
        /// <returns>True si son distintos , false iguales</returns>
        public static bool operator !=(Aeronave avionUno, string matricula)
        {
            return !(avionUno == matricula);
        }

        /// <summary>
        /// Sobreescritura del metodo Equals , donde compara dos clases del tipo Aeronave.
        /// LLama a la sobrecarga del metodo ==.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>true si son iguales , false si son distintos</returns>
        public override bool Equals(object? obj)
        {
            Boolean retorno = false;

            if (!(obj is null) && obj is Aeronave)
            {
                retorno = this == (Aeronave)obj;
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
        /// todos los datos de la clase Aeronave
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Mostrar();
        }

        /// <summary>
        /// Sobrecarga del operador de conversion implicit donde recibe un objeto de la clase
        /// aeronave y lo muestra , llamando al ToString()
        /// </summary>
        /// <returns>String con los datos de la clase Aeronave</returns>
        public static implicit operator string(Aeronave avion)
        {
            return avion.ToString();
        }

        #endregion

        #region Sobrecargas lista de aeronaves

        /// <summary>
        /// Compara una lista de Aeronaves con un tipo Aeronave , para determinar si se encuentra
        /// dentro de la misma
        /// </summary>
        /// <param name="listaAviones"></param>
        /// <param name="avionUno"></param>
        /// <returns>True si esta , false si no esta</returns>
        public static bool operator ==(List<Aeronave> listaAviones, Aeronave avionUno)
        {
            bool esta = false;

            foreach (Aeronave item in listaAviones)
            {
                if (item == avionUno)
                {
                    esta = true;
                }
            }

            return esta;
        }

        /// <summary>
        /// Compara una lista de Aeronaves con un tipo Aeronave , para determinar si no se encuentra
        /// dentro de la misma
        /// </summary>
        /// <param name="listaAviones"></param>
        /// <param name="avionUno"></param>
        /// <returns>True si no esta , false si esta</returns>
        public static bool operator !=(List<Aeronave> listaAviones, Aeronave avionUno)
        {
            return !(listaAviones == avionUno);
        }

        /// <summary>
        /// Agrega un objeto del tipo Aeronave que recibe  a la lista de tipo Aeronave
        /// dentro de la misma se pregunta si no se encuentra ya ese objeto, y se agrega el mismo
        /// </summary>
        /// <param name="listaAviones"></param>
        /// <param name="avionUno"></param>
        /// <returns>lista de aeronaves actualizada, con el agregado del avion ingresado</returns>
        public static List<Aeronave> operator +(List<Aeronave> listaAviones, Aeronave avionUno)
        {
            
            if (listaAviones != avionUno)
            {
                listaAviones.Add(avionUno);
            }
            
            return listaAviones;
        }
        /// <summary>
        /// Elimina un objeto del tipo Aeronave que recibe  a la lista de tipo Aeronave
        /// dentro de la misma se pregunta si se encuentra ya ese objeto, y se elemina el mismo
        /// </summary>
        /// <param name="listaAviones"></param>
        /// <param name="avionUno"></param>
        /// <returns>lista de aeronaves actualizada, con el borrado del avion ingresados>
        public static List<Aeronave> operator -(List<Aeronave> listaAviones, Aeronave avionUno)
        {
           
            if (listaAviones == avionUno)
            {
                listaAviones.Remove(avionUno);
            }
            
            return listaAviones;
        }
        #endregion

        #region Metodos

        /// <summary>
        /// Muestra todos los campos de la clase Aeronave, ademas de cargar los booleanos con Si/No
        /// </summary>
        /// <returns></returns>
        private string Mostrar()
        {
            StringBuilder datos = new StringBuilder();


            datos.Append($"Matricula : {this.matricula}\nCantidad Asientos: {this.cantidadAsientos}\nCantidad Baños:{this.cantidadBanios}\nInternet: ");
          
            
            datos.Append(Aeronave.ObtenerEstadoDelServicio(this.ofreceInternet));

            datos.Append($"\nComida: ");
            datos.Append(Aeronave.ObtenerEstadoDelServicio(this.ofreceComida));


            datos.Append($"\nCapacidad bodega: {this.capacidadBodega}");

            return datos.ToString(); 
        }

        /// <summary>
        /// Encuentra una aeronave a traves de su matricula, se recibe una matricula y se busca
        /// en la lista de Aeronaves la igualdad en matricula , cuando se encuentra se devuelve 
        /// un objeto del tipo Aeronave
        /// </summary>
        /// <param name="listaAviones"></param>
        /// <param name="matricula"></param>
        /// <returns>Objeto Aeronave</returns>
        public Aeronave EncontrarAeronave(List<Aeronave> listaAviones, string matricula)
        {
            Aeronave avionEncontrada = new Aeronave();

            foreach (Aeronave item in listaAviones)
            {
                if (item == matricula)
                {
                    avionEncontrada = item;
                    break;
                }
            }
            return avionEncontrada;
        }

        /// <summary>
        /// Encuentra el indicie de una aeronave a traves del ingreso de otra aeronave
        /// se comparan y cuando se encuentra, se retorna el indice en lista.
        /// </summary>
        /// <param name="listaAviones"></param>
        /// <param name="avion"></param>
        /// <returns>Indice de la lista</returns>
        public int ObtenerIndiceAeronave(List<Aeronave> lista, Aeronave avion)
        {
            int indice = -1;

            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i] == avion)
                {
                    indice = i;
                    break;
                }
            }
            return indice;
        }

        /// <summary>
        /// Se recibe un Aeronave, se obtiene su indice en lista y se agrega ese nuevo aeronave, reemplazando al anterior
        /// para tener los nuevos datos cargados, y luego de esto se serializa en un archivo
        /// </summary>
        /// <param name="listaDeAviones"></param>
        /// <param name="avionActualizado"></param>
        public void ActualizarContadorDeVuelosPorAvion(List<Aeronave> listaDeAviones, Aeronave avionActualizado)
        {
            int indiceAvion = avionActualizado.ObtenerIndiceAeronave(listaDeAviones, avionActualizado);
            if (indiceAvion !=-1)
            {
                listaDeAviones[indiceAvion] = avionActualizado;
                Archivos.GuardarJsonAeronave(listaDeAviones);
            }
        }

        /// <summary>
        /// Se analiza los campos booleanos de la clase Aeronave y 
        /// si el booleano esta en True , devuelve un string
        /// </summary>
        /// <param name="servicio"></param>
        /// <returns>"Si" "No"</returns>
        public static string ObtenerEstadoDelServicio(bool servicio)
        {
            string ofreceServicio = "No";

            if (servicio == true)
            {
                ofreceServicio = "Si";
            }
            
            return ofreceServicio;
        }

        /// <summary>
        /// Recibe un Aeronave y descuenta el campo cantidad de vuelos de todas las aeronaves 
        /// que se encuentren en la lista de vuelos recibida
        /// </summary>
        /// <param name="listaDeVuelos"></param>
        /// <param name="aeronaveAActualizar"></param>
        public void DescontarContadorVuelosDelAeronave(List<Vuelo> listaDeVuelos,Aeronave aeronaveAActualizar) 
        {
            foreach (Vuelo item in listaDeVuelos)
            {
                if (item.Avion == aeronaveAActualizar)
                {
                    item.Avion.CantidadVuelos--;
                }
            }
        }
        /// <summary>
        /// Recibe un Aeronave y descuenta el campo cantidad de vuelos de todas las aeronaves 
        /// que se encuentren en la lista de vuelos recibida
        /// </summary>
        /// <param name="listaDeVuelos"></param>
        /// <param name="aeronaveAActualizar"></param>
        public void AcrementarContadorVuelosDelAeronave(List<Vuelo> listaDeVuelos, Aeronave aeronaveAActualizar) 
        {
            foreach (Vuelo item in listaDeVuelos)
            {
                if (item.Avion == aeronaveAActualizar)
                {
                    item.Avion.CantidadVuelos++;
                }
            }
        }

        /// <summary>
        /// Se recibe una lista de vuelos y se analiza todas las aeronaves de los vuelos, generando un diccionario
        /// donde se guarda el nombre del Aeronave y un acumulador de la duracion de vuelo de cada aeronave en 
        /// cada vuelo
        /// </summary>
        /// <param name="listaVuelos"></param>
        /// <returns>Diccionario de Aeronaves con sus horas de vuelo</returns>
        public Dictionary<string, TimeSpan> ContarHorasDeVueloPorAeronave(List<Vuelo> listaVuelos)
        {

            Dictionary<string, TimeSpan> avionHora = new Dictionary<string, TimeSpan>();

            foreach (Vuelo item in listaVuelos)
            {
                if (avionHora.ContainsKey(item.Avion.Matricula))
                {
                    avionHora[item.Avion.Matricula] += item.DuracionVuelo; // incremento el value
                }
                else
                {
                    avionHora.Add(item.Avion.Matricula, item.DuracionVuelo);
                }
            }
            return avionHora;
        }

        /// <summary>
        /// Ordena las horas de vuelo de un diccionario de manera descendente, convirtiendo el diccionario a lista, utilizando
        /// uno de los metodos de lista de ordenamiento y volviendo a reconvertir a diccionario
        /// </summary>
        /// <param name="listadoHorasPorAeronave"></param>
        /// <returns>Diccionario ordenado por hora descendentemenete</returns>
        public Dictionary<string, TimeSpan> OrdenarHorasDeVuelos(Dictionary<string, TimeSpan> listadoHorasPorAeronave)
        {
            List<KeyValuePair<string, TimeSpan>> listaOrdenada = listadoHorasPorAeronave.ToList(); // convertimos el dic a lista , para utilizar el sort
            listaOrdenada.Sort((x, y) => y.Value.CompareTo(x.Value)); // segun que llame al compare , va a ser descendiente o ascendente

            listadoHorasPorAeronave = listaOrdenada.ToDictionary(x => x.Key, x => x.Value); // reconvertimos al tipo dictionary

            return listadoHorasPorAeronave;
        }
        #endregion 

    }


}
