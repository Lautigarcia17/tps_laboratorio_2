namespace Garcia.Lautaro.PrimerParcialForm
{
    partial class FrmEliminarAeronave
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
            txtCantidadAsientos.Location = new Point(241, 95);
            // 
            // txtCantidadBanios
            // 
            txtCantidadBanios.Location = new Point(241, 139);
            // 
            // txtCapacidadBodega
            // 
            txtCapacidadBodega.Location = new Point(241, 281);
            // 
            // chkComida
            // 
            chkComida.Location = new Point(241, 235);
            // 
            // chkInternet
            // 
            chkInternet.Location = new Point(93, 235);
            // 
            // lblAeronave
            // 
            lblAeronave.BorderStyle = BorderStyle.FixedSingle;
            lblAeronave.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblAeronave.Location = new Point(115, 46);
            lblAeronave.Size = new Size(186, 33);
            lblAeronave.Text = "MATRICULA : ";
            // 
            // lblCantidadAsientos
            // 
            lblCantidadAsientos.Location = new Point(75, 99);
            // 
            // label1
            // 
            label1.Location = new Point(84, 143);
            // 
            // label3
            // 
            label3.Location = new Point(61, 281);
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(126, 325);
            btnAgregar.Size = new Size(153, 53);
            // 
            // FrmEliminarAeronave
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 381);
            Name = "FrmEliminarAeronave";
            Text = "FrmEliminarAeronave";
            Load += FrmEliminarAeronave_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}