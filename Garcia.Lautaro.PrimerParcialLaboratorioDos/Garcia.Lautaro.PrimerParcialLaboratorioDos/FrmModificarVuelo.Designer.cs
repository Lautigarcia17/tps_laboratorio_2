namespace Garcia.Lautaro.PrimerParcialForm
{
    partial class FrmModificarVuelo
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
            ((System.ComponentModel.ISupportInitialize)btnMostrarAeronave).BeginInit();
            SuspendLayout();
            // 
            // cmbOrigen
            // 
            cmbOrigen.Location = new Point(190, 146);
            // 
            // cmbDestino
            // 
            cmbDestino.Location = new Point(190, 185);
            // 
            // dtpFechaVuelo
            // 
            dtpFechaVuelo.Location = new Point(37, 261);
            // 
            // cmbAeronave
            // 
            cmbAeronave.Location = new Point(313, 261);
            // 
            // rbNacional
            // 
            rbNacional.Location = new Point(216, 96);
            // 
            // rbInternacional
            // 
            rbInternacional.Location = new Point(327, 96);
            // 
            // btnMostrarAeronave
            // 
            btnMostrarAeronave.Location = new Point(453, 256);
            // 
            // lblTipoVuelo
            // 
            lblTipoVuelo.Location = new Point(51, 96);
            // 
            // lblOrigen
            // 
            lblOrigen.Location = new Point(82, 150);
            // 
            // lblDestino
            // 
            lblDestino.Location = new Point(78, 189);
            // 
            // lblFechaVuelo
            // 
            lblFechaVuelo.Location = new Point(110, 239);
            // 
            // lblAeronave
            // 
            lblAeronave.Location = new Point(341, 239);
            // 
            // lblVuelo
            // 
            lblVuelo.Location = new Point(190, 38);
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(163, 310);
            // 
            // FrmModificarVuelo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 376);
            Name = "FrmModificarVuelo";
            Text = "Modificar Vuelo";
            Load += FrmModificarVuelo_Load;
            ((System.ComponentModel.ISupportInitialize)btnMostrarAeronave).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}