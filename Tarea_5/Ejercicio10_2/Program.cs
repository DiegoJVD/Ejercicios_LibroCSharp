using System;
using System.Collections;


namespace Ejercicio10_2
{
    public  class Estudiante
    {
        string nombre;
        string apellido;
        int edad;
        int cantidadMaterias;
        String curso;

        public Estudiante(string nombre, string apellido, int edad, int cantidadMaterias, string curso){
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.cantidadMaterias = cantidadMaterias;
            this.curso = curso;
        }

       
            

        }

        
    

      public class Program{
            
            public static void EstudianteEscuela(){
                
                string nombre, apellido, curso;
                int edad, cantidadMaterias;
                Console.WriteLine("ingrese el nombre de el estudiante");
                nombre = Console.ReadLine();
                Console.WriteLine("ingrese el apellido de el estudiante");
                apellido = Console.ReadLine();
                Console.WriteLine("ingrese la edad de el estudiante");
                edad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ingrese la cantidad de materias de el estudiante");
                cantidadMaterias = Convert.ToInt32( Console.ReadLine());
                Console.WriteLine("ingrese el curso de el estudiante");
                curso = Console.ReadLine();

                Estudiante estudiante = new Estudiante(nombre,apellido,edad,cantidadMaterias,curso);
                
                estudiante.ToString();
            }
        }
}