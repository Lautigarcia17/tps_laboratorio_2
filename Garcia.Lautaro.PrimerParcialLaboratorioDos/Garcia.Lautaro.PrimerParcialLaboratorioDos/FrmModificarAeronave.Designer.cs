namespace Garcia.Lautaro.PrimerParcialForm
{
    partial class FrmModificarAeronave
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
            SuspendLayout();
            // 
            // txtCantidadAsientos
            // 
            txtCantidadAsientos.Location = new Point(261, 99);
            // 
            // txtCantidadBanios
            // 
            txtCantidadBanios.Location = new Point(261, 143);
            // 
            // txtCapacidadBodega
            // 
            txtCapacidadBodega.Location = new Point(287, 279);
            // 
            // chkComida
            // 
            chkComida.Location = new Point(302, 233);
            // 
            // chkInternet
            // 
            chkInternet.Location = new Point(131, 233);
            // 
            // lblAeronave
            // 
            lblAeronave.BackColor = Color.White;
            lblAeronave.BorderStyle = BorderStyle.FixedSingle;
            lblAeronave.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblAeronave.Location = new Point(25, 47);
            lblAeronave.Size = new Size(186, 33);
            lblAeronave.Text = "MATRICULA : ";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(123, 324);
            btnAgregar.Size = new Size(144, 44);
            // 
            // FrmModificarAeronave
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 380);
            Name = "FrmModificarAeronave";
            Text = "FrmModificarAeronave";
            Load += FrmModificarAeronave_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}