using System;

namespace EjercicioPropuesto2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            do
            {
                Console.WriteLine("Introduce un número entre 0 y 10");
                numero = int.Parse(Console.ReadLine());
            } while (numero < 0 || numero > 10);

            Console.WriteLine("Número válido");

            Console.WriteLine("Pulsa una tecla para salir");
            Console.ReadKey();
        }
    }
}
