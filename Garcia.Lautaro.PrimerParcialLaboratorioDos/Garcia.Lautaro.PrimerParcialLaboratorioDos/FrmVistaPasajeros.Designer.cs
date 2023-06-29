namespace Garcia.Lautaro.PrimerParcialForm
{
    partial class FrmVistaPasajeros
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
            lblTipoPasajero = new Label();
            SuspendLayout();
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(917, 144);
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(917, 203);
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(917, 260);
            // 
            // lblTipoPasajero
            // 
            lblTipoPasajero.AutoSize = true;
            lblTipoPasajero.Font = new Font("Microsoft YaHei UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTipoPasajero.Location = new Point(331, 9);
            lblTipoPasajero.Name = "lblTipoPasajero";
            lblTipoPasajero.Size = new Size(0, 50);
            lblTipoPasajero.TabIndex = 7;
            // 
            // FrmVistaPasajeros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 561);
            Controls.Add(lblTipoPasajero);
            MinimumSize = new Size(877, 600);
            Name = "FrmVistaPasajeros";
            Text = "Lista De Pasajeros";
            Load += FrmVistaPasajeros_Load;
            Controls.SetChildIndex(lblTipoPasajero, 0);
            Controls.SetChildIndex(btnAgregar, 0);
            Controls.SetChildIndex(btnModificar, 0);
            Controls.SetChildIndex(btnBorrar, 0);
            Controls.SetChildIndex(btnVolver, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTipoPasajero;
    }
}