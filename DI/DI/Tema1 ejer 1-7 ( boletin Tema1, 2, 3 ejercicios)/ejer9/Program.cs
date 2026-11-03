using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ejer9
{
    internal class Program
    {

        public static int conversorEnt(String lectura)
        {
            if (!int.TryParse(lectura, out int numero))
            { //primero el out y luego la declaracion de la variable con el int y todo
                Console.WriteLine("Has introducido un dato erroneo");
                throw new ArgumentException();
            }
            else
            {
                Console.WriteLine("Has introducido correctamente el dato");
                return numero;
            }
        }
        static void Main(string[] args)
        {
            //Plantea un menú para nuevo equipos, elimina un dato(por clave), muestra de la
            //colección entera y muestra de un elemento de la colección(A partir de la clave
            //muestra el resto de los datos).
            int opcion = 0;
            //String entrada;
            List<Ordenador> ordenadores = new List<Ordenador>();
            do
            {
                Console.WriteLine("Menu:\n1)Añadir nuevos equipos\n2)Eliminar un dato de la coleccion\n3)Mostrar la coleccion entera\n4)Muestra un elemento concreto de la coleccion\n5)Salir");
                opcion = conversorEnt(Console.ReadLine());
                //el int.TryParse() no funciona con el Console.ReadLine() tienes que hacer siempre el mismo proceso
                //entrada = Console.ReadLine();
                //if(int.TryParse(Console.ReadLine(), out opcion)) {
                //    Console.WriteLine($"Has introducido correctamente la opcion: {opcion}");
                //} else
                //{
                //    Console.WriteLine("No se introdujo un valor correcto para el menu, has introducido un dato que no fue un numero");
                //}

                switch (opcion)
                {
                    case 1: //añadir ordenador
                        Ordenador ord = new Ordenador();
                        //String nombreOrd;
                        //int memoRam;

                        Console.WriteLine("Vamos a añadir elementos en la lista de ordenadores");

                        Console.WriteLine("Dime el nombre del ordenador:");
                        ord.Nombre = Console.ReadLine();

                        Console.WriteLine("Dime la capacidad de memoria RAM que tiene:");
                        ord.MemoriaRam = conversorEnt(Console.ReadLine());

                        Console.WriteLine("Dime la ip del ordenador:");
                        Ordenador.IpValida(Console.ReadLine());
                        //tengo que llamarla con la clase porque es parte de la clase, por eso si hago el objeto no aparece esta funcion

                        ordenadores.Add(ord);

                        break;

                    case 2: //eliminar un dato de la coleccion
                        String nomOrd;
                        Console.WriteLine("Dime el nombre del ordenador que vas a querer eliminar de la lista");
                        foreach(Ordenador ordenador in ordenadores)
                        {
                            Console.WriteLine(ordenador);
                        }
                        nomOrd = Console.ReadLine();
                        for (int i = 0; i < ordenadores.Count; i++)
                        {
                            if(nomOrd.Equals())
                            {

                            }
                        }
                        break;

                    case 3:
                        break;

                    case 4:
                        break;

                    case 5:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Has seleccionado ");
                        break;
                }

            } while (opcion != 5);
        }
    }
}
