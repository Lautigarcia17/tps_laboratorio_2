namespace Vista
{
    partial class FrmEstadisticas
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
            lblRankingVictorias = new Label();
            dtgRankingVictorias = new DataGridView();
            nombreGrid = new DataGridViewTextBoxColumn();
            victoriasGrid = new DataGridViewTextBoxColumn();
            lblRankingDerrotas = new Label();
            lblPuntajesTotales = new Label();
            dtgPuntajesTotales = new DataGridView();
            nombrePuntajeGrid = new DataGridViewTextBoxColumn();
            puntajesGrid = new DataGridViewTextBoxColumn();
            dtgRankingDerrotas = new DataGridView();
            nombreDerrotasGrid = new DataGridViewTextBoxColumn();
            derrotasGrid = new DataGridViewTextBoxColumn();
            lblRankingPartidasEmpatadas = new Label();
            dtgRankingEmpates = new DataGridView();
            nombreJugadorEmpateGrid = new DataGridViewTextBoxColumn();
            empatesGrid = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnVolver).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgRankingVictorias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgPuntajesTotales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgRankingDerrotas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgRankingEmpates).BeginInit();
            SuspendLayout();
            // 
            // btnIniciar
            // 
            btnIniciar.FlatAppearance.BorderSize = 3;
            btnIniciar.Location = new Point(787, 407);
            btnIniciar.Size = new Size(10, 10);
            // 
            // btnMaximizar
            // 
            btnMaximizar.Location = new Point(803, 407);
            btnMaximizar.Size = new Size(10, 10);
            // 
            // btnMinimizar
            // 
            btnMinimizar.Location = new Point(819, 407);
            btnMinimizar.Size = new Size(10, 10);
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(835, 407);
            btnCerrar.Size = new Size(22, 10);
            // 
            // lblRankingVictorias
            // 
            lblRankingVictorias.Anchor = AnchorStyles.Left;
            lblRankingVictorias.AutoSize = true;
            lblRankingVictorias.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblRankingVictorias.Location = new Point(39, 129);
            lblRankingVictorias.Name = "lblRankingVictorias";
            lblRankingVictorias.Size = new Size(183, 16);
            lblRankingVictorias.TabIndex = 0;
            lblRankingVictorias.Text = "RANKING DE VICTORIAS";
            // 
            // dtgRankingVictorias
            // 
            dtgRankingVictorias.AllowUserToAddRows = false;
            dtgRankingVictorias.AllowUserToResizeColumns = false;
            dtgRankingVictorias.AllowUserToResizeRows = false;
            dtgRankingVictorias.Anchor = AnchorStyles.Left;
            dtgRankingVictorias.BackgroundColor = SystemColors.Control;
            dtgRankingVictorias.BorderStyle = BorderStyle.None;
            dtgRankingVictorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgRankingVictorias.Columns.AddRange(new DataGridViewColumn[] { nombreGrid, victoriasGrid });
            dtgRankingVictorias.Location = new Point(12, 158);
            dtgRankingVictorias.Name = "dtgRankingVictorias";
            dtgRankingVictorias.ReadOnly = true;
            dtgRankingVictorias.RowHeadersVisible = false;
            dtgRankingVictorias.RowTemplate.Height = 25;
            dtgRankingVictorias.Size = new Size(256, 172);
            dtgRankingVictorias.TabIndex = 3;
            // 
            // nombreGrid
            // 
            nombreGrid.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nombreGrid.FillWeight = 121.827408F;
            nombreGrid.HeaderText = "Nombre";
            nombreGrid.Name = "nombreGrid";
            nombreGrid.ReadOnly = true;
            // 
            // victoriasGrid
            // 
            victoriasGrid.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            victoriasGrid.FillWeight = 78.17259F;
            victoriasGrid.HeaderText = "Victorias";
            victoriasGrid.Name = "victoriasGrid";
            victoriasGrid.ReadOnly = true;
            // 
            // lblRankingDerrotas
            // 
            lblRankingDerrotas.Anchor = AnchorStyles.Right;
            lblRankingDerrotas.AutoSize = true;
            lblRankingDerrotas.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblRankingDerrotas.Location = new Point(621, 129);
            lblRankingDerrotas.Name = "lblRankingDerrotas";
            lblRankingDerrotas.Size = new Size(187, 16);
            lblRankingDerrotas.TabIndex = 4;
            lblRankingDerrotas.Text = "RANKING DE DERROTAS";
            // 
            // lblPuntajesTotales
            // 
            lblPuntajesTotales.Anchor = AnchorStyles.Top;
            lblPuntajesTotales.AutoSize = true;
            lblPuntajesTotales.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPuntajesTotales.Location = new Point(291, 17);
            lblPuntajesTotales.Name = "lblPuntajesTotales";
            lblPuntajesTotales.Size = new Size(273, 16);
            lblPuntajesTotales.TabIndex = 7;
            lblPuntajesTotales.Text = "PUNTAJES TOTALES POR JUGADOR";
            // 
            // dtgPuntajesTotales
            // 
            dtgPuntajesTotales.AllowUserToAddRows = false;
            dtgPuntajesTotales.AllowUserToResizeColumns = false;
            dtgPuntajesTotales.AllowUserToResizeRows = false;
            dtgPuntajesTotales.Anchor = AnchorStyles.Top;
            dtgPuntajesTotales.BackgroundColor = SystemColors.Control;
            dtgPuntajesTotales.BorderStyle = BorderStyle.None;
            dtgPuntajesTotales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgPuntajesTotales.Columns.AddRange(new DataGridViewColumn[] { nombrePuntajeGrid, puntajesGrid });
            dtgPuntajesTotales.Location = new Point(301, 36);
            dtgPuntajesTotales.Name = "dtgPuntajesTotales";
            dtgPuntajesTotales.ReadOnly = true;
            dtgPuntajesTotales.RowHeadersVisible = false;
            dtgPuntajesTotales.RowTemplate.Height = 25;
            dtgPuntajesTotales.Size = new Size(263, 162);
            dtgPuntajesTotales.TabIndex = 8;
            // 
            // nombrePuntajeGrid
            // 
            nombrePuntajeGrid.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nombrePuntajeGrid.FillWeight = 121.827408F;
            nombrePuntajeGrid.HeaderText = "Nombre";
            nombrePuntajeGrid.Name = "nombrePuntajeGrid";
            nombrePuntajeGrid.ReadOnly = true;
            // 
            // puntajesGrid
            // 
            puntajesGrid.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            puntajesGrid.FillWeight = 78.17259F;
            puntajesGrid.HeaderText = "Puntaje";
            puntajesGrid.Name = "puntajesGrid";
            puntajesGrid.ReadOnly = true;
            // 
            // dtgRankingDerrotas
            // 
            dtgRankingDerrotas.AllowUserToAddRows = false;
            dtgRankingDerrotas.AllowUserToResizeColumns = false;
            dtgRankingDerrotas.AllowUserToResizeRows = false;
            dtgRankingDerrotas.Anchor = AnchorStyles.Right;
            dtgRankingDerrotas.BackgroundColor = SystemColors.Control;
            dtgRankingDerrotas.BorderStyle = BorderStyle.None;
            dtgRankingDerrotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgRankingDerrotas.Columns.AddRange(new DataGridViewColumn[] { nombreDerrotasGrid, derrotasGrid });
            dtgRankingDerrotas.Location = new Point(592, 158);
            dtgRankingDerrotas.Name = "dtgRankingDerrotas";
            dtgRankingDerrotas.ReadOnly = true;
            dtgRankingDerrotas.RowHeadersVisible = false;
            dtgRankingDerrotas.RowTemplate.Height = 25;
            dtgRankingDerrotas.Size = new Size(253, 192);
            dtgRankingDerrotas.TabIndex = 9;
            // 
            // nombreDerrotasGrid
            // 
            nombreDerrotasGrid.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nombreDerrotasGrid.FillWeight = 121.827408F;
            nombreDerrotasGrid.HeaderText = "Nombre";
            nombreDerrotasGrid.Name = "nombreDerrotasGrid";
            nombreDerrotasGrid.ReadOnly = true;
            // 
            // derrotasGrid
            // 
            derrotasGrid.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            derrotasGrid.FillWeight = 78.17259F;
            derrotasGrid.HeaderText = "Derrotas";
            derrotasGrid.Name = "derrotasGrid";
            derrotasGrid.ReadOnly = true;
            // 
            // lblRankingPartidasEmpatadas
            // 
            lblRankingPartidasEmpatadas.Anchor = AnchorStyles.Bottom;
            lblRankingPartidasEmpatadas.AutoSize = true;
            lblRankingPartidasEmpatadas.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblRankingPartidasEmpatadas.Location = new Point(330, 217);
            lblRankingPartidasEmpatadas.Name = "lblRankingPartidasEmpatadas";
            lblRankingPartidasEmpatadas.Size = new Size(179, 16);
            lblRankingPartidasEmpatadas.TabIndex = 11;
            lblRankingPartidasEmpatadas.Text = "RANKING DE EMPATES ";
            // 
            // dtgRankingEmpates
            // 
            dtgRankingEmpates.AllowUserToAddRows = false;
            dtgRankingEmpates.AllowUserToResizeColumns = false;
            dtgRankingEmpates.AllowUserToResizeRows = false;
            dtgRankingEmpates.Anchor = AnchorStyles.Bottom;
            dtgRankingEmpates.BackgroundColor = SystemColors.Control;
            dtgRankingEmpates.BorderStyle = BorderStyle.None;
            dtgRankingEmpates.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgRankingEmpates.Columns.AddRange(new DataGridViewColumn[] { nombreJugadorEmpateGrid, empatesGrid });
            dtgRankingEmpates.Location = new Point(301, 246);
            dtgRankingEmpates.Name = "dtgRankingEmpates";
            dtgRankingEmpates.ReadOnly = true;
            dtgRankingEmpates.RowHeadersVisible = false;
            dtgRankingEmpates.RowTemplate.Height = 25;
            dtgRankingEmpates.Size = new Size(253, 192);
            dtgRankingEmpates.TabIndex = 12;
            // 
            // nombreJugadorEmpateGrid
            // 
            nombreJugadorEmpateGrid.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nombreJugadorEmpateGrid.FillWeight = 121.827408F;
            nombreJugadorEmpateGrid.HeaderText = "Nombre";
            nombreJugadorEmpateGrid.Name = "nombreJugadorEmpateGrid";
            nombreJugadorEmpateGrid.ReadOnly = true;
            // 
            // empatesGrid
            // 
            empatesGrid.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            empatesGrid.FillWeight = 78.17259F;
            empatesGrid.HeaderText = "Empates";
            empatesGrid.Name = "empatesGrid";
            empatesGrid.ReadOnly = true;
            // 
            // FrmEstadisticas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 429);
            Controls.Add(dtgRankingEmpates);
            Controls.Add(lblRankingPartidasEmpatadas);
            Controls.Add(dtgRankingDerrotas);
            Controls.Add(dtgPuntajesTotales);
            Controls.Add(lblPuntajesTotales);
            Controls.Add(lblRankingDerrotas);
            Controls.Add(dtgRankingVictorias);
            Controls.Add(lblRankingVictorias);
            MinimumSize = new Size(868, 445);
            Name = "FrmEstadisticas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Estadisticas";
            Load += FrmEstadisticas_Load;
            Controls.SetChildIndex(lblRankingVictorias, 0);
            Controls.SetChildIndex(dtgRankingVictorias, 0);
            Controls.SetChildIndex(lblRankingDerrotas, 0);
            Controls.SetChildIndex(lblPuntajesTotales, 0);
            Controls.SetChildIndex(dtgPuntajesTotales, 0);
            Controls.SetChildIndex(dtgRankingDerrotas, 0);
            Controls.SetChildIndex(lblRankingPartidasEmpatadas, 0);
            Controls.SetChildIndex(dtgRankingEmpates, 0);
            Controls.SetChildIndex(btnIniciar, 0);
            Controls.SetChildIndex(btnCerrar, 0);
            Controls.SetChildIndex(btnMaximizar, 0);
            Controls.SetChildIndex(btnMinimizar, 0);
            Controls.SetChildIndex(btnVolver, 0);
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnVolver).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgRankingVictorias).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgPuntajesTotales).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgRankingDerrotas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgRankingEmpates).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRankingVictorias;
        private DataGridView dtgRankingVictorias;
        private Label lblRankingDerrotas;
        private Label lblPuntajesTotales;
        private DataGridViewTextBoxColumn nombreGrid;
        private DataGridViewTextBoxColumn victoriasGrid;
        private DataGridView dtgPuntajesTotales;
        private DataGridViewTextBoxColumn nombrePuntajeGrid;
        private DataGridViewTextBoxColumn puntajesGrid;
        private DataGridView dtgRankingDerrotas;
        private DataGridViewTextBoxColumn nombreDerrotasGrid;
        private DataGridViewTextBoxColumn derrotasGrid;
        private Label lblRankingPartidasEmpatadas;
        private DataGridView dtgRankingEmpates;
        private DataGridViewTextBoxColumn nombreJugadorEmpateGrid;
        private DataGridViewTextBoxColumn empatesGrid;
    }
}