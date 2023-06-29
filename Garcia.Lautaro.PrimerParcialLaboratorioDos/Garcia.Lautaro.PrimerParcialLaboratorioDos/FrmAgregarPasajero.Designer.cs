namespace Garcia.Lautaro.PrimerParcialForm
{
    partial class FrmAgregarPasajero
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
            lblPasajero = new Label();
            lblNombre = new Label();
            lblApellido = new Label();
            lblDni = new Label();
            lblEdad = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDni = new TextBox();
            txtEdad = new TextBox();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Size = new Size(95, 29);
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Bottom;
            btnAgregar.Location = new Point(154, 278);
            btnAgregar.Size = new Size(157, 50);
            // 
            // lblPasajero
            // 
            lblPasajero.Anchor = AnchorStyles.Top;
            lblPasajero.AutoSize = true;
            lblPasajero.Font = new Font("Microsoft YaHei UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPasajero.ForeColor = Color.Black;
            lblPasajero.Location = new Point(144, 54);
            lblPasajero.Name = "lblPasajero";
            lblPasajero.Size = new Size(205, 46);
            lblPasajero.TabIndex = 7;
            lblPasajero.Text = "PASAJERO";
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.None;
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(8, 150);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(88, 22);
            lblNombre.TabIndex = 8;
            lblNombre.Text = "Nombre :";
            // 
            // lblApellido
            // 
            lblApellido.Anchor = AnchorStyles.None;
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblApellido.Location = new Point(8, 199);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(89, 22);
            lblApellido.TabIndex = 9;
            lblApellido.Text = "Apellido :";
            // 
            // lblDni
            // 
            lblDni.Anchor = AnchorStyles.None;
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDni.Location = new Point(293, 147);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(48, 22);
            lblDni.TabIndex = 10;
            lblDni.Text = "Dni :";
            // 
            // lblEdad
            // 
            lblEdad.Anchor = AnchorStyles.None;
            lblEdad.AutoSize = true;
            lblEdad.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEdad.Location = new Point(284, 199);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(65, 22);
            lblEdad.TabIndex = 11;
            lblEdad.Text = "Edad : ";
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.None;
            txtNombre.Location = new Point(102, 149);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(131, 23);
            txtNombre.TabIndex = 12;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // txtApellido
            // 
            txtApellido.Anchor = AnchorStyles.None;
            txtApellido.Location = new Point(102, 201);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(131, 23);
            txtApellido.TabIndex = 13;
            txtApellido.KeyPress += txtApellido_KeyPress;
            // 
            // txtDni
            // 
            txtDni.Anchor = AnchorStyles.None;
            txtDni.Location = new Point(357, 147);
            txtDni.MaxLength = 8;
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(62, 23);
            txtDni.TabIndex = 14;
            txtDni.KeyPress += txtDni_KeyPress;
            txtDni.Leave += txtDni_Leave;
            // 
            // txtEdad
            // 
            txtEdad.Anchor = AnchorStyles.None;
            txtEdad.Location = new Point(357, 198);
            txtEdad.MaxLength = 3;
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(62, 23);
            txtEdad.TabIndex = 15;
            txtEdad.KeyPress += txtEdad_KeyPress;
            // 
            // FrmAgregarPasajero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 340);
            Controls.Add(txtEdad);
            Controls.Add(txtDni);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblEdad);
            Controls.Add(lblDni);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblPasajero);
            MinimumSize = new Size(447, 379);
            Name = "FrmAgregarPasajero";
            Text = "FrmAgregarPasajero";
            Load += FrmAgregarPasajero_Load;
            Controls.SetChildIndex(btnAgregar, 0);
            Controls.SetChildIndex(btnModificar, 0);
            Controls.SetChildIndex(btnBorrar, 0);
            Controls.SetChildIndex(btnVolver, 0);
            Controls.SetChildIndex(lblPasajero, 0);
            Controls.SetChildIndex(lblNombre, 0);
            Controls.SetChildIndex(lblApellido, 0);
            Controls.SetChildIndex(lblDni, 0);
            Controls.SetChildIndex(lblEdad, 0);
            Controls.SetChildIndex(txtNombre, 0);
            Controls.SetChildIndex(txtApellido, 0);
            Controls.SetChildIndex(txtDni, 0);
            Controls.SetChildIndex(txtEdad, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblNombre;
        private Label lblApellido;
        private Label lblDni;
        private Label lblEdad;
        protected TextBox txtNombre;
        protected TextBox txtApellido;
        protected TextBox txtEdad;
        protected TextBox txtDni;
        private Label lblPasajero;
    }
}