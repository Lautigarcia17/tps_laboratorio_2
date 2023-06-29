using Entidades;

namespace Garcia.Lautaro.PrimerParcialForm
{
    public partial class FrmLogin : FrmBase
    {
        private List<Usuario> listaUsuarios;
        private Usuario usuario;

        public FrmLogin()
        {
            InitializeComponent();
            this.listaUsuarios = Archivos.LeerJsonUsuarios();
            this.usuario = new Usuario();
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            base.btnModificar.Visible = false;
            base.btnBorrar.Visible = false;
            base.btnVolver.Text = "Salir";
            base.btnAgregar.Text = "Ingresar";


            this.CargarUsuariosComboBox();

        }
        public Usuario Usuario
        {
            get { return this.usuario; }
        }

        protected override void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Validar.ValidarCamposCompletos(this.txtCorreo.Text, this.txtContrasenia.Text))
            {
                this.usuario = this.usuario.EncontrarUsuario(this.txtCorreo.Text, this.txtContrasenia.Text, this.listaUsuarios);
                if (this.usuario.Legajo != 0)
                {
                    MessageBox.Show("USUARIO VALIDO");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("USUARIO INVALIDO");
                }
            }
            else
            {
                MessageBox.Show("Error.Faltan completar campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tmrHora_Tick(object sender, EventArgs e)
        {
            this.lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtContrasenia.Text = string.Empty;
            this.txtCorreo.Text = string.Empty;
        }
        protected override void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void CargarUsuariosComboBox()
        {
            foreach (Usuario item in this.listaUsuarios)
            {
                this.cmbIngresoRapido.Items.Add($"{item.Nombre} {item.Apellido}  ({item.Perfil})");
            }
        }

        private void cmbIngresoRapido_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LlenarCamposConUsuario();
        }


        private void LlenarCamposConUsuario()
        {
            string datosComboBox = this.cmbIngresoRapido.Text;

            string[] elementoSeleccionado = datosComboBox.Split(" ");

            string cadena = this.usuario.EncontrarCorreoClave(elementoSeleccionado[0], elementoSeleccionado[1], this.listaUsuarios);
            if (!(string.IsNullOrEmpty(cadena)))
            {
                string[] correoContrasenia = cadena.Split(" ");
                this.txtCorreo.Text = correoContrasenia[0];
                this.txtContrasenia.Text = correoContrasenia[1];
            }
        }
    }
}
