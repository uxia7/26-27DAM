namespace Ejercicio3
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
            this.jugar = new System.Windows.Forms.Button();
            this.recarga = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.num3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dinero = new System.Windows.Forms.Label();
            this.premio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // jugar
            // 
            this.jugar.Location = new System.Drawing.Point(316, 202);
            this.jugar.Name = "jugar";
            this.jugar.Size = new System.Drawing.Size(75, 23);
            this.jugar.TabIndex = 0;
            this.jugar.Text = "Jugar";
            this.jugar.UseVisualStyleBackColor = true;
            this.jugar.Click += new System.EventHandler(this.jugar_Click);
            // 
            // recarga
            // 
            this.recarga.Location = new System.Drawing.Point(641, 384);
            this.recarga.Name = "recarga";
            this.recarga.Size = new System.Drawing.Size(75, 23);
            this.recarga.TabIndex = 1;
            this.recarga.Text = "Recarga";
            this.recarga.UseVisualStyleBackColor = true;
            this.recarga.Click += new System.EventHandler(this.recarga_Click);
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(186, 140);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(100, 22);
            this.num1.TabIndex = 2;
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(326, 140);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(100, 22);
            this.num2.TabIndex = 3;
            // 
            // num3
            // 
            this.num3.Location = new System.Drawing.Point(481, 140);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(100, 22);
            this.num3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(625, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Saldo";
            // 
            // dinero
            // 
            this.dinero.AutoSize = true;
            this.dinero.Location = new System.Drawing.Point(675, 51);
            this.dinero.Name = "dinero";
            this.dinero.Size = new System.Drawing.Size(21, 16);
            this.dinero.TabIndex = 6;
            this.dinero.Text = "50";
            // 
            // premio
            // 
            this.premio.AutoSize = true;
            this.premio.Location = new System.Drawing.Point(638, 90);
            this.premio.Name = "premio";
            this.premio.Size = new System.Drawing.Size(16, 16);
            this.premio.TabIndex = 7;
            this.premio.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.premio);
            this.Controls.Add(this.dinero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.recarga);
            this.Controls.Add(this.jugar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button jugar;
        private System.Windows.Forms.Button recarga;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.TextBox num3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dinero;
        private System.Windows.Forms.Label premio;
    }
}

