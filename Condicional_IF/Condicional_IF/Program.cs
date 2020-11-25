using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicional_IF
{
    class Program
    {
        static void Main(string[] args)
        {

            String nombre = "Felipess";
            String nombreMay = "FELIPE";
            String frase = "Carlos y Felipe son amigos";

            var longitudNombre = nombre.Length;

            Console.WriteLine(longitudNombre);

            if (longitudNombre == 6)
            {
                Console.WriteLine(frase.Length);
            }
            else if (longitudNombre == 7)
            {
                Console.WriteLine("La longitud es 7");
            }
            else if (longitudNombre == 8)
            {
                Console.WriteLine("La longitud es 8");
                Console.WriteLine("C# es grandioso!");

                if (nombre == nombreMay)
                {
                    Console.WriteLine("Los nombres son iguales");
                }
                else
                {
                    Console.WriteLine("Los nombres son diferentes");
                }
            }
            else
            {
                Console.WriteLine(nombre == nombreMay);
            }

            Console.ReadLine();

        }
    }
}
