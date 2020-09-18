using System;

namespace Ejercicio4_2
{
    class Program
    {
        public static void potenciacion()
        {
            int numero;
            int potencia;
            int resultado;

            Console.WriteLine("digite un numero");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("digite la potencia");
            potencia = Convert.ToInt32(Console.ReadLine());

            resultado = numero;


            for(int i = 1; i< potencia ; i++){
                resultado *=  numero;
                
            }

            Console.WriteLine("el numero "+ numero+" elevado "+ potencia+" veces  es igual a " + resultado);

        }   
    }
}
