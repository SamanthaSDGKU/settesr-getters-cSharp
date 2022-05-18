using System;

namespace ConsoleApp2 // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie vida = new Movie("La vita e bella", "Roberto", "PG");
            Movie devoluciones = new Movie("No se aceptan devoluciones", "Eugenio", "Dog");

            //rating = PG,G,PG-13
            
            Console.WriteLine(devoluciones.Rating);
            Console.ReadKey();

        }
    }
}
