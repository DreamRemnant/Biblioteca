using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Usuarios
    {
        static List<Persona> Personas = new List<Persona>();

        public Persona ObtenerPorUsername (string username)
        {
            foreach (Persona usuario in Personas)
            {
                if (usuario.Username == username)
                {
                    return usuario;
                }
            }

            throw new Exception("No se encontró un usuario con ese Username.");
        }

        public Persona ObtenerPorNombre(string nombre)
        {
            foreach (Persona usuario in Usuarios)
            {
                if (usuario.Nombre == nombre)
                {
                    return usuario;
                }
            }

            throw new Exception("No se encontró un usuario con ese Username.");
        }
    }
}
