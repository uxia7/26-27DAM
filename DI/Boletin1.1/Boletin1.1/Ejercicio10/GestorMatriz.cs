using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    internal class GestorMatriz
    {
        public int[,] matriz;

        public GestorMatriz(int fila, int columna)
        {
            Random rand = new Random();
            matriz = new int[fila, columna];

            /* matriz.GetLength()
             * en esta funcion lo que se le pasa como parametro
             * son las dimensiones basicamente
             * 0 representa filas
             * 1 representa columnas
             * y si hubiera mas numero 2 y asi representaria las siguientes dimensiones de la matriz
             */
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = rand.Next(-5, 21);
                }
            }
        }

        public GestorMatriz() : this(3, 4) { }

        public (int, bool) sumaFila(int indFila)
        {
            int resultado = 0;
            if (indFila >= 0 && indFila < matriz.GetLength(0))
            {
                //doble bucle innecesario porque sometido a mal codigo 
               // for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    for (int j = 0; j < matriz.GetLength(1); j++)
                    {
                      //  if (i == indFila)
                        {
                            resultado += matriz[indFila, j];
                        }
                    }
                }

                return (resultado, true);
            }
            else
            {
                return (0, false);
            }
        }


        public bool sumaCols(int indCol, out int resultado)//TODO revisar
        {
            resultado = 0;
            if (indCol >= 0 && indCol < matriz.GetLength(1))
            {
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    for (int j = 0; j < matriz.GetLength(1); j++)
                    {
                        if (j == indCol)
                        {
                            resultado += matriz[i, j];
                        }
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public double[,] sumaMatriz(object obj)
        {
            //MEJOR IS QUE LA CONDICION DE TIPOS
            // ESTA CONDICION: obj is int[,] || obj is double[,] || (obj.GetType() == typeof(GestorMatriz) && ((Array)obj).Length == matriz.Length)
            //INCORRECTA Y MUY TEDIOSA
            double[,] resultado = new double[matriz.GetLength(0), matriz.GetLength(1)];
            if (obj is int[,] mEnt)
            {

                if (mEnt.GetLength(0) == matriz.GetLength(0) && mEnt.GetLength(1) == matriz.GetLength(1))
                {
                    for (int i = 0; i < matriz.GetLength(0); i++)
                    {
                        for (int j = 0; j < matriz.GetLength(1); j++)
                        {
                            resultado[i, j] = matriz[i, j] + mEnt[i, j];
                        }
                    }
                }
                else
                {
                    throw new MatrizException("Matriz no valida");
                }

                return resultado;

            }
            else if (obj is double[,] mDeci)
            {
                if (mDeci.GetLength(0) == matriz.GetLength(0) && mDeci.GetLength(1) == matriz.GetLength(1))
                {
                    for (int i = 0; i < matriz.GetLength(0); i++)
                    {
                        for (int j = 0; j < matriz.GetLength(1); j++)
                        {
                            resultado[i, j] = matriz[i, j] + mDeci[i, j];
                        }
                    }

                }
                else
                {
                    throw new MatrizException("Matriz no valida");
                }
                return resultado;
            }
            else if (obj is GestorMatriz gm)
            {
                if (gm.matriz.GetLength(0) == matriz.GetLength(0) && gm.matriz.GetLength(1) == matriz.GetLength(1))
                {
                    for (int i = 0; i < matriz.GetLength(0); i++)
                    {
                        for (int j = 0; j < matriz.GetLength(1); j++)
                        {
                            resultado[i, j] = matriz[i, j] + gm.matriz[i, j];
                        }
                    }

                }
                else
                {
                    throw new MatrizException("Matriz no valida");
                }
                return resultado;
            }
            else
            {
                throw new MatrizException("Matriz no valida");
            }
        }

        public double[] medias(bool filas)
        {

            if (filas)
            {
                double[] resultFilas = new double[matriz.GetLength(0)];
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    (int sumaFilas, bool bandera) = sumaFila(i);
                    resultFilas[i] = (double)sumaFilas / matriz.GetLength(1);
                }
                return resultFilas;
            }
            else
            {
                double[] resultCols = new double[matriz.GetLength(1)];

                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    int resultado = 0;
                    bool bandera = sumaCols(j, out resultado);

                    resultCols[j] = (double)resultado / matriz.GetLength(0);
                }
                return resultCols;
            }
        }

        //TENGO QUE DECLARAR EL TIPO GENERICO AL LADO DEL NOMBRE DE LA FUNCION
        //SI NO, NO LO RECONOCE Y NO ME HACE LOS GENERICOS
        /*
          * los genericos se hacen con una T y con los <> eso para ponerlo delante 
          * de una funcion y luego tipo generico en si es solo poniendo una T en donde 
          * iria el tipo de dato y ya esta
         */
        public static void mostrarMatriz<T>(T[,] matriz)
        {
            Console.WriteLine($"{"",5}");
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write($"{(char)('A' + j),5}");
            }
            Console.WriteLine();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                Console.Write($"{i + 1,5}");
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"{matriz[i, j],5}");
                }
                Console.WriteLine();
            }
        }
    }
}
