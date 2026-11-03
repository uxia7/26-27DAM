using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace RepasoGenerico
{
    internal class Planeta : Astro, ITerraformable
    {

        public bool gaseoso;

        public int numSat
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
            this.gaseoso = gaseoso;
            this.numSat = numSat;
        }

        public Planeta() : this("", 1, false, 0)
        {

        }

        public bool esHabitable()
        {
            return (!gaseoso && (radio >= 2000 && radio <= 8000));
        }

        public override string ToString()
        {
            //devuelva la propiedad Nombre ocupando
            //10 caracteres, la cantidad de satélites ocupando 4 caracteres y el radio con 2
            //decimales(usa string.Format o cadenas interpoladas si ya las has visto).

            //return string.Format($"{nombre, 10}, {numSat, 4}, {radio:F2}");
            return string.Format("{0,10}, {1,4}, {2:F2}", nombre, numSat, radio);
        }

        /*
         * Sobrecarga los operadores ++ y -- de forma que si se aplica a un Planeta,
            incremente o decremente en una unidad la cantidad de satélites. No debe
            permitir bajar de 0.
         */

        //es estatica
        //devuelvee el tipo de clase que queramos o que nos especifiquen
        public static Planeta operator ++(Planeta p)
        {
            p.numSat++;
            return p;
        }

        public static Planeta operator --(Planeta p)
        {
            if (p.numSat <= 0)
            {
                Console.WriteLine("El numero de satelites no se puede decrementar");
            }
            else
            {
                p.numSat--;
            }
            return p;
        }

    }
}
