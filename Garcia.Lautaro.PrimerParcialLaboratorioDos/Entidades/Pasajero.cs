using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pasajero : Persona
    {
        #region Atributos
        private int cantidadVuelosComprados;
        private int dni;
        private int edad;
        private string equipaje;
        #endregion

        #region Constructor
        public Pasajero():base() // necesario para la desearilizacion de json
        {
            this.cantidadVuelosComprados = 0;
            this.dni = 0;
            this.edad = 0;
            this.equipaje = string.Empty;
        } 
        public Pasajero(int cantidadVuelosComprados,string nombre, string apellido, int dni, int edad, string equipaje) : base(nombre,apellido) 
        {
            this.cantidadVuelosComprados = cantidadVuelosComprados;
            this.dni = dni;
            this.edad = edad;
            this.equipaje = equipaje;
        }
        public Pasajero(string nombre, string apellido, int dni, int edad):this(0,nombre,apellido,dni,edad,"")
        {

        }
        #endregion

        #region Propiedades
        public int CantidadVuelosComprados
        {
            get { return this.cantidadVuelosComprados; }
            set { this.cantidadVuelosComprados = value; }
        }
        public int Dni
        {
            get { return this.dni; }
            set { this.dni = value; }
        }

        public int Edad
        {
            get { return this.edad; }
            set { this.edad = value; }
        }
        public string Equipaje
        {
            get { return this.equipaje; }
            set { this.equipaje = value; }
        }

        #endregion

        #region Sobrecargas
        /// <summary>
        /// Compara dos clases del tipo Pasajero , buscando la igualdad ,  por el campo dni.
        /// </summary>
        /// <param name="pasajeroUno"></param>
        /// <param name="pasajeroDos"></param>
        /// <returns>True si son iguales , false distintos</returns>
        public static bool operator ==(Pasajero pasajeroUno, Pasajero pasajeroDos)
        {
            return pasajeroUno.dni == pasajeroDos.dni;
        }
        /// <summary>
        /// Compara dos clases del tipo Pasajero , buscando la desigualdad ,  por el campo dni.
        /// </summary>
        /// <param name="pasajeroUno"></param>
        /// <param name="pasajeroDos"></param>
        /// <returns>True si son distintos , false iguales</returns>
        public static bool operator !=(Pasajero pasajeroUno, Pasajero pasajeroDos)
        {
            return !(pasajeroUno == pasajeroDos);
        }

        /// <summary>
        /// Compara una  clases del tipo Pasajero  y un entero, representando el dni, buscando la igualdad.
        /// </summary>
        /// <param name="pasajeroUno"></param>
        /// <param name="dni"></param>
        /// <returns>True si son iguales , false distintos</returns>
        public static bool operator ==(Pasajero pasajeroUno, int dni)
        {
            return pasajeroUno.dni == dni;
        }

        /// <summary>
        /// Compara una  clases del tipo Pasajero  y un entero, representando el dni, buscando la desigualdad.
        /// </summary>
        /// <param name="pasajeroUno"></param>
        /// <param name="dni"></param>
        /// <returns>True si son distintos , false iguales</returns>
        public static bool operator !=(Pasajero pasajeroUno, int dni)
        {
            return !(pasajeroUno == dni);
        }

        /// <summary>
        /// Sobreescritura del metodo Equals , donde compara dos clases del tipo Pasajero.
        /// LLama a la sobrecarga del metodo ==.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>true si son iguales , false si son distintos</returns>
        public override bool Equals(object? obj)
        {
            Boolean retorno = false;

            if (!(obj is null) && obj is Pasajero)
            {
                retorno = this == (Pasajero)obj;
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
        /// todos los datos de la clase Pasajero
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Mostrar();
        }
        #endregion

        #region Sobrecargas lista de pasajeros

        /// <summary>
        /// Compara una lista de Pasajeros con un tipo Pasajero , para determinar si se encuentra
        /// dentro de la misma
        /// </summary>
        /// <param name="listaPasajeros"></param>
        /// <param name="pasajeroUno"></param>
        /// <returns>True si esta , false si no esta</returns>
        public static bool operator ==(List<Pasajero> listaPasajeros, Pasajero pasajeroUno)
        {
            bool esta = false;
            foreach (Pasajero item in listaPasajeros)
            {
                if (item == pasajeroUno)
                {
                    esta = true;
                    break;
                }
            }
            return esta;
        }

        /// <summary>
        /// Compara una lista de Pasajeros con un tipo Pasajero , para determinar si no se encuentra
        /// dentro de la misma
        /// </summary>
        /// <param name="listaPasajeros"></param>
        /// <param name="pasajeroUno"></param>
        /// <returns>True si no esta , false si esta</returns>
        public static bool operator !=(List<Pasajero> listaPasajeros, Pasajero pasajeroUno)
        {
            return !(listaPasajeros == pasajeroUno);
        }

        /// <summary>
        /// Agrega un objeto del tipo Pasajero que recibe  a la lista de tipo  Pasajero
        /// dentro de la misma se pregunta si no se encuentra ya ese objeto, y se agrega el mismo
        /// </summary>
        /// <param name="listaPasajeros"></param>
        /// <param name="pasajeroUno"></param>
        /// <returns>lista de pasajeros actualizada, con el agregado del pasajero ingresados</returns>
        public static List<Pasajero> operator +(List<Pasajero> listaPasajeros, Pasajero pasajeroUno)
        {
        
            if (listaPasajeros != pasajeroUno)
            {
                listaPasajeros.Add(pasajeroUno);
            }
            
            return listaPasajeros;
        }
        /// <summary>
        /// Elimina un objeto del tipo Pasajero que recibe  a la lista de tipo Pasajero
        /// dentro de la misma se pregunta si se encuentra ya ese objeto, y se elemina el mismo
        /// </summary>
        /// <param name="listaPasajeros"></param>
        /// <param name="pasajeroUno"></param>
        /// <returns>lista de pasajeros actualizada, con el borrado del pasajero ingresados</returns>
        public static List<Pasajero> operator -(List<Pasajero> listaPasajeros, Pasajero pasajeroUno)
        {

            if (listaPasajeros == pasajeroUno)
            {
                listaPasajeros.Remove(pasajeroUno);
            }

            return listaPasajeros;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Muestra todos los campos de la clase  Pasajero, llamando ademas a la clase base para obtener nombre apellido
        /// </summary>
        /// <returns></returns>
        protected override string Mostrar()
        {
            StringBuilder datos = new StringBuilder();

            datos.Append($"{base.Mostrar()} {this.dni} {this.edad} {this.equipaje} ");

            return datos.ToString();
        }

        /// <summary>
        /// Sobrecarga del operador de conversion implicit donde recibe un objeto de la clase
        /// pasajero y lo muestra , llamando al ToString()
        /// </summary>
        /// <returns></returns>
        public static implicit operator string(Pasajero pasajero)
        {
            return pasajero.ToString();
        }

        /// <summary>
        /// Encuentra un pasajero a traves de su dni, se recibe una dni y se busca
        /// en la lista de Pasajeros la igualdad en dni , cuando se encuentra se devuelve 
        /// un objeto del tipo Pasajero
        /// </summary>
        /// <param name="listaPasajeros"></param>
        /// <param name="dni"></param>
        /// <returns>Objeto Pasajero</returns>
        public Pasajero EncontrarPasajero(List<Pasajero> listaPasajeros, int dni)
        {
            Pasajero pasajeroEncontrado = new Pasajero();

            foreach (Pasajero item in listaPasajeros)
            {
                if (item == dni)
                {
                    pasajeroEncontrado = item;
                    break;
                }
            }
            return pasajeroEncontrado;
        }

        /// <summary>
        /// Encuentra el indicie de un pasajero a traves del ingreso de otro pasajero
        /// se comparan y cuando se encuentra, se retorna el indice en lista.
        /// </summary>
        /// <param name="listaDePasajeros"></param>
        /// <param name="pasajero"></param>
        /// <returns>Indice de la lista</returns>
        public int ObtenerIndicePasajero(List<Pasajero> listaDePasajeros, Pasajero pasajero)
        {
            int indice = -1;

            for (int i = 0; i < listaDePasajeros.Count; i++)
            {
                if (listaDePasajeros[i] == pasajero)
                {
                    indice = i;
                    break;
                }
            }
            return indice;
        }
        #endregion
    }
}
