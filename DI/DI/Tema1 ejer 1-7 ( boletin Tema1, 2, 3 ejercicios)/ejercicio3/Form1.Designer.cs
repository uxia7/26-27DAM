namespace ejercicio3
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
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.btnJugar = new System.Windows.Forms.Button();
            this.lbInfoPremio = new System.Windows.Forms.Label();
            this.lblNoAccion = new System.Windows.Forms.Label();
            this.btnSumaCredito = new System.Windows.Forms.Button();
            this.lblCredito = new System.Windows.Forms.Label();
            this.lblTipoDinero = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(128, 148);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 22);
            this.txt1.TabIndex = 0;
            this.txt1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(338, 148);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 22);
            this.txt2.TabIndex = 1;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(548, 148);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(100, 22);
            this.txt3.TabIndex = 2;
            // 
            // btnJugar
            // 
            this.btnJugar.Location = new System.Drawing.Point(350, 210);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(75, 31);
            this.btnJugar.TabIndex = 3;
            this.btnJugar.Text = "Jugar";
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // lbInfoPremio
            // 
            this.lbInfoPremio.AutoSize = true;
            this.lbInfoPremio.Location = new System.Drawing.Point(384, 309);
            this.lbInfoPremio.Name = "lbInfoPremio";
            this.lbInfoPremio.Size = new System.Drawing.Size(67, 16);
            this.lbInfoPremio.TabIndex = 4;
            this.lbInfoPremio.Text = "Ganador?";
            this.lbInfoPremio.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNoAccion
            // 
            this.lblNoAccion.AutoSize = true;
            this.lblNoAccion.Location = new System.Drawing.Point(30, 38);
            this.lblNoAccion.Name = "lblNoAccion";
            this.lblNoAccion.Size = new System.Drawing.Size(56, 16);
            this.lblNoAccion.TabIndex = 5;
            this.lblNoAccion.Text = "Credito: ";
            // 
            // btnSumaCredito
            // 
            this.btnSumaCredito.Location = new System.Drawing.Point(202, 31);
            this.btnSumaCredito.Name = "btnSumaCredito";
            this.btnSumaCredito.Size = new System.Drawing.Size(137, 23);
            this.btnSumaCredito.TabIndex = 6;
            this.btnSumaCredito.Text = "Insertar mas credito";
            this.btnSumaCredito.UseVisualStyleBackColor = true;
            this.btnSumaCredito.Click += new System.EventHandler(this.btnSumaCredito_Click);
            // 
            // lblCredito
            // 
            this.lblCredito.AutoSize = true;
            this.lblCredito.Location = new System.Drawing.Point(103, 38);
            this.lblCredito.Name = "lblCredito";
            this.lblCredito.Size = new System.Drawing.Size(21, 16);
            this.lblCredito.TabIndex = 7;
            this.lblCredito.Text = "50";
            // 
            // lblTipoDinero
            // 
            this.lblTipoDinero.AutoSize = true;
            this.lblTipoDinero.Location = new System.Drawing.Point(131, 38);
            this.lblTipoDinero.Name = "lblTipoDinero";
            this.lblTipoDinero.Size = new System.Drawing.Size(14, 16);
            this.lblTipoDinero.TabIndex = 8;
            this.lblTipoDinero.Text = "€";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTipoDinero);
            this.Controls.Add(this.lblCredito);
            this.Controls.Add(this.btnSumaCredito);
            this.Controls.Add(this.lblNoAccion);
            this.Controls.Add(this.lbInfoPremio);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Label lbInfoPremio;
        private System.Windows.Forms.Label lblNoAccion;
        private System.Windows.Forms.Button btnSumaCredito;
        private System.Windows.Forms.Label lblCredito;
        private System.Windows.Forms.Label lblTipoDinero;
    }
}

