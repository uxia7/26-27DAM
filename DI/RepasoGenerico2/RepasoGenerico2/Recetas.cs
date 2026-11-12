using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoGenerico2
{
    internal class Recetas
    {
        public string nombre { set; get; }
        public string descripcion { set; get; }
        public int tiempo { set; get; }

        public Recetas(string nombre, string descripcion, int tiempo)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.tiempo = tiempo;
        }

        public override string ToString()
        {
            return this.nombre;
        }
    }
}
