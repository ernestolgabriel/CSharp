using System;

namespace PracticaCursoCSharp
{
    class Program
    {
        class Carro
        {
            private int ruedas;

            private double ancho, largo;

            private bool aire_acondicionado;

            private string tapizado;

            //constructor

            public Carro()
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

            public int Ruedas()
            {
                return ruedas;
            }

            public string InformacionCarro()
            {
                return "Información del Carro-> ruedas: " + ruedas + " largo del carro: " + largo + " ancho del carro:" + ancho;
            }
        }
        static void Main(string[] args)
        {
            Carro nuevocarro = new Carro();

            Carro nuevocarro2 = new Carro();

            Carro carro1=new
            Console.WriteLine(nuevocarro2.InformacionCarro());

            Console.WriteLine(nuevocarro.Ruedas());
        }
    }
}
