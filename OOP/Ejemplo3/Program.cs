using System;

namespace Ejemplo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EL mundo Animal!");

            Console.WriteLine("Ingrese el tipo de Animal: ");
            String tipoAnimal = Console.ReadLine();

            Console.WriteLine("Ingrese la raza del Animal: ");
            String raza = Console.ReadLine();

            Console.WriteLine("Ingrese la edad del Animal: ");
            int edad = int.Parse(Console.ReadLine());

          /*   Console.WriteLine("Ingrese el tipo de entrenamiento: ");
            String TipoEntrenamiento = Console.ReadLine(); */

            /* Console.WriteLine("Tiene reflejo? (Si/No): ");
            String Reflejo = Console.ReadLine(); */


            //Instanciar la clase AnimalDomestico
            /* AnimalDomestico animal1 = new AnimalDomestico(){

                TipoAnimal = tipoAnimal,
                Raza = raza,
                Edad = edad,

            }; */

            //Para acceder a una propiedad exclusiva de Perro, debo usar el tipo Perro.
            //No sirve usar AnimalDomestico. (private)
            Perro perro = new Perro(){

                TipoAnimal = tipoAnimal,
                Raza = raza,
                Edad = edad,
                
            };

            Gato gato = new Gato(){

                TipoAnimal = tipoAnimal,
                Raza = raza,
                Edad = edad,

            };

            //Usar la instancia perro para acceder a los atributos e imprimirlos
            /* Console.WriteLine($"El tipo de animal es: {animal1.TipoAnimal}");
            
            Console.WriteLine($"La raza del animal es: {animal1.Raza}");

            Console.WriteLine($"La edad del animal es: {animal1.Edad}");

            animal1.comer(); */

            /* perro.mostrarTipoEntrenamiento(TipoEntrenamiento);

            Console.WriteLine($"{perro.TipoAnimal} {perro.Raza}");

            Console.WriteLine(perro.sonido()); */
            
            //perro.comer();

            Console.WriteLine($"{gato.TipoAnimal} {gato.Raza}");

            Console.WriteLine(gato.sonido());

        }
    }
}
