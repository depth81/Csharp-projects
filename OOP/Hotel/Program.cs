using System;

namespace EJemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cantidad de huespedes: ");
            int huespedes = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Días de estadía: ");
            int dias = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Nombre de la habitación: ");
            string nombreHab = Console.ReadLine();

            //Instancia
            var hotelUno = new GestionHotel(){

                habitacion =  nombreHab,
                huesped = huespedes,
                dias = dias

            };

            hotelUno.cuentaCobro();
        }
    }
}
