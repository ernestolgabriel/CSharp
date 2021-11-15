using System;

namespace claseEjemplo1
{
    class Circulo
    {
        //Atributos
        private double x, y;
        private double radio;

        //Metodos
        public Circulo() { }
        public Circulo(double ex, double cy, double r)
        {
            x = ex;
            y = cy;
            if (r < 0)
                r = -r;
            radio = r;
        }
        public double LongCircunferencia()
        {
            return 2 * Math.PI * radio;
        }
        public double AreaCirculo()
        {
            return Math.PI * radio * radio;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double rad, result; 
            //Se crea el obj1 a partir de valores 5, 2, 10
            //estos valores representan el centro del circulo (x,y) y el radio
            Circulo obj1 = new Circulo(5, 2, 10);
            Circulo obj2 = new Circulo();

            
            Console.WriteLine("Introduce un valor para calcular el radio del circulo");
            

            //Como calcularias la longitud de la circunferencia y area del circulo?
            //Como visualizarias el resultado de los calculos anteriores?

            Console.ReadKey(true);
        }
    }
}