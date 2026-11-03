using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Ejercicio7
{
    abstract class Astro
    {
        private string nombre;

        public string Nombre//Leer bien enunciado
        {
            set
            {
                //tengo que guardarlo en mayus
                this.nombre = value.ToUpper();
            }

            get
            {
                //y tengo que devolver el nombre entre comillas
                return "\"" + nombre + "\"";
            }
        }

        private double radio;

        public double Radio
        {
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    this.radio = value;
                }
            }

            get
            {
                return radio;
            }
        }

        public Astro(string nombre, double radio)
        {
            Nombre = nombre;
            Radio = radio;
        }

        public Astro() : this("Tierra", 6378)
        {

        }

        public override bool Equals(object obj)
        {
            //if(((Astro)obj).Nombre == this.Nombre && (obj.GetType() == typeof(string) && ((string)obj) == this.Nombre))
            //{
            //    return true;
            //} else
            //{
            //    return false;
            //}

            //IMPORTANCIA PARA COMPROBAR NULOS
            /* obj != null
             * esta sentencia es fundamental tenerla en cuenta
             * esto se debe a que en caso de que el objeto sea nulo
             * la condicion ni se cumple y se rompe ahi
             * al poner esta condicion chequeas esa parte tambien
             */

            //ANTES DE HACER LA COMPARACION DE NOMBRES
            //HAY QUE COMPROBAR SI EL OBJETO ES DE TIPO ASTRO
            /*(obj.GetType() == typeof(Astro))
             * llamamos al objeto y cogemos el tipo de dato que es
             * en caso de que ese tipo sea un Astro
             * esta condicion se cumple
             */

            //DOS ASTROS SON IGUALES SI SON IGUALES SUS NOMBRES
            /*((Astro)obj).Nombre == this.Nombre
             * en esta parte de la condicion lo que estamos diciendo:
             * llamamos al nombre del object, porque como hemos visto 
             * primero se realiza la operacion del . y luego se castea
             * luego de hacer ese lado del ==
             * cogemos el nombre de la clase en la que estamos que es de la clase Astro
             * con lo cual no dará ningun problema porque ya estamos en esa clase que comparamos
             */

            //SI EL OBJETO ES STRING
            /* obj.GetType() == typeof(string)
             * cogemos el tipo de dato del objeto 
             * lo igualamos para saber si es de tipo string o no
             * en caso de que sea de tipo string, esta condicion se cumple
             */

            //SI COINDICE CON EL NOMBRE TAMBIEN DEVUELVE TRUE
            /* (string)obj == this.Nombre
             * al haber comprobado que es de tipo string podemos castearlo
             * una vez casteado como es una cadena
             * comparamos dos cadenas, para saber si son exactamente iguales
             * si objeto casteado a cadena es exactamente igual al nombre de esta clase
             * entonces la condicion se cumples
             */

            //RECOMENDACION FUTURO, en este caso es mas recomendable que usemos dos if
            //sentencia muy larga y con complejidad, por diverso uso de cosas
            //return (obj!=null&&(obj.GetType() == typeof(Astro) && ((Astro)obj).Nombre == this.Nombre) || (obj.GetType() == typeof(string) && (string)obj == this.Nombre));
            if (obj != null)
            {
                //EL IS Y PORQUE ES BUENO SI LA NECESITAMOS PARA TENER EN CUENTA LAS CLASES HIJAS
                /*obj.GetType() == typeof(Astro)
                 * esta condicion esta muy bien
                 * pero en caso de necesitar comparar que sea un tipo de clase hija
                 * no sirve porque GetType() == typeof() solo te permite que sean de ese tipo
                 * tal cual y solo de ese tipo, sin contar a las hijas
                 * para eso tenemos el IS
                 * IS
                 * nos permite que en este tipo de comparaciones de clase tambien permita a sus clases hijas
                 * por ejemplo si usamos el Equals con planeta, entrara en la sobrecarga
                 * y gracias al IS la condicion se cumplira aunque usemos la clse hija
                 */
                if (obj is Astro && ((Astro)obj).Nombre == this.Nombre)
                {
                    return true;
                }
                else if (obj.GetType() == typeof(string) && (string)obj == this.Nombre)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

    }
}

