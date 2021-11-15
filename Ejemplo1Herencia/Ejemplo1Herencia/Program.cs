using System;

namespace Ejemplo1Herencia
{
    class Operacion
    {
        private int valor1 = 0, valor2=0, resultado;
        
        protected int Valor1    //Propiedad de Valor1
        {
            get { return valor1; }

            set { valor1 = value;}
        }

        protected int Valor2    //Propiedad de Valor2
        {
            get { return valor2; }

            set { valor2 = value; }
        }

        protected int Resultado //Propiedad de Resultado
        {
            get { return resultado; }

            set { resultado = value; }
        }
            
    }

    class Suma:Operacion
    {
        public void OperacionSuma()
        {
            Console.WriteLine("Ingrese el valor de la primera cantidad");
            Valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de la segunda cantidad");
            Valor2 = int.Parse(Console.ReadLine());

            Console.WriteLine("El resultado de la suma es: "+(Resultado=Valor1+Valor2));
        }
    }

    class Resta:Operacion
    {
        public void OperacionResta()
        {
            Console.WriteLine("Ingrese el valor de la primera cantidad");
            Valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de la segunda cantidad");
            Valor2 = int.Parse(Console.ReadLine());

            Console.WriteLine("El resultado de la resta es: " + (Resultado=Valor1-Valor2));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Suma suma1 = new Suma();    //instancia de la clase Suma
            suma1.OperacionSuma();

            Resta resta1 = new Resta();
            resta1.OperacionResta();

            Console.WriteLine("Pulse una tecla para continuar");
            Console.ReadKey();
        }
    }
}
