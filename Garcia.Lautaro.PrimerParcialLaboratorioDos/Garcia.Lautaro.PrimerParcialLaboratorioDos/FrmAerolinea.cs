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
    public partial class FrmAerolinea : Form
    {
        private bool estadoCierre;
        private Usuario usuarioSistema;
        public FrmAerolinea()
        {
            InitializeComponent();
            this.Enabled = false;
            this.estadoCierre = false;
            this.usuarioSistema = new Usuario();
        }

        private void FrmAerolinea_Load(object sender, EventArgs e)
        {
            this.Logear();

            this.sugerenciaToolTip.SetToolTip(this.btnVuelos, "Manejador de Vuelos");
            this.lblHora.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }




        private void btnVuelos_Click(object sender, EventArgs e)
        {
            FrmVuelos frmVuelos = new FrmVuelos(this.usuarioSistema);
            frmVuelos.ShowDialog();
        }

        private void btnPasajeros_Click(object sender, EventArgs e)
        {
            FrmPasajeros frmPasajeros = new FrmPasajeros();
            frmPasajeros.ShowDialog();
        }

        private void btnListaAeronaves_Click(object sender, EventArgs e)
        {
            FrmAeronaves frmAeronaves = new FrmAeronaves();
            frmAeronaves.ShowDialog();
        }
        private void btnEstadisticasHistoricas_Click(object sender, EventArgs e)
        {
            FrmEstadisticasHistoricas frmEstadisticas = new FrmEstadisticasHistoricas();
            frmEstadisticas.ShowDialog();
        }
        private void FrmAerolinea_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.estadoCierre == false)
            {
                DialogResult respuesta = MessageBox.Show("¿Esta seguro de salir de la aplicacion?", "Atencion!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }

        }
        private void FuncionalidadSegunPerfil()
        {
            switch (this.usuarioSistema.Perfil)
            {
                case "vendedor":
                    this.btnVuelos.Visible = true;
                    this.btnPasajeros.Visible = true;
                    this.btnEstadisticasHistoricas.Visible = true;
                    this.btnListaAeronaves.Visible = false;
                    break;
                case "supervisor":
                    this.btnEstadisticasHistoricas.Visible = true;
                    this.btnPasajeros.Visible = true;
                    this.btnVuelos.Visible = false;
                    this.btnListaAeronaves.Visible = false;
                    break;
                case "administrador":
                    this.btnVuelos.Visible= true;
                    this.btnListaAeronaves.Visible = true;
                    this.btnEstadisticasHistoricas.Visible = false;
                    this.btnPasajeros.Visible = false;
                    break;
            }

        }

        private void btnDesloguear_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            this.Logear();
        }
        private void Logear()
        {
            FrmLogin logear = new FrmLogin();

            if (logear.ShowDialog() == DialogResult.OK)
            {
                this.Enabled = true;
                this.lblUsuarioIngresante.Text = $"{logear.Usuario.Nombre} {logear.Usuario.Apellido}  - {logear.Usuario.Perfil.ToUpper()}";
                Archivos.GuardarJsonUsuario(logear.Usuario, DateTime.Now); // guardo usuario log
                this.usuarioSistema = logear.Usuario;

                this.FuncionalidadSegunPerfil();
            }
            else
            {
                this.estadoCierre = true;
                this.Close();
            }

        }


    }
}
