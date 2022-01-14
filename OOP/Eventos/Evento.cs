using System;

namespace Eventos{

    //Clase PADRE.
    class Evento{

        //Propiedades o características generales de todo evento.
        
        public string TipoEvento { get; set; }
        public int Aforo { get; set; }
        public string Ubicacion { get; set; }
        public string Presentador { get; set; }

        public string dimeTipoEvento(){

            return TipoEvento;

        }
        public void Publicitar(){

            Console.WriteLine($"Publicitando el evento...");

        }

        public void HacerMontaje(){

            Console.WriteLine($"Haciendo el montaje del evento...");

        }

        public void Transmitir(){

            Console.WriteLine($"Transmitiendo en vivo...");

        }

        public void Desmontar(){

            Console.WriteLine($"Desmontando el evento...");

        }


    }

}