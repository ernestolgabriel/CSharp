using System;

namespace Número_Par_o_Impar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número entero");
            int numero = int.Parse(Console.ReadLine());
            if (numero % 2 == 0)
                Console.WriteLine(numero + " es un número par");
            else
                Console.WriteLine(numero + " no es un número par");
        }
    }
}
