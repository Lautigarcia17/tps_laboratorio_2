namespace Garcia.Lautaro.PrimerParcialForm
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
            btnAgregar = new Button();
            btnModificar = new Button();
            btnBorrar = new Button();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Black;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(456, 69);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(127, 54);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.Black;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(455, 186);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(127, 53);
            btnModificar.TabIndex = 4;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.Black;
            btnBorrar.FlatStyle = FlatStyle.Flat;
            btnBorrar.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBorrar.ForeColor = Color.White;
            btnBorrar.Location = new Point(456, 129);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(126, 51);
            btnBorrar.TabIndex = 5;
            btnBorrar.Text = "BORRAR";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(255, 128, 0);
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.ForeColor = Color.White;
            btnVolver.Location = new Point(1, 1);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(112, 31);
            btnVolver.TabIndex = 6;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // FrmBase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 376);
            Controls.Add(btnVolver);
            Controls.Add(btnBorrar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            MinimumSize = new Size(447, 415);
            Name = "FrmBase";
            Text = "FrmBase";
            ResumeLayout(false);
        }

        #endregion

        protected Button btnModificar;
        protected Button btnBorrar;
        protected Button btnVolver;
        protected Button btnAgregar;
    }
}