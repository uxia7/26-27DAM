using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    internal class Ordenador
    {
        //private string nombre;
        public string Nombre { set; get; }

        private int memoria;
        public int Memoria
        {
            set
            {
                if(value <= 0)
                {
                    throw new NegativeRAMException();
                }
                else
                {
                    this.memoria = value;
                }
            }

            get
            {
                return memoria;
            }
        }


        public Ordenador(string nombre, int memoria)
        {
            this.Nombre = nombre;
            this.Memoria = memoria;
        }

        public static bool comprobacionIp(string ipComprobar)
        {
            string[] trozos = ipComprobar.Split('.');

            if (trozos.Length != 4)
            {

                return false;
            }

            foreach (string parte in trozos)
            {
                if (!int.TryParse(parte, out int num))
                {//ver lo de byte.TryParse()

                    return false;
                }

                if (num < 0 || num > 255)
                {

                    return false;
                }
            }

            return true;
        }
    }
}
