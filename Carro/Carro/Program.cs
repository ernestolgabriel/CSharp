using System;

namespace Carro
{
    class Carro
    {
        private int ruedas;
        private double largo, ancho;
        private bool aireAcondicionado;
        private string tapizado;

        public Carro() //contructor, estado inicial de la clase Carro
        {
            ruedas = 4;
            largo = 2300.5;
            ancho = 0.800;
        }

        public int getRUEDAS()
        {
            return ruedas;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Carro nuevoCarro = new Carro(); //Estado inicial de nuestro objeto Carro
            Carro otroCarro = new Carro();  //Otra instancia de la clase Carro

            otroCarro.getRUEDAS();
            Console.WriteLine("Hello World!");
        }
    }
}
