using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fechas
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime fecha = new DateTime(2020, 11, 24);
            DateTime fechaConHora = new DateTime(1899, 4, 22, 9, 30, 45);

            Console.WriteLine(fecha.ToString());
            Console.WriteLine(fecha.ToString("MM/dd/yyyy"));
            Console.WriteLine(fecha.ToString("dd-MM-yy"));
            Console.WriteLine(fechaConHora.ToString("dd/MM/yyyy hh:mm:ss"));
            Console.WriteLine(fecha.AddDays(45).ToString());
            Console.WriteLine(fechaConHora.DayOfWeek);
            Console.WriteLine(fechaConHora.Date);
            Console.WriteLine(fecha.Subtract(fechaConHora).Days); 
            Console.Read();

        }
    }
}
