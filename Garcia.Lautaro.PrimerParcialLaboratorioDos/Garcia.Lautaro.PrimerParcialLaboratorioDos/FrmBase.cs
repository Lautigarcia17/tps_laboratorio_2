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
    public partial class FrmBase : Form
    {
        public FrmBase()
        {
            InitializeComponent();
            this.btnAgregar.BackColor = Color.DodgerBlue;
            this.btnModificar.BackColor = Color.FromArgb(255, 128, 0);
            this.btnBorrar.BackColor = Color.FromArgb(255, 128, 0);

            this.ControlBox = false;
        }

        protected virtual void btnVolver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        protected virtual void btnAgregar_Click(object sender, EventArgs e) { }

        protected virtual void btnModificar_Click(object sender, EventArgs e) { }

        protected virtual void btnBorrar_Click(object sender, EventArgs e) { }

        protected void ValidarIngresoLetrasForm(KeyPressEventArgs e)  
        {
            if (Validar.ValidarIngresoLetras(e.KeyChar) == false)
            {
                MessageBox.Show("Se debe ingresar solo letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }
        protected void ValidarIngresoNumerosForm(KeyPressEventArgs e)
        {
            if (Validar.ValidarIngresoNumeros(e.KeyChar) == false)
            {
                MessageBox.Show("Se debe ingresar solo numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }


    }
}
