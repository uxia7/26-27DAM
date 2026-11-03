using System;
using System.Collections.Generic;
using System.Data;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    internal class Program
    {
        public int enteros(string lectura)
        {
            //creo la variable y asi cuando la use en el TryParse, si sale correcto
            //devuelvo su valor
            int num;

            //el bucle se tiene que repetir hasta que metan un dato correcto
            while (!int.TryParse(lectura, out num))
            {
                //en caso de que el dato sea erroneo
                //muestro el mensaje por pantalla 
                Console.WriteLine("No has introducido el dato que se pidio, vuelve a intentarlo");
                //vuelvo a intentarlo leyendo una nuevo dato del Console.ReadLine
                //esta linea es fundamental porque si no entra en bucle infinito
                lectura = Console.ReadLine();
            }
            //en caso de que metan un dato correcto, devolverá ese mismo numero
            return num;
        }

        public double decimales(string lectura)
        {
            //creo la variable y asi cuando la use en el TryParse, si sale correcto
            //devuelvo su valor
            double num;
            //el bucle se tiene que repetir hasta que metan un dato correcto
            while (!double.TryParse(lectura, out num))
            {
                //en caso de que el dato sea erroneo
                //muestro el mensaje por pantalla 
                Console.WriteLine("No has introducido el dato que se pidio, vuelve a intentarlo");
                //vuelvo a intentarlo leyendo una nuevo dato del Console.ReadLine
                //esta linea es fundamental porque si no entra en bucle infinito
                lectura = Console.ReadLine();
            }
            //en caso de que metan un dato correcto, devolverá ese mismo numero
            return num;
        }

        public double comprobacionRadio(string lectura)
        {
            // primero me aseguro de que sea un número
            double radio = decimales(lectura);

            // ahora compruebo que además sea positivo
            while (radio <= 0)
            {
                Console.WriteLine("Radio no valido, vuelve a intentarlo");
                // vuelvo a leer y a validar que sea número con decimales()
                radio = decimales(Console.ReadLine());
            }
            return radio;
        }

        static void Main(string[] args)
        {

            //aqui es donde empieza el ejercicio 8 que seria todo el main
            //NO PUEDE FALLAR NADA
            Program pg = new Program();
            try
            {
                int opcion = 0;
                List<Astro> cole = new List<Astro>();

                do
                {
                    Console.WriteLine("Dime una opcion del menu: 1-6");
                    opcion = pg.enteros(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            bool gaseoso = true;
                            string nombre = "";
                            double radio = 0;
                            int numSat = 0;

                            bool bandera = true;
                            while (bandera)
                            {
                                Console.WriteLine("Es gaseoso? (1-si 2-no)");
                                int decision = pg.enteros(Console.ReadLine());
                                bandera = false;
                                if (decision == 1)
                                {
                                    gaseoso = true;
                                }
                                else if (decision == 2)
                                {
                                    gaseoso = false;
                                    // bandera = false;
                                }
                                else
                                {
                                    Console.WriteLine("Opcion no valida, vuelve a intentarlo");
                                    bandera = true;
                                }
                            }


                            Console.WriteLine("Dime el nombre del planeta");
                            nombre = Console.ReadLine();

                            //bandera = true;
                            //while (bandera)
                            //{
                            try
                            {
                                Console.WriteLine("Dime el radio");
                                radio = pg.comprobacionRadio(Console.ReadLine());

                                //if (radio > 0)
                                //{
                                //    bandera = false;
                                //}
                                //else
                                //{
                                //    Console.WriteLine("Radio negativo, vuelve a intentarlo");
                                //    bandera = true;
                                //}

                            }
                            catch (ArgumentException e)
                            {
                                //bandera = true;
                                Console.WriteLine("El radio no puede ser negativo");
                            }
                            //}

                            Console.WriteLine("Dime el numero de satelites");
                            numSat = pg.enteros(Console.ReadLine());

                            Planeta p1 = new Planeta(nombre, radio, gaseoso, numSat);

                            cole.Add(p1);

                            break;

                        case 2:
                            string nombre1 = "";
                            Console.WriteLine("Dime el nombre");
                            nombre1 = Console.ReadLine();

                            double radio1 = 0;

                            //bool bandera1 = true;
                            //while (bandera1)
                            //{
                            Console.WriteLine("Dime el radio");
                            radio1 = pg.comprobacionRadio(Console.ReadLine());
                            //    if (double.TryParse(Console.ReadLine(), out radio1))
                            //    {
                            //        if (radio1 > 0)
                            //        {
                            //            bandera = false;
                            //        }
                            //        else
                            //        {
                            //            Console.WriteLine("Radio negativo, vuelve a intentarlo");
                            //            bandera = true;
                            //        }

                            //    }
                            //    else
                            //    {
                            //        Console.WriteLine("Opcion no valida, vuelve a intentarlo");
                            //    }
                            //}

                            Cometa cm = new Cometa(nombre1, radio1);

                            cole.Add(cm);

                            break;

                        case 3:
                            //mostrar datos
                            //indicar si es iterraformable
                            //en cometa muestra el nombre 
                            //en caso de planeta lo que devuelva ToString
                            for (int i = 0; i < cole.Count; i++)
                            {
                                if (cole[i].GetType() == typeof(Planeta))
                                {
                                    Console.WriteLine(((Planeta)cole[i]).ToString());
                                    //el . se evalua antes que el cast
                                    //con lo cual si quiero llamar al tostring que tengo sobrecargado
                                    //tengo que poner el casteo entre parentesis adicionales para que me lo haga bien
                                    if (cole[i] is ITerraformable tierra)//TODO sacar esste if comprobando si es ITerraformable
                                    {
                                        if (tierra.esHabitable())
                                        {

                                            Console.WriteLine("ES habitable");
                                        }
                                        else
                                        {
                                            Console.WriteLine("NO es habitable");
                                        }

                                    }
                                    else
                                    {
                                        Console.WriteLine("NO es terraformable");
                                    }

                                }
                                else if (cole[i].GetType() == typeof(Cometa))
                                {
                                    Console.WriteLine($"Nombre: {((Cometa)cole[i]).Nombre}\nRadio: {((Cometa)cole[i]).Radio}");
                                    if (cole[i] is ITerraformable tierra)//TODO sacar esste if comprobando si es ITerraformable
                                    {
                                        if (tierra.esHabitable())
                                        {

                                            Console.WriteLine("ES habitable");
                                        }
                                        else
                                        {
                                            Console.WriteLine("NO es habitable");
                                        }

                                    }
                                    else
                                    {
                                        Console.WriteLine("NO es terraformable");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Error, no se detecto ninguna de las clases");
                                }
                            }
                            break;

                        case 4:
                            //pedimos el nombre del astro para poder buscarlo en la cole
                            Console.WriteLine("Dime el nombre del Astro que quieres incrementar o decrementar");
                            string nomAstro = Console.ReadLine().ToUpper();

                            //SI HAGO USO DEL INDEXOF() NO NECESITO USAR UN FOR
                            //for (int i = 0; i < cole.Count; i++)
                            //{
                            int indices = cole.IndexOf(new Planeta(nomAstro, 0, true, 0));
                            //recorremos la coleccion
                            //cuando los dos nombres son iguales -> usamos IndexOf()
                            //le preguntamos al usuario si quiere incrementar sus lunas o decrementar
                            if (indices != -1 && (cole[indices].GetType() == typeof(Planeta)))
                            {

                                bool band = true;
                                while (band)
                                {
                                    //try
                                    //{
                                    Console.WriteLine("Se encontró el elemento!\nVas a querer incrementar(1) o decrementar(2)");
                                    int desvio = pg.enteros(Console.ReadLine());
                                    //no puedo crear una variable donde guardar el resultado porque al final tengo que andar a actualizar el resultado en cada momento
                                    //es mejor hacerlo directamente
                                    //int satelite = ((Planeta)cole[i]).NumSat;
                                    if (desvio == 1)
                                    {
                                        Console.WriteLine($"Vamos a INCREMENTAR el numero de satelites:\nActualmente:\nNombre: {cole[indices].Nombre}\nNumero de saatelites: {((Planeta)cole[indices]).NumSat}");
                                        //((Planeta)cole[indices]).NumSat++;//TODO usar las sobrecargas de ++ y --
                                        Planeta p = (Planeta)cole[indices];
                                        p++;
                                       // cole[indices] = p;

                                        Console.WriteLine($"Incremento:\nNombre: {cole[indices].Nombre}\nNumero de saatelites: {((Planeta)cole[indices]).NumSat}");
                                        band = false;
                                    }
                                    else if (desvio == 2)
                                    {
                                        Console.WriteLine($"Vamos a DECREMENTAR el numero de satelites:\nActualmente:\nNombre: {cole[indices].Nombre}\nNumero de satelites: {((Planeta)cole[indices]).NumSat}");

                                        if (((Planeta)cole[indices]).NumSat <= 0)
                                        {
                                            Console.WriteLine("No se puede decrementar porque no cumple las condiciones, incrementa antes de seguir");
                                            band = true;
                                        }
                                        else
                                        {
                                            Planeta p = (Planeta)cole[indices];
                                            p--;
                                            //cole[indices] = p;
                                            Console.WriteLine($"Decremento:\nNombre: {cole[indices].Nombre}\nNumero de satelites: {((Planeta)cole[indices]).NumSat}");
                                            band = false;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Opcion no valida, vuelve a intentarlo");
                                        band = true;
                                    }
                                    //}
                                    //catch (ArgumentException n)
                                    //{
                                    //    Console.WriteLine("No se puede drecrementar el numero de satelites, porque será negativo");
                                    //    band = true;
                                    //}
                                }
                            }
                            else
                            {
                                Console.Error.WriteLine("Elemento no valido en la condicion");
                            }
                            //}
                            break;

                        case 5:
                            Console.WriteLine("Vamos a eliminar los elementos NO habitables de la cole");
                            for (int i = cole.Count - 1; i >= 0; i--)
                            {
                                //en caso de que esHbabitable devuelva false, enton lo eliminamos
                                if (cole[i] is ITerraformable)
                                {
                                    if (!((Planeta)cole[i]).esHabitable())
                                    {
                                        Console.WriteLine($"Planeta: {cole[i].Nombre} fue eliminado de la coleccion");
                                        cole.RemoveAt(i);

                                    }
                                }
                                else
                                {
                                    if (!((Cometa)cole[i]).esHabitable())
                                    {
                                        Console.WriteLine($"Cometa: {cole[i].Nombre} fue eliminado de la coleccion");
                                        cole.RemoveAt(i);

                                    }
                                }
                                //else
                                //{
                                //    Console.Error.WriteLine($"Elemento: {cole[i].Nombre} es habitable");
                                //}
                            }
                            break;

                        case 6:
                            Console.WriteLine("Saliendo...");
                            break;

                        default:
                            Console.WriteLine("Opcion no valida");
                            break;
                    }

                } while (opcion != 6);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Argumento invalido");
            }
        }
    }
}

