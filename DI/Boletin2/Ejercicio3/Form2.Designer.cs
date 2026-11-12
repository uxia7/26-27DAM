namespace Ejercicio3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.imagen = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deformarImagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noDeformarImagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imagen
            // 
            this.imagen.ContextMenuStrip = this.contextMenuStrip1;
            this.imagen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagen.Location = new System.Drawing.Point(0, 0);
            this.imagen.Name = "imagen";
            this.imagen.Size = new System.Drawing.Size(800, 450);
            this.imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagen.TabIndex = 0;
            this.imagen.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deformarImagenToolStripMenuItem,
            this.noDeformarImagenToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(219, 52);
            // 
            // deformarImagenToolStripMenuItem
            // 
            this.deformarImagenToolStripMenuItem.Name = "deformarImagenToolStripMenuItem";
            this.deformarImagenToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
            this.deformarImagenToolStripMenuItem.Text = "Deformar imagen";
            this.deformarImagenToolStripMenuItem.Click += new System.EventHandler(this.deformarImagenToolStripMenuItem_Click);
            // 
            // noDeformarImagenToolStripMenuItem
            // 
            this.noDeformarImagenToolStripMenuItem.Name = "noDeformarImagenToolStripMenuItem";
            this.noDeformarImagenToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
            this.noDeformarImagenToolStripMenuItem.Text = "No deformar imagen";
            this.noDeformarImagenToolStripMenuItem.Click += new System.EventHandler(this.noDeformarImagenToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imagen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imagen;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deformarImagenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noDeformarImagenToolStripMenuItem;
    }
}