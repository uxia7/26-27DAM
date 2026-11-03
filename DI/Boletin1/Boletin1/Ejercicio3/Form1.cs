#define PRUEBA
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        //cuidado con los statics
        public (int, int, int) numAle(int min, int max)
        {
            Random rand = new Random();

            int num1 = rand.Next(min, max + 1);
            int num2 = rand.Next(min, max + 1);
            int num3 = rand.Next(min, max + 1);

            return (num1, num2, num3);
        }

        public int tranformacion(string lectura)
        {
            if (int.TryParse(lectura, out int numero))
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

        private void jugar_Click(object sender, EventArgs e)//Si no hay credito no hay juego
        {

            //para no repetir todo el tiempo esa linea de dinero o de premio, hacer las variable y al final de todo modificarlo

            int credito = tranformacion(dinero.Text);

            if (credito > 1)
            {
                credito -= 2;
                dinero.Text = credito.ToString();
            }
            else
            {
                DialogResult result = MessageBox.Show("Te has quedado sin credito ya no puedes jugar. Quieres recargar?", "Final del juego", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(result == DialogResult.Yes)
                {
                    credito += 10;
                    dinero.Text = credito.ToString();
                } else
                {
                    jugar.Enabled = false;
                }


            }

            (int prim, int dos, int tres) = numAle(1, 7);

            num1.Text = prim.ToString();
            num2.Text = dos.ToString();
            num3.Text = tres.ToString();

            if (prim == dos && dos == tres)
            {
                premio.Text = "20, premio gordo";
                credito += 1;
                dinero.Text = credito.ToString();
            }
            else if (prim == dos || dos == tres || tres == prim)
            {
                premio.Text = "5, sigue para el gordo";
#if PRUEBA
                credito += 1;
#else
                credito -=5;
#endif 
                dinero.Text = credito.ToString();
            }
            else
            {
                premio.Text = "No hay premio";
            }
        }

        private void recarga_Click(object sender, EventArgs e)
        {
            int recarga = tranformacion(dinero.Text);

            recarga += 10;

            dinero.Text = recarga.ToString();
        }
    }
}
