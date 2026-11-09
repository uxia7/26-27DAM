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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.clickIzq = new System.Windows.Forms.Button();
            this.clickDere = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clickIzq
            // 
            this.clickIzq.Location = new System.Drawing.Point(470, 377);
            this.clickIzq.Name = "clickIzq";
            this.clickIzq.Size = new System.Drawing.Size(75, 23);
            this.clickIzq.TabIndex = 0;
            this.clickIzq.Text = "Click Izq";
            this.clickIzq.UseVisualStyleBackColor = true;
            this.clickIzq.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // clickDere
            // 
            this.clickDere.Location = new System.Drawing.Point(599, 377);
            this.clickDere.Name = "clickDere";
            this.clickDere.Size = new System.Drawing.Size(105, 23);
            this.clickDere.TabIndex = 1;
            this.clickDere.Text = "Click Drch";
            this.clickDere.UseVisualStyleBackColor = true;
            this.clickDere.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clickDere);
            this.Controls.Add(this.clickIzq);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "MouseTester";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clickIzq;
        private System.Windows.Forms.Button clickDere;
    }
}

