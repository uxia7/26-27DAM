using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.AcceptButton = btnAñadir;

            toolTip1.SetToolTip(btnAñadir, "Añadir elemento");
            toolTip1.SetToolTip(btnEliminar, "Eliminar elemento");
            toolTip1.SetToolTip(btnTraspasar, "Traspasar elementos");

            actualizarLabelCantidad();
            actualizarLabelIndices();
            actualizarToolTipLista2();

            timer1.Interval = 200;
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
