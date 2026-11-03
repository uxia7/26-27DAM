using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ejer7
{
    internal class Program
    {
        public static int ConvertirEnt(String lectura)
        {
            int dato;
            while (!int.TryParse(lectura, out dato))
            {
                Console.WriteLine("Tienes que ingresar un dato valido!");
                lectura = Console.ReadLine();
            }
            return dato;

        }

        public static double ConvertirDeci(String lectura)
        {
            double dato;
            while (!double.TryParse(lectura, out dato))
            {
                Console.WriteLine("Tienes que ingresar un dato valido!");
                lectura = Console.ReadLine();
            }
            return dato;
        }

        public static bool ComprobacionGas(String respuesta)
        {
            //Planeta planeta = new Planeta();
            if (respuesta == "si" || respuesta == "true")
            {
                //gaseoso = true;
                //planeta.Gaseoso = true;
                return true;

            }
            else if (respuesta == "no" || respuesta == "false")
            {
                //planeta.Gaseoso = false;
                return false;

            }
            else
            {
                throw new ArgumentException("No has indicado corectamente si es o no gaseoso");
            }
        }
        static void Main(string[] args)
        {
            //Astro astro = new Astro("XP-585-120", 2348.45);

            //Astro astro1 = new Astro("XP-585-439", 2348.45);

            //Console.WriteLine(astro.Equals(astro));


            Astro astro1 = new Planeta(true, 67, "Jupiter", 34567.678);
            astro1.Equals(22);
            //una clase abstracta es una clase incompleta, para poder usarla lo que tienes que hacer es llamar a la clase que la implemente o herede y de ahí acceder a sus funciones correspondientes
            Astro astro2 = new Planeta(false, 1, "Tierra", 16700.69);

            Planeta p1 = new Planeta(false, 2, "Marte", 17363.635);
            Planeta p2 = new Planeta(true, 1, "Venus", 4000.635);

            //planeta sin parametros para saber que lo crea bien
            Planeta p3 = new Planeta();

            //planeta con radio negativo para comprobar que no se guarda y que hace mensaje de error por ello
            Planeta p4 = new Planeta(true, 4, "Pluton", -2536.56);

            //probando la sobrecarga del Equals
            Console.WriteLine("Son exactamente iguales en el nombre?: " + astro1.Equals(astro2));
            Console.WriteLine("Son exactamente iguales en el nombre?: " + astro1.Equals(astro1));

            //probando lo de la sobrecarga de operadores
            //primero el de ++
            Console.WriteLine("El numero de satelites originalmente es: " + p1.NumSatelites);
            p1++;
            Console.WriteLine("El numero de satelites despues del incremento es: " + p1.NumSatelites);

            //luego el de --
            Console.WriteLine("El numero de satelites originalmente es: " + p2.NumSatelites);
            p2--;
            Console.WriteLine("El numero de satelites despues del decremento es: " + p2.NumSatelites);
            //al volver a intentar hacer el decremento porque al restarlo por primera vez bien, pero a la segunda ya da problemas?:
            //p2--;

            //probando el ToString()
            p1.ToString();
            p2.ToString();

            //probando si el metodo de esHabitable()
            Console.WriteLine("Tu planeta: " + p3.Nombre + "es habitable?: " + p3.esHabitable());
            Console.WriteLine("Tu planeta: " + p2.Nombre + "es habitable?: " + p2.esHabitable());

            //comprobamos la funcion implementada en Cometa siempre devuelva false
            Cometa cometaPrueba = new Cometa();
            cometaPrueba.Nombre = "A-3 Tsuchinshan-ATLAS";
            cometaPrueba.Radio = 2036.523;
            Console.WriteLine("Este es tu cometa:\n" + "Nombre: " + cometaPrueba.Nombre + "\nRadio: " + cometaPrueba.Radio + "\nNunca será habitable: " + cometaPrueba.esHabitable());



            //aqui empieza el ejercicio 8!!!!!!!
            //por recomendacion es mejor hacer ArrayList con el tipo tipado, o sea con el List <> para indicarle el tipo de dato que va a guardar
            //porque las colecciones como ArrayList colObjetos = new ArrayList() hay que usarlo cuando tenemos que guardar en una coleccion diferentes objetos que no heredan del todo comun, por ejemplo, clase Gato, Astro y Comida

            List<Astro> astros = new List<Astro>();
            int opcion = 0;
            //bool error = true;
            try
            {
                do
                {
                    Console.WriteLine("Dime la opcion del menu:\n1)Añadir planeta\n2)Añadir cometa\n3)Mostrar datos\n4)Incrementar/decrementar nº satelites\n5)Eliminnar no terraformables\n6)Salir");
                    //opcion = Convert.ToInt32(Console.ReadLine());
                    //como tiene que convetir a un numero de un string, aqui podemos hacer un TryParse
                    opcion = ConvertirEnt(Console.ReadLine());
                    Console.WriteLine("Tu opcion ha sido: " + opcion);
                    switch (opcion)
                    {
                        case 1: //añadir planeta

                            Planeta planeta = new Planeta();

                            //try
                            //{
                            string respuesta;
                            //bool gaseoso;
                            //do
                            //{
                            try
                            {

                                Console.WriteLine("Tu planeta es gaseoso?");
                                //respuesta = Console.ReadLine().ToLower();
                                //como aqui el escaner no tranforma los datos con un sc.NextInt o asi, da igual que meta un 234 va a ser una cadena
                                //y entonces no saltara ninguna excepcion, pero es que igual que en java, eso solo seria si estuviera conviertiendo a un numero
                                planeta.Gaseoso = ComprobacionGas(Console.ReadLine().ToLower());
                                //} while (respuesta != "si" && respuesta != "no" && respuesta != "true" && respuesta != "false");

                                //}
                                //catch (ArgumentException e) //ArgumentException //FormatException
                                //{
                                //    Console.WriteLine("Has metido el dato incorrecto: " + e.Message);
                                //}

                            }
                            catch (ArgumentException e)
                            {
                                Console.WriteLine(e.Message);
                            }

                            Console.WriteLine("Dime el nombre de tu planeta:");
                            planeta.Nombre = Console.ReadLine();

                            Console.WriteLine("Dime el radio de tu planeta:");
                            //planeta.Radio = Convert.ToInt32(Console.ReadLine());
                            //while (!int.TryParse(Console.ReadLine(), out opcion))
                            //{
                            //    Console.WriteLine("Tienes que ingresar un dato valido!");
                            //}
                            try
                            {

                                planeta.Radio = ConvertirDeci(Console.ReadLine());
                            }
                            catch (ArgumentException e)
                            {
                                Console.WriteLine(e.Message);
                            }

                            //int final;
                            //String cantidad;
                            Console.WriteLine("Dime la cantidad de lunas que tiene tu planeta:");
                            planeta.NumSatelites = ConvertirEnt(Console.ReadLine());
                            //planeta.NumSatelites = Convert.ToInt32(Console.ReadLine());
                            //cantidad = Console.ReadLine();
                            //while (!int.TryParse(cantidad, out final))
                            //explicacion del TryParse en la hoja, pero:
                            //esta funcion devuelve 2 cosas, true/false y la variable donde guardara el dato
                            //{
                            //    Console.WriteLine("Tienes que ingresar un dato valido!\nIngresa de nuevo una cantidad de lunas: ");
                            //    cantidad = Console.ReadLine();

                            //}
                            //planeta.NumSatelites = final;

                            astros.Add(planeta);
                            break;

                        case 2: //añadir cometa

                            Cometa cometa = new Cometa();

                            Console.WriteLine("Dime el nombre de tu cometa:");
                            cometa.Nombre = Console.ReadLine();

                            //string radioCon;
                            //double final2;
                            Console.WriteLine("Dime el radio de tu cometa:");
                            cometa.Radio = ConvertirDeci(Console.ReadLine());//Excepcion radio
                            //radioCon = Console.ReadLine();
                            //while (!double.TryParse(radioCon, out final2))
                            //{
                            //    Console.WriteLine("Tienes que ingresar un dato valido!\nVuelve a ingresar el radio de tu cometa");
                            //    radioCon = Console.ReadLine();

                            //}
                            //cometa.Radio = final2;

                            astros.Add(cometa);
                            break;


                        case 3: //mostrar datos
                            for (int i = 0; i < astros.Count; i++)
                            {//dentro de la coleccion queremos comprobar de que tipo de es el astro, ya que si son planetas queremos mostrar tambien las lunas y en caso de cometa eso no existe
                             //entonces, hacemos esto dentro del if y nos aseguramos que ese elemento en concreto de la coleccion es del tipo Planeta
                                if (astros[i].GetType() == typeof(Planeta))
                                {
                                    Console.WriteLine(((Planeta)(astros[i])).ToString() + "\nHabitable: " + ((Planeta)(astros[i])).esHabitable());
                                    //otra manera un poco mas larga
                                    //Console.WriteLine("El planeta:"+ ((Planeta)(astros[i])).Nombre +"\nHabitable: " + ((Planeta)(astros[i])).esHabitable());
                                    //Console.WriteLine(((Planeta)(astros[i])).ToString());
                                }
                                else
                                {
                                    Console.WriteLine("Nombre cometa: " + ((Cometa)(astros[i])).Nombre + "\nRadio: " + ((Cometa)(astros[i])).Radio + "\nHabitable: " + ((Cometa)(astros[i])).esHabitable());

                                }
                            }
                            break;


                        case 4: //incrementar o decrementar satelites
                            String nombreAstro;
                            bool encontrado = false;
                            // bandera para controlar el tema de poder salir del bucle do-while 


                            do
                            {
                                Console.WriteLine("Dime el nombre del astro del cual vas a querer modificar las lunas (ej: \"MARTE\":");
                                nombreAstro = Console.ReadLine();

                                //cada vez que se meta un nombre el encontrado se pone a false
                                encontrado = false;

                                for (int i = 0; i < astros.Count; i++)//uso de indexof y equals
                                {
                                    if (astros[i].GetType() == typeof(Planeta) && astros[i].Nombre.Equals(nombreAstro)) //Equals("\""+ nombreAstro.ToUpper() + "\""))
                                    {
                                        String decision;
                                        Console.WriteLine($"Incrementar o decrementar? {astros[i].Nombre} (incrementar/decrementar)");
                                        decision = Console.ReadLine().ToLower();

                                        try
                                        {
                                            if (decision == "decrementar")//TODO operadores sobrecargados (variable auxiliar)
                                            {
                                                //en caso, como decrementar tiene una excepciones, tenemos que hacerle el try-catch para que no falle cuando llegue el caso de la excepcion
                                                //se lo he hecho a todo el codigo de este apartado, igual es lo mejor, aunque igual es mejor ponerlo concentrado en ese apartado solo
                                                //try
                                                //{

                                                Console.WriteLine("Has elegido la opcion: " + decision);

                                                //para poder hacer la sobrecarga necesitamos una variable auxiliar de tipo Planeta donde guardaremos el planeta actual donde estamos
                                                Planeta finalSat = (Planeta)astros[i];

                                                Console.WriteLine("El numero actual de lunas en: " + astros[i].Nombre + " es: " + finalSat.NumSatelites); //((Planeta)astros[i]).NumSatelites
                                                                                                                                                          //como todavia no hemos decrementado ni hecho nada, finalSat tiene el valor original de satelites, entonces podemos usarlo para mostrar el numero de satelites antes de nada y asi no tener que hacer el casting ni nada
                                                finalSat--;

                                                //muestras en pantalla el resultado final para asegurarte que se ha realizado correctamente
                                                Console.WriteLine("El numero de lunas se ha decrementado: " + finalSat.NumSatelites);

                                                //}
                                                //catch (ArgumentOutOfRangeException e)
                                                //{
                                                //    Console.WriteLine(e.Message);
                                                //}
                                            }
                                            else if (decision == "incrementar")
                                            {
                                                Console.WriteLine("Has elegido la opcion: " + decision);

                                                //hacemos lo mismo que con decrementar, creamos la variable auxiliar donde guardaremos el elemento seleccionado
                                                Planeta finalSat = (Planeta)astros[i];

                                                Console.WriteLine("El numero actual de lunas en: " + astros[i].Nombre + " es: " + ((Planeta)astros[i]).NumSatelites);

                                                //una vez hecho esto lo que hacemos es 
                                                finalSat++;
                                                Console.WriteLine("El numero actual de lunas se ha incrementado correctamente: " + finalSat.NumSatelites);
                                            }
                                            else
                                            {
                                                Console.WriteLine("Opción no válida, no has introducido la palabra correcta: " + decision);
                                            }
                                        }
                                        catch (ArgumentOutOfRangeException e)
                                        {
                                            Console.WriteLine(e.Message);
                                        }

                                        encontrado = true;
                                        //break;
                                        //con el break lo que hacemos es salir del for en el momento en el que hemos encontrado y gestionado el elemento que buscabamos
                                    }
                                }

                                //aqui simplemente informaremos al usuario del que el planeta que buscaba no se dio encontrado, asi simplemente no da error
                                if (!encontrado)
                                {
                                    Console.WriteLine("No se encontró un planeta con ese nombre");
                                }

                                //no recorre el bucle en el momento que encontrado sea false
                            } while (!encontrado);


                            //Console.WriteLine("Introduce el nombre del planeta:");
                            //nombreAstro = Console.ReadLine();
                            //Planeta planetaEncontrado = astros.OfType<Planeta>().FirstOrDefault(p => p.Nombre == nombreAstro);

                            //if (planetaEncontrado == null)
                            //{
                            //    Console.WriteLine("No se ha encontrado un planeta con ese nombre.");
                            //}
                            //else
                            //{
                            //    Console.WriteLine("¿Quieres incrementar o decrementar las lunas? (incrementar/decrementar)");
                            //    string decision = Console.ReadLine().ToLower();

                            //    if (decision == "incrementar") planetaEncontrado.NumSatelites++;
                            //    else if (decision == "decrementar") planetaEncontrado.NumSatelites--;
                            //    else Console.WriteLine("Opción no válida.");
                            //}

                            break;


                        case 5: //eliminar los que no son terraformables
                            for (int i = astros.Count - 1; i >= 0; i--)
                            {
                                //if (((Planeta)(astros[i])).esHabitable() == false || (astros[i].GetType() == typeof(Cometa)))
                                //{
                                //    astros.RemoveAt(i);
                                //}
                                //esHabitable() == false -> este tipo de cosas hay que evitarlas a toda costa

                                if ((astros[i] is Cometa && !((Cometa)astros[i]).esHabitable() || astros[i] is Planeta && !((Planeta)astros[i]).esHabitable()) && astros[i] is ITerraformable)//TODO Comprueba que cumple la interface ITerrafomable
                                {//astros[i] is Cometa || (astros[i] is Planeta p && !p.esHabitable())
                                    astros.RemoveAt(i);
                                }
                            }
                            break;


                        case 6:
                            Console.WriteLine("Saliendo del programa...");
                            break;

                        default:
                            Console.WriteLine("Tu opcion no está dentro de las opciones del menu");
                            break;
                    }



                } while (opcion != 6);
            }
            catch (FormatException e)
            {
                Console.WriteLine("No has metido un dato valido: " + e.Message);
            }
        }

    }
}

