using System;

namespace Tarea_3 {
    class SubMenu {
        public static void main1() {

            int opcion;
            do{
                Console.Clear();
                Console.Write("Elija una opcion : \n");
                Console.WriteLine("0) Salir");
                Console.WriteLine("1) Capitulo 6 ejercicio 1:  ");
                Console.WriteLine("2) Capitulo 6 ejercicio 2: ");
                Console.WriteLine("3) Capitulo 6 ejercicio 3: ");
                Console.WriteLine("4) capitulo 6 ejercicio 4: ");
                Console.WriteLine("5) capitulo 6 ejercicio 5: ");
                Console.WriteLine("6) capitulo 7 ejercicio 1: ");
                Console.WriteLine("7) capitulo 7 ejercicio 2: ");
                Console.WriteLine("8) capitulo 7 ejercicio 5: ");
                

                opcion = Convert.ToInt32(Console.ReadLine());

              

                switch(opcion){
                    case 0: 
                        break;
                    case 1: 
                        Ejercicio6_1.Program.Jagged();
                        break;
                    case 2:
                        Ejercicio6_2.Program.Jagged2();
                        break;
                    case 3: 
                        Ejercicio6_3.Program.Jagged3();
                        break;
                    case 4:
                        Ejercicio6_4.Program.Jagged4();
                        break;
                    case 5:
                        Ejercicio6_5.Program.Jagged5();
                        break;
                    case 6:
                        Ejercicio7_1.Program.arrayllist();
                        break;
                    case 7:
                        Ejercicio7_2.Program.tablaHash();
                        break;
                    case 8:
                        Ejercicio7_5.Program.tablaHash2();
                        break;
                    default:
                        break;
                }

                Console.ReadLine();
            }while(opcion != 0);
        }
    }
}