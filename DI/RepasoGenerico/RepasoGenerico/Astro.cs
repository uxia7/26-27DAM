using System;

namespace RepasoGenerico
{
    abstract class Astro
    {
        public string nombre
        {
            set
            {
                this.nombre = value.ToUpper();
            }

            get
            {
                return "\"" + nombre + "\"";
            }
        }
        public double radio
        {
            set
            {
                if(value > 0)
                {
                    this.radio = value;
                } else
                {
                    throw new ArgumentException();
                }
            } 

            get
            {
                return radio;
            }
        }

        public Astro(string nombre, double radio)
        {
            this.nombre = nombre;
            this.radio = radio;
        }

        public Astro() : this("Tierra", 6378)
        {
        }

        public override bool Equals(object obj)
        {
            if(obj is Astro || obj.GetType() == typeof(string))
            {
                if(((Astro)obj).nombre == this.nombre)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
