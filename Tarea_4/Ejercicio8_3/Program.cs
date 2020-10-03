using System;
using System.Collections;

namespace Ejercicio8_3
{
    class Program
    {
        public static void Fecha()
        {
            DateTime fecha = DateTime.Now;
            Console.WriteLine("{0:hh:mm tt - yyyy/dd/mm}", fecha);
        }
    }
}