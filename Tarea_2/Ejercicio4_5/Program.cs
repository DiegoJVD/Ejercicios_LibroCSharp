using System;

namespace Ejercicio4_5
{
    class Program
    {
        public static void promedioEdad()
        {
            int numeroDePersonas;
            int edad;
            int mayor = 0;
            int menor = 100;
            int acumulado = 0;

            Console.WriteLine("Digite el numero de edades que quiere ingresar ");
            numeroDePersonas = Convert.ToInt32(Console.ReadLine());


            for(int i = 0; i< numeroDePersonas ; i++){
                
                Console.WriteLine("Digite una edad ");
                edad = Convert.ToInt32(Console.ReadLine());

                if(edad > mayor){
                    mayor = edad;
                }
                if(edad < menor){
                    menor = edad;
                }
                acumulado += edad;
                
            }

            Console.WriteLine("El promedio de edad es "+(acumulado/numeroDePersonas));

        }   
    }
}
