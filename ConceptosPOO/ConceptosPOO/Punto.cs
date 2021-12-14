using System;
using System.Collections.Generic;
using System.Text;

namespace ConceptosPOO
{
    class Punto
    {
        public Punto(int x, int y)
        {
            Console.WriteLine("Coordenada X: "+x+" Coordenada Y: "+y);
        }

        public Punto()
        {
            Console.WriteLine("Constructor por defecto");
        }
    }
}
