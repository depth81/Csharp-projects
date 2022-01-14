using System;

namespace Eventos{

    class Religioso : Evento{

        //Propiedades específicas a un evento religioso.
        public string Oracion {get; set;}
        public string Cancion { get; set; }

        //Métodos
        public void Orando(string oracion){

            Oracion = oracion;

            Console.WriteLine($"Estamos orando así: {Oracion}");

        }

        public string CantarCancion(){

            return $"Aleluya! estamos alabando con la canción {Cancion}";

        }
    }

}