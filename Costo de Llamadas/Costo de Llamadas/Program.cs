using System;

namespace Costo_de_Llamadas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*calcular e imprimir el costo de una llamada, teniendo en cuenta que los primeros 8 minutos
             *cuestan 0.25, pero si se pasa de eso vale 0.15 mas del precio estipulado, mas el precio
             *de la ciudad a la cual está llamando*/
            
            int minutos, clave;
            double precio;

            Console.WriteLine("¿Cuantos minutos habló?");
            minutos = int.Parse(Console.ReadLine());

            if (minutos < 8)
            {
                Console.WriteLine("El costo de su llamada en promoción es: " + (minutos*0.15)+ " córdobas");
                Console.WriteLine("Pulse cualquier tecla para salir");
                Console.ReadKey();
            }

            else
            {
                Console.WriteLine("Introduzca la clave de la ciudad a la que realizó la llamada");
                clave = int.Parse(Console.ReadLine());

                switch (clave)
                {
                    case 1:
                        precio = minutos * 2 * 0.4; //minutos hablados * valor de llamada de la ciudad *(0.25 costo llamada + 0.15 costo adicional)
                        Console.WriteLine("\nEl costo de llamada a León es: " + precio + " córdobas");
                        Console.WriteLine("Por hablar " + minutos + "  minutos");
                        break;

                    case 5:
                        precio = minutos * 2.2 * 0.4;//minutos hablados * valor de llamada de la ciudad *(0.25 costo llamada + 0.15 costo adicional)
                        Console.WriteLine("\nEl costo de llamada a Managua es: " + precio + " córdobas");
                        Console.WriteLine("Por hablar " + minutos + "  minutos");
                        break;

                    case 8:
                        precio = minutos * 4.5 * 0.4;//minutos hablados * valor de llamada de la ciudad *(0.25 costo llamada + 0.15 costo adicional)
                        Console.WriteLine("\nEl costo de llamada a Estelí es: " + precio + " córdobas");
                        Console.WriteLine("Por hablar " + minutos + "  minutos");
                        break;

                    case 9:
                        precio = minutos * 3.5 * 0.4;//minutos hablados * valor de llamada de la ciudad *(0.25 costo llamada + 0.15 costo adicional)
                        Console.WriteLine("\nEl costo de llamada a Matagalpa es: " + precio + " córdobas");
                        Console.WriteLine("Por hablar " + minutos + "  minutos");
                        break;

                    case 13:
                        precio = minutos * 6 * 0.4;//minutos hablados * valor de llamada de la ciudad *(0.25 costo llamada + 0.15 costo adicional)
                        Console.WriteLine("\nEl costo de llamada a Jinotega es: " + precio + " córdobas");
                        Console.WriteLine("Por hablar " + minutos + "  minutos");
                        break;

                    case 2:
                        precio = minutos * 6;//minutos hablados * valor de llamada de la ciudad *(0.25 costo llamada + 0.15 costo adicional)
                        Console.WriteLine("\nEl costo de llamada a Chinandega es: " + precio + " córdobas");
                        Console.WriteLine("Por hablar " + minutos + "  minutos");
                        break;

                    case 15:
                        precio = minutos * 5 * 0.4;//minutos hablados * valor de llamada de la ciudad *(0.25 costo llamada + 0.15 costo adicional)
                        Console.WriteLine("\nEl costo de llamada a Rivas es: " + precio + " córdobas");
                        Console.WriteLine("Por hablar " + minutos + "  minutos");
                        break;

                    default:
                        Console.WriteLine("La clave de ciudad introducida no es válida");
                        break;

                }

            }

        }
    }
}
