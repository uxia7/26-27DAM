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
        Button[,] botones;
        string titulo;
        public Form1()
        {
            InitializeComponent();
            titulo = this.Text;

            /*
             * crear los botones en tiempo de ejecucion es crearlos en el constructor del formulario y no crearlos en el diseñador grafico
             * hay que crear 20 botones y situarlos en 4 filas y 5 columnas, lo cual ya nos dan las 20 posiciones
             * haciendo una matriz de 4 x 5 lo conseguimos perfectamente
             */
            botones = new Button[4, 5];
            int cont = 1;
            for (int i = 0; i < botones.GetLength(0); i++)
            {
                for (int j = 0; j < botones.GetLength(1); j++)
                {
                    botones[i, j] = new Button();
                    botones[i, j].Size = new Size(50, 50);
                    botones[i, j].Location = new Point(j * 50, i * 50);
                    botones[i, j].Text = cont.ToString();

                    botones[i, j].MouseMove += this.Form1_MouseMove; //foo; (curro)// 
                    /*
                     * cuando llamo al .MouseMove
                     */
                    botones[i, j].MouseDown += this.Form1_MouseDown;
                    botones[i, j].MouseUp += this.Form1_MouseUp;

                    this.Controls.Add(botones[i, j]);
                    cont++;
                }
            }



        }
        //void foo(object a, MouseEventArgs aaa) { }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            /*
             * una vez que ya tenemos creado el evento asociado a nuestro formmulario que es el MouseMove 
             * y nosotros queremos que cada vez que movemos el raton aparezcan sus coordenadas podemos hacerlo de dos formas
             * 
             * la primera:
             * podemos usar e.Location que nos da la localizacion del raton en todo momento, pero e.Location devuelve un dato de tipo Point
             * con lo cual deberiamos de usar el ToString() para poder pasarlo a cadena y que no nos de error
             * 
             * la segunda:
             * usando e.X y e.Y, que son las dos coordenadas de X e Y en todo momento, es lo mismo que e.Location pero ya dividido
             * y aparte de que podemos usarlo como strig sin problema ninguno con lo cual ya nos quitamos un problema del medio
             * y no necesitamos usar el ToString al final
             * 
             * lo dejamos hecho de las dos maneras
             */

            //this.Text = e.Location.ToString();
            //this.Text = "( " + e.X + " : " + e.Y + " )";


            /*
             * claro ahora nos funciona y nos da las coordenadas en cada momento del raton por el formulario
             * bien pero la problematica viene ahora porque cada vez que pasamos por cada componente las coordenadas dejan de funcionar
             * eso se debe a que claro, cuando el evento recoge quien lo lanza, ve que no es el componente al que esta asignado asi que 
             * no sabe ni ve nada, con lo cual, para solucionar esta problematica lo que tenemos que hacer es:
             * 
             * cogemos los componentes del form y les asignamos esta misma funcion ne su apartado correspondiente
             * asi ahora esos componentes tambien reaccionan cuando el raton pasa por encima porque tambien tienen esta funcion
             * y reaccionan igual, pero problema => no continuan con el mismo, se reinician y empiezan en 0 y ponen la locacion dentro 
             * de cada componente
             * y no la localizacion de ese componente en base al formulario, con lo cual:
             */

            //Control es una clase que guarda que componente lanza el evento en el que estamos
            //en este caso c es quien guardara el objeto que lanza el evento que nos devuelve el parametro sender
            //pero para ello hay que castear el sender a Control
            Control c = (Control)sender;

            //HACER ANOTACION breve: tengo que identificar el form porque
            if (sender is Form1)
            {
                this.Text = $"{e.X} : {e.Y}";
            }
            else
            {
                //c.Left indica la distancia que hay entre el componente que lanza el evento y el lado izquierdo del form y le sumammos e.X que
                //es la localizacion del raton
                //c.Top es la posicion del compoenente y el borde superior del form y le sumamos e.Y porque es la localizacion del raton
                //con lo cual la suma de uno y del otro nos devuelve la posicion real del componente en el formulario y no se reinicia la posicion 
                this.Text = $"{c.Left + e.X} : {c.Top + e.Y}";
            }

            //y asi de esta manera cada vez que el raton pasa por encima de cada componente no se reinicia la posicion del raton simplemente
            //sigue con las coordenadas
            //y tambien de forma global si se añaden mas componentes, este codigo seguira funcionando
        }

        /*
         * el siguiente punto menciona que cuando cuando el raton abandona el formulario se tiene que reiniciar el titulo del formulario 
         * al titulo original
         * 
         * asi que la funcion que tenemos que usar ahora seria la de MouseLeave, porque es cuando el formulario deja el form, 
         * con lo cual esa es la funcion mas apropiada
         * 
         * para obtener el titulo original y que en caso de que cambie el titulo no afecte al codigo:
         * creamos una variable de clase de tipo string la cual usaremos para guardar el dato actual del titulo
         * despues, dentro del constructor del Form1, que es donde están los valores por defecto a la hora de crear el formulario
         * cogemos la variable de clase que creamos antes y en esa variable es donde guardamos el valor de this.Text que es el 
         * titulo original del form
         */
        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            //ahora dentro de esta funcion lo que hacemos es simplemente, dentro de this.Text que es donde se hace referencia al titulo del form
            //guardamos ese valor inicial que reservamos en esa dicha variable
            this.Text = titulo;
        }

        //ANOTACION:
        //ambas propiedades Down y Up, tienen informacion sobre e.Button que nos dice cual de los dos click del raton ocurrio
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            //este evento es el que se lanza cuando se pulsa el raton hacia abajo se ejecuta algo pero en el momento en el que se suelta
            //y solo pasa cuando se pulsa pero cuando se levanta ya no
            if (sender is Button)
            {
                ((Button)sender).ForeColor = Color.Violet;
            }
            else
            {
                if (e.Button == MouseButtons.Left)
                {
                    clickIzq.BackColor = Color.Teal;
                }
                else if (e.Button == MouseButtons.Right)
                {
                    clickDere.BackColor = Color.Violet;
                }
                else
                {
                    clickIzq.BackColor = Color.AliceBlue;
                    clickDere.BackColor = Color.Violet;
                }
            }


        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Left)
            //{
            //    clickIzq.BackColor = Color.White;
            //}
            //else if (e.Button == MouseButtons.Right)
            //{
            //    clickDere.BackColor = Color.White;
            //}
            //else
            //{
            //    clickIzq.BackColor = Color.White;
            //    clickDere.BackColor = Color.White;
            //}

            /*
             * en este caso no hace falta identificar que click lanza el evento
             * ambos lo lanzan pero ambos necesitan hacer lo mismo cuando se lanza el evento del MouseUp
             * entonces solo basta con poner que ambos botones se pongan en blanco cuando en cualquier momento se lance esta accion 
             * da igual quien lo lance
             */
            if (sender is Button)
            {
                ((Button)sender).ForeColor = Color.Black;
            }
            else
            {
                clickIzq.BackColor = Color.White;
                clickDere.BackColor = Color.White;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            /*
             * ahora nos indican que si se pulsa una tecla tiene que aparecer en el titulo del formulario 
             * y que si se pulsa ESC se pone el titulo original otra vez
             * 
             * usamos el KeyDown por dos motivos:
             * el primero es porque detecta todo, tanto teclas especiales como letras sin embargo el KeyPress, se centra mejor en 
             * las letras que en las teclas especiales, por eso no usamos ese y usamos el Down
             * que el Down
             * 
             * el segundo
             * porque la tecla pulsada tiene que aparecer cuando se pulsa no cuando se levanta el dedo de la tacla
             * seria raro que justo aparezca cuando dejo de pulsar la tecla, bueno, eso decia chat -> PREGUNTAR A CURRO
             */

            //KeyValue, duelve un numero que representa la tecla pulsada, pero si no lo sabes y quieres hacer esa comparacion lo ideal es
            //KeyCode y luego usas el Keys y buscas la tecla que tu quieras buscar
            if (e.KeyCode == Keys.Escape)
            {
                this.Text = titulo;
            }
            else
            {
                this.Text = e.KeyCode.ToString();
            }

            /*
             * en este caso hay que tener en cuenta la propiedad KeyPreview del formulario, la cual esta situada en la llave inglesa y no en el rayito
             * false:
             * significa que aunque KeyDown sea un evento del formulario, un boton o cualquier otro componente del form podria capturar sin querer el evento
             * en lugar de que lo haga solo el formulario
             * 
             * true:
             * lo gestiona solo el formulario, con lo cual, no existe la posibilidad de que los componentes capturen el evento y asi funciona correctamente
             * sobre el form y solo el formulario
             */
        }
    }
}
