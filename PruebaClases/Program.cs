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
            Console.WriteLine();
            Usuario fermin = new Usuario();
            fermin.getNombre();
            fermin.getEmail();
            Console.ReadKey();
        }
    }

    class Usuario
    {
        public string Nombre;
        public string Email;

        public Usuario()
        {
            Nombre = "Fermin";
            Email = "fermin@microsoft.com";
        }

        public void getNombre()
        {
            Console.WriteLine( "Mi nombre es {0}", Nombre);
        }
        public void getEmail()
        {
            Console.WriteLine("Mi email es {0}", Email);
        }

    }
}
