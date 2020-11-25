using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BucleForEach
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> nombres = new List<string>() { "Paulo Enrique", "Luisa Fernanda" };

            //FOREACH no puede editar los elementos de la lista que está iterando, para esto se usa el ciclo FOR
            
            foreach(string nombre in nombres)
            {
                Console.WriteLine(nombre.ToUpper());
            }

            Console.Read();

        }
    }
}
