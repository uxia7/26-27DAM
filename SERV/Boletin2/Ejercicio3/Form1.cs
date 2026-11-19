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
        public Form1()
        {
            InitializeComponent();
        }

        //el enunciado nos dice que tiene que haber una funcion con esta cabecera
        //esta funcion devuelve un Task porque la operacion es asincrona y ademas devuelve un resultado tipo string
        private async Task<string> DownloadFileAsync(string fileName, int delayMs)
        {
            //usamos await aqui porque espera a que termine la tarea sin bloquear la interfaz grafica 
            //y usamos el Task.Delay() porque ejercicio dice que la descarga es simulada y los tiempos deben generarse mediante Task.Delay
            await Task.Delay(delayMs);

            return $"File {fileName} downloaded in {delayMs} ms.";
            //y tiene que devolver File archivo.txt downloaded in 5000 ms.
        }

        //tenemos que poner el async justo delante de esta funcion porque dentro de esta funcion estamos usando el await
        //por ese mismo motivo, siempre que usemos el await dentro de una funcion dicha funcion tiene que llevar en su cabecera
        //la palabra async
        private async void btnDownload_Click(object sender, EventArgs e)
        {
            string nombre = txtFileName.Text;

            Random r = new Random();

            int delay = r.Next(1000, 10001);

            string resultado = await DownloadFileAsync(nombre, delay);

            txtResults.AppendText(resultado + "\n");
        }
    }
}
