using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Program
    {
        static List<Persona> usuarios = new List<Persona>();
        static List<Libro> libros = new List<Libro>();
        static void Main(string[] args)
        {
            Libros.AgregarLibro(new Libro("Orgullo y Prejuicio", "Jane Austen", 9788483431078));
            Libros.AgregarLibro(new Libro("Don Quijote de la Mancha", "Miguel de Servantes", 9788481093353));
            Libros.AgregarLibro(new Libro("El fantasma de la Opera", "Gastón Leroux", 9781421806242));
            Libro libro = Libros.ObtenerPorISBN(9788481093353);
            Console.WriteLine($"{libro.Titulo}, {libro.Autor}, {libro.ISBN}");
            libro.Autor = "Roberto Gomez Bolaños";
            Libros.ModificarLibro(libro);
            Console.ReadKey();
        }
    }
}
