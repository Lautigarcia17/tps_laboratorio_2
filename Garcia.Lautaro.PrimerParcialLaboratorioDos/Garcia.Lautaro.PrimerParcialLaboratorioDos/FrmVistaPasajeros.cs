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
    public partial class FrmVistaPasajeros : FrmPasajeros
    {
        private List<Pasajero> pasajerosAMostrar;
        public FrmVistaPasajeros(List<Pasajero> pasajeros, string nombrePasajeros)
        {
            InitializeComponent();

            base.btnAgregar.Visible = false;
            base.btnBorrar.Visible = false;
            base.btnModificar.Visible = false;
            base.dtgPasajeros.Columns[0].Visible = false;
            this.dtgPasajeros.Columns[5].Visible = true;

            this.pasajerosAMostrar = pasajeros;
            this.lblTipoPasajero.Text = nombrePasajeros;
        }

        private void FrmVistaPasajeros_Load(object sender, EventArgs e)
        {
            base.CargarPasajeros(this.pasajerosAMostrar);
        }
    }
}

