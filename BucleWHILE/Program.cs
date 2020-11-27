using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BucleWHILE
{
    class Program
    {
       
        static void Main(string[] args)
        {

            List<string> nombres = new List<string>() { "Paulo Enrique", "Luisa Fernanda" };

            int j = 0;

            //while (j<nombres.Count)
            while (true)
            {

                Console.WriteLine(j);

                j++;

                Console.WriteLine("Presione la tecla 'C' si quiere cancelar");

                var respuestaUsuario = Console.ReadLine();

                if(respuestaUsuario.ToUpper() == "C")
                {
                    break;
                }

            }

            Console.Read();

        }
    }
}
