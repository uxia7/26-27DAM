using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public static int enteros(string texto)
        {
            int resultado;
            if (!int.TryParse(texto, out resultado))
            {
                Debug.Write("No fue posible parsear el numero");
            }
            return resultado;
        }
        public Form1()
        {
            InitializeComponent();

            txtR.Enter += txtEnter;
        }

        private void salir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Quieres cerrar la ventana?", "Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Cierre cancelado", "Volviendo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void color_Click(object sender, EventArgs e)
        {
            int r = enteros(txtR.Text);
            int g = enteros(txtG.Text);
            int b = enteros(txtB.Text);

            if ((r < 0 || r > 255) || (g < 0 || g > 255) || (b < 0 || b > 255))
            {
                MessageBox.Show("Uno de los datos RGB es incorrecto", "Colores", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                this.BackColor = Color.FromArgb(r, g, b);
            }
        }

        private void cargar_Click(object sender, EventArgs e)
        {
            //sizemode
            string rutaRecog = ruta.Text;

            if (!File.Exists(rutaRecog))
            {
                MessageBox.Show("La ruta no existe", "Fallo en la ruta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                imagen.Image = Image.FromFile(rutaRecog);
            }
        }

        public void txtEnter(object sender, EventArgs e)
        {

        }
    }
}
