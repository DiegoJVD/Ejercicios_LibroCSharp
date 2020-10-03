using System;
using System.Collections;

namespace Ejercicio9_4
{
    class Program
    {
          enum Neumatico
        {
            Verano, Invierno, Normales, Asimétricos, Direccionales, antipinchazos, SinAire
        };
        public static void Fecha()
        {

            Neumatico respuesta;

            Console.WriteLine("Elija que neumatico desea");
            Console.WriteLine("1) de verano ");
            Console.WriteLine("2) de invierno ");
            Console.WriteLine("1) de normales ");
            Console.WriteLine("1) de asimétricos ");
            Console.WriteLine("1) de direccionales ");
            Console.WriteLine("1) de antipinchazos ");
            Console.WriteLine("1) de sin aire ");

            respuesta = (Neumatico)Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("los neumaticos que elijio fue {0}", respuesta);
            
        }
    }
}