using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoExamen
{
    /*
     *  Nombre: string que guarda el nombre de la receta.
• Descripción: string donde se guarda datos de ingredientes y realización.
• Tiempo: int con el tiempo en minutos que lleva hacer la receta.
     */
    internal class Recetas
    {
        public string Nombre { set; get; }
        public string Descripcion { set; get; }
        public int Tiempo { set; get; }

        public Recetas(string nombre, string descripcion, int tiempo)
        {
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Tiempo = tiempo;
        }

        public override string ToString()
        {
            return string.Format(this.Nombre);
        }
    }
}
