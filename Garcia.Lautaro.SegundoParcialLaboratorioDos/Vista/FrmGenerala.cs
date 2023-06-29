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

namespace Vista
{
    public partial class FrmGenerala : FrmBase
    {
        private List<Partida> listaPartidas;
        private bool estadoCierre;
        private static string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "partidas.json");
        private CancellationTokenSource cancellationTokenSource;
        private CancellationToken cancellationToken;
        private bool partidaIniciada;

        public event PartidaCancelada eventoNotificarCancelada;

        public FrmGenerala()
        {
            InitializeComponent();
            this.btnVolver.Visible = false;
            this.Enabled = false;
            this.estadoCierre = false;
            this.partidaIniciada = false;
            this.eventoNotificarCancelada += NotificarCancelacion;
            try
            {
                this.listaPartidas = Archivos<List<Partida>>.LecturaJson(FrmGenerala.path);
                this.CargarPartida(this.listaPartidas);
            }
            catch (Exception)
            {
                listaPartidas = new List<Partida>();
            }

        }

        private void FrmGenerala_Load(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                this.Enabled = true;
            }
            else
            {
                this.estadoCierre = true;
                this.Close();
            }
        }

        protected async override void btnIniciar_Click(object sender, EventArgs e)
        {
            cancellationTokenSource = new CancellationTokenSource();
            cancellationToken = cancellationTokenSource.Token;
            Partida inicioPartida = await IniciarHilo();

            if (inicioPartida.Ganador == "")
            {
                this.DeterminarGanador(inicioPartida.JugadorUno, inicioPartida.JugadorDos);
                inicioPartida.Ganador = this.lblJugadorGanador.Text;
                this.RefrezcarPartidas();
                this.partidaIniciada = false;
            }
            else if (inicioPartida.Ganador == "Cancelada")
            {
                this.RefrezcarPartidas();
                this.partidaIniciada = false;
            }

        }
        private async Task<Partida> IniciarHilo()
        {
            Partida partida = new Partida();
            try
            {
                if (cancellationToken.IsCancellationRequested)
                {
                    cancellationToken.ThrowIfCancellationRequested(); // lanza excepcion de cancelacion
                }

                partida = this.EncontrarPartidaDataGrid();
                if (partida.Ganador == "")
                {
                    this.partidaIniciada = true;
                    await this.IniciarPartida(partida, this.dtgTablaJugadorUno, this.dtgTablaJugadorDos);
                }
                else
                {
                    throw new ValidarExcepcion("La partida ya finalizo/cancelo");
                }
            }
            catch (ValidarExcepcion ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (OperationCanceledException)
            {
                this.eventoNotificarCancelada.Invoke("!! Partida cancelada !!");
                partida.Ganador = "Cancelada";
            }
            catch (Exception)
            {
                MessageBox.Show("Surgio un error");
            }

            return partida;
        }
        private void NotificarCancelacion(string mensaje)
        {
            MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK);
        }


        private async Task IniciarPartida(Partida partida, DataGridView tablaJugadorUno, DataGridView tablaJugadorDos)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(async () => await IniciarPartida(partida, tablaJugadorUno, tablaJugadorDos)));
            }
            else
            {
                int contador = 0;
                do
                {
                    this.lblNumeroRonda.Text = (contador + 1).ToString();

                    await this.IniciarRonda(partida.JugadorUno, this.dtgTablaJugadorUno);
                    await this.IniciarRonda(partida.JugadorDos, this.dtgTablaJugadorDos);

                    await Task.Delay(5000);
                    contador++;
                } while (contador < 2);
            }

        }
        private async Task IniciarRonda(Jugador jugador, DataGridView dataGridTabla)
        {
            Tiradas tirada = new Tiradas();
            int contador = 0;
            do
            {
                if (cancellationToken.IsCancellationRequested)
                {
                    cancellationToken.ThrowIfCancellationRequested();
                }
                else
                {
                    tirada.GenerarTirada();
                    this.RefrezcarImagenDado(tirada.ListaDadosTirados);

                    contador++;
                    if (tirada.DetectarTipoTirada(jugador.TablaJugador) != true)
                    {
                        tirada.CargarDadoSeleccionado();
                        if (contador == 3)
                        {
                            tirada.SumarTiradaSinTipo(jugador.TablaJugador); //Si bien es la ultima tirada, selecciono el dado repetido o el mayor, y hago la suma
                        }
                    }
                    this.ActualizarTabla(jugador.TablaJugador, dataGridTabla);
                    this.RefrezcarTabla();
                    Task tarea1 = Task.Delay(5000);
                    await Task.WhenAll(tarea1);
                }


            } while (contador < 3);
        }

        private void btnCrearSala_Click(object sender, EventArgs e)
        {
            FrmCrearMesa frmCrear = new FrmCrearMesa(this.listaPartidas);
            if (frmCrear.ShowDialog() == DialogResult.OK)
            {
                this.RefrezcarPartidas();
            }

        }

        private void dtgPartida_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Partida partidaAMostrar = this.EncontrarPartidaDataGrid();
                this.ActualizarTabla(partidaAMostrar.JugadorUno.TablaJugador, dtgTablaJugadorUno);
                this.ActualizarTabla(partidaAMostrar.JugadorDos.TablaJugador, dtgTablaJugadorDos);

                this.lblNombreJugadorUno.Text = partidaAMostrar.JugadorUno.NombreCompleto;
                this.lblNombreJugadorDos.Text = partidaAMostrar.JugadorDos.NombreCompleto;
                this.lblPuntosJugadorUno.Text = partidaAMostrar.JugadorUno.TablaJugador.SumaPuntaje.ToString();
                this.lblPuntosJugadorDos.Text = partidaAMostrar.JugadorDos.TablaJugador.SumaPuntaje.ToString();
                this.lblJugadorGanador.Text = partidaAMostrar.Ganador;
            }
        }

        private void CargarNombresPartidaLabels(Label labelUno, Label labelDos, string textoLabelUno, string textoLabelDos)
        {
            if (this.InvokeRequired)
            {
                Action<Label, Label, string, string> delegado = CargarNombresPartidaLabels;
                object[] pametros = { labelUno, labelDos, textoLabelUno, textoLabelDos };
                this.Invoke(delegado, pametros);
            }
            else
            {
                this.lblGanador.Visible = true;
                this.lblJugadorGanador.Visible = true;
                labelUno.Text = textoLabelUno;
                labelDos.Text = textoLabelDos;
            }

        }

        private void RefrezcarTabla()
        {
            if (this.InvokeRequired)
            {
                Action delegado = RefrezcarTabla;
                this.Invoke(delegado);
            }
            else
            {
                this.Refresh();
            }

        }

        public void ActualizarTabla(Tabla tablaJugador, DataGridView dataGridTabla)
        {
            if (this.InvokeRequired)
            {
                Action<Tabla, DataGridView> delegado = ActualizarTabla;
                object[] parametros = { tablaJugador, dataGridTabla };
                this.Invoke(delegado, parametros);
            }
            else
            {
                Dictionary<string, int> tabla = new Dictionary<string, int>();
                tabla.Add("Uno", tablaJugador.Uno);
                tabla.Add("Dos", tablaJugador.Dos);
                tabla.Add("Tres", tablaJugador.Tres);
                tabla.Add("Cuatro", tablaJugador.Cuatro);
                tabla.Add("Cinco", tablaJugador.Cinco);
                tabla.Add("Seis", tablaJugador.Seis);
                tabla.Add("Poker", tablaJugador.Poker);
                tabla.Add("Full", tablaJugador.Full);
                tabla.Add("Escalera", tablaJugador.Escalera);
                tabla.Add("Generala", tablaJugador.Generala);

                dataGridTabla.Rows.Clear();
                foreach (KeyValuePair<string, int> item in tabla)
                {
                    DataGridViewRow fila = new DataGridViewRow();
                    fila.CreateCells(dataGridTabla);
                    fila.Cells[0].Value = item.Key;
                    fila.Cells[1].Value = item.Value;
                    dataGridTabla.Rows.Add(fila);
                }
            }
        }





        private void DeterminarGanador(Jugador jugadorUno, Jugador jugadorDos)
        {
            if (this.InvokeRequired)
            {
                Action<Jugador, Jugador> delegado = DeterminarGanador;
                object[] parametros = { jugadorUno, jugadorDos };
                this.Invoke(delegado, parametros);
            }
            else
            {
                this.lblPuntosJugadorUno.Text = jugadorUno.TablaJugador.SumaPuntaje.ToString();
                this.lblPuntosJugadorDos.Text = jugadorDos.TablaJugador.SumaPuntaje.ToString();

                if (jugadorUno.TablaJugador.SumaPuntaje > jugadorDos.TablaJugador.SumaPuntaje)
                {
                    this.lblJugadorGanador.Text += jugadorUno.NombreCompleto;
                    JugadorDao.GuardarPartidaGanada(jugadorUno);
                    JugadorDao.GuardarPartidaPerdida(jugadorDos);
                }
                else if (jugadorUno.TablaJugador.SumaPuntaje < jugadorDos.TablaJugador.SumaPuntaje)
                {
                    this.lblJugadorGanador.Text += jugadorDos.NombreCompleto;
                    JugadorDao.GuardarPartidaGanada(jugadorDos);
                    JugadorDao.GuardarPartidaPerdida(jugadorUno);
                }
                else if (jugadorUno.TablaJugador.SumaPuntaje > 0 && jugadorDos.TablaJugador.SumaPuntaje > 0)
                {
                    this.lblJugadorGanador.Text = "EMPATE";
                    JugadorDao.GuardarPartidaEmpatada(jugadorDos);
                    JugadorDao.GuardarPartidaEmpatada(jugadorUno);
                }
            }
        }



        public static Image ObtenerImagenDado(int numero)
        {
            switch (numero)
            {
                case 1:
                    return Properties.Resources.dado1;
                case 2:
                    return Properties.Resources.dado2;
                case 3:
                    return Properties.Resources.dado3;
                case 4:
                    return Properties.Resources.dado4;
                case 5:
                    return Properties.Resources.dado5;
                default:
                    return Properties.Resources.dado6;
            }
        }
        public void RefrezcarImagenDado(List<Dado> dados)
        {
            if (this.InvokeRequired)
            {
                Action<List<Dado>> delegado = RefrezcarImagenDado;
                object[] parametros = { dados };
                this.Invoke(delegado, parametros);
            }
            else
            {
                this.pbDadoUno.Image = FrmGenerala.ObtenerImagenDado(dados[0].NumeroDado);
                this.pbDadoDos.Image = FrmGenerala.ObtenerImagenDado(dados[1].NumeroDado);
                this.pbDadoTres.Image = FrmGenerala.ObtenerImagenDado(dados[2].NumeroDado);
                this.pbDadoCuatro.Image = FrmGenerala.ObtenerImagenDado(dados[3].NumeroDado);
                this.pbDadoCinco.Image = FrmGenerala.ObtenerImagenDado(dados[4].NumeroDado);
            }
        }


        private void CargarPartida(List<Partida> lista)
        {
            this.dtgPartida.Rows.Clear();
            foreach (Partida item in lista)
            {
                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(this.dtgPartida);
                fila.Cells[0].Value = item.IdPartida;
                fila.Cells[1].Value = item.JugadorUno.NombreCompleto;
                fila.Cells[2].Value = item.JugadorDos.NombreCompleto;
                fila.Cells[3].Value = item.Ganador;
                this.dtgPartida.Rows.Add(fila);
            }
        }


        private Partida EncontrarPartidaDataGrid()
        {

            int index = this.dtgPartida.CurrentCell?.RowIndex ?? -1; // si es nulo , le pongo valor por default -1
            if (index == -1)
            {
                throw new NullReferenceException("Debe seleccionar una partida para iniciar, si no hay , crearla");
            }
            int id = (int)dtgPartida.Rows[index].Cells[0].Value;
            Partida partidaAMostrar = new Partida();
            partidaAMostrar = partidaAMostrar.Encontrar(this.listaPartidas, id);

            return partidaAMostrar;
        }


        private void FrmGenerala_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            FrmEstadisticas frmEstadisticas = new FrmEstadisticas();

            frmEstadisticas.ShowDialog();
        }

        private void RefrezcarPartidas()
        {
            try
            {
                Archivos<List<Partida>>.GuardarJson(this.listaPartidas, path);
                this.CargarPartida(this.listaPartidas);
            }
            catch (Exception)
            {
                MessageBox.Show("Surgio un error");
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (this.partidaIniciada == true)
            {
                cancellationTokenSource.Cancel();
            }
            else
            {
                MessageBox.Show("La partida no se inicio o ya termino");
            }          
        }


    }



}


