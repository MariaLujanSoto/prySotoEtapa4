namespace prySotoEtapa4
{
    partial class frmEtapa4
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
            this.btnListar = new System.Windows.Forms.Button();
            this.btnCrearBarco = new System.Windows.Forms.Button();
            this.btnCrearAvion = new System.Windows.Forms.Button();
            this.btnCrearAuto = new System.Windows.Forms.Button();
            this.lstVehiculos = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(497, 12);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(110, 40);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnCrearBarco
            // 
            this.btnCrearBarco.Location = new System.Drawing.Point(444, 588);
            this.btnCrearBarco.Name = "btnCrearBarco";
            this.btnCrearBarco.Size = new System.Drawing.Size(150, 38);
            this.btnCrearBarco.TabIndex = 5;
            this.btnCrearBarco.Text = "BARCO";
            this.btnCrearBarco.UseVisualStyleBackColor = true;
            this.btnCrearBarco.Click += new System.EventHandler(this.btnCrearBarco_Click);
            // 
            // btnCrearAvion
            // 
            this.btnCrearAvion.Location = new System.Drawing.Point(233, 588);
            this.btnCrearAvion.Name = "btnCrearAvion";
            this.btnCrearAvion.Size = new System.Drawing.Size(150, 38);
            this.btnCrearAvion.TabIndex = 4;
            this.btnCrearAvion.Text = "AVION";
            this.btnCrearAvion.UseVisualStyleBackColor = true;
            this.btnCrearAvion.Click += new System.EventHandler(this.btnCrearAvion_Click);
            // 
            // btnCrearAuto
            // 
            this.btnCrearAuto.Location = new System.Drawing.Point(20, 588);
            this.btnCrearAuto.Name = "btnCrearAuto";
            this.btnCrearAuto.Size = new System.Drawing.Size(150, 38);
            this.btnCrearAuto.TabIndex = 3;
            this.btnCrearAuto.Text = "AUTO";
            this.btnCrearAuto.UseVisualStyleBackColor = true;
            this.btnCrearAuto.Click += new System.EventHandler(this.btnCrearAuto_Click);
            // 
            // lstVehiculos
            // 
            this.lstVehiculos.HideSelection = false;
            this.lstVehiculos.Location = new System.Drawing.Point(499, 66);
            this.lstVehiculos.Name = "lstVehiculos";
            this.lstVehiculos.Size = new System.Drawing.Size(107, 109);
            this.lstVehiculos.TabIndex = 6;
            this.lstVehiculos.UseCompatibleStateImageBehavior = false;
            // 
            // frmEtapa4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::prySotoEtapa4.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(619, 649);
            this.Controls.Add(this.lstVehiculos);
            this.Controls.Add(this.btnCrearBarco);
            this.Controls.Add(this.btnCrearAvion);
            this.Controls.Add(this.btnCrearAuto);
            this.Controls.Add(this.btnListar);
            this.Name = "frmEtapa4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Etapa 4 : Crear Objetos en Lista";
            this.Load += new System.EventHandler(this.frmEtapa4_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnCrearBarco;
        private System.Windows.Forms.Button btnCrearAvion;
        private System.Windows.Forms.Button btnCrearAuto;
        private System.Windows.Forms.ListView lstVehiculos;
    }
}

