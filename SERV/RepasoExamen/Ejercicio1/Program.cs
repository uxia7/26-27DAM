// Uxía Pino Figueras

using System;
using System.Threading;

namespace Ejercicio1
{
    internal class Program
    {
        static int NCebollas = 0;
        static int NPatatas = 0;
        static int NTortillas = 0;

        static bool running = true;

        static readonly object l = new object();

        static Random g = new Random();

        static void Tortilla()
        {
            while (running)
            {
                lock (l)
                {
                    if (running)
                    {
                        if (NCebollas >= 5 && NPatatas >= 5)
                        {
                            NCebollas -= 5;
                            NPatatas -= 5;
                            NTortillas++;

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Tortillas:{NTortillas,3}      Cebollas:{NCebollas,3}      Patatas:{NPatatas,3}");
                            Console.ResetColor();

                            if (NTortillas >= 10)
                            {
                                running = false;
                            }
                        }
                    }
                }
            }
        }

        static void Ingrediente(string nombre)
        {
            while (running)
            {
                lock (l)
                {
                    if (running)
                    {
                        if (nombre == "Cebolla")
                        {
                            NCebollas++;

                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"Cebollas: {NCebollas}");
                            Console.ResetColor();
                        }
                        else
                        {
                            NPatatas++;

                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine($"Patatas: {NPatatas}");
                            Console.ResetColor();
                        }
                    }
                }

                if (g.Next(2) == 0)
                {
                    Thread.Sleep(50);
                }
            }
        }

        static void Main(string[] args)
        {
            Thread hiloCebollas = new Thread(() => Ingrediente("Cebolla"));
            Thread hiloPatatas = new Thread(() => Ingrediente("Patata"));
            Thread hiloTortillas = new Thread(Tortilla);

            hiloCebollas.Start();
            hiloPatatas.Start();
            hiloTortillas.Start();

            hiloCebollas.Join();
            hiloPatatas.Join();
            hiloTortillas.Join();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine($"Cebollas sobrantes: {NCebollas}");
            Console.WriteLine($"Patatas sobrantes: {NPatatas}");
            Console.ResetColor();
        }
    }
}