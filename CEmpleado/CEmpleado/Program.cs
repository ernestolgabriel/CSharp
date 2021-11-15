using System;
using System.Collections.Generic;

namespace CEmpleado
{
    class CEmpleado
    {
        private String nombre;
        private int edad;
        private float salario;

        public CEmpleado()
        {
            nombre = string.Empty;
            edad = 0;
            salario = 0;//Constructor sin parámetros
        }
        public CEmpleado(String nom, int ed, float sal)
        { //Constructor con argumentos. 
            nombre = nom;
            edad = ed;
            salario = sal;
        }

        public String getNombre()
        { //Obtiene el Nombre. 
            return nombre;
        }

        public void setNombre(String nom)
        { //Establece un Nombre.
            this.nombre = nom;
        }

        public int getEdad()
        { //Obtiene la Edad.
            return edad;
        }

        public void setEdad(int ed)
        { //Establece una Edad. 
            edad = ed;
        }

        public float getSalario()
        { //Obtiene el Salario.
            return salario;
        }

        public void setSalario(float sal)
        { //Establece un Salario.
            this.salario = sal;
        }

        public Boolean equals(CEmpleado cli)
        { //Retorna true si los nombres son iguales 
            return this.nombre.Equals(cli.nombre);
        }

        public String toString()
        { //Retorna una cadena de caracteres con todos los datos. 
            return String.Format("Nombre: {0} \n Edad: {1} \n Salario: CS  {2}", nombre, edad, salario);
        }
        

        public void LeerDatos()
        {
            //Ingrese  las instrucciones  necesarias  para almacenar datos  en  los             atributos.
            Console.WriteLine("Introduce el nombre del Empleado");
            nombre = Console.ReadLine();

            Console.WriteLine("Introduce la edad del empleado");
            edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el salario del empleado");
            salario = float.Parse(Console.ReadLine());
        }

        //public void MostrarDatos()
        //{
        //    Console.WriteLine("");
        //}
    }

    class CTurno
    {
        private int horaInicio;
        private int horaFin;
        private int horaPorSemana;

        public CTurno()
        {

        }

        public int getHoraInicio()
        {
            Console.WriteLine("Introduce tu hora de entrada");
            horaInicio = int.Parse(Console.ReadLine());
            return horaInicio;
        }

        public int getHoraFin()
        {
            Console.WriteLine("Introduce la hora de finalización");
            horaFin = int.Parse(Console.ReadLine());
            return horaFin;
        }

        public int obtenerHorasPorSemana()
        {
            return horaPorSemana = horaFin - horaInicio;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int cantidad_empleados=0;
            
            
            CEmpleado empleado1 = new CEmpleado();
            Console.WriteLine("Empleado # 1:");

            //Crea  una instancia  de CEmpleado  mediante un  constructor y 
            //asígnale los siguientes datos: Hugo, 18, 3600

            CEmpleado empleado = new CEmpleado("Hugo", 18, 3600);

            //Visualiza los datos de la instancia creada con ayuda del método 
            //toString de la clase CEmpleado
            Console.WriteLine(empleado.toString());

            //Crea una  instancia mediante  el constructor  sin parámetros  y
            //asigna a sus atributos los datos: Luis Diaz, 39, 4000 mediante los métodos
            //de la clase, NO añada propiedades.
            //Visualice los datos del empleado 2
            Console.WriteLine("\nEmpleado # 2:");
            CEmpleado empleado2 = new CEmpleado("Luis Diaz", 39, 4000);

            Console.WriteLine("El nombre es "+empleado2.getNombre()+" su edad es "+empleado2.getEdad());
            Console.WriteLine("y el salario es: "+empleado2.getSalario());


            Console.WriteLine("Empleado # 3:");
            CEmpleado empleado3 = new CEmpleado("Hugo", 40, 10000);
            bool igual = empleado3.equals(empleado1);

            //Console.WriteLine("*Introduzca la cantidad de empleados*");
            //Console.WriteLine("\n");
            //int cantidad = int.Parse(Console.ReadLine());

            
            List<CEmpleado> ListaEmpleado = new List<CEmpleado>();


            for (int i = 0; i < cantidad_empleados; i++)
            {
                CEmpleado empleados = new CEmpleado();
                empleados.LeerDatos(); // metodo que solocita los datos del empleado
                ListaEmpleado.Add(empleados);// agrega en la lista los datos de cada emplado por teclado

            }

            for(int i=0; i < ListaEmpleado.Count;i++)
            {
                Console.WriteLine("\n**Empleado{0}**", i + 1);
                Console.WriteLine(ListaEmpleado[i].toString());//imprime cada empleado de la Lista
                Console.WriteLine("\n");
            }

            //if (igual == true)
            //{
            //    Console.WriteLine("Los  nombres  de  los  empleados  1  y  3  son iguales"); 
            //    Console.WriteLine(empleado3.toString());
            //}
        }
    }
}
