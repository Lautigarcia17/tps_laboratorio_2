namespace Garcia.Lautaro.PrimerParcialForm
{
    partial class FrmAgregarVuelo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblVuelo = new Label();
            lblTipoVuelo = new Label();
            rbNacional = new RadioButton();
            rbInternacional = new RadioButton();
            lblOrigen = new Label();
            lblDestino = new Label();
            cmbOrigen = new ComboBox();
            cmbDestino = new ComboBox();
            lblFechaVuelo = new Label();
            dtpFechaVuelo = new DateTimePicker();
            lblAeronave = new Label();
            cmbAeronave = new ComboBox();
            btnMostrarAeronave = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btnMostrarAeronave).BeginInit();
            SuspendLayout();
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(752, 189);
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(753, 132);
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Bottom;
            btnAgregar.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.Location = new Point(175, 312);
            btnAgregar.Size = new Size(173, 54);
            // 
            // lblVuelo
            // 
            lblVuelo.Anchor = AnchorStyles.Top;
            lblVuelo.AutoSize = true;
            lblVuelo.Font = new Font("Microsoft YaHei UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblVuelo.Location = new Point(195, 45);
            lblVuelo.Name = "lblVuelo";
            lblVuelo.Size = new Size(128, 42);
            lblVuelo.TabIndex = 0;
            lblVuelo.Text = "VUELO";
            // 
            // lblTipoVuelo
            // 
            lblTipoVuelo.Anchor = AnchorStyles.None;
            lblTipoVuelo.AutoSize = true;
            lblTipoVuelo.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTipoVuelo.Location = new Point(50, 106);
            lblTipoVuelo.Name = "lblTipoVuelo";
            lblTipoVuelo.Size = new Size(131, 22);
            lblTipoVuelo.TabIndex = 1;
            lblTipoVuelo.Text = "Tipo de vuelo :";
            // 
            // rbNacional
            // 
            rbNacional.Anchor = AnchorStyles.None;
            rbNacional.AutoSize = true;
            rbNacional.Font = new Font("Microsoft YaHei UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            rbNacional.Location = new Point(206, 106);
            rbNacional.Name = "rbNacional";
            rbNacional.Size = new Size(72, 20);
            rbNacional.TabIndex = 2;
            rbNacional.Text = "Nacional";
            rbNacional.UseVisualStyleBackColor = true;
            rbNacional.CheckedChanged += rbNacional_CheckedChanged;
            // 
            // rbInternacional
            // 
            rbInternacional.Anchor = AnchorStyles.None;
            rbInternacional.AutoSize = true;
            rbInternacional.Font = new Font("Microsoft YaHei UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            rbInternacional.Location = new Point(302, 106);
            rbInternacional.Name = "rbInternacional";
            rbInternacional.Size = new Size(97, 20);
            rbInternacional.TabIndex = 3;
            rbInternacional.Text = "Internacional";
            rbInternacional.UseVisualStyleBackColor = true;
            rbInternacional.CheckedChanged += rbInternacional_CheckedChanged;
            // 
            // lblOrigen
            // 
            lblOrigen.Anchor = AnchorStyles.None;
            lblOrigen.AutoSize = true;
            lblOrigen.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblOrigen.Location = new Point(92, 164);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(63, 19);
            lblOrigen.TabIndex = 4;
            lblOrigen.Text = "Origen :";
            // 
            // lblDestino
            // 
            lblDestino.Anchor = AnchorStyles.None;
            lblDestino.AutoSize = true;
            lblDestino.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblDestino.Location = new Point(92, 199);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(67, 19);
            lblDestino.TabIndex = 5;
            lblDestino.Text = "Destino :";
            // 
            // cmbOrigen
            // 
            cmbOrigen.Anchor = AnchorStyles.None;
            cmbOrigen.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOrigen.FormattingEnabled = true;
            cmbOrigen.Location = new Point(185, 160);
            cmbOrigen.Name = "cmbOrigen";
            cmbOrigen.Size = new Size(172, 23);
            cmbOrigen.TabIndex = 6;
            // 
            // cmbDestino
            // 
            cmbDestino.Anchor = AnchorStyles.None;
            cmbDestino.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDestino.FormattingEnabled = true;
            cmbDestino.Location = new Point(185, 195);
            cmbDestino.Name = "cmbDestino";
            cmbDestino.Size = new Size(172, 23);
            cmbDestino.TabIndex = 7;
            // 
            // lblFechaVuelo
            // 
            lblFechaVuelo.Anchor = AnchorStyles.None;
            lblFechaVuelo.AutoSize = true;
            lblFechaVuelo.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblFechaVuelo.Location = new Point(92, 244);
            lblFechaVuelo.Name = "lblFechaVuelo";
            lblFechaVuelo.Size = new Size(109, 19);
            lblFechaVuelo.TabIndex = 8;
            lblFechaVuelo.Text = "Fecha de vuelo";
            // 
            // dtpFechaVuelo
            // 
            dtpFechaVuelo.Anchor = AnchorStyles.None;
            dtpFechaVuelo.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFechaVuelo.Cursor = Cursors.IBeam;
            dtpFechaVuelo.CustomFormat = "dddd d / MMMM/ yyyy / HH:mm";
            dtpFechaVuelo.Format = DateTimePickerFormat.Custom;
            dtpFechaVuelo.Location = new Point(39, 266);
            dtpFechaVuelo.MaxDate = new DateTime(3000, 12, 31, 0, 0, 0, 0);
            dtpFechaVuelo.MinDate = new DateTime(2023, 5, 5, 0, 0, 0, 0);
            dtpFechaVuelo.Name = "dtpFechaVuelo";
            dtpFechaVuelo.Size = new Size(251, 23);
            dtpFechaVuelo.TabIndex = 9;
            dtpFechaVuelo.ValueChanged += dtpFechaVuelo_ValueChanged;
            // 
            // lblAeronave
            // 
            lblAeronave.Anchor = AnchorStyles.None;
            lblAeronave.AutoSize = true;
            lblAeronave.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAeronave.Location = new Point(351, 239);
            lblAeronave.Name = "lblAeronave";
            lblAeronave.Size = new Size(74, 19);
            lblAeronave.TabIndex = 10;
            lblAeronave.Text = "Aeronave";
            // 
            // cmbAeronave
            // 
            cmbAeronave.Anchor = AnchorStyles.None;
            cmbAeronave.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAeronave.FormattingEnabled = true;
            cmbAeronave.Location = new Point(321, 261);
            cmbAeronave.Name = "cmbAeronave";
            cmbAeronave.Size = new Size(134, 23);
            cmbAeronave.TabIndex = 11;
            // 
            // btnMostrarAeronave
            // 
            btnMostrarAeronave.BorderStyle = BorderStyle.FixedSingle;
            btnMostrarAeronave.Image = Properties.Resources.airplane_flying_vector_icon;
            btnMostrarAeronave.Location = new Point(459, 255);
            btnMostrarAeronave.Name = "btnMostrarAeronave";
            btnMostrarAeronave.Size = new Size(41, 34);
            btnMostrarAeronave.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMostrarAeronave.TabIndex = 7;
            btnMostrarAeronave.TabStop = false;
            btnMostrarAeronave.Click += btnMostrarAeronave_Click_1;
            // 
            // FrmAgregarVuelo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(506, 376);
            Controls.Add(btnMostrarAeronave);
            Controls.Add(cmbAeronave);
            Controls.Add(lblAeronave);
            Controls.Add(dtpFechaVuelo);
            Controls.Add(lblFechaVuelo);
            Controls.Add(cmbDestino);
            Controls.Add(cmbOrigen);
            Controls.Add(lblDestino);
            Controls.Add(lblOrigen);
            Controls.Add(rbInternacional);
            Controls.Add(rbNacional);
            Controls.Add(lblTipoVuelo);
            Controls.Add(lblVuelo);
            MinimumSize = new Size(518, 415);
            Name = "FrmAgregarVuelo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Vuelo";
            Load += FrmAgregarVuelo_Load;
            Controls.SetChildIndex(lblVuelo, 0);
            Controls.SetChildIndex(lblTipoVuelo, 0);
            Controls.SetChildIndex(rbNacional, 0);
            Controls.SetChildIndex(rbInternacional, 0);
            Controls.SetChildIndex(lblOrigen, 0);
            Controls.SetChildIndex(lblDestino, 0);
            Controls.SetChildIndex(cmbOrigen, 0);
            Controls.SetChildIndex(cmbDestino, 0);
            Controls.SetChildIndex(lblFechaVuelo, 0);
            Controls.SetChildIndex(dtpFechaVuelo, 0);
            Controls.SetChildIndex(lblAeronave, 0);
            Controls.SetChildIndex(cmbAeronave, 0);
            Controls.SetChildIndex(btnAgregar, 0);
            Controls.SetChildIndex(btnModificar, 0);
            Controls.SetChildIndex(btnBorrar, 0);
            Controls.SetChildIndex(btnVolver, 0);
            Controls.SetChildIndex(btnMostrarAeronave, 0);
            ((System.ComponentModel.ISupportInitialize)btnMostrarAeronave).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        protected ComboBox cmbOrigen;
        protected ComboBox cmbDestino;
        protected DateTimePicker dtpFechaVuelo;
        protected ComboBox cmbAeronave;
        protected RadioButton rbNacional;
        protected RadioButton rbInternacional;
        protected PictureBox btnMostrarAeronave;
        protected Label lblTipoVuelo;
        protected Label lblOrigen;
        protected Label lblDestino;
        protected Label lblFechaVuelo;
        protected Label lblAeronave;
        protected Label lblVuelo;
    }
}