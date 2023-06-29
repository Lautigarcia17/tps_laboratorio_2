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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Garcia.Lautaro.PrimerParcialForm
{
    public partial class FrmModificarVuelo : FrmAgregarVuelo
    {
        private Vuelo vueloAModificar;
        private List<Aeronave> listaAvion;
        private List<Vuelo> listaDeVuelos;
        public Vuelo VueloAModificar
        {
            get
            {
                return this.vueloAModificar;
            }

            set
            {
                this.vueloAModificar = value;
            }
        }

        public FrmModificarVuelo(List<Aeronave> listaDeAviones, Vuelo vueloAModificar)
        {
            InitializeComponent();
            this.vueloAModificar = vueloAModificar;
            this.listaAvion = listaDeAviones;
            this.listaDeVuelos = Archivos.LeerDeXmlVuelos();
        }

        private void FrmModificarVuelo_Load(object sender, EventArgs e)
        {
            this.cmbAeronave.Items.Clear();
            base.CargarAvionesComboBox();

            this.rbInternacional.Enabled = true;
            this.rbNacional.Enabled = true;
            this.dtpFechaVuelo.Enabled = true;
            this.cmbAeronave.Enabled = true;
            this.btnAgregar.Text = "Modificar";
            if (Validar.EsVueloInternacional(this.vueloAModificar.CiudadPartida))
            {
                this.rbInternacional.Checked = true;
            }
            else
            {
                this.rbNacional.Checked = true;
            }

            this.cmbAeronave.SelectedIndex = cmbAeronave.Items.IndexOf(this.vueloAModificar.Avion.Matricula); ; // aparezca primero
            this.cmbOrigen.SelectedIndex = cmbOrigen.Items.IndexOf(this.vueloAModificar.CiudadPartida); ; // aparezca primero
            this.cmbDestino.SelectedIndex = this.SeleccionarItemDestinoComboBox();
            this.dtpFechaVuelo.Value = this.vueloAModificar.FechaVuelo;
        }


        protected override void btnAgregar_Click(object sender, EventArgs e) //// modificar
        {
            this.ModificarUnVuelo();
        }



        private void ModificarUnVuelo()
        {
            if (Validar.ValidarCamposCompletos(this.cmbOrigen.Text, this.cmbDestino.Text, this.cmbAeronave.Text) == true)
            {
                if (Validar.VerificarCambios(this.vueloAModificar, this.cmbOrigen.Text, this.cmbDestino.Text, this.dtpFechaVuelo.Value, this.cmbAeronave.Text)
                    && MessageBox.Show("Esta seguro de modificar el vuelo ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (this.vueloAModificar.Avion.Matricula != this.cmbAeronave.Text)
                    {
                        Aeronave nuevoAvion = new Aeronave();
                        nuevoAvion = nuevoAvion.EncontrarAeronave(this.listaAvion, this.cmbAeronave.Text);
                        if (nuevoAvion.Matricula != string.Empty)
                        {

                            this.vueloAModificar.Avion.DescontarContadorVuelosDelAeronave(this.listaDeVuelos, this.vueloAModificar.Avion);
                            this.vueloAModificar.Avion.CantidadVuelos--;
                            nuevoAvion.ActualizarContadorDeVuelosPorAvion(this.listaAvion, this.vueloAModificar.Avion);

                            //this.cmbAeronave.Text = nuevoAvion.Matricula;  // ?
                            this.vueloAModificar.CantidadAsientosPremium = (int)(nuevoAvion.CantidadAsientos * 0.20);
                            this.vueloAModificar.CantidadAsientosTurista = nuevoAvion.CantidadAsientos - this.vueloAModificar.CantidadAsientosPremium;

                            nuevoAvion.CantidadVuelos++;
                            nuevoAvion.AcrementarContadorVuelosDelAeronave(this.listaDeVuelos, nuevoAvion);
                            nuevoAvion.ActualizarContadorDeVuelosPorAvion(this.listaAvion, nuevoAvion);

                            this.vueloAModificar.Avion = nuevoAvion;
                        }

                    }
                    //else
                    //{
                    //    this.vueloAModificar.Avion.Matricula = this.cmbAeronave.Text;
                    //}

                    if (this.vueloAModificar.CiudadPartida != this.cmbOrigen.Text || this.vueloAModificar.CiudadDeDestino != this.cmbDestino.Text)
                    {
                        int costo;
                        if (Validar.EsVueloInternacional(this.cmbOrigen.Text))
                        {
                            this.vueloAModificar.DuracionVuelo = Vuelo.GenerarHora(8, 12);
                            costo = 100;

                        }
                        else
                        {
                            this.vueloAModificar.DuracionVuelo = Vuelo.GenerarHora(2, 4);
                            costo = 50;
                        }

                        this.vueloAModificar.CostoTurista = this.vueloAModificar.DuracionVuelo.Hours * costo;
                        this.vueloAModificar.CostoPremium = 1.35f * this.vueloAModificar.CostoTurista;

                    }


                    this.vueloAModificar.CiudadPartida = this.cmbOrigen.Text;
                    this.vueloAModificar.CiudadDeDestino = this.cmbDestino.Text;
                    this.vueloAModificar.FechaVuelo = this.dtpFechaVuelo.Value;
                    this.DialogResult = DialogResult.Yes;
                }
                else
                {
                    MessageBox.Show("No se realizo ningun cambio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Error.Faltan completar campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private int SeleccionarItemDestinoComboBox()
        {
            int indice = -1;
            for (int i = 0; i < this.cmbDestino.Items.Count; i++)
            {
                if (this.cmbDestino.Items[i].ToString() == this.vueloAModificar.CiudadDeDestino)
                {
                    indice = i;
                    break;
                }
            }
            return indice;
        }


    }
}
