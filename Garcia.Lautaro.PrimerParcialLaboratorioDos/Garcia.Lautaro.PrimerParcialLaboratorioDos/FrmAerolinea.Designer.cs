namespace Garcia.Lautaro.PrimerParcialForm
{ //Garcia.Lautaro.PrimerParcialLaboratorioDos

    partial class FrmAerolinea
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
            components = new System.ComponentModel.Container();
            lblAerolinea = new Label();
            lblUsuarioIngresante = new Label();
            btnVuelos = new Button();
            sugerenciaToolTip = new ToolTip(components);
            lblHora = new Label();
            btnPasajeros = new Button();
            btnListaAeronaves = new Button();
            btnEstadisticasHistoricas = new Button();
            btnDesloguear = new Button();
            SuspendLayout();
            // 
            // lblAerolinea
            // 
            lblAerolinea.Anchor = AnchorStyles.None;
            lblAerolinea.AutoSize = true;
            lblAerolinea.BackColor = Color.DodgerBlue;
            lblAerolinea.Font = new Font("Microsoft YaHei UI", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblAerolinea.ForeColor = Color.White;
            lblAerolinea.Location = new Point(191, 195);
            lblAerolinea.Name = "lblAerolinea";
            lblAerolinea.Size = new Size(622, 128);
            lblAerolinea.TabIndex = 0;
            lblAerolinea.Text = "         AEROLINEAS\r\n CMPWORLD NATIONAL\r\n";
            // 
            // lblUsuarioIngresante
            // 
            lblUsuarioIngresante.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblUsuarioIngresante.AutoSize = true;
            lblUsuarioIngresante.BackColor = Color.FromArgb(255, 128, 0);
            lblUsuarioIngresante.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsuarioIngresante.ForeColor = Color.White;
            lblUsuarioIngresante.Location = new Point(3, 493);
            lblUsuarioIngresante.Name = "lblUsuarioIngresante";
            lblUsuarioIngresante.Size = new Size(72, 22);
            lblUsuarioIngresante.TabIndex = 1;
            lblUsuarioIngresante.Text = "Usuario";
            // 
            // btnVuelos
            // 
            btnVuelos.Anchor = AnchorStyles.Top;
            btnVuelos.BackColor = Color.FromArgb(255, 128, 0);
            btnVuelos.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnVuelos.ForeColor = Color.White;
            btnVuelos.Location = new Point(191, 0);
            btnVuelos.Name = "btnVuelos";
            btnVuelos.Size = new Size(100, 28);
            btnVuelos.TabIndex = 2;
            btnVuelos.Text = "VUELOS";
            btnVuelos.UseVisualStyleBackColor = false;
            btnVuelos.Click += btnVuelos_Click;
            // 
            // lblHora
            // 
            lblHora.Anchor = AnchorStyles.Bottom;
            lblHora.AutoSize = true;
            lblHora.BackColor = Color.FromArgb(255, 128, 0);
            lblHora.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblHora.ForeColor = Color.White;
            lblHora.Location = new Point(287, 493);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(50, 22);
            lblHora.TabIndex = 3;
            lblHora.Text = "Hora";
            // 
            // btnPasajeros
            // 
            btnPasajeros.Anchor = AnchorStyles.Top;
            btnPasajeros.BackColor = Color.FromArgb(255, 128, 0);
            btnPasajeros.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnPasajeros.ForeColor = Color.White;
            btnPasajeros.Location = new Point(459, 0);
            btnPasajeros.Name = "btnPasajeros";
            btnPasajeros.Size = new Size(115, 28);
            btnPasajeros.TabIndex = 4;
            btnPasajeros.Text = "PASAJEROS";
            btnPasajeros.UseVisualStyleBackColor = false;
            btnPasajeros.Click += btnPasajeros_Click;
            // 
            // btnListaAeronaves
            // 
            btnListaAeronaves.Anchor = AnchorStyles.Top;
            btnListaAeronaves.BackColor = Color.FromArgb(255, 128, 0);
            btnListaAeronaves.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnListaAeronaves.ForeColor = Color.White;
            btnListaAeronaves.Location = new Point(287, 0);
            btnListaAeronaves.Name = "btnListaAeronaves";
            btnListaAeronaves.Size = new Size(175, 28);
            btnListaAeronaves.TabIndex = 5;
            btnListaAeronaves.Text = "LISTA AERONAVES";
            btnListaAeronaves.UseVisualStyleBackColor = false;
            btnListaAeronaves.Click += btnListaAeronaves_Click;
            // 
            // btnEstadisticasHistoricas
            // 
            btnEstadisticasHistoricas.Anchor = AnchorStyles.Top;
            btnEstadisticasHistoricas.BackColor = Color.FromArgb(255, 128, 0);
            btnEstadisticasHistoricas.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnEstadisticasHistoricas.ForeColor = Color.White;
            btnEstadisticasHistoricas.Location = new Point(571, 0);
            btnEstadisticasHistoricas.Name = "btnEstadisticasHistoricas";
            btnEstadisticasHistoricas.Size = new Size(175, 28);
            btnEstadisticasHistoricas.TabIndex = 6;
            btnEstadisticasHistoricas.Text = "ESTADISTICAS";
            btnEstadisticasHistoricas.UseVisualStyleBackColor = false;
            btnEstadisticasHistoricas.Click += btnEstadisticasHistoricas_Click;
            // 
            // btnDesloguear
            // 
            btnDesloguear.Anchor = AnchorStyles.Top;
            btnDesloguear.BackColor = Color.FromArgb(255, 128, 0);
            btnDesloguear.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnDesloguear.ForeColor = Color.White;
            btnDesloguear.Location = new Point(3, 0);
            btnDesloguear.Name = "btnDesloguear";
            btnDesloguear.Size = new Size(100, 28);
            btnDesloguear.TabIndex = 7;
            btnDesloguear.Text = "Volver";
            btnDesloguear.UseVisualStyleBackColor = false;
            btnDesloguear.Click += btnDesloguear_Click;
            // 
            // FrmAerolinea
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(941, 514);
            Controls.Add(btnDesloguear);
            Controls.Add(btnEstadisticasHistoricas);
            Controls.Add(btnListaAeronaves);
            Controls.Add(btnPasajeros);
            Controls.Add(lblHora);
            Controls.Add(btnVuelos);
            Controls.Add(lblUsuarioIngresante);
            Controls.Add(lblAerolinea);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MinimumSize = new Size(957, 553);
            Name = "FrmAerolinea";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AEROLINEAS CMPWORLD NATIONAL";
            FormClosing += FrmAerolinea_FormClosing;
            Load += FrmAerolinea_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAerolinea;
        private Label lblUsuarioIngresante;
        private Button btnVuelos;
        private ToolTip sugerenciaToolTip;
        private Label lblHora;
        private Button btnPasajeros;
        private Button btnListaAeronaves;
        private Button btnEstadisticasHistoricas;
        private Button btnDesloguear;
    }
}