using System;
using System.Collections;

namespace Ejercicio8_5
{
    class Program
    {
         public static void CompararCadena()
        {
             string cad1 = "";
            string cad2 = "";

            Console.WriteLine("Inserte una cadena");
            cad1 = Console.ReadLine();

            Console.WriteLine("Inserte otra cadena");
            cad2 = Console.ReadLine();

            if (string.Compare(cad1, cad2) < 0){
                Console.WriteLine(cad1);
                Console.WriteLine("");
                Console.WriteLine(cad2);
            }  
            else{
                Console.WriteLine(cad2);
                Console.WriteLine("");
                Console.WriteLine(cad1);
            }
        }
       
    }
}