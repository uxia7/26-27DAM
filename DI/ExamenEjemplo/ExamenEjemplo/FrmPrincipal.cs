using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenEjemplo
{
    public partial class FrmPrincipal : Form
    {
        CheckBox ckb;
        public FrmPrincipal()
        {
            InitializeComponent();

            int x = 30;
            int y = 30;
            
            for (int i = 0; i < 49; i++)
            { //int i = 1; i <= 4; i++S
                ckb = new CheckBox();

                ckb.Text = (i+1).ToString();
                //ckb.text = i.toString();

                //9coluns y 6 filas
                int columna = i%9;
                int fila = i / 9;
                ckb.Size = new Size(50, 50);

                ckb.Location = new Point(30+columna * 50, 30+ fila *50 );

                //ckb.Location = new Point(x, y);

                //if (i % 9 != 0)
                //{
                //    x += 60;
                //}
                //else
                //{
                //    x = 30;
                //    y += 60;
                //}
                //si me dan las columnas, se hace de la manera de arriba, pero en caso de que me dieran las filas, seria cambiar la x por la y
                this.Controls.Add(ckb);

                //añadimos el tooltip
                tp1.SetToolTip(ckb, "No marcado");

                ckb.CheckedChanged += this.ckb_CheckedChanged;

                timer1.Start();
            }
        }

        public void ckb_CheckedChanged(object sender, EventArgs e)
        {
            ckb = (CheckBox)sender;
            if(ckb.Checked)
            {
                tp1.SetToolTip(ckb, "Marcado");
            }
            else
            {
                tp1.SetToolTip(ckb, "No marcado");
            }
        }

        //Color colorAntiguo;
        //Control controlAntiguo;
        int indice = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {

            //for(int i = 0; i < botones.Length; i++)
            //{
            //    if(i == 0)
            //    {
            //        botones[0].BackColor = Color.Yellow;
            //        botones[1].BackColor = Color.Beige;
            //        botones[2].BackColor = Color.Beige;

            //    } else if(i == 1)
            //    {
            //        botones[0].BackColor = Color.Beige;
            //        botones[1].BackColor = Color.Yellow;
            //        botones[2].BackColor = Color.Beige;
            //    } else
            //    {
            //        botones[0].BackColor = Color.Beige;
            //        botones[1].BackColor = Color.Beige;
            //        botones[2].BackColor = Color.Yellow;
            //    }
            //}

            //if (cont == 0)
            //{
            //    botones[0].BackColor = Color.Yellow;
            //    botones[1].BackColor = Color.Beige;
            //    botones[2].BackColor = Color.Beige;
            //    cont++;

            //}
            //else if (cont == 1)
            //{
            //    botones[0].BackColor = Color.Beige;
            //    botones[1].BackColor = Color.Yellow;
            //    botones[2].BackColor = Color.Beige;
            //    cont++;
            //}
            //else
            //{
            //    botones[0].BackColor = Color.Beige;
            //    botones[1].BackColor = Color.Beige;
            //    botones[2].BackColor = Color.Yellow;
            //    cont++;
            //    cont = 0;
            //}

            Button[] botones = { btnJugar, btnReset, btnSalir };

            foreach (Button b in botones)
            {
                b.BackColor = Color.Beige;
            }

            botones[indice].BackColor = Color.Yellow;

            indice++;

            if (indice >= botones.Length)
            {
                indice = 0;
            }

        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
