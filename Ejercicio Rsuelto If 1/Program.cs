using System;

namespace Ejercicio_Rsuelto_If_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa 2 números enteros");
            int numero1 = int.Parse(Console.ReadLine());
            int numero2 = int.Parse(Console.ReadLine());
            if(numero1%numero2 ==0)
                Console.WriteLine(numero1 + " es divisible por "+numero2);
            else
                Console.WriteLine(numero1 + " no es divisible por "+ numero2);

        }
    }
}
