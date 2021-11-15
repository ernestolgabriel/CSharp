using System;

namespace piramideConNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce la base de la pirámide");
            int tam = int.Parse(Console.ReadLine());    //se lee el tamaño de la base de la pirámide

            Console.WriteLine();    //espacio en blanco

                for (int altura = 1; altura <= (tam / 2); altura++)
                {
                    //Espacios en blanco
                    for (int i = 1; i <= altura; i++)
                    {
                        Console.Write(" "+i); //espacio en blanco mas espacio del número de la vuelta del for
                    }
                Console.WriteLine();    //espacio en blanco
                }
                for (int altura = (tam / 2) + 1; altura > 0; altura--)
                {
                    //Espacios en blanco
                    for (int i = 1; i <= altura; i++)
                    {
                        Console.Write(" "+i);   //espacio en blanco mas espacio del número de la vuelta del for
                }
                Console.WriteLine();
                }
            Console.WriteLine("\nPulse cualquier tecla para salir");
            Console.ReadKey();
        }

    }
}

