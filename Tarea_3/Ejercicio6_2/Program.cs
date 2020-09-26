using System;


namespace Ejercicio6_2
{
    class Program
    {

       public static void Jagged2()
        {
            int cantidad = 0; // Cantidad de alumnos
            int salones = 0; // Cantidad de salones
            int n = 0; // Variable de control de ciclo salones
            int m = 0; // Variable de control del ciclo alumnos

            // Variables para el promedio
            float suma = 0.0f;
            float promedio = 0.0f;
            float minima = 10.0f;
            float maxima = 0.0f; 
                           

            Console.WriteLine("Dame la cantidad de salones");
            salones = Convert.ToInt32(Console.ReadLine());

            int[][] calif = new int[salones][];
            // Pedimos los alumnos por salon
            for (n = 0; n < salones; n++) 
            {
                Console.WriteLine("Dame la cantidad de alumnos para el salon "+ n);
                cantidad = Convert.ToInt32(Console.ReadLine());
                calif[n] = new int[cantidad];
            }

            for (n = 0; n < salones; n++) // Ciclo salones
            {
                Console.WriteLine("Salon "+n);
                for (m = 0; m < calif[n].GetLength(0); m++) // Ciclo alumnos
                {
                    Console.Write("Dame la calificación ");
                    calif[n] [m] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("—— Información ——");
            for (n = 0; n < salones; n++)
            {
                Console.WriteLine("Salon" +n);
                for (m = 0; m < calif[n].GetLength(0); m++) // Ciclo alumnos
                {
                    Console.WriteLine("El alumno"+ m +"tiene "+ calif[n][m]);
                }



            }

            //promedio 
             Console.WriteLine("—— Promedio ——");
            for (n = 0; n < salones; n++)
            {
                Console.WriteLine("Salon { 0}", n);
                for (m = 0; m < calif[n].GetLength(0); m++) // Ciclo alumnos
                {
                    suma += calif[n][m];
                    if(calif[n][m] < minima){
                        minima = calif[n][m];
                    }
                }
                promedio = suma/calif[n].GetLength(0);

                Console.WriteLine("El promedio de el curso"+n+ "es" + promedio);
                Console.WriteLine("la  nota mas baja de el curso"+n+ "es" + minima);




            }
            
        }
    }
}