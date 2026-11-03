#define ELECCION 
//no llevan ;
//se ponen al principio del todo

using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer5
{

    internal class Program
    {

        static bool Factorial(int num, ref int resultado)
        { //las funciones tienen que ir obligatoriamente dentro de este apartado, porque namespace es lo mismo que package con lo cual no puede ir debajo de allí
            if (num < 0 || num > 10)
            {
                return false;
            }
            else
            {
                resultado = 1;
                for (int i = 1; i <= num; i++)
                {
                    resultado = resultado * i;
                }
                return true;
            }
        }

        //los parametros opcionales en c# son aquellos que se ponen en los parametros y que son String nombre = "invitado"
        static void Asteriscos (int cantidadAste = 10)
        {
            Random rand = new Random();

            for (int i = 0; i < cantidadAste; i++)
            {
                //porque son posiciones aleatorias entre (1 y 10) y (1 y 20), con lo cual, como usamos Next tenemos que subir 1 al maximo para que vaya hasta el que queremos ya que va uno menos
                int filas = rand.Next(1, 11);
                int columnas = rand.Next(1, 21);

                Console.SetCursorPosition(filas,columnas);
                Console.Write(i);
            }
        }

        static void Main(string[] args)
        {
#if ELECCION
            //los parametros por referencia ojo! tienen que ser variables
            int resultado = 7;
            int numero;
            Console.WriteLine("Dime un numero para hacer su factorial: ");
            numero = Convert.ToInt32(Console.ReadLine());
            Factorial(numero, ref resultado);
            Console.WriteLine(resultado);

#else
            int cantidad;
            Console.WriteLine("Dime una cantidad de asteriscos: ");
            cantidad = Convert.ToInt32(Console.ReadLine());
            Asteriscos(cantidad);
#endif

            Console.WriteLine("HOLA");
            Console.ReadLine();
        }
    }
}
