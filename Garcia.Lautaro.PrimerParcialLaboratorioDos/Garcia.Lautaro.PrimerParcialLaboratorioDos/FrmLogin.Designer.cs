namespace Garcia.Lautaro.PrimerParcialForm
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
            lblCmpWorld = new Label();
            lblHora = new Label();
            btnLimpiar = new Button();
            lblCorreo = new Label();
            lblContrasenia = new Label();
            txtCorreo = new TextBox();
            txtContrasenia = new TextBox();
            tmrHora = new System.Windows.Forms.Timer(components);
            cmbIngresoRapido = new ComboBox();
            lblIngresoRapido = new Label();
            SuspendLayout();
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(501, 185);
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(502, 143);
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.DodgerBlue;
            btnVolver.Location = new Point(0, -1);
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Bottom;
            btnAgregar.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.Location = new Point(151, 318);
            btnAgregar.Size = new Size(176, 60);
            // 
            // lblCmpWorld
            // 
            lblCmpWorld.Anchor = AnchorStyles.None;
            lblCmpWorld.AutoSize = true;
            lblCmpWorld.Font = new Font("Microsoft YaHei UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCmpWorld.ForeColor = SystemColors.Control;
            lblCmpWorld.Location = new Point(121, 57);
            lblCmpWorld.Name = "lblCmpWorld";
            lblCmpWorld.Size = new Size(254, 50);
            lblCmpWorld.TabIndex = 0;
            lblCmpWorld.Text = "CMPWORLD";
            // 
            // lblHora
            // 
            lblHora.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblHora.AutoSize = true;
            lblHora.BackColor = Color.Transparent;
            lblHora.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblHora.ForeColor = Color.White;
            lblHora.Location = new Point(391, 3);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(0, 21);
            lblHora.TabIndex = 1;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Anchor = AnchorStyles.Right;
            btnLimpiar.BackColor = SystemColors.ControlDarkDark;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Popup;
            btnLimpiar.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(383, 180);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(83, 23);
            btnLimpiar.TabIndex = 2;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblCorreo
            // 
            lblCorreo.Anchor = AnchorStyles.None;
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCorreo.ForeColor = Color.White;
            lblCorreo.Location = new Point(11, 143);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(134, 19);
            lblCorreo.TabIndex = 3;
            lblCorreo.Text = "Correo Electronico";
            // 
            // lblContrasenia
            // 
            lblContrasenia.Anchor = AnchorStyles.None;
            lblContrasenia.AutoSize = true;
            lblContrasenia.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblContrasenia.ForeColor = Color.White;
            lblContrasenia.Location = new Point(61, 192);
            lblContrasenia.Name = "lblContrasenia";
            lblContrasenia.Size = new Size(84, 19);
            lblContrasenia.TabIndex = 4;
            lblContrasenia.Text = "Contraseña";
            // 
            // txtCorreo
            // 
            txtCorreo.Anchor = AnchorStyles.None;
            txtCorreo.Location = new Point(151, 143);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "Ingrese el correo";
            txtCorreo.Size = new Size(204, 23);
            txtCorreo.TabIndex = 5;
            // 
            // txtContrasenia
            // 
            txtContrasenia.Anchor = AnchorStyles.None;
            txtContrasenia.Location = new Point(151, 192);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.PasswordChar = '*';
            txtContrasenia.PlaceholderText = "Ingrese la contraseña";
            txtContrasenia.Size = new Size(204, 23);
            txtContrasenia.TabIndex = 6;
            // 
            // tmrHora
            // 
            tmrHora.Enabled = true;
            tmrHora.Tick += tmrHora_Tick;
            // 
            // cmbIngresoRapido
            // 
            cmbIngresoRapido.Anchor = AnchorStyles.None;
            cmbIngresoRapido.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIngresoRapido.FormattingEnabled = true;
            cmbIngresoRapido.Location = new Point(112, 267);
            cmbIngresoRapido.Name = "cmbIngresoRapido";
            cmbIngresoRapido.Size = new Size(243, 23);
            cmbIngresoRapido.TabIndex = 7;
            cmbIngresoRapido.SelectedIndexChanged += cmbIngresoRapido_SelectedIndexChanged;
            // 
            // lblIngresoRapido
            // 
            lblIngresoRapido.Anchor = AnchorStyles.None;
            lblIngresoRapido.AutoSize = true;
            lblIngresoRapido.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblIngresoRapido.ForeColor = Color.White;
            lblIngresoRapido.Location = new Point(181, 245);
            lblIngresoRapido.Name = "lblIngresoRapido";
            lblIngresoRapido.Size = new Size(111, 19);
            lblIngresoRapido.TabIndex = 8;
            lblIngresoRapido.Text = "Ingreso Rapido";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(467, 390);
            Controls.Add(lblIngresoRapido);
            Controls.Add(cmbIngresoRapido);
            Controls.Add(txtContrasenia);
            Controls.Add(txtCorreo);
            Controls.Add(lblContrasenia);
            Controls.Add(lblCorreo);
            Controls.Add(btnLimpiar);
            Controls.Add(lblHora);
            Controls.Add(lblCmpWorld);
            MinimumSize = new Size(483, 429);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ingreso";
            FormClosing += FrmLogin_FormClosing;
            Load += FrmLogin_Load;
            Controls.SetChildIndex(lblCmpWorld, 0);
            Controls.SetChildIndex(lblHora, 0);
            Controls.SetChildIndex(btnLimpiar, 0);
            Controls.SetChildIndex(lblCorreo, 0);
            Controls.SetChildIndex(lblContrasenia, 0);
            Controls.SetChildIndex(txtCorreo, 0);
            Controls.SetChildIndex(txtContrasenia, 0);
            Controls.SetChildIndex(btnAgregar, 0);
            Controls.SetChildIndex(btnModificar, 0);
            Controls.SetChildIndex(btnBorrar, 0);
            Controls.SetChildIndex(btnVolver, 0);
            Controls.SetChildIndex(cmbIngresoRapido, 0);
            Controls.SetChildIndex(lblIngresoRapido, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCmpWorld;
        private Label lblHora;
        private Button btnLimpiar;
        private Label lblCorreo;
        private Label lblContrasenia;
        private TextBox txtCorreo;
        private TextBox txtContrasenia;
        private System.Windows.Forms.Timer tmrHora;
        private ComboBox cmbIngresoRapido;
        private Label lblIngresoRapido;
    }
}