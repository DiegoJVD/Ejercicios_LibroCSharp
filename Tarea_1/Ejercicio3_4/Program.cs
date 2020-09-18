using System;

namespace Ejercicio3_4
{
    class Program
    {
        static string diasDeSemana(int num)
        {
        string dia = "";
            switch(num)
            {
                case 1: 
                    dia = "Domingo";
                    break;
                case 2:
                    dia = "Lunes";
                    break;
                case 3: 
                    dia = "Martes";
                    break;
                case 4:
                    dia = "Miercoles";
                    break;
                case 5: 
                    dia = "Jueves";
                    break;
                case 6:
                    dia = "Viernes";
                    break;
                case 7:
                    dia = "sabado";
                    break;
                default: 
                    dia = "numero no valido";
                    break;
            }

            return dia;
        }
        public static void DiasDeSemana()
        {
            int num;

            Console.WriteLine("escriba un numero del 1 al 7");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine(diasDeSemana(num));
        }
    }
}
