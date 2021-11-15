using System;

namespace primera_aplicación
{
    class Program
    {
        static void Main(string[] args)
        {

            const double PI = 3.141516;
            Console.WriteLine("Introduce el radio:");
            double radio = double.Parse(Console.ReadLine());

            //double area = radio*radio * PI;
            double area = Math.Pow(radio, 2) * PI;

            Console.WriteLine("El área del circulo es: "+area);



        }
    }
}
