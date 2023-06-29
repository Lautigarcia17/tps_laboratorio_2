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
    public partial class FrmAgregarAeronave : FrmBase
    {
        private Aeronave aeronaveAgregar;


        public Aeronave AeronaveAgregar
        {
            get
            {
                return this.aeronaveAgregar;
            }

            set
            {
                this.aeronaveAgregar = value;
            }
        }

        public FrmAgregarAeronave()
        {
            InitializeComponent();
            this.aeronaveAgregar = new Aeronave();
        }
        private void FrmAgregarAeronave_Load(object sender, EventArgs e)
        {
            base.btnModificar.Visible = false;
            base.btnBorrar.Visible = false;
        }
        protected override void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Validar.ValidarCamposCompletos(this.txtCantidadAsientos.Text, this.txtCantidadBanios.Text, this.txtCapacidadBodega.Text))
            {
                this.aeronaveAgregar = this.CrearAeronave();
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Error. Faltan completar campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void txtCantidadAsientos_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.ValidarIngresoNumerosForm(e);
        }


        private void txtCantidadBanios_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.ValidarIngresoNumerosForm(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.ValidarIngresoNumerosForm(e);
        }

        private Aeronave CrearAeronave()
        {
            Aeronave nuevaAeronave = new Aeronave(int.Parse(this.txtCantidadAsientos.Text), int.Parse(this.txtCantidadBanios.Text),
                                                  this.chkInternet.Checked, this.chkComida.Checked, int.Parse(this.txtCapacidadBodega.Text));

            return nuevaAeronave;
        }
    }
}
