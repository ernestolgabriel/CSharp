using System;

namespace Categoria_Trabajador
{
    class Program
    {
        static void Main(string[] args)
        {
            //Construya un seudocódigo tal que, dado como datos la categoría y el sueldo de un trabajador, calcule
            //el aumento correspondiente teniendo en cuenta lo siguiente: Si el trabajador se encuentra en la categoría 1, 
            //el aumento de sueldo será de 15 %, si se encuentra en
            //la categoría 2, el aumento será de 10 %, si está en la categoría 3, el aumento será de 8 % y si es de la
            //cuarta categoría, el aumento será de 7 %.Visualice la categoría del trabajador y su nuevo sueldo.

            string nombreTrabajador, porcentaje;
            int categoria;
            double sueldo, aumento, nuevoSalario;

            Console.WriteLine("Introduzca su nombre");
            nombreTrabajador = Console.ReadLine();

            Console.WriteLine("Introduzca su sueldo");
            sueldo = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduzca su categoría, con un numero del 1 al 4");
            categoria = int.Parse(Console.ReadLine());

            if (categoria == 1)
            {
                aumento = sueldo * 0.15;
                porcentaje = "15 %";
            }
                
            else if (categoria == 2)
            {
                aumento = sueldo * 0.1;
                porcentaje = "10 %";
            }
                
                
            else if (categoria == 3)
            {
                aumento = sueldo * 0.08;
                porcentaje = "8 %";
            }
                             
            else
            {
                aumento = sueldo * 0.07;
                porcentaje = "7 %";
            }
                

            nuevoSalario = aumento + sueldo;

            Console.WriteLine("\nEstimado " + nombreTrabajador);
            Console.WriteLine("Su nuevo salario es de "+nuevoSalario);
            Console.WriteLine("Debido a que usted está en la categoría " + categoria);
            Console.WriteLine("y recibe un aumento del "+ porcentaje+" .");
            Console.WriteLine("Que corresponden a "+aumento+" córdobas");
        }
    }
}
