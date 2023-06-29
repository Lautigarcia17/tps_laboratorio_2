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
    public partial class FrmPasajeros : FrmBase
    {
        private List<Pasajero> listaPasajeros;
        private List<Vuelo> listaVuelos;
        public FrmPasajeros()
        {
            InitializeComponent();
            this.listaPasajeros = Archivos.LeerXmlPasajeros();
            this.listaVuelos = Archivos.LeerDeXmlVuelos();
        }
        private void FrmPasajeros_Load(object sender, EventArgs e)
        {
            this.CargarPasajeros(this.listaPasajeros);
        }


        protected override void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarPasajero frmAgregar = new FrmAgregarPasajero();

            if (frmAgregar.ShowDialog() == DialogResult.OK)
            {
                if (this.listaPasajeros != frmAgregar.PasajeroAgregar)
                {
                    this.listaPasajeros += frmAgregar.PasajeroAgregar;
                    Archivos.GuardarXmlPasajeros(this.listaPasajeros);
                    this.CargarPasajeros(this.listaPasajeros);
                }
                else
                {
                    MessageBox.Show("El pasajero ya fue cargado anteriormente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

        }
        protected override void btnModificar_Click(object sender, EventArgs e)
        {
            Pasajero pasajeroModificar = this.EncontrarPasajeroPorDataGrid();
            if (pasajeroModificar.Dni != 0)
            {
                FrmModificarPasajero frmModificar = new FrmModificarPasajero(pasajeroModificar);

                if (frmModificar.ShowDialog() == DialogResult.OK)
                {
                    int indice = pasajeroModificar.ObtenerIndicePasajero(this.listaPasajeros, pasajeroModificar);
                    if (indice != -1)
                    {
                        this.listaPasajeros[indice] = frmModificar.PasajeroAModificar;
                        this.ActualizarPasajerosVuelo(this.listaVuelos, frmModificar.PasajeroAModificar);
                        Archivos.GuardarXmlVuelos(this.listaVuelos);
                        Archivos.GuardarXmlPasajeros(this.listaPasajeros);
                        this.CargarPasajeros(this.listaPasajeros);
                    }
                }
            }

        }

        protected override void btnBorrar_Click(object sender, EventArgs e)
        {
            Pasajero pasajeroBorrrar = this.EncontrarPasajeroPorDataGrid();
            if (pasajeroBorrrar.Dni != 0)
            {
                FrmBorrarPasajero frmBorrar = new FrmBorrarPasajero(pasajeroBorrrar);
                if (frmBorrar.ShowDialog() == DialogResult.Yes)
                {
                    this.listaPasajeros -= frmBorrar.PasajeroABorrar;
                    this.BorrarPasajeroVuelo(this.listaVuelos, frmBorrar.PasajeroABorrar);
                    Archivos.GuardarXmlVuelos(this.listaVuelos);
                    Archivos.GuardarXmlPasajeros(this.listaPasajeros);
                    this.CargarPasajeros(this.listaPasajeros);
                }
            }

        }

        protected void CargarPasajeros(List<Pasajero> listaDePasajeros)
        {
            this.dtgPasajeros.Rows.Clear();
            foreach (Pasajero item in listaDePasajeros)
            {
                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(this.dtgPasajeros);
                fila.Cells[0].Value = item.CantidadVuelosComprados;
                fila.Cells[1].Value = item.Dni;
                fila.Cells[2].Value = item.Nombre;
                fila.Cells[3].Value = item.Apellido;
                fila.Cells[4].Value = item.Edad;
                fila.Cells[5].Value = item.Equipaje;
                this.dtgPasajeros.Rows.Add(fila);
            }
        }

        private Pasajero EncontrarPasajeroPorDataGrid()
        {
            int index = this.dtgPasajeros.CurrentCell.RowIndex;
            int dni = (int)this.dtgPasajeros.Rows[index].Cells[1].Value;

            Pasajero pasajeroEncontrado = new Pasajero();
            pasajeroEncontrado = pasajeroEncontrado.EncontrarPasajero(this.listaPasajeros, dni);

            return pasajeroEncontrado;
        }

        private void ActualizarPasajerosVuelo(List<Vuelo> listaVuelos, Pasajero pasajeroActualizado)
        {
            foreach (Vuelo vuelo in listaVuelos)
            {
                foreach (Pasajero pasajero in vuelo.Pasajeros)
                {
                    if (pasajero == pasajeroActualizado)
                    {
                        pasajero.Nombre = pasajeroActualizado.Nombre;
                        pasajero.Apellido = pasajeroActualizado.Apellido;
                        pasajero.Dni = pasajeroActualizado.Dni;
                        pasajero.Edad = pasajeroActualizado.Edad;
                        break;
                    }
                }
                foreach (Pasajero pasajeroT in vuelo.PasajerosTurista)
                {
                    if (pasajeroT == pasajeroActualizado)
                    {
                        pasajeroT.Nombre = pasajeroActualizado.Nombre;
                        pasajeroT.Apellido = pasajeroActualizado.Apellido;
                        pasajeroT.Dni = pasajeroActualizado.Dni;
                        pasajeroT.Edad = pasajeroActualizado.Edad;
                        break;
                    }
                }
                foreach (Pasajero pasajeroP in vuelo.PasajerosPremium)
                {
                    if (pasajeroP == pasajeroActualizado)
                    {
                        pasajeroP.Nombre = pasajeroActualizado.Nombre;
                        pasajeroP.Apellido = pasajeroActualizado.Apellido;
                        pasajeroP.Dni = pasajeroActualizado.Dni;
                        pasajeroP.Edad = pasajeroActualizado.Edad;
                        break;
                    }
                }
            }
        }
        private void BorrarPasajeroVuelo(List<Vuelo> listaVuelos, Pasajero pasajeroAQuitar)
        {
            foreach (Vuelo vuelo in listaVuelos)
            {
                foreach (Pasajero pasajero in vuelo.Pasajeros)
                {
                    if (pasajero == pasajeroAQuitar)
                    {
                        vuelo.Pasajeros.Remove(pasajero);
                        break;
                    }
                }
                foreach (Pasajero pasajeroP in vuelo.PasajerosPremium)
                {
                    if (pasajeroP == pasajeroAQuitar)
                    {
                        vuelo.PasajerosPremium.Remove(pasajeroP);
                        break;
                    }
                }
                foreach (Pasajero pasajeroT in vuelo.PasajerosTurista)
                {
                    if (pasajeroT == pasajeroAQuitar)
                    {
                        vuelo.PasajerosTurista.Remove(pasajeroT);
                        break;
                    }
                }
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(this.txtFilter.Text)))
            {
                string palabraFiltro = txtFilter.Text;

                if (!(String.IsNullOrEmpty(palabraFiltro)))
                {
                    this.FiltrarDataGrid(palabraFiltro);
                }
            }
            else
            {
                this.ResetearDataGrid();
            }


        }

        private void FiltrarDataGrid(string palabraFiltro)
        {
            palabraFiltro = palabraFiltro.ToLower();
            foreach (DataGridViewRow row in this.dtgPasajeros.Rows) // recorre cada fila
            {
                string? nombreColumna = row.Cells[2].Value.ToString(); // guarda el contenido de la fila
                string? apellidoColumna = row.Cells[3].Value.ToString(); // guarda el contenido de la fila

                if (!(String.IsNullOrEmpty(nombreColumna)) && !(String.IsNullOrEmpty(apellidoColumna)))
                {
                    nombreColumna = nombreColumna.ToLower();
                    apellidoColumna = apellidoColumna.ToLower();

                    row.Visible = nombreColumna.Contains(palabraFiltro) || apellidoColumna.Contains(palabraFiltro); // pregunta si el caracter ingresado esta en la palabra, si es true muestra
                }
            }

        }

        private void ResetearDataGrid()
        {
            this.dtgPasajeros.ClearSelection();
            foreach (DataGridViewRow item in this.dtgPasajeros.Rows)
            {
                item.Visible = true;
            }
        }


    }
}
