using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //cout << "PROGRAMA QUE DIBUJA UN RECTANGULO VACIO FORMADO POR ASTERISCOS" << endl;
            //int alto, ancho, fila, columna;
            //cout << "Introduzca el ANCHO del rectangulo:";
            //cin >> ancho;
            //cout << "Introduzca el ALTO del rectangulo:";
            //cin >> alto;

            //for (fila = 0; fila < alto; fila = fila + 1)
            //{
            //    for (columna = 0; columna < ancho; columna = columna + 1)
            //        cout << "*";
            //    cout << endl;
            //}

            //return 0;
            Console.WriteLine("Introduce el ancho del rectángulo");
            int ancho = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el alto del rectángulo");
            int alto = int.Parse(Console.ReadLine());

            for (int i = 0; i < ancho; i++)
            {
                for (int j = 0; j < alto; j++)
                    Console.Write("*");
                Console.Write("\n");
            }
                

        }
    }

}

