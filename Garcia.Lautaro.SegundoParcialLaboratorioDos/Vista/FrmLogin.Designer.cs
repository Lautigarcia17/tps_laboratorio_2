namespace Vista
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            txtContrasenia = new TextBox();
            lblContrasenia = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            pictureBox1 = new PictureBox();
            cmbIngresoRapido = new ComboBox();
            lblIngresoRapido = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            lblHora = new Label();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnVolver).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnIniciar
            // 
            btnIniciar.Anchor = AnchorStyles.Bottom;
            btnIniciar.BackColor = Color.Gray;
            btnIniciar.FlatAppearance.BorderSize = 3;
            btnIniciar.Location = new Point(467, 372);
            btnIniciar.Size = new Size(278, 79);
            btnIniciar.Text = "Iniciar Sesion";
            // 
            // btnMaximizar
            // 
            btnMaximizar.Location = new Point(788, 1);
            // 
            // btnMinimizar
            // 
            btnMinimizar.Location = new Point(752, 3);
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(824, 1);
            // 
            // txtContrasenia
            // 
            txtContrasenia.Anchor = AnchorStyles.None;
            txtContrasenia.BackColor = Color.Silver;
            txtContrasenia.BorderStyle = BorderStyle.None;
            txtContrasenia.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtContrasenia.ForeColor = Color.Black;
            txtContrasenia.Location = new Point(396, 198);
            txtContrasenia.Multiline = true;
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.PasswordChar = '*';
            txtContrasenia.Size = new Size(370, 37);
            txtContrasenia.TabIndex = 11;
            // 
            // lblContrasenia
            // 
            lblContrasenia.Anchor = AnchorStyles.None;
            lblContrasenia.AutoSize = true;
            lblContrasenia.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblContrasenia.ForeColor = SystemColors.ButtonHighlight;
            lblContrasenia.Location = new Point(387, 153);
            lblContrasenia.Name = "lblContrasenia";
            lblContrasenia.Size = new Size(222, 42);
            lblContrasenia.TabIndex = 10;
            lblContrasenia.Text = "Contraseña";
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.None;
            txtNombre.BackColor = Color.Silver;
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtNombre.ForeColor = Color.Black;
            txtNombre.Location = new Point(396, 91);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(370, 37);
            txtNombre.TabIndex = 9;
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.None;
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.ForeColor = SystemColors.ButtonHighlight;
            lblNombre.Location = new Point(387, 46);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(156, 42);
            lblNombre.TabIndex = 8;
            lblNombre.Text = "Nombre";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(358, 462);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // cmbIngresoRapido
            // 
            cmbIngresoRapido.Anchor = AnchorStyles.None;
            cmbIngresoRapido.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIngresoRapido.FormattingEnabled = true;
            cmbIngresoRapido.Location = new Point(485, 302);
            cmbIngresoRapido.Name = "cmbIngresoRapido";
            cmbIngresoRapido.Size = new Size(211, 23);
            cmbIngresoRapido.TabIndex = 16;
            cmbIngresoRapido.SelectedIndexChanged += cmbIngresoRapido_SelectedIndexChanged;
            // 
            // lblIngresoRapido
            // 
            lblIngresoRapido.Anchor = AnchorStyles.None;
            lblIngresoRapido.AutoSize = true;
            lblIngresoRapido.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblIngresoRapido.ForeColor = SystemColors.ButtonHighlight;
            lblIngresoRapido.Location = new Point(513, 275);
            lblIngresoRapido.Name = "lblIngresoRapido";
            lblIngresoRapido.Size = new Size(152, 24);
            lblIngresoRapido.TabIndex = 17;
            lblIngresoRapido.Text = "Ingreso Rapido";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblHora.ForeColor = Color.Goldenrod;
            lblHora.Location = new Point(366, 1);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(41, 16);
            lblHora.TabIndex = 18;
            lblHora.Text = "Hora";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(854, 463);
            Controls.Add(lblHora);
            Controls.Add(lblIngresoRapido);
            Controls.Add(cmbIngresoRapido);
            Controls.Add(pictureBox1);
            Controls.Add(txtContrasenia);
            Controls.Add(lblContrasenia);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            ForeColor = SystemColors.ControlLightLight;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ingresar";
            FormClosing += FrmLogin_FormClosing;
            Load += FrmLogin_Load;
            Controls.SetChildIndex(lblNombre, 0);
            Controls.SetChildIndex(txtNombre, 0);
            Controls.SetChildIndex(lblContrasenia, 0);
            Controls.SetChildIndex(txtContrasenia, 0);
            Controls.SetChildIndex(pictureBox1, 0);
            Controls.SetChildIndex(cmbIngresoRapido, 0);
            Controls.SetChildIndex(lblIngresoRapido, 0);
            Controls.SetChildIndex(btnIniciar, 0);
            Controls.SetChildIndex(btnCerrar, 0);
            Controls.SetChildIndex(btnMaximizar, 0);
            Controls.SetChildIndex(btnMinimizar, 0);
            Controls.SetChildIndex(btnVolver, 0);
            Controls.SetChildIndex(lblHora, 0);
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnVolver).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtContrasenia;
        private Label lblContrasenia;
        private TextBox txtNombre;
        private Label lblNombre;
        private PictureBox pictureBox1;
        private ComboBox cmbIngresoRapido;
        private Label lblIngresoRapido;
        private System.Windows.Forms.Timer timer1;
        private Label lblHora;
    }
}