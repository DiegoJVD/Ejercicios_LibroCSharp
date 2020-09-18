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
                Console.WriteLine("MENU");
                Console.WriteLine("1. Tarea 1");
                Console.WriteLine("2. Tarea 2");
                Console.WriteLine("0. Salir");
                Console.Write("Elija una opcion: ");

                opcion = Convert.ToInt32(Console.ReadLine());


                switch (opcion)
                {
                    case 1:
                        Tarea_1.SubMenu.main1();
                        break;
                    case 2:
                        Tarea_2.SubMenu.main1();
                        break;
                }

                Console.ReadLine();

            } while (opcion != 0);
        }
    }
}
