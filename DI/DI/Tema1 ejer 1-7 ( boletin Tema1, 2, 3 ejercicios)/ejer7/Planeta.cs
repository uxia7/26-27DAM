using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ejer7
{
    public class Planeta : Astro, ITerraformable
    { //los constructores de la clase padre tienen que ser publicos, osea, hay que ponerles public, si no en c# se condirea protected o private y da errores al heredar
        //luego si Astro es public y aqui solo tengo lo del internal class, hay que cambiarlo a public class para que se vean mutuamente y que todo vaya bien
        //es mejor poner public
        private bool gaseoso; //{ set; get; }
        public bool Gaseoso
        {
            set
            {
                gaseoso = value;
            }

            get
            {
                return gaseoso;
            }
        }

        private int numSatelites;
        //aunque sean publicas, si hay comprobacion tenemos que crear una privada para que podamos hacer la asignacion correctamente en el setter
        public int NumSatelites//TODO 0 si value es neg
        {
            set
            {
                if (value > 0)
                {
                    numSatelites = value;
                }
                else
                {
                    numSatelites = 0;
                }
            }

            get
            {
                return numSatelites;
            }
        }

        public Planeta(bool gaseoso, int numSatelites, String nombre, double radio) : base(nombre, radio)
        {
            this.Gaseoso = gaseoso;
            this.NumSatelites = numSatelites;

        }

        public Planeta() : this(false, 0, "", 1)
        {

        }

        public bool esHabitable()
        {
            return (!gaseoso && (Radio <= 2000 && Radio >= 8000));
            //tambien hay que acostumbrarse a que cuando tenemos booleanos no hace falta lo de gaseoso == false, porque es una mala practica, hay que poner directamente !gaseoso porque es el false para los bools directo
            //if(gaseoso = false && (Radio <= 2000 && Radio >= 8000))
            //{
            //    return true;
            //} else
            //{
            //    return false;
            //}
        }

        public override String ToString()
        {
            return ($"Nombre planeta: {Nombre,10}\nCantidad de satelites: {numSatelites,4}\nRadio: {Radio:.00}");
        }

        //sobrecarga de operadores, tema2 pg 13
        //public static Planeta ++()
        //{

        //}
        //la sobrecarga de operadores es basicamente crear una funcion que te permite sumar los tipos de tu clase sin necesidad de hacer p.x + p1.x y asi, por ejemplo
        public static Planeta operator ++(Planeta p)
        {
            p.NumSatelites++;
            return p;
            //como al sumar no puede bajar de 0, no hace falta hacer comprobacion porque aumentara siempre
        }

        public static Planeta operator --(Planeta p)
        {
            if (p.NumSatelites > 0)
            {
                p.NumSatelites--;
                return p;
            }
            else
            {
                //Console.WriteLine("No se puede decrementar el numero de satelites porque ya llegaste a 0 y un planeta no puede tener -1 satelite");
                throw new ArgumentOutOfRangeException("No se pueden decrementar el numero de satelites, ya llegaste al numero 0. No puede haber una cantidad de satelites negativos");
                //return p;
            }
        }


    }
}
