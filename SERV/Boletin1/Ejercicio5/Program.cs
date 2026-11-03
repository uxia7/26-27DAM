using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Program
    {
        // 1. Definimos el delegado
        //    - No recibe parámetros
        //    - No devuelve nada
        delegate void MyDelegate();

        // 2. Función generadora de menús
        static bool MenuGenerator(string[] opciones, MyDelegate[] acciones)
        {
            // Comprobación de parámetros
            if (opciones == null || acciones == null)
                return false;

            if (opciones.Length != acciones.Length)
                return false;

            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("\n=== MENÚ ===");

                // Mostrar opciones
                for (int i = 0; i < opciones.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {opciones[i]}");
                }

                // Última opción: Exit
                Console.WriteLine($"{opciones.Length + 1}. Exit");

                Console.Write("Selecciona una opción: ");
                string texto = Console.ReadLine();

                int seleccion;

                // Validación de número
                if (!int.TryParse(texto, out seleccion))
                {
                    Console.WriteLine("Error: introduce un número válido.");
                    continue;
                }

                // Si selecciona Exit
                if (seleccion == opciones.Length + 1)
                {
                    salir = true;
                    continue;
                }

                // Si está fuera de rango
                if (seleccion < 1 || seleccion > opciones.Length)
                {
                    Console.WriteLine("Opción fuera de rango.");
                    continue;
                }

                // Ejecutar la acción correspondiente
                acciones[seleccion - 1]();
            }

            return true;
        }



        // Funciones de prueba
        static void f1()
        {
            Console.WriteLine("A");
        }

        static void f2()
        {
            Console.WriteLine("B");
        }

        static void f3()
        {
            Console.WriteLine("C");
        }

        static void Main(string[] args)
        {
            MenuGenerator(
                new string[] { "Op1", "Op2", "Op3" },
                new MyDelegate[] { f1, f2, f3 }
            );

            Console.WriteLine("Fin del programa.");
            Console.ReadKey();
        }
    }
}
