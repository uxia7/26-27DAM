using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenEjemplo
{
    internal class Record
    {
        public string nombre;

        private int edad;
        public int Edad
        {
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    this.edad = value;
                }
            }

            get
            {
                return this.edad;
            }
        }

        public int puntuacion;

        public Record(string nombre, int edad, int puntuacion)
        {
            this.nombre = nombre;
            this.Edad = edad;
            this.puntuacion = puntuacion;
        }

        public override string ToString()
        {
            return $"{this.nombre}, {this.Edad}, {this.puntuacion}";
        }
    }
}
