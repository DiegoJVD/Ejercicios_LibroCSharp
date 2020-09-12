using System;

namespace Ejercicio2_1
{
    class Program
    {
        static float obtenerPerimetro(int numeroLados, float medidaLado)
        {
            float perimetro;
            perimetro = numeroLados * medidaLado;

            return perimetro;
        }

        static void Main(string[] args)
        {
            int numeroLados;
            float medidaLado;
            
            Console.WriteLine("Escriba el numero de lados del poligono regular ");
            numeroLados = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba la medida de un lado del poligono regular ");
            medidaLado = float.Parse(Console.ReadLine());
            Console.WriteLine("El perimetro es: "+ obtenerPerimetro(numeroLados, medidaLado));
        }
    }
}
