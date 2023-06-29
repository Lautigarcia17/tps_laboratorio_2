using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Tiradas
    {
        private List<Dado> listaDadosTirados;

        public Tiradas()
        {
            this.listaDadosTirados = new List<Dado>();
        }


        public List<Dado> ListaDadosTirados { get => this.listaDadosTirados; }


        #region METODOS
        /// <summary>
        /// Genera una tirada de dados, donde se guarda en el atributo listaDadosTirados 5 tipo Dado, en caso de que la lista de dados venga con  4 dados cargados o mas
        /// se limpia , esto es por si es un full,generala,poker, en caso de que no sea ninguno de estos puede tener de igual manera numeros repetidos asi que se carga a partir de su contador
        /// </summary>
        public void GenerarTirada()
        {
            int i;
            if (this.listaDadosTirados.Count >3)
            {
                this.listaDadosTirados.Clear();
            }

            for (i = this.listaDadosTirados.Count; i < 5; i++)
            {
                this.listaDadosTirados.Add(new Dado());
            }
        }


        #region Tipos de tirada

        /// <summary>
        /// Detecta el tipo de tirada,recibe una tabla de un jugador, primero preguntando si todos los dados distintos , en caso 
        /// de que no sean distintos verifica que sean full,generala,poker y si es uno de esto retorna true y carga la propiedad de tabla correspondiente al tipo con el valor 
        /// correspondiente a cada tipo.Si no dados iguales tambien puede existir la posiblidad de que  sea escalera, tambien verificandose esto. En caso de que sean distintos
        /// puede que sean todos distintos o que alla repeticion de 2 o 3 dados. 
        /// </summary>
        /// <param name="tabla"></param>
        /// <returns>True si es un tipo especifico de tirada,  false si son todos distintos o hay 2/3 repetidos</returns>
        public bool DetectarTipoTirada(Tabla tabla) 
        {
            bool retorno = false;

            if (this.VerificarDadosDistintos() == false)
            {
                if (this.VerificarFull())
                {
                    if (tabla.Full == 0)
                    { 
                        tabla.Full = (int)ETipoTirada.Full;
                    }
                    retorno = true;
                }
                else if (this.VerificarPoker())
                {
                    if (tabla.Poker == 0)
                    {
                        tabla.Poker = (int)ETipoTirada.Poker;
                    }
                    retorno = true;
                }
                else if (this.VerificarGenerala())
                {
                    if (tabla.Generala == 0)
                    {
                        tabla.Generala = (int)ETipoTirada.Generala;
                    }
                    retorno = true;
                }
            }
            else
            {
                if (this.VerificarEscalera())
                {
                    if (tabla.Escalera == 0)
                    {
                        tabla.Escalera = (int)ETipoTirada.Escalera;
                    }
                    retorno = true;
                }
            }

            return retorno;
        }
        /// <summary>
        /// Recorre la lista de dados tirados, preguntando por iteracion cuantas veces se repite ese dado en la lista, si el dado se repite 2/3 veces, lo elige y borra todos
        /// los que sean distintos a este y retorna true. En caso de que no alla repetidos, elige el numero mayor en la lista y actualiza la lista  borrando todos los distintos a este.
        /// </summary>
        public  void CargarDadoSeleccionado()
        {
            bool hayRepetido = false;
            foreach (Dado dado in this.listaDadosTirados)
            {
                int cantidadRepetida = this.listaDadosTirados.Count(d => d.NumeroDado == dado.NumeroDado); // contar cantidad de repeticiones por numero

                if (cantidadRepetida == 2 || cantidadRepetida == 3)
                {
                    this.listaDadosTirados.RemoveAll(x  => x != dado); // RemoveAll funciona con lambda
                    hayRepetido = true;
                    break;
                }
            }
            if (hayRepetido == false)
            {
                this.CargarMayorDado();
            }
        }

        /// <summary>
        /// Busca en la lista de dados tirados cual es el mayor dado , por su atributo NumeroDado y actualiza la lista removiendo todos los que sean distintos a este
        /// </summary>
        private void CargarMayorDado()
        {
            Dado? dadoMayorSinRepeticion = this.listaDadosTirados.MaxBy(x => x.NumeroDado); // busca el mayor en la lista
            if (!(dadoMayorSinRepeticion is null))
            {
                this.listaDadosTirados.RemoveAll(x => x != dadoMayorSinRepeticion); // borrar todos los distintos al numero
            }
        }

        /// <summary>
        /// Verifica si en la lista de dados tirado, son todos los dados distintos. Selecciona todos los dados y borra los repetidos, si el contador de la lista da 5 , quiere decir que son todos distintos
        /// y retorna true, en caso contrario retorna false
        /// </summary>
        /// <returns>True si son todos distintos,False si hay iguales</returns>
        private bool VerificarDadosDistintos()
        {
            List<int> listaDadosDistintos = this.listaDadosTirados.Select(x => x.NumeroDado).Distinct().ToList();  // Selecciona de la lista el campo NumeroDado, y lo guarda en la lista, luego borrar los numeros repetidos con el distinct()
            bool valoresDistintos = false;

            if (listaDadosDistintos.Count == 5)
            {
                valoresDistintos = true;
            }

            return valoresDistintos;
        }

        /// <summary>
        /// Verifica si la lista de dados tirados sigue la secuencia de numeros 1,2,3,4,5 o 2,3,4,5,6 , si la sigue retorna true y sino retorna false
        /// </summary>
        /// <returns>True si es escalera, false si no lo es</returns>
        private bool VerificarEscalera()
        {
            List<int> listaNumerosDado = this.listaDadosTirados.Select(x => x.NumeroDado).ToList();  // Select = Selecciona de la lista, el objeto Dado y me trae su numero

            bool esEscalera = false;

            if (listaNumerosDado.SequenceEqual(new List<int> { 1, 2, 3, 4, 5 }) || listaNumerosDado.SequenceEqual(new List<int> { 2, 3, 4, 5, 6 }))
            {
                esEscalera = true;
            }
            return esEscalera;
        }

        /// <summary>
        /// Verifica si la lista de dados tiene 3 dados iguales y 2 dados iguales.Seleccionando todos y guarda en una nueva lista los repetidos
        /// Si el contador de repetidos da 2, quiere decir que puede ser full. Recorre la lista de dados preguntando si se repite ese
        /// numero, si ese numero se repite 2 o 3 veces, se cambia el estado de un booleano , lo mismo con el otro repetido . Si los dos estados
        /// estan en true significa que es un full , para que los estados esten en true tiene que un repetido estar 2 veces y el otro 3 veces.
        /// </summary>
        /// <returns>True si es Full , False si no lo es</returns>
        private bool VerificarFull()
        {
            List<int> listaRepetidos = this.listaDadosTirados.Select(x => x.NumeroDado).Distinct().ToList();  // Selecciona de la lista el campo NumeroDado, y lo guarda en la lista, luego borrar los numeros repetidos con el distinct()
            bool tresIguales = false;
            bool dosIguales = false;
            int contador;

            if (listaRepetidos.Count == 2)
            {
                for (int i = 0; i < listaRepetidos.Count; i++)
                {
                    contador = 0;
                    for (int j = 0; j < this.listaDadosTirados.Count; j++)
                    {
                        if (listaRepetidos[i] == this.listaDadosTirados[j].NumeroDado)
                        {
                            contador++;
                        }
                    }
                    if (contador == 3)
                    {
                        tresIguales = true;
                    }
                    else if (contador == 2)
                    {
                        dosIguales = true;
                    }
                }
            }

            return tresIguales && dosIguales; // dos iguales es true, 1 y 1 es false
        }

        /// <summary>
        /// Verifica si la lista de dados tiene 4 dados iguales .Seleccionando todos y guarda en una nueva lista los repetidos y 
        /// Si el contador de repetidos da 2, quiere decir que puede ser Poker. Recorre la lista de dados preguntando si se repite ese
        /// numero, si ese numero se repite 4 veces, se cambia el estado de un booleano. 
        /// </summary>
        /// <returns>True si es Poker , False si no lo es</returns>
        private bool VerificarPoker()
        {
            List<int> listaRepetidos = this.listaDadosTirados.Select(x => x.NumeroDado).Distinct().ToList();  // Selecciona de la lista el campo NumeroDado, y lo guarda en la lista, luego borrar los numeros repetidos con el distinct()
            bool esPoker = false;
            int contador;

            if (listaRepetidos.Count == 2)
            {
                for (int i = 0; i < listaRepetidos.Count; i++)
                {
                    contador = 0;
                    for (int j = 0; j < this.listaDadosTirados.Count; j++)
                    {
                        if (listaRepetidos[i] == this.listaDadosTirados[j].NumeroDado)
                        {
                            contador++;
                        }
                    }
                    if (contador == 4)
                    {
                        esPoker = true;
                        break;
                    }
                }
            }
            return esPoker;
        }

        /// <summary>
        /// Verifica si la lista de dados tiene 5 dados iguales .Seleccionando todos y guarda en una nueva lista los repetidos y 
        /// Si el contador de repetidos da 1, quiere decir que es Generala. 
        /// </summary>
        /// <returns>True si es Generala, False si no lo es</returns>
        private bool VerificarGenerala()
        {
            List<int> listaRepetidos = this.listaDadosTirados.Select(x => x.NumeroDado).Distinct().ToList();  // Selecciona de la lista el campo NumeroDado, y lo guarda en la lista, luego borrar los numeros repetidos con el distinct()
            bool esGenerala = false;

            if (listaRepetidos.Count == 1)
            {
                esGenerala = true;
            }
            return esGenerala;
        }
        #endregion

        #endregion

        /// <summary>
        /// Muestra todos los dados de la tirada , y lo retorna en un string
        /// </summary>
        /// <returns>string con todos los datos</returns>
        public string Mostrar()
        {
            StringBuilder dados = new StringBuilder();

            foreach (Dado item in this.listaDadosTirados)
            {
                dados.AppendLine(item.ToString());
            }

            return dados.ToString();
        }
        /// <summary>
        /// LLama al metodo Mostrar(), que contiene todos los atributos de la clase y lo retorna en formato string
        /// </summary>
        /// <returns>String de datos</returns>
        public override string ToString()
        {
            return this.Mostrar();
        }

        /// <summary>
        /// Recibe una tabla que va a ser del Jugador. Recorre la lista de dados y pregunta en un switch cual es el dado, si ese tipo 
        /// en la tabla todavia no fue cargado, se puede cargar, y generando una bandera para que pueda cargarse 2 veces en un mismo bucle
        /// </summary>
        /// <param name="tabla"></param>
        public void SumarTiradaSinTipo(Tabla tabla)
        {
            bool entroUno = false;
            bool entroDos = false;
            bool entroTres = false;
            bool entroCuatro = false;
            bool entroCinco = false;
            bool entroSeis = false;

            foreach (Dado item in this.listaDadosTirados)
            {
                switch (item.NumeroDado) 
                {
                    case 1:
                        if (tabla.Uno == 0 || entroUno == true)
                        {
                            tabla.Uno += item.NumeroDado;
                            entroUno = true;
                        }
                    break;
                    case 2:
                        if (tabla.Dos == 0 || entroDos == true)
                        {
                            tabla.Dos += item.NumeroDado;
                            entroDos = true;
                        }
                        break;
                    case 3:
                        if (tabla.Tres == 0 || entroTres == true)
                        {
                            tabla.Tres += item.NumeroDado;
                            entroTres = true;
                        }
                        break;
                    case 4:
                        if (tabla.Cuatro == 0 || entroCuatro == true)
                        {
                            tabla.Cuatro+= item.NumeroDado;
                            entroCuatro = true;
                        }
                        break;
                    case 5:
                        if (tabla.Cinco == 0 || entroCinco == true)
                        {
                            tabla.Cinco += item.NumeroDado;
                            entroCinco = true;
                        }
                        break;
                    default:
                        if (tabla.Seis == 0 || entroSeis == true)
                        {
                            tabla.Seis += item.NumeroDado;
                            entroSeis = true;
                        }
                        break;
                }
            }
        }

    }
}
