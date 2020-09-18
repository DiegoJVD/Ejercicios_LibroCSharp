using System;

namespace Tarea_2 {
    class SubMenu {
        public static void main1() {

            int opcion;
            do{
                Console.Clear();
                Console.WriteLine("MENU");
                Console.WriteLine("0. Salir");
                Console.WriteLine("1. Ejercicio 4.1 Tabla ");
                Console.WriteLine("2. Ejercicio 4.2 Potenciacion");
                Console.WriteLine("3. Ejercicio 4.5 Promedio de edad");
                Console.WriteLine("4. Ejercicio 5.4 Factorial");
                Console.WriteLine("5. Ejercicio 5.5 Numeros a letras");
                Console.Write(" / n Elija una opcion : ");

                opcion = Convert.ToInt32(Console.ReadLine());

              

                switch(opcion){
                    case 0: 
                        break;
                    case 1: 
                        Ejercicio4_1.Program.tabla();
                        break;
                    case 2:
                        Ejercicio4_2.Program.potenciacion();
                        break;
                    case 3: 
                        Ejercicio4_5.Program.promedioEdad();
                        break;
                    case 4:
                        Ejercicio5_4.Program.factorial();
                        break;
                    case 5:
                        Ejercicio5_5.Program.Numeros_Letras();
                        break;
                    default:
                        break;
                }

                Console.ReadLine();
            }while(opcion != 0);
        }
    }
}