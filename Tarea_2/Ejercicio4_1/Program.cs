using System;

namespace Ejercicio4_1
{
    class Program
    {
        public static void tabla()
        {
            int numero;
            Console.WriteLine("digite un numero");
            numero = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i<= numero; i++){
                Console.WriteLine(numero+" * "+i+" = "+ i*numero);
            }

        }   
    }
}
