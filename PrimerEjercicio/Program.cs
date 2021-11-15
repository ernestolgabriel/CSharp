using System;

namespace PrimerEjercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            do
            {
                Console.WriteLine("Ingresa el multiplicando (0-10)");
                numero = int.Parse(Console.ReadLine());
                
            } while (numero > 10 || numero < 0);

            for (int i = 0; i <= 10; i++)
                Console.WriteLine(numero + " x " + i + " = " + (numero * i));

            Console.WriteLine("Pulsa una tecla para salir");
            Console.ReadKey();
        }
    }
}
