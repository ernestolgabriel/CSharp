using System;

namespace ejercicioPropuesto1doWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0, numero = 0, positivos = 0;

            Console.WriteLine("Introduce números (999) para finalizar");
            numero = int.Parse(Console.ReadLine());

            do
            {
                contador++; // cuenta el total de números introducidos

                if (numero > 0)
                    positivos++;    //conteo de números positivos
                Console.WriteLine("Introduce números (999) para finalizar");
                numero = int.Parse(Console.ReadLine());

            } while (numero !=  999); //hará el ciclo mientras no se introduzca 999

            Console.WriteLine("Total de números introducidos "+contador);
            Console.WriteLine("Los positivos son "+positivos);

            Console.WriteLine("Pulsa cualquier tecla para salir");
            Console.ReadKey();
        }
    }
}
