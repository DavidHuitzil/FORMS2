namespace FORMS
{
    partial class Multas
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
            this.components = new System.ComponentModel.Container();
            this.DGVMulta = new System.Windows.Forms.DataGridView();
            this.idMulta = new System.Windows.Forms.TextBox();
            this.fechaExpedicion = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Paterno = new System.Windows.Forms.TextBox();
            this.idPlacas = new System.Windows.Forms.TextBox();
            this.descripcion = new System.Windows.Forms.TextBox();
            this.importe = new System.Windows.Forms.TextBox();
            this.Estatus = new System.Windows.Forms.TextBox();
            this.Agregar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Si = new System.Windows.Forms.CheckBox();
            this.No = new System.Windows.Forms.CheckBox();
            this.Folio = new System.Windows.Forms.Label();
            this.labFechaExpedicion = new System.Windows.Forms.Label();
            this.NOMBRE2 = new System.Windows.Forms.Label();
            this.Placas1 = new System.Windows.Forms.Label();
            this.MotoPagar = new System.Windows.Forms.Label();
            this.EstatusMul = new System.Windows.Forms.Label();
            this.Motivo = new System.Windows.Forms.Label();
            this.TienLicencia = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Paterno1 = new System.Windows.Forms.Label();
            this.Materno = new System.Windows.Forms.TextBox();
            this.Materno1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.fechaLiquidacionMuta = new System.Windows.Forms.TextBox();
            this.labfechaLiquidcion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMulta)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVMulta
            // 
            this.DGVMulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMulta.Location = new System.Drawing.Point(12, 21);
            this.DGVMulta.Name = "DGVMulta";
            this.DGVMulta.Size = new System.Drawing.Size(466, 298);
            this.DGVMulta.TabIndex = 0;
            // 
            // idMulta
            // 
            this.idMulta.Location = new System.Drawing.Point(560, 17);
            this.idMulta.Name = "idMulta";
            this.idMulta.Size = new System.Drawing.Size(103, 20);
            this.idMulta.TabIndex = 23;
            // 
            // fechaExpedicion
            // 
            this.fechaExpedicion.Location = new System.Drawing.Point(776, 18);
            this.fechaExpedicion.Name = "fechaExpedicion";
            this.fechaExpedicion.Size = new System.Drawing.Size(103, 20);
            this.fechaExpedicion.TabIndex = 24;
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(560, 69);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(103, 20);
            this.Nombre.TabIndex = 25;
            // 
            // Paterno
            // 
            this.Paterno.Location = new System.Drawing.Point(712, 69);
            this.Paterno.Name = "Paterno";
            this.Paterno.Size = new System.Drawing.Size(103, 20);
            this.Paterno.TabIndex = 26;
            // 
            // idPlacas
            // 
            this.idPlacas.Location = new System.Drawing.Point(589, 144);
            this.idPlacas.Name = "idPlacas";
            this.idPlacas.Size = new System.Drawing.Size(103, 20);
            this.idPlacas.TabIndex = 27;
            // 
            // descripcion
            // 
            this.descripcion.Location = new System.Drawing.Point(577, 191);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(243, 20);
            this.descripcion.TabIndex = 28;
            // 
            // importe
            // 
            this.importe.Location = new System.Drawing.Point(577, 241);
            this.importe.Name = "importe";
            this.importe.Size = new System.Drawing.Size(103, 20);
            this.importe.TabIndex = 29;
            // 
            // Estatus
            // 
            this.Estatus.Location = new System.Drawing.Point(577, 288);
            this.Estatus.Name = "Estatus";
            this.Estatus.Size = new System.Drawing.Size(103, 20);
            this.Estatus.TabIndex = 30;
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(672, 347);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 23);
            this.Agregar.TabIndex = 59;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(764, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 60;
            this.button1.Text = "Borrar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Si
            // 
            this.Si.AutoSize = true;
            this.Si.Location = new System.Drawing.Point(818, 245);
            this.Si.Name = "Si";
            this.Si.Size = new System.Drawing.Size(35, 17);
            this.Si.TabIndex = 61;
            this.Si.Text = "Si";
            this.Si.UseVisualStyleBackColor = true;
            this.Si.CheckedChanged += new System.EventHandler(this.Si_CheckedChanged);
            // 
            // No
            // 
            this.No.AutoSize = true;
            this.No.Location = new System.Drawing.Point(862, 245);
            this.No.Name = "No";
            this.No.Size = new System.Drawing.Size(40, 17);
            this.No.TabIndex = 62;
            this.No.Text = "No";
            this.No.UseVisualStyleBackColor = true;
            this.No.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Folio
            // 
            this.Folio.AutoSize = true;
            this.Folio.Location = new System.Drawing.Point(516, 21);
            this.Folio.Name = "Folio";
            this.Folio.Size = new System.Drawing.Size(29, 13);
            this.Folio.TabIndex = 63;
            this.Folio.Text = "Folio";
            // 
            // labFechaExpedicion
            // 
            this.labFechaExpedicion.AutoSize = true;
            this.labFechaExpedicion.Location = new System.Drawing.Point(687, 21);
            this.labFechaExpedicion.Name = "labFechaExpedicion";
            this.labFechaExpedicion.Size = new System.Drawing.Size(92, 13);
            this.labFechaExpedicion.TabIndex = 64;
            this.labFechaExpedicion.Text = "Fecha Expedicion";
            this.labFechaExpedicion.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // NOMBRE2
            // 
            this.NOMBRE2.AutoSize = true;
            this.NOMBRE2.Location = new System.Drawing.Point(510, 72);
            this.NOMBRE2.Name = "NOMBRE2";
            this.NOMBRE2.Size = new System.Drawing.Size(44, 13);
            this.NOMBRE2.TabIndex = 65;
            this.NOMBRE2.Text = "Nombre";
            // 
            // Placas1
            // 
            this.Placas1.AutoSize = true;
            this.Placas1.Location = new System.Drawing.Point(495, 151);
            this.Placas1.Name = "Placas1";
            this.Placas1.Size = new System.Drawing.Size(83, 13);
            this.Placas1.TabIndex = 66;
            this.Placas1.Text = "Placas Vehiculo";
            // 
            // MotoPagar
            // 
            this.MotoPagar.AutoSize = true;
            this.MotoPagar.Location = new System.Drawing.Point(501, 244);
            this.MotoPagar.Name = "MotoPagar";
            this.MotoPagar.Size = new System.Drawing.Size(77, 13);
            this.MotoPagar.TabIndex = 67;
            this.MotoPagar.Text = "Monto a Pagar";
            // 
            // EstatusMul
            // 
            this.EstatusMul.AutoSize = true;
            this.EstatusMul.Location = new System.Drawing.Point(519, 291);
            this.EstatusMul.Name = "EstatusMul";
            this.EstatusMul.Size = new System.Drawing.Size(42, 13);
            this.EstatusMul.TabIndex = 68;
            this.EstatusMul.Text = "Estatus";
            // 
            // Motivo
            // 
            this.Motivo.AutoSize = true;
            this.Motivo.Location = new System.Drawing.Point(495, 194);
            this.Motivo.Name = "Motivo";
            this.Motivo.Size = new System.Drawing.Size(68, 13);
            this.Motivo.TabIndex = 69;
            this.Motivo.Text = "Motivo.Multa";
            // 
            // TienLicencia
            // 
            this.TienLicencia.AutoSize = true;
            this.TienLicencia.Location = new System.Drawing.Point(735, 245);
            this.TienLicencia.Name = "TienLicencia";
            this.TienLicencia.Size = new System.Drawing.Size(77, 13);
            this.TienLicencia.TabIndex = 70;
            this.TienLicencia.Text = "Tiene Licencia";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(862, 347);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 71;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Paterno1
            // 
            this.Paterno1.AutoSize = true;
            this.Paterno1.Location = new System.Drawing.Point(669, 72);
            this.Paterno1.Name = "Paterno1";
            this.Paterno1.Size = new System.Drawing.Size(44, 13);
            this.Paterno1.TabIndex = 72;
            this.Paterno1.Text = "Paterno";
            // 
            // Materno
            // 
            this.Materno.Location = new System.Drawing.Point(714, 111);
            this.Materno.Name = "Materno";
            this.Materno.Size = new System.Drawing.Size(103, 20);
            this.Materno.TabIndex = 73;
            // 
            // Materno1
            // 
            this.Materno1.AutoSize = true;
            this.Materno1.Location = new System.Drawing.Point(664, 114);
            this.Materno1.Name = "Materno1";
            this.Materno1.Size = new System.Drawing.Size(46, 13);
            this.Materno1.TabIndex = 74;
            this.Materno1.Text = "Materno";
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // fechaLiquidacionMuta
            // 
            this.fechaLiquidacionMuta.Location = new System.Drawing.Point(818, 299);
            this.fechaLiquidacionMuta.Name = "fechaLiquidacionMuta";
            this.fechaLiquidacionMuta.Size = new System.Drawing.Size(103, 20);
            this.fechaLiquidacionMuta.TabIndex = 75;
            // 
            // labfechaLiquidcion
            // 
            this.labfechaLiquidcion.AutoSize = true;
            this.labfechaLiquidcion.Location = new System.Drawing.Point(718, 302);
            this.labfechaLiquidcion.Name = "labfechaLiquidcion";
            this.labfechaLiquidcion.Size = new System.Drawing.Size(94, 13);
            this.labfechaLiquidcion.TabIndex = 76;
            this.labfechaLiquidcion.Text = "Fecha Liquidacion";
            // 
            // Multas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(958, 450);
            this.Controls.Add(this.labfechaLiquidcion);
            this.Controls.Add(this.fechaLiquidacionMuta);
            this.Controls.Add(this.Materno1);
            this.Controls.Add(this.Materno);
            this.Controls.Add(this.Paterno1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TienLicencia);
            this.Controls.Add(this.Motivo);
            this.Controls.Add(this.EstatusMul);
            this.Controls.Add(this.MotoPagar);
            this.Controls.Add(this.Placas1);
            this.Controls.Add(this.NOMBRE2);
            this.Controls.Add(this.labFechaExpedicion);
            this.Controls.Add(this.Folio);
            this.Controls.Add(this.No);
            this.Controls.Add(this.Si);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.Estatus);
            this.Controls.Add(this.importe);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.idPlacas);
            this.Controls.Add(this.Paterno);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.fechaExpedicion);
            this.Controls.Add(this.idMulta);
            this.Controls.Add(this.DGVMulta);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Multas";
            this.Text = "Multas";
            this.Load += new System.EventHandler(this.Multas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVMulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVMulta;
        internal System.Windows.Forms.TextBox idMulta;
        internal System.Windows.Forms.TextBox fechaExpedicion;
        internal System.Windows.Forms.TextBox Nombre;
        internal System.Windows.Forms.TextBox Paterno;
        internal System.Windows.Forms.TextBox idPlacas;
        internal System.Windows.Forms.TextBox descripcion;
        internal System.Windows.Forms.TextBox importe;
        internal System.Windows.Forms.TextBox Estatus;
        internal System.Windows.Forms.Button Agregar;
        internal System.Windows.Forms.Button button1;
        internal System.Windows.Forms.CheckBox Si;
        internal System.Windows.Forms.CheckBox No;
        internal System.Windows.Forms.Label Folio;
        internal System.Windows.Forms.Label labFechaExpedicion;
        internal System.Windows.Forms.Label NOMBRE2;
        internal System.Windows.Forms.Label Placas1;
        internal System.Windows.Forms.Label MotoPagar;
        internal System.Windows.Forms.Label EstatusMul;
        internal System.Windows.Forms.Label Motivo;
        internal System.Windows.Forms.Label TienLicencia;
        internal System.Windows.Forms.Button button2;
        internal System.Windows.Forms.Label Paterno1;
        internal System.Windows.Forms.TextBox Materno;
        internal System.Windows.Forms.Label Materno1;
        private System.Windows.Forms.ToolTip toolTip1;
        internal System.Windows.Forms.TextBox fechaLiquidacionMuta;
        internal System.Windows.Forms.Label labfechaLiquidcion;
    }
}