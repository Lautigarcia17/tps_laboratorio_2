namespace Garcia.Lautaro.PrimerParcialForm
{
    partial class FrmEstadisticasHistoricas
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dtgPasajerosFrecuentes = new DataGridView();
            nombreGrid = new DataGridViewTextBoxColumn();
            vueloGrid = new DataGridViewTextBoxColumn();
            lblPasajerosFrecuentes = new Label();
            lblPasajerosPorVuelo = new Label();
            dtgCantidadPasajerosPorVuelo = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            lblDestinoMasElegido = new Label();
            grpDestinoMasElegido = new GroupBox();
            dtgHorasPorAeronave = new DataGridView();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            lblHorasAeronave = new Label();
            lblDestinosPorFacturacion = new Label();
            dtgDestinosPorFacturacion = new DataGridView();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            grpGanancias = new GroupBox();
            lblGananciasInternacional = new Label();
            lblGananciasCabotaje = new Label();
            lblGananciasTotales = new Label();
            lblGanancias = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgPasajerosFrecuentes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgCantidadPasajerosPorVuelo).BeginInit();
            grpDestinoMasElegido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgHorasPorAeronave).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgDestinosPorFacturacion).BeginInit();
            grpGanancias.SuspendLayout();
            SuspendLayout();
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(1177, 297);
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(1177, 240);
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(1198, 180);
            // 
            // dtgPasajerosFrecuentes
            // 
            dtgPasajerosFrecuentes.AllowUserToAddRows = false;
            dtgPasajerosFrecuentes.AllowUserToResizeColumns = false;
            dtgPasajerosFrecuentes.AllowUserToResizeRows = false;
            dtgPasajerosFrecuentes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dtgPasajerosFrecuentes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgPasajerosFrecuentes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dtgPasajerosFrecuentes.BackgroundColor = SystemColors.Window;
            dtgPasajerosFrecuentes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgPasajerosFrecuentes.Columns.AddRange(new DataGridViewColumn[] { nombreGrid, vueloGrid });
            dtgPasajerosFrecuentes.Location = new Point(12, 311);
            dtgPasajerosFrecuentes.Name = "dtgPasajerosFrecuentes";
            dtgPasajerosFrecuentes.ReadOnly = true;
            dtgPasajerosFrecuentes.RowHeadersVisible = false;
            dtgPasajerosFrecuentes.RowTemplate.Height = 25;
            dtgPasajerosFrecuentes.ScrollBars = ScrollBars.Vertical;
            dtgPasajerosFrecuentes.Size = new Size(348, 196);
            dtgPasajerosFrecuentes.TabIndex = 0;
            // 
            // nombreGrid
            // 
            nombreGrid.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nombreGrid.HeaderText = "Nombre";
            nombreGrid.Name = "nombreGrid";
            nombreGrid.ReadOnly = true;
            // 
            // vueloGrid
            // 
            vueloGrid.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            vueloGrid.HeaderText = "Cantidad Vuelos";
            vueloGrid.Name = "vueloGrid";
            vueloGrid.ReadOnly = true;
            // 
            // lblPasajerosFrecuentes
            // 
            lblPasajerosFrecuentes.AutoSize = true;
            lblPasajerosFrecuentes.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPasajerosFrecuentes.Location = new Point(66, 281);
            lblPasajerosFrecuentes.Name = "lblPasajerosFrecuentes";
            lblPasajerosFrecuentes.Size = new Size(215, 22);
            lblPasajerosFrecuentes.TabIndex = 1;
            lblPasajerosFrecuentes.Text = "PASAJEROS FRECUENTES";
            // 
            // lblPasajerosPorVuelo
            // 
            lblPasajerosPorVuelo.Anchor = AnchorStyles.None;
            lblPasajerosPorVuelo.AutoSize = true;
            lblPasajerosPorVuelo.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPasajerosPorVuelo.Location = new Point(412, 279);
            lblPasajerosPorVuelo.Name = "lblPasajerosPorVuelo";
            lblPasajerosPorVuelo.Size = new Size(300, 22);
            lblPasajerosPorVuelo.TabIndex = 2;
            lblPasajerosPorVuelo.Text = "CANTIDAD PASAJEROS POR VUELO";
            // 
            // dtgCantidadPasajerosPorVuelo
            // 
            dtgCantidadPasajerosPorVuelo.AllowUserToAddRows = false;
            dtgCantidadPasajerosPorVuelo.AllowUserToResizeColumns = false;
            dtgCantidadPasajerosPorVuelo.AllowUserToResizeRows = false;
            dtgCantidadPasajerosPorVuelo.Anchor = AnchorStyles.None;
            dtgCantidadPasajerosPorVuelo.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dtgCantidadPasajerosPorVuelo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgCantidadPasajerosPorVuelo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgCantidadPasajerosPorVuelo.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtgCantidadPasajerosPorVuelo.DefaultCellStyle = dataGridViewCellStyle2;
            dtgCantidadPasajerosPorVuelo.Location = new Point(383, 311);
            dtgCantidadPasajerosPorVuelo.Name = "dtgCantidadPasajerosPorVuelo";
            dtgCantidadPasajerosPorVuelo.ReadOnly = true;
            dtgCantidadPasajerosPorVuelo.RowHeadersVisible = false;
            dtgCantidadPasajerosPorVuelo.RowTemplate.Height = 25;
            dtgCantidadPasajerosPorVuelo.Size = new Size(348, 196);
            dtgCantidadPasajerosPorVuelo.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.FillWeight = 159.390869F;
            dataGridViewTextBoxColumn1.HeaderText = "Vuelo";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewTextBoxColumn2.FillWeight = 40.60914F;
            dataGridViewTextBoxColumn2.HeaderText = "Cantidad Pasajeros";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 132;
            // 
            // lblDestinoMasElegido
            // 
            lblDestinoMasElegido.AutoSize = true;
            lblDestinoMasElegido.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblDestinoMasElegido.Location = new Point(18, 0);
            lblDestinoMasElegido.Name = "lblDestinoMasElegido";
            lblDestinoMasElegido.Size = new Size(145, 19);
            lblDestinoMasElegido.TabIndex = 4;
            lblDestinoMasElegido.Text = "DESTINO FAVORITO ";
            // 
            // grpDestinoMasElegido
            // 
            grpDestinoMasElegido.Anchor = AnchorStyles.Left;
            grpDestinoMasElegido.Controls.Add(lblDestinoMasElegido);
            grpDestinoMasElegido.Location = new Point(91, 62);
            grpDestinoMasElegido.Name = "grpDestinoMasElegido";
            grpDestinoMasElegido.Size = new Size(180, 75);
            grpDestinoMasElegido.TabIndex = 5;
            grpDestinoMasElegido.TabStop = false;
            // 
            // dtgHorasPorAeronave
            // 
            dtgHorasPorAeronave.AllowUserToAddRows = false;
            dtgHorasPorAeronave.AllowUserToResizeColumns = false;
            dtgHorasPorAeronave.AllowUserToResizeRows = false;
            dtgHorasPorAeronave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            dtgHorasPorAeronave.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgHorasPorAeronave.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dtgHorasPorAeronave.BackgroundColor = Color.White;
            dtgHorasPorAeronave.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgHorasPorAeronave.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dtgHorasPorAeronave.Location = new Point(770, 311);
            dtgHorasPorAeronave.Name = "dtgHorasPorAeronave";
            dtgHorasPorAeronave.ReadOnly = true;
            dtgHorasPorAeronave.RowHeadersVisible = false;
            dtgHorasPorAeronave.RowTemplate.Height = 25;
            dtgHorasPorAeronave.ScrollBars = ScrollBars.Vertical;
            dtgHorasPorAeronave.Size = new Size(332, 196);
            dtgHorasPorAeronave.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn3.HeaderText = "Aeronave";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn4.HeaderText = "Cantidad Horas";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // lblHorasAeronave
            // 
            lblHorasAeronave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblHorasAeronave.AutoSize = true;
            lblHorasAeronave.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblHorasAeronave.Location = new Point(802, 281);
            lblHorasAeronave.Name = "lblHorasAeronave";
            lblHorasAeronave.Size = new Size(291, 22);
            lblHorasAeronave.TabIndex = 7;
            lblHorasAeronave.Text = "HORAS DE VUELO POR AERONAVE";
            // 
            // lblDestinosPorFacturacion
            // 
            lblDestinosPorFacturacion.Anchor = AnchorStyles.Top;
            lblDestinosPorFacturacion.AutoSize = true;
            lblDestinosPorFacturacion.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDestinosPorFacturacion.Location = new Point(466, 27);
            lblDestinosPorFacturacion.Name = "lblDestinosPorFacturacion";
            lblDestinosPorFacturacion.Size = new Size(246, 22);
            lblDestinosPorFacturacion.TabIndex = 9;
            lblDestinosPorFacturacion.Text = "FACTURACION DE DESTINOS";
            // 
            // dtgDestinosPorFacturacion
            // 
            dtgDestinosPorFacturacion.AllowUserToAddRows = false;
            dtgDestinosPorFacturacion.AllowUserToResizeColumns = false;
            dtgDestinosPorFacturacion.AllowUserToResizeRows = false;
            dtgDestinosPorFacturacion.Anchor = AnchorStyles.Top;
            dtgDestinosPorFacturacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDestinosPorFacturacion.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dtgDestinosPorFacturacion.BackgroundColor = Color.White;
            dtgDestinosPorFacturacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDestinosPorFacturacion.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            dtgDestinosPorFacturacion.Location = new Point(396, 62);
            dtgDestinosPorFacturacion.Name = "dtgDestinosPorFacturacion";
            dtgDestinosPorFacturacion.ReadOnly = true;
            dtgDestinosPorFacturacion.RowHeadersVisible = false;
            dtgDestinosPorFacturacion.RowTemplate.Height = 25;
            dtgDestinosPorFacturacion.ScrollBars = ScrollBars.Vertical;
            dtgDestinosPorFacturacion.Size = new Size(371, 196);
            dtgDestinosPorFacturacion.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn5.HeaderText = "Destino";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn6.HeaderText = "Facturacion";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // grpGanancias
            // 
            grpGanancias.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            grpGanancias.Controls.Add(lblGananciasInternacional);
            grpGanancias.Controls.Add(lblGananciasCabotaje);
            grpGanancias.Controls.Add(lblGananciasTotales);
            grpGanancias.Controls.Add(lblGanancias);
            grpGanancias.Location = new Point(875, 47);
            grpGanancias.Name = "grpGanancias";
            grpGanancias.Size = new Size(244, 172);
            grpGanancias.TabIndex = 11;
            grpGanancias.TabStop = false;
            // 
            // lblGananciasInternacional
            // 
            lblGananciasInternacional.AutoSize = true;
            lblGananciasInternacional.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblGananciasInternacional.Location = new Point(11, 120);
            lblGananciasInternacional.Name = "lblGananciasInternacional";
            lblGananciasInternacional.Size = new Size(116, 19);
            lblGananciasInternacional.TabIndex = 14;
            lblGananciasInternacional.Text = "Internacional : $";
            // 
            // lblGananciasCabotaje
            // 
            lblGananciasCabotaje.AutoSize = true;
            lblGananciasCabotaje.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblGananciasCabotaje.Location = new Point(11, 74);
            lblGananciasCabotaje.Name = "lblGananciasCabotaje";
            lblGananciasCabotaje.Size = new Size(89, 19);
            lblGananciasCabotaje.TabIndex = 13;
            lblGananciasCabotaje.Text = "Cabotaje : $";
            // 
            // lblGananciasTotales
            // 
            lblGananciasTotales.AutoSize = true;
            lblGananciasTotales.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblGananciasTotales.Location = new Point(11, 34);
            lblGananciasTotales.Name = "lblGananciasTotales";
            lblGananciasTotales.Size = new Size(77, 19);
            lblGananciasTotales.TabIndex = 12;
            lblGananciasTotales.Text = "Totales : $";
            // 
            // lblGanancias
            // 
            lblGanancias.AutoSize = true;
            lblGanancias.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblGanancias.Location = new Point(11, 0);
            lblGanancias.Name = "lblGanancias";
            lblGanancias.Size = new Size(92, 19);
            lblGanancias.TabIndex = 4;
            lblGanancias.Text = "GANANCIAS";
            // 
            // FrmEstadisticasHistoricas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1166, 519);
            Controls.Add(grpGanancias);
            Controls.Add(dtgDestinosPorFacturacion);
            Controls.Add(lblDestinosPorFacturacion);
            Controls.Add(lblHorasAeronave);
            Controls.Add(dtgHorasPorAeronave);
            Controls.Add(grpDestinoMasElegido);
            Controls.Add(dtgCantidadPasajerosPorVuelo);
            Controls.Add(lblPasajerosPorVuelo);
            Controls.Add(lblPasajerosFrecuentes);
            Controls.Add(dtgPasajerosFrecuentes);
            MinimumSize = new Size(1182, 558);
            Name = "FrmEstadisticasHistoricas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Estadisticas Historicas";
            Load += FrmDatosHistoricos_Load;
            Controls.SetChildIndex(dtgPasajerosFrecuentes, 0);
            Controls.SetChildIndex(lblPasajerosFrecuentes, 0);
            Controls.SetChildIndex(lblPasajerosPorVuelo, 0);
            Controls.SetChildIndex(dtgCantidadPasajerosPorVuelo, 0);
            Controls.SetChildIndex(grpDestinoMasElegido, 0);
            Controls.SetChildIndex(dtgHorasPorAeronave, 0);
            Controls.SetChildIndex(lblHorasAeronave, 0);
            Controls.SetChildIndex(lblDestinosPorFacturacion, 0);
            Controls.SetChildIndex(dtgDestinosPorFacturacion, 0);
            Controls.SetChildIndex(btnAgregar, 0);
            Controls.SetChildIndex(btnModificar, 0);
            Controls.SetChildIndex(btnBorrar, 0);
            Controls.SetChildIndex(btnVolver, 0);
            Controls.SetChildIndex(grpGanancias, 0);
            ((System.ComponentModel.ISupportInitialize)dtgPasajerosFrecuentes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgCantidadPasajerosPorVuelo).EndInit();
            grpDestinoMasElegido.ResumeLayout(false);
            grpDestinoMasElegido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgHorasPorAeronave).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgDestinosPorFacturacion).EndInit();
            grpGanancias.ResumeLayout(false);
            grpGanancias.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgPasajerosFrecuentes;
        private DataGridViewTextBoxColumn nombreGrid;
        private DataGridViewTextBoxColumn vueloGrid;
        private Label lblPasajerosFrecuentes;
        private Label lblPasajerosPorVuelo;
        private DataGridView dtgCantidadPasajerosPorVuelo;
        private Label lblDestinoMasElegido;
        private GroupBox grpDestinoMasElegido;
        private DataGridView dtgHorasPorAeronave;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Label lblHorasAeronave;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private Label lblDestinosPorFacturacion;
        private DataGridView dtgDestinosPorFacturacion;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private GroupBox grpGanancias;
        private Label lblGanancias;
        private Label lblGananciasCabotaje;
        private Label lblGananciasTotales;
        private Label lblGananciasInternacional;
    }
}