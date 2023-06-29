namespace Vista
{
    partial class FrmGenerala
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
            panelDados = new Panel();
            pbDadoCinco = new PictureBox();
            pbDadoCuatro = new PictureBox();
            pbDadoTres = new PictureBox();
            pbDadoDos = new PictureBox();
            pbDadoUno = new PictureBox();
            dtgTablaJugadorUno = new DataGridView();
            categoriaGrdi = new DataGridViewTextBoxColumn();
            puntajeGrid = new DataGridViewTextBoxColumn();
            lblPuntajeJugadorUno = new Label();
            dtgTablaJugadorDos = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            lblPuntajeJugadorDos = new Label();
            lblJugadorUno = new Label();
            lblJugadorDos = new Label();
            lblGanador = new Label();
            dtgPartida = new DataGridView();
            idColumna = new DataGridViewTextBoxColumn();
            jugadorUnoGrid = new DataGridViewTextBoxColumn();
            jugadorDosGrid = new DataGridViewTextBoxColumn();
            ganadorGrid = new DataGridViewTextBoxColumn();
            btnCrearSala = new Button();
            btnCancelar = new Button();
            lblNombreJugadorUno = new Label();
            lblNombreJugadorDos = new Label();
            lblPuntosJugadorUno = new Label();
            lblPuntosJugadorDos = new Label();
            lblJugadorGanador = new Label();
            btnEstadisticas = new Button();
            lblRonda = new Label();
            lblNumeroRonda = new Label();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnVolver).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            panelDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbDadoCinco).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDadoCuatro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDadoTres).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDadoDos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDadoUno).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgTablaJugadorUno).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgTablaJugadorDos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgPartida).BeginInit();
            SuspendLayout();
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = SystemColors.Control;
            btnIniciar.FlatAppearance.BorderSize = 3;
            btnIniciar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnIniciar.ForeColor = SystemColors.ControlText;
            btnIniciar.Location = new Point(198, 18);
            btnIniciar.Size = new Size(108, 49);
            btnIniciar.Text = "Iniciar Partida";
            // 
            // btnMaximizar
            // 
            btnMaximizar.Location = new Point(1059, 1);
            // 
            // btnMinimizar
            // 
            btnMinimizar.Location = new Point(1013, 1);
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(1098, 1);
            // 
            // panelDados
            // 
            panelDados.Anchor = AnchorStyles.Right;
            panelDados.Controls.Add(pbDadoCinco);
            panelDados.Controls.Add(pbDadoCuatro);
            panelDados.Controls.Add(pbDadoTres);
            panelDados.Controls.Add(pbDadoDos);
            panelDados.Controls.Add(pbDadoUno);
            panelDados.Location = new Point(697, 165);
            panelDados.Name = "panelDados";
            panelDados.Size = new Size(208, 291);
            panelDados.TabIndex = 0;
            // 
            // pbDadoCinco
            // 
            pbDadoCinco.Image = Properties.Resources.dado1;
            pbDadoCinco.Location = new Point(68, 230);
            pbDadoCinco.Name = "pbDadoCinco";
            pbDadoCinco.Size = new Size(59, 48);
            pbDadoCinco.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDadoCinco.TabIndex = 4;
            pbDadoCinco.TabStop = false;
            // 
            // pbDadoCuatro
            // 
            pbDadoCuatro.Image = Properties.Resources.dado1;
            pbDadoCuatro.Location = new Point(68, 176);
            pbDadoCuatro.Name = "pbDadoCuatro";
            pbDadoCuatro.Size = new Size(59, 48);
            pbDadoCuatro.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDadoCuatro.TabIndex = 3;
            pbDadoCuatro.TabStop = false;
            // 
            // pbDadoTres
            // 
            pbDadoTres.Image = Properties.Resources.dado1;
            pbDadoTres.Location = new Point(68, 122);
            pbDadoTres.Name = "pbDadoTres";
            pbDadoTres.Size = new Size(59, 48);
            pbDadoTres.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDadoTres.TabIndex = 2;
            pbDadoTres.TabStop = false;
            // 
            // pbDadoDos
            // 
            pbDadoDos.Image = Properties.Resources.dado1;
            pbDadoDos.Location = new Point(68, 68);
            pbDadoDos.Name = "pbDadoDos";
            pbDadoDos.Size = new Size(59, 48);
            pbDadoDos.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDadoDos.TabIndex = 1;
            pbDadoDos.TabStop = false;
            // 
            // pbDadoUno
            // 
            pbDadoUno.Image = Properties.Resources.dado1;
            pbDadoUno.Location = new Point(68, 14);
            pbDadoUno.Name = "pbDadoUno";
            pbDadoUno.Size = new Size(59, 48);
            pbDadoUno.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDadoUno.TabIndex = 0;
            pbDadoUno.TabStop = false;
            // 
            // dtgTablaJugadorUno
            // 
            dtgTablaJugadorUno.AllowUserToAddRows = false;
            dtgTablaJugadorUno.AllowUserToResizeColumns = false;
            dtgTablaJugadorUno.AllowUserToResizeRows = false;
            dtgTablaJugadorUno.Anchor = AnchorStyles.Right;
            dtgTablaJugadorUno.BackgroundColor = SystemColors.Control;
            dtgTablaJugadorUno.BorderStyle = BorderStyle.None;
            dtgTablaJugadorUno.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgTablaJugadorUno.Columns.AddRange(new DataGridViewColumn[] { categoriaGrdi, puntajeGrid });
            dtgTablaJugadorUno.Location = new Point(476, 64);
            dtgTablaJugadorUno.Name = "dtgTablaJugadorUno";
            dtgTablaJugadorUno.ReadOnly = true;
            dtgTablaJugadorUno.RowHeadersVisible = false;
            dtgTablaJugadorUno.RowTemplate.Height = 25;
            dtgTablaJugadorUno.Size = new Size(175, 292);
            dtgTablaJugadorUno.TabIndex = 2;
            // 
            // categoriaGrdi
            // 
            categoriaGrdi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            categoriaGrdi.HeaderText = "Categoria";
            categoriaGrdi.Name = "categoriaGrdi";
            categoriaGrdi.ReadOnly = true;
            // 
            // puntajeGrid
            // 
            puntajeGrid.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            puntajeGrid.HeaderText = "Puntaje";
            puntajeGrid.Name = "puntajeGrid";
            puntajeGrid.ReadOnly = true;
            // 
            // lblPuntajeJugadorUno
            // 
            lblPuntajeJugadorUno.Anchor = AnchorStyles.Right;
            lblPuntajeJugadorUno.AutoSize = true;
            lblPuntajeJugadorUno.BackColor = Color.Gray;
            lblPuntajeJugadorUno.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPuntajeJugadorUno.ForeColor = SystemColors.ControlText;
            lblPuntajeJugadorUno.Location = new Point(476, 359);
            lblPuntajeJugadorUno.Name = "lblPuntajeJugadorUno";
            lblPuntajeJugadorUno.Size = new Size(113, 25);
            lblPuntajeJugadorUno.TabIndex = 3;
            lblPuntajeJugadorUno.Text = "Puntaje : ";
            // 
            // dtgTablaJugadorDos
            // 
            dtgTablaJugadorDos.AllowUserToAddRows = false;
            dtgTablaJugadorDos.AllowUserToResizeColumns = false;
            dtgTablaJugadorDos.AllowUserToResizeRows = false;
            dtgTablaJugadorDos.Anchor = AnchorStyles.Right;
            dtgTablaJugadorDos.BackgroundColor = SystemColors.Control;
            dtgTablaJugadorDos.BorderStyle = BorderStyle.None;
            dtgTablaJugadorDos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgTablaJugadorDos.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2 });
            dtgTablaJugadorDos.Location = new Point(930, 64);
            dtgTablaJugadorDos.Name = "dtgTablaJugadorDos";
            dtgTablaJugadorDos.ReadOnly = true;
            dtgTablaJugadorDos.RowHeadersVisible = false;
            dtgTablaJugadorDos.RowTemplate.Height = 25;
            dtgTablaJugadorDos.Size = new Size(175, 292);
            dtgTablaJugadorDos.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.HeaderText = "Categoria";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn2.HeaderText = "Puntaje";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // lblPuntajeJugadorDos
            // 
            lblPuntajeJugadorDos.Anchor = AnchorStyles.Right;
            lblPuntajeJugadorDos.AutoSize = true;
            lblPuntajeJugadorDos.BackColor = Color.Gray;
            lblPuntajeJugadorDos.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPuntajeJugadorDos.ForeColor = SystemColors.ControlText;
            lblPuntajeJugadorDos.Location = new Point(930, 359);
            lblPuntajeJugadorDos.Name = "lblPuntajeJugadorDos";
            lblPuntajeJugadorDos.Size = new Size(113, 25);
            lblPuntajeJugadorDos.TabIndex = 5;
            lblPuntajeJugadorDos.Text = "Puntaje : ";
            // 
            // lblJugadorUno
            // 
            lblJugadorUno.Anchor = AnchorStyles.Right;
            lblJugadorUno.AutoSize = true;
            lblJugadorUno.BackColor = Color.Gray;
            lblJugadorUno.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblJugadorUno.ForeColor = SystemColors.ControlText;
            lblJugadorUno.Location = new Point(460, 34);
            lblJugadorUno.Name = "lblJugadorUno";
            lblJugadorUno.Size = new Size(88, 16);
            lblJugadorUno.TabIndex = 6;
            lblJugadorUno.Text = "Jugador 1 : ";
            // 
            // lblJugadorDos
            // 
            lblJugadorDos.Anchor = AnchorStyles.Right;
            lblJugadorDos.AutoSize = true;
            lblJugadorDos.BackColor = Color.Gray;
            lblJugadorDos.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblJugadorDos.ForeColor = SystemColors.ControlText;
            lblJugadorDos.Location = new Point(902, 34);
            lblJugadorDos.Name = "lblJugadorDos";
            lblJugadorDos.Size = new Size(88, 16);
            lblJugadorDos.TabIndex = 7;
            lblJugadorDos.Text = "Jugador 2 : ";
            // 
            // lblGanador
            // 
            lblGanador.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblGanador.AutoSize = true;
            lblGanador.BackColor = Color.FromArgb(128, 255, 128);
            lblGanador.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblGanador.ForeColor = SystemColors.ControlText;
            lblGanador.Location = new Point(581, 487);
            lblGanador.Name = "lblGanador";
            lblGanador.Size = new Size(151, 31);
            lblGanador.TabIndex = 8;
            lblGanador.Text = "Ganador : ";
            // 
            // dtgPartida
            // 
            dtgPartida.AllowUserToAddRows = false;
            dtgPartida.AllowUserToResizeColumns = false;
            dtgPartida.AllowUserToResizeRows = false;
            dtgPartida.Anchor = AnchorStyles.Left;
            dtgPartida.BackgroundColor = SystemColors.Control;
            dtgPartida.BorderStyle = BorderStyle.None;
            dtgPartida.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgPartida.Columns.AddRange(new DataGridViewColumn[] { idColumna, jugadorUnoGrid, jugadorDosGrid, ganadorGrid });
            dtgPartida.Location = new Point(21, 88);
            dtgPartida.MultiSelect = false;
            dtgPartida.Name = "dtgPartida";
            dtgPartida.ReadOnly = true;
            dtgPartida.RowHeadersVisible = false;
            dtgPartida.RowTemplate.Height = 25;
            dtgPartida.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgPartida.Size = new Size(404, 355);
            dtgPartida.TabIndex = 9;
            dtgPartida.CellClick += dtgPartida_CellClick;
            // 
            // idColumna
            // 
            idColumna.HeaderText = "Id";
            idColumna.Name = "idColumna";
            idColumna.ReadOnly = true;
            // 
            // jugadorUnoGrid
            // 
            jugadorUnoGrid.HeaderText = "Jugador Uno";
            jugadorUnoGrid.Name = "jugadorUnoGrid";
            jugadorUnoGrid.ReadOnly = true;
            // 
            // jugadorDosGrid
            // 
            jugadorDosGrid.HeaderText = "Jugador Dos";
            jugadorDosGrid.Name = "jugadorDosGrid";
            jugadorDosGrid.ReadOnly = true;
            // 
            // ganadorGrid
            // 
            ganadorGrid.HeaderText = "Ganador";
            ganadorGrid.Name = "ganadorGrid";
            ganadorGrid.ReadOnly = true;
            // 
            // btnCrearSala
            // 
            btnCrearSala.FlatAppearance.BorderSize = 3;
            btnCrearSala.FlatStyle = FlatStyle.Flat;
            btnCrearSala.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCrearSala.Location = new Point(82, 17);
            btnCrearSala.Name = "btnCrearSala";
            btnCrearSala.Size = new Size(110, 50);
            btnCrearSala.TabIndex = 10;
            btnCrearSala.Text = "Crear Sala";
            btnCrearSala.UseVisualStyleBackColor = true;
            btnCrearSala.Click += btnCrearSala_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatAppearance.BorderSize = 3;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(320, 19);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(105, 48);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar Partida";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblNombreJugadorUno
            // 
            lblNombreJugadorUno.Anchor = AnchorStyles.Right;
            lblNombreJugadorUno.AutoSize = true;
            lblNombreJugadorUno.BackColor = Color.Gray;
            lblNombreJugadorUno.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombreJugadorUno.ForeColor = SystemColors.ControlText;
            lblNombreJugadorUno.Location = new Point(554, 34);
            lblNombreJugadorUno.Name = "lblNombreJugadorUno";
            lblNombreJugadorUno.Size = new Size(0, 16);
            lblNombreJugadorUno.TabIndex = 12;
            // 
            // lblNombreJugadorDos
            // 
            lblNombreJugadorDos.Anchor = AnchorStyles.Right;
            lblNombreJugadorDos.AutoSize = true;
            lblNombreJugadorDos.BackColor = Color.Gray;
            lblNombreJugadorDos.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombreJugadorDos.ForeColor = SystemColors.ControlText;
            lblNombreJugadorDos.Location = new Point(996, 34);
            lblNombreJugadorDos.Name = "lblNombreJugadorDos";
            lblNombreJugadorDos.Size = new Size(0, 16);
            lblNombreJugadorDos.TabIndex = 13;
            // 
            // lblPuntosJugadorUno
            // 
            lblPuntosJugadorUno.Anchor = AnchorStyles.Right;
            lblPuntosJugadorUno.AutoSize = true;
            lblPuntosJugadorUno.BackColor = Color.Gray;
            lblPuntosJugadorUno.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPuntosJugadorUno.ForeColor = SystemColors.ControlText;
            lblPuntosJugadorUno.Location = new Point(581, 359);
            lblPuntosJugadorUno.Name = "lblPuntosJugadorUno";
            lblPuntosJugadorUno.Size = new Size(0, 25);
            lblPuntosJugadorUno.TabIndex = 14;
            // 
            // lblPuntosJugadorDos
            // 
            lblPuntosJugadorDos.Anchor = AnchorStyles.Right;
            lblPuntosJugadorDos.AutoSize = true;
            lblPuntosJugadorDos.BackColor = Color.Gray;
            lblPuntosJugadorDos.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPuntosJugadorDos.ForeColor = SystemColors.ControlText;
            lblPuntosJugadorDos.Location = new Point(1039, 359);
            lblPuntosJugadorDos.Name = "lblPuntosJugadorDos";
            lblPuntosJugadorDos.Size = new Size(0, 25);
            lblPuntosJugadorDos.TabIndex = 15;
            // 
            // lblJugadorGanador
            // 
            lblJugadorGanador.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblJugadorGanador.AutoSize = true;
            lblJugadorGanador.BackColor = Color.FromArgb(128, 255, 128);
            lblJugadorGanador.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblJugadorGanador.ForeColor = SystemColors.ControlText;
            lblJugadorGanador.Location = new Point(725, 487);
            lblJugadorGanador.Name = "lblJugadorGanador";
            lblJugadorGanador.Size = new Size(0, 31);
            lblJugadorGanador.TabIndex = 16;
            // 
            // btnEstadisticas
            // 
            btnEstadisticas.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEstadisticas.FlatAppearance.BorderSize = 3;
            btnEstadisticas.FlatStyle = FlatStyle.Flat;
            btnEstadisticas.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEstadisticas.Location = new Point(176, 463);
            btnEstadisticas.Name = "btnEstadisticas";
            btnEstadisticas.Size = new Size(130, 55);
            btnEstadisticas.TabIndex = 17;
            btnEstadisticas.Text = "Estadisticas";
            btnEstadisticas.UseVisualStyleBackColor = true;
            btnEstadisticas.Click += btnEstadisticas_Click;
            // 
            // lblRonda
            // 
            lblRonda.Anchor = AnchorStyles.Right;
            lblRonda.AutoSize = true;
            lblRonda.BackColor = Color.Black;
            lblRonda.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblRonda.ForeColor = SystemColors.ButtonHighlight;
            lblRonda.Location = new Point(725, 115);
            lblRonda.Name = "lblRonda";
            lblRonda.Size = new Size(94, 25);
            lblRonda.TabIndex = 18;
            lblRonda.Text = "Ronda :";
            // 
            // lblNumeroRonda
            // 
            lblNumeroRonda.Anchor = AnchorStyles.Right;
            lblNumeroRonda.AutoSize = true;
            lblNumeroRonda.BackColor = Color.Black;
            lblNumeroRonda.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumeroRonda.ForeColor = SystemColors.ButtonHighlight;
            lblNumeroRonda.Location = new Point(811, 115);
            lblNumeroRonda.Name = "lblNumeroRonda";
            lblNumeroRonda.Size = new Size(0, 25);
            lblNumeroRonda.TabIndex = 19;
            // 
            // FrmGenerala
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.generala;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1140, 529);
            Controls.Add(lblNumeroRonda);
            Controls.Add(lblRonda);
            Controls.Add(btnEstadisticas);
            Controls.Add(lblJugadorGanador);
            Controls.Add(lblPuntosJugadorDos);
            Controls.Add(lblPuntosJugadorUno);
            Controls.Add(lblNombreJugadorDos);
            Controls.Add(lblNombreJugadorUno);
            Controls.Add(btnCancelar);
            Controls.Add(btnCrearSala);
            Controls.Add(dtgPartida);
            Controls.Add(lblGanador);
            Controls.Add(lblJugadorDos);
            Controls.Add(lblJugadorUno);
            Controls.Add(lblPuntajeJugadorDos);
            Controls.Add(dtgTablaJugadorDos);
            Controls.Add(lblPuntajeJugadorUno);
            Controls.Add(dtgTablaJugadorUno);
            Controls.Add(panelDados);
            MinimumSize = new Size(1124, 557);
            Name = "FrmGenerala";
            Text = "La Generala";
            FormClosing += FrmGenerala_FormClosing;
            Load += FrmGenerala_Load;
            Controls.SetChildIndex(panelDados, 0);
            Controls.SetChildIndex(dtgTablaJugadorUno, 0);
            Controls.SetChildIndex(lblPuntajeJugadorUno, 0);
            Controls.SetChildIndex(dtgTablaJugadorDos, 0);
            Controls.SetChildIndex(lblPuntajeJugadorDos, 0);
            Controls.SetChildIndex(lblJugadorUno, 0);
            Controls.SetChildIndex(lblJugadorDos, 0);
            Controls.SetChildIndex(lblGanador, 0);
            Controls.SetChildIndex(dtgPartida, 0);
            Controls.SetChildIndex(btnCrearSala, 0);
            Controls.SetChildIndex(btnCancelar, 0);
            Controls.SetChildIndex(lblNombreJugadorUno, 0);
            Controls.SetChildIndex(lblNombreJugadorDos, 0);
            Controls.SetChildIndex(lblPuntosJugadorUno, 0);
            Controls.SetChildIndex(lblPuntosJugadorDos, 0);
            Controls.SetChildIndex(lblJugadorGanador, 0);
            Controls.SetChildIndex(btnEstadisticas, 0);
            Controls.SetChildIndex(lblRonda, 0);
            Controls.SetChildIndex(lblNumeroRonda, 0);
            Controls.SetChildIndex(btnIniciar, 0);
            Controls.SetChildIndex(btnCerrar, 0);
            Controls.SetChildIndex(btnMaximizar, 0);
            Controls.SetChildIndex(btnMinimizar, 0);
            Controls.SetChildIndex(btnVolver, 0);
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnVolver).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            panelDados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbDadoCinco).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDadoCuatro).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDadoTres).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDadoDos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDadoUno).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgTablaJugadorUno).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgTablaJugadorDos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgPartida).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelDados;
        private PictureBox pbDadoCinco;
        private PictureBox pbDadoCuatro;
        private PictureBox pbDadoTres;
        private PictureBox pbDadoDos;
        private PictureBox pbDadoUno;
        private DataGridView dtgTablaJugadorUno;
        private DataGridViewTextBoxColumn categoriaGrdi;
        private DataGridViewTextBoxColumn puntajeGrid;
        private Label lblPuntajeJugadorUno;
        private DataGridView dtgTablaJugadorDos;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private Label lblPuntajeJugadorDos;
        private Label lblJugadorUno;
        private Label lblJugadorDos;
        private Label lblGanador;
        private DataGridView dtgPartida;
        private Button btnCrearSala;
        private Button btnCancelar;
        private DataGridViewTextBoxColumn idColumna;
        private DataGridViewTextBoxColumn jugadorUnoGrid;
        private DataGridViewTextBoxColumn jugadorDosGrid;
        private DataGridViewTextBoxColumn ganadorGrid;
        private Label lblNombreJugadorUno;
        private Label lblNombreJugadorDos;
        private Label lblPuntosJugadorUno;
        private Label lblPuntosJugadorDos;
        private Label lblJugadorGanador;
        private Button btnEstadisticas;
        private Label lblRonda;
        private Label lblNumeroRonda;
    }
}