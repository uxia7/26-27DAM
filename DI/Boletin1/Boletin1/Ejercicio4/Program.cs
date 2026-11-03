using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace Ejercicio4
{
    internal class Program
    {
        public static int transformacion(string lectura)//Funcion de peticion de datos en unrango
        {
            int numero;
            //en lugar del true, ahorro mucho poniendo el while de esta manera
            while ((int.TryParse(lectura, out numero)) && numero >= 0 && numero <= 10000) //true 
            {
                //if ((int.TryParse(lectura, out int numero)) && numero >= 0 && numero <= 10000)
                //{
                //    return numero;
                //}
                //else
                //{
                Console.WriteLine("Dato no valido, vuelve a indicarme un nuevo dato");
                lectura = Console.ReadLine();
                //}
            }
            return numero;
        }

        //public static int comprobacionPos1(int year)
        //{
        //    if (year > 0 && year < 10000)
        //    {
        //        return year;
        //    }
        //    else
        //    {
        //        return 0;
        //    }
        //}


        public static bool bisiesto(int year)
        {
            //de forma directa:
            return ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0);

            //de forma indirecta: (evitarlo)
            //if(((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)){
            //    return true;

            //}
            //else
            //{
            //    return false;
            //}
        }

        public static int? sumaRango(int num1, int num2)
        {
            if (num1 > num2)
            {
                return null;
            }
            else
            {
                int resultado = 0;
                for (int i = num1; i < num2; i++)
                {
                    resultado += i;
                }

                return resultado;
            }
        }
        static void Main(string[] args)
        {
            int opcion = 0;
            do
            {
                //while (true)
                //{

                Console.WriteLine("Dime una opcion del menu 1-4");
                opcion = transformacion(Console.ReadLine());
                //if (opcion != 0)
                //{
                //    break;
                //}
                //Console.WriteLine("Error al intrdocir los datos");
                //}

                switch (opcion)
                {
                    case 1:
                        int year;
                        //int year2;

                        //while (true)
                        //{
                        Console.WriteLine("Dime un año");
                        year = transformacion(Console.ReadLine());
                        //year2 = comprobacionPos1(year);
                        //if (year2 != 0)
                        //{
                        //    break;
                        //}
                        //Console.WriteLine("Error al intrdocir los datos");
                        //}

                        bool resultado = bisiesto(year);
                        if (resultado)
                        {
                            Console.WriteLine("Es bisiesto");
                        }
                        else
                        {
                            Console.WriteLine("No es bisiesto");
                        }

                        if (opcion == 3)
                        {
                            goto case 2;
                        }
                        else
                        {
                            break;
                        }

                    case 2:
                        int num1;
                        //int aux1;
                        int num2;
                        //int aux2;

                        //while (true)
                        //{
                        Console.WriteLine("Dime un numero");
                        num1 = transformacion(Console.ReadLine());
                        //aux1 = comprobacionPos1(num1);

                        Console.WriteLine("Dime un segundo numero");
                        num2 = transformacion(Console.ReadLine());
                        //aux2 = comprobacionPos1(num2);
                        //if (aux1 != 0 && aux2 != 0)
                        //{
                        //    break;
                        //}
                        //Console.WriteLine("Error al intrdocir uno de los datos");
                        //}

                        int? result = sumaRango(num1, num2);

                        if (result == null)
                        {
                            Console.WriteLine("Error, metiste el primer numero mayor al segundo");
                        }
                        else
                        {
                            Console.WriteLine("Resultado: " + result);
                        }
                        break;

                    case 3://Ir deirectamente al 1 y luego al 2
                        //int op = 0;
                        //while (true)
                        //{

                        //    Console.WriteLine("Dime la opcion a la que quieres volver, 1-2");
                        //    op = transformacion(Console.ReadLine());
                        //    if (op != 0)
                        //    {
                        //        break;
                        //    }
                        //    Console.WriteLine("Error al intrdocir los datos");
                        //}

                        //if (op == 1)
                        //{
                        //    goto case 1;
                        //}
                        //else if (op == 2)
                        //{
                        //    goto case 2;
                        //}
                        //else
                        //{
                        //    Console.WriteLine("Opcion no valida, volviendo al menu original");
                        //}

                        goto case 1;

                    //break;

                    case 4:
                        Console.WriteLine("Saliendo...");
                        break;

                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }

            } while (opcion != 4);
        }
    }
}
