using System;

namespace Ejercicio5_4
{
    class Program
    {

        static int factorial(int numero){
            if(numero == 0){
                return 0;
            }
            else if(numero == 1){
                return 1;
            }
            else if(numero >= 2 ){
                return factorial(numero-1)* numero;
            }

            return 0;// if i dont write this line the program give a error
            
        }
        public static void factorial()
        {
            int numero;
            Console.WriteLine("digite un numero");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(factorial(numero));
            

        }   
    }
}
