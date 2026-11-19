using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        public static bool terminado = false;
        public static object candado = new object();

        public static int[] posiciones;

        public static int ganador;
        static void Main(string[] args)
        {
            Thread[] hilos = new Thread[5];

            //asi sabemos que el caballo 1 esta en la posicion 0 y asi
            posiciones = new int[hilos.Length];

            for (int i = 0; i < hilos.Length; i++)
            {
                Console.WriteLine($"Caballo {i + 1}:");
            }

            for (int i = 0; i < hilos.Length; i++)
            {
                hilos[i] = new Thread(carrera);
                //para indicar cual es el caballo que empezo, si el 1 o asi
                hilos[i].Start(i);
            }

            for (int i = 0; i < hilos.Length; i++)
            {
                //como se indica de que SE ESPERA a que cada uno acabe, tenemos que usar el Join,
                //que es el que indica quue se espere a que todos acaben para finalizar el programa esto incluye el Main
                hilos[i].Join();

                //ponemos el Join dentro de otro for diferente porque no todos corren a la vez
                //asi todos corren y el Main espera a que todo acabe correctamente
            }

            //una vez que situo este bloque de codigo, automaticamente ya se ajusta solo lo del main y que se coma los caballos
            Console.SetCursorPosition(0, 7);

            Console.WriteLine($"Ganador: Caballo {ganador + 1}");
        }

        //los parametros que se le pasan a Thread tienen que ser de tipo object SIEMPRE
        public static void carrera(object numCaballo)
        {
            int posicionCaballo = (int)numCaballo;
            //lo que queremos hacer solo una vez por hilo lo ponemos fuera del lock
            Random rand = new Random();
            while (!terminado)
            {
                lock (candado)
                {
                    if (terminado)
                    {
                        return;
                    }

                    int avance = rand.Next(1, 11);

                    //como cada caballo necesita su fila fija,
                    //tenemos que usar el setCursorPosition para darle esa posicion fija a cada caballo
                    //Console.SetCursorPosition(0, 0);
                    //Console.WriteLine("Caballo 1:" + new string('*', posiciones[posicionCaballo]));

                    //Console.SetCursorPosition(0, 1);
                    //Console.WriteLine("Caballo 2:" + new string('*', posiciones[posicionCaballo]));

                    //Console.SetCursorPosition(0, 2);
                    //Console.WriteLine("Caballo 3:" + new string('*', posiciones[posicionCaballo]));

                    //Console.SetCursorPosition(0, 3);
                    //Console.WriteLine("Caballo 4:" + new string('*', posiciones[posicionCaballo]));

                    //Console.SetCursorPosition(0, 4);
                    //Console.WriteLine("Caballo 5:" + new string('*', posiciones[posicionCaballo]));

                    posiciones[posicionCaballo] += avance;

                    //aqui es donde mostramos esa cantidad de asteriscos de cada caballo cuando avanzan
                    Console.SetCursorPosition(0, posicionCaballo);

                    Console.Write($"Caballo {posicionCaballo + 1}: " + new string('*', posiciones[posicionCaballo]));


                    if (!terminado && posiciones[posicionCaballo] >= 50)
                    {
                        terminado = true;
                        ganador = posicionCaballo;
                    }
                }

                //uhna vez que acaba de correr, se pone ese hilo a dormir un tiempo aleatorio
                //tambien nos ayuda a ver la animacion con mas calma
                //el Sleep tiene que ejecutarse fuera del lock porque mientras ese hilo duerme
                //los otros caballos estan esperando a que ese se despierte para continuar
                Thread.Sleep(rand.Next(100, 500));
            }
        }
    }
}
