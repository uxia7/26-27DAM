namespace Ejercicio5
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
            this.smsNom = new System.Windows.Forms.Label();
            this.nombreTxt = new System.Windows.Forms.TextBox();
            this.aceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // smsNom
            // 
            this.smsNom.AutoSize = true;
            this.smsNom.Location = new System.Drawing.Point(67, 73);
            this.smsNom.Name = "smsNom";
            this.smsNom.Size = new System.Drawing.Size(105, 16);
            this.smsNom.TabIndex = 0;
            this.smsNom.Text = "Dime un nombre";
            // 
            // nombreTxt
            // 
            this.nombreTxt.Location = new System.Drawing.Point(197, 73);
            this.nombreTxt.Name = "nombreTxt";
            this.nombreTxt.Size = new System.Drawing.Size(100, 22);
            this.nombreTxt.TabIndex = 1;
            // 
            // aceptar
            // 
            this.aceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.aceptar.Location = new System.Drawing.Point(197, 156);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(75, 23);
            this.aceptar.TabIndex = 2;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.nombreTxt);
            this.Controls.Add(this.smsNom);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label smsNom;
        private System.Windows.Forms.TextBox nombreTxt;
        private System.Windows.Forms.Button aceptar;
    }
}