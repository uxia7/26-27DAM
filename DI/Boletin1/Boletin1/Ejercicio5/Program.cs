#define PRUEBA
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Program
    {

        public bool factorial(ref int result)
        {//no puede ser out porque esta funcion tiene que devolver bool y si fuera out
            //tendria que devolver un int

            //guardo el valor del resultado que se me pasa como parametro y poder gestionarlo
            //ya que luego reestablezco el valor del parametro por referencia
            int num = result;
            if (num < 0 || num > 10)
            {
                return false;
            }
            else
            {
                result = 1;
                for (int i = 1; i <= num; i++)
                {
                    result *= i;
                }
                return true;
            }
        }

        public void dibujarPosi(int? noAsteriscos = 10)
        {//los parametros opcionales son aquellos que se ponen pero no hay que definirlos al llamar a dicha funcion
            //yo establezco el valor y lo uso o en la funcion
            Random rand = new Random();
            //int filas = 10;
            //int columnas = 20;
            //int[,] matriz = new int[10,20];


            //Console.SetCursorPosition(columnas, filas)
            //if (noAsteriscos == null)
            //{
            //es solo necesario el for
            //porque aunque sea un parametro opcional y ponga = 10
            //si se le pasa un valor, el = 10 como que se anula y se coge el valor 
            for (int i = 0; i < noAsteriscos; i++) //matriz.GetLength(0)
            {

                int aux1Filas = rand.Next(1, 11);
                int aux2Columns = rand.Next(1, 21);
                Console.SetCursorPosition(aux1Filas, aux2Columns);
                Console.Write("*");
            }
            //}
            //else
            //{
            //    for (int i = 0; i <= cantidadAteriscos; i++) //matriz.GetLength(0)
            //    {
            //        int aux1Filas = rand.Next(1, 11);
            //        int aux2Columns = rand.Next(1, 21);
            //        Console.SetCursorPosition(aux1Filas, aux2Columns);
            //        Console.Write("*");
            //    }
            //}
        }
        static void Main(string[] args)
        {
#if PRUEBA
            Program pg = new Program();
            int resultado = 9;
            //siempre tengo que inicializarla
            //la declaracion tiene que ir fuera de la variable no dentro de la llamada de la funcion
            //bool result = pg.factorial(ref resultado);
            bool bandera = pg.factorial(ref resultado);
            //while(!bandera)
            //{

            if (bandera)
            {
                Console.WriteLine("Tu resultado es: " + resultado);
            }
            else
            {
                Console.WriteLine("Error, metiste el numero fuera del rango establecido, vuelve a intentarlo");

            }
            //}
#else 
            Program pg = new Program();
            pg.dibujarPosi(12);
#endif
        }
    }
}
