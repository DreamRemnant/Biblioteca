using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Bibliotecario : Persona
    {
        override
        public void Menu ()
        {
            Console.WriteLine("Menú Bibliotecario");
        }

        public void NuevoLibro()
        {
            String titulo = "";
            String autor = "";
            long isbn = 0;
            Libro nuevoLibro = new Libro("Título", "Autor", 12312312312312312);

            Console.WriteLine("Ingrese el título del nuevo libro: ");
            titulo = Console.ReadLine();

            Console.WriteLine("Ingrese el nombre o pseudónimo del autor: ");
            autor = Console.ReadLine();

            Console.WriteLine("Ingrese el código ISBN del libro (Solamente números): ");
            CodigoISBN:
            try
            {
                isbn = long.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Solo se aceptan números para codigo ISBN. Favor de ingresar de nuevo.: ");
                goto CodigoISBN;
            }
        }
    }
}
