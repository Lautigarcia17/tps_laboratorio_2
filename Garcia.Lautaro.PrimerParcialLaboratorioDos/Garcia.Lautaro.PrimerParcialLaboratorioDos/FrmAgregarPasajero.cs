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
    public partial class FrmAgregarPasajero : FrmBase
    {
        private Pasajero pasajeroAgregar;
        private bool dniValido;
        public Pasajero PasajeroAgregar
        {
            get { return this.pasajeroAgregar; }
            set { this.pasajeroAgregar = value; }
        }

        public FrmAgregarPasajero()
        {
            InitializeComponent();
            this.pasajeroAgregar = new Pasajero();
        }

        private void FrmAgregarPasajero_Load(object sender, EventArgs e)
        {
            base.btnModificar.Visible = false;
            base.btnBorrar.Visible = false;
        }

        protected override void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.dniValido == true)
            {
                if (Validar.ValidarCamposCompletos(this.txtNombre.Text, this.txtApellido.Text, this.txtDni.Text, this.txtEdad.Text))
                {
                    this.pasajeroAgregar = this.CrearPasajero();
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Error. Faltan completar campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El dni requiere como minimo 8 numeros", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.ValidarIngresoLetrasForm(e);
        }
        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.ValidarIngresoLetrasForm(e);
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.ValidarIngresoNumerosForm(e);
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.ValidarIngresoNumerosForm(e);

        }
        private void txtDni_Leave(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txtDni.Text)) && Validar.ValidarDniMinimo(this.txtDni.Text.Length) == false)
            {
                MessageBox.Show("El dni requiere como minimo 7 numeros", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dniValido = false;
            }
            else
            {
                this.dniValido = true;
            }
        }


        private Pasajero CrearPasajero()
        {
            return new Pasajero(this.txtNombre.Text, this.txtApellido.Text, int.Parse(this.txtDni.Text), int.Parse(this.txtEdad.Text));
        }


    }
}
