//directivas de compilacion 
//habilitar asi tal cual como esta y para deshabilitar pones un comentario delante
// #define PRUEBA



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //Que cuete
        private void btnJugar_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            //int num1 = rand.Next(1, 8); // = Convert.ToInt32(txt1.Text); ;
            //int num2 = rand.Next(1, 8); //= Convert.ToInt32(txt2.Text);
            //int num3 = rand.Next(1, 8); //= Convert.ToInt32(txt1.Text);
            int credito = Convert.ToInt32(lblCredito.Text);




            if (credito < 2)
            {
                MessageBox.Show("Sin saldo", "Saldo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                credito -= 2;
                lblCredito.Text = credito.ToString();
            }



            //usando la funcion de tupla
            (int num1, int num2, int num3) = Aleatoriedad(1, 8);

            txt1.Text = num1.ToString();
            txt2.Text = num2.ToString();
            txt3.Text = num3.ToString();

            if (num1 == num2 && num2 == num3)
            {

                lbInfoPremio.Text = "ENHORABUENA LOS 3 SON IGUALES, GANAS 20€!!";
                credito = credito + 20;
                lblCredito.Text = credito.ToString();

            }
            else if (num1 == num2 || num2 == num3 || num3 == num1)
            {
#if PRUEBA
                lbInfoPremio.Text = "hay 2 iguales, perdiste 5€!!!!";
                credito = credito - 5;
                lblCredito.Text = credito.ToString();

#else
                lbInfoPremio.Text = "hay 2 iguales, ganas 5€!!!!";
                credito = credito + 5;
                lblCredito.Text = credito.ToString();
#endif

            }
            else
            {
                lbInfoPremio.Text = "Lo sientoo, no ganaste nada :(";
            }

        }

        private void btnSumaCredito_Click(object sender, EventArgs e)
        {
            int credito = Convert.ToInt32(lblCredito.Text);

            credito = credito + 10;

            lblCredito.Text = credito.ToString();
        }

        // funcion con tupla y con retorno de numeros aleatorios para cada numero que se introduce
        (int, int, int) Aleatoriedad(int min, int max) // los parametros son rangos del aleatorio, o sea, el minimo y el maximo
        { //Cambiar la funcion (ver enunciado) y usarla
            Random rand = new Random();

            return (rand.Next(min, max), rand.Next(min, max), rand.Next(min, max));
        }

    }
}
