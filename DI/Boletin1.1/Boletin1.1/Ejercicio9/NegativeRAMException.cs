using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    internal class NegativeRAMException : Exception
    {
        public NegativeRAMException()
        {
            Console.WriteLine("Error con la memoria");
        }
    }
}
