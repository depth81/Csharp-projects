using System;

namespace Ejemplo1
{
    class Operaciones{

        //Atributos o propiedades.
        public int num1 {get; set;}

        /* 
           public: Modificador de acceso 
           int: Tipo de dato.
           num1: Nombre de la propiedad (atributo).
           get: Método para entregar el valor de la propiedad.
           set: Método para recibir datos.
        */

        public int num2 {get; set;}

        /* Métodos o funciones */

        public int calcularSuma(int num1, int num2){
            int suma = 0;
            suma = num1 + num2;
            return suma;
           
        }

        public void ImprimirSuma(){
            System.Console.WriteLine($"La suma es: {calcularSuma(num1,num2)}");
        }
       
       // Console.WriteLine($"La suma de {num1} y {num2} es {suma}");

    }
}