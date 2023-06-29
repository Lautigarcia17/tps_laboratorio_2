namespace Garcia.Lautaro.PrimerParcialForm
{
    partial class FrmComprarPasaje
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
            lblVentaPasajes = new Label();
            lblPartida = new Label();
            lblDestino = new Label();
            lblCosto = new Label();
            lblPrecioFinal = new Label();
            lstPasajeros = new ListBox();
            rbtTurista = new RadioButton();
            rbtPremium = new RadioButton();
            lblEquipaje = new Label();
            grpEquipaje = new GroupBox();
            lblCapacidadBodega = new Label();
            lblValijaDos = new Label();
            numValijaDos = new NumericUpDown();
            numValijaUno = new NumericUpDown();
            lblValijaUno = new Label();
            lblPesoValija = new Label();
            chkBolsoDeMano = new CheckBox();
            lblAsientosTurista = new Label();
            lblAsientosPremium = new Label();
            lblPasajeros = new Label();
            lblInternet = new Label();
            lblComida = new Label();
            grpFacturacion = new GroupBox();
            lblLineaPuntuada = new Label();
            lblFacturacion = new Label();
            grpEquipaje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numValijaDos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numValijaUno).BeginInit();
            grpFacturacion.SuspendLayout();
            SuspendLayout();
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(780, 189);
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(790, 132);
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(590, 448);
            btnAgregar.Size = new Size(159, 50);
            // 
            // lblVentaPasajes
            // 
            lblVentaPasajes.AutoSize = true;
            lblVentaPasajes.Font = new Font("Microsoft YaHei UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblVentaPasajes.Location = new Point(221, 9);
            lblVentaPasajes.Name = "lblVentaPasajes";
            lblVentaPasajes.Size = new Size(333, 42);
            lblVentaPasajes.TabIndex = 7;
            lblVentaPasajes.Text = "VENTA DE PASAJES";
            // 
            // lblPartida
            // 
            lblPartida.AutoSize = true;
            lblPartida.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPartida.Location = new Point(32, 87);
            lblPartida.Name = "lblPartida";
            lblPartida.Size = new Size(121, 19);
            lblPartida.TabIndex = 8;
            lblPartida.Text = "Ciudad Partida : ";
            // 
            // lblDestino
            // 
            lblDestino.AutoSize = true;
            lblDestino.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblDestino.Location = new Point(32, 125);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(122, 19);
            lblDestino.TabIndex = 9;
            lblDestino.Text = "Ciudad Destino : ";
            // 
            // lblCosto
            // 
            lblCosto.AutoSize = true;
            lblCosto.Font = new Font("Microsoft YaHei UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCosto.Location = new Point(6, 51);
            lblCosto.Name = "lblCosto";
            lblCosto.Size = new Size(85, 16);
            lblCosto.TabIndex = 10;
            lblCosto.Text = "Precio Bruto : ";
            // 
            // lblPrecioFinal
            // 
            lblPrecioFinal.AutoSize = true;
            lblPrecioFinal.Font = new Font("Microsoft YaHei UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrecioFinal.Location = new Point(6, 81);
            lblPrecioFinal.Name = "lblPrecioFinal";
            lblPrecioFinal.Size = new Size(150, 16);
            lblPrecioFinal.TabIndex = 11;
            lblPrecioFinal.Text = "Precio Final Neto (+ IVA) : ";
            // 
            // lstPasajeros
            // 
            lstPasajeros.FormattingEnabled = true;
            lstPasajeros.ItemHeight = 15;
            lstPasajeros.Location = new Point(32, 235);
            lstPasajeros.Name = "lstPasajeros";
            lstPasajeros.Size = new Size(294, 259);
            lstPasajeros.TabIndex = 12;
            // 
            // rbtTurista
            // 
            rbtTurista.AutoSize = true;
            rbtTurista.Checked = true;
            rbtTurista.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rbtTurista.Location = new Point(380, 278);
            rbtTurista.Name = "rbtTurista";
            rbtTurista.Size = new Size(72, 23);
            rbtTurista.TabIndex = 13;
            rbtTurista.TabStop = true;
            rbtTurista.Text = "Turista";
            rbtTurista.UseVisualStyleBackColor = true;
            rbtTurista.CheckedChanged += rbtTurista_CheckedChanged;
            // 
            // rbtPremium
            // 
            rbtPremium.AutoSize = true;
            rbtPremium.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rbtPremium.Location = new Point(380, 328);
            rbtPremium.Name = "rbtPremium";
            rbtPremium.Size = new Size(88, 23);
            rbtPremium.TabIndex = 14;
            rbtPremium.Text = "Premium";
            rbtPremium.UseVisualStyleBackColor = true;
            rbtPremium.CheckedChanged += rbtPremium_CheckedChanged;
            // 
            // lblEquipaje
            // 
            lblEquipaje.AutoSize = true;
            lblEquipaje.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblEquipaje.Location = new Point(43, 28);
            lblEquipaje.Name = "lblEquipaje";
            lblEquipaje.Size = new Size(106, 26);
            lblEquipaje.TabIndex = 15;
            lblEquipaje.Text = "EQUIPAJE";
            // 
            // grpEquipaje
            // 
            grpEquipaje.Controls.Add(lblCapacidadBodega);
            grpEquipaje.Controls.Add(lblValijaDos);
            grpEquipaje.Controls.Add(numValijaDos);
            grpEquipaje.Controls.Add(numValijaUno);
            grpEquipaje.Controls.Add(lblValijaUno);
            grpEquipaje.Controls.Add(lblPesoValija);
            grpEquipaje.Controls.Add(chkBolsoDeMano);
            grpEquipaje.Controls.Add(lblEquipaje);
            grpEquipaje.Location = new Point(522, 160);
            grpEquipaje.Name = "grpEquipaje";
            grpEquipaje.Size = new Size(206, 259);
            grpEquipaje.TabIndex = 16;
            grpEquipaje.TabStop = false;
            // 
            // lblCapacidadBodega
            // 
            lblCapacidadBodega.AutoSize = true;
            lblCapacidadBodega.Font = new Font("Microsoft YaHei UI", 8.25F, FontStyle.Italic, GraphicsUnit.Point);
            lblCapacidadBodega.Location = new Point(6, 137);
            lblCapacidadBodega.Name = "lblCapacidadBodega";
            lblCapacidadBodega.Size = new Size(103, 16);
            lblCapacidadBodega.TabIndex = 21;
            lblCapacidadBodega.Text = "Capacidad avion : ";
            // 
            // lblValijaDos
            // 
            lblValijaDos.AutoSize = true;
            lblValijaDos.Font = new Font("Microsoft YaHei UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblValijaDos.Location = new Point(18, 220);
            lblValijaDos.Name = "lblValijaDos";
            lblValijaDos.Size = new Size(42, 16);
            lblValijaDos.TabIndex = 20;
            lblValijaDos.Text = "Valija :";
            lblValijaDos.Visible = false;
            // 
            // numValijaDos
            // 
            numValijaDos.Location = new Point(68, 218);
            numValijaDos.Maximum = new decimal(new int[] { 21, 0, 0, 0 });
            numValijaDos.Name = "numValijaDos";
            numValijaDos.Size = new Size(56, 23);
            numValijaDos.TabIndex = 19;
            numValijaDos.Visible = false;
            // 
            // numValijaUno
            // 
            numValijaUno.Location = new Point(68, 171);
            numValijaUno.Maximum = new decimal(new int[] { 25, 0, 0, 0 });
            numValijaUno.Name = "numValijaUno";
            numValijaUno.Size = new Size(56, 23);
            numValijaUno.TabIndex = 18;
            // 
            // lblValijaUno
            // 
            lblValijaUno.AutoSize = true;
            lblValijaUno.Font = new Font("Microsoft YaHei UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblValijaUno.Location = new Point(18, 175);
            lblValijaUno.Name = "lblValijaUno";
            lblValijaUno.Size = new Size(42, 16);
            lblValijaUno.TabIndex = 18;
            lblValijaUno.Text = "Valija :";
            // 
            // lblPesoValija
            // 
            lblPesoValija.AutoSize = true;
            lblPesoValija.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPesoValija.Location = new Point(59, 108);
            lblPesoValija.Name = "lblPesoValija";
            lblPesoValija.Size = new Size(90, 19);
            lblPesoValija.TabIndex = 17;
            lblPesoValija.Text = "Peso Valija  ";
            // 
            // chkBolsoDeMano
            // 
            chkBolsoDeMano.AutoSize = true;
            chkBolsoDeMano.Font = new Font("Microsoft YaHei UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            chkBolsoDeMano.Location = new Point(6, 75);
            chkBolsoDeMano.Name = "chkBolsoDeMano";
            chkBolsoDeMano.Size = new Size(106, 20);
            chkBolsoDeMano.TabIndex = 16;
            chkBolsoDeMano.Text = "Bolso de mano";
            chkBolsoDeMano.UseVisualStyleBackColor = true;
            // 
            // lblAsientosTurista
            // 
            lblAsientosTurista.AutoSize = true;
            lblAsientosTurista.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAsientosTurista.Location = new Point(277, 87);
            lblAsientosTurista.Name = "lblAsientosTurista";
            lblAsientosTurista.Size = new Size(126, 19);
            lblAsientosTurista.TabIndex = 17;
            lblAsientosTurista.Text = "Asientos Turista : ";
            // 
            // lblAsientosPremium
            // 
            lblAsientosPremium.AutoSize = true;
            lblAsientosPremium.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAsientosPremium.Location = new Point(277, 125);
            lblAsientosPremium.Name = "lblAsientosPremium";
            lblAsientosPremium.Size = new Size(142, 19);
            lblAsientosPremium.TabIndex = 18;
            lblAsientosPremium.Text = "Asientos Premium : ";
            // 
            // lblPasajeros
            // 
            lblPasajeros.AutoSize = true;
            lblPasajeros.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPasajeros.Location = new Point(114, 206);
            lblPasajeros.Name = "lblPasajeros";
            lblPasajeros.Size = new Size(123, 26);
            lblPasajeros.TabIndex = 19;
            lblPasajeros.Text = "PASAJEROS";
            // 
            // lblInternet
            // 
            lblInternet.AutoSize = true;
            lblInternet.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblInternet.Location = new Point(183, 161);
            lblInternet.Name = "lblInternet";
            lblInternet.Size = new Size(72, 17);
            lblInternet.TabIndex = 20;
            lblInternet.Text = "Internet :  ";
            // 
            // lblComida
            // 
            lblComida.AutoSize = true;
            lblComida.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblComida.Location = new Point(318, 160);
            lblComida.Name = "lblComida";
            lblComida.Size = new Size(70, 17);
            lblComida.TabIndex = 21;
            lblComida.Text = "Comida :  ";
            // 
            // grpFacturacion
            // 
            grpFacturacion.Controls.Add(lblLineaPuntuada);
            grpFacturacion.Controls.Add(lblFacturacion);
            grpFacturacion.Controls.Add(lblCosto);
            grpFacturacion.Controls.Add(lblPrecioFinal);
            grpFacturacion.Location = new Point(541, 54);
            grpFacturacion.Name = "grpFacturacion";
            grpFacturacion.Size = new Size(220, 100);
            grpFacturacion.TabIndex = 22;
            grpFacturacion.TabStop = false;
            // 
            // lblLineaPuntuada
            // 
            lblLineaPuntuada.AutoSize = true;
            lblLineaPuntuada.Location = new Point(20, 67);
            lblLineaPuntuada.Name = "lblLineaPuntuada";
            lblLineaPuntuada.Size = new Size(157, 15);
            lblLineaPuntuada.TabIndex = 24;
            lblLineaPuntuada.Text = "------------------------------";
            // 
            // lblFacturacion
            // 
            lblFacturacion.AutoSize = true;
            lblFacturacion.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblFacturacion.Location = new Point(45, 19);
            lblFacturacion.Name = "lblFacturacion";
            lblFacturacion.Size = new Size(107, 19);
            lblFacturacion.TabIndex = 23;
            lblFacturacion.Text = "FACTURACION";
            // 
            // FrmComprarPasaje
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(773, 510);
            Controls.Add(grpFacturacion);
            Controls.Add(lblAsientosTurista);
            Controls.Add(lblComida);
            Controls.Add(lblInternet);
            Controls.Add(lblPasajeros);
            Controls.Add(lblAsientosPremium);
            Controls.Add(grpEquipaje);
            Controls.Add(rbtPremium);
            Controls.Add(rbtTurista);
            Controls.Add(lstPasajeros);
            Controls.Add(lblDestino);
            Controls.Add(lblPartida);
            Controls.Add(lblVentaPasajes);
            Name = "FrmComprarPasaje";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Comprar Pasaje";
            Load += FrmComprarPasaje_Load;
            Controls.SetChildIndex(lblVentaPasajes, 0);
            Controls.SetChildIndex(lblPartida, 0);
            Controls.SetChildIndex(lblDestino, 0);
            Controls.SetChildIndex(lstPasajeros, 0);
            Controls.SetChildIndex(rbtTurista, 0);
            Controls.SetChildIndex(rbtPremium, 0);
            Controls.SetChildIndex(btnAgregar, 0);
            Controls.SetChildIndex(btnModificar, 0);
            Controls.SetChildIndex(btnBorrar, 0);
            Controls.SetChildIndex(btnVolver, 0);
            Controls.SetChildIndex(grpEquipaje, 0);
            Controls.SetChildIndex(lblAsientosPremium, 0);
            Controls.SetChildIndex(lblPasajeros, 0);
            Controls.SetChildIndex(lblInternet, 0);
            Controls.SetChildIndex(lblComida, 0);
            Controls.SetChildIndex(lblAsientosTurista, 0);
            Controls.SetChildIndex(grpFacturacion, 0);
            grpEquipaje.ResumeLayout(false);
            grpEquipaje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numValijaDos).EndInit();
            ((System.ComponentModel.ISupportInitialize)numValijaUno).EndInit();
            grpFacturacion.ResumeLayout(false);
            grpFacturacion.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblVentaPasajes;
        private Label lblPartida;
        private Label lblDestino;
        private Label lblCosto;
        private Label lblPrecioFinal;
        private ListBox lstPasajeros;
        private RadioButton rbtTurista;
        private RadioButton rbtPremium;
        private Label lblEquipaje;
        private GroupBox grpEquipaje;
        private CheckBox chkBolsoDeMano;
        private Label lblValijaDos;
        private NumericUpDown numValijaDos;
        private NumericUpDown numValijaUno;
        private Label lblValijaUno;
        private Label lblPesoValija;
        private Label lblAsientosTurista;
        private Label lblAsientosPremium;
        private Label lblCapacidadBodega;
        private Label lblPasajeros;
        private Label lblInternet;
        private Label lblComida;
        private GroupBox grpFacturacion;
        private Label lblFacturacion;
        private Label lblLineaPuntuada;
    }
}