using System;

namespace Ejercicio2_3
{
    class Program
    {
        static double GradosARadianes(double grados)
        {
            double radianes;
            radianes = grados * 0.0174533;

            return radianes;
        }

        static void Main(string[] args)
        {
            double grados;
            
            Console.WriteLine("Escriba los grados que quiere convertir a radianes ");
            grados = double.Parse(Console.ReadLine());
            Console.WriteLine(grados + " grados En radianes es : "+GradosARadianes(grados));
        }
    }
}
