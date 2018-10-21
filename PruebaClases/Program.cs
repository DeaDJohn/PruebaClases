using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaClases
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mensajes de bienvenida
            Console.WriteLine(" Bienvenido a Jotagochi");
            Console.WriteLine(" Introduzca el nombre de su Jotagochi");
            // Nombre del Jotagochi del usuario
            string nombreJotagochi = Console.ReadLine();
            // Creamos el objeto Jotagochi.
            Jotagochi gochi = new Jotagochi(nombreJotagochi);
            Console.WriteLine("Tu Jotagochi se llama {0}",gochi.Nombre);
            Console.WriteLine("Y tiene una vida de {0}%", gochi.Vida);
            // Iniciamos el juego
            gochi.GochiJuego(gochi.Vida);
            Console.ReadKey();
        }


    }

    class Jotagochi
    {
        public string Nombre { get; set; }
        public int Vida { get; set; }
        // Variables para el futuro
        //public int Comida;
        //public int Hambre;

        // Constructor de Jotagochi
        public Jotagochi(string nombre)
        {
            this.Vida = 100;
            this.Nombre = nombre;
        }
        // Metodo que devuelve el mensaje de juego fin
        public void GochiMuerto()
        {
            Console.WriteLine("Tu gochi a muerto!!!!");
        }

        public void GochiJuego( int Vida )
        {
            // Aciones posibles jugar o comer
            Console.WriteLine("Quieres jugar o comer?");
            string accion = Console.ReadLine();
            if( accion == "jugar")
            {
                // si juega restamos 5 de vida
                Vida = Vida - 5;
            }
            else if ( accion == "comer")
            {
                // si come sumamos 5 de vida
                Vida = Vida + 5;
            }
            else
            {
                // No pone la accion correcta
                Console.WriteLine("Escribe jugar o comer");
            }

            Console.WriteLine("Tu vida es {0}", Vida);
            
            if (Vida >= 0)
            {
                GochiJuego(Vida);
            }
            else
            {
                GochiMuerto();
            }

        }

        

    }
}
