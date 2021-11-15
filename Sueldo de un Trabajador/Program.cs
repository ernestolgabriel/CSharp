using System;

namespace Sueldo_de_un_Trabajador
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dado como dato el sueldo de un trabajador, aplíquele un aumento del 15 % 
            //si su sueldo es inferior a $1000.Imprima en este caso el nuevo sueldo del trabajador.
            Console.WriteLine("Ingrese el sueldo del Trabajador");
            double sueldo = float.Parse(Console.ReadLine());
            double aumento = 0;
            if (sueldo < 1000)
            {
                aumento = sueldo * 0.15;
                sueldo = sueldo + aumento;
                Console.WriteLine("\nSu salario con aumento es: "+sueldo);
                Console.WriteLine("Usted recibió un aumento de: "+aumento);
            }
            else
                Console.WriteLine("Usted no recibe aumento");

        }
    }
}
