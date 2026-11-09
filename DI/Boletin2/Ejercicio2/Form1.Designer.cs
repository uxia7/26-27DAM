namespace Ejercicio2
{
    partial class Form1
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
            this.salir = new System.Windows.Forms.Button();
            this.txtR = new System.Windows.Forms.TextBox();
            this.txtG = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.color = new System.Windows.Forms.Button();
            this.ruta = new System.Windows.Forms.TextBox();
            this.imagen = new System.Windows.Forms.PictureBox();
            this.cargar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // salir
            // 
            this.salir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.salir.Location = new System.Drawing.Point(660, 389);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(75, 23);
            this.salir.TabIndex = 0;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(120, 137);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(100, 22);
            this.txtR.TabIndex = 1;
            // 
            // txtG
            // 
            this.txtG.Location = new System.Drawing.Point(295, 137);
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(100, 22);
            this.txtG.TabIndex = 2;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(477, 137);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 22);
            this.txtB.TabIndex = 3;
            // 
            // color
            // 
            this.color.Location = new System.Drawing.Point(651, 135);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(75, 23);
            this.color.TabIndex = 4;
            this.color.Text = "Color";
            this.color.UseVisualStyleBackColor = true;
            this.color.Click += new System.EventHandler(this.color_Click);
            // 
            // ruta
            // 
            this.ruta.Location = new System.Drawing.Point(37, 182);
            this.ruta.Name = "ruta";
            this.ruta.Size = new System.Drawing.Size(183, 22);
            this.ruta.TabIndex = 5;
            this.ruta.Text = "Dime una ruta de una imagen ";
            // 
            // imagen
            // 
            this.imagen.Location = new System.Drawing.Point(37, 232);
            this.imagen.Name = "imagen";
            this.imagen.Size = new System.Drawing.Size(251, 206);
            this.imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagen.TabIndex = 6;
            this.imagen.TabStop = false;
            // 
            // cargar
            // 
            this.cargar.Location = new System.Drawing.Point(270, 182);
            this.cargar.Name = "cargar";
            this.cargar.Size = new System.Drawing.Size(112, 24);
            this.cargar.TabIndex = 7;
            this.cargar.Text = "Cargar Imagen";
            this.cargar.UseVisualStyleBackColor = true;
            this.cargar.Click += new System.EventHandler(this.cargar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.salir;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cargar);
            this.Controls.Add(this.imagen);
            this.Controls.Add(this.ruta);
            this.Controls.Add(this.color);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtG);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.salir);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.TextBox txtG;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button color;
        private System.Windows.Forms.TextBox ruta;
        private System.Windows.Forms.PictureBox imagen;
        private System.Windows.Forms.Button cargar;
    }
}

