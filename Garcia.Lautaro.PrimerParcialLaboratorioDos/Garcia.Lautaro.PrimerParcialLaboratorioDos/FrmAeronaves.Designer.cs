namespace Garcia.Lautaro.PrimerParcialForm
{
    partial class FrmAeronaves
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
            dtgListaAeronaves = new DataGridView();
            cantidadVuelosGrid = new DataGridViewTextBoxColumn();
            matriculaGrid = new DataGridViewTextBoxColumn();
            cantidadAsientosGrid = new DataGridViewTextBoxColumn();
            cantidadBaniosGrid = new DataGridViewTextBoxColumn();
            internetGrid = new DataGridViewCheckBoxColumn();
            comidaGrid = new DataGridViewCheckBoxColumn();
            capacidadBodegaGrid = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgListaAeronaves).BeginInit();
            SuspendLayout();
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.Right;
            btnModificar.Location = new Point(751, 202);
            // 
            // btnBorrar
            // 
            btnBorrar.Anchor = AnchorStyles.Right;
            btnBorrar.Location = new Point(752, 136);
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Right;
            btnAgregar.Location = new Point(751, 66);
            // 
            // dtgListaAeronaves
            // 
            dtgListaAeronaves.AllowUserToAddRows = false;
            dtgListaAeronaves.AllowUserToResizeColumns = false;
            dtgListaAeronaves.AllowUserToResizeRows = false;
            dtgListaAeronaves.Anchor = AnchorStyles.None;
            dtgListaAeronaves.BackgroundColor = Color.White;
            dtgListaAeronaves.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgListaAeronaves.Columns.AddRange(new DataGridViewColumn[] { cantidadVuelosGrid, matriculaGrid, cantidadAsientosGrid, cantidadBaniosGrid, internetGrid, comidaGrid, capacidadBodegaGrid });
            dtgListaAeronaves.Location = new Point(22, 49);
            dtgListaAeronaves.Name = "dtgListaAeronaves";
            dtgListaAeronaves.RowHeadersVisible = false;
            dtgListaAeronaves.RowTemplate.Height = 25;
            dtgListaAeronaves.Size = new Size(703, 342);
            dtgListaAeronaves.TabIndex = 0;
            // 
            // cantidadVuelosGrid
            // 
            cantidadVuelosGrid.HeaderText = "Cantidad Vuelos";
            cantidadVuelosGrid.Name = "cantidadVuelosGrid";
            cantidadVuelosGrid.ReadOnly = true;
            // 
            // matriculaGrid
            // 
            matriculaGrid.HeaderText = "Matricula";
            matriculaGrid.Name = "matriculaGrid";
            matriculaGrid.ReadOnly = true;
            // 
            // cantidadAsientosGrid
            // 
            cantidadAsientosGrid.HeaderText = "Cantidad Asientos";
            cantidadAsientosGrid.Name = "cantidadAsientosGrid";
            cantidadAsientosGrid.ReadOnly = true;
            // 
            // cantidadBaniosGrid
            // 
            cantidadBaniosGrid.HeaderText = "Cantidad Baños";
            cantidadBaniosGrid.Name = "cantidadBaniosGrid";
            cantidadBaniosGrid.ReadOnly = true;
            // 
            // internetGrid
            // 
            internetGrid.HeaderText = "Internet";
            internetGrid.Name = "internetGrid";
            internetGrid.ReadOnly = true;
            // 
            // comidaGrid
            // 
            comidaGrid.HeaderText = "Comida";
            comidaGrid.Name = "comidaGrid";
            comidaGrid.ReadOnly = true;
            // 
            // capacidadBodegaGrid
            // 
            capacidadBodegaGrid.HeaderText = "Capacidad Bodega";
            capacidadBodegaGrid.Name = "capacidadBodegaGrid";
            capacidadBodegaGrid.ReadOnly = true;
            // 
            // FrmAeronaves
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 407);
            Controls.Add(dtgListaAeronaves);
            MinimumSize = new Size(900, 446);
            Name = "FrmAeronaves";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de Aeronaves";
            Load += FrmAeronaves_Load;
            Controls.SetChildIndex(dtgListaAeronaves, 0);
            Controls.SetChildIndex(btnAgregar, 0);
            Controls.SetChildIndex(btnModificar, 0);
            Controls.SetChildIndex(btnBorrar, 0);
            Controls.SetChildIndex(btnVolver, 0);
            ((System.ComponentModel.ISupportInitialize)dtgListaAeronaves).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgListaAeronaves;
        private DataGridViewTextBoxColumn cantidadVuelosGrid;
        private DataGridViewTextBoxColumn matriculaGrid;
        private DataGridViewTextBoxColumn cantidadAsientosGrid;
        private DataGridViewTextBoxColumn cantidadBaniosGrid;
        private DataGridViewCheckBoxColumn internetGrid;
        private DataGridViewCheckBoxColumn comidaGrid;
        private DataGridViewTextBoxColumn capacidadBodegaGrid;
    }
}