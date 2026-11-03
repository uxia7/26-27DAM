using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CREO LAS MATRICESS
            GestorMatriz gm1 = new GestorMatriz();
            GestorMatriz gm2 = new GestorMatriz();

            //MUESRO CADA UNA
            Console.WriteLine("Primer matri");
            GestorMatriz.mostrarMatriz(gm1.matriz);

            Console.WriteLine("Segunda matriz");
            GestorMatriz.mostrarMatriz(gm2.matriz);

            //SUMA FILAAs
            Console.WriteLine("Suma de una fila");

            (int sumaFila, bool okFila) = gm1.sumaFila(1);

            if (okFila)
            {
                Console.WriteLine($"Suma fila 1 = {sumaFila}");
            }
            else
            {
                Console.WriteLine("Fila incorrecta");
            }

            //SUMA COLUMNSSS
            Console.WriteLine("Suma de una columna");

            int sumaCol;
            bool okCol = gm1.sumaCols(2, out sumaCol);

            if (okCol)
            {
                Console.WriteLine($"Suma columna 2 = {sumaCol}");
            }
            else
            {
                Console.WriteLine("Columna incorrecta");
            }

            //MEDIA FILAAAS 
            Console.WriteLine("Media de las dilas");

            double[] mediasFilas = gm1.medias(true);

            for (int i = 0; i < mediasFilas.Length; i++)
            {
                Console.WriteLine($"Fila {i}: {mediasFilas[i]}");
            }

            //MEDIA COLIMSSS
            Console.WriteLine("Mediac columnas");

            double[] mediasCols = gm1.medias(false);

            for (int i = 0; i < mediasCols.Length; i++)
            {
                Console.WriteLine($"Columna {i}: {mediasCols[i]}");
            }

            //SUMA MATRIZ + GESTOR
            Console.WriteLine("Suma matrices + gestor matriz");

            try
            {
                double[,] resultado = gm1.sumaMatriz(gm2);

                GestorMatriz.mostrarMatriz(resultado);
            }
            catch (MatrizException ex)
            {
                Console.WriteLine(ex.Message);
            }

            //INT
            Console.WriteLine("Suma con int[,]");

            //int[,] mEntera =
            //{
            //    {1,2,3,4},
            //    {5,6,7,8},
            //    {9,10,11,12}
            //};
            int[,] mEntera = new int[5,7];
            for (int i = 0; i < mEntera.GetLength(0); i++)
            {
                for(int j = 0; j < mEntera.GetLength(1); j++)
                {
                    mEntera[i, j] = 2;
                }
            }

            try
            {
                double[,] resultado = gm1.sumaMatriz(mEntera);

                GestorMatriz.mostrarMatriz(resultado);
            }
            catch (MatrizException ex)
            {
                Console.WriteLine(ex.Message);
            }

            //DOUBLE
            Console.WriteLine("Suam con double[,]");

            double[,] mDouble =
            {
                {1.5,2.5,3.5,4.5},
                {5.5,6.5,7.5,8.5},
                {9.5,10.5,11.5,12.5}
            };

            try
            {
                double[,] resultado = gm1.sumaMatriz(mDouble);

                GestorMatriz.mostrarMatriz(resultado);
            }
            catch (MatrizException ex)
            {
                Console.WriteLine(ex.Message);
            }

            //EXCEPCION
            Console.WriteLine("Lanzamiento de la excepcion y trys-catch");

            int[,] matrizIncorrecta =
            {
                {1,2},
                {3,4}
            };

            try
            {
                double[,] resultado = gm1.sumaMatriz(matrizIncorrecta);

                GestorMatriz.mostrarMatriz(resultado);
            }
            catch (MatrizException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
