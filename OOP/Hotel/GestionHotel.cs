using System;

namespace EJemplo2{
    
    class GestionHotel{
        public string habitacion {get; set;}
        public int huesped {get; set;}
        //public int dias {get; set;}

        int Dias; //Variable interna.

        public int dias{
            get {return Dias;}

            set
            {

                if(value >= 1){
                    Dias = value;
                }else{
                    System.Console.WriteLine("Cantidad mínima de días es uno");
                }

            }


        }


        //Métodos
        public int valorEstadia(int huesped, int cantidad){
            int TINDIVIDUAL = 2500;
            int TDOBLE = 4600;
            int TFAMILIAR = 5200;

            int cobro = 0; 

            if(huesped==1){     
                cobro = cantidad * TINDIVIDUAL;
            }else{
                if(huesped==2){
                    cobro = cantidad * TDOBLE;
                }
                else{
                    if (huesped >= 3){
                        cobro = cantidad * TFAMILIAR;
                    }else{

                    }
                }

            }
        
        return cobro;
        
        }

        public void cuentaCobro(){

            int IVA = 19;

            int precioSinIva = 0;

            int precioConIva = 0;

            precioSinIva = valorEstadia(huesped, dias);

            precioConIva = ((precioSinIva * IVA) / 100) + precioSinIva;

            Console.WriteLine(precioConIva);
        }

    }
}