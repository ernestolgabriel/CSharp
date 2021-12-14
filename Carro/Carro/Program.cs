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

        public Carro(double largo, double ancho)
        {
            ruedas = 4;
            this.largo = largo;
            this.ancho = ancho;
        }

        public string getInfoCarro()
        {
            return "Información del carro;\n Ruedas: " + ruedas + " Largo: " + largo + " Ancho: " + ancho;
        }

        public void setExtras(bool aire, string tapi)
        {
            aireAcondicionado = aire;
            tapizado = tapi;
        }

        public string getExtras()
        {
            return "Extras del carro:\n Tapiceria: " + tapizado + " Aire Acondicionado: " + aireAcondicionado;
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
            Carro otroCarro = new Carro(4500.25, 1200.35);  //Otra instancia de la clase Carro

            //otroCarro.getRUEDAS();
            Console.WriteLine(otroCarro.getInfoCarro());
        }
    }
}
