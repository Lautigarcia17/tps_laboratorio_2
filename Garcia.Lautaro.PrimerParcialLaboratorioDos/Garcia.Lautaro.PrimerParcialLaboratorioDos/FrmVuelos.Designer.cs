namespace Garcia.Lautaro.PrimerParcialForm
{
    partial class FrmVuelos
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dtgListaVuelos = new DataGridView();
            estadoVueloGrid = new DataGridViewTextBoxColumn();
            codigoVueloGrid = new DataGridViewTextBoxColumn();
            origenGrid = new DataGridViewTextBoxColumn();
            destinoGrid = new DataGridViewTextBoxColumn();
            fechaVueloGrid = new DataGridViewTextBoxColumn();
            duracionGrid = new DataGridViewTextBoxColumn();
            avionGrid = new DataGridViewButtonColumn();
            asientosPremiumGrid = new DataGridViewButtonColumn();
            asientosTurista = new DataGridViewButtonColumn();
            costoTuristaGrid = new DataGridViewTextBoxColumn();
            costoPremiumGrid = new DataGridViewTextBoxColumn();
            pasajerosGrid = new DataGridViewButtonColumn();
            sugerenciaToolTipVuelo = new ToolTip(components);
            btnComprarPasaje = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgListaVuelos).BeginInit();
            SuspendLayout();
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.Top;
            btnModificar.Location = new Point(759, 6);
            // 
            // btnBorrar
            // 
            btnBorrar.Anchor = AnchorStyles.Top;
            btnBorrar.Location = new Point(540, 6);
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top;
            btnAgregar.Location = new Point(310, 6);
            // 
            // dtgListaVuelos
            // 
            dtgListaVuelos.AllowUserToAddRows = false;
            dtgListaVuelos.AllowUserToResizeColumns = false;
            dtgListaVuelos.AllowUserToResizeRows = false;
            dtgListaVuelos.Anchor = AnchorStyles.None;
            dtgListaVuelos.BackgroundColor = Color.White;
            dtgListaVuelos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgListaVuelos.Columns.AddRange(new DataGridViewColumn[] { estadoVueloGrid, codigoVueloGrid, origenGrid, destinoGrid, fechaVueloGrid, duracionGrid, avionGrid, asientosPremiumGrid, asientosTurista, costoTuristaGrid, costoPremiumGrid, pasajerosGrid });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtgListaVuelos.DefaultCellStyle = dataGridViewCellStyle2;
            dtgListaVuelos.Location = new Point(12, 78);
            dtgListaVuelos.Name = "dtgListaVuelos";
            dtgListaVuelos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dtgListaVuelos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dtgListaVuelos.RowHeadersVisible = false;
            dtgListaVuelos.RowTemplate.Height = 25;
            dtgListaVuelos.Size = new Size(1197, 378);
            dtgListaVuelos.TabIndex = 0;
            dtgListaVuelos.CellContentClick += dtgListaVuelos_CellContentClick;
            // 
            // estadoVueloGrid
            // 
            estadoVueloGrid.HeaderText = "Estado";
            estadoVueloGrid.Name = "estadoVueloGrid";
            estadoVueloGrid.ReadOnly = true;
            // 
            // codigoVueloGrid
            // 
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            codigoVueloGrid.DefaultCellStyle = dataGridViewCellStyle1;
            codigoVueloGrid.HeaderText = "Codigo";
            codigoVueloGrid.Name = "codigoVueloGrid";
            codigoVueloGrid.ReadOnly = true;
            // 
            // origenGrid
            // 
            origenGrid.HeaderText = "Origen";
            origenGrid.Name = "origenGrid";
            origenGrid.ReadOnly = true;
            // 
            // destinoGrid
            // 
            destinoGrid.HeaderText = "Destino";
            destinoGrid.Name = "destinoGrid";
            destinoGrid.ReadOnly = true;
            // 
            // fechaVueloGrid
            // 
            fechaVueloGrid.HeaderText = "Fecha Vuelo";
            fechaVueloGrid.Name = "fechaVueloGrid";
            fechaVueloGrid.ReadOnly = true;
            // 
            // duracionGrid
            // 
            duracionGrid.HeaderText = "Duracion";
            duracionGrid.Name = "duracionGrid";
            duracionGrid.ReadOnly = true;
            // 
            // avionGrid
            // 
            avionGrid.HeaderText = "Avion";
            avionGrid.Name = "avionGrid";
            avionGrid.ReadOnly = true;
            // 
            // asientosPremiumGrid
            // 
            asientosPremiumGrid.HeaderText = "Asientos Premium";
            asientosPremiumGrid.Name = "asientosPremiumGrid";
            asientosPremiumGrid.ReadOnly = true;
            asientosPremiumGrid.Resizable = DataGridViewTriState.True;
            asientosPremiumGrid.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // asientosTurista
            // 
            asientosTurista.HeaderText = "Asientos Turista";
            asientosTurista.Name = "asientosTurista";
            asientosTurista.ReadOnly = true;
            asientosTurista.Resizable = DataGridViewTriState.True;
            asientosTurista.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // costoTuristaGrid
            // 
            costoTuristaGrid.HeaderText = "Costo Turista";
            costoTuristaGrid.Name = "costoTuristaGrid";
            costoTuristaGrid.ReadOnly = true;
            // 
            // costoPremiumGrid
            // 
            costoPremiumGrid.HeaderText = "Costo Premium";
            costoPremiumGrid.Name = "costoPremiumGrid";
            costoPremiumGrid.ReadOnly = true;
            // 
            // pasajerosGrid
            // 
            pasajerosGrid.HeaderText = "Pasajeros";
            pasajerosGrid.Name = "pasajerosGrid";
            pasajerosGrid.ReadOnly = true;
            // 
            // btnComprarPasaje
            // 
            btnComprarPasaje.Anchor = AnchorStyles.Right;
            btnComprarPasaje.BackColor = Color.FromArgb(255, 128, 0);
            btnComprarPasaje.FlatStyle = FlatStyle.Flat;
            btnComprarPasaje.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnComprarPasaje.ForeColor = Color.White;
            btnComprarPasaje.Location = new Point(1006, 31);
            btnComprarPasaje.Name = "btnComprarPasaje";
            btnComprarPasaje.Size = new Size(203, 41);
            btnComprarPasaje.TabIndex = 7;
            btnComprarPasaje.Text = "COMPRAR PASAJE";
            btnComprarPasaje.UseVisualStyleBackColor = false;
            btnComprarPasaje.Click += btnComprarPasaje_Click;
            // 
            // FrmVuelos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1219, 505);
            Controls.Add(dtgListaVuelos);
            Controls.Add(btnComprarPasaje);
            MinimumSize = new Size(1235, 544);
            Name = "FrmVuelos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de Vuelos";
            Load += FrmVuelos_Load;
            Controls.SetChildIndex(btnAgregar, 0);
            Controls.SetChildIndex(btnModificar, 0);
            Controls.SetChildIndex(btnBorrar, 0);
            Controls.SetChildIndex(btnVolver, 0);
            Controls.SetChildIndex(btnComprarPasaje, 0);
            Controls.SetChildIndex(dtgListaVuelos, 0);
            ((System.ComponentModel.ISupportInitialize)dtgListaVuelos).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ToolTip sugerenciaToolTipVuelo;
        private Button btnComprarPasaje;
        private DataGridViewTextBoxColumn estadoVueloGrid;
        private DataGridViewTextBoxColumn codigoVueloGrid;
        private DataGridViewTextBoxColumn origenGrid;
        private DataGridViewTextBoxColumn destinoGrid;
        private DataGridViewTextBoxColumn fechaVueloGrid;
        private DataGridViewTextBoxColumn duracionGrid;
        private DataGridViewButtonColumn avionGrid;
        private DataGridViewButtonColumn asientosPremiumGrid;
        private DataGridViewButtonColumn asientosTurista;
        private DataGridViewTextBoxColumn costoTuristaGrid;
        private DataGridViewTextBoxColumn costoPremiumGrid;
        private DataGridViewButtonColumn pasajerosGrid;
        protected DataGridView dtgListaVuelos;
    }
}