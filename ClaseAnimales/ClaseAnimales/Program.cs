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
        protected string colorPlumaje;
        protected double altumaMaximaVuelo;
        
        public string ColorPlumaje
        {
            get { return colorPlumaje; }
            set { colorPlumaje = value; }
        }

        public double AlturaMaximaVuelo
        {
            get { return altumaMaximaVuelo; }
            set { altumaMaximaVuelo = value; }
        }

        public Ave(string especie,string nombre, double peso, int jaula):base(especie,nombre,peso,jaula)
        {
            Console.WriteLine("Cual es el color del plumaje");
            ColorPlumaje = Console.ReadLine();

            Console.WriteLine("Altura maxima a la que vuela");
            AlturaMaximaVuelo = double.Parse(Console.ReadLine());
        }

        public override void QueClaseDeAnimalEs()
        {
            Console.WriteLine("\n Soy un ave llamada: "+Nombre);
            Console.WriteLine("de la especie: "+Especie);
            Console.WriteLine("Peso en Kilogramos es: "+Peso);
            Console.WriteLine("Estoy en la jaula: "+Jaula);
        }

    }

    //Clase Insecto derivada de la clase Animal
    class Insecto:Animal
    {
        protected bool vuela;

        //propiedad Vuela
        public bool Vuela
        {
            get { return vuela; }
            set { vuela = value; }
        }

        public Insecto(string especie,string nombre,double peso,int jaula):base(especie,nombre,peso,jaula)
        {
            int valor = 0;

            Console.WriteLine("Vuela? SI=1 NO=0");
            valor = int.Parse(Console.ReadLine());

            if (valor == 1)
                Vuela = true;
            else
                Vuela = false;
        }

        public override void QueClaseDeAnimalEs()
        {
            Console.WriteLine("\nSoy un insecto llamado: "+Nombre);
            Console.WriteLine("de la especie: "+Especie);
            Console.WriteLine("Peso en KiloGramos: "+Peso);
            Console.WriteLine("Estoy en la jaula: "+Jaula);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //el menu se pone en pantalla
            int opcion;

            Console.WriteLine("Estas son las opciones");
            Console.WriteLine("1. Datos del Mamifero");
            Console.WriteLine("2. Datos de la Ave");
            Console.WriteLine("3. Datos del Insecto");
            Console.WriteLine("4. Salir del Sistema");
            opcion = int.Parse(Console.ReadLine());

            switch(opcion)
            {
                case 1:
                    Animal animal1 = new Animal();
                    Mamifero mamifero1 = new Mamifero(animal1.Especie, animal1.Nombre, animal1.Peso, animal1.Jaula);
                    mamifero1.QueClaseDeAnimalEs();
                    break;

                case 2:
                    Animal animal2 = new Animal();
                    Ave ave2 = new Ave()
            }

        }
    }
}
