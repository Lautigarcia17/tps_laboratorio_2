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
    public partial class FrmModificarPasajero : FrmAgregarPasajero
    {
        private Pasajero pasajeroAModificar;

        public Pasajero PasajeroAModificar
        {
            get
            {
                return this.pasajeroAModificar;
            }

            set
            {
                this.pasajeroAModificar = value;
            }
        }
        public FrmModificarPasajero(Pasajero pasajero)
        {
            InitializeComponent();
            this.pasajeroAModificar = pasajero;
        }

        private void FrmModificarPasajero_Load(object sender, EventArgs e)
        {
            base.btnAgregar.Text = "Modificar";
            this.txtNombre.Text = this.pasajeroAModificar.Nombre;
            this.txtApellido.Text = this.pasajeroAModificar.Apellido;
            this.txtDni.Text = this.pasajeroAModificar.Dni.ToString();
            this.txtDni.Enabled = false;
            this.txtEdad.Text = this.pasajeroAModificar.Edad.ToString();
        }

        protected override void btnAgregar_Click(object sender, EventArgs e) // modifica
        {
            if (Validar.ValidarCamposCompletos(this.txtNombre.Text, this.txtApellido.Text, this.txtDni.Text, this.txtEdad.Text))
            {
                if (Validar.VerificarCambios(this.pasajeroAModificar, this.txtNombre.Text, this.txtApellido.Text, this.txtDni.Text, this.txtEdad.Text)
                    && MessageBox.Show("Esta seguro de modificar el pasajero ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.pasajeroAModificar.Nombre = this.txtNombre.Text;
                    this.pasajeroAModificar.Apellido = this.txtApellido.Text;
                    this.pasajeroAModificar.Dni = int.Parse(this.txtDni.Text);
                    this.pasajeroAModificar.Edad = int.Parse(this.txtEdad.Text);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("No se realizaron cambios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            else
            {
                MessageBox.Show("Error. Faltan completar campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
