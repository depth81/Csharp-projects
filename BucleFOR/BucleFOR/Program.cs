using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BucleFOR
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> nombres = new List<string>() { "Felipe", "Juana", "Leonardo", "Diana", "Monique", "Paulo Enrique" };

            //Console.WriteLine(nombres.Count);

            //Console.WriteLine(nombres[0].ToUpper());

            for (int i = 0; i < nombres.Count; i++)
            {

                Console.WriteLine(nombres[i].ToUpper());

            }

            Console.Read();

        }
    }
}
