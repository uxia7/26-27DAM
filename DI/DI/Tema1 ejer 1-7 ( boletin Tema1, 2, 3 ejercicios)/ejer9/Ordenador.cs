using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ejer9
{
    internal class Ordenador
    {
        private String nombre;
        public String Nombre
        {
            set
            {
                this.nombre = value;
            }

            get
            {
                return this.nombre;
            }
        }

        private int memoriaRam;
        public int MemoriaRam
        {
            set
            {
                this.memoriaRam = value;
            }

            get
            {
                return this.memoriaRam;
            }
        }

        //crear una función estática que compruebe si una IP es válida. Se le pasa como
        //parámetro un string y debe comprobar que consta de cuatro bytes separados por
        //puntos.Si es correcto devuelve true, false en caso contrario.
        public static bool IpValida(String ip)
        {
            String[] ipCompleta = ip.Split('.');
            //split('.') devuelve un array de todos los valores de una cadena que han sido separados por determinado caracter en este caso un punto
            //basicamente lo que va a guardar es: [192, 68, 0, 1] 
            //una ip siempre se va a escribir con puntos, porque es la forma correcta de hacerlo, entonces si no lo separa con puntos
            //habria que decirle algo al usuario para que sepa que lo esta escribiendo mal, esta escribiendolo en un formato que no es el correcto, que seria con puntos
            //entonces en caso de que lo escriba todo junto o separado con espacios, no valadria y lo devolveria como false

            //en caso de que el array que devuelve split no se cumpla
            if (ipCompleta.Length != 4)
            {//en caso de que el tamaño del array sea diferente de 4, devolverá falso porque no está cumpliendo con las partes correctas de una ip
             //que solo debe de tener 4 partes separadas por puntos
                return false;
            }

            //asi es como se hace un foreach en C#
            foreach (String parteIp in ipCompleta)
            {//ponemos un String al recorrer el array porque lo que has guardado dentro es una cadena no numeros
             //porque te lo ha pasado el usuario con console y no haces la conversion cuando te de el numero
             //lo haces en la comproacion para poder usar el split y el tema del array con cada parte de la ip
             //comprobar que cada parte del array es un numero y no hay letras coladas, ya que si lo hay saltará una excepcion a la hora de hacer conversion de tipos
                if (!int.TryParse(parteIp, out int numero))
                {//int numero esta es la declaracion de la variable numero al mismo tiempo que indicas que es la variable de salida que se usará para devolver el numero
                    return false;
                }

                //en este if compruebas que están dentro del rango normal de una ip ya que las ip van desde 0 hasta 255 pero sin contarlos porque son exactamente 255 numeros de ip
                if (numero < 0 || numero > 255)
                {
                    return false;
                }

            }

            return true;
        }

        //ahora hacemos la tabla hash y para hacer eso es sencillo
        //las tablas hash son una colección especial en la cual el índice en lugar de ser numérico es cualquier
        //otra cosa de forma que estas colecciones se componen de pares clave/valor
        //se usa las clase Dictionary o Hashtable como se ve en el ejemplo
        //Dictionary es tipada, y Hashtable es de objects ambas funcionan igual solo que una es mejor que la otra y mas moderna
        //en este caso Dictionary es mejor que Hashtable que es más obsoleta y menos eficaz y segura
        Dictionary<string, Ordenador> red = new Dictionary<string, Ordenador>();


    }
}
