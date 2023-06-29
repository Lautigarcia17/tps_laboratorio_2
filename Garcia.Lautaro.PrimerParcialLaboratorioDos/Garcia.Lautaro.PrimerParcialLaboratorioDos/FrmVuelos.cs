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
    public partial class FrmVuelos : FrmBase
    {
        private List<Vuelo> listaDeVuelos;
        private List<Aeronave> listaDeAviones;
        private List<Pasajero> listaPasajeros;
        public FrmVuelos(Usuario usuarioSistema)
        {
            this.InitializeComponent();
            this.listaDeVuelos = Archivos.LeerDeXmlVuelos();
            this.listaDeAviones = Archivos.LeerJsonAeronave();
            this.listaPasajeros = Archivos.LeerXmlPasajeros();

            if (usuarioSistema.Perfil == "vendedor")
            {
                base.btnAgregar.Visible = false;
                base.btnModificar.Visible = false;
                base.btnBorrar.Visible = false;
            }
            else
            {
                this.btnComprarPasaje.Visible = false;
            }
            this.btnComprarPasaje.BackColor = Color.FromArgb(255, 128, 0);
        }

        private void FrmVuelos_Load(object sender, EventArgs e)
        {
            this.CargarVuelos(this.listaDeVuelos);
            this.dtgListaVuelos.Columns[6].ToolTipText = "Click sobre una celda para ver datos del Avion";
            this.dtgListaVuelos.Columns[11].ToolTipText = "Click sobre una celda para ver los pasajeros";
            this.sugerenciaToolTipVuelo.SetToolTip(this.btnAgregar, "Agregar Vuelo");
            this.sugerenciaToolTipVuelo.SetToolTip(this.btnModificar, "Modificar Vuelo");
            this.sugerenciaToolTipVuelo.SetToolTip(this.btnBorrar, "Eliminar Vuelo");
            this.sugerenciaToolTipVuelo.SetToolTip(this.btnVolver, "Volver al Menu Principal");
        }



        private void dtgListaVuelos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexColumna = e.ColumnIndex;
            int indexFila = e.RowIndex;

            this.GestionarClickListaVuelo(indexColumna, indexFila);
        }
        protected override void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarVuelo formAgrega = new FrmAgregarVuelo();

            if (formAgrega.ShowDialog() == DialogResult.OK)
            {
                formAgrega.VueloAgregar.Avion.AcrementarContadorVuelosDelAeronave(this.listaDeVuelos, formAgrega.VueloAgregar.Avion);
                formAgrega.VueloAgregar.Avion.ActualizarContadorDeVuelosPorAvion(this.listaDeAviones, formAgrega.VueloAgregar.Avion);
                this.listaDeVuelos += formAgrega.VueloAgregar;

                Archivos.GuardarXmlPasajeros(this.listaPasajeros);
                Archivos.GuardarXmlVuelos(this.listaDeVuelos);
                this.CargarVuelos(this.listaDeVuelos);
            }
        }

        protected override void btnModificar_Click(object sender, EventArgs e)
        {
            int index = dtgListaVuelos.CurrentCell.RowIndex;
            string? codigo = dtgListaVuelos.Rows[index].Cells[1].Value.ToString();

            if (!string.IsNullOrEmpty(codigo))
            {
                Vuelo vueloAModificar = this.EncontrarVuelo(listaDeVuelos, codigo);

                if (vueloAModificar.CodigoVuelo != string.Empty && vueloAModificar.EstadoVuelo == ETipoEstadoVuelo.Proximo.ToString())
                {
                    if (vueloAModificar.Pasajeros.Count == 0)
                    {
                        FrmModificarVuelo formModificar = new FrmModificarVuelo(this.listaDeAviones, vueloAModificar);
                        if (formModificar.ShowDialog() == DialogResult.Yes)
                        {
                            this.listaDeVuelos[this.ObtenerIndiceVuelo(this.listaDeVuelos, vueloAModificar)] = formModificar.VueloAModificar;
                            Archivos.GuardarXmlVuelos(this.listaDeVuelos);
                            this.CargarVuelos(this.listaDeVuelos);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se puede modificar un vuelo con pasajeros cargados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    MessageBox.Show("No se puede eliminar un vuelo realizado o despegado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        protected override void btnBorrar_Click(object sender, EventArgs e)
        {
            int index = this.dtgListaVuelos.CurrentCell.RowIndex;
            string? codigo = this.dtgListaVuelos.Rows[index].Cells[1].Value.ToString();

            if (!(string.IsNullOrEmpty(codigo)))
            {
                Vuelo vueloABorrar = this.EncontrarVuelo(listaDeVuelos, codigo);

                if (vueloABorrar.CodigoVuelo != string.Empty && vueloABorrar.EstadoVuelo == ETipoEstadoVuelo.Proximo.ToString())
                {
                    FrmBorrarVuelo formBorrar = new FrmBorrarVuelo(vueloABorrar);
                    if (formBorrar.ShowDialog() == DialogResult.OK)
                    {
                        formBorrar.VueloABorrar.Avion.DescontarContadorVuelosDelAeronave(this.listaDeVuelos, formBorrar.VueloABorrar.Avion);
                        formBorrar.VueloABorrar.Avion.ActualizarContadorDeVuelosPorAvion(this.listaDeAviones, formBorrar.VueloABorrar.Avion);

                        this.listaDeVuelos -= formBorrar.VueloABorrar;

                        this.DescontarVuelosDelPasajero(formBorrar.VueloABorrar); // descuento la cantidad de vuelos del pasajero

                        Archivos.GuardarXmlVuelos(this.listaDeVuelos);
                        Archivos.GuardarXmlPasajeros(this.listaPasajeros); // guardo el descuento de el contador de vuelos del pasajero
                        this.CargarVuelos(this.listaDeVuelos);
                    }
                }
                else
                {
                    MessageBox.Show("No se puede eliminar un vuelo realizado o despegado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnComprarPasaje_Click(object sender, EventArgs e)
        {
            int index = this.dtgListaVuelos.CurrentCell?.RowIndex ?? -1;

            if (index != -1)
            {
                string? codigo = this.dtgListaVuelos.Rows[index].Cells[1].Value.ToString();
                if (!string.IsNullOrEmpty(codigo))
                {
                    Vuelo vueloACargarPasajero = this.EncontrarVuelo(this.listaDeVuelos, codigo);

                    if (vueloACargarPasajero.CodigoVuelo != string.Empty && vueloACargarPasajero.EstadoVuelo == ETipoEstadoVuelo.Proximo.ToString())
                    {
                        if (vueloACargarPasajero.Pasajeros.Count < vueloACargarPasajero.Avion.CantidadAsientos)
                        {
                            FrmComprarPasaje frmComprar = new FrmComprarPasaje(vueloACargarPasajero);
                            if (frmComprar.ShowDialog() == DialogResult.Yes && frmComprar.Comprador.Dni != 0)
                            {
                                if (frmComprar.EsPremium)
                                {
                                    vueloACargarPasajero.PasajerosPremium += frmComprar.Comprador;
                                }
                                else
                                {
                                    vueloACargarPasajero.PasajerosTurista += frmComprar.Comprador;
                                }
                                vueloACargarPasajero.Pasajeros += frmComprar.Comprador;

                                Archivos.GuardarXmlVuelos(this.listaDeVuelos);
                                this.CargarVuelos(this.listaDeVuelos);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se pueden comprar mas pasajes debido a que no hay mas asientos disponibles", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se puede comprar mas pasajes de este vuelo debido a que ya despego/finalizo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            else
            {
                MessageBox.Show("Debe Seleccionar primero un vuelo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }





        public void GestionarClickListaVuelo(int indexColumna, int indexFila)
        {
            if (indexColumna >= 0 & indexFila >= 0 && indexColumna < this.dtgListaVuelos.ColumnCount)
            {
                switch (indexColumna)
                {
                    case 6:
                        this.MostrarAeronaveDataGrid(indexColumna, indexFila);
                        break;
                    case 7:
                        this.MostrarPasajerosDataGrid(indexFila, "Premium");
                        break;
                    case 8:
                        this.MostrarPasajerosDataGrid(indexFila, "Turista");
                        break;
                    case 11:
                        this.MostrarPasajerosDataGrid(indexFila, "Lista Pasajeros");
                        break;
                }
            }
        }

        private Vuelo EncontrarVuelo(List<Vuelo> lista, string codigoVuelo)
        {
            Vuelo vueloEncontrado = new Vuelo();

            foreach (Vuelo item in lista)
            {
                if (item == codigoVuelo)
                {
                    vueloEncontrado = item;
                    break;
                }
            }
            return vueloEncontrado;
        }
        private int ObtenerIndiceVuelo(List<Vuelo> lista, Vuelo vuelo) // agregar sobrecarga de lista con vuelo
        {
            int indice = -1;

            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].CodigoVuelo == vuelo.CodigoVuelo)
                {
                    indice = i;
                    break;
                }
            }
            return indice;
        }



        private void CargarVuelos(List<Vuelo> listaDeVuelos)
        {
            this.dtgListaVuelos.Rows.Clear();
            foreach (Vuelo item in listaDeVuelos)
            {
                this.GenerarEstadoVuelo(item);
                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(this.dtgListaVuelos);
                fila.Cells[0].Value = item.EstadoVuelo;
                fila.Cells[1].Value = item.CodigoVuelo;
                fila.Cells[2].Value = item.CiudadPartida;
                fila.Cells[3].Value = item.CiudadDeDestino;
                fila.Cells[4].Value = item.FechaVuelo.ToString("d/M/yyyy HH\\:mm");
                fila.Cells[5].Value = item.DuracionVuelo.ToString("hh\\:mm");
                fila.Cells[6].Value = item.Avion.Matricula;
                fila.Cells[7].Value = item.PasajerosPremium.Count + " / " + item.CantidadAsientosPremium;
                fila.Cells[8].Value = item.PasajerosTurista.Count + " / " + item.CantidadAsientosTurista;
                fila.Cells[9].Value = "$ " + item.CostoTurista;
                fila.Cells[10].Value = "$ " + item.CostoPremium;
                fila.Cells[11].Value = item.Pasajeros.Count + " / " + item.Avion.CantidadAsientos;
                this.dtgListaVuelos.Rows.Add(fila);
            }
        }



        private void GenerarEstadoVuelo(Vuelo vuelo)
        {
            DateTime fechaVuelo = vuelo.FechaVuelo;
            DateTime hoy = DateTime.Now;

            DateTime fechaLlegadaEstimada = fechaVuelo.AddHours(vuelo.DuracionVuelo.Hours);
            fechaLlegadaEstimada = fechaLlegadaEstimada.AddMinutes(vuelo.DuracionVuelo.Minutes);

            if (hoy > fechaVuelo && fechaLlegadaEstimada > hoy)
            {
                vuelo.EstadoVuelo = ETipoEstadoVuelo.Despego.ToString();
            }
            else if (hoy > fechaVuelo)
            {
                vuelo.EstadoVuelo = ETipoEstadoVuelo.Finalizado.ToString();
            }
        }

        private void DescontarVuelosDelPasajero(Vuelo pasajerosDelVuelo)
        {
            foreach (Pasajero pasajeroVuelo in pasajerosDelVuelo.Pasajeros)
            {
                foreach (Pasajero pasajeroLista in this.listaPasajeros)
                {
                    if (pasajeroVuelo == pasajeroLista)
                    {
                        pasajeroLista.CantidadVuelosComprados--;
                        break;
                    }
                }
            }
        }

        private void MostrarPasajerosDataGrid(int indexFila, string tipoPasajero)
        {
            string? datosPasajerosVuelo = this.dtgListaVuelos.Rows[indexFila].Cells[1].Value.ToString(); // ? admite valores nulos
            if (!string.IsNullOrEmpty(datosPasajerosVuelo))
            {
                Vuelo vuelo = this.EncontrarVuelo(this.listaDeVuelos, datosPasajerosVuelo);
                if (vuelo.CodigoVuelo != string.Empty)
                {
                    if (vuelo.Pasajeros.Count == 0)
                    {
                        MessageBox.Show("No hay pasajeros Cargados");
                    }
                    else
                    {
                        List<Pasajero> lista;

                        switch (tipoPasajero)
                        {
                            case "Premium":
                                lista = vuelo.PasajerosPremium;
                                break;
                            case "Turista":
                                lista = vuelo.PasajerosTurista;
                                break;
                            default:
                                lista = vuelo.Pasajeros;
                                break;
                        }

                        FrmVistaPasajeros vista = new FrmVistaPasajeros(lista, tipoPasajero);
                        vista.ShowDialog();
                    }
                }
            }
        }

        private void MostrarAeronaveDataGrid(int indexColumna, int indexFila)
        {
            string? datosAeronaveSeleccionada = this.dtgListaVuelos.Rows[indexFila].Cells[indexColumna].Value.ToString(); // ? admite valores nulos

            if (!string.IsNullOrEmpty(datosAeronaveSeleccionada))
            {
                Aeronave avion = new Aeronave();
                avion = avion.EncontrarAeronave(this.listaDeAviones, datosAeronaveSeleccionada);
                if (avion.Matricula != string.Empty)
                {
                    MessageBox.Show(avion.ToString());
                }
            }

        }
    }
}
