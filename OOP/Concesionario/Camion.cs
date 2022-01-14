using System;

namespace Concesionario
{
    class Camion : Vehiculo
    {
        //Propiedades especificas de camion
        string tipoR;
        public string Remolque {
            get { return tipoR; }
            set {
                //string tipoRemolque = value;
                switch (value.ToLower())
                {
                    case "camabaja":
                        tipoR = value;
                        break;
                    case "estacas":
                        tipoR = value;
                        break;
                    case "contenedor":
                        tipoR = value;
                        break;
                    case "planchon":
                        tipoR = value;
                        break;
                    case "ninera":
                        tipoR = value;
                        break;
                    case "cisterna":
                        tipoR = value;
                        break;
                    default:
                        Console.WriteLine($"Remolque no existe, por favor verificar");
                        break;
                }
            }
        }

        //Metodos
        public void mostrarDatos()
        {
            Console.WriteLine(Serie);
        }

        public string listarRuta()
        {
            return Ruta.ToString();
        }
    }
}