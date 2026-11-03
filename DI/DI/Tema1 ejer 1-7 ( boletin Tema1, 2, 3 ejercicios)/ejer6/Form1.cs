using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejer6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //el MessageBox es como el JOptionPane de swing pero en este caso no devuelve un int devuelve un DialogResult con lo cual para guardar el tema de los resultados
            //deberiamos crear una variable con el tipo correspondiente o sea un DialogResult
            DialogResult opcion;
            opcion = MessageBox.Show("Quieres poner este texto \"" + txt1.Text + "\" como titulo de la ventana?", "Cambiar titulo", MessageBoxButtons.YesNo); //devuelve un objeto de tipo DialogResult

            if(opcion == DialogResult.Yes)
            {
                this.Text = txt1.Text;
            }
            else
            {
                MessageBox.Show("No se ha cambiado el titulo", "Aviso", MessageBoxButtons.OK ,MessageBoxIcon.Exclamation);
            }
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
