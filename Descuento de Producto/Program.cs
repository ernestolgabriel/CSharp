using System;

namespace Descuento_de_Producto
{
    class Program
    {
        static void Main(string[] args)
        {

            //Escriba un programa en C# que permita simular una venta. Se debe introducir el nombre del producto 
            //que  se está  comprando,  su precio  y la  cantidad. El programa  debe imprimir  el total  a pagar,
            //suponiendo que se aplica un 10 % de descuento.
            
            Console.WriteLine("Introduzca el nombre del Producto: ");
            string nombreProducto = Console.ReadLine();
            
            Console.WriteLine("\nCantidad de producto: ");
            int cantidad = int.Parse(Console.ReadLine());

            Console.WriteLine("\nCosto unitario del producto: ");
            float costoProducto = float.Parse(Console.ReadLine());

            double totalPago = costoProducto * cantidad;
            double descuento = totalPago * 0.1;

            Console.WriteLine("\nBillete con el que paga la venta: ");
            double billete = double.Parse(Console.ReadLine());

            Console.WriteLine("\nCosto total de la venta: " + totalPago);
            Console.WriteLine("\nSu descuento de 10% es:" + descuento);

            Console.WriteLine("\nSu cambio es: "+ (billete - (totalPago - descuento)));
                                

        }
    }
}
