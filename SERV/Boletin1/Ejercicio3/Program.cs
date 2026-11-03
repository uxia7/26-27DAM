using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{

    internal class Program
    {

        // 1. Definimos el delegado:
        //    - Recibe un double
        //    - Devuelve un double
        delegate double OperacionDouble(double x);
        static void Main(string[] args)
        {
            // 2. Pedimos el número al usuario
            Console.Write("Introduce un número: ");
            string textoNumero = Console.ReadLine();

            // Intentamos convertir a double
            double numero;
            while (!double.TryParse(textoNumero, out numero))
            {
                Console.Write("Valor no válido. Introduce un número: ");
                textoNumero = Console.ReadLine();
            }

            // 3. Preguntamos si quiere cuadrado o cubo
            Console.Write("Cuadrado (c) o Cubo (b) ");
            string opcion = Console.ReadLine();

            // 4. Declaramos la variable del tipo delegado
            OperacionDouble operacionSeleccionada;

            // 5. Según la opción, asignamos una lambda al delegado
            //    Lambda para el cuadrado: x => x * x
            //    Lambda para el cubo:     x => x * x * x
            if (opcion == "c" || opcion.Equals("cuadrado", StringComparison.OrdinalIgnoreCase))
            {
                operacionSeleccionada = x => x * x;
            }
            else if (opcion == "b" || opcion.Equals("cubo", StringComparison.OrdinalIgnoreCase))
            {
                operacionSeleccionada = x => x * x * x;
            }
            else
            {
                Console.WriteLine("Opción no válida. Se calculará el cuadrado por defecto.");
                operacionSeleccionada = x => x * x;
            }

            // 6. Ejecutamos la variable del tipo delegado
            double resultado = operacionSeleccionada(numero);

            // 7. Mostramos el resultado
            Console.WriteLine($"El resultado es: {resultado}");

            Console.WriteLine("Pulsa una tecla para salir...");
            Console.ReadKey();
        }
    }
}

