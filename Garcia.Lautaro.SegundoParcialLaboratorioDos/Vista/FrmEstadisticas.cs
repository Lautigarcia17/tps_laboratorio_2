using Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmEstadisticas : FrmBase
    {
        private delegate Dictionary<string, int> DelegadoCarga();

        public FrmEstadisticas()
        {
            InitializeComponent();
            this.btnMinimizar.Visible = false;
            this.btnMaximizar.Visible = false;
            this.btnCerrar.Visible = false;
            this.btnIniciar.Visible = false;
        }



        private void FrmEstadisticas_Load(object sender, EventArgs e)
        {
            try
            {
                FrmEstadisticas.CargarRankingDataGrid(JugadorDao.LeerCantidadVictoriasJugador, this.dtgRankingVictorias);
                FrmEstadisticas.CargarRankingDataGrid(JugadorDao.LeerCantidadEmpatesJugador, this.dtgRankingEmpates);
                FrmEstadisticas.CargarRankingDataGrid(JugadorDao.LeerCantidadDerrotasJugador, this.dtgRankingDerrotas);
                FrmEstadisticas.CargarRankingDataGrid(JugadorDao.LeerPuntajeTotalJugador, this.dtgPuntajesTotales);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private static void CargarRankingDataGrid(DelegadoCarga leerDatos, DataGridView tabla)
        {
            Dictionary<string, int> datos = leerDatos.Invoke();
            datos = datos.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);// ordena y crea un nuevo diccionario , pisando el anterior
            FrmEstadisticas.CargarDataGrids(datos, tabla);
        }



        private static void CargarDataGrids(Dictionary<string, int> datos, DataGridView tabla)
        {
            tabla.Rows.Clear();
            foreach (KeyValuePair<string, int> item in datos)
            {
                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(tabla);
                fila.Cells[0].Value = item.Key;
                fila.Cells[1].Value = item.Value;

                tabla.Rows.Add(fila);
            }

        }

    }
}
