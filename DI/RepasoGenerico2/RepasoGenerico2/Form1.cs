using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepasoGenerico2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        Recetas receta;
        private void btnAnadir_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();

            DialogResult resultado = f2.ShowDialog();

            if (resultado == DialogResult.Yes)
            {
                string nombreF1 = f2.nombreF2;
                string descripcionF1 = f2.descripcionF2;
                int tiempoF1 = f2.tiempoF2;

                receta = new Recetas(nombreF1, descripcionF1, tiempoF1);

                //lb.Items.Add(receta.nombre);
                //automaticamente se llama al toString de recetas
                lb.Items.Add(receta);
            }
            else
            {

            }
        }

        private void lb_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < lb.SelectedItems.Count; i++)
            {
                txtDatos.AppendText($"{receta.nombre,10}\r{receta.tiempo,5}\r\n{receta.descripcion}\n");
            }
        }

        Label lbl;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                if (rbEliminar.Checked)
                {
                    for (int i = lb.Items.Count - 1; i <= 0; i--)
                    {
                        lb.Items.RemoveAt(i);
                    }

                    txtDatos.Text = "";

                }
                else if (rbMostrar.Checked)
                {
                    for (int i = 0; i < lb.Items.Count; i++)
                    {
                        lbl = new Label();

                        lbl.MouseEnter += this.lbl_MouseEnter;

                        lbl.MouseLeave += this.lbl_MouseLeave;

                        lbl.Text = ((Recetas)(lb.Items[i])).nombre.ToUpper();

                        lbl.Size = new Size(50, 50);

                        panel1.Controls.Add(lbl);

                        lbl.Tag = lb.Items[i];
                    }

                    for (int j = 0; j < panel1.Controls.Count; j++)
                    {
                        ((Label)panel1.Controls[j]).Location = new Point(10 + (j / 3) * 50, 20 + (j % 3) * 50);

                        if (j % 2 == 0)
                        {
                            ((Label)panel1.Controls[j]).ForeColor = Color.Green;
                        }
                        else
                        {
                            ((Label)panel1.Controls[j]).ForeColor = Color.Blue;
                        }
                    }
                }
            }
        }

        Recetas receta1;

        public void lbl_MouseEnter(object sender, EventArgs e)
        {
            receta1 = (Recetas)((Label)sender).Tag;

            ((Label)sender).Text = receta1.tiempo.ToString();
        }

        public void lbl_MouseLeave(object sender, EventArgs e)
        {

            receta1 = (Recetas)((Label)sender).Tag;

            ((Label)sender).Text = receta1.nombre;

        }
    }
}
