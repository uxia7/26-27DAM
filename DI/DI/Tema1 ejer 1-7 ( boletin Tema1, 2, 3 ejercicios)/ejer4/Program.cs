using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ejer4
{
    internal class Program
    {

        static bool Bisiesto(int año)//TODO Revisar
        {
            return (año % 4 == 0 && año % 100 != 0) || (año % 400 == 0);
            //al final es mejor devolver directamente este tipo de cosas, porque al hacer un if estas diciendo que si esta operacion se cumple (o sea es true) si no es false
            //va a devolver true si la operacion es correcta, es que es una redundancia hacer lo del if
        }

        static int? SumaRangos(int num1, int num2) //lo del ? es para que a parte de los enteros tambien permita que se devuelvan nulos
        {
            int acu = 0;

            if (num1 > num2)
            {
                return null;
            }
            else
            {
                for (int i = num1; i <= num2; i++)
                {
                    //no es lo mismo hacer acu = acu + i; que sumandole num1
                    acu = acu + i;
                }
                return acu;
            }
        }

        //tenemos que hacer una funcion para la comprobacion ya que se pide que se evite repetir codigo
        static int Comprobacion(int num)
        {
            while (num > 10000 && num < 0)
            {
                Console.WriteLine("Tu numero no está entre los rangos correctos, vuelve a introducirlo");
                num = Convert.ToInt32(Console.ReadLine());
            }
            return num;
        }
        static void Main(string[] args)
        {
            int opcion;

            do//TODO bucle infinito
            {
                Console.WriteLine("Opciones de menu: \n1)Año bisiesto \n2)Suma de rangos \n3)Todas las opciones \n4)Salir");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        int año;

                        Console.WriteLine("Dime un año entre 0 y menor que 10000");
                        año = Comprobacion(Convert.ToInt32(Console.ReadLine()));
                        //es mejor hacer esto directamente porque lo otro esta muy mal hecho
                        //asi ya compruebas directamente lo que te da el usuario y no gastas en mas lineas de codigo adicional

                        //año = Convert.ToInt32(Console.ReadLine());
                        //Comprobacion(año);


                        if (Bisiesto(año))
                        {
                            Console.WriteLine("El año es bisiesto: " + año);
                        }
                        else
                        {
                            Console.WriteLine("No es bisiesto: " + año);
                        }

                        Console.WriteLine("Vas a volver al menu principal");

                        //if con goto
                        if (opcion == 3)
                        {
                            goto case 2;
                        }

                        break; // el break es obligatorio

                    case 2:

                        int num1;
                        int num2;

                        Console.WriteLine("Dime un primer numero entre 0 pero menor que 10000");
                        num1 = Comprobacion(Convert.ToInt32(Console.ReadLine()));
                        //como dije en el case 1, es mejor hacerlo de forma directa, lo otro es una tonteria como un mundo
                        
                        //num1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Dime un segundo numero entre 0 pero menor que 10000");// TODO mejorar la funcion de peticion de datos
                        num2 = Comprobacion(Convert.ToInt32(Console.ReadLine()));

                        //num2 = Convert.ToInt32(Console.ReadLine());

                        //Comprobacion(num1);
                        //Comprobacion(num2);

                        if (SumaRangos(num1, num2) == null)
                        {
                            Console.WriteLine("Has metido el primer numero mas grande que el segundo");
                        }
                        else
                        {
                            Console.WriteLine("Este es tu resultado de la suma del primero hasta el segundo numero: " + SumaRangos(num1, num2));
                        }
                        SumaRangos(1, 2);
                        break;

                    case 3:
                        goto case 1;

                    case 4:
                        Console.WriteLine("Saliendo...");
                        break;

                    default:
                        Console.WriteLine("Numero fuera de rango pedido");
                        break;
                }

            }
            while (opcion != 4);
        }
    }
}
