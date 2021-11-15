using System;

namespace Menor_de_3_números
{
    class Program
    {
        static void Main(string[] args)
        {
            int menor = 0;
            Console.WriteLine("Introduce 3 nímeros enteros");
            int numero1 = int.Parse(Console.ReadLine());
            int numero2 = int.Parse(Console.ReadLine());
            int numero3 = int.Parse(Console.ReadLine());

            if (numero1 < numero2)
                if (numero1 < numero3)
                    menor = numero1;
                else
                    menor = numero3;
            
            else
                if (numero2 < numero3)
                menor = numero2;
                else
                menor = numero3;

            Console.WriteLine("El menor es "+ menor);
            Console.WriteLine("Pulsa cualquier tecla para salir");
            Console.ReadKey();
        }
    }
}
