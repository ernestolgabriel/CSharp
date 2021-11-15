using System;

namespace Costo_de_Productos
{
    class Program
    {
        static void Main(string[] args)
        {

            //Construya un programa en C# tal que dado el costo de un artículo vendido y 
            //la cantidad de dinero entregado por el cliente vía teclado,
            //calcule e imprima el cambio que debe entregarse al mismo.
            
            Console.WriteLine("Producto comprado:");
            string nombreP = Console.ReadLine();

            Console.WriteLine("\nCosto del producto:");
            float costoProducto = float.Parse(Console.ReadLine());

            Console.WriteLine("\nBillete con el que paga: ");
            int billete = int.Parse(Console.ReadLine());

            float cambio = billete - costoProducto;

            Console.WriteLine("\nEl producto comprado es: " + nombreP + "\nSu cambio es: " + cambio);
        }
    }
}
