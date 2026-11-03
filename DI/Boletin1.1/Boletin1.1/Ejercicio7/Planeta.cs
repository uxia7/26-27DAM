using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    internal class Planeta : Astro, ITerraformable
    {
        private bool gaseoso;

        public bool Gaseoso { set; get; }
        //{
        //    set
        //    {
        //        this.gaseoso = value;
        //    }

        //    get
        //    {
        //        return gaseoso;
        //    }
        //}

        private int numSat;

        public int NumSat
        {
            set
            {
                if (value < 0)
                {
                    this.numSat = 0;
                }
                else
                {
                    this.numSat = value;
                }
            }

            get
            {
                return numSat;
            }
        }

        public Planeta(string nombre, double radio, bool gaseoso, int numSat) : base(nombre, radio)
        {
            Gaseoso = gaseoso;
            NumSat = numSat;
        }

        public Planeta() : this("", 1, false, 0)
        {

        }

        public bool esHabitable()
        {
            return (Gaseoso && (Radio < 2000 || Radio > 8000));
            //EMPEZAR A VER LOS RETURN DE LOS IF SOLOS SIN TENER QUE PONER LOS TRUE Y FALSE
            //{
            //    return false;
            //} else
            //{
            //    return true;
            //}
        }

        public override string ToString()
        {
            //string.Format no va con las cadenas interpoladas, va con las indexadas
            return $"Nombre: {Nombre,10}\nCantidad de satelites: {NumSat,4}\nRadio: {Radio:F2}";
        }

        public static Planeta operator ++(Planeta p1)
        {
            p1.NumSat++;
            return p1;
        }

        public static Planeta operator --(Planeta p1)
        {
            //if(p1.NumSat < 0)
            //{
            //    throw new ArgumentException();//Guarda 0
            //} else
            //{

            /*codigo totalmente inncesario porque ya se hace la comprobacion
             *p1.NumSat esta llamando al setter del NumSat y comprueba si se le esta pasando un negativo
             *el codigo interno que tiene es el siguiente
             *p1.NumSat--; equivale a p1.NumSat = p1.NumSat - 1; el setter ya controla los negativos
             */
            p1.NumSat--;
            return p1;
            //}
        }
    }
}
