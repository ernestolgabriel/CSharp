using System;

namespace Ejemplo2Herencia
{
    class Producto
    {
        //atributos de la clase Producto
        private float precio;
        private long codigo;
        private string marca, nombre;
        
        //propiedades
        //Propiedad Precio
        protected float Precio
        {
            get { return precio; }

            set { precio = value; }
        }
        //Propiedad Codigo
        protected long Codigo
        {
            get { return codigo; }

            set { codigo = value; }
        }
        //Propiedad Marca
        protected string Marca
        {
            get { return marca; }

            set { marca = value; }
        }
        //Propiedad Nombre
        protected string Nombre
        {
            get { return nombre; }

            set { nombre = value; }
        }

        protected void Almacenar()
        {
            Console.WriteLine("Ingrese el producto que vamos a almacenar");
            Console.WriteLine("\nNombre");
            nombre = Console.ReadLine();

            Console.WriteLine("\nIngrese la marca");
            marca = Console.ReadLine();

            Console.WriteLine("\nIngresa el código de barras");
            codigo = long.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el precio del producto");
            precio = float.Parse(Console.ReadLine());
        }

        protected void MostrarDatos()
        {
            Console.WriteLine("******************************");
            Console.WriteLine("Hemos almacenado lo siguiente");
            Console.WriteLine(Nombre+" de la marca "+Marca);
            Console.WriteLine("Con el código "+Codigo+" y su precio es "+Precio);
        }
    }
    //Clase papeles derivada de la clase producto
    class Papeles:Producto
    {
        //atributos de la clase Papeles
        string tipo, color, tamanio;

        //Propiedades
        //Propiedad Tipo
        public string Tipo
        {
            get { return tipo; }

            set { tipo = value; }
        }

        //Propiedad Tamaño
        public string Tamanio
        {
            get { return tamanio; }

            set { tamanio = value; }
        }
        //Propiedad Color
        public string Color
        {
            get { return color; }

            set { color = value; }
        }

        public void SeleccionarPapel()
        {
            Almacenar();       //Llamado a la función almacenar
            Console.WriteLine("\nElije el tipo de papel a almacenar");
            
            Console.Write("Tipo: ");
            tipo = Console.ReadLine();
            
            Console.Write("\nColor del papel: ");
            color = Console.ReadLine();

            Console.Write("\nIntroduce el tamaño del papel: ");
            tamanio = Console.ReadLine();
        }

        public void MostrarPapel()
        {
            MostrarDatos();

            Console.WriteLine("El papel es de tipo "+tipo+" el color es "+color+" tu tamaño es "+tamanio);
        }
    }
    //Clase Utensilios derivada de la clase Producto
    class Utensilios:Producto
    {
        //Atributos clase Utensilios
        string categoria, material;
        double peso;

        //Propiedad Categoria para acceder al atributo categoria
        public string Categoria
        {
            get { return categoria; }

            set { categoria = value; }
        }

        //Propiedad Material para acceder al atributo material
        public string Material
        {
            get { return material; }

            set { material = value; }
        }

        //Propiedad Peso para acceder al atributo peso
        public double Peso
        {
            get { return peso; }

            set { peso = value; }
        }

        //Método para seleccionar los datos del utensilio a almacenar
        public void SeleccionaUtensilio()
        {
            Almacenar();    //Llamada de la funcion almacenar, método de la clase padre Producto

            Console.WriteLine("Seleccione el tipo de utensilio a almacenar");
            Console.WriteLine("\nCategoria");
            categoria = Console.ReadLine();

            Console.WriteLine("Introduce el peso del material");
            peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el nombre del material");
            material = Console.ReadLine();
        }

        public void MostrarUtensilio()
        {
            MostrarDatos();

            Console.WriteLine("Esto es de la categoria "+categoria+" de "+material+" tiene un peso de "+peso);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int seleccion;

            Console.WriteLine("Ingrese el producto que desea ingresar");
            Console.WriteLine("1. Papeles");
            Console.WriteLine("2. Utensilios");
            Console.WriteLine("****************************");
            seleccion = int.Parse(Console.ReadLine());

            switch(seleccion)
            {
                case 1:
                    Papeles NuevoPapel = new Papeles();
                    NuevoPapel.SeleccionarPapel();
                    NuevoPapel.MostrarPapel();
                    break;

                case 2:
                    Utensilios NuevoUtensilio = new Utensilios();
                    NuevoUtensilio.SeleccionaUtensilio();
                    NuevoUtensilio.MostrarUtensilio();
                    break;

                default:
                    Console.WriteLine("La opción introducida no es válida");
                    break;
            }

            Console.WriteLine("Pulsa una tecla para salir");
            Console.ReadKey();
        }
    }
}
