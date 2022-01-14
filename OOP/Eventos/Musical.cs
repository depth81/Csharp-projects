using System;

namespace Eventos{

    class Musical : Evento{

        //Propiedades específicas a un evento musical.
        public string InstrumentoMusical {get; set;}
        public string Cancion {get; set;}

        public void EjecutarInstrumento(string instrumento){

            InstrumentoMusical = instrumento;

            Console.WriteLine($"Tocando el instrumento {InstrumentoMusical}");

        }

        public string CantarCancion(){

            return $"Estamos cantando la canción {Cancion}";

        }

    }

}