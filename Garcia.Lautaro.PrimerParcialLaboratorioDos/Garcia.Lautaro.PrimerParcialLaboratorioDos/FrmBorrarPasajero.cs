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
    public partial class FrmBorrarPasajero : FrmAgregarPasajero
    {
        private Pasajero pasajeroABorrar;

        public Pasajero PasajeroABorrar
        {
            get
            {
                return this.pasajeroABorrar;
            }

            set
            {
                this.pasajeroABorrar = value;
            }
        }
        public FrmBorrarPasajero(Pasajero pasajero)
        {
            InitializeComponent();
            this.pasajeroABorrar = pasajero;
            this.btnAgregar.Text = "Borrar";
        }

        private void FrmBorrarPasajero_Load(object sender, EventArgs e)
        {
            this.txtNombre.Text = this.pasajeroABorrar.Nombre;
            this.txtApellido.Text = this.pasajeroABorrar.Apellido;
            this.txtDni.Text = this.pasajeroABorrar.Dni.ToString();
            this.txtEdad.Text = this.pasajeroABorrar.Edad.ToString();


            this.txtNombre.Enabled = false;
            this.txtApellido.Enabled = false;
            this.txtDni.Enabled = false;
            this.txtEdad.Enabled = false;
        }

        protected override void btnAgregar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de eliminar al pasajero?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Yes;
            }
        }


    }
}
