using System;
using System.Collections;

namespace Ejercicio7_5
{
    class Program
    {
        public static void tablaHash2()
        {
            int opcion;
            int numero;
            string nombre;
            Hashtable agendaTelefonica = new Hashtable();
            do
            {
                Console.WriteLine("Elija una opcion");
                Console.WriteLine("1) ver la agenda");
                Console.WriteLine("2) agregar contacto");
                Console.WriteLine("0) salir");

                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        foreach (DictionaryEntry c in agendaTelefonica)
                            Console.WriteLine("Nombre :"+ c.Key + "Numero " + c.Value);
                        break;
                    case 2:
                        Console.WriteLine("dijite el nombre");
                        nombre = Console.ReadLine();
                        Console.WriteLine("dijite el numero");
                        numero = Convert.ToInt32(Console.ReadLine());
                        agendaTelefonica.Add(numero, nombre);
                        break;
                }
            } while (opcion != 0);
        }
    }
}