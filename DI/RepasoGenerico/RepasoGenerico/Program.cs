using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoGenerico
{
    internal class Program
    {
        /*
         *
            se crea una colección de Astros y el siguiente menú (Controla las excepciones de
            las opciones de menú con TryParse):
            
            
           
            
            • Eliminar no terraformables: Elimina todos los elementos que no sean
            terraformables de la colección.
            • Salir. Como siempre no sale de la aplicación hasta que se selecciona esta
            opción.
         */


        public static int numerosEnteros(string sms)
        {
            int opcion;
            string cadena;
            Console.WriteLine(sms);
            cadena = Console.ReadLine();
            while (!int.TryParse(cadena, out opcion))
            {
                Console.WriteLine("dime un numero valido:");
                cadena = Console.ReadLine();
            }
            return opcion;
        }

        public static double numeroReales(string sms)
        {
            double opcion;
            string cadena;
            Console.WriteLine(sms);
            cadena = Console.ReadLine();
            while (!double.TryParse(cadena, out opcion))
            {
                Console.WriteLine("dime un numero valido:");
                cadena = Console.ReadLine();
            }
            return opcion;
        }
        static void Main(string[] args)
        {

            List<Astro> cole = new List<Astro>();
            int opcion;
            string cadena;
            do
            {

                opcion = numerosEnteros("dime una opcion de menu");

                switch (opcion)
                {
                    //• Añade Planeta: Pregunta si es gaseoso y pide el nombre y radio. También
                    //pregunta cantidad de lunas.
                    case 1:
                        bool gaseoso = false;
                        int numeroSatelites;
                        string nombre;
                        double radio;
                        int opcion1 = numerosEnteros("Dime si es gaseoso? 1)si 2)no");
                        if (opcion1 == 1)
                        {
                            gaseoso = true;
                        }
                        else if (opcion1 == 2)
                        {
                            gaseoso = false;
                        }
                        else
                        {
                            Console.WriteLine("opcion no valida!");
                        }

                        numeroSatelites = numerosEnteros("dime numero de satelites:");
                        Console.WriteLine("dime el nombre:");
                        nombre = Console.ReadLine();

                        radio = numeroReales("dime el radio:");

                        Planeta planeta1 = new Planeta(nombre, radio, gaseoso, numeroSatelites);
                        cole.Add(planeta1);

                        break;
                    case 2:

                        //• Añade Cometa: Pide su nombre y radio.

                        //añadir cometa
                        string nombre2 = "";
                        double radio2;

                        Console.WriteLine("Dime el nombre del cometa");
                        nombre2 = Console.ReadLine();


                        radio2 = numeroReales("dime el radio del cometa");

                        //como cometa no dispone de ctor, lo creamos nosotros para poder usarlo
                        Cometa cm = new Cometa(nombre2, radio2);
                        cole.Add(cm);

                        break;
                    case 3:

                        /*
                         *  • Mostrar datos: para cada elemento indica si es terraformable. Además en el
                            caso de Cometa mostrará el nombre y en el caso de Planeta mostrará lo que
                             devuelva ToString.
                         */


                        for (int i = 0; i < cole.Count(); i++)
                        {
                            if (cole[i] is ITerraformable)
                            {
                                Console.WriteLine("Es terraformable");
                            }
                            else
                            {
                                Console.WriteLine("No es terraformable");
                            }

                            if (cole[i].GetType() == typeof(Planeta))
                            {
                                ((Planeta)cole[i]).ToString();
                            }
                            else
                            {
                                Console.WriteLine(((Cometa)cole[i]).nombre);
                            }
                        }

                        break;
                    case 4:
                        /*
                         * • Incrementa/Decrementa n.º de satélites. Pide nombre del Astro y si existe
                            (usa IndexOf) y es de tipo Planeta se pregunta si se desea incrementar o
                            decrementar en una unidad el n.º de satélites.
                         */

                        Console.WriteLine("Dime el nombre de un astro");
                        string nombre4 = Console.ReadLine();
                        
                        int posicion = cole.IndexOf(new Planeta(nombre4, 0, false, 0));
                        
                        if(posicion != -1)
                        {
                            if (cole[posicion].GetType() == typeof(Planeta))
                            {
                                int opcion4 = numerosEnteros("INcrementar(1) decrementar(2)");
                                if(opcion4 == 1)
                                {
                                    Planeta p = ((Planeta)cole[posicion]);
                                    p++;

                                } else if(opcion4  ==  2)
                                {
                                    Planeta p = ((Planeta)cole[posicion]);
                                    p--;

                                } else
                                {
                                    Console.WriteLine("mal");
                                }
                            }
                        }

                        break;
                    case 5:
                        break;
                    case 6:
                        break;

                    default:
                        break;
                }

            } while (opcion != 6);
        }
    }
}
