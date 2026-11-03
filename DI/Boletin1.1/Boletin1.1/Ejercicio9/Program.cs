using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    internal class Program
    {
        public int enteros(string lectura)
        {
            int resultado;
            while (!int.TryParse(lectura, out resultado))
            {
                Console.WriteLine("No fue posible coger el numero, vuelve a intentarlo (entero)");
                lectura = Console.ReadLine();
            }
            return resultado;
        }

        public int ram(string lectura)
        {
            int resultado;
            while (!int.TryParse(lectura, out resultado) || resultado <= 0)
            {
                Console.WriteLine("No fue posible coger el numero, vuelve a intentarlo (entero, positivo)");
                lectura = Console.ReadLine();
            }
            return resultado;
        }

        public string ip(string lectura)
        {
            while (!Ordenador.comprobacionIp(lectura))
            {
                Console.WriteLine("Error al dar la ip, no es valida, vuelve a intentarlo");
                lectura = Console.ReadLine();
            }
            return lectura;
        }

        static void Main(string[] args)
        {
            Program pg = new Program();

            Dictionary<string, Ordenador> dicOrdenador = new Dictionary<string, Ordenador>();

            int opcion = 0;
            do
            {
                Console.WriteLine("1)Añadir equipos\n2)Añadir varios equipos\n3)Eliminaar un dato por clave\n4)Mostrar lista de nombre\n5)Mostrar un elemento de la coleccion\n6)Salir");
                opcion = pg.enteros(Console.ReadLine());

                switch (opcion)
                {
                    case 1://TODO comprobar clave repetida
                        Console.WriteLine("Vamos a añadir un nuevo equipo!");

                        Console.WriteLine("Dime la IP del ordenador");
                        string ip = pg.ip(Console.ReadLine());

                        Console.WriteLine("Ahora dime la RAM");
                        int memoria = pg.ram(Console.ReadLine());

                        Ordenador or1 = new Ordenador(ip, memoria);

                        dicOrdenador.Add(ip, or1);
                        break;

                    case 2:
                        Console.WriteLine("Vamos a añadir varios equipos");

                        //Console.WriteLine("Cuantos equipos quieres?");
                        //int cantidad = pg.enteros(Console.ReadLine());

                        //for (int i = 0; i < cantidad; i++)
                        //{
                        //    Console.WriteLine("Dime la IP del ordenador");
                        //    string ip2 = pg.ip(Console.ReadLine());

                        //    Console.WriteLine("Ahora dime la RAM");
                        //    int memoria2 = pg.ram(Console.ReadLine());

                        //    Ordenador or2 = new Ordenador("NONAME_"+ip2, memoria2);

                        //    dicOrdenador.Add(ip2, or2);
                        //}

                        bool bandera = false;

                        int memoria2 = 0;
                        string ip2 = "";
                        do//bucle raaro
                        {
                            Console.WriteLine("Dime todas las ip:ram que quieras añadir");
                            string[] equipos = Console.ReadLine().Split(',');

                            for (int i = 0; i < equipos.Length; i++)
                            {
                                string[] infoEquipo = equipos[i].Split(':');
                                if (infoEquipo.Length == 2)
                                {
                                    Console.WriteLine("Hay dos valores, para guardar correctamente la informacion de los equipos");
                                    if (Ordenador.comprobacionIp(infoEquipo[0]) && !dicOrdenador.ContainsKey(infoEquipo[0]))
                                    {
                                        ip2 = infoEquipo[0];
                                        bandera = false;

                                    }
                                    else
                                    {
                                        Console.WriteLine("ip invalida");
                                        bandera = true;//continue
                                    }

                                    if (int.TryParse(infoEquipo[1], out memoria2))
                                    {
                                        if (memoria2 > 0)
                                        {
                                            bandera = false;
                                        }
                                        else
                                        {
                                            Console.WriteLine("La memoria es negativa y no puede serlo");
                                            bandera = true;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("ram invalida");
                                        bandera = true;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("No has introducido la cantidad de valores correctamente, vuelve a intentarlo (Ip:RAM)");
                                    bandera = true;
                                }

                                try//TODO revisar donde colocar
                                {
                                    dicOrdenador.Add(ip2, new Ordenador("NONAME_" + ip2, memoria2));
                                    bandera = false;
                                }
                                catch (NegativeRAMException e)
                                {
                                    Console.WriteLine("No se pudieron añadir todos los elementos correctamente");
                                    bandera = true;
                                }
                            }
                        } while (bandera);


                        Console.WriteLine("Se añadieron todos los nuevos equipos correctamente");
                        break;

                    case 3:
                        Console.WriteLine("Dime la clave del equipo que quieres eliminar");
                        string claveBuscar = pg.ip(Console.ReadLine());

                        bool existe = dicOrdenador.ContainsKey(claveBuscar);

                        if (existe)
                        {
                            dicOrdenador.Remove(claveBuscar);
                        }
                        else
                        {
                            Console.WriteLine("La clave que pasaste no existe en el diccionario");
                        }

                        break;

                    case 4:
                        Console.WriteLine("Vamos a ver los nombres");
                        //var lista = dicOrdenador.ToList();

                        //for (int i = 0; i < dicOrdenador.Count; i++)
                        //{
                        //    Console.WriteLine($"Nombre: {lista[i].Value.Nombre}");
                        //}

                        foreach (var par in dicOrdenador)
                        {
                            Console.WriteLine($"Nombre: {par.Value.Nombre}");
                        }
                        break;

                    case 5:
                        Console.WriteLine("Vamos a buscar el elemento");

                        Console.WriteLine("Dime la clave que quieres buscar");
                        string clavBusca = pg.ip(Console.ReadLine());

                        bool existe5 = dicOrdenador.ContainsKey(clavBusca);

                        if (existe5)
                        {
                            Console.WriteLine($"IP: {clavBusca}\nNombre: {dicOrdenador[clavBusca].Nombre}\nRAM: {dicOrdenador[clavBusca].Memoria}");
                        }
                        else
                        {
                            Console.WriteLine("La clave sugerida no existe en el listdo");
                        }
                        break;

                    case 6:
                        Console.WriteLine("Saliendo del menu");
                        break;

                    default:
                        Console.WriteLine("Opcion del menu no valida");
                        break;
                }
            } while (opcion != 6);
        }
    }
}
