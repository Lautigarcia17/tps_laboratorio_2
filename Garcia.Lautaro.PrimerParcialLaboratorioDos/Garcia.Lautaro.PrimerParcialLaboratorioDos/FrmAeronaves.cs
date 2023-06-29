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
    public partial class FrmAeronaves : FrmBase
    {
        private List<Aeronave> listaAeronaves;
        public FrmAeronaves()
        {
            InitializeComponent();
            this.listaAeronaves = Archivos.LeerJsonAeronave();
        }

        private void FrmAeronaves_Load(object sender, EventArgs e)
        {
            this.CargarAeronaves();
        }


        private void CargarAeronaves()
        {
            this.dtgListaAeronaves.Rows.Clear();
            foreach (Aeronave item in this.listaAeronaves)
            {
                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(this.dtgListaAeronaves);
                fila.Cells[0].Value = item.CantidadVuelos;
                fila.Cells[1].Value = item.Matricula;
                fila.Cells[2].Value = item.CantidadAsientos;
                fila.Cells[3].Value = item.CantidadBanios;
                fila.Cells[4].Value = item.OfreceInternet;
                fila.Cells[5].Value = item.OfreceComida;
                fila.Cells[6].Value = item.CapacidadBodega;
                this.dtgListaAeronaves.Rows.Add(fila);
            }
        }

        protected override void btnAgregar_Click(object sender, EventArgs e)
        {
            this.AgregarAeronave();
        }

        protected override void btnModificar_Click(object sender, EventArgs e)
        {
            this.ModificarAeronave();
        }

        protected override void btnBorrar_Click(object sender, EventArgs e)
        {
            this.EliminarAeronave();
        }


        private void AgregarAeronave()
        {
            FrmAgregarAeronave frmAgregar = new FrmAgregarAeronave();

            if (frmAgregar.ShowDialog() == DialogResult.OK)
            {
                this.listaAeronaves += frmAgregar.AeronaveAgregar;
                Archivos.GuardarJsonAeronave(this.listaAeronaves);
                this.CargarAeronaves();
            }
        }

        private void ModificarAeronave()
        {
            Aeronave aeronaveAModificar = this.EncontrarAeronavePorDataGrid();

            if (aeronaveAModificar.Matricula != string.Empty && aeronaveAModificar.CantidadVuelos == 0)
            {
                FrmModificarAeronave frmModificar = new FrmModificarAeronave(aeronaveAModificar);

                if (frmModificar.ShowDialog() == DialogResult.Yes)
                {
                    int indice = aeronaveAModificar.ObtenerIndiceAeronave(this.listaAeronaves, aeronaveAModificar);
                    if (indice != -1)
                    {
                        this.listaAeronaves[indice] = frmModificar.AeronaveAModificar;
                        Archivos.GuardarJsonAeronave(this.listaAeronaves);
                        this.CargarAeronaves();
                    }
                }
            }
            else
            {
                MessageBox.Show("No se puede modificar una aeronave con vuelos asignados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void EliminarAeronave()
        {

            Aeronave aeronaveABorrar = this.EncontrarAeronavePorDataGrid();
            if (aeronaveABorrar.Matricula != string.Empty)
            {
                if (aeronaveABorrar.CantidadVuelos == 0)
                {
                    FrmEliminarAeronave frmEliminar = new FrmEliminarAeronave(aeronaveABorrar);

                    if (frmEliminar.ShowDialog() == DialogResult.Yes)
                    {
                        this.listaAeronaves -= frmEliminar.AeronaveABorrar;
                        Archivos.GuardarJsonAeronave(this.listaAeronaves);
                        this.CargarAeronaves();
                    }
                }
                else
                {
                    MessageBox.Show("No se puede eliminar una aeronave con vuelos realizados o que hayan despegado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }


        private Aeronave EncontrarAeronavePorDataGrid()
        {
            int index = dtgListaAeronaves.CurrentCell.RowIndex;
            string? matricula = dtgListaAeronaves.Rows[index].Cells[1].Value.ToString();

            Aeronave aeronaveAEncontrar = new Aeronave();
            if (matricula != null)
            {
                aeronaveAEncontrar = aeronaveAEncontrar.EncontrarAeronave(this.listaAeronaves, matricula);
            }

            return aeronaveAEncontrar;
        }

    }
}
