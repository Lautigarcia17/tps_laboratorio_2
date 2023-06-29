namespace Garcia.Lautaro.PrimerParcialForm
{
    partial class FrmBorrarVuelo
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
            cmbOrigen.Location = new Point(213, 160);
            // 
            // cmbDestino
            // 
            cmbDestino.Location = new Point(213, 195);
            // 
            // dtpFechaVuelo
            // 
            dtpFechaVuelo.Location = new Point(23, 266);
            // 
            // cmbAeronave
            // 
            cmbAeronave.Location = new Point(319, 266);
            // 
            // rbNacional
            // 
            rbNacional.Location = new Point(234, 106);
            // 
            // rbInternacional
            // 
            rbInternacional.Location = new Point(330, 106);
            // 
            // lblTipoVuelo
            // 
            lblTipoVuelo.Location = new Point(78, 106);
            // 
            // lblOrigen
            // 
            lblOrigen.Location = new Point(120, 164);
            // 
            // lblDestino
            // 
            lblDestino.Location = new Point(120, 199);
            // 
            // lblFechaVuelo
            // 
            lblFechaVuelo.Location = new Point(100, 244);
            // 
            // lblAeronave
            // 
            lblAeronave.Location = new Point(353, 244);
            // 
            // lblVuelo
            // 
            lblVuelo.Location = new Point(223, 45);
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(203, 312);
            // 
            // FrmBorrarVuelo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 389);
            Name = "FrmBorrarVuelo";
            Text = "Borrar Vuelo";
            Load += FrmBorrarVuelo_Load;
            ((System.ComponentModel.ISupportInitialize)btnMostrarAeronave).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}