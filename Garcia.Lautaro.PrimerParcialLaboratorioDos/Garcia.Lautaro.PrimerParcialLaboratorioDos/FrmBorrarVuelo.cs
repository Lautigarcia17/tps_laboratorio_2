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
    public partial class FrmBorrarVuelo : FrmAgregarVuelo
    {
        private Vuelo vueloABorrar;

        public Vuelo VueloABorrar
        {
            get
            {
                return this.vueloABorrar;
            }

            set
            {
                this.vueloABorrar = value;
            }
        }


        public FrmBorrarVuelo(Vuelo vueloABorrar)
        {
            InitializeComponent();
            this.vueloABorrar = vueloABorrar;
        }

        private void FrmBorrarVuelo_Load(object sender, EventArgs e)
        {
            this.cmbAeronave.Items.Clear(); // borrar datos pre-cargados

            this.cmbOrigen.Items.Add(this.vueloABorrar.CiudadPartida);
            this.cmbDestino.Items.Add(this.vueloABorrar.CiudadDeDestino);
            this.cmbAeronave.Items.Add(this.vueloABorrar.Avion.Matricula);

            this.cmbAeronave.SelectedIndex = 0; // aparezca primero
            this.cmbOrigen.SelectedIndex = 0; // aparezca primero
            this.cmbDestino.SelectedIndex = 0; // aparezca primero

            this.dtpFechaVuelo.Value = this.vueloABorrar.FechaVuelo;

            this.rbInternacional.Enabled = false;
            this.rbNacional.Enabled = false;
            this.dtpFechaVuelo.Enabled = false;
            this.cmbAeronave.Enabled = false;
            this.btnAgregar.Text = "Borrar";
        }


        protected override void btnAgregar_Click(object sender, EventArgs e) // borrar
        {
            if (MessageBox.Show("Esta seguro de eliminar el vuelo ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.OK;
            }
        }


    }
}
