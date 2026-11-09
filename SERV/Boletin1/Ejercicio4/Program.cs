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
            //TODO revisar archivo
        static void Main(string[] args)
        {
            // Ruta del archivo en la carpeta del usuario
            string ruta = Environment.GetEnvironmentVariable("userprofile") + "\\archivoDelegados.txt";
            // Leemos todas las líneas del archivo
            string[] lineas = File.ReadAllLines(ruta);
            //file es una clase que no necesita instancia para usarse

            // Primera línea que hace ref a los números
            string[] trozos = lineas[0].Split(',');

            int[] numbers = new int[trozos.Length];

            for (int i = 0; i < trozos.Length; i++)
            {
                numbers[i] = int.Parse(trozos[i]);
            }

            // y la segunda que me hace ref a las palabras
            string[] words = lineas[1].Split(',');

            Console.WriteLine("Operaciones con numbers:");

            // saber si hay algún número negativo
            bool hayNegativo = Array.Exists(numbers, x => x < 0);
            Console.WriteLine($"Existe un neg?: {hayNegativo}");

            // mostrar los impares
            int[] impares = Array.FindAll(numbers, x => x % 2 != 0);
            Console.Write("Impares: ");
            Array.ForEach(impares, x => Console.Write(x + " "));

            // posicion del ultimo mayor a 10
            int posMayor10 = Array.FindLastIndex(numbers, x => x > 10);
            Console.WriteLine($"Ultimo mayor que 10 en la pos: {posMayor10}");

            // valor del ultimo pos
            int ultimoPositivo = Array.FindLast(numbers, x => x > 0);
            Console.WriteLine($"Ultimo pos: {ultimoPositivo}");

            // cuantos son pos y divisibles entre 5
            //TODO Count
            int cantidadPosDiv5 = Array.FindAll(numbers, x => x > 0 && x % 5 == 0).Length;
            Console.WriteLine($"Pos y divisibles entre 5: {cantidadPosDiv5}");

            Console.WriteLine("\nOperaciones con words:");

            // primera palabra de más de 4 caracteres
            string primeraLarga = Array.Find(words, w => w.Length > 4);
            Console.WriteLine($"Primera palabra con mas de 4 carac: {primeraLarga}");

            // mostrar todas las palabras en mayúsculas
            string[] mayus = Array.ConvertAll(words, w => w.ToUpper());//TODO innecesario
            Console.Write("Palabras en mayus: ");
            Array.ForEach(mayus, w => Console.Write(w + " "));

            // existe palabra de dos caracteres cuyo segundo sea 'A'
            bool existeDosConA = Array.Exists(words, w => w.Length == 2 && w[1] == 'A');
            Console.WriteLine($"Existe una palabra con dos caracteres y que el segundo sea A?: {existeDosConA}");

            // posición de la primera palabra que empiece por E
            int posEmpiezaE = Array.FindIndex(words, w => w.StartsWith("E"));
            Console.WriteLine($"Primera palabra que empieza por E esta en la pos: {posEmpiezaE}");

        }
    }
}
