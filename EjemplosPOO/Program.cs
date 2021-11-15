using System;

namespace EjemplosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            CDeportista p1, p2, p3;
            p1 = new CDeportista("Gabriel", "Karate", 220, 170);
            p1.MostrarDatos();

            //uso del constructor copia
            //p2 = new CDeportista(p1);
            p2 = new CDeportista("Misael","Baseball",200,178);// nuevos datos de p2
            p2.MostrarDatos();

            p3 = new CDeportista();
            p3.LeerDatos();
            p3.MostrarDatos();
            Console.Write("\n");
        }
    }

    class CDeportista
    {
        // aqui se definen los atributos
        private string deporte, nombre;
        private double peso, altura;

        //aqui vienen los métodos
        public CDeportista()    //constructor sin parámetros
        {
            nombre = string.Empty;
            deporte = string.Empty;
            peso = 0.0;
            altura = 0.0;
        }

        public CDeportista(string d, string n, double p, double a)   //contructor con parámetros
        {
            deporte = d;
            nombre = n;
            peso = p;
            altura = a;
        }

        public CDeportista(CDeportista d)   //constructor copia
        {
            this.deporte = d.deporte;
            this.nombre = d.nombre;
            this.peso = d.peso;
            this.altura = d.altura;
        }

        public void LeerDatos()
        {
            Console.WriteLine("Datos del Deportista");
            Console.WriteLine();

            Console.WriteLine("Introduce la disciplina deportiva");
            deporte = Console.ReadLine();

            Console.WriteLine("Introduce nombre");
            nombre = Console.ReadLine();

            Console.WriteLine("Introduce tu peso en libras");
            peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduce tu altura en centímetros");
            altura = double.Parse(Console.ReadLine());
        }

        public void MostrarDatos()
        {
            Console.WriteLine();
            Console.WriteLine("Impresión de Datos");
            Console.WriteLine("Deporte escogido es: "+ deporte);
            Console.WriteLine("Tu nombre es: "+nombre+" tu peso es: "+peso);
            Console.WriteLine("Tu altura es: "+altura);
        }
    }
}
