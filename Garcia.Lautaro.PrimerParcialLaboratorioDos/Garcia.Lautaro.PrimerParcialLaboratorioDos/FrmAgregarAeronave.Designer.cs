namespace Garcia.Lautaro.PrimerParcialForm
{
    partial class FrmAgregarAeronave
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
            lblAeronave = new Label();
            lblCantidadAsientos = new Label();
            txtCantidadAsientos = new TextBox();
            label1 = new Label();
            txtCantidadBanios = new TextBox();
            label3 = new Label();
            txtCapacidadBodega = new TextBox();
            chkComida = new CheckBox();
            chkInternet = new CheckBox();
            lblOfrece = new Label();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Bottom;
            btnAgregar.Location = new Point(128, 322);
            btnAgregar.Size = new Size(153, 54);
            // 
            // lblAeronave
            // 
            lblAeronave.Anchor = AnchorStyles.Top;
            lblAeronave.AutoSize = true;
            lblAeronave.Font = new Font("Microsoft YaHei UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblAeronave.Location = new Point(103, 35);
            lblAeronave.Name = "lblAeronave";
            lblAeronave.Size = new Size(200, 42);
            lblAeronave.TabIndex = 0;
            lblAeronave.Text = "AERONAVE";
            // 
            // lblCantidadAsientos
            // 
            lblCantidadAsientos.Anchor = AnchorStyles.None;
            lblCantidadAsientos.AutoSize = true;
            lblCantidadAsientos.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCantidadAsientos.ForeColor = Color.Black;
            lblCantidadAsientos.Location = new Point(52, 99);
            lblCantidadAsientos.Name = "lblCantidadAsientos";
            lblCantidadAsientos.Size = new Size(141, 19);
            lblCantidadAsientos.TabIndex = 1;
            lblCantidadAsientos.Text = "Cantidad Asientos : ";
            // 
            // txtCantidadAsientos
            // 
            txtCantidadAsientos.Anchor = AnchorStyles.None;
            txtCantidadAsientos.Location = new Point(218, 99);
            txtCantidadAsientos.Name = "txtCantidadAsientos";
            txtCantidadAsientos.ShortcutsEnabled = false;
            txtCantidadAsientos.Size = new Size(85, 23);
            txtCantidadAsientos.TabIndex = 2;
            txtCantidadAsientos.KeyPress += txtCantidadAsientos_KeyPress;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(70, 143);
            label1.Name = "label1";
            label1.Size = new Size(121, 19);
            label1.TabIndex = 3;
            label1.Text = "Cantidad Baños :";
            // 
            // txtCantidadBanios
            // 
            txtCantidadBanios.Anchor = AnchorStyles.None;
            txtCantidadBanios.Location = new Point(218, 143);
            txtCantidadBanios.Name = "txtCantidadBanios";
            txtCantidadBanios.ShortcutsEnabled = false;
            txtCantidadBanios.Size = new Size(85, 23);
            txtCantidadBanios.TabIndex = 4;
            txtCantidadBanios.KeyPress += txtCantidadBanios_KeyPress;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(70, 279);
            label3.Name = "label3";
            label3.Size = new Size(144, 19);
            label3.TabIndex = 8;
            label3.Text = "Capacidad Bodega :";
            // 
            // txtCapacidadBodega
            // 
            txtCapacidadBodega.Anchor = AnchorStyles.None;
            txtCapacidadBodega.Location = new Point(244, 279);
            txtCapacidadBodega.Name = "txtCapacidadBodega";
            txtCapacidadBodega.ShortcutsEnabled = false;
            txtCapacidadBodega.Size = new Size(75, 23);
            txtCapacidadBodega.TabIndex = 9;
            txtCapacidadBodega.KeyPress += textBox1_KeyPress;
            // 
            // chkComida
            // 
            chkComida.Anchor = AnchorStyles.None;
            chkComida.AutoSize = true;
            chkComida.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            chkComida.Location = new Point(259, 233);
            chkComida.Name = "chkComida";
            chkComida.Size = new Size(80, 23);
            chkComida.TabIndex = 12;
            chkComida.Text = "Comida";
            chkComida.UseVisualStyleBackColor = true;
            // 
            // chkInternet
            // 
            chkInternet.Anchor = AnchorStyles.None;
            chkInternet.AutoSize = true;
            chkInternet.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            chkInternet.Location = new Point(88, 233);
            chkInternet.Name = "chkInternet";
            chkInternet.Size = new Size(80, 23);
            chkInternet.TabIndex = 11;
            chkInternet.Text = "Internet";
            chkInternet.UseVisualStyleBackColor = true;
            // 
            // lblOfrece
            // 
            lblOfrece.Anchor = AnchorStyles.None;
            lblOfrece.AutoSize = true;
            lblOfrece.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblOfrece.ForeColor = Color.Black;
            lblOfrece.Location = new Point(159, 185);
            lblOfrece.Name = "lblOfrece";
            lblOfrece.Size = new Size(87, 26);
            lblOfrece.TabIndex = 10;
            lblOfrece.Text = "OFRECE";
            // 
            // FrmAgregarAeronave
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(384, 376);
            Controls.Add(chkComida);
            Controls.Add(chkInternet);
            Controls.Add(lblOfrece);
            Controls.Add(txtCapacidadBodega);
            Controls.Add(label3);
            Controls.Add(txtCantidadBanios);
            Controls.Add(label1);
            Controls.Add(txtCantidadAsientos);
            Controls.Add(lblCantidadAsientos);
            Controls.Add(lblAeronave);
            MinimumSize = new Size(400, 415);
            Name = "FrmAgregarAeronave";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Aeronave";
            Load += FrmAgregarAeronave_Load;
            Controls.SetChildIndex(lblAeronave, 0);
            Controls.SetChildIndex(lblCantidadAsientos, 0);
            Controls.SetChildIndex(txtCantidadAsientos, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(txtCantidadBanios, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(txtCapacidadBodega, 0);
            Controls.SetChildIndex(lblOfrece, 0);
            Controls.SetChildIndex(chkInternet, 0);
            Controls.SetChildIndex(chkComida, 0);
            Controls.SetChildIndex(btnAgregar, 0);
            Controls.SetChildIndex(btnModificar, 0);
            Controls.SetChildIndex(btnBorrar, 0);
            Controls.SetChildIndex(btnVolver, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblOfrece;
        protected TextBox txtCantidadAsientos;
        protected TextBox txtCantidadBanios;
        protected TextBox txtCapacidadBodega;
        protected CheckBox chkComida;
        protected CheckBox chkInternet;
        protected Label lblAeronave;
        protected Label lblCantidadAsientos;
        protected Label label1;
        protected Label label3;
    }
}