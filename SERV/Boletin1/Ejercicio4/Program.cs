using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ruta del archivo en la carpeta del usuario
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
                          + "\\archivoDelegados.txt";

            // Leemos todas las líneas del archivo
            string[] lineas = File.ReadAllLines(ruta);
            //file es una clase que no necesita instancia para usarse

            // Primera línea → números
            int[] numbers = lineas[0]
                            .Split(',')
                            .Select(x => int.Parse(x))
                            .ToArray();

            // Segunda línea → palabras
            string[] words = lineas[1]
                             .Split(',');

            Console.WriteLine("Operaciones con numbers:");

            // 1. Saber si hay algún número negativo
            bool hayNegativo = Array.Exists(numbers, x => x < 0);
            Console.WriteLine($"Negativo?: {hayNegativo}");

            // 2. Mostrar los impares
            int[] impares = Array.FindAll(numbers, x => x % 2 != 0);
            Console.WriteLine("Impares: " + string.Join(", ", impares));

            // 3. Posición del último número mayor que 10
            int posMayor10 = Array.FindLastIndex(numbers, x => x > 10);
            Console.WriteLine($"Ultimo mayor que 10 está en la posición: {posMayor10}");

            // 4. Valor del último positivo
            int ultimoPositivo = Array.FindLast(numbers, x => x > 0);
            Console.WriteLine($"Ultimo positivo: {ultimoPositivo}");

            // 5. Cuántos son positivos y divisibles entre 5
            int cantidadPosDiv5 = Array.FindAll(numbers, x => x > 0 && x % 5 == 0).Length;
            Console.WriteLine($"Positivos y divisibles entre 5: {cantidadPosDiv5}");

            Console.WriteLine("\nOperaciones con words:");

            // 1. Primera palabra de más de 4 caracteres
            string primeraLarga = Array.Find(words, w => w.Length > 4);
            Console.WriteLine($"Primera palabra con más de 4 caracteres: {primeraLarga}");

            // 2. Mostrar todas las palabras en mayúsculas
            string[] mayus = Array.ConvertAll(words, w => w.ToUpper());
            Console.WriteLine("Palabras en mayúsculas: " + string.Join(", ", mayus));

            // 3. ¿Existe palabra de dos caracteres cuyo segundo sea 'A'?
            bool existeDosConA = Array.Exists(words, w => w.Length == 2 && w[1] == 'A');
            Console.WriteLine($"¿Existe palabra de dos caracteres y segundo A?: {existeDosConA}");

            // 4. Posición de la primera palabra que empiece por E
            int posEmpiezaE = Array.FindIndex(words, w => w.StartsWith("E"));
            Console.WriteLine($"Primera palabra que empieza por E está en la posición: {posEmpiezaE}");

            //Console.WriteLine("\nPulsa una tecla para salir...");
            //Console.ReadKey();
        }
    }
}
