using System;

namespace Ejercicio10_3
{
    public class Poligono
    {
        private int Lados;
        private int Distancia;

          public Poligono()
        {
            Lados = 0;
            Distancia = 0;
        }

        public Poligono(int lados, int distancia)
        {
            this.Lados = lados;
            this.Distancia = distancia;
        }
        public int lados
        {
            get
            {
                return Lados;
            }
            set
            {
                if (value >= 3)
                    Lados = value;
                else
                    Lados = 0;
            }
        }

        public int distancia
        {
            get
            {
                return Distancia;
            }
            set
            {
                if (value > 0)
                    Distancia = value;
                else
                    Distancia = 0;
            }
        }
      

        public override string ToString()
        {
            String mensaje = "";
            mensaje += "Los lados del poligono son " + Lados.ToString() +
                        " y su distancia es " + Distancia.ToString();
            return mensaje;
        }
    }

    public class Program{
        public static void ingresarPoligono(){
            int lados;
            int distancia;

            Console.WriteLine("ingrese los lados");
            lados = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese la distancia");
            distancia =  Convert.ToInt32(Console.ReadLine());

            Poligono poligono = new Poligono(lados,distancia);

            poligono.ToString();

        }
    }
}