using System;

namespace ejercicioPropuesto1For
{
    class Program
    {
        static void Main(string[] args)
        {
            int positivos = 0, contador, numero;    //declaración de variables

            Console.Title = "Ejercicio Propuesto 1 con for";    //título de la ventana de consola

            Console.WriteLine("Introduce números (999 para finalizar)");
            numero = int.Parse(Console.ReadLine());

            for(contador=0; numero != 999; contador++)  //contador inializado a 0, la condición de cierre del for es que se introduzca el 999
            {
                if (numero > 0)
                    positivos += 1;         // si son mayor que 1 son contabilizados

                Console.WriteLine("Introduce números (999 para finalizar)");    //se seguirá pidiendo número mientras no se introduzca el 999
                numero = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Has introducido un total de "+contador+" números");  //se imprime el resultado de los números introducidos
            Console.WriteLine("De ellos hay "+positivos+" positivos");          //se imprimen cuantos de ellos fueron mayor que 0, por tanto positivos

            Console.WriteLine("Pulsa cualquier tecla para salir");
            Console.ReadKey();
        }
    }
}
