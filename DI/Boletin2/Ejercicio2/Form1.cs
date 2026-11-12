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
using System.Xml.Serialization;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        //TODO placeholder
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

            //el segundo parametro EVENTARGS
            //color.MouseEnter += this.Boton_MouseEnter;
            //cargar.MouseEnter += this.Boton_MouseEnter;
            //reseteo.MouseEnter += this.Boton_MouseEnter;
            //salir.MouseEnter += this.Boton_MouseEnter;

            //desde el diseñador y ponerlos todos a mano

            //recorriendo lo de Controls
            for(int i = 0; i < this.Controls.Count; i++)
            {
                if (this.Controls[i] is Button)
                {
                    this.Controls[i].MouseEnter += this.Boton_MouseEnter;
                    this.Controls[i].MouseLeave += this.Boton_MouseLeave;
                }
            }
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
            //modificacion de como queremos que se vea la imagen: SIZEMODE
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

        private void reseteo_Click(object sender, EventArgs e)
        {
            //esto serviria para recorrer todos los componentes del formulario
            for(int i = 0; i < this.Controls.Count; i++)
            {
                if(this.Controls[i] is TextBox)
                {
                    ((TextBox)this.Controls[i]).Text = "0";

                } else if (this.Controls[i] is PictureBox)
                {
                    ((PictureBox)this.Controls[i]).Image = null;
                }
            }

            //con el TAG que basicamente en el form, cada componente tiene esa propiedad TAG en sus propiedades
            //enton con cada uno, puedes asignar el mismo asi todos los que tengan ese tag se restablecen al mismo valor
            //foreach (Control c in this.Controls)
            //{
            //    if (c is TextBox)
            //    {
            //        if (c.Tag.ToString() == "color")
            //        {
            //            c.Text = "0";
            //        }
            //        else if (c.Tag.ToString() == "imagen")
            //        {
            //            c.Text = "";
            //        }
            //    }
            //}

            //para volver al valor original del formulario que es el blanco pero con las propiedades
            this.BackColor = SystemColors.Control;
        }

        public void Boton_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Violet;
        }

        public void Boton_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.White;
        }

        //es una funcion para cuando antes de que se cierre el form
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Seguro que quieres cerrar el formulario?", "Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if(resultado == DialogResult.Yes)
            {
                e.Cancel = false;
            } 
            else
            {
                e.Cancel = true;
            }
        }
    }
}
