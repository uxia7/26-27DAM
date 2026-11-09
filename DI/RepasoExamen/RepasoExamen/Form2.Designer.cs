namespace RepasoExamen
{
    partial class Form2
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
            this.nombre = new System.Windows.Forms.Label();
            this.descri = new System.Windows.Forms.Label();
            this.nomRec = new System.Windows.Forms.TextBox();
            this.descript = new System.Windows.Forms.TextBox();
            this.tiempo = new System.Windows.Forms.Label();
            this.cbTiempo = new System.Windows.Forms.ComboBox();
            this.guardar = new System.Windows.Forms.Button();
            this.nGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(40, 55);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(56, 16);
            this.nombre.TabIndex = 0;
            this.nombre.Text = "Nombre";
            // 
            // descri
            // 
            this.descri.AutoSize = true;
            this.descri.Location = new System.Drawing.Point(40, 113);
            this.descri.Name = "descri";
            this.descri.Size = new System.Drawing.Size(79, 16);
            this.descri.TabIndex = 2;
            this.descri.Text = "Descripcion";
            // 
            // nomRec
            // 
            this.nomRec.Location = new System.Drawing.Point(109, 55);
            this.nomRec.Name = "nomRec";
            this.nomRec.Size = new System.Drawing.Size(100, 22);
            this.nomRec.TabIndex = 1;
            // 
            // descript
            // 
            this.descript.AcceptsReturn = true;
            this.descript.Location = new System.Drawing.Point(137, 110);
            this.descript.Multiline = true;
            this.descript.Name = "descript";
            this.descript.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.descript.Size = new System.Drawing.Size(210, 97);
            this.descript.TabIndex = 3;
            // 
            // tiempo
            // 
            this.tiempo.AutoSize = true;
            this.tiempo.Location = new System.Drawing.Point(43, 277);
            this.tiempo.Name = "tiempo";
            this.tiempo.Size = new System.Drawing.Size(54, 16);
            this.tiempo.TabIndex = 4;
            this.tiempo.Text = "Tiempo";
            // 
            // cbTiempo
            // 
            this.cbTiempo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTiempo.FormattingEnabled = true;
            this.cbTiempo.Location = new System.Drawing.Point(109, 277);
            this.cbTiempo.Name = "cbTiempo";
            this.cbTiempo.Size = new System.Drawing.Size(121, 24);
            this.cbTiempo.TabIndex = 5;
            // 
            // guardar
            // 
            this.guardar.Location = new System.Drawing.Point(556, 390);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(75, 23);
            this.guardar.TabIndex = 6;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.respuesta);
            // 
            // nGuardar
            // 
            this.nGuardar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.nGuardar.Location = new System.Drawing.Point(667, 390);
            this.nGuardar.Name = "nGuardar";
            this.nGuardar.Size = new System.Drawing.Size(90, 23);
            this.nGuardar.TabIndex = 7;
            this.nGuardar.TabStop = false;
            this.nGuardar.Text = "No Guardar";
            this.nGuardar.UseVisualStyleBackColor = true;
            this.nGuardar.Click += new System.EventHandler(this.respuesta);
            // 
            // Form2
            // 
            this.AcceptButton = this.guardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.nGuardar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nGuardar);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.cbTiempo);
            this.Controls.Add(this.tiempo);
            this.Controls.Add(this.descript);
            this.Controls.Add(this.nomRec);
            this.Controls.Add(this.descri);
            this.Controls.Add(this.nombre);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label descri;
        private System.Windows.Forms.TextBox nomRec;
        private System.Windows.Forms.TextBox descript;
        private System.Windows.Forms.Label tiempo;
        private System.Windows.Forms.ComboBox cbTiempo;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.Button nGuardar;
    }
}