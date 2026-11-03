using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio6
{
    public partial class Form1 : Form
    {
        string comienzo = "Escribe aqui un titulo para el formulario";
        public Form1()
        {
            InitializeComponent();

            //modTitulo.Enabled = false;
            modTitulo.Text = comienzo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //modTitulo.Enabled = true;

            DialogResult decision = MessageBox.Show("Quieres poner: \"" + modTitulo.Text + "\" como titulo?", "Cambiar titulo del formulario", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (decision == DialogResult.Yes && modTitulo.Text != comienzo)
            {
                MessageBox.Show("Se efectuara el cambio", "Aceptado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Text = modTitulo.Text;
            }
            else
            {
                MessageBox.Show("No se realizara el cambio de titulo", "Rechazado o No modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
