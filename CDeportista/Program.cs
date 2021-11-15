using System;

namespace CDeportista
{
    class CDeportista
    {
        private string nombre, deporte;
        private double peso, estatura;

        //propiedades
        public string NOMBRE
        {
            set { nombre = value; }
            get { return nombre; }
        }

        public string DEPORTE
        {
            set { deporte = value; }
            get { return deporte; }
        }

        public double PESO
        {
            set { peso = value; }
            get { return peso; }
        }

        public double ESTATURA
        {
            set { estatura = value; }
            get { return estatura; }
        }
        //contructor sin parámetros
        public CDeportista()
        {
            nombre = string.Empty;
            deporte = string.Empty;
            peso = 0.0;
            estatura = 0.0;
        }
        //contructor con parámetros
        public CDeportista(string n, string d, double p, double e)
        {
            nombre = n;
            deporte = d;
            peso = p;
            estatura = e;
        }
        //contructor copia
        public CDeportista (CDeportista d)
        {
            this.nombre = d.nombre;
            this.deporte = d.deporte;
            this.peso = d.peso;
            this.estatura = d.estatura;
        }
        //método para leer datos
        public void LeerDatos()
        {
            Console.WriteLine("Introduce el nombre del deportista");
            nombre = Console.ReadLine();

            Console.WriteLine("\nIntroduce la disciplina deportiva");
            deporte = Console.ReadLine();

            Console.WriteLine("\nIntroduce el peso del deportista en libras");
            peso = double.Parse(Console.ReadLine());

            Console.WriteLine("\nIntroduce la altura del deportista en centímetros");
            estatura = double.Parse(Console.ReadLine());
        }
        //método para imprimir datos
        public void MostrarDatos()
        {
            Console.WriteLine("El nombre del deportista es: "+nombre);
            Console.WriteLine("La disciplina deportiva es: "+deporte);
            Console.WriteLine("El peso es "+peso+" lbs. y la altura es "+estatura+" cms.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //creación de instancias de la clase CDeportista
            CDeportista p1, p2, p3;
            p1 = new CDeportista("Miguel", "Karate", 220, 170);
            p1.MostrarDatos();

            Console.WriteLine();
            //llamada de propiedades de la clase CDeportista0
            p2 = new CDeportista();
            p2.NOMBRE = "Mainor";
            p2.DEPORTE = "Baseball";
            p2.PESO = 200;
            p2.ESTATURA = 178;
            p2.MostrarDatos();

            p3 = new CDeportista();
            p3.LeerDatos();
            Console.WriteLine();
            p3.MostrarDatos();
        }
    }
}
