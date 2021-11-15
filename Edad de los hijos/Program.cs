using System;

namespace Edad_de_los_hijos
{
    class Program
    {
        static void Main(string[] args)
        {
            //A la mamá de Juan le preguntan su edad, y contesta: tengo 3 hijos, pregúntele a Juan su edad.
            //Alberto tiene 2 / 3 de la edad de Juan, Ana tiene 4 / 3 de la edad de Juan y mi edad es la suma de las tres.
            //Hacer un programa que muestre la edad de los cuatro.

            Console.WriteLine("¿Cual es la edad de Juan?");
            int Juan = int.Parse(Console.ReadLine());

            int Alberto = Juan / 2 * 3;

            int Ana = Juan * 4 / 3;

            int Madre = Juan + Alberto + Ana;

            Console.WriteLine("La edad de la mamá es: "+ Madre);
            Console.WriteLine("\nLa edad de Juan es: "+ Juan);
            Console.WriteLine("\nLa edad de Alberto es: "+ Alberto);
            Console.WriteLine("\nLa edad de Ana es: "+Ana);

        }
    }
}
