using System;

namespace version_while
{
	class Program
	{
		public static void Main(string[] args)
		{
			int positivos = 0;
			int conta = 0;
			int numero;

			Console.WriteLine("Introduzca un numero (Si desea finalizar introduzca el 999)"); // De le solicita al usuario introducir un numeroi a evaluar
			numero = int.Parse(Console.ReadLine());

			do
			{
				conta = conta + 1;
				if (numero > 0)
				{
					positivos = positivos + 1;
				}

				Console.WriteLine("Introduce número ");
				numero = int.Parse(Console.ReadLine());

			} while (numero != 999);

			Console.WriteLine("Has introducido un total de {0} numeros", conta);
			Console.WriteLine("y son positivos {0}", positivos);
			Console.Write("Press any key to continue . . . ");

			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);

		}
	}
}