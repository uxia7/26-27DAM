namespace Ejercicio5
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
            this.numeros = new System.Windows.Forms.TextBox();
            this.reseteo = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.grabarNum = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarAgen = new System.Windows.Forms.ToolStripMenuItem();
            this.resetOp = new System.Windows.Forms.ToolStripMenuItem();
            this.separador = new System.Windows.Forms.ToolStripMenuItem();
            this.salir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numeros
            // 
            this.numeros.Location = new System.Drawing.Point(322, 48);
            this.numeros.Name = "numeros";
            this.numeros.Size = new System.Drawing.Size(100, 22);
            this.numeros.TabIndex = 0;
            // 
            // reseteo
            // 
            this.reseteo.Location = new System.Drawing.Point(635, 48);
            this.reseteo.Name = "reseteo";
            this.reseteo.Size = new System.Drawing.Size(75, 23);
            this.reseteo.TabIndex = 1;
            this.reseteo.Text = "Resetear";
            this.reseteo.UseVisualStyleBackColor = true;
            this.reseteo.Click += new System.EventHandler(this.reseteo_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.acercaDe});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grabarNum,
            this.mostrarAgen,
            this.resetOp,
            this.separador,
            this.salir});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(73, 24);
            this.toolStripMenuItem1.Text = "Archivo";
            // 
            // acercaDe
            // 
            this.acercaDe.Name = "acercaDe";
            this.acercaDe.Size = new System.Drawing.Size(98, 24);
            this.acercaDe.Text = "Acerca de...";
            // 
            // grabarNum
            // 
            this.grabarNum.Name = "grabarNum";
            this.grabarNum.Size = new System.Drawing.Size(224, 26);
            this.grabarNum.Text = "Grabar numero";
            this.grabarNum.Click += new System.EventHandler(this.grabarNum_Click);
            // 
            // mostrarAgen
            // 
            this.mostrarAgen.Name = "mostrarAgen";
            this.mostrarAgen.Size = new System.Drawing.Size(224, 26);
            this.mostrarAgen.Text = "Mostrar agenda";
            // 
            // resetOp
            // 
            this.resetOp.Name = "resetOp";
            this.resetOp.Size = new System.Drawing.Size(224, 26);
            this.resetOp.Text = "Reset";
            // 
            // separador
            // 
            this.separador.Name = "separador";
            this.separador.Size = new System.Drawing.Size(224, 26);
            this.separador.Text = "Separador";
            // 
            // salir
            // 
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(224, 26);
            this.salir.Text = "Salir";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reseteo);
            this.Controls.Add(this.numeros);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numeros;
        private System.Windows.Forms.Button reseteo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem grabarNum;
        private System.Windows.Forms.ToolStripMenuItem mostrarAgen;
        private System.Windows.Forms.ToolStripMenuItem resetOp;
        private System.Windows.Forms.ToolStripMenuItem separador;
        private System.Windows.Forms.ToolStripMenuItem salir;
        private System.Windows.Forms.ToolStripMenuItem acercaDe;
    }
}

