using System;

namespace Ejercicio2_5
{
    class Program
    {
        static double dolaresaEuros(double dolares, double tasa)
        {
            double euros;
            euros = dolares*tasa;

            return euros;
        }

        static void Main(string[] args)
        {
            double dolares;
            double tasa;
            
            Console.WriteLine("Escriba los dolares a cambiar a euros ");
            dolares = double.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el equivalente de 1 dolar en euro ");
            tasa = double.Parse(Console.ReadLine());

            Console.WriteLine(dolares + " dolares  a euros son  : "+dolaresaEuros(dolares,tasa) + "Euros");
        }
    }
}
