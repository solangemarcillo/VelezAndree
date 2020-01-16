using System;
using System.Collections.Generic;
using System.Text;

namespace PatronSingleton
{
    public class Singleton
    {
        //Se crea una propiedad privada con un valor de null
        private static Singleton instancia=null;

        //Creas un metodo Estatico De la clase el cual tenfra un get y despues ahara un recorrido con el " if " el cual pregunta
        // si instancia es igaul que null y el verificara en la variable instancia el cual tiene como valor el "new con el constructor dela clases"
        public static Singleton Instancia
        {
            get 
            {
                if (instancia == null)
                {
                    instancia = new Singleton();
                }
                return instancia;
            }
            
        }
        public String Titulo = "";


        //Este es el constructor con una variable que tiene como valor un mesanje de "Patrones"
        public Singleton()
        {
            Titulo = "Patrones";
        }
    }
}
