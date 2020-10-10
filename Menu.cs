using System;

namespace Ejercicios_LibroCSharp
{
    class Menu
    {
        static void Main(string[] args)
        {
            
            int opcion ;
            do
            {
                Console.Clear();
                Console.Write("Elija una opcion: \n");
                Console.WriteLine("0) Salir");
                Console.WriteLine("1) Ejercicios de la tarea 1");
                Console.WriteLine("2) Ejercicios de la tarea 2");
                Console.WriteLine("3) Ejercicios de la tarea 3");
                Console.WriteLine("4) Ejercicios de la tarea 4");
                
                

                opcion = Convert.ToInt32(Console.ReadLine());


                switch (opcion)
                {
                    case 1:
                        Tarea_1.SubMenu.main1();
                        break;
                    case 2:
                        Tarea_2.SubMenu.main1();
                        break;
                    case 3:
                        Tarea_3.SubMenu.main1();
                        break;
                    case 4:
                        Tarea_4.SubMenu.main1();
                        break;
                     case 5:
                        Tarea_5.SubMenu.main1();
                        break;
                }

                Console.ReadLine();

            } while (opcion != 0);
        }
    }
}
