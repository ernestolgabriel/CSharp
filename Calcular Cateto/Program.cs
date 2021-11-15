using System;

namespace Calcular_Cateto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escriba un programa que reciba como datos de entrada el valor de la hipotenusa y uno de los catetos
            //de un triángulo rectángulo. El programa debe calcular e imprimir el valor del otro cateto.


            Console.WriteLine("Introduce el valor de la Hipotenusa: ");
            float hipotenusa = float.Parse(Console.ReadLine());

            Console.WriteLine("\nIntroduce el valor de uno de los Catetos");
            float cateto = float.Parse(Console.ReadLine());

            double resultado = Math.Sqrt(Math.Pow(hipotenusa,2) + Math.Pow(cateto,2));

            Console.WriteLine("El valor del segundo Cateto es: "+ resultado);

        }
    }
}
