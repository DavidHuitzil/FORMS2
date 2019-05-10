namespace FORMS
{
    partial class Vehiculo
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DGVVehiculo = new System.Windows.Forms.DataGridView();
            this.Agregar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.idpropietario = new System.Windows.Forms.TextBox();
            this.Factura = new System.Windows.Forms.TextBox();
            this.tipovehiculo = new System.Windows.Forms.TextBox();
            this.marca = new System.Windows.Forms.TextBox();
            this.color = new System.Windows.Forms.TextBox();
            this.combustible = new System.Windows.Forms.TextBox();
            this.Pasajeros = new System.Windows.Forms.TextBox();
            this.idempleado = new System.Windows.Forms.TextBox();
            this.importedefactura = new System.Windows.Forms.TextBox();
            this.fechaFactura = new System.Windows.Forms.TextBox();
            this.Particular = new System.Windows.Forms.CheckBox();
            this.Comercial = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbPasajeros = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbFactura = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbPlacas = new System.Windows.Forms.Label();
            this.idPlacasve = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DGVVehiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVVehiculo
            // 
            this.DGVVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVVehiculo.Location = new System.Drawing.Point(8, 25);
            this.DGVVehiculo.Name = "DGVVehiculo";
            this.DGVVehiculo.Size = new System.Drawing.Size(467, 305);
            this.DGVVehiculo.TabIndex = 0;
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(617, 398);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 23);
            this.Agregar.TabIndex = 60;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(715, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 61;
            this.button1.Text = "Borrar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(813, 398);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 62;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // idpropietario
            // 
            this.idpropietario.Location = new System.Drawing.Point(564, 49);
            this.idpropietario.Name = "idpropietario";
            this.idpropietario.Size = new System.Drawing.Size(144, 20);
            this.idpropietario.TabIndex = 63;
            this.idpropietario.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // Factura
            // 
            this.Factura.Location = new System.Drawing.Point(790, 108);
            this.Factura.Name = "Factura";
            this.Factura.Size = new System.Drawing.Size(144, 20);
            this.Factura.TabIndex = 64;
            // 
            // tipovehiculo
            // 
            this.tipovehiculo.Location = new System.Drawing.Point(564, 91);
            this.tipovehiculo.Name = "tipovehiculo";
            this.tipovehiculo.Size = new System.Drawing.Size(144, 20);
            this.tipovehiculo.TabIndex = 65;
            // 
            // marca
            // 
            this.marca.Location = new System.Drawing.Point(564, 148);
            this.marca.Name = "marca";
            this.marca.Size = new System.Drawing.Size(144, 20);
            this.marca.TabIndex = 66;
            // 
            // color
            // 
            this.color.Location = new System.Drawing.Point(564, 204);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(144, 20);
            this.color.TabIndex = 67;
            this.color.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // combustible
            // 
            this.combustible.Location = new System.Drawing.Point(564, 266);
            this.combustible.Name = "combustible";
            this.combustible.Size = new System.Drawing.Size(144, 20);
            this.combustible.TabIndex = 68;
            // 
            // Pasajeros
            // 
            this.Pasajeros.Location = new System.Drawing.Point(790, 65);
            this.Pasajeros.Name = "Pasajeros";
            this.Pasajeros.Size = new System.Drawing.Size(144, 20);
            this.Pasajeros.TabIndex = 69;
            // 
            // idempleado
            // 
            this.idempleado.Location = new System.Drawing.Point(790, 266);
            this.idempleado.Name = "idempleado";
            this.idempleado.Size = new System.Drawing.Size(144, 20);
            this.idempleado.TabIndex = 70;
            // 
            // importedefactura
            // 
            this.importedefactura.Location = new System.Drawing.Point(790, 216);
            this.importedefactura.Name = "importedefactura";
            this.importedefactura.Size = new System.Drawing.Size(144, 20);
            this.importedefactura.TabIndex = 71;
            this.importedefactura.TextChanged += new System.EventHandler(this.importedefactura_TextChanged);
            // 
            // fechaFactura
            // 
            this.fechaFactura.Location = new System.Drawing.Point(790, 166);
            this.fechaFactura.Name = "fechaFactura";
            this.fechaFactura.Size = new System.Drawing.Size(144, 20);
            this.fechaFactura.TabIndex = 72;
            // 
            // Particular
            // 
            this.Particular.AutoSize = true;
            this.Particular.Location = new System.Drawing.Point(818, 313);
            this.Particular.Name = "Particular";
            this.Particular.Size = new System.Drawing.Size(70, 17);
            this.Particular.TabIndex = 73;
            this.Particular.Text = "Particular";
            this.Particular.UseVisualStyleBackColor = true;
            // 
            // Comercial
            // 
            this.Comercial.AutoSize = true;
            this.Comercial.Location = new System.Drawing.Point(732, 313);
            this.Comercial.Name = "Comercial";
            this.Comercial.Size = new System.Drawing.Size(72, 17);
            this.Comercial.TabIndex = 74;
            this.Comercial.Text = "Comercial";
            this.Comercial.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(428, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 76;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(501, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 77;
            this.label7.Text = "Propietario";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(736, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 78;
            this.label2.Text = "Empleado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(729, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 79;
            this.label3.Text = "Fecha Factura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(729, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 80;
            this.label4.Text = "Importe Factura";
            // 
            // lbPasajeros
            // 
            this.lbPasajeros.AutoSize = true;
            this.lbPasajeros.Location = new System.Drawing.Point(738, 68);
            this.lbPasajeros.Name = "lbPasajeros";
            this.lbPasajeros.Size = new System.Drawing.Size(53, 13);
            this.lbPasajeros.TabIndex = 81;
            this.lbPasajeros.Text = "Pasajeros";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(501, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 82;
            this.label6.Text = "Color Auto";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lbFactura
            // 
            this.lbFactura.AutoSize = true;
            this.lbFactura.Location = new System.Drawing.Point(738, 111);
            this.lbFactura.Name = "lbFactura";
            this.lbFactura.Size = new System.Drawing.Size(54, 13);
            this.lbFactura.TabIndex = 83;
            this.lbFactura.Text = "N.Factura";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(496, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 84;
            this.label9.Text = "Marca Auto";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(508, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 85;
            this.label10.Text = "Tipo Auto";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(496, 250);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 13);
            this.label11.TabIndex = 86;
            this.label11.Text = "Tipo Combustible";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(654, 314);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 13);
            this.label12.TabIndex = 87;
            this.label12.Text = "Tipo Vehiculo";
            // 
            // lbPlacas
            // 
            this.lbPlacas.AutoSize = true;
            this.lbPlacas.Location = new System.Drawing.Point(738, 25);
            this.lbPlacas.Name = "lbPlacas";
            this.lbPlacas.Size = new System.Drawing.Size(39, 13);
            this.lbPlacas.TabIndex = 88;
            this.lbPlacas.Text = "Placas";
            // 
            // idPlacasve
            // 
            this.idPlacasve.Location = new System.Drawing.Point(790, 22);
            this.idPlacasve.Name = "idPlacasve";
            this.idPlacasve.Size = new System.Drawing.Size(84, 20);
            this.idPlacasve.TabIndex = 89;
            // 
            // Vehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 450);
            this.Controls.Add(this.idPlacasve);
            this.Controls.Add(this.lbPlacas);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbFactura);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbPasajeros);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Comercial);
            this.Controls.Add(this.Particular);
            this.Controls.Add(this.fechaFactura);
            this.Controls.Add(this.importedefactura);
            this.Controls.Add(this.idempleado);
            this.Controls.Add(this.Pasajeros);
            this.Controls.Add(this.combustible);
            this.Controls.Add(this.color);
            this.Controls.Add(this.marca);
            this.Controls.Add(this.tipovehiculo);
            this.Controls.Add(this.Factura);
            this.Controls.Add(this.idpropietario);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.DGVVehiculo);
            this.Name = "Vehiculo";
            this.Text = "Vehiculo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVVehiculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVVehiculo;
        internal System.Windows.Forms.Button Agregar;
        internal System.Windows.Forms.Button button1;
        internal System.Windows.Forms.Button button2;
        internal System.Windows.Forms.TextBox idpropietario;
        internal System.Windows.Forms.TextBox Factura;
        internal System.Windows.Forms.TextBox tipovehiculo;
        internal System.Windows.Forms.TextBox marca;
        internal System.Windows.Forms.TextBox color;
        internal System.Windows.Forms.TextBox combustible;
        internal System.Windows.Forms.TextBox Pasajeros;
        internal System.Windows.Forms.TextBox idempleado;
        internal System.Windows.Forms.TextBox importedefactura;
        internal System.Windows.Forms.TextBox fechaFactura;
        internal System.Windows.Forms.CheckBox Particular;
        internal System.Windows.Forms.CheckBox Comercial;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label lbPasajeros;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label lbFactura;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.Label lbPlacas;
        internal System.Windows.Forms.TextBox idPlacasve;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}

