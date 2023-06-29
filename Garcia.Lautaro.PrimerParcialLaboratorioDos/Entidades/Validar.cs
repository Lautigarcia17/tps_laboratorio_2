using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Validar
    {
        #region Metodos

        #region ValidarCamposCompletos
        /// <summary>
        /// Funcion para validar 4 cadenas y determinar si no estan todas vacias
        /// </summary>
        /// <param name="cadenaUno"></param>
        /// <param name="cadenaDos"></param>
        /// <param name="cadenaTres"></param>
        /// <param name="cadenanaCuatro"></param>
        /// <returns>True si estan llenas, false si esta vacia por lo menos una</returns>
        public static bool ValidarCamposCompletos(string cadenaUno, string cadenaDos, string cadenaTres,string cadenanaCuatro)
        {
            bool todoLleno = false;
            if (!(string.IsNullOrEmpty(cadenaUno)) && !(string.IsNullOrEmpty(cadenaDos)) && !(string.IsNullOrEmpty(cadenaTres)) && !(string.IsNullOrEmpty(cadenanaCuatro)))
            {
                todoLleno = true;
            }
            return todoLleno;
        }
        /// <summary>
        /// Funcion para validar 3 cadenas y determinar si no estan todas vacias
        /// </summary>
        /// <param name="cadenaUno"></param>
        /// <param name="cadenaDos"></param>
        /// <param name="cadenaTres"></param>
        /// <returns>True si estan llenas, false si esta vacia por lo menos una</returns>
        public static bool ValidarCamposCompletos(string cadenaUno,string cadenaDos,string cadenaTres)
        {
            bool todoLleno = false;
            if (!(string.IsNullOrEmpty(cadenaUno)) && !(string.IsNullOrEmpty(cadenaDos)) && !(string.IsNullOrEmpty(cadenaTres)))
            {
                todoLleno = true;
            }
            return todoLleno;
        }
        /// <summary>
        /// Funcion para validar 2 cadenas y determinar si no estan todas vacias
        /// </summary>
        /// <param name="cadenaUno"></param>
        /// <param name="cadenaDos"></param>
        /// <returns>True si estan llenas, false si esta vacia por lo menos una</returns>
        public static bool ValidarCamposCompletos(string cadenaUno, string cadenaDos) 
        {
            bool todoLleno = false;
            if (!(string.IsNullOrEmpty(cadenaUno)) && !(string.IsNullOrEmpty(cadenaDos)))
            {
                todoLleno = true;
            }
            return todoLleno;
        }
            #endregion

        #region VerificarCambios
        /// <summary>
        /// Recibe un pasajero y verifica si todos los strings recibidos son iguales a los campos
        /// de la clase Pasajero
        /// </summary>
        /// <param name="pasajero"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="edad"></param>
        /// <returns>True si son iguales,  false si son distintos</returns>
        public static bool VerificarCambios(Pasajero pasajero, string nombre, string apellido, string dni, string edad)
        {
            bool cambios = true;

            if (nombre == pasajero.Nombre &&
                apellido == pasajero.Apellido &&
                dni == pasajero.Dni.ToString() &&
                edad == pasajero.Edad.ToString())
            {
                cambios = false;
            }
            return cambios;
        }

        /// <summary>
        /// Recibe un vuelo y verifica si todos los strings recibidos son iguales a los campos
        /// de la clase Pasajero
        /// </summary>
        /// <param name="vuelo"></param>
        /// <param name="origen"></param>
        /// <param name="destino"></param>
        /// <param name="fechaVuelo"></param>
        /// <param name="matricula"></param>
        /// <returns>True si son iguales,  false si son distintos</returns>
        public static bool VerificarCambios(Vuelo vuelo, string origen, string destino, DateTime fechaVuelo, string matricula)
        {
            bool cambio = true;

            if (vuelo.CiudadPartida == origen &&
                vuelo.CiudadDeDestino == destino &&
                vuelo.FechaVuelo == fechaVuelo &&
                vuelo.Avion.Matricula == matricula)
            {
                cambio = false;
            }

            return cambio;
        }
        public static bool VerificarCambios(Aeronave aeronave, string cantidadAsientos, string cantidadBanios, string capacidadBodega, bool comida, bool internet)
        {
            bool cambios = true;

            if (cantidadAsientos == aeronave.CantidadAsientos.ToString() &&
                cantidadBanios == aeronave.CantidadBanios.ToString() &&
                capacidadBodega == aeronave.CapacidadBodega.ToString() &&
                comida == aeronave.OfreceComida &&
                internet == aeronave.OfreceInternet)
            {
                cambios = false;
            }
            return cambios;
        }

            #endregion


        /// <summary>
        /// Recibe un ciudad de partida y si es igual al string Buenos Aires , devuelve true
        /// </summary>
        /// <param name="ciudadPartida"></param>
        /// <returns>True si es internacional , false si no es internacional</returns>
        public static bool EsVueloInternacional(string ciudadPartida)
        {
            bool esInternacional = false;
            if (ciudadPartida == "Buenos Aires")
            {
                esInternacional = true;
            }
            return esInternacional;
        }

        /// <summary>
        /// Valida el ingreso de numeros,  preguntandose si  es un digito
        /// </summary>
        /// <param name="caracter"></param>
        /// <returns>True si es un numero , false si no es un numero</returns>
        public static bool ValidarIngresoNumeros(char caracter)
        {
            bool esValido = true;
            if (!char.IsControl(caracter) && !Char.IsDigit(caracter))
            {
                esValido = false;
            }

            return esValido;
        }

        /// <summary>
        /// Valida el ingreso de letras,  preguntandose si  es una letra
        /// </summary>
        /// <param name="caracter"></param>
        /// <returns>True si es un caracter , false si no es un caracter</returns>
        public static bool ValidarIngresoLetras(char caracter)
        {
            bool esValido = true;
            if (!char.IsControl(caracter) && !Char.IsLetter(caracter))
            {
                esValido = false;
            }

            return esValido;
        }

        /// <summary>
        /// Valida el ingreso minimo de un dni, contando que el tamanio minimo es de 8 numeros
        /// </summary>
        /// <param name="dniEvaluar"></param>
        /// <returns>True si es valido , false  si no es valido</returns>
        public static bool ValidarDniMinimo(int dniEvaluar)
        {
            bool esValido = true;
            int minimoTamanio = 7;

            if (dniEvaluar < minimoTamanio)
            {
                esValido = false;
            }

            return esValido;
        }

        #endregion
    }
}
