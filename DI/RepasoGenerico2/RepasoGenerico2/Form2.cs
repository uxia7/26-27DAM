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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            for(int i = 5; i <= 60; i+=5)
            {
                cbTiempo.Items.Add(i);
            }

            cbTiempo.SelectedItem = 20;
        }

        public string nombreF2;
        public string descripcionF2;
        public int tiempoF2;
        public void guardarNoGuardar_Click(object sender, EventArgs e)
        {
            if(sender == btnGuardar)
            {
                nombreF2 = txtNombre.Text.Trim();
                descripcionF2 = txtDescripcion.Text.Trim();
                tiempoF2 = Convert.ToInt32(cbTiempo.SelectedItem);
            } else
            {

            }
        }
    }
}
