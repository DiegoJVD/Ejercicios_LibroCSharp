using System;

namespace Ejercicio2_4
{
    class Program
    {
        static double centigradosAFahrenheit(double centigrados)
        {
            double fahrenheit;
            fahrenheit = (centigrados * 1.8) + 32;

            return fahrenheit;
        }

        static void Main(string[] args)
        {
            double centigrados;
            
            Console.WriteLine("Escriba los centigrados que quiere convertir a fahrenheit ");
            centigrados = double.Parse(Console.ReadLine());
            Console.WriteLine(centigrados + " grados centigrados a fahrenheit es : "+centigradosAFahrenheit(centigrados));
        }
    }
}
