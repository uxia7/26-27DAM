using Ejercicio2;
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
    public partial class Form1 : Form//Ojo con título al principio
    {
        //public string ruta;
        public Form1()
        {
            InitializeComponent();
            /*
             * y ahora aqui es donde escribimos esta linea de codigo que sirve para filtrar que mencionamos antes
             * la estrcutura es: 
             * mensaje que vera el usuario en el despegable del filtro | filtros
             * y este patron es el que se sigue y en un mismo string puede haber tantos patrones se quiera
             * digamos que la secuencia dentro de un string que siempre hay que cumplir es:
             * descripcion1 | patron1 | descripcion2 | patron2... y asi cuantos necesites
             * luego, los * que se ponen indican cadenas del tamaño que sea y de lo que sea, siempre y cuando cumplan con esa extension
             * en el caso de *.jpg, por ejemplo, pero en el caso de *.* indica, cualquier archivo de cualquier extension
             * luego tenemos el ; que sirve para separar diferentes filtros dentro de un mismo patron, como en el caso de *.jpg;*.png
             */
            ofdImg.Filter = "Imagenes(.jpg, .png)|*.jpg;*.png|Todos los archivos(*.*)|*.*";

            //nos interesa inicializar el timer cuando se crea el formulario porque tenemos que gestionar el tiempo que estamos dentro de la app
            timer1.Start();
        }

        private void btnNuevaImg_Click(object sender, EventArgs e)
        {
            //cuando se pulsa el boton se abre un visor de OpenFileDialog
            /*
             * OpenFileDialog, es lo que se abre cuando a un archivo le damos a abrir 
             * es esa ventanita del explorador de archivos de windows
             * 
             * nosotros no la diseñamos porque windows la tiene por defecto
             * nosotros solo lo abrimos con esta clase para poder mostrar 
             * los archivos del tipo que queramos filtrar 
             * 
             * cuando pulsemos este boton de Nueva imagen tiene que abrirse esa ventana
             * para poder cargar una imagen que nosotros elijamos
             */

            /*
             * aunque el OpenFileDialog no sea visible, se pone desde el diseñador grafico a mano 
             * como un componente mas, con lo cual tenemos que gestionarlo desde abajo
             * porque como es no visible aparece abajo en una barrita especial
             * 
             * como todo componente tiene propiedades y funciones
             */

            //para abrir el OpenFileDialog:
            // -> ofdImg.ShowDialog();

            /*
             * para saber si el usuario una vez que se abrio la ventana, pulso el boton aceptar y nos dio una ruta
             * o cancelo la operacion 
             * 
             * el ofdImg.ShowDialog() esta funcion devuelve un resultado de tipo DialogResult, con lo cual
             * cuando llamamos a esa funcion, podemos recoger su valor en una variable de tipo DialogResult:
             */
            DialogResult resultado = ofdImg.ShowDialog();

            //y una vez recogido dicho resultado, usarlo en el if para saber si se hizo correctamente la operacion o no
            if (resultado == DialogResult.OK)
            { //en caso de que el usuario haya elegido una imagen y le haya dado al boton Aceptar

                //para obtener la ruta que se devuelve, usamos el:
                string ruta = ofdImg.FileName;
                //asi obtenemos la ruta completa, si quisieramos solo el nombre del archivo hariamos
                //Path.GetFileName(ruta)
                //peor no es necesario, es solo por curiosidad porque pensaba que funcionaba diferente


                /*
                 * en el ejercicio se menciona lo de los filtros y para hacer eso
                 * tenemos que usar la propiedad filter que corresponde al OpenFileDialog
                 * se hace de la siguiente manera, primero nos vamos al constructor de la clase
                 */

                /*
                 * una vez que el usuario dijo que si y ya el OpenFileDialog se cerro
                 * tenemos que abrir un modal con la imagen del usuario dentro ocupando todo
                 * entonces hacemos los siguientes pasos
                 * 
                 * primero lanzamos el formulario:
                 */
                Form2 f2 = new Form2(ruta);
                //me dio un error que no me encontraba el Form2, eso fue porque no tenia la referencia al proyecto Ejercicio 2 indicada

                //el siguiente paso es:
                // -> f2.ShowDialog();
                //para mostrar el formulario secundario en donde pondremos la imagen que hemos recogido en el OpenFileDialog la ruta y asi
                //le pasamos dicha ruta como param al constructor del Form2 para poder acceder a ella

                //en caso de que el checkbox Modal este marcado el form será modal, si no, no y eso lo sabemos con el ckModal.Checked para saber
                //si esta marcado o no y para abrir el form2 de forma modal es con su funcion .ShowDialog() en el caso contrario, el no modal es .Show()
                if (ckModal.Checked)
                {
                    f2.ShowDialog();
                    
                }
                else
                {
                    f2.Show();
                }


            }
            else
            {//en caso de que se haya cancelado la operacion

                MessageBox.Show("No cargaste ninguna imagen", "No imagen", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //o en caso de querer hacerlo mas corto o directo, se pone directamente dentro del if
            //if(ofdImg.ShowDialog() ==  DialogResult.OK)
            //serviria igual y seria igual de valida que la primera, solo que mas corta y directa, sin esa variable de por medio
        }

        //creamos una variable para gestionar el tiempo correctamente
        int segundos = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            segundos++;
            int seg = segundos % 60;
            int minutos = segundos / 60;
            //si quisieramos añadir horas, deberiamos de poner % en minutos y segundos y las horas seria con /

            //D2 es un formato que le ponemos a las variables para poder mostrar los 0 y mostrar ese formato de tiempo correcto
            this.Text = $"Visor de imagenes: {minutos:D2}:{seg:D2}";
        }

        private void ckModal_CheckedChanged(object sender, EventArgs e)
        {
            if(ckModal.Checked)
            {
                ckModal.ForeColor = Color.Red;
            }
            else
            {
                ckModal.ForeColor = Color.Black;
            }
        }
    }
}
