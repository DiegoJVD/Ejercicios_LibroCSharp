using System;

namespace Tarea_5 {
    class SubMenu{
        public static void main1() {

            int opcion;
            do{
                Console.Clear();
                Console.Write("Elija una opcion : \n");
                Console.WriteLine("0) Salir");
                Console.WriteLine("1) Capitulo 10 ejercicio 2: ");
                Console.WriteLine("2) Capitulo 10 ejercicio 3-4-5: ");
                

                opcion = Convert.ToInt32(Console.ReadLine());

              

                switch(opcion){
                    case 0: 
                        break;
                    case 1: 
                        Ejercicio10_2.Program.EstudianteEscuela();
                        break;
                    case 2:
                        Ejercicio10_3.Program.ingresarPoligono();
                        break;
                    default:
                        break;
                }

                Console.ReadLine();
            }while(opcion != 0);
        }
    }
}