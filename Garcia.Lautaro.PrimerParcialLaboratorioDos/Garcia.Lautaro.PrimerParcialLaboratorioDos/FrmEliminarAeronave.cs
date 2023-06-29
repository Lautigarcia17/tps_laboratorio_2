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
    public partial class FrmEliminarAeronave : FrmAgregarAeronave
    {
        private Aeronave aeronaveABorrar;
        public Aeronave AeronaveABorrar
        {
            get { return this.aeronaveABorrar; }
            set { this.aeronaveABorrar = value; }
        }
        public FrmEliminarAeronave(Aeronave aeronave)
        {
            InitializeComponent();
            this.aeronaveABorrar = aeronave;
            this.btnAgregar.Text = "Eliminar";
        }

        private void FrmEliminarAeronave_Load(object sender, EventArgs e)
        {
            this.lblAeronave.Text += this.aeronaveABorrar.Matricula;
            this.txtCantidadAsientos.Text = (aeronaveABorrar.CantidadAsientos).ToString();
            this.txtCantidadBanios.Text = (aeronaveABorrar.CantidadBanios).ToString();
            this.txtCapacidadBodega.Text = (aeronaveABorrar.CapacidadBodega).ToString();
            this.chkInternet.Checked = aeronaveABorrar.OfreceInternet;
            this.chkComida.Checked = aeronaveABorrar.OfreceComida;


            this.txtCantidadAsientos.Enabled = false;
            this.txtCantidadBanios.Enabled = false;
            this.txtCapacidadBodega.Enabled = false;
            this.chkComida.Enabled = false;
            this.chkInternet.Enabled = false;

        }


        protected override void btnAgregar_Click(object sender, EventArgs e) // eliminar
        {
            if (MessageBox.Show("Esta seguro de eliminar la aeronave ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Yes;
            }
        }

    }
}
