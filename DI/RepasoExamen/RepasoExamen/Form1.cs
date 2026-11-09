using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepasoExamen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            lb.Items.Add("Pollo");
            lb.Items.Add("Espaguetis");
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();

            if(f2.ShowDialog() == DialogResult.Yes) {

                string nombre = f2.nomReceta;
                string descripcion = f2.desRece;
                int tiempo = f2.tiemRece;


                Recetas rc = new Recetas(nombre, descripcion, tiempo);

            }
            else
            {
                MessageBox.Show("No se ha guardado ninguna informacion", "No guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
