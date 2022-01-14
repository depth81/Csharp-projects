using System;

namespace Ejemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("I am a great C# programmer!");

            Console.WriteLine("Ingrese el primer número: ");
            int numero1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());

            //var miOperacion = new Operacion();
            Operaciones miOperacion = new Operaciones(){
                num1 = numero1,
                num2 = numero2
            };

            //Verificar el valor que tiene la propiedad
            //Console.WriteLine(miOperacion.num1);

            //miOperacion.muestraSuma(miOperacion.num1, miOperacion.num2);
            //miOperacion.muestraSuma(miOperacion.num1, 9);

            miOperacion.ImprimirSuma();

            

            

        }
    }

}
