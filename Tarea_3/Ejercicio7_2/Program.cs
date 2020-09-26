using System;
using System.Collections;


namespace Ejercicio7_2
{
    class Program
    {
        public static void tablaHash()
        {
            Hashtable diccionario = new Hashtable();
            diccionario.Add("a cappella", " Sin acompañamiento musical: cantar a cappella.");
            diccionario.Add("buscar ", " accion de buscar : siembre busco a mi hijo al colegio.");
            diccionario.Add("cazar ", " accion de cazar : el hombre cazo un antilope.");
            diccionario.Add("dar", " trasparar o donar : le voy a dar un  lapiz a mi amigo .");
            diccionario.Add("elevar ", " Levantar o alzar una cosa.");
            diccionario.Add("faltar", " no acudir a una cita u obligacion.");




            foreach (DictionaryEntry w in diccionario)
                Console.WriteLine(w.Key + ": " + w.Value);


        }
    }
}