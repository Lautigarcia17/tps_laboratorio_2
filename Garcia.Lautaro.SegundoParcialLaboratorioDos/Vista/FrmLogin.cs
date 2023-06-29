using Entidades;

namespace Vista
{
    public partial class FrmLogin : FrmBase
    {
        private List<Usuario> listaUsuarios;
        public FrmLogin()
        {
            InitializeComponent();
            this.listaUsuarios = new List<Usuario>();
            this.btnVolver.Visible = false;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                this.listaUsuarios = UsuarioDao.LeerUsuario();
                this.CargarUsuariosComboBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbIngresoRapido_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LlenarCamposConUsuario();
        }

        private void CargarUsuariosComboBox()
        {
            try
            {
                foreach (Usuario item in this.listaUsuarios)
                {
                    this.cmbIngresoRapido.Items.Add($"{item.Id} {item.NombreUsuario}");
                }
            }
            catch (Exception)
            {
                throw new ValidarExcepcion();
            }

        }

        protected override void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtNombre.Text == "" || this.txtContrasenia.Text == "")
                {
                    throw new ValidarExcepcion("Faltan campos por completar");
                }

                Usuario usuarioIngresar = Usuario.Encontrar(this.listaUsuarios, this.txtNombre.Text, this.txtContrasenia.Text);
                if (usuarioIngresar.Id == 0)
                {
                    throw new ValidarExcepcion("No se encontro un usuario valido");
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (ValidarExcepcion ex)
            {
                MessageBox.Show($"{ex.Message}");
            }

        }

        private void LlenarCamposConUsuario()
        {
            string datosComboBox = this.cmbIngresoRapido.Text;
            string[] elementoSeleccionado = datosComboBox.Split(" ");

            try
            {
                Usuario usuarioLlenar = new Usuario();
                usuarioLlenar = usuarioLlenar.Encontrar(this.listaUsuarios, int.Parse(elementoSeleccionado[0]));

                this.txtNombre.Text = usuarioLlenar.NombreUsuario;
                this.txtContrasenia.Text = usuarioLlenar.Contrasenia;
            }
            catch (ValidarExcepcion ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!(this.DialogResult == DialogResult.OK))
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}