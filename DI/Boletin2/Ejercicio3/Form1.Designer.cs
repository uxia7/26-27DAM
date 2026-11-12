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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnNuevaImg = new System.Windows.Forms.Button();
            this.ofdImg = new System.Windows.Forms.OpenFileDialog();
            this.ckModal = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnNuevaImg
            // 
            this.btnNuevaImg.Location = new System.Drawing.Point(51, 38);
            this.btnNuevaImg.Name = "btnNuevaImg";
            this.btnNuevaImg.Size = new System.Drawing.Size(110, 30);
            this.btnNuevaImg.TabIndex = 0;
            this.btnNuevaImg.Text = "Nueva imagen";
            this.btnNuevaImg.UseVisualStyleBackColor = true;
            this.btnNuevaImg.Click += new System.EventHandler(this.btnNuevaImg_Click);
            // 
            // ofdImg
            // 
            this.ofdImg.FileName = "openFileDialog1";
            // 
            // ckModal
            // 
            this.ckModal.AutoSize = true;
            this.ckModal.Location = new System.Drawing.Point(51, 146);
            this.ckModal.Name = "ckModal";
            this.ckModal.Size = new System.Drawing.Size(67, 20);
            this.ckModal.TabIndex = 1;
            this.ckModal.Text = "Modal";
            this.ckModal.UseVisualStyleBackColor = true;
            this.ckModal.CheckedChanged += new System.EventHandler(this.ckModal_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ckModal);
            this.Controls.Add(this.btnNuevaImg);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Visor de imagenes: ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevaImg;
        private System.Windows.Forms.OpenFileDialog ofdImg;
        private System.Windows.Forms.CheckBox ckModal;
        private System.Windows.Forms.Timer timer1;
    }
}

