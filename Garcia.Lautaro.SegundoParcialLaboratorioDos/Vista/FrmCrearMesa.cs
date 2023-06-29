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
    public partial class FrmCrearMesa : FrmBase
    {
        private List<Jugador> listaJugadores;
        private List<Partida> listaPartidas;
        public FrmCrearMesa(List<Partida> listaPartidas)
        {
            InitializeComponent();
            this.btnMinimizar.Visible = false;
            this.btnMaximizar.Visible = false;
            this.btnCerrar.Visible = false;


            try
            {
                this.listaJugadores = JugadorDao.LeerJugador();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.listaJugadores = new List<Jugador>();
            }
            this.listaPartidas = listaPartidas;
        }
        private void FrmCrearMesa_Load(object sender, EventArgs e)
        {
            this.CargarJugadoresComboBox();
        }

        protected override void btnIniciar_Click(object sender, EventArgs e) // crear
        {
            try
            {
                if (this.cmbJugadorUno.SelectedItem != null && this.cmbJugadorDos.SelectedItem != null)
                {
                    Jugador jugadorUno = EncontrarJugadorComboBox(this.cmbJugadorUno);
                    Jugador jugadorDos = EncontrarJugadorComboBox(this.cmbJugadorDos);
                    if (jugadorUno != jugadorDos)
                    {
                        Partida partidaNueva = new Partida(jugadorUno, jugadorDos);
                        this.listaPartidas.Add(partidaNueva);
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        throw new ValidarExcepcion("Un jugador no puede ser jugador 1 y jugador 2");
                    }

                }
                else
                {
                    throw new ValidarExcepcion("No se seleccionaron jugadores");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }





        private void CargarJugadoresComboBox()
        {
            try
            {

                foreach (Jugador item in this.listaJugadores)
                {
                    this.cmbJugadorUno.Items.Add($"{item.Id}  -  Nombre : {item.NombreCompleto}");
                    this.cmbJugadorDos.Items.Add($"{item.Id}  -  Nombre : {item.NombreCompleto}");
                }
            }
            catch (Exception)
            {
                throw new ValidarExcepcion();
            }
        }

        private Jugador EncontrarJugadorComboBox(ComboBox jugadorSeleccionado)
        {
            string datosComboBox = jugadorSeleccionado.Text;
            string[] elementoSeleccionado = datosComboBox.Replace(" ", "").Split("-");
            Jugador jugadorEncontrado = new Jugador();
            jugadorEncontrado = jugadorEncontrado.Encontrar(this.listaJugadores, int.Parse(elementoSeleccionado[0]));

            return jugadorEncontrado;
        }


    }
}
