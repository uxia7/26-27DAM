namespace ejer1
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
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.operandoSuma = new System.Windows.Forms.Label();
            this.operandoIgual = new System.Windows.Forms.Label();
            this.suma = new System.Windows.Forms.Button();
            this.resultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(198, 78);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(100, 22);
            this.num1.TabIndex = 0;
            this.num1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(392, 78);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(100, 22);
            this.num2.TabIndex = 1;
            this.num2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // operandoSuma
            // 
            this.operandoSuma.AutoSize = true;
            this.operandoSuma.Location = new System.Drawing.Point(339, 84);
            this.operandoSuma.Name = "operandoSuma";
            this.operandoSuma.Size = new System.Drawing.Size(14, 16);
            this.operandoSuma.TabIndex = 2;
            this.operandoSuma.Text = "+";
            this.operandoSuma.Click += new System.EventHandler(this.label1_Click);
            // 
            // operandoIgual
            // 
            this.operandoIgual.AutoSize = true;
            this.operandoIgual.Location = new System.Drawing.Point(535, 83);
            this.operandoIgual.Name = "operandoIgual";
            this.operandoIgual.Size = new System.Drawing.Size(14, 16);
            this.operandoIgual.TabIndex = 4;
            this.operandoIgual.Text = "=";
            // 
            // suma
            // 
            this.suma.Location = new System.Drawing.Point(310, 128);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(75, 23);
            this.suma.TabIndex = 5;
            this.suma.Text = "Suma";
            this.suma.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.suma.UseVisualStyleBackColor = true;
            this.suma.Click += new System.EventHandler(this.suma_Click);
            // 
            // resultado
            // 
            this.resultado.Location = new System.Drawing.Point(581, 81);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(100, 22);
            this.resultado.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.suma);
            this.Controls.Add(this.operandoIgual);
            this.Controls.Add(this.operandoSuma);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.Label operandoSuma;
        private System.Windows.Forms.Label operandoIgual;
        private System.Windows.Forms.Button suma;
        private System.Windows.Forms.TextBox resultado;
    }
}

