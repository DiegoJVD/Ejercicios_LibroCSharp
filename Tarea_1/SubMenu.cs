using System;

namespace Tarea_1 {
    class SubMenu {
        public static int option;
   

        public static void main1() {
            do{
                Console.Clear();
                Console.Write("Elija una opcion : \n");
                Console.WriteLine("0) Salir");
                Console.WriteLine("1) Capitulo 1 ejercicio 1: Hola Diego");
                Console.WriteLine("2) Capitulo 1 ejercicio 5: Informacion");
                Console.WriteLine("3) Capitulo 2 ejercicio 1: Perimetro");
                Console.WriteLine("4) Capitulo 2 ejercicio 3: Grados a radianes");
                Console.WriteLine("5) Capitulo 2 ejercicio 4: Centigrados a Fahrenheit");
                Console.WriteLine("6) Capitulo 2 ejercicio 5: USD a EUR");
                Console.WriteLine("7) Capitulo 3 ejercicio 1: Par o impar ");
                Console.WriteLine("8) Capitulo 3 ejercicio 4: Dias de la semana");
                Console.Write("\n  Opcion: ");

                option = Convert.ToInt32(Console.ReadLine());

              

                switch(option){
                    case 0: return;
                    case 1: 
                        Ejercicio1_1.Program.myName();
                        break;
                    case 2:
                        Ejercicio1_5.Program.myInfo();
                        break;
                    case 3: 
                        Ejercicio2_1.Program.perimetro();
                        break;
                    case 4:
                        Ejercicio2_3.Program.grados_Radianes();
                        break;
                    case 5:
                        Ejercicio2_4.Program.centigrados_fahrenheit();
                        break;
                    case 6:
                        Ejercicio2_5.Program.dolar_Euro();
                        break;
                    case 7:
                        Ejercicio3_1.Program.par_Impar();
                        break;
                    case 8:
                        Ejercicio3_4.Program.DiasDeSemana();
                        break;
                }

                Console.ReadKey(true);

            }while(option != 3);
        }
    }
}