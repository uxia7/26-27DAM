using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        //LS:
        //SIN COMANDOS Y CON COMANDOS
        //public static void ls()
        //{

        //}
        public static void ls(string ruta)//TODO excep. Tsmaño archivos
        {
            if (Directory.Exists(ruta))
            {
                Console.WriteLine("El directorio que me diste existe");

                string[] subdirectorios = Directory.GetDirectories(ruta);
                string[] archivos = Directory.GetFiles(ruta);
                DirectoryInfo di;
                FileInfo fi;

                for (int i = 0; i < subdirectorios.Length; i++)
                {
                    di = new DirectoryInfo(subdirectorios[i]);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(di.Name);
                    Console.ResetColor();
                }

                for (int i = 0; i < archivos.Length; i++)
                {
                    fi = new FileInfo(archivos[i]);
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine(fi.Name);
                    Console.ResetColor();
                }
            }
            else
            {
                Console.Error.WriteLine("El directorio no existe");
            }
        }



        public static void cat(string ruta, int contadorLineas)
        {

            try
            {
                if (contadorLineas == 0)
                {
                    using (StreamReader sr = new StreamReader(ruta))
                    {
                        Console.Write(sr.ReadToEnd());
                    }
                }
                else
                {
                    int cont = 0;

                    using (StreamReader sr = new StreamReader(ruta))
                    {
                        string linea = sr.ReadLine();

                        while (linea != null && cont < contadorLineas)
                        {
                            Console.WriteLine(linea);
                            cont++;
                            linea = sr.ReadLine();
                        }
                    }
                }
            }
            catch (IOException e)//Unautorized
            {
                Console.Error.WriteLine("Problema al leer los archivos" + e.Message);
            }
        }



        public static void newFile(bool bandera, string ruta, string texto)
        {

            try
            {
                if (bandera)
                {
                    using (StreamWriter sw = new StreamWriter(ruta, true))
                    {
                        sw.WriteLine(texto);
                    }
                }
                else
                {
                    //por defecto va a false, no hace falta ponerlo
                    using (StreamWriter sw = new StreamWriter(ruta))
                    {
                        sw.WriteLine(texto);
                    }
                }

                Console.WriteLine("Fichero escrito correctamente");
            }
            catch (IOException e)//unathired exception
            {
                Console.WriteLine("Error al escribir el fichero");
            }
        }

        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Debe indicar un comando");
                return;
            }

            string comando = args[0];


            switch (comando.ToLower())
            {
                case "ls":

                    string ruta = "";

                    if (args.Length == 1)
                    {
                        ruta = Directory.GetCurrentDirectory();
                    }
                    else if (args.Length == 2)
                    {
                        ruta = args[1];
                    }
                    else
                    {
                        Console.WriteLine("Error con los parametros del comando");
                        return;
                    }

                    ls(ruta);

                    break;

                case "cat":
                    string ruta2 = "";
                    int contadorLineas = 0;

                    if (args.Length == 2)
                    {
                        ruta2 = args[1];
                    }
                    else if (args.Length == 3)
                    {
                        if (args[1].Length >= 3 && args[1][0] == '-' && args[1][1] == 'n')
                        {
                            string contador = args[1].Substring(2);

                            if (int.TryParse(contador, out contadorLineas))
                            {
                                Console.WriteLine("El numero de lineas se parseo correctamente");
                            }
                            else
                            {
                                Console.WriteLine("El numero de lineas no se pudo guardar");
                                return;
                            }

                            ruta2 = args[2];
                        }
                        else
                        {
                            Console.WriteLine("El parametro de lector de lineas (-n) es incorrecto");
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Parametros incorrectos, ruta vacia");
                        return;
                    }

                    cat(ruta2, contadorLineas);

                    break;

                case "newfile":

                    string ruta3 = "";
                    string texto = "";
                    bool bandera = true;

                    if (args.Length == 3)
                    {
                        ruta3 = args[1];
                        texto = args[2];
                        bandera = false;
                    }
                    else if (args.Length == 4)
                    {
                        if (args[1] == "-a")
                        {
                            ruta3 = args[2];
                            texto = args[3];
                            bandera = true;

                        }
                        else
                        {
                            Console.WriteLine("Comando primer argumento, -a invalido");
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Agumentos del comando invalidos");
                        return;
                    }

                    newFile(bandera, ruta3, texto);

                    break;

                case "salir":
                    Console.WriteLine("Saliendo");
                    break;


                default:
                    Console.WriteLine("Comando no valido");
                    break;
            }


        }
    }
}
