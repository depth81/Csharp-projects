using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsApp
{
    class Program
    {
        static void Main(string[] args)
        {

            String nombre = "Felipe";
            String nombreMay = "FELIPE";
            String frase = "Juan y Maria son amigos";

            //Length
            Console.WriteLine(nombre.Length);
            Console.WriteLine(frase.Length);

            //Substring
            Console.WriteLine(nombre.Substring(3));
            Console.WriteLine(frase.Substring(7,4));

            //Startswith
            Console.WriteLine(frase.StartsWith("Juan"));
            Console.WriteLine(frase.StartsWith("Jose"));

            //endswith
            Console.WriteLine(frase.EndsWith("amigos"));
            Console.WriteLine(frase.EndsWith("Desconocidos"));

            //indexof
            var indiceDeMaria = frase.IndexOf("Maria");
            var indiceDeJose = frase.IndexOf("Jose");
            Console.WriteLine(indiceDeMaria);
            Console.WriteLine(indiceDeJose);

            //operador + (concatenar)
            Console.WriteLine(nombre + ", " + frase);

            //ToLower
            Console.WriteLine(frase.ToLower());

            //ToUpper
            Console.WriteLine(frase.ToUpper());

            Console.WriteLine(nombre.ToUpper() == nombreMay.ToUpper());

            //Trim (Eliminar espacios en blanco al principio y al final de una cadena de texto
            String ejemploTrim = "  Felipe  ";
            Console.WriteLine(ejemploTrim);
            Console.WriteLine(ejemploTrim.Trim());
            Console.WriteLine(nombre == ejemploTrim);
            Console.WriteLine(nombre == ejemploTrim.Trim());

            //Format. 
            String ejemploFormat = "Felicidades {0} en tu aniversario numero {1}! {0}";
            var resultadoFormat = String.Format(ejemploFormat, nombre, 50);
            Console.WriteLine(resultadoFormat);

            //Replace
            String ejemploReplace = "Felicidades @nombre en tu aniversario numero @edad";
            var resultadoReplace = ejemploReplace.Replace("@nombre", nombre);
            resultadoReplace = resultadoReplace.Replace("@edad", "50");
            Console.WriteLine(resultadoReplace);

            //IsNullOrWhiteSpace
            String stringEspaciosEnBlanco = "   ";
            String stringNULL = null;
            Console.WriteLine(String.IsNullOrEmpty(stringEspaciosEnBlanco));
            Console.WriteLine(String.IsNullOrEmpty(stringNULL));
            Console.WriteLine(String.IsNullOrEmpty(nombre));


            Console.Read();

        }
    }
}
