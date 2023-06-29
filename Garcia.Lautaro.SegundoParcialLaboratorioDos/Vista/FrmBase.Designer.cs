namespace Vista
{
    partial class FrmBase
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
            btnIniciar = new Button();
            btnMaximizar = new PictureBox();
            btnMinimizar = new PictureBox();
            btnVolver = new PictureBox();
            btnCerrar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnVolver).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            SuspendLayout();
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.DarkGray;
            btnIniciar.FlatAppearance.BorderSize = 3;
            btnIniciar.FlatStyle = FlatStyle.Flat;
            btnIniciar.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnIniciar.ForeColor = SystemColors.ControlLightLight;
            btnIniciar.Location = new Point(220, 263);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(185, 51);
            btnIniciar.TabIndex = 0;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.Image = Properties.Resources.iconoMaximizar;
            btnMaximizar.Location = new Point(597, 1);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(30, 23);
            btnMaximizar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMaximizar.TabIndex = 2;
            btnMaximizar.TabStop = false;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.Image = Properties.Resources.iconoMinimizar;
            btnMinimizar.Location = new Point(561, 1);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(30, 23);
            btnMinimizar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMinimizar.TabIndex = 3;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Image = Properties.Resources.volver;
            btnVolver.Location = new Point(12, 1);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(52, 41);
            btnVolver.SizeMode = PictureBoxSizeMode.StretchImage;
            btnVolver.TabIndex = 4;
            btnVolver.TabStop = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Image = Properties.Resources.iconoCerrar;
            btnCerrar.Location = new Point(633, 1);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(30, 23);
            btnCerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnCerrar.TabIndex = 1;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FrmBase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 348);
            ControlBox = false;
            Controls.Add(btnVolver);
            Controls.Add(btnMinimizar);
            Controls.Add(btnMaximizar);
            Controls.Add(btnCerrar);
            Controls.Add(btnIniciar);
            Name = "FrmBase";
            Text = "FrmBase";
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnVolver).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        protected Button btnIniciar;
        protected PictureBox btnMaximizar;
        protected PictureBox btnMinimizar;
        protected PictureBox btnVolver;
        protected PictureBox btnCerrar;
    }
}