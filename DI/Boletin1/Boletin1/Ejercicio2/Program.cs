 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        public static int transformacion(string lectura)
        {
            if(int.TryParse(lectura, out int numero))
            {
                return numero;
            } else
            {
                return 0;
            }
        }

        public static double transformacion2(string lectura)
        {
            if (double.TryParse(lectura, out double numero))
            {
                return numero;
            }
            else
            {
                return 0;
            }
        }
        /*
         * pida al usuario el nombre (string), la edad (int) y el peso (double). Debe mostrar en un único WriteLine y sin 
         * usa concatenación la siguiente información: 
         * • En la primera linea: el nombre ocupando 12 caracteres, la edad ocupando 4. 
         * • En la segunda línea un tabulador (carácter de escap correspondiente) y 
         * a continuación el peso ocupando 5 caracteres y con sólo 1 decimal. 
         * • En la tercera línea Escribirá de nuevo el nombre entre comillas y a continuación la edad entre barras (\).
         */
        static void Main(string[] args)
        {
            string nombre;
            int edad;
            double peso;


            Console.WriteLine("Dime un nombre");
            nombre = Console.ReadLine();

            Console.WriteLine("Dime un edad");
            edad = transformacion(Console.ReadLine());

            //while(true)
            //{
            //    Console.WriteLine("Dime un edad");
            //    edad = transformacion(Console.ReadLine());
            //    if (edad != 0)
            //    {
            //        break;
            //    }
            //    Console.WriteLine("Dato Incorrecto, intentalo de nuevo");
            //}

            Console.WriteLine("Dime un edad");
            peso = transformacion2(Console.ReadLine());


            Console.WriteLine("Nombre:{0,12} Edad:{1,4}\n\tPeso:{2,5:F1}\nNombre:\"{0}\" Edad:\\{1}\\", nombre, edad, peso);
        }
    }
}
