using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa la cantidad de lineas del triangulo");
            int lineas = int.Parse(Console.ReadLine()); 

            for (int i = 0; i <= lineas; i++)
            {
                for (int e = 0; e < i; e++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();

            }
        }
    }
}
