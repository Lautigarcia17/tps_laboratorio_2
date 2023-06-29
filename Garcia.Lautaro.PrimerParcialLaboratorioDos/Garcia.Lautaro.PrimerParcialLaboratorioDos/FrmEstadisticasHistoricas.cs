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
    public partial class FrmEstadisticasHistoricas : FrmBase
    {
        private List<Pasajero> listaPasajeros;
        private List<Vuelo> listaVuelos;

        public FrmEstadisticasHistoricas()
        {
            InitializeComponent();
            base.btnAgregar.Visible = false;
            base.btnBorrar.Visible = false;
            base.btnModificar.Visible = false;

            this.listaPasajeros = Archivos.LeerXmlPasajeros();
            this.listaVuelos = Archivos.LeerDeXmlVuelos();
        }

        private void FrmDatosHistoricos_Load(object sender, EventArgs e)
        {
            this.CargarEstadisticasHistoricas();
        }

        #region Cargar Estadisticas
        private void CargarEstadisticasHistoricas()
        {
            Vuelo vuelo = new Vuelo();

            this.CargarDestinosPorFacturacion();
            this.CargarPasajerosFrecuentes();
            this.CargarPasajerosPorVuelo();
            this.lblDestinoMasElegido.Text += "\n" + vuelo.BuscarDestinoMasElegido(this.listaVuelos);
            this.CargarHorasDeVueloPorAeronave();
            this.CargarGananciasAerolinea();
        }



        private void CargarPasajerosFrecuentes()
        {
            Dictionary<string, int> listadoPasajerosFrecuentes = this.listaPasajeros.ToDictionary(p => $"{p.Dni}  {p.Nombre}  {p.Apellido}", p => p.CantidadVuelosComprados)
                                                                          .OrderByDescending(x => x.Value) // ordena descendentemente
                                                                          .ToDictionary(x => x.Key, x => x.Value); // crea un nuevo diccionario con los cambios
                                                                                                                   // la x => haria referencia a cada clave valor
            this.dtgPasajerosFrecuentes.Rows.Clear();
            foreach (KeyValuePair<string, int> item in listadoPasajerosFrecuentes)
            {
                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(this.dtgPasajerosFrecuentes);
                fila.Cells[0].Value = item.Key;
                fila.Cells[1].Value = item.Value;
                this.dtgPasajerosFrecuentes.Rows.Add(fila);
            }
        }

        private void CargarPasajerosPorVuelo()
        {
            Dictionary<string, int> listadoPasajerosPorVuelo = this.listaVuelos.ToDictionary(p => $"{p.CodigoVuelo} - {p.CiudadPartida} - {p.CiudadDeDestino}", p => p.Pasajeros.Count)
                                                                          .OrderByDescending(x => x.Value) // ordena descendentemente
                                                                          .ToDictionary(x => x.Key, x => x.Value); // crea un nuevo diccionario con los cambios
                                                                                                                   // la x => haria referencia a cada clave valor
            this.dtgCantidadPasajerosPorVuelo.Rows.Clear();
            foreach (KeyValuePair<string, int> item in listadoPasajerosPorVuelo)
            {
                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(this.dtgCantidadPasajerosPorVuelo);
                fila.Cells[0].Value = item.Key;
                fila.Cells[1].Value = item.Value;
                this.dtgCantidadPasajerosPorVuelo.Rows.Add(fila);
            }
        }

        private void CargarGananciasAerolinea()
        {
            Vuelo vueloGanancias = new Vuelo();

            this.lblGananciasTotales.Text += vueloGanancias.SumarGanancias(this.listaVuelos).ToString("0.00");
            this.lblGananciasCabotaje.Text += vueloGanancias.SumarGanancias(this.listaVuelos, true).ToString("0.00");
            this.lblGananciasInternacional.Text += vueloGanancias.SumarGanancias(this.listaVuelos, false).ToString("0.00");
        }


        private void CargarHorasDeVueloPorAeronave()
        {
            Aeronave aeronave = new Aeronave();

            Dictionary<string, TimeSpan> listadoHorasPorAeronave = aeronave.ContarHorasDeVueloPorAeronave(this.listaVuelos);
            listadoHorasPorAeronave = aeronave.OrdenarHorasDeVuelos(listadoHorasPorAeronave);

            this.dtgHorasPorAeronave.Rows.Clear();
            foreach (KeyValuePair<string, TimeSpan> item in listadoHorasPorAeronave)
            {
                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(this.dtgHorasPorAeronave);
                fila.Cells[0].Value = item.Key;
                fila.Cells[1].Value = item.Value;
                this.dtgHorasPorAeronave.Rows.Add(fila);
            }
        }

        private void CargarDestinosPorFacturacion()
        {
            Vuelo vuelo = new Vuelo();
            Dictionary<string, float> destinosPorFacturacion = vuelo.GenerarFacturacionPorDestino(this.listaVuelos);


            this.dtgDestinosPorFacturacion.Rows.Clear();
            foreach (KeyValuePair<string, float> item in destinosPorFacturacion)
            {
                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(this.dtgDestinosPorFacturacion);
                fila.Cells[0].Value = item.Key;
                fila.Cells[1].Value = "$ " + item.Value.ToString("0.00");
                this.dtgDestinosPorFacturacion.Rows.Add(fila);
            }
        }
        #endregion
    }
}
