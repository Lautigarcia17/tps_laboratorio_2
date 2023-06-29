using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Tabla
    {
        private int poker;
        private int full;
        private int escalera;
        private int generala;
        private int uno;
        private int dos;
        private int tres;
        private int cuatro;
        private int cinco;
        private int seis;

        public Tabla()
        {
            this.poker = 0;
            this.full = 0;
            this.escalera = 0;
            this.generala = 0;
            this.uno = 0;
            this.dos = 0;
            this.tres = 0;
            this.cuatro = 0;
            this.cinco = 0;
            this.seis = 0;         
        }

        public int Poker 
        { 
            get => this.poker; 
            set => this.poker = value; 
        }
        public int Full 
        { 
            get => full; 
            set => full = value;
        }
        public int Escalera 
        { 
            get => escalera; 
            set => escalera = value; 
        }
        public int Generala 
        { 
            get => generala; 
            set => generala = value; 
        }
        public int Uno
        { 
            get => uno; 
            set => uno = value;
        }
        public int Dos 
        { 
            get => dos; 
            set => dos = value; 
        }
        public int Tres
        { 
            get => tres; 
            set => tres = value; 
        }
        public int Cuatro 
        { 
            get => cuatro; 
            set => cuatro = value;
        }
        public int Cinco 
        { 
            get => cinco; 
            set => cinco = value; 
        }
        public int Seis 
        { 
            get => seis; 
            set => seis = value; 
        }


        public int SumaPuntaje
        {
             get => this.SumarPuntajes(); 
        }

        /// <summary>
        /// Suma todos los atributos de la clase y lo retorna en formato entero
        /// </summary>
        /// <returns>Entero de la suma de todas los atributos</returns>
        private int SumarPuntajes()
        {
            return this.poker + this.escalera + this.generala + this.full + this.uno + this.dos + this.tres + this.cuatro + this.cinco + this.seis;
        }


        /// <summary>
        /// Muestra todos los atributos de la clase y lo retorna en formato de string
        /// </summary>
        /// <returns>string con todos los datos</returns>
        private string MostrarPuntajes()
        { 
            StringBuilder datosTabla = new StringBuilder();

            datosTabla.AppendLine($"Tabla 1 : {this.uno}");
            datosTabla.AppendLine($"Tabla 2 : {this.dos}");
            datosTabla.AppendLine($"Tabla 3 : {this.tres}");
            datosTabla.AppendLine($"Tabla 4 : {this.cuatro}");
            datosTabla.AppendLine($"Tabla 5 : {this.cinco}");
            datosTabla.AppendLine($"Tabla 6 : {this.seis}");
            datosTabla.AppendLine($"Escalera : {this.escalera}");
            datosTabla.AppendLine($"Full : {this.full}");
            datosTabla.AppendLine($"Poker : {this.poker}");
            datosTabla.AppendLine($"Generala : {this.generala}");

            return datosTabla.ToString();
        }
        /// <summary>
        /// LLama al metodo MostrarPuntajes(), que contiene todos los atributos de la clase y lo retorna en formato string
        /// </summary>
        /// <returns>String de datos</returns>
        public override string ToString()
        {
            return this.MostrarPuntajes();
        }



    }
}
