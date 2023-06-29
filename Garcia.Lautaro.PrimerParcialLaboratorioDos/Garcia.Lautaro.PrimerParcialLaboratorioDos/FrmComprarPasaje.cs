using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garcia.Lautaro.PrimerParcialForm
{
    public partial class FrmComprarPasaje : FrmBase
    {
        private List<Pasajero> listaPasajeros;
        private Vuelo vueloComprarPasaje;
        private Pasajero comprador;
        private bool esPremium;

        public Vuelo VueloComprarPasaje
        {
            get { return this.vueloComprarPasaje; }
            set { this.vueloComprarPasaje = value; }
        }

        public bool EsPremium
        {
            get { return this.esPremium; }
            set { esPremium = value; }
        }

        public Pasajero Comprador
        {
            get { return this.comprador; }
            set { comprador = value; }
        }

        public FrmComprarPasaje(Vuelo vuelo)
        {
            InitializeComponent();
            this.listaPasajeros = Archivos.LeerXmlPasajeros();
            this.vueloComprarPasaje = vuelo;
        }

        private void FrmComprarPasaje_Load(object sender, EventArgs e)
        {
            base.btnModificar.Visible = false;
            base.btnBorrar.Visible = false;
            base.btnAgregar.Text = "COMPRAR";

            this.esPremium = false;
            this.lblPartida.Text += this.vueloComprarPasaje.CiudadPartida;
            this.lblDestino.Text += this.vueloComprarPasaje.CiudadDeDestino;
            this.lblCapacidadBodega.Text += $"{this.vueloComprarPasaje.PesoCargaValijas} / {this.vueloComprarPasaje.Avion.CapacidadBodega} KG";

            if (this.vueloComprarPasaje.PasajerosTurista.Count == this.vueloComprarPasaje.CantidadAsientosTurista)
            {
                this.lblAsientosTurista.Text += "Sin asientos disponibles";
                this.rbtPremium.Checked = true;
                this.rbtTurista.Visible = false;
            }
            else
            {
                this.lblAsientosTurista.Text += "Disponibles";
            }
            if (this.vueloComprarPasaje.PasajerosPremium.Count == this.vueloComprarPasaje.CantidadAsientosPremium)
            {
                this.lblAsientosPremium.Text += "Sin asientos disponibles";
                this.rbtTurista.Checked = true;
                this.rbtPremium.Visible = false;

            }
            else
            {
                this.lblAsientosPremium.Text += "Disponibles";
            }

            lblComida.Text += Aeronave.ObtenerEstadoDelServicio(this.vueloComprarPasaje.Avion.OfreceComida);
            lblInternet.Text += Aeronave.ObtenerEstadoDelServicio(this.vueloComprarPasaje.Avion.OfreceInternet);



            this.CargarPasajerosListBox();
            this.GenerarFacturacion();

            MessageBox.Show("!! Bienvenido al sector de compra !!\nTen en cuenta las siguientes restricciones : \n" +
                "Clase Turista : Puede llevar un bolso de mano y una valija de hasta 25 KG.\n" +
                "Clase Premium : Puede llevar un bolso de mano y dos valijas de hasta 21 KG.", "Bienvenido", MessageBoxButtons.OK);

        }

        protected override void btnAgregar_Click(object sender, EventArgs e)
        {
            this.comprador = this.SeleccionarPasajeroListBox();

            if (this.comprador.Dni != 0)
            {
                int nuevoPeso = this.ValidarPesoAvion((int)numValijaUno.Value, (int)numValijaDos.Value, vueloComprarPasaje.PesoCargaValijas, vueloComprarPasaje.Avion.CapacidadBodega);
                if (nuevoPeso != -1)
                {
                    if (this.rbtPremium.Checked)
                    {
                        this.esPremium = true;
                    }
                    this.comprador.Equipaje = this.GenerarEquipajePasajero();
                    this.comprador.CantidadVuelosComprados++;

                    this.vueloComprarPasaje.PesoCargaValijas = nuevoPeso;

                    Archivos.GuardarXmlPasajeros(listaPasajeros);
                    DialogResult = DialogResult.Yes;
                }
                else
                {
                    int espacioRestante = this.vueloComprarPasaje.Avion.CapacidadBodega - this.vueloComprarPasaje.PesoCargaValijas;
                    MessageBox.Show($"ERROR. El peso excede la capacidad del avion. Al avion le queda espacio de {espacioRestante} KG", "AVISO");
                }

            }
            else
            {
                MessageBox.Show("Error. Debe seleccionar un pasajero");
            }

        }

        private int ValidarPesoAvion(int valijaUno, int valijaDos, int pesoDelVuelo, int capacidadDelAvion)
        {
            int nuevoPeso = valijaUno + valijaDos + pesoDelVuelo;

            if (nuevoPeso > capacidadDelAvion)
            {
                nuevoPeso = -1;
            }

            return nuevoPeso;
        }


        private void rbtTurista_CheckedChanged(object sender, EventArgs e)
        {
            this.PonerDefaultControlsEquipaje();

            this.lblValijaDos.Visible = false;
            this.numValijaDos.Visible = false;

            this.numValijaUno.Maximum = 25;

            this.GenerarFacturacion();

        }

        private void rbtPremium_CheckedChanged(object sender, EventArgs e)
        {
            this.PonerDefaultControlsEquipaje();

            this.numValijaUno.Maximum = 21;

            this.GenerarFacturacion();

        }



        private void CargarPasajerosListBox()
        {
            lstPasajeros.Items.Clear();
            foreach (Pasajero item in listaPasajeros)
            {
                if (this.vueloComprarPasaje.Pasajeros != item) // si no se encuentra en el vuelo que lo cargue
                {
                    this.lstPasajeros.Items.Add($" {item.Dni}  /  {item.Nombre} {item.Apellido}");
                }
            }
        }

        private Pasajero SeleccionarPasajeroListBox()
        {
            Pasajero comprador = new Pasajero();
            string? textoSeleccionado = this.lstPasajeros.SelectedItem?.ToString();

            if (textoSeleccionado != null)
            {
                string[] datos = textoSeleccionado.Split('/'); // separa donde encuentre una /
                string dniTexto = datos[0].Trim(); // borra espacios en blanco
                int dni = int.Parse(dniTexto);

                comprador = comprador.EncontrarPasajero(this.listaPasajeros, dni);
            }
            return comprador;
        }
        private void PonerDefaultControlsEquipaje()
        {
            this.lblValijaDos.Visible = true;
            this.numValijaDos.Visible = true;
            this.numValijaUno.Value = 0;
            this.numValijaDos.Value = 0;
            this.chkBolsoDeMano.Checked = false;
        }

        private string GenerarEquipajePasajero()
        {
            StringBuilder equipajePasajero = new StringBuilder();

            if (this.chkBolsoDeMano.Checked)
            {
                equipajePasajero.AppendLine($"\n{this.chkBolsoDeMano.Text}");
            }

            if (this.numValijaUno.Value > 0)
            {
                equipajePasajero.AppendLine($"Valija 1 : {this.numValijaUno.Value} KG");
            }
            if (this.numValijaDos.Value > 0)
            {
                equipajePasajero.AppendLine($"Valija 2: {this.numValijaDos.Value} KG");
            }

            return equipajePasajero.ToString();
        }

        private void GenerarFacturacion()
        {
            if (this.rbtPremium.Checked)
            {
                this.lblCosto.Text = $"Precio Bruto : $ {this.vueloComprarPasaje.CostoPremium}";
                this.lblPrecioFinal.Text = $"Precio Final Neto (+ IVA) : $ {(this.vueloComprarPasaje.CostoPremium * 1.21).ToString("0.00")}";
            }
            else
            {
                this.lblCosto.Text = $"Precio Bruto : $ {this.vueloComprarPasaje.CostoTurista}";
                this.lblPrecioFinal.Text = $"Precio Final Neto (+ IVA) : $ {(this.vueloComprarPasaje.CostoTurista * 1.21).ToString("0.00")}";
            }
        }


    }
}


