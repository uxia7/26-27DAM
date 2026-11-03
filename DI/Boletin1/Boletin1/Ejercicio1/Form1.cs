using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public static int transformacion(string lectura)
        {
            if(int.TryParse(lectura, out int numero))
            {
                return numero;
            }
            else
            {
                return 0;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void sumar_Click(object sender, EventArgs e)
        {
            int prim = transformacion(num1.Text);
            int dos = transformacion(num2.Text);

            int solucion = prim + dos;

            resultado.Text = " = " + solucion.ToString();
        }
    }
}
