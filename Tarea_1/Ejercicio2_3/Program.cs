using System;

namespace Ejercicio2_3
{
    class Program
    {
        static double obtenerGrados_Radianes(double grados)
        {
            double radianes;
            radianes = grados * 0.0174533;

            return radianes;
        }

        public static void grados_Radianes()
        {
            double grados;
            
            Console.WriteLine("Escriba los grados que quiere convertir a radianes ");
            grados = double.Parse(Console.ReadLine());
            Console.WriteLine(grados + " grados En radianes es : "+obtenerGrados_Radianes(grados));
        }
    }
}
