namespace FORMS
{
    partial class Placas
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
            this.DGVPlacas = new System.Windows.Forms.DataGridView();
            this.idVehiculo = new System.Windows.Forms.TextBox();
            this.idLicencia = new System.Windows.Forms.TextBox();
            this.idPlaca = new System.Windows.Forms.TextBox();
            this.Agregar = new System.Windows.Forms.Button();
            this.Borrar2 = new System.Windows.Forms.Button();
            this.Cancelar2 = new System.Windows.Forms.Button();
            this.lbVehiculo = new System.Windows.Forms.Label();
            this.lbPropietario = new System.Windows.Forms.Label();
            this.lbPlaca = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPlacas)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVPlacas
            // 
            this.DGVPlacas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPlacas.Location = new System.Drawing.Point(21, 28);
            this.DGVPlacas.Name = "DGVPlacas";
            this.DGVPlacas.Size = new System.Drawing.Size(466, 318);
            this.DGVPlacas.TabIndex = 0;
            // 
            // idVehiculo
            // 
            this.idVehiculo.Location = new System.Drawing.Point(577, 117);
            this.idVehiculo.Name = "idVehiculo";
            this.idVehiculo.Size = new System.Drawing.Size(123, 20);
            this.idVehiculo.TabIndex = 30;
            // 
            // idLicencia
            // 
            this.idLicencia.Location = new System.Drawing.Point(790, 41);
            this.idLicencia.Name = "idLicencia";
            this.idLicencia.Size = new System.Drawing.Size(117, 20);
            this.idLicencia.TabIndex = 31;
            // 
            // idPlaca
            // 
            this.idPlaca.Location = new System.Drawing.Point(566, 38);
            this.idPlaca.Name = "idPlaca";
            this.idPlaca.Size = new System.Drawing.Size(134, 20);
            this.idPlaca.TabIndex = 32;
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(593, 336);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 23);
            this.Agregar.TabIndex = 60;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            // 
            // Borrar2
            // 
            this.Borrar2.Location = new System.Drawing.Point(693, 336);
            this.Borrar2.Name = "Borrar2";
            this.Borrar2.Size = new System.Drawing.Size(75, 23);
            this.Borrar2.TabIndex = 61;
            this.Borrar2.Text = "Borrar";
            this.Borrar2.UseVisualStyleBackColor = true;
            // 
            // Cancelar2
            // 
            this.Cancelar2.Location = new System.Drawing.Point(790, 336);
            this.Cancelar2.Name = "Cancelar2";
            this.Cancelar2.Size = new System.Drawing.Size(75, 23);
            this.Cancelar2.TabIndex = 62;
            this.Cancelar2.Text = "Cancelar";
            this.Cancelar2.UseVisualStyleBackColor = true;
            // 
            // lbVehiculo
            // 
            this.lbVehiculo.AutoSize = true;
            this.lbVehiculo.Location = new System.Drawing.Point(525, 120);
            this.lbVehiculo.Name = "lbVehiculo";
            this.lbVehiculo.Size = new System.Drawing.Size(48, 13);
            this.lbVehiculo.TabIndex = 71;
            this.lbVehiculo.Text = "Vehiculo";
            // 
            // lbPropietario
            // 
            this.lbPropietario.AutoSize = true;
            this.lbPropietario.Location = new System.Drawing.Point(729, 44);
            this.lbPropietario.Name = "lbPropietario";
            this.lbPropietario.Size = new System.Drawing.Size(57, 13);
            this.lbPropietario.TabIndex = 72;
            this.lbPropietario.Text = "Propietario";
            this.lbPropietario.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbPlaca
            // 
            this.lbPlaca.AutoSize = true;
            this.lbPlaca.Location = new System.Drawing.Point(515, 41);
            this.lbPlaca.Name = "lbPlaca";
            this.lbPlaca.Size = new System.Drawing.Size(45, 13);
            this.lbPlaca.TabIndex = 73;
            this.lbPlaca.Text = "N.Placa";
            // 
            // Placas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 450);
            this.Controls.Add(this.lbPlaca);
            this.Controls.Add(this.lbPropietario);
            this.Controls.Add(this.lbVehiculo);
            this.Controls.Add(this.Cancelar2);
            this.Controls.Add(this.Borrar2);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.idPlaca);
            this.Controls.Add(this.idLicencia);
            this.Controls.Add(this.idVehiculo);
            this.Controls.Add(this.DGVPlacas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Placas";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Placas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPlacas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVPlacas;
        internal System.Windows.Forms.TextBox idVehiculo;
        internal System.Windows.Forms.TextBox idLicencia;
        internal System.Windows.Forms.TextBox idPlaca;
        internal System.Windows.Forms.Button Agregar;
        internal System.Windows.Forms.Button Borrar2;
        internal System.Windows.Forms.Button Cancelar2;
        internal System.Windows.Forms.Label lbVehiculo;
        internal System.Windows.Forms.Label lbPropietario;
        internal System.Windows.Forms.Label lbPlaca;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}