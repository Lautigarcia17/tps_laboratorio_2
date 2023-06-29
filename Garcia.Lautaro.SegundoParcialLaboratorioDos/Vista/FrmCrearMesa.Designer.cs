namespace Vista
{
    partial class FrmCrearMesa
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
            lblMesa = new Label();
            lblJugadorUno = new Label();
            lblJugadorDos = new Label();
            cmbJugadorUno = new ComboBox();
            cmbJugadorDos = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnVolver).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            SuspendLayout();
            // 
            // btnIniciar
            // 
            btnIniciar.Anchor = AnchorStyles.None;
            btnIniciar.BackColor = Color.FromArgb(128, 255, 128);
            btnIniciar.FlatAppearance.BorderSize = 3;
            btnIniciar.Font = new Font("Lucida Console", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnIniciar.ForeColor = SystemColors.ActiveCaptionText;
            btnIniciar.Location = new Point(136, 235);
            btnIniciar.Size = new Size(236, 65);
            btnIniciar.Text = "Crear";
            // 
            // btnMaximizar
            // 
            btnMaximizar.Location = new Point(593, 1);
            // 
            // btnMinimizar
            // 
            btnMinimizar.Location = new Point(557, 1);
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(2, 0);
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(629, 1);
            // 
            // lblMesa
            // 
            lblMesa.Anchor = AnchorStyles.Top;
            lblMesa.AutoSize = true;
            lblMesa.Font = new Font("Lucida Console", 48F, FontStyle.Bold, GraphicsUnit.Point);
            lblMesa.Location = new Point(163, 24);
            lblMesa.Name = "lblMesa";
            lblMesa.Size = new Size(188, 65);
            lblMesa.TabIndex = 0;
            lblMesa.Text = "MESA";
            // 
            // lblJugadorUno
            // 
            lblJugadorUno.Anchor = AnchorStyles.None;
            lblJugadorUno.AutoSize = true;
            lblJugadorUno.Font = new Font("Lucida Console", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblJugadorUno.Location = new Point(50, 123);
            lblJugadorUno.Name = "lblJugadorUno";
            lblJugadorUno.Size = new Size(127, 21);
            lblJugadorUno.TabIndex = 1;
            lblJugadorUno.Text = "Jugador 1";
            // 
            // lblJugadorDos
            // 
            lblJugadorDos.Anchor = AnchorStyles.None;
            lblJugadorDos.AutoSize = true;
            lblJugadorDos.Font = new Font("Lucida Console", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblJugadorDos.Location = new Point(322, 123);
            lblJugadorDos.Name = "lblJugadorDos";
            lblJugadorDos.Size = new Size(127, 21);
            lblJugadorDos.TabIndex = 2;
            lblJugadorDos.Text = "Jugador 2";
            // 
            // cmbJugadorUno
            // 
            cmbJugadorUno.Anchor = AnchorStyles.None;
            cmbJugadorUno.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbJugadorUno.FormattingEnabled = true;
            cmbJugadorUno.Location = new Point(12, 158);
            cmbJugadorUno.Name = "cmbJugadorUno";
            cmbJugadorUno.Size = new Size(220, 23);
            cmbJugadorUno.TabIndex = 3;
            // 
            // cmbJugadorDos
            // 
            cmbJugadorDos.Anchor = AnchorStyles.None;
            cmbJugadorDos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbJugadorDos.FormattingEnabled = true;
            cmbJugadorDos.Location = new Point(262, 158);
            cmbJugadorDos.Name = "cmbJugadorDos";
            cmbJugadorDos.Size = new Size(220, 23);
            cmbJugadorDos.TabIndex = 4;
            // 
            // FrmCrearMesa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(490, 312);
            Controls.Add(cmbJugadorDos);
            Controls.Add(cmbJugadorUno);
            Controls.Add(lblJugadorDos);
            Controls.Add(lblJugadorUno);
            Controls.Add(lblMesa);
            MinimumSize = new Size(492, 328);
            Name = "FrmCrearMesa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crear Mesa";
            Load += FrmCrearMesa_Load;
            Controls.SetChildIndex(lblMesa, 0);
            Controls.SetChildIndex(lblJugadorUno, 0);
            Controls.SetChildIndex(lblJugadorDos, 0);
            Controls.SetChildIndex(cmbJugadorUno, 0);
            Controls.SetChildIndex(cmbJugadorDos, 0);
            Controls.SetChildIndex(btnIniciar, 0);
            Controls.SetChildIndex(btnCerrar, 0);
            Controls.SetChildIndex(btnMaximizar, 0);
            Controls.SetChildIndex(btnMinimizar, 0);
            Controls.SetChildIndex(btnVolver, 0);
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnVolver).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMesa;
        private Label lblJugadorUno;
        private Label lblJugadorDos;
        private ComboBox cmbJugadorUno;
        private ComboBox cmbJugadorDos;
    }
}