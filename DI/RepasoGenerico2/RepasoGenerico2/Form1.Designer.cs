namespace RepasoGenerico2
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
            this.lb = new System.Windows.Forms.ListBox();
            this.btnAnadir = new System.Windows.Forms.Button();
            this.txtDatos = new System.Windows.Forms.TextBox();
            this.accionesGroup = new System.Windows.Forms.GroupBox();
            this.rbEliminar = new System.Windows.Forms.RadioButton();
            this.rbMostrar = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.accionesGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb
            // 
            this.lb.FormattingEnabled = true;
            this.lb.ItemHeight = 16;
            this.lb.Location = new System.Drawing.Point(54, 58);
            this.lb.Name = "lb";
            this.lb.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lb.Size = new System.Drawing.Size(121, 148);
            this.lb.TabIndex = 0;
            this.lb.SelectedIndexChanged += new System.EventHandler(this.lb_SelectedIndexChanged);
            // 
            // btnAnadir
            // 
            this.btnAnadir.Location = new System.Drawing.Point(54, 230);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(75, 23);
            this.btnAnadir.TabIndex = 1;
            this.btnAnadir.Text = "Añadir";
            this.btnAnadir.UseVisualStyleBackColor = true;
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // txtDatos
            // 
            this.txtDatos.Location = new System.Drawing.Point(273, 58);
            this.txtDatos.Multiline = true;
            this.txtDatos.Name = "txtDatos";
            this.txtDatos.Size = new System.Drawing.Size(125, 147);
            this.txtDatos.TabIndex = 2;
            // 
            // accionesGroup
            // 
            this.accionesGroup.Controls.Add(this.rbMostrar);
            this.accionesGroup.Controls.Add(this.rbEliminar);
            this.accionesGroup.Location = new System.Drawing.Point(273, 230);
            this.accionesGroup.Name = "accionesGroup";
            this.accionesGroup.Size = new System.Drawing.Size(143, 124);
            this.accionesGroup.TabIndex = 3;
            this.accionesGroup.TabStop = false;
            this.accionesGroup.Text = "Acciones(A)";
            // 
            // rbEliminar
            // 
            this.rbEliminar.AutoSize = true;
            this.rbEliminar.Location = new System.Drawing.Point(7, 22);
            this.rbEliminar.Name = "rbEliminar";
            this.rbEliminar.Size = new System.Drawing.Size(76, 20);
            this.rbEliminar.TabIndex = 0;
            this.rbEliminar.TabStop = true;
            this.rbEliminar.Text = "Eliminar";
            this.rbEliminar.UseVisualStyleBackColor = true;
            // 
            // rbMostrar
            // 
            this.rbMostrar.AutoSize = true;
            this.rbMostrar.Location = new System.Drawing.Point(6, 48);
            this.rbMostrar.Name = "rbMostrar";
            this.rbMostrar.Size = new System.Drawing.Size(73, 20);
            this.rbMostrar.TabIndex = 1;
            this.rbMostrar.TabStop = true;
            this.rbMostrar.Text = "Mostrar";
            this.rbMostrar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(484, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 148);
            this.panel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.accionesGroup);
            this.Controls.Add(this.txtDatos);
            this.Controls.Add(this.btnAnadir);
            this.Controls.Add(this.lb);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Fredrecetas de pesadilla";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.accionesGroup.ResumeLayout(false);
            this.accionesGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb;
        private System.Windows.Forms.Button btnAnadir;
        private System.Windows.Forms.TextBox txtDatos;
        private System.Windows.Forms.GroupBox accionesGroup;
        private System.Windows.Forms.RadioButton rbMostrar;
        private System.Windows.Forms.RadioButton rbEliminar;
        private System.Windows.Forms.Panel panel1;
    }
}

