namespace Ejercicio1
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
            this.sumar = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.TextBox();
            this.operacion = new System.Windows.Forms.Label();
            this.num2 = new System.Windows.Forms.TextBox();
            this.resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sumar
            // 
            this.sumar.Location = new System.Drawing.Point(304, 199);
            this.sumar.Name = "sumar";
            this.sumar.Size = new System.Drawing.Size(75, 23);
            this.sumar.TabIndex = 0;
            this.sumar.Text = "Sumar";
            this.sumar.UseVisualStyleBackColor = true;
            this.sumar.Click += new System.EventHandler(this.sumar_Click);
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(195, 133);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(100, 22);
            this.num1.TabIndex = 1;
            // 
            // operacion
            // 
            this.operacion.AutoSize = true;
            this.operacion.Location = new System.Drawing.Point(301, 139);
            this.operacion.Name = "operacion";
            this.operacion.Size = new System.Drawing.Size(14, 16);
            this.operacion.TabIndex = 3;
            this.operacion.Text = "+";
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(351, 133);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(100, 22);
            this.num2.TabIndex = 4;
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Location = new System.Drawing.Point(457, 139);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(14, 16);
            this.resultado.TabIndex = 5;
            this.resultado.Text = "=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.operacion);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.sumar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sumar;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.Label operacion;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.Label resultado;
    }
}

