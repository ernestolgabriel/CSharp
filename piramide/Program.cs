using System;

namespace ciclo_for_cuadarado
{
    class Program
    {
        public static void Main(string[] args)
        {
            int ancho = 0;

            Console.WriteLine("Introduzca la medida del Cuadrado\n");

            Console.Write("Ancho: "); // solicitar el ancho
            ancho = int.Parse(Console.ReadLine());

            for (int i = 0; i < ancho; i++)
              Console.Write("*");// fila superior del cuadrado
            

            Console.WriteLine();    //espacio
            for (int i = 0; i < ancho - 2; i++)// se cumple mientras i sea nenor de ancho-2

            {
                Console.Write("*");// lado izquierdo del cuadrado

                for (int j = 0; j < ancho - 2; j++)
                  Console.Write(" ");// hueco del cuadrado
                
                Console.WriteLine("*");//  lado derecho del cuadrado
            }

            for (int i = 0; i < ancho; i++)
               Console.Write("*");//  fila inferior del cuadrado

            Console.WriteLine("\nPresione una tecla para salir");
            Console.ReadKey(true);
        }


    }
}