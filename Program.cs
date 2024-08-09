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
            defaultData();

            Console.WriteLine("" +
                "=============== BIBLIOTECA ==============="
                "Bienvenido al sistema de bibilioteca." +
                "Eliga una opción del menú:\n" +
                "1. Iniciar sesión.\n" +
                "2. Registrarse\n" +
                "3. Salir");
            //TODO Avanzar desde aquí

            Console.ReadKey();
        }

        private static void defaultData()
        {
            Libros.AgregarLibro(new Libro("Orgullo y Prejuicio", "Jane Austen", 9788483431078));
            Libros.AgregarLibro(new Libro("Don Quijote de la Mancha", "Miguel de Servantes", 9788481093353));
            Libros.AgregarLibro(new Libro("El fantasma de la Opera", "Gastón Leroux", 9781421806242));
        }
    }
}
