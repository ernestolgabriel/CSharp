using System;

namespace indiceMasa
{
    class Persona
    {
        private string nombre;
        private double peso;
        private double estatura;
        private double imc;

        public Persona()
        {
            nombre = string.Empty;
            peso = 0.0;
            estatura = 0.0;
        }

        public void LeerDatos()
        {
            Console.WriteLine("Introduce tu nombre");
            nombre = Console.ReadLine();

            Console.WriteLine("\nIntroduce tu peso en Kilogramos");
            peso = double.Parse(Console.ReadLine());

            Console.WriteLine("\nIntroduce tu estatura, esta debe ser en metros");
            estatura = double.Parse(Console.ReadLine());
        }        

        public void MostrarDatos()
        {
            imc = peso / Math.Pow(estatura,2);     // fórmula para el cálculo de IMC
            if(imc < 24.9)
            {
                Console.WriteLine("Hola " + nombre);
                Console.WriteLine("Te encuentras sin sobrepeso");
                Console.WriteLine("Tu Índice de Masa Corporal es: "+imc);
            }

            else if (imc >= 25 || imc <= 26.9)
            {
                Console.WriteLine("Hola " + nombre);
                Console.WriteLine("Tienes sobrepeso Grado 1");
                Console.WriteLine("Tu Índice de Masa Corporal es: " + imc);
            }

            else if(imc >=27 || imc <= 29.9)
            {
                Console.WriteLine("Hola " + nombre);
                Console.WriteLine("Tienes sobrepeso Grado 2");
                Console.WriteLine("Tu Índice de Masa Corporal es: " + imc);
            }

            else if(imc >= 30 || imc <= 34.9)
            {
                Console.WriteLine("Hola " + nombre);
                Console.WriteLine("Tienes sobrepeso Obesidad Tipo 1");
                Console.WriteLine("Tu Índice de Masa Corporal es: " + imc);
            }

            else if(imc >= 35 || imc <= 39.9)
            {
                Console.WriteLine("Hola " + nombre);
                Console.WriteLine("Tienes sobrepeso Obesidad Tipo 2");
                Console.WriteLine("Tu Índice de Masa Corporal es: " + imc);
            }

            else if(imc >= 10 || imc <= 49.9)
            {
                Console.WriteLine("Hola " + nombre);
                Console.WriteLine("Tienes sobrepeso Obesidad Tipo 3 (Mórbida)");
                Console.WriteLine("Tu Índice de Masa Corporal es: " + imc);
            }

            else
            {
                Console.WriteLine("Hola " + nombre);
                Console.WriteLine("Tienes que preocuparte, tienes obesidad tipo 4 (Extrema)");
                Console.WriteLine("Tu Índice de Masa Corporal es: " + imc);
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("¿Cuantas persona desea evaluar su índice de IMC?");
            int total = int.Parse(Console.ReadLine());  //leemos la cantidad de personas a evaluar

            Persona[] p1 = new Persona[total];

            for(int i=0; i < total ;i++)
            {
                Console.WriteLine();
                Console.WriteLine("***********************");
                Console.WriteLine("Persona "+(i+1));
                p1[i] = new Persona();
                p1[i].LeerDatos();
            }
            Console.WriteLine("\nResultados de Análisis del IMC, basados en el peso.");

            for (int j=0; j < total; j++)
            {
                Console.WriteLine("***********************");
                Console.WriteLine("Persona: "+(j+1));
                p1[j].MostrarDatos();

            }
        }
    }
}
