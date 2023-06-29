namespace Garcia.Lautaro.PrimerParcialForm
{
    partial class FrmPasajeros
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dtgPasajeros = new DataGridView();
            cantidadVuelosGrid = new DataGridViewTextBoxColumn();
            dniGrid = new DataGridViewTextBoxColumn();
            nombreGrid = new DataGridViewTextBoxColumn();
            apellidoGrid = new DataGridViewTextBoxColumn();
            edadGrid = new DataGridViewTextBoxColumn();
            equipajeGrid = new DataGridViewTextBoxColumn();
            btnVolverVuelos = new Button();
            txtFilter = new TextBox();
            lblFiltrado = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgPasajeros).BeginInit();
            SuspendLayout();
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnModificar.Location = new Point(724, 25);
            btnModificar.Size = new Size(123, 53);
            // 
            // btnBorrar
            // 
            btnBorrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBorrar.Location = new Point(583, 24);
            btnBorrar.Size = new Size(123, 51);
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregar.Location = new Point(436, 24);
            btnAgregar.Size = new Size(123, 54);
            // 
            // dtgPasajeros
            // 
            dtgPasajeros.AllowUserToAddRows = false;
            dtgPasajeros.AllowUserToResizeColumns = false;
            dtgPasajeros.AllowUserToResizeRows = false;
            dtgPasajeros.Anchor = AnchorStyles.None;
            dtgPasajeros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgPasajeros.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dtgPasajeros.BackgroundColor = Color.White;
            dtgPasajeros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgPasajeros.Columns.AddRange(new DataGridViewColumn[] { cantidadVuelosGrid, dniGrid, nombreGrid, apellidoGrid, edadGrid, equipajeGrid });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtgPasajeros.DefaultCellStyle = dataGridViewCellStyle2;
            dtgPasajeros.Location = new Point(56, 120);
            dtgPasajeros.Name = "dtgPasajeros";
            dtgPasajeros.ReadOnly = true;
            dtgPasajeros.RowHeadersVisible = false;
            dtgPasajeros.RowTemplate.Height = 25;
            dtgPasajeros.Size = new Size(718, 303);
            dtgPasajeros.TabIndex = 0;
            // 
            // cantidadVuelosGrid
            // 
            cantidadVuelosGrid.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cantidadVuelosGrid.FillWeight = 35.4062576F;
            cantidadVuelosGrid.HeaderText = "Vuelos";
            cantidadVuelosGrid.Name = "cantidadVuelosGrid";
            cantidadVuelosGrid.ReadOnly = true;
            cantidadVuelosGrid.ToolTipText = "Cantidad de vuelos comprados";
            // 
            // dniGrid
            // 
            dniGrid.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dniGrid.FillWeight = 39.2069321F;
            dniGrid.HeaderText = "Dni";
            dniGrid.Name = "dniGrid";
            dniGrid.ReadOnly = true;
            // 
            // nombreGrid
            // 
            nombreGrid.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nombreGrid.FillWeight = 52.81218F;
            nombreGrid.HeaderText = "Nombre";
            nombreGrid.Name = "nombreGrid";
            nombreGrid.ReadOnly = true;
            // 
            // apellidoGrid
            // 
            apellidoGrid.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            apellidoGrid.FillWeight = 52.81218F;
            apellidoGrid.HeaderText = "Apellido";
            apellidoGrid.Name = "apellidoGrid";
            apellidoGrid.ReadOnly = true;
            // 
            // edadGrid
            // 
            edadGrid.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            edadGrid.FillWeight = 52.81218F;
            edadGrid.HeaderText = "Edad";
            edadGrid.Name = "edadGrid";
            edadGrid.ReadOnly = true;
            // 
            // equipajeGrid
            // 
            equipajeGrid.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            equipajeGrid.DefaultCellStyle = dataGridViewCellStyle1;
            equipajeGrid.FillWeight = 153.138535F;
            equipajeGrid.HeaderText = "Equipaje";
            equipajeGrid.Name = "equipajeGrid";
            equipajeGrid.ReadOnly = true;
            equipajeGrid.Visible = false;
            // 
            // btnVolverVuelos
            // 
            btnVolverVuelos.BackColor = Color.Cyan;
            btnVolverVuelos.FlatStyle = FlatStyle.Flat;
            btnVolverVuelos.Font = new Font("Gadugi", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnVolverVuelos.Location = new Point(0, 1);
            btnVolverVuelos.Name = "btnVolverVuelos";
            btnVolverVuelos.Size = new Size(112, 31);
            btnVolverVuelos.TabIndex = 2;
            btnVolverVuelos.Text = "Volver";
            btnVolverVuelos.UseVisualStyleBackColor = false;
            // 
            // txtFilter
            // 
            txtFilter.Anchor = AnchorStyles.None;
            txtFilter.Location = new Point(56, 81);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(212, 23);
            txtFilter.TabIndex = 7;
            txtFilter.TextChanged += txtFilter_TextChanged;
            // 
            // lblFiltrado
            // 
            lblFiltrado.Anchor = AnchorStyles.None;
            lblFiltrado.AutoSize = true;
            lblFiltrado.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblFiltrado.Location = new Point(56, 59);
            lblFiltrado.Name = "lblFiltrado";
            lblFiltrado.Size = new Size(197, 19);
            lblFiltrado.TabIndex = 8;
            lblFiltrado.Text = "Filtrado (nombre / apellido)";
            // 
            // FrmPasajeros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 435);
            Controls.Add(lblFiltrado);
            Controls.Add(txtFilter);
            Controls.Add(btnVolverVuelos);
            Controls.Add(dtgPasajeros);
            MinimumSize = new Size(871, 474);
            Name = "FrmPasajeros";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de Pasajeros";
            Load += FrmPasajeros_Load;
            Controls.SetChildIndex(dtgPasajeros, 0);
            Controls.SetChildIndex(btnVolverVuelos, 0);
            Controls.SetChildIndex(btnAgregar, 0);
            Controls.SetChildIndex(btnModificar, 0);
            Controls.SetChildIndex(btnBorrar, 0);
            Controls.SetChildIndex(btnVolver, 0);
            Controls.SetChildIndex(txtFilter, 0);
            Controls.SetChildIndex(lblFiltrado, 0);
            ((System.ComponentModel.ISupportInitialize)dtgPasajeros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnVolverVuelos;
        public DataGridView dtgPasajeros;
        private DataGridViewTextBoxColumn cantidadVuelosGrid;
        private DataGridViewTextBoxColumn dniGrid;
        private DataGridViewTextBoxColumn nombreGrid;
        private DataGridViewTextBoxColumn apellidoGrid;
        private DataGridViewTextBoxColumn edadGrid;
        private DataGridViewTextBoxColumn equipajeGrid;
        private TextBox txtFilter;
        private Label lblFiltrado;
    }
}