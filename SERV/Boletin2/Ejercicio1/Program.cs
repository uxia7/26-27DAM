using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        /*
         * todo se pone como static porque como el hilo esta dentro del main y este es estatico
         * con lo cual todo lo que vaya relacionado con los hilos, sus funciones o las variables 
         * que vayan en las funciones, TODO tiene que ser estatico, a menos que se haga en formato 
         * de lambda que enton al no usar cosas externas, pues, no hace falta, porque esta todo dentro de la propia clase ????
         * 
         * // Como estamos trabajando desde Main
            // y no hemos creado ninguna instancia,
            // usamos métodos estáticos.
         */
        public static int varCarrera = 0;

        public static bool terminado = false;

        //el lock necesita un objeto llave para cerrar su puerta y hacerle saber al otro hilo que ya esta cogido
        public static object candado = new object();
        static void Main(string[] args)
        {

            //al Thread hay que pasarle algo siempre, ya sea un delegado o una lambda
            /*
             * para saber que usar, osea si es mejor una lambda o una funcion, 
             * hay que pensar en la complejidad del codigo o de lo que se va a realizar
             * por ejemplo:
             * lambda con cosas puntuales o codigo muy directo, una operacion directa, sin while ni lock
             * o mostrar por pantalla el hilo
             */
            Thread hilo1Suma = new Thread(aumentar);
            Thread hilo2Decrementar = new Thread(decrementar);

            hilo1Suma.Start();
            hilo2Decrementar.Start();

            hilo1Suma.Join();
            hilo2Decrementar.Join();
        }

        //para pasar las funciones como delegados, tienen que ser funciones estaticas
        public static void aumentar()
        {

            //while es mejor dejarlo con una boleana antes que hacer la operacion de comprobacion, justo antes de coger la llave
            //while(varCarrera < 500)
            //es mejor hacer una variable booleana para saber quien de los dos acabo y esa comprobacion hacerla cuando ya se cogio la llave
            while (!terminado)
            {
                lock (candado)
                {
                    if (terminado)
                    {
                        return;
                    }

                    if (varCarrera < 500)
                    {

                        //System.ForeColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Cyan;

                        varCarrera += 1;

                        Console.WriteLine("Hilo 1 (aumentar): " + varCarrera);
                    }

                    if (varCarrera == 500)
                    {
                        terminado = true;
                    }
                }
            }

            //Console.ForegroundColor = ConsoleColor.White;
            //para resetear el color hay esta funcion especifica
            Console.ResetColor();
        }

        public static void decrementar()
        {
            while (!terminado)
            {
                lock (candado)
                {
                    if(terminado)
                    {
                        return;
                    }
                    if (varCarrera > -500)
                    {

                        Console.ForegroundColor = ConsoleColor.DarkMagenta;

                        varCarrera -= 1;

                        Console.WriteLine("Hilo 2 (decrementar): " + varCarrera);
                    }

                    if (varCarrera == -500)
                    {
                        terminado = true;
                    }
                }

            }

            Console.ResetColor();
        }
    }
}
