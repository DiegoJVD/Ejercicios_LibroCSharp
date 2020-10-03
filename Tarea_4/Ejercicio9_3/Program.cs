using System;
using System.Collections;

namespace Ejercicio9_3
{
    class Program
    {
        public struct Dueno
        {
            string nombre;
            string sexo;
            int edad;
            public Dueno(string nombre, string sexo, int edad)
            {
                this.nombre = nombre;
                this.sexo = sexo;
                this.edad = edad;
            }

            public override string ToString()
            {
                return "Nombre: " + nombre + "\n sexo: " + sexo + "\n edad:"+ edad;
            }
        }

        public struct Mascota
        {
            string nombre;
            string sexo;
            Dueno dueno;

            public Mascota(string nombre, string sexo, Dueno dueno)
            {
                this.nombre = nombre;
                this.sexo = sexo;
                this.dueno = dueno;
            }

            public override string ToString()
            {
                return "Nombre: " + nombre + "\nEspecie: " + sexo + "\n dueño "+ dueno;
            }
        }
        public static void duenoMascota()
        {
            string nombreDueno;
            string nombremascota;
            string sexoDueno;
            string sexoMascota;
            int edad;
            Dueno dueno;
            Mascota mascota;
            
            Console.WriteLine("Escriba el nombre de el dueño ");
            nombreDueno = Console.ReadLine();
            Console.WriteLine("Escriba el sexo de el dueño ");
            sexoDueno = Console.ReadLine();
            Console.WriteLine("Escriba la edad de el dueño ");
            edad = Convert.ToInt32(Console.ReadLine()); 

            dueno = new Dueno(nombreDueno,sexoDueno,edad);

            Console.WriteLine("Escriba el nombre de la mascota");
            nombremascota = Console.ReadLine();
            Console.WriteLine("Escriba el sexo de la mascota");
            sexoMascota = Console.ReadLine();

            mascota = new Mascota(nombremascota,sexoMascota,dueno);

            Console.WriteLine("");

            dueno.ToString();
            mascota.ToString();


        }
    }
}