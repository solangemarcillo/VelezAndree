using System;

namespace PatronSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aqui se llama a la clase  singlenton mas la varible  que es "Instancia" mas la variable 
            //"Titulo" que esta en el constructor de la clases singlento
            Console.WriteLine(Singleton.Instancia.Titulo);

            Singleton.Instancia.Titulo = "Patrones de diseño";
            Console.WriteLine(Singleton.Instancia.Titulo);

            Singleton.Instancia.Titulo = "Patron Singleton";
            Console.WriteLine(Singleton.Instancia.Titulo);
        }
    }
}