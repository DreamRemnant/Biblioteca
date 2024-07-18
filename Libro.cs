using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Libro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int ISBN { get; set; }
        public bool Estado { get; set; }

        public Libro(string Titulo, string Autor, int ISBN)
        {
            this.Titulo = Titulo;
            this.Autor = Autor;
            this.ISBN = ISBN;
            Estado = false;
        }
    }
}
