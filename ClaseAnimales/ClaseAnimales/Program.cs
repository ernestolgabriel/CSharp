using System;

namespace ClaseAnimales
{
    //Clase padre
    class Animal
    {
        //Atributos protegidos visibles en las clases hijas
        protected string especie, nombre;
        protected double peso;
        protected int jaula;

        //Propiedades para acceder a los miembros protegidos de la clase
        public string Especie
        {
            get { return especie; }
            set { especie = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        public int Jaula
        {
            get { return jaula; }
            set { jaula = value; }
        }

        //Constructor sin parámetros de la clase base Animal
        public Animal()
        {
            Console.WriteLine("****Introduce los datos del animal****");
            Console.Write("Nombre: ");
            Nombre = Console.ReadLine();

            Console.Write("\nEspecie a la que pertenece: ");
            Especie = Console.ReadLine();

            Console.Write("\nPeso en Kilogramos: ");
            Peso = double.Parse(Console.ReadLine());

            Console.Write("Jaula en la que está el animal: ");
            Jaula = int.Parse(Console.ReadLine());
        }

        //Constructor con parámetros de la clase base Animal
        public Animal(string especie, string nombre, double peso, int jaula)
        {
            this.especie = especie;
            this.nombre = nombre;
            this.peso = peso;
            this.jaula = jaula;
        }

        //metodo virtual que puede ser reutilizado por las clases hijas
        public virtual void QueClaseDeAnimalEs()
        {
            Console.WriteLine("Soy un mamifero llamado: "+Nombre);
            Console.WriteLine("de la especie: "+Especie);
            Console.WriteLine("Peso en KiloGramos: "+Peso);
            Console.WriteLine("Estoy en la jaula "+Jaula);
        }
    }

    //Clase Mamifero derivda de la clase Animal
    class Mamifero:Animal
    {
        // declaración de atributos protegidos
        protected string tipoMamifero;

        //declaración de propiedad tipo de mamifero

        public string TipoMamifero
        {
            get { return tipoMamifero; }
            set { tipoMamifero = value; }
        }
        //contructor con parámetros de la clase mamífero hace la llamada primero al contructor del padre
        public Mamifero(string especie, string nombre, double peso, int jaula):base(especie,nombre,peso,jaula)
        {
            Console.WriteLine("\nTipo de mamifero: ");
            TipoMamifero = Console.ReadLine();
        }

        public override void QueClaseDeAnimalEs()
        {
            Console.WriteLine("Soy un mamifero llamado: " + Nombre);
            Console.WriteLine("de la especie: " + Especie);
            Console.WriteLine("Peso en KiloGramos: " + Peso);
            Console.WriteLine("Estoy en la jaula " + Jaula);
        }
    }

    //Clase Ave derivada de la clase Animal
    class Ave:Animal
    {
        string colorPlumaje;
        double altumaMaximaVuelo;
    }

    //Clase Insecto derivada de la clase Animal
    class Insecto:Animal
    {
        Boolean vuela;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
