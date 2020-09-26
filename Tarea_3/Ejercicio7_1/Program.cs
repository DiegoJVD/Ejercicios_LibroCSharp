using System;
using System.Collections;

namespace Ejercicio7_1
{


    public class Program
    {
         public static float Promedio(ArrayList cal)
        {
            int suma = 0;
            float promedio = 0;
            for (int n = 0; n < cal.Count; n++)
                suma += Convert.ToInt32(cal[n]);

            promedio = suma / cal.Count;

            return promedio;
        }

          public static int Menor(ArrayList cal)
        {
            int minima;
            minima = Convert.ToInt32(cal[0]);
            for (int n = 0; n < cal.Count; n++)
            {
                if (Convert.ToSingle(cal[n]) < minima)
                    minima = Convert.ToInt32(cal[n]);

            }

            return minima;
        }

         public static int Mayor(ArrayList cal)
        {
            int mayor;
            mayor = Convert.ToInt32(cal[0]);
            for (int n = 0; n < cal.Count; n++)
            {
                if (Convert.ToInt32(cal[n]) > mayor)
                    mayor = Convert.ToInt32(cal[n]);

            }

            return mayor;
        }
        public static void arrayllist()
        {
            float promedio = 0.0f;
            float minima = 0.0f;
            float mayor = 0.0f;
            ArrayList calificaciones = new ArrayList();

            Console.WriteLine("Digite la cantidad de alumnos: ");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            for (int n = 0; n < cantidad; n++)
            {
                Console.Write("Digite la calificación: ");
                calificaciones.Add(Convert.ToSingle(Console.ReadLine()));

            }

            promedio = Promedio(calificaciones);
            minima = Menor(calificaciones);
            mayor = Mayor(calificaciones);
            Console.WriteLine($"La nota minima es: {minima}");
            Console.WriteLine($"La nota maxima es: {mayor}");
            Console.WriteLine($"El promedio es: {promedio}");
        }
    }

}