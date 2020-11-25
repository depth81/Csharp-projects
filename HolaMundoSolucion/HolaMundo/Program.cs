using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hola Mundo!!!");
            
            //Instanciar la clase Persona
            Persona p = new Persona();
            p.Nombre = "Lorena";
            p.Edad = 35;
            p.Direccion = "Av.35 #456";
            p.MostrarDatosEnConsola();
     
            Persona p2 = new Persona();
            p2.Nombre = "Mario";
            p2.Edad = 46;
            p2.Direccion = "Calle de las flores";
            p2.MostrarDatosEnConsola();
            Console.Read();


        }//END Main()

        class Persona
        {
            //Campos
            public string Nombre;
            public int Edad;
            public string Direccion;

            //Metodo
            public void MostrarDatosEnConsola()
            {
                string output = "El nombre es {0}, la edad es {1} y la direccion es {2}";
                output = string.Format(output, Nombre, Edad, Direccion);
                Console.WriteLine(output);
               
            }

        }
        
    }//END Program
}
