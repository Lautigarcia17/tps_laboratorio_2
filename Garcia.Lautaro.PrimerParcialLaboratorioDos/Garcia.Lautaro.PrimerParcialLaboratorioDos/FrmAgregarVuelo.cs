using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Garcia.Lautaro.PrimerParcialForm
{
    public partial class FrmAgregarVuelo : FrmBase
    {
        private List<Aeronave> listaAviones;
        private Aeronave avionVuelo;
        private Vuelo vueloAgregar;

        #region Propiedad
        public Vuelo VueloAgregar
        {
            get
            {
                return this.vueloAgregar;
            }

            set
            {
                this.vueloAgregar = value;
            }
        }
        #endregion
        public FrmAgregarVuelo()
        {
            InitializeComponent();
            this.vueloAgregar = new Vuelo();
            this.listaAviones = Archivos.LeerJsonAeronave();
            this.avionVuelo = new Aeronave();
            this.CargarAvionesComboBox();
        }
        private void FrmAgregarVuelo_Load(object sender, EventArgs e)
        {
            base.btnModificar.Visible = false;
            base.btnBorrar.Visible = false;
            this.cmbOrigen.Enabled = false;
            this.cmbDestino.Enabled = false;
        }


        private void rbNacional_CheckedChanged(object sender, EventArgs e)
        {
            this.LimpiarComboBox();

            this.cmbOrigen.Enabled = true;
            this.cmbDestino.Enabled = true;

            this.CargarViajesNacionalesComboBox();
        }

        private void rbInternacional_CheckedChanged(object sender, EventArgs e)
        {
            this.LimpiarComboBox();

            this.cmbOrigen.Enabled = true;
            this.cmbDestino.Enabled = true;
            this.cmbOrigen.Items.Add("Buenos Aires"); // todo internacional sale de bs as
            this.cmbOrigen.SelectedIndex = 0; // default
            this.CargarViajesInternacionalesComboBox();

        }

        protected override void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Validar.ValidarCamposCompletos(this.cmbOrigen.Text, this.cmbDestino.Text, this.cmbAeronave.Text) == true)
            {
                this.vueloAgregar = this.CrearVuelo();
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Error.Faltan completar campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LimpiarComboBox()
        {
            this.cmbDestino.Items.Clear();
            this.cmbOrigen.Items.Clear();
        }

        protected void CargarAvionesComboBox()
        {
            foreach (Aeronave item in this.listaAviones)
            {
                this.cmbAeronave.Items.Add(item.Matricula);
            }
        }
        protected void CargarViajesNacionalesComboBox()
        {
            this.cmbDestino.Items.Clear();
            this.cmbOrigen.Items.Clear();

            foreach (ENacional item in Enum.GetValues(typeof(ENacional))) // SI SE ELIJE UNO,NO SE PUEDE ELEGIR EN EL OTRO
            {
                string pais = item.ToString().Replace('_', ' ');

                this.cmbOrigen.Items.Add(pais);
                this.cmbDestino.Items.Add(pais);
            }
        }
        protected void CargarViajesInternacionalesComboBox()
        {
            this.cmbDestino.Items.Clear();
            foreach (EInternacional item in Enum.GetValues(typeof(EInternacional)))
            {
                this.cmbDestino.Items.Add(item);
            }
        }



        protected void dtpFechaVuelo_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = this.dtpFechaVuelo.Value;
            DateTime fechaHoy = DateTime.Now; ;
            if (fechaSeleccionada < fechaHoy && (fechaSeleccionada.Hour < fechaHoy.Hour || fechaSeleccionada.Minute < fechaHoy.Minute))
            {
                MessageBox.Show("La hora seleccionada debe ser mayor a la hora actual.", "Aviso", MessageBoxButtons.OK);
                this.dtpFechaVuelo.Value = DateTime.Now; // restrablezco la hora
            }
        }


        protected Vuelo CrearVuelo()
        {

            if (!(listaAviones is null))
            {
                avionVuelo = avionVuelo.EncontrarAeronave(this.listaAviones, this.cmbAeronave.Text);
            }
            int costo = 100;
            int asientosTurista;
            int asientosPremium;
            float costoTurista;
            float costoPremium;
            TimeSpan hora;
            int tiempoEnHora;

            if (Validar.EsVueloInternacional(this.cmbOrigen.Text))
            {
                hora = Vuelo.GenerarHora(8, 12);
            }
            else
            {
                hora = Vuelo.GenerarHora(2, 4);
                costo = 50;
            }

            tiempoEnHora = hora.Hours;
            if (hora.Minutes > 50)
            {
                tiempoEnHora++;
            }

            costoTurista = tiempoEnHora * costo;
            costoPremium = 1.35f * costoTurista;

            asientosPremium = (int)(avionVuelo.CantidadAsientos * 0.20);
            asientosTurista = (avionVuelo.CantidadAsientos - asientosPremium);


            Vuelo vueloNuevo = new Vuelo(ETipoEstadoVuelo.Proximo.ToString(), this.cmbOrigen.Text, this.cmbDestino.Text,
                                    this.dtpFechaVuelo.Value, avionVuelo, asientosPremium,
                                    asientosTurista, costoTurista, costoPremium, hora);

            vueloNuevo.Avion.CantidadVuelos++; // Se le suma 1 vuelo al avion existente  

            return vueloNuevo;
        }



        private void btnMostrarAeronave_Click_1(object sender, EventArgs e)
        {
            if (this.cmbAeronave.SelectedIndex >= 0)
            {
                avionVuelo = avionVuelo.EncontrarAeronave(this.listaAviones, this.cmbAeronave.Text);
                MessageBox.Show(avionVuelo.ToString());
            }
            else
            {
                MessageBox.Show("Debe seleccionar un aeronave para mostralo !!", "AVISO", MessageBoxButtons.OK);
            }
        }
    }
}
