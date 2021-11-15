using System;

namespace Ferreteria_Leiva
{
    class Program
    {
        static void Main(string[] args)
        {
            double descuento, valorpago, compra;
            string valorporciento;
            Console.WriteLine("Ingrese el monto de la compra del cliente");
            compra = double.Parse(Console.ReadLine());

            if (compra < 3000)
            {
                descuento = compra * 0.05;
                valorporciento = "5 % de descuento";
            }
            else
            {
                if (compra >= 3000 && compra < 10000)
                {
                    descuento = compra * 0.1;
                    valorporciento = "10% de descuento";
                }


                else
                {
                    descuento = compra * 0.18;
                    valorporciento = "18% de descuento";
                }

            }

            valorpago = compra - descuento;

            Console.WriteLine("\nA su factura se le aplicó un descuento de " + descuento);
            Console.WriteLine("\nEquivalente al "+valorporciento);
            Console.WriteLine("\nEl valor total a pagar es "+valorpago);

            Console.WriteLine("Pulse cualquier tecla para salir");
            Console.ReadKey();
        }
    }
}
