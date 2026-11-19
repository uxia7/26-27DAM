// Uxía Pino Figueras

using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Backup
    {
        private List<string> log = new List<string>();

        public List<string> Log
        {
            get { return log; }
        }

        public FileInfo[] buscaArchivos(string directorio, string[] extensiones)
        {
            if (!Directory.Exists(directorio))
            {
                return null;
            }

            DirectoryInfo d = new DirectoryInfo(directorio);

            FileInfo[] todos = d.GetFiles();

            FileInfo[] resultado = Array.FindAll(
                todos,
                fichero => Array.Exists(extensiones,
                ext => fichero.Extension == ext)
            );

            return resultado;
        }

        public bool copiaArchivo(FileInfo fichero, string destino)
        {
            try
            {
                string rutaDestino = destino + "\\" + fichero.Name;

                using (StreamReader sr = new StreamReader(fichero.FullName))
                {
                    using (StreamWriter sw = new StreamWriter(rutaDestino))
                    {
                        string linea;
                        int contLineas = 0;

                        linea = sr.ReadLine();

                        while (linea != null)
                        {
                            sw.WriteLine(linea);

                            contLineas++;

                            if (contLineas % 10 == 0)
                            {
                                string entrada =
                                    $"{fichero.Name,-20}" +
                                    $"{fichero.Length,10}" +
                                    $"{contLineas,5}";

                                log.Add(entrada);

                                Console.WriteLine(entrada);
                            }

                            linea = sr.ReadLine();
                        }
                    }
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public int buscaYCopia(string origen, string destino, string[] extensiones)
        {
            int copiados = 0;

            FileInfo[] archivos = buscaArchivos(origen, extensiones);

            if (archivos != null)
            {
                Array.ForEach(
                    archivos,
                    fichero =>
                    {
                        if (copiaArchivo(fichero, destino))
                        {
                            copiados++;
                        }
                    }
                );
            }

            return copiados;
        }

        public async Task<int> InitBackup(string directorioOrigen)
        {
            string destino =
                Environment.GetEnvironmentVariable("USERPROFILE")
                + "\\backup";

            if (!Directory.Exists(destino))
            {
                Directory.CreateDirectory(destino);
            }

            Task<int> task1 = Task.Run(() =>
                buscaYCopia(
                    directorioOrigen,
                    destino,
                    new string[] { ".txt", ".md", ".json" }
                )
            );

            Task<int> task2 = Task.Run(() =>
                buscaYCopia(
                    directorioOrigen,
                    destino,
                    new string[] { ".java", ".cs", ".py" }
                )
            );

            int[] resultados = await Task.WhenAll(task1, task2);

            return resultados[0] + resultados[1];
        }
    }

    internal class Program
    {
        static async Task Main(string[] args)
        {
            Backup b = new Backup();

            string origen =
                Environment.GetEnvironmentVariable("HOMEPATH")
                + "\\examen";

            int total = await b.InitBackup(origen);

            Console.WriteLine($"Archivos copiados: {total}");

            string linea100 = Array.Find(
                b.Log.ToArray(),
                item => item.Contains("100")
            );

            Console.WriteLine(linea100);
        }
    }
}