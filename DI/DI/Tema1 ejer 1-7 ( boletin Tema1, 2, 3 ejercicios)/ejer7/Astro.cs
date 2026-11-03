using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ejer7
{
    public abstract class Astro
    {//para establecer una clase abstracta lo que tenemos que hacer es quitar la palabra internal y le ponemos abstract

        //asi es como se establecen las propiedades
        private String nombre;

        public String Nombre
        {//tiene que guardarlo en mayus y devolverlo entre comillas
            set
            {
                //nombre = value;
                this.nombre = value.ToUpper();
            }

            get
            {
                return "\"" + nombre + "\"";
                //tenemos que ascostumbrarnos a que no se pueden poner parentesis asi como asi, es mejor que lo pongamos directamente porque estas cosas ya hay que verlas directas
            }
        }

        private double radio;
        public double Radio
        {
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Este radio es negativo, con lo cual es invalido");
                    
                }
                else
                {
                    radio = value;
                }
            }

            get
            {
                return radio;
            }
        }



        public Astro(String nombre, double radio)
        {
            //las propiedades privadas tienen que hacer como siempre, this.nombre = nombre y tal, son las publicas las que tienen lo de value
            this.Nombre = nombre;
            this.Radio = radio;
        }

        public Astro() : this("Tierra", 6378)
        {
            //this.nombre = "Tierra";
            //this.radio = 6378;
            //no hace falta hacer esto si ya tengo un constructor creado arriba y puedo llamarlo a el y usarlo embezde ocupar mas lineas de codigo
        }

        public override bool Equals(Object obj)
        {
            //GetType es lo mismo que la funcion de getClass de Java y typeof es lo mismo que String.class de java
            //if (!(obj.GetType() == typeof(Astro)))
            //{
            //    Console.WriteLine("El tipo del objeto no es el correcto, no es de tipo Astro");
            //    return false;
            //}
            //else
            //{
                return (obj is Astro && (((Astro)obj).Nombre).Equals(this.Nombre)) || ((obj.GetType() == typeof(String)) && (String)obj == ((Astro)obj).Nombre);
                //en esta comprobacion en la parte de astro hay que usar el is porque tambien nos interesan que sean las clases que heredan de esta no solo Astro
            //}
        }
    }
}
