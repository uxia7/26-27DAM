using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5
{
    public partial class Form1 : Form
    {
        Button botones;
        public Form1()
        {
            InitializeComponent();

            //inicializamos las variables a las posiciones iniciales que queramos
            int x = 200;
            int y = 100;
            //una solucion es pasar en una cadena toda la combinacion de caracteres que queremos usar
            //porque al final es eso, un string no deja de ser un array de caracteres
            string aux = "123456789*0#";
            //otra opcion es crear un array de string y rellenarlo con los caracteres que queremos
            //string[] aux2 = { "1", "2", };
            for (int i = 1; i <= 12; i++)
            {
                //con la cadena auxiliar ya no hace falta hacer comprobaciones con los ifs

                //if (i <= 9)
                //{
                //    botones = new Button();
                //}
                //else if (i == 10)
                //{
                //    botones = new Button();
                //    botones.Text = "*";

                //}
                //else
                //{
                //    botones = new Button();
                //    botones.Text = "#";
                //}

                //si tenemos la cadena colocada de esta manera solo tenemos 
                botones.Text = aux[i - 1].ToString();
                botones.Size = new Size(50, 50);

                //establecemos x e y que en cada vuelta cambiaran de valor y se reiniciaran
                botones.Location = new Point(x, y);// (200 + (i % 3) * 50, 100 + (i / 3) * 50);

                //como necesitamos 3 filas
                if (i % 3 != 0)
                {
                    x += 70;

                }
                else
                {
                    x = 200;
                    y += 60;
                }

                this.Controls.Add(botones);

                botones.Click += this.pulsaciones_Click;
                botones.MouseEnter += this.coloresPasar_MouseEnter;
                botones.MouseLeave += this.coloresQuitar_MouseLeave;
                botones.MouseDown += this.permanColor_MouseDown;

            }

            //for(int i = 0, i < this.Controls.Count; i++)
            //{

            //}

            //preguntarle a curro sobre si en el examen usamos el showDialog para el modal o si usamos el Open del apednice para el modal
        }

        public void pulsaciones_Click(object sender, EventArgs e)
        {
            //estas dos lineas de codigo son equivalentes y es para que cada vez que escribes no se sustituya si no que se concatenen todos los valores
            //this.numeros.Text = this.numeros.Text + ((Button)sender).Text;
            this.numeros.Text += ((Button)sender).Text;
        }

        public void permanColor_MouseDown(object sender, EventArgs e)
        {
            Button pulsado = ((Button)sender);
            pulsado.BackColor = Color.Violet;
            /*
             * existe una propiedad comun a todos los componentes que se llama TAG
             * esta propiedad puede guardar cualquier cosa porque es de tipo object
             * pueda guardar, strings, numeros, boleanas
             * entonces podemos usar esta propiedad para que cuando entremos a X evento
             * podriamos hacerlo guardando una booleana en el TAG de ese componente
             * 
             * los valores guardados dentro del TAG se pueden sustituir o limpiar cuando 
             * guardas el primer valor y luego guardas uno diferente o nuevo
             */
            pulsado.Tag = true;

        }

        public void coloresPasar_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Magenta;
        }

        public void coloresQuitar_MouseLeave(object sender, EventArgs e)
        {
            Button quitar = ((Button)sender);
            //porque si esta null eso quiere decir que nunca se hice el click 
            //con lo cual nunca se le asigno un valor al TAG
            if (quitar.Tag != null)
            {
                quitar.BackColor = Color.Violet;
            }
            else
            {
                quitar.BackColor = Color.White;
            }

        }

        private void reseteo_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (this.Controls[i] is Button)
                {
                    this.Controls[i].BackColor = Color.White;
                }
                else
                {
                    this.Controls[i].Text = "";
                }
            }
        }

        private void grabarNum_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();

        }
    }
}
