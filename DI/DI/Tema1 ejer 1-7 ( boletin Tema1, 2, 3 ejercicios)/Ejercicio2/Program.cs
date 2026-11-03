using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            String nombre;
            int edad;
            double peso;

            Console.WriteLine("Dime tu nombre");
            nombre = Console.ReadLine();

            Console.WriteLine("Dime tu edad");
            edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Dime tu peso");
            peso = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Nombre:{0,12}, Edad:{1,4} \n \t Peso:{2,5:.0} \n \"{0}\", \\{1}\\", nombre, edad, peso);
            //o F1 para los decimales F y numero de decimales
        }
    }
}
