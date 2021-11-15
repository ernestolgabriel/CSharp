using System;

namespace Segundos_en_Número_de_Días
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Introduce el número de días"); // se imprime un rótulo para que el usuario introduzca por teclado el número de días
            int nDias = int.Parse(Console.ReadLine());    // el valor es almacenado en la variable nDias. 

            int segDias = nDias * 86400;  // en la variable segDias se almacena la operación de multiplicación del número de días introducidos por
                                               // el número de segundos que hay en un día

            Console.WriteLine("Los segundos que hay en esos " + nDias + " días son:" + segDias);

        }
    }
}
