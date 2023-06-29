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
    public partial class FrmModificarAeronave : FrmAgregarAeronave
    {
        private Aeronave aeronaveAModificar;

        public Aeronave AeronaveAModificar
        {
            get
            {
                return this.aeronaveAModificar;
            }

            set
            {
                this.aeronaveAModificar = value;
            }
        }

        public FrmModificarAeronave(Aeronave aeronave)
        {
            InitializeComponent();
            this.aeronaveAModificar = aeronave;
            this.btnAgregar.Text = "Modificar";
        }

        private void FrmModificarAeronave_Load(object sender, EventArgs e)
        {
            this.lblAeronave.Text += this.aeronaveAModificar.Matricula;
            this.txtCantidadAsientos.Text = this.aeronaveAModificar.CantidadAsientos.ToString();
            this.txtCantidadBanios.Text = this.aeronaveAModificar.CantidadBanios.ToString();
            this.txtCapacidadBodega.Text = this.aeronaveAModificar.CapacidadBodega.ToString();
            this.chkComida.Checked = this.aeronaveAModificar.OfreceComida;
            this.chkInternet.Checked = this.aeronaveAModificar.OfreceInternet;
        }

        protected override void btnAgregar_Click(object sender, EventArgs e) // modificar
        {
            this.ModificarAeronave();
        }



        private void ModificarAeronave()
        {
            if (Validar.ValidarCamposCompletos(this.txtCantidadAsientos.Text, this.txtCantidadBanios.Text, this.txtCapacidadBodega.Text))
            {
                if (Validar.VerificarCambios(aeronaveAModificar, this.txtCantidadAsientos.Text, this.txtCantidadBanios.Text, this.txtCapacidadBodega.Text, this.chkComida.Checked, this.chkInternet.Checked) == true &&
                    MessageBox.Show("Esta seguro de modificar la aeronave ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.aeronaveAModificar.CantidadAsientos = int.Parse(txtCantidadAsientos.Text);
                    this.aeronaveAModificar.CantidadBanios = int.Parse(txtCantidadBanios.Text);
                    this.aeronaveAModificar.OfreceInternet = this.chkInternet.Checked;
                    this.aeronaveAModificar.OfreceComida = this.chkComida.Checked;
                    this.aeronaveAModificar.CapacidadBodega = int.Parse(txtCapacidadBodega.Text);

                    DialogResult = DialogResult.Yes;
                }
                else
                {
                    MessageBox.Show("No se realizo ningun cambio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Error. Faltan completar campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
