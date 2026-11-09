using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepasoExamen
{
    public partial class Form2 : Form
    {
        public string nomReceta;
        public string desRece;

        public int tiemRece;

        public Form2()
        {
            InitializeComponent();
            
            for(int i = 5; i <= 60; i+=5)
            {
                cbTiempo.Items.Add(i);
            }

            cbTiempo.SelectedItem = 20;
        }

        public void respuesta(object sender, EventArgs e)
        {
            nomReceta = nomRec.Text;

            desRece = descript.Text;

            tiemRece = Convert.ToInt32(cbTiempo.SelectedItem);

            if (sender == guardar) {
                DialogResult = DialogResult.Yes;
            } 
            else
            {
                DialogResult = DialogResult.No;
            }

            this.Hide();
        }
    }
}
