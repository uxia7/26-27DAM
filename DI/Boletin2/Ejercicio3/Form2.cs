using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace Ejercicio3
{
    public partial class Form2 : Form
    {
        public Form2(string ruta)
        {
            InitializeComponent();

            //en el pictureBox existe una opcion que se llama Dock
            //esta propiedad nos permite seleccionar como queremos o donde queremos que aparezca la imagen
            //salen como un barritas y un rectangulo central, ese central sirve para coger y darle un tamaño fijo en cierto espacio
            //otra cosa a tener en cuenta es que se menciona que se quiere que cuando cambie el formulario la imagen se estreche o se deforme,
            //para ello lo que hay que hacer es ir a la propiedad de SizeMode y poner lo de strech porque la de zoom hace que se ajuste

            //Form1 f1 = new Form1();

            try
            {
                imagen.Image = Image.FromFile(ruta);

            } catch(OutOfMemoryException e)//IO unaut
            {
                MessageBox.Show("No seleccionaste una imagen valida", "Imagen invalida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                imagen.Image = Image.FromFile("C:\\Users\\uxiap\\Downloads\\halconMirandoMal.jpg");

            } catch (UnauthorizedAccessException e)
            {
                MessageBox.Show("No tienes acceso a ese archivo", "No autorizacion para la imagen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                imagen.Image = Image.FromFile("C:\\Users\\uxiap\\Downloads\\halconMirandoMal.jpg");
            }
            

            //lo de abajo, tiene varias soluciones, con el split o con el FileInfo o asi
            //para darle el titulo del form, como el nombre del archivo sin la ruta o sin usar el Path, la opcion es con el Split
            //split para coger justo el ultimo componente de la ruta que ya conocemos
            string[] trozosRuta = ruta.Split('\\');

            this.Text = trozosRuta[trozosRuta.Length-1];
        }

        private void deformarImagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imagen.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void noDeformarImagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imagen.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
