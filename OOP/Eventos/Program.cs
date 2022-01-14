using System;

namespace Eventos
{
    class Program
    {
        static void Main(string[] args)
        {
 
            Console.WriteLine("***EVENTOS***");

            Console.WriteLine("Ingrese el tipo de Evento: ");
            String tipoEvento = Console.ReadLine();

            Console.WriteLine("Ingrese la ubicación geográfica del evento: ");
            String ubicacion = Console.ReadLine();

            Console.WriteLine("Ingrese el nombre del presentador: ");
            String presentador = Console.ReadLine();

            Console.WriteLine("Indique el aforo: ");
            int aforo = int.Parse(Console.ReadLine());

            Console.WriteLine("Indique el nombre de la cancion a interpretar: ");
            String cancion = Console.ReadLine();

            Console.WriteLine("Indique la oración para decir: ");
            String oracion = Console.ReadLine();

            /* Console.WriteLine("Indique el instrumento musical a ejecutar: ");
            String instrumento = Console.ReadLine(); */

            //Instanciar los objetos respectivos.

            /* Evento evento1 = new Evento(){

                TipoEvento = tipoEvento,
                Ubicacion = ubicacion,
                Presentador = presentador,
                Aforo = aforo

            };

            //Usar las propiedades y métodos.

            Console.WriteLine(evento1.dimeTipoEvento());

            evento1.Publicitar();

            evento1.HacerMontaje();

            evento1.Transmitir();

            evento1.Desmontar();
             */
            
            /* Musical concierto1 = new Musical(){

                TipoEvento = tipoEvento,
                Ubicacion = ubicacion,
                Aforo = aforo,
                Presentador = presentador,
                InstrumentoMusical = instrumento,
                Cancion = cancion

            };

            //Usar las propiedades y métodos.

            concierto1.dimeTipoEvento();

            concierto1.EjecutarInstrumento(instrumento);

            Console.WriteLine(concierto1.CantarCancion()); 

            Console.WriteLine($" Hay {concierto1.Aforo} especatores!!!!"); */

            Religioso alabanza1 = new Religioso(){

                TipoEvento = tipoEvento,
                Ubicacion = ubicacion,
                Aforo = aforo,
                Presentador = presentador,
                Oracion = oracion,
                Cancion = cancion

            }; 

            //Usar los métodos y propiedades.

            Console.WriteLine($"Estamos en un evento de tipo {alabanza1.dimeTipoEvento()}");

            Console.WriteLine(alabanza1.CantarCancion());

            alabanza1.Orando(oracion);

            Console.WriteLine($"El presentador del evento es {alabanza1.Presentador}");

            Console.WriteLine($"Hay {alabanza1.Aforo} fieles congregados");

            Console.WriteLine($"El lugar de congregacion es {alabanza1.Ubicacion}");

        }
    }
}
