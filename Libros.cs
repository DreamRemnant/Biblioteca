using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal static class Libros
    {
        private static List<Libro> librosRegistrados = new List<Libro>();

        public static void AgregarLibro(Libro libro)
        {
            librosRegistrados.Add(libro);
            Console.WriteLine("!Libro registrado correctamente!");
        }

        public static void ModificarLibro(Libro libroMod)
        {
            if (librosRegistrados.Contains(libroMod)) 
            {
                Console.WriteLine($"Se encontró el libro especificado. {librosRegistrados.FindIndex(libro => libroMod.Equals(libro))}");
            }
        }

        public static void EliminarLibro(long isbn)
        {
            librosRegistrados.Remove(ObtenerPorISBN(isbn));
        }

        public static void EliminarLibro(Libro libro)
        {
            librosRegistrados.Remove(libro);
        }

        public static List<Libro> ObtenerPorTitulo(string titulo)
        {
            List<Libro> librosRet = new List<Libro>();
            foreach (Libro libro in librosRegistrados)
            {
                if (libro.Titulo == titulo)
                {
                    librosRet.Add(libro);
                }
            }

            if (librosRet.Count == 0)
            {
                 throw new Exception($"No se encontró ningun libro con el título: {titulo}.");
            }

            return librosRet;
        }

        public static Libro ObtenerPorISBN(long isbn)
        {
            foreach (Libro libro in librosRegistrados)
            {
                if (libro.ISBN == isbn)
                {
                    return libro;
                }
            }

            throw new Exception($"No se encontró el libro con ISBN {isbn}");
        }


    }
}
