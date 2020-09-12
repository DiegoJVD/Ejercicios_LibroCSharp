using System;

namespace Ejercicio3_1
{
    class Program
    {
        static Boolean parOImpar(int num)
        {
            if(num %2 == 0){
                return true;
            }
            else{
                return false;
            }
        }

        static void Main(string[] args)
        {
            int num;
            
            Console.WriteLine("Escriba un numero ");
            num = int.Parse(Console.ReadLine());

            if(parOImpar(num)){
                Console.WriteLine(num+" es par ");
            }
            else{
                Console.WriteLine(num+" es impar ");
            }

            
        }
    }
}
